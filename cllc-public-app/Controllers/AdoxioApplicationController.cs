﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gov.Lclb.Cllb.Public.Authentication;
using Gov.Lclb.Cllb.Interfaces.Microsoft.Dynamics.CRM;
using Gov.Lclb.Cllb.Public.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using Microsoft.OData.Client;
using Newtonsoft.Json;
using Gov.Lclb.Cllb.Interfaces;
using Microsoft.Extensions.Logging;
using Gov.Lclb.Cllb.Interfaces.Models;

namespace Gov.Lclb.Cllb.Public.Controllers
{
    [Route("api/[controller]")]
    public class AdoxioApplicationController : Controller
    {
        private readonly IConfiguration Configuration;
        private readonly Interfaces.Microsoft.Dynamics.CRM.System _system;
        //private readonly IDistributedCache _distributedCache;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly SharePointFileManager _sharePointFileManager;
        private readonly ILogger _logger;
        private readonly IDynamicsClient _dynamicsClient;

        public AdoxioApplicationController(Interfaces.Microsoft.Dynamics.CRM.System context, SharePointFileManager sharePointFileManager, IConfiguration configuration, IDistributedCache distributedCache, IHttpContextAccessor httpContextAccessor, ILoggerFactory loggerFactory, IDynamicsClient dynamicsClient)
        {
            Configuration = configuration;
            this._system = context;
            this._httpContextAccessor = httpContextAccessor;
            this._sharePointFileManager = sharePointFileManager;
            //this._distributedCache = null;
            this._dynamicsClient = dynamicsClient;
            _logger = loggerFactory.CreateLogger(typeof(AdoxioLegalEntityController));                    
        }

        /// <summary>
        /// Get a license application by applicant id
        /// </summary>
        /// <param name="applicantId"></param>
        /// <returns></returns>
        private async Task<List<ViewModels.AdoxioApplication>> GetApplicationsByApplicant(string applicantId)
        {
            List<ViewModels.AdoxioApplication> result = new List<ViewModels.AdoxioApplication>();
            IEnumerable<MicrosoftDynamicsCRMadoxioApplication> dynamicsApplicationList = null;
            if (string.IsNullOrEmpty (applicantId))
            {
                dynamicsApplicationList = _dynamicsClient.Applications.Get().Value;
            }
            else
            {
                dynamicsApplicationList = _dynamicsClient.Applications.Get(filter:"_adoxio_applicant_value eq " + applicantId).Value;
            }

            if (dynamicsApplicationList != null)
            {
                foreach (MicrosoftDynamicsCRMadoxioApplication dynamicsApplication in dynamicsApplicationList)
                {
                    result.Add(await dynamicsApplication.ToViewModel(_dynamicsClient));
                }
            }
            return result;
        }

        /// <summary>
        /// GET all applications in Dynamics. Optional parameter for applicant ID. Or all applications if the applicantId is null
        /// </summary>
        /// <param name="applicantId"></param>
        /// <returns></returns>
        [HttpGet()]
        public async Task<JsonResult> GetDynamicsApplications (string applicantId)
        {
            List<ViewModels.AdoxioApplication> adoxioApplications = await GetApplicationsByApplicant(applicantId);
            return Json(adoxioApplications);
        }

        /// GET all applications in Dynamics for the current user
        [HttpGet("current")]
        public async Task<JsonResult> GetCurrentUserDyanamicsApplications()
        {
            // get the current user.
            string temp = _httpContextAccessor.HttpContext.Session.GetString("UserSettings");
            UserSettings userSettings = JsonConvert.DeserializeObject<UserSettings>(temp);

            // GET all applications in Dynamics by applicant using the account Id assigned to the user logged in
            List<ViewModels.AdoxioApplication> adoxioApplications = await GetApplicationsByApplicant(userSettings.AccountId);
            return Json(adoxioApplications);
        }

