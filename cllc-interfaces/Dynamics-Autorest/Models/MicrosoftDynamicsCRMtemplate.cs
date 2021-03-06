// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class MicrosoftDynamicsCRMtemplate
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMtemplate
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMtemplate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMtemplate
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMtemplate(IList<MicrosoftDynamicsCRMemail> emailEmailTemplate = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMasyncoperation> templateAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> templateBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMorganization> templateOrganization = default(IList<MicrosoftDynamicsCRMorganization>), IList<MicrosoftDynamicsCRMsyncerror> templateSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), string _createdbyValue = default(string), string _createdonbehalfbyValue = default(string), string _modifiedbyValue = default(string), string _modifiedonbehalfbyValue = default(string), string _owneridValue = default(string), string _owningbusinessunitValue = default(string), string _owningteamValue = default(string), string _owninguserValue = default(string), string body = default(string), int? componentstate = default(int?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), string description = default(string), int? generationtypecode = default(int?), int? importsequencenumber = default(int?), string introducedversion = default(string), MicrosoftDynamicsCRMBooleanManagedProperty iscustomizable = default(MicrosoftDynamicsCRMBooleanManagedProperty), bool? ismanaged = default(bool?), bool? ispersonal = default(bool?), bool? isrecommended = default(bool?), int? languagecode = default(int?), string mimetype = default(string), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), int? opencount = default(int?), int? openrate = default(int?), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), string presentationxml = default(string), int? replycount = default(int?), int? replyrate = default(int?), string solutionid = default(string), string subject = default(string), string subjectpresentationxml = default(string), IList<MicrosoftDynamicsCRMactivitymimeattachment> templateActivityMimeAttachments = default(IList<MicrosoftDynamicsCRMactivitymimeattachment>), string templateid = default(string), string templateidunique = default(string), string templatetypecode = default(string), string title = default(string), int? usedcount = default(int?), object versionnumber = default(object))
        {
            EmailEmailTemplate = emailEmailTemplate;
            TemplateAsyncOperations = templateAsyncOperations;
            TemplateBulkDeleteFailures = templateBulkDeleteFailures;
            TemplateOrganization = templateOrganization;
            TemplateSyncErrors = templateSyncErrors;
            this._createdbyValue = _createdbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._owneridValue = _owneridValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._owningteamValue = _owningteamValue;
            this._owninguserValue = _owninguserValue;
            Body = body;
            Componentstate = componentstate;
            Createdby = createdby;
            Createdon = createdon;
            Createdonbehalfby = createdonbehalfby;
            Description = description;
            Generationtypecode = generationtypecode;
            Importsequencenumber = importsequencenumber;
            Introducedversion = introducedversion;
            Iscustomizable = iscustomizable;
            Ismanaged = ismanaged;
            Ispersonal = ispersonal;
            Isrecommended = isrecommended;
            Languagecode = languagecode;
            Mimetype = mimetype;
            Modifiedby = modifiedby;
            Modifiedon = modifiedon;
            Modifiedonbehalfby = modifiedonbehalfby;
            Opencount = opencount;
            Openrate = openrate;
            Overwritetime = overwritetime;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            Owningteam = owningteam;
            Owninguser = owninguser;
            Presentationxml = presentationxml;
            Replycount = replycount;
            Replyrate = replyrate;
            Solutionid = solutionid;
            Subject = subject;
            Subjectpresentationxml = subjectpresentationxml;
            TemplateActivityMimeAttachments = templateActivityMimeAttachments;
            Templateid = templateid;
            Templateidunique = templateidunique;
            Templatetypecode = templatetypecode;
            Title = title;
            Usedcount = usedcount;
            Versionnumber = versionnumber;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Email_EmailTemplate")]
        public IList<MicrosoftDynamicsCRMemail> EmailEmailTemplate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Template_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> TemplateAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Template_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> TemplateBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Template_Organization")]
        public IList<MicrosoftDynamicsCRMorganization> TemplateOrganization { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Template_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> TemplateSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "body")]
        public string Body { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "generationtypecode")]
        public int? Generationtypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscustomizable")]
        public MicrosoftDynamicsCRMBooleanManagedProperty Iscustomizable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ispersonal")]
        public bool? Ispersonal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isrecommended")]
        public bool? Isrecommended { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "languagecode")]
        public int? Languagecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mimetype")]
        public string Mimetype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opencount")]
        public int? Opencount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "openrate")]
        public int? Openrate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "presentationxml")]
        public string Presentationxml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "replycount")]
        public int? Replycount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "replyrate")]
        public int? Replyrate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subjectpresentationxml")]
        public string Subjectpresentationxml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "template_activity_mime_attachments")]
        public IList<MicrosoftDynamicsCRMactivitymimeattachment> TemplateActivityMimeAttachments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "templateid")]
        public string Templateid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "templateidunique")]
        public string Templateidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "templatetypecode")]
        public string Templatetypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "usedcount")]
        public int? Usedcount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public object Versionnumber { get; set; }

    }
}
