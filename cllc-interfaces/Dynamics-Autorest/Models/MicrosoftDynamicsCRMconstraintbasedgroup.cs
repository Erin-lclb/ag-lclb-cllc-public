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

    public partial class MicrosoftDynamicsCRMconstraintbasedgroup
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMconstraintbasedgroup class.
        /// </summary>
        public MicrosoftDynamicsCRMconstraintbasedgroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMconstraintbasedgroup class.
        /// </summary>
        public MicrosoftDynamicsCRMconstraintbasedgroup(IList<MicrosoftDynamicsCRMasyncoperation> constraintBasedGroupAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> constraintBasedGroupBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), string _businessunitidValue = default(string), string _createdbyValue = default(string), string _createdonbehalfbyValue = default(string), string _modifiedbyValue = default(string), string _modifiedonbehalfbyValue = default(string), string _organizationidValue = default(string), MicrosoftDynamicsCRMbusinessunit businessunitidBusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMsystemuser businessunitidSystemuser = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMresourcespec> constraintBasedGroupResourceSpecs = default(IList<MicrosoftDynamicsCRMresourcespec>), IList<MicrosoftDynamicsCRMconnection> constraintbasedgroupConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMconnection> constraintbasedgroupConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMresourcegroup> constraintbasedgroupResourceGroups = default(IList<MicrosoftDynamicsCRMresourcegroup>), string constraintbasedgroupid = default(string), string constraints = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), string description = default(string), int? grouptypecode = default(int?), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), string name = default(string), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), object versionnumber = default(object))
        {
            ConstraintBasedGroupAsyncOperations = constraintBasedGroupAsyncOperations;
            ConstraintBasedGroupBulkDeleteFailures = constraintBasedGroupBulkDeleteFailures;
            this._businessunitidValue = _businessunitidValue;
            this._createdbyValue = _createdbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._organizationidValue = _organizationidValue;
            BusinessunitidBusinessunit = businessunitidBusinessunit;
            BusinessunitidSystemuser = businessunitidSystemuser;
            ConstraintBasedGroupResourceSpecs = constraintBasedGroupResourceSpecs;
            ConstraintbasedgroupConnections1 = constraintbasedgroupConnections1;
            ConstraintbasedgroupConnections2 = constraintbasedgroupConnections2;
            ConstraintbasedgroupResourceGroups = constraintbasedgroupResourceGroups;
            Constraintbasedgroupid = constraintbasedgroupid;
            Constraints = constraints;
            Createdby = createdby;
            Createdon = createdon;
            Createdonbehalfby = createdonbehalfby;
            Description = description;
            Grouptypecode = grouptypecode;
            Modifiedby = modifiedby;
            Modifiedon = modifiedon;
            Modifiedonbehalfby = modifiedonbehalfby;
            Name = name;
            Organizationid = organizationid;
            Versionnumber = versionnumber;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ConstraintBasedGroup_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> ConstraintBasedGroupAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ConstraintBasedGroup_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> ConstraintBasedGroupBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_businessunitid_value")]
        public string _businessunitidValue { get; set; }

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
        [JsonProperty(PropertyName = "businessunitid_businessunit")]
        public MicrosoftDynamicsCRMbusinessunit BusinessunitidBusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "businessunitid_systemuser")]
        public MicrosoftDynamicsCRMsystemuser BusinessunitidSystemuser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "constraint_based_group_resource_specs")]
        public IList<MicrosoftDynamicsCRMresourcespec> ConstraintBasedGroupResourceSpecs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "constraintbasedgroup_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> ConstraintbasedgroupConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "constraintbasedgroup_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> ConstraintbasedgroupConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "constraintbasedgroup_resource_groups")]
        public IList<MicrosoftDynamicsCRMresourcegroup> ConstraintbasedgroupResourceGroups { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "constraintbasedgroupid")]
        public string Constraintbasedgroupid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "constraints")]
        public string Constraints { get; set; }

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
        [JsonProperty(PropertyName = "grouptypecode")]
        public int? Grouptypecode { get; set; }

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
        [JsonProperty(PropertyName = "versionnumber")]
        public object Versionnumber { get; set; }

    }
}