        /// <summary>
        /// GET an Application by ID
        /// </summary>
        /// <param name="id">GUID of the Application to get</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDynamicsApplication(string id)
        {
			// get the current user.
            string temp = _httpContextAccessor.HttpContext.Session.GetString("UserSettings");
            UserSettings userSettings = JsonConvert.DeserializeObject<UserSettings>(temp);

			_logger.LogError("Application id = " + id);
			_logger.LogError("User id = " + userSettings.AccountId);

			ViewModels.AdoxioApplication result = null;
            var dynamicsApplication = await _dynamicsClient.GetApplicationById(Guid.Parse(id));
            if (dynamicsApplication == null)
            {
                return NotFound();
            }
            else
            {
				if (!CurrentUserHasAccessToApplicationOwnedBy(dynamicsApplication._adoxioApplicantValue))
                {
                    return new NotFoundResult();
                }
                result = await dynamicsApplication.ToViewModel(_dynamicsClient);
            }

            return Json(result);
        }

        /// <summary>
        /// Create an Application in Dynamics (POST)
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpPost()]
		public async Task<IActionResult> CreateApplication([FromBody] ViewModels.AdoxioApplication item)
        {			

			// for association with current user
            string userJson = _httpContextAccessor.HttpContext.Session.GetString("UserSettings");
			UserSettings userSettings = JsonConvert.DeserializeObject<UserSettings>(userJson);			
            MicrosoftDynamicsCRMadoxioApplication adoxioApplication = new MicrosoftDynamicsCRMadoxioApplication();
            
            // copy received values to Dynamics Application
			adoxioApplication.CopyValues(item);
            adoxioApplication.AdoxioApplicanttype = (int?)item.applicantType;
            try
            {
                adoxioApplication = _dynamicsClient.Applications.Create(adoxioApplication);
            }
            catch (OdataerrorException odee)
            {
                _logger.LogError("Error creating application");
                _logger.LogError("Request:");
                _logger.LogError(odee.Request.Content);
                _logger.LogError("Response:");
                _logger.LogError(odee.Response.Content);
                // fail if we can't create.
                throw (odee);
            }

            MicrosoftDynamicsCRMadoxioApplication patchAdoxioApplication = new MicrosoftDynamicsCRMadoxioApplication();

            // set license type relationship

            var adoxioLicencetype = _dynamicsClient.GetAdoxioLicencetypeByName(item.licenseType).Result;
            patchAdoxioApplication.AdoxioLicenceTypeODataBind = _dynamicsClient.GetEntityURI("adoxio_licencetypes", adoxioLicencetype.AdoxioLicencetypeid); ;
            patchAdoxioApplication.AdoxioApplicantODataBind = _dynamicsClient.GetEntityURI("adoxio_applications", userSettings.AccountId);
            try
            {
               _dynamicsClient.Applications.Update(adoxioApplication.AdoxioApplicationid, patchAdoxioApplication);
            }
            catch (OdataerrorException odee)
            {
                _logger.LogError("Error updating application");
                _logger.LogError("Request:");
                _logger.LogError(odee.Request.Content);
                _logger.LogError("Response:");
                _logger.LogError(odee.Response.Content);
                // fail if we can't create.
                throw (odee);
            }
            return Json(await adoxioApplication.ToViewModel(_dynamicsClient));
            
        }

        /// <summary>
        /// Update a Dynamics Application (PUT)
        /// </summary>
        /// <param name="item"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateApplication([FromBody] ViewModels.AdoxioApplication item, string id)
        {
            if (id != item.id)
            {
                return BadRequest();
            }

			// for association with current user
            string userJson = _httpContextAccessor.HttpContext.Session.GetString("UserSettings");
            UserSettings userSettings = JsonConvert.DeserializeObject<UserSettings>(userJson);
            

			//Prepare application for update
            Guid adoxio_applicationId = new Guid(id);
            MicrosoftDynamicsCRMadoxioApplication adoxioApplication = await _dynamicsClient.GetApplicationById(adoxio_applicationId);

			if (!CurrentUserHasAccessToApplicationOwnedBy(adoxioApplication._adoxioApplicantValue))
			{
				return new NotFoundResult();
			}
            

            adoxioApplication = new MicrosoftDynamicsCRMadoxioApplication();

			adoxioApplication.CopyValues(item);

            try
            {
                _dynamicsClient.Applications.Update(id, adoxioApplication);
            }
            catch (OdataerrorException odee)
            {
                _logger.LogError("Error updating application");
                _logger.LogError("Request:");
                _logger.LogError(odee.Request.Content);
                _logger.LogError("Response:");
                _logger.LogError(odee.Response.Content);
                // fail if we can't create.
                throw (odee);
            }

            adoxioApplication = await _dynamicsClient.GetApplicationById(adoxio_applicationId);

            return Json(await adoxioApplication.ToViewModel(_dynamicsClient));
        }

