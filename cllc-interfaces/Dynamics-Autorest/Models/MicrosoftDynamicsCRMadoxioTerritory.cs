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

    public partial class MicrosoftDynamicsCRMadoxioTerritory
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioTerritory class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioTerritory()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioTerritory class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioTerritory(string _adoxioPrimaryinspectorValue = default(string), string _adoxioRegionValue = default(string), string _createdbyValue = default(string), string _createdonbehalfbyValue = default(string), string _modifiedbyValue = default(string), string _modifiedonbehalfbyValue = default(string), string _owneridValue = default(string), string _owningbusinessunitValue = default(string), string _owningteamValue = default(string), string _owninguserValue = default(string), MicrosoftDynamicsCRMsystemuser adoxioPrimaryInspector = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMadoxioRegion adoxioRegion = default(MicrosoftDynamicsCRMadoxioRegion), IList<MicrosoftDynamicsCRMaccount> adoxioAdoxioTerritoryAccountTerritory = default(IList<MicrosoftDynamicsCRMaccount>), IList<MicrosoftDynamicsCRMadoxioApplication> adoxioAdoxioTerritoryAdoxioApplication = default(IList<MicrosoftDynamicsCRMadoxioApplication>), IList<MicrosoftDynamicsCRMadoxioComplaint> adoxioAdoxioTerritoryAdoxioComplaintTerritory = default(IList<MicrosoftDynamicsCRMadoxioComplaint>), IList<MicrosoftDynamicsCRMadoxioEstablishment> adoxioAdoxioTerritoryAdoxioEstablishmentTerritory = default(IList<MicrosoftDynamicsCRMadoxioEstablishment>), IList<MicrosoftDynamicsCRMadoxioLicences> adoxioAdoxioTerritoryAdoxioLicencesTerritory = default(IList<MicrosoftDynamicsCRMadoxioLicences>), IList<MicrosoftDynamicsCRMadoxioPostalcode> adoxioAdoxioTerritoryAdoxioPostalcodeTerritory = default(IList<MicrosoftDynamicsCRMadoxioPostalcode>), IList<MicrosoftDynamicsCRMincident> adoxioAdoxioTerritoryIncidentTerritory = default(IList<MicrosoftDynamicsCRMincident>), string adoxioName = default(string), IList<MicrosoftDynamicsCRMasyncoperation> adoxioTerritoryAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioTerritoryBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioTerritoryDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioTerritoryDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMsyncerror> adoxioTerritorySyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), string adoxioTerritoryid = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), int? importsequencenumber = default(int?), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), int? statecode = default(int?), int? statuscode = default(int?), int? timezoneruleversionnumber = default(int?), int? utcconversiontimezonecode = default(int?), object versionnumber = default(object))
        {
            this._adoxioPrimaryinspectorValue = _adoxioPrimaryinspectorValue;
            this._adoxioRegionValue = _adoxioRegionValue;
            this._createdbyValue = _createdbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._owneridValue = _owneridValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._owningteamValue = _owningteamValue;
            this._owninguserValue = _owninguserValue;
            AdoxioPrimaryInspector = adoxioPrimaryInspector;
            AdoxioRegion = adoxioRegion;
            AdoxioAdoxioTerritoryAccountTerritory = adoxioAdoxioTerritoryAccountTerritory;
            AdoxioAdoxioTerritoryAdoxioApplication = adoxioAdoxioTerritoryAdoxioApplication;
            AdoxioAdoxioTerritoryAdoxioComplaintTerritory = adoxioAdoxioTerritoryAdoxioComplaintTerritory;
            AdoxioAdoxioTerritoryAdoxioEstablishmentTerritory = adoxioAdoxioTerritoryAdoxioEstablishmentTerritory;
            AdoxioAdoxioTerritoryAdoxioLicencesTerritory = adoxioAdoxioTerritoryAdoxioLicencesTerritory;
            AdoxioAdoxioTerritoryAdoxioPostalcodeTerritory = adoxioAdoxioTerritoryAdoxioPostalcodeTerritory;
            AdoxioAdoxioTerritoryIncidentTerritory = adoxioAdoxioTerritoryIncidentTerritory;
            AdoxioName = adoxioName;
            AdoxioTerritoryAsyncOperations = adoxioTerritoryAsyncOperations;
            AdoxioTerritoryBulkDeleteFailures = adoxioTerritoryBulkDeleteFailures;
            AdoxioTerritoryDuplicateBaseRecord = adoxioTerritoryDuplicateBaseRecord;
            AdoxioTerritoryDuplicateMatchingRecord = adoxioTerritoryDuplicateMatchingRecord;
            AdoxioTerritorySyncErrors = adoxioTerritorySyncErrors;
            AdoxioTerritoryid = adoxioTerritoryid;
            Createdbyname = createdbyname;
            Createdon = createdon;
            Createdonbehalfbyname = createdonbehalfbyname;
            Importsequencenumber = importsequencenumber;
            Modifiedbyname = modifiedbyname;
            Modifiedon = modifiedon;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Overriddencreatedon = overriddencreatedon;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            Owningteam = owningteam;
            Owninguser = owninguser;
            Statecode = statecode;
            Statuscode = statuscode;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Versionnumber = versionnumber;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_primaryinspector_value")]
        public string _adoxioPrimaryinspectorValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_region_value")]
        public string _adoxioRegionValue { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_PrimaryInspector")]
        public MicrosoftDynamicsCRMsystemuser AdoxioPrimaryInspector { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_Region")]
        public MicrosoftDynamicsCRMadoxioRegion AdoxioRegion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_adoxio_territory_account_Territory")]
        public IList<MicrosoftDynamicsCRMaccount> AdoxioAdoxioTerritoryAccountTerritory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_adoxio_territory_adoxio_application")]
        public IList<MicrosoftDynamicsCRMadoxioApplication> AdoxioAdoxioTerritoryAdoxioApplication { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_adoxio_territory_adoxio_complaint_Territory")]
        public IList<MicrosoftDynamicsCRMadoxioComplaint> AdoxioAdoxioTerritoryAdoxioComplaintTerritory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_adoxio_territory_adoxio_establishment_Territory")]
        public IList<MicrosoftDynamicsCRMadoxioEstablishment> AdoxioAdoxioTerritoryAdoxioEstablishmentTerritory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_adoxio_territory_adoxio_licences_Territory")]
        public IList<MicrosoftDynamicsCRMadoxioLicences> AdoxioAdoxioTerritoryAdoxioLicencesTerritory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_adoxio_territory_adoxio_postalcode_Territory")]
        public IList<MicrosoftDynamicsCRMadoxioPostalcode> AdoxioAdoxioTerritoryAdoxioPostalcodeTerritory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_adoxio_territory_incident_Territory")]
        public IList<MicrosoftDynamicsCRMincident> AdoxioAdoxioTerritoryIncidentTerritory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_territory_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioTerritoryAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_territory_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioTerritoryBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_territory_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioTerritoryDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_territory_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioTerritoryDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_territory_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioTerritorySyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_territoryid")]
        public string AdoxioTerritoryid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

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
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public object Versionnumber { get; set; }

    }
}
