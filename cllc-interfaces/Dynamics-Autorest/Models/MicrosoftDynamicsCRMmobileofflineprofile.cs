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

    public partial class MicrosoftDynamicsCRMmobileofflineprofile
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmobileofflineprofile class.
        /// </summary>
        public MicrosoftDynamicsCRMmobileofflineprofile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmobileofflineprofile class.
        /// </summary>
        public MicrosoftDynamicsCRMmobileofflineprofile(IList<MicrosoftDynamicsCRMorganization> defaultMobileOfflineProfileOrganization = default(IList<MicrosoftDynamicsCRMorganization>), IList<MicrosoftDynamicsCRMmobileofflineprofileitem> mobileOfflineProfileMobileOfflineProfileItem = default(IList<MicrosoftDynamicsCRMmobileofflineprofileitem>), IList<MicrosoftDynamicsCRMsystemuser> mobileOfflineProfileSystemUser = default(IList<MicrosoftDynamicsCRMsystemuser>), string _createdbyValue = default(string), string _createdonbehalfbyValue = default(string), string _modifiedbyValue = default(string), string _modifiedonbehalfbyValue = default(string), string _organizationidValue = default(string), int? componentstate = default(int?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), string description = default(string), string introducedversion = default(string), bool? ismanaged = default(bool?), bool? isvalidated = default(bool?), string mobileofflineprofileid = default(string), string mobileofflineprofileidunique = default(string), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), string name = default(string), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), string processid = default(string), System.DateTimeOffset? publishedon = default(System.DateTimeOffset?), string selectedentitymetadata = default(string), string solutionid = default(string), string stageid = default(string), string traversedpath = default(string), object versionnumber = default(object))
        {
            DefaultMobileOfflineProfileOrganization = defaultMobileOfflineProfileOrganization;
            MobileOfflineProfileMobileOfflineProfileItem = mobileOfflineProfileMobileOfflineProfileItem;
            MobileOfflineProfileSystemUser = mobileOfflineProfileSystemUser;
            this._createdbyValue = _createdbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._organizationidValue = _organizationidValue;
            Componentstate = componentstate;
            Createdby = createdby;
            Createdon = createdon;
            Createdonbehalfby = createdonbehalfby;
            Description = description;
            Introducedversion = introducedversion;
            Ismanaged = ismanaged;
            Isvalidated = isvalidated;
            Mobileofflineprofileid = mobileofflineprofileid;
            Mobileofflineprofileidunique = mobileofflineprofileidunique;
            Modifiedby = modifiedby;
            Modifiedon = modifiedon;
            Modifiedonbehalfby = modifiedonbehalfby;
            Name = name;
            Organizationid = organizationid;
            Overwritetime = overwritetime;
            Processid = processid;
            Publishedon = publishedon;
            Selectedentitymetadata = selectedentitymetadata;
            Solutionid = solutionid;
            Stageid = stageid;
            Traversedpath = traversedpath;
            Versionnumber = versionnumber;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DefaultMobileOfflineProfile_Organization")]
        public IList<MicrosoftDynamicsCRMorganization> DefaultMobileOfflineProfileOrganization { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MobileOfflineProfile_MobileOfflineProfileItem")]
        public IList<MicrosoftDynamicsCRMmobileofflineprofileitem> MobileOfflineProfileMobileOfflineProfileItem { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MobileOfflineProfile_SystemUser")]
        public IList<MicrosoftDynamicsCRMsystemuser> MobileOfflineProfileSystemUser { get; set; }

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
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isvalidated")]
        public bool? Isvalidated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mobileofflineprofileid")]
        public string Mobileofflineprofileid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mobileofflineprofileidunique")]
        public string Mobileofflineprofileidunique { get; set; }

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
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public string Processid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "publishedon")]
        public System.DateTimeOffset? Publishedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "selectedentitymetadata")]
        public string Selectedentitymetadata { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid")]
        public string Stageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "traversedpath")]
        public string Traversedpath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public object Versionnumber { get; set; }

    }
}
