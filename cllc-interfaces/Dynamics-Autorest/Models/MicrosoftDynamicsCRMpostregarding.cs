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

    public partial class MicrosoftDynamicsCRMpostregarding
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMpostregarding
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMpostregarding()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMpostregarding
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMpostregarding(string _regardingobjectidValue = default(string), string _regardingobjectowneridValue = default(string), string _regardingobjectowningbusinessunitValue = default(string), System.DateTimeOffset? latestautopostmodifiedon = default(System.DateTimeOffset?), System.DateTimeOffset? latestmanualpostmodifiedon = default(System.DateTimeOffset?), IList<MicrosoftDynamicsCRMpost> postPostRegardings = default(IList<MicrosoftDynamicsCRMpost>), string postregardingid = default(string), MicrosoftDynamicsCRMaccount regardingobjectidAccount = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMappointment regardingobjectidAppointment = default(MicrosoftDynamicsCRMappointment), MicrosoftDynamicsCRMcompetitor regardingobjectidCompetitor = default(MicrosoftDynamicsCRMcompetitor), MicrosoftDynamicsCRMcontact regardingobjectidContact = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMincident regardingobjectidIncident = default(MicrosoftDynamicsCRMincident), MicrosoftDynamicsCRMknowledgearticle regardingobjectidKnowledgearticle = default(MicrosoftDynamicsCRMknowledgearticle), MicrosoftDynamicsCRMlead regardingobjectidLead = default(MicrosoftDynamicsCRMlead), MicrosoftDynamicsCRMopportunity regardingobjectidOpportunity = default(MicrosoftDynamicsCRMopportunity), MicrosoftDynamicsCRMphonecall regardingobjectidPhonecall = default(MicrosoftDynamicsCRMphonecall), MicrosoftDynamicsCRMqueue regardingobjectidQueue = default(MicrosoftDynamicsCRMqueue), MicrosoftDynamicsCRMrecurringappointmentmaster regardingobjectidRecurringappointmentmaster = default(MicrosoftDynamicsCRMrecurringappointmentmaster), MicrosoftDynamicsCRMsystemuser regardingobjectidSystemuser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMtask regardingobjectidTask = default(MicrosoftDynamicsCRMtask), MicrosoftDynamicsCRMteam regardingobjectidTeam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMbusinessunit regardingobjectowningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), string regardingobjecttypecodeforsharing = default(string))
        {
            this._regardingobjectidValue = _regardingobjectidValue;
            this._regardingobjectowneridValue = _regardingobjectowneridValue;
            this._regardingobjectowningbusinessunitValue = _regardingobjectowningbusinessunitValue;
            Latestautopostmodifiedon = latestautopostmodifiedon;
            Latestmanualpostmodifiedon = latestmanualpostmodifiedon;
            PostPostRegardings = postPostRegardings;
            Postregardingid = postregardingid;
            RegardingobjectidAccount = regardingobjectidAccount;
            RegardingobjectidAppointment = regardingobjectidAppointment;
            RegardingobjectidCompetitor = regardingobjectidCompetitor;
            RegardingobjectidContact = regardingobjectidContact;
            RegardingobjectidIncident = regardingobjectidIncident;
            RegardingobjectidKnowledgearticle = regardingobjectidKnowledgearticle;
            RegardingobjectidLead = regardingobjectidLead;
            RegardingobjectidOpportunity = regardingobjectidOpportunity;
            RegardingobjectidPhonecall = regardingobjectidPhonecall;
            RegardingobjectidQueue = regardingobjectidQueue;
            RegardingobjectidRecurringappointmentmaster = regardingobjectidRecurringappointmentmaster;
            RegardingobjectidSystemuser = regardingobjectidSystemuser;
            RegardingobjectidTask = regardingobjectidTask;
            RegardingobjectidTeam = regardingobjectidTeam;
            Regardingobjectowningbusinessunit = regardingobjectowningbusinessunit;
            Regardingobjecttypecodeforsharing = regardingobjecttypecodeforsharing;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_regardingobjectid_value")]
        public string _regardingobjectidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_regardingobjectownerid_value")]
        public string _regardingobjectowneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_regardingobjectowningbusinessunit_value")]
        public string _regardingobjectowningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "latestautopostmodifiedon")]
        public System.DateTimeOffset? Latestautopostmodifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "latestmanualpostmodifiedon")]
        public System.DateTimeOffset? Latestmanualpostmodifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "post_PostRegardings")]
        public IList<MicrosoftDynamicsCRMpost> PostPostRegardings { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postregardingid")]
        public string Postregardingid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_account")]
        public MicrosoftDynamicsCRMaccount RegardingobjectidAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_appointment")]
        public MicrosoftDynamicsCRMappointment RegardingobjectidAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_competitor")]
        public MicrosoftDynamicsCRMcompetitor RegardingobjectidCompetitor { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_contact")]
        public MicrosoftDynamicsCRMcontact RegardingobjectidContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_incident")]
        public MicrosoftDynamicsCRMincident RegardingobjectidIncident { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgearticle")]
        public MicrosoftDynamicsCRMknowledgearticle RegardingobjectidKnowledgearticle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_lead")]
        public MicrosoftDynamicsCRMlead RegardingobjectidLead { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_opportunity")]
        public MicrosoftDynamicsCRMopportunity RegardingobjectidOpportunity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_phonecall")]
        public MicrosoftDynamicsCRMphonecall RegardingobjectidPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_queue")]
        public MicrosoftDynamicsCRMqueue RegardingobjectidQueue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMrecurringappointmentmaster RegardingobjectidRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_systemuser")]
        public MicrosoftDynamicsCRMsystemuser RegardingobjectidSystemuser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_task")]
        public MicrosoftDynamicsCRMtask RegardingobjectidTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_team")]
        public MicrosoftDynamicsCRMteam RegardingobjectidTeam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectowningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Regardingobjectowningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjecttypecodeforsharing")]
        public string Regardingobjecttypecodeforsharing { get; set; }

    }
}
