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

    public partial class MicrosoftDynamicsCRMorderclose : MicrosoftDynamicsCRMactivitypointer
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMorderclose
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMorderclose()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMorderclose
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMorderclose(IList<MicrosoftDynamicsCRMasyncoperation> activityPointerAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> activityPointerBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMcampaignactivityitem> activityPointerCampaignActivityItems = default(IList<MicrosoftDynamicsCRMcampaignactivityitem>), IList<MicrosoftDynamicsCRMqueueitem> activityPointerQueueItem = default(IList<MicrosoftDynamicsCRMqueueitem>), IList<MicrosoftDynamicsCRMbulkoperationlog> createdActivityBulkOperationLogs = default(IList<MicrosoftDynamicsCRMbulkoperationlog>), string _createdbyValue = default(string), string _createdonbehalfbyValue = default(string), string _modifiedbyValue = default(string), string _modifiedonbehalfbyValue = default(string), string _owneridValue = default(string), string _owningbusinessunitValue = default(string), string _owningteamValue = default(string), string _owninguserValue = default(string), string _regardingobjectidValue = default(string), string _sendermailboxidValue = default(string), string _serviceidValue = default(string), string _slaidValue = default(string), string _slainvokedidValue = default(string), string _transactioncurrencyidValue = default(string), IList<MicrosoftDynamicsCRMcampaignresponse> activityCampaignresponse = default(IList<MicrosoftDynamicsCRMcampaignresponse>), IList<MicrosoftDynamicsCRMbulkoperation> activityPointerBulkOperation = default(IList<MicrosoftDynamicsCRMbulkoperation>), IList<MicrosoftDynamicsCRMbulkoperationlog> activityPointerBulkOperationLogs = default(IList<MicrosoftDynamicsCRMbulkoperationlog>), IList<MicrosoftDynamicsCRMactivitymimeattachment> activityPointerActivityMimeAttachment = default(IList<MicrosoftDynamicsCRMactivitymimeattachment>), IList<MicrosoftDynamicsCRMappointment> activityPointerAppointment = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMcampaignactivity> activityPointerCampaignactivity = default(IList<MicrosoftDynamicsCRMcampaignactivity>), IList<MicrosoftDynamicsCRMcampaignresponse> activityPointerCampaignresponse = default(IList<MicrosoftDynamicsCRMcampaignresponse>), IList<MicrosoftDynamicsCRMemail> activityPointerEmail = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMfax> activityPointerFax = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMincidentresolution> activityPointerIncidentResolution = default(IList<MicrosoftDynamicsCRMincidentresolution>), IList<MicrosoftDynamicsCRMletter> activityPointerLetter = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMopportunityclose> activityPointerOpportunityClose = default(IList<MicrosoftDynamicsCRMopportunityclose>), IList<MicrosoftDynamicsCRMorderclose> activityPointerOrderClose = default(IList<MicrosoftDynamicsCRMorderclose>), IList<MicrosoftDynamicsCRMphonecall> activityPointerPhonecall = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMquoteclose> activityPointerQuoteClose = default(IList<MicrosoftDynamicsCRMquoteclose>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> activityPointerRecurringappointmentmaster = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMserviceappointment> activityPointerServiceAppointment = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMsocialactivity> activityPointerSocialactivity = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMtask> activityPointerTask = default(IList<MicrosoftDynamicsCRMtask>), string activityadditionalparams = default(string), string activityid = default(string), IList<MicrosoftDynamicsCRMactivityparty> activitypointerActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), IList<MicrosoftDynamicsCRMconnection> activitypointerConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMconnection> activitypointerConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), string activitytypecode = default(string), int? actualdurationminutes = default(int?), System.DateTimeOffset? actualend = default(System.DateTimeOffset?), System.DateTimeOffset? actualstart = default(System.DateTimeOffset?), int? community = default(int?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? deliverylastattemptedon = default(System.DateTimeOffset?), int? deliveryprioritycode = default(int?), string description = default(string), string exchangeitemid = default(string), double? exchangerate = default(double?), string exchangeweblink = default(string), int? instancetypecode = default(int?), bool? isbilled = default(bool?), bool? ismapiprivate = default(bool?), bool? isregularactivity = default(bool?), bool? isworkflowcreated = default(bool?), System.DateTimeOffset? lastonholdtime = default(System.DateTimeOffset?), bool? leftvoicemail = default(bool?), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), int? onholdtime = default(int?), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? postponeactivityprocessinguntil = default(System.DateTimeOffset?), int? prioritycode = default(int?), string processid = default(string), MicrosoftDynamicsCRMaccount regardingobjectidAccount = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMadoxioAgencycommunication regardingobjectidAdoxioAgencycommunication = default(MicrosoftDynamicsCRMadoxioAgencycommunication), MicrosoftDynamicsCRMadoxioApplication regardingobjectidAdoxioApplication = default(MicrosoftDynamicsCRMadoxioApplication), MicrosoftDynamicsCRMadoxioComplaint regardingobjectidAdoxioComplaint = default(MicrosoftDynamicsCRMadoxioComplaint), MicrosoftDynamicsCRMadoxioInvestigation regardingobjectidAdoxioInvestigation = default(MicrosoftDynamicsCRMadoxioInvestigation), MicrosoftDynamicsCRMadoxioInvestigationstakeholder regardingobjectidAdoxioInvestigationstakeholder = default(MicrosoftDynamicsCRMadoxioInvestigationstakeholder), MicrosoftDynamicsCRMadoxioLicences regardingobjectidAdoxioLicences = default(MicrosoftDynamicsCRMadoxioLicences), MicrosoftDynamicsCRMbookableresourcebooking regardingobjectidBookableresourcebooking = default(MicrosoftDynamicsCRMbookableresourcebooking), MicrosoftDynamicsCRMbookableresourcebookingheader regardingobjectidBookableresourcebookingheader = default(MicrosoftDynamicsCRMbookableresourcebookingheader), MicrosoftDynamicsCRMbulkoperation regardingobjectidBulkoperation = default(MicrosoftDynamicsCRMbulkoperation), MicrosoftDynamicsCRMcampaign regardingobjectidCampaign = default(MicrosoftDynamicsCRMcampaign), MicrosoftDynamicsCRMcampaignactivity regardingobjectidCampaignactivity = default(MicrosoftDynamicsCRMcampaignactivity), MicrosoftDynamicsCRMcontact regardingobjectidContact = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMcontract regardingobjectidContract = default(MicrosoftDynamicsCRMcontract), MicrosoftDynamicsCRMentitlement regardingobjectidEntitlement = default(MicrosoftDynamicsCRMentitlement), MicrosoftDynamicsCRMentitlementtemplate regardingobjectidEntitlementtemplate = default(MicrosoftDynamicsCRMentitlementtemplate), MicrosoftDynamicsCRMincident regardingobjectidIncident = default(MicrosoftDynamicsCRMincident), MicrosoftDynamicsCRMinvoice regardingobjectidInvoice = default(MicrosoftDynamicsCRMinvoice), MicrosoftDynamicsCRMknowledgearticle regardingobjectidKnowledgearticle = default(MicrosoftDynamicsCRMknowledgearticle), MicrosoftDynamicsCRMknowledgebaserecord regardingobjectidKnowledgebaserecord = default(MicrosoftDynamicsCRMknowledgebaserecord), MicrosoftDynamicsCRMlead regardingobjectidLead = default(MicrosoftDynamicsCRMlead), MicrosoftDynamicsCRMinteractionforemail regardingobjectidNewInteractionforemail = default(MicrosoftDynamicsCRMinteractionforemail), MicrosoftDynamicsCRMopportunity regardingobjectidOpportunity = default(MicrosoftDynamicsCRMopportunity), MicrosoftDynamicsCRMquote regardingobjectidQuote = default(MicrosoftDynamicsCRMquote), MicrosoftDynamicsCRMsalesorder regardingobjectidSalesorder = default(MicrosoftDynamicsCRMsalesorder), int? scheduleddurationminutes = default(int?), System.DateTimeOffset? scheduledend = default(System.DateTimeOffset?), System.DateTimeOffset? scheduledstart = default(System.DateTimeOffset?), MicrosoftDynamicsCRMmailbox sendermailboxid = default(MicrosoftDynamicsCRMmailbox), System.DateTimeOffset? senton = default(System.DateTimeOffset?), string seriesid = default(string), MicrosoftDynamicsCRMservice serviceid = default(MicrosoftDynamicsCRMservice), MicrosoftDynamicsCRMsla slaActivitypointerSla = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMsla slainvokedidActivitypointerSla = default(MicrosoftDynamicsCRMsla), IList<MicrosoftDynamicsCRMslakpiinstance> slakpiinstanceActivitypointer = default(IList<MicrosoftDynamicsCRMslakpiinstance>), System.DateTimeOffset? sortdate = default(System.DateTimeOffset?), string stageid = default(string), int? statecode = default(int?), int? statuscode = default(int?), string subject = default(string), int? timezoneruleversionnumber = default(int?), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), string traversedpath = default(string), int? utcconversiontimezonecode = default(int?), object versionnumber = default(object), IList<MicrosoftDynamicsCRMannotation> orderCloseAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMasyncoperation> orderCloseAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> orderCloseBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMsyncerror> orderCloseSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), string _salesorderidValue = default(string), MicrosoftDynamicsCRMactivitypointer activityidActivitypointer = default(MicrosoftDynamicsCRMactivitypointer), string category = default(string), MicrosoftDynamicsCRMsystemuser createdbyOrderclose = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyOrderclose = default(MicrosoftDynamicsCRMsystemuser), int? importsequencenumber = default(int?), MicrosoftDynamicsCRMsystemuser modifiedbyOrderclose = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyOrderclose = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMactivityparty> ordercloseActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), string ordernumber = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMbusinessunit owningbusinessunitOrderclose = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMteam owningteamOrderclose = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMsystemuser owninguserOrderclose = default(MicrosoftDynamicsCRMsystemuser), int? revision = default(int?), MicrosoftDynamicsCRMsalesorder salesorderid = default(MicrosoftDynamicsCRMsalesorder), MicrosoftDynamicsCRMservice serviceidOrderclose = default(MicrosoftDynamicsCRMservice), string subcategory = default(string))
            : base(activityPointerAsyncOperations, activityPointerBulkDeleteFailures, activityPointerCampaignActivityItems, activityPointerQueueItem, createdActivityBulkOperationLogs, _createdbyValue, _createdonbehalfbyValue, _modifiedbyValue, _modifiedonbehalfbyValue, _owneridValue, _owningbusinessunitValue, _owningteamValue, _owninguserValue, _regardingobjectidValue, _sendermailboxidValue, _serviceidValue, _slaidValue, _slainvokedidValue, _transactioncurrencyidValue, activityCampaignresponse, activityPointerBulkOperation, activityPointerBulkOperationLogs, activityPointerActivityMimeAttachment, activityPointerAppointment, activityPointerCampaignactivity, activityPointerCampaignresponse, activityPointerEmail, activityPointerFax, activityPointerIncidentResolution, activityPointerLetter, activityPointerOpportunityClose, activityPointerOrderClose, activityPointerPhonecall, activityPointerQuoteClose, activityPointerRecurringappointmentmaster, activityPointerServiceAppointment, activityPointerSocialactivity, activityPointerTask, activityadditionalparams, activityid, activitypointerActivityParties, activitypointerConnections1, activitypointerConnections2, activitytypecode, actualdurationminutes, actualend, actualstart, community, createdby, createdon, createdonbehalfby, deliverylastattemptedon, deliveryprioritycode, description, exchangeitemid, exchangerate, exchangeweblink, instancetypecode, isbilled, ismapiprivate, isregularactivity, isworkflowcreated, lastonholdtime, leftvoicemail, modifiedby, modifiedon, modifiedonbehalfby, onholdtime, ownerid, owningbusinessunit, owningteam, owninguser, postponeactivityprocessinguntil, prioritycode, processid, regardingobjectidAccount, regardingobjectidAdoxioAgencycommunication, regardingobjectidAdoxioApplication, regardingobjectidAdoxioComplaint, regardingobjectidAdoxioInvestigation, regardingobjectidAdoxioInvestigationstakeholder, regardingobjectidAdoxioLicences, regardingobjectidBookableresourcebooking, regardingobjectidBookableresourcebookingheader, regardingobjectidBulkoperation, regardingobjectidCampaign, regardingobjectidCampaignactivity, regardingobjectidContact, regardingobjectidContract, regardingobjectidEntitlement, regardingobjectidEntitlementtemplate, regardingobjectidIncident, regardingobjectidInvoice, regardingobjectidKnowledgearticle, regardingobjectidKnowledgebaserecord, regardingobjectidLead, regardingobjectidNewInteractionforemail, regardingobjectidOpportunity, regardingobjectidQuote, regardingobjectidSalesorder, scheduleddurationminutes, scheduledend, scheduledstart, sendermailboxid, senton, seriesid, serviceid, slaActivitypointerSla, slainvokedidActivitypointerSla, slakpiinstanceActivitypointer, sortdate, stageid, statecode, statuscode, subject, timezoneruleversionnumber, transactioncurrencyid, traversedpath, utcconversiontimezonecode, versionnumber)
        {
            OrderCloseAnnotation = orderCloseAnnotation;
            OrderCloseAsyncOperations = orderCloseAsyncOperations;
            OrderCloseBulkDeleteFailures = orderCloseBulkDeleteFailures;
            OrderCloseSyncErrors = orderCloseSyncErrors;
            this._salesorderidValue = _salesorderidValue;
            ActivityidActivitypointer = activityidActivitypointer;
            Category = category;
            CreatedbyOrderclose = createdbyOrderclose;
            CreatedonbehalfbyOrderclose = createdonbehalfbyOrderclose;
            Importsequencenumber = importsequencenumber;
            ModifiedbyOrderclose = modifiedbyOrderclose;
            ModifiedonbehalfbyOrderclose = modifiedonbehalfbyOrderclose;
            OrdercloseActivityParties = ordercloseActivityParties;
            Ordernumber = ordernumber;
            Overriddencreatedon = overriddencreatedon;
            OwningbusinessunitOrderclose = owningbusinessunitOrderclose;
            OwningteamOrderclose = owningteamOrderclose;
            OwninguserOrderclose = owninguserOrderclose;
            Revision = revision;
            Salesorderid = salesorderid;
            ServiceidOrderclose = serviceidOrderclose;
            Subcategory = subcategory;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OrderClose_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> OrderCloseAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OrderClose_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> OrderCloseAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OrderClose_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> OrderCloseBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OrderClose_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> OrderCloseSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_salesorderid_value")]
        public string _salesorderidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_activitypointer")]
        public MicrosoftDynamicsCRMactivitypointer ActivityidActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby_orderclose")]
        public MicrosoftDynamicsCRMsystemuser CreatedbyOrderclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby_orderclose")]
        public MicrosoftDynamicsCRMsystemuser CreatedonbehalfbyOrderclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby_orderclose")]
        public MicrosoftDynamicsCRMsystemuser ModifiedbyOrderclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby_orderclose")]
        public MicrosoftDynamicsCRMsystemuser ModifiedonbehalfbyOrderclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "orderclose_activity_parties")]
        public IList<MicrosoftDynamicsCRMactivityparty> OrdercloseActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ordernumber")]
        public string Ordernumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit_orderclose")]
        public MicrosoftDynamicsCRMbusinessunit OwningbusinessunitOrderclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam_orderclose")]
        public MicrosoftDynamicsCRMteam OwningteamOrderclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser_orderclose")]
        public MicrosoftDynamicsCRMsystemuser OwninguserOrderclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "revision")]
        public int? Revision { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salesorderid")]
        public MicrosoftDynamicsCRMsalesorder Salesorderid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceid_orderclose")]
        public MicrosoftDynamicsCRMservice ServiceidOrderclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subcategory")]
        public string Subcategory { get; set; }

    }
}