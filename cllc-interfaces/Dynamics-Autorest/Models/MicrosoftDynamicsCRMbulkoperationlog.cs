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

    public partial class MicrosoftDynamicsCRMbulkoperationlog
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbulkoperationlog class.
        /// </summary>
        public MicrosoftDynamicsCRMbulkoperationlog()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbulkoperationlog class.
        /// </summary>
        public MicrosoftDynamicsCRMbulkoperationlog(IList<MicrosoftDynamicsCRMasyncoperation> bulkOperationLogAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> bulkOperationLogBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), string _bulkoperationidValue = default(string), string _createdobjectidValue = default(string), string _owneridValue = default(string), string _regardingobjectidValue = default(string), string additionalinfo = default(string), MicrosoftDynamicsCRMbulkoperation bulkoperationid = default(MicrosoftDynamicsCRMbulkoperation), MicrosoftDynamicsCRMactivitypointer bulkoperationidActivitypointer = default(MicrosoftDynamicsCRMactivitypointer), string bulkoperationlogid = default(string), MicrosoftDynamicsCRMaccount createdobjectidAccount = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMactivitypointer createdobjectidActivitypointer = default(MicrosoftDynamicsCRMactivitypointer), MicrosoftDynamicsCRMcontact createdobjectidContact = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMlead createdobjectidLead = default(MicrosoftDynamicsCRMlead), MicrosoftDynamicsCRMopportunity createdobjectidOpportunity = default(MicrosoftDynamicsCRMopportunity), int? errornumber = default(int?), string owningbusinessunit = default(string), string owninguser = default(string), MicrosoftDynamicsCRMaccount regardingobjectidAccount = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMcontact regardingobjectidContact = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMlead regardingobjectidLead = default(MicrosoftDynamicsCRMlead))
        {
            BulkOperationLogAsyncOperations = bulkOperationLogAsyncOperations;
            BulkOperationLogBulkDeleteFailures = bulkOperationLogBulkDeleteFailures;
            this._bulkoperationidValue = _bulkoperationidValue;
            this._createdobjectidValue = _createdobjectidValue;
            this._owneridValue = _owneridValue;
            this._regardingobjectidValue = _regardingobjectidValue;
            Additionalinfo = additionalinfo;
            Bulkoperationid = bulkoperationid;
            BulkoperationidActivitypointer = bulkoperationidActivitypointer;
            Bulkoperationlogid = bulkoperationlogid;
            CreatedobjectidAccount = createdobjectidAccount;
            CreatedobjectidActivitypointer = createdobjectidActivitypointer;
            CreatedobjectidContact = createdobjectidContact;
            CreatedobjectidLead = createdobjectidLead;
            CreatedobjectidOpportunity = createdobjectidOpportunity;
            Errornumber = errornumber;
            Owningbusinessunit = owningbusinessunit;
            Owninguser = owninguser;
            RegardingobjectidAccount = regardingobjectidAccount;
            RegardingobjectidContact = regardingobjectidContact;
            RegardingobjectidLead = regardingobjectidLead;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BulkOperationLog_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> BulkOperationLogAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BulkOperationLog_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> BulkOperationLogBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_bulkoperationid_value")]
        public string _bulkoperationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdobjectid_value")]
        public string _createdobjectidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_regardingobjectid_value")]
        public string _regardingobjectidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "additionalinfo")]
        public string Additionalinfo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bulkoperationid")]
        public MicrosoftDynamicsCRMbulkoperation Bulkoperationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bulkoperationid_activitypointer")]
        public MicrosoftDynamicsCRMactivitypointer BulkoperationidActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bulkoperationlogid")]
        public string Bulkoperationlogid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdobjectid_account")]
        public MicrosoftDynamicsCRMaccount CreatedobjectidAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdobjectid_activitypointer")]
        public MicrosoftDynamicsCRMactivitypointer CreatedobjectidActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdobjectid_contact")]
        public MicrosoftDynamicsCRMcontact CreatedobjectidContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdobjectid_lead")]
        public MicrosoftDynamicsCRMlead CreatedobjectidLead { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdobjectid_opportunity")]
        public MicrosoftDynamicsCRMopportunity CreatedobjectidOpportunity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errornumber")]
        public int? Errornumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public string Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public string Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_account")]
        public MicrosoftDynamicsCRMaccount RegardingobjectidAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_contact")]
        public MicrosoftDynamicsCRMcontact RegardingobjectidContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_lead")]
        public MicrosoftDynamicsCRMlead RegardingobjectidLead { get; set; }

    }
}
