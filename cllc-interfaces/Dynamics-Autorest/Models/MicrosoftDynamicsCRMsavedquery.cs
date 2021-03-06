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

    public partial class MicrosoftDynamicsCRMsavedquery
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMsavedquery
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMsavedquery()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMsavedquery
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMsavedquery(IList<MicrosoftDynamicsCRMasyncoperation> savedQueryAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> savedQueryBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMsyncerror> savedQuerySyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), string _createdbyValue = default(string), string _createdonbehalfbyValue = default(string), string _modifiedbyValue = default(string), string _modifiedonbehalfbyValue = default(string), string _organizationidValue = default(string), string advancedgroupby = default(string), MicrosoftDynamicsCRMBooleanManagedProperty canbedeleted = default(MicrosoftDynamicsCRMBooleanManagedProperty), string columnsetxml = default(string), int? componentstate = default(int?), string conditionalformatting = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), string description = default(string), string fetchxml = default(string), string introducedversion = default(string), bool? iscustom = default(bool?), MicrosoftDynamicsCRMBooleanManagedProperty iscustomizable = default(MicrosoftDynamicsCRMBooleanManagedProperty), bool? isdefault = default(bool?), bool? ismanaged = default(bool?), bool? isquickfindquery = default(bool?), bool? isuserdefined = default(bool?), string layoutxml = default(string), IList<MicrosoftDynamicsCRMmobileofflineprofileitem> lkMobileofflineprofileitemSavedquery = default(IList<MicrosoftDynamicsCRMmobileofflineprofileitem>), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), string name = default(string), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), int? organizationtaborder = default(int?), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), string queryapi = default(string), int? queryappusage = default(int?), int? querytype = default(int?), string returnedtypecode = default(string), string savedqueryid = default(string), string savedqueryidunique = default(string), string solutionid = default(string), int? statecode = default(int?), int? statuscode = default(int?), object versionnumber = default(object))
        {
            SavedQueryAsyncOperations = savedQueryAsyncOperations;
            SavedQueryBulkDeleteFailures = savedQueryBulkDeleteFailures;
            SavedQuerySyncErrors = savedQuerySyncErrors;
            this._createdbyValue = _createdbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._organizationidValue = _organizationidValue;
            Advancedgroupby = advancedgroupby;
            Canbedeleted = canbedeleted;
            Columnsetxml = columnsetxml;
            Componentstate = componentstate;
            Conditionalformatting = conditionalformatting;
            Createdby = createdby;
            Createdon = createdon;
            Createdonbehalfby = createdonbehalfby;
            Description = description;
            Fetchxml = fetchxml;
            Introducedversion = introducedversion;
            Iscustom = iscustom;
            Iscustomizable = iscustomizable;
            Isdefault = isdefault;
            Ismanaged = ismanaged;
            Isquickfindquery = isquickfindquery;
            Isuserdefined = isuserdefined;
            Layoutxml = layoutxml;
            LkMobileofflineprofileitemSavedquery = lkMobileofflineprofileitemSavedquery;
            Modifiedby = modifiedby;
            Modifiedon = modifiedon;
            Modifiedonbehalfby = modifiedonbehalfby;
            Name = name;
            Organizationid = organizationid;
            Organizationtaborder = organizationtaborder;
            Overwritetime = overwritetime;
            Queryapi = queryapi;
            Queryappusage = queryappusage;
            Querytype = querytype;
            Returnedtypecode = returnedtypecode;
            Savedqueryid = savedqueryid;
            Savedqueryidunique = savedqueryidunique;
            Solutionid = solutionid;
            Statecode = statecode;
            Statuscode = statuscode;
            Versionnumber = versionnumber;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SavedQuery_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SavedQueryAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SavedQuery_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> SavedQueryBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SavedQuery_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> SavedQuerySyncErrors { get; set; }

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
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "advancedgroupby")]
        public string Advancedgroupby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "canbedeleted")]
        public MicrosoftDynamicsCRMBooleanManagedProperty Canbedeleted { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "columnsetxml")]
        public string Columnsetxml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "conditionalformatting")]
        public string Conditionalformatting { get; set; }

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
        [JsonProperty(PropertyName = "fetchxml")]
        public string Fetchxml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscustom")]
        public bool? Iscustom { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscustomizable")]
        public MicrosoftDynamicsCRMBooleanManagedProperty Iscustomizable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isdefault")]
        public bool? Isdefault { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isquickfindquery")]
        public bool? Isquickfindquery { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isuserdefined")]
        public bool? Isuserdefined { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "layoutxml")]
        public string Layoutxml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lk_mobileofflineprofileitem_savedquery")]
        public IList<MicrosoftDynamicsCRMmobileofflineprofileitem> LkMobileofflineprofileitemSavedquery { get; set; }

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
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationtaborder")]
        public int? Organizationtaborder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "queryapi")]
        public string Queryapi { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "queryappusage")]
        public int? Queryappusage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "querytype")]
        public int? Querytype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "returnedtypecode")]
        public string Returnedtypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "savedqueryid")]
        public string Savedqueryid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "savedqueryidunique")]
        public string Savedqueryidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

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
        [JsonProperty(PropertyName = "versionnumber")]
        public object Versionnumber { get; set; }

    }
}