        /// <summary>
        /// Delete an Application.  Using a HTTP Post to avoid Siteminder issues with DELETE
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost("{id}/delete")]
        public async Task<IActionResult> DeleteApplication(string id)
        {
            // get the application.
            Guid adoxio_applicationid = new Guid(id);

            MicrosoftDynamicsCRMadoxioApplication adoxioApplication = await _dynamicsClient.GetApplicationById(adoxio_applicationid);
            if (adoxioApplication == null)
            {
                return new NotFoundResult();
            }

            if (!CurrentUserHasAccessToApplicationOwnedBy(adoxioApplication._adoxioApplicantValue))
            {
                return new NotFoundResult();
            }


            await _dynamicsClient.Applications.DeleteAsync(adoxio_applicationid.ToString());

            return NoContent(); // 204
        }

        [HttpPost("{id}/attachments")]
        public async Task<IActionResult> UploadFile([FromRoute] string id, [FromForm]IFormFile file, [FromForm] string documentType)
        {
            ViewModels.FileSystemItem result = null;
            // get the LegalEntity.
            // Adoxio_legalentity legalEntity = null;

            // get the current user.
            string temp = _httpContextAccessor.HttpContext.Session.GetString("UserSettings");
            UserSettings userSettings = JsonConvert.DeserializeObject<UserSettings>(temp);
            // check that the session is setup correctly.
            userSettings.Validate();

            if (id != null)
            {
                var applicationId = Guid.Parse(id);
                var application = await _dynamicsClient.GetApplicationById(applicationId);

                if (application == null)
                {
                    return new NotFoundResult();
                }

                string fileName = FileSystemItemExtensions.CombineNameDocumentType(file.FileName, documentType);
                var applicationIdCleaned = application.AdoxioApplicationid.ToString().ToUpper().Replace("-", "");
                // Dynamics code for the name is {Code(Licence Type (Licence Type))} - {Business Type(Application)} - {Job Number(Application)} 
                string folderName = $"{application.AdoxioLicenceType.AdoxioCode} - {application.AdoxioApplicant.AdoxioBusinesstype}_{applicationIdCleaned}";

                try
                {
                    await _sharePointFileManager.AddFile(folderName, fileName, file.OpenReadStream(), file.ContentType);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex.Message);
                    _logger.LogError(ex.StackTrace);
                    return new NotFoundResult();
                }
            }
            return Json(result);
        }

        [HttpGet("{id}/attachments/{fileId}")]
        public async Task<IActionResult> DownloadFile([FromRoute] string id, [FromRoute] string fileId)
        {
            // get the file.
            if (fileId == null)
            {
                return BadRequest();
            }
            else
            {
                _sharePointFileManager.GetFileById(fileId);
            }
            string filename = "";
            byte[] fileContents = new byte[10];
            return new FileContentResult(fileContents, "application/octet-stream")
            {
                FileDownloadName = filename
            };
        }

        /// <summary>
        /// Verify whether currently logged in user has access to this account id
        /// </summary>
        /// <returns>boolean</returns>
        private bool CurrentUserHasAccessToApplicationOwnedBy(string accountId)
        {
            // get the current user.
            string temp = _httpContextAccessor.HttpContext.Session.GetString("UserSettings");
            UserSettings userSettings = JsonConvert.DeserializeObject<UserSettings>(temp);

            // For now, check if the account id matches the user's account.
            // TODO there may be some account relationships in the future
            if (userSettings.AccountId != null && userSettings.AccountId.Length > 0)
            {
				return userSettings.AccountId == accountId;
            }

            // if current user doesn't have an account they are probably not logged in
            return false;
        }
    }
}
