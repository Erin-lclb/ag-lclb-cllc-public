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

    public partial class MicrosoftDynamicsCRMcontract
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMcontract
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMcontract()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMcontract
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMcontract(IList<MicrosoftDynamicsCRMactivitypointer> contractActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMannotation> contractAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMappointment> contractAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMasyncoperation> contractAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> contractBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMduplicaterecord> contractDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> contractDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMemail> contractEmails = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMfax> contractFaxes = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMletter> contractLetters = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMphonecall> contractPhonecalls = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> contractRecurringAppointmentMasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMserviceappointment> contractServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMsocialactivity> contractSocialActivities = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMsyncerror> contractSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMtask> contractTasks = default(IList<MicrosoftDynamicsCRMtask>), string _accountidValue = default(string), string _billingaccountidValue = default(string), string _billingcontactidValue = default(string), string _billingcustomeridValue = default(string), string _billtoaddressValue = default(string), string _contactidValue = default(string), string _contracttemplateidValue = default(string), string _createdbyValue = default(string), string _createdonbehalfbyValue = default(string), string _customeridValue = default(string), string _modifiedbyValue = default(string), string _modifiedonbehalfbyValue = default(string), string _originatingcontractValue = default(string), string _owneridValue = default(string), string _owningbusinessunitValue = default(string), string _owningteamValue = default(string), string _owninguserValue = default(string), string _serviceaddressValue = default(string), string _transactioncurrencyidValue = default(string), System.DateTimeOffset? activeon = default(System.DateTimeOffset?), int? allotmenttypecode = default(int?), MicrosoftDynamicsCRMaccount billingcustomeridAccount = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMcontact billingcustomeridContact = default(MicrosoftDynamicsCRMcontact), System.DateTimeOffset? billingendon = default(System.DateTimeOffset?), int? billingfrequencycode = default(int?), System.DateTimeOffset? billingstarton = default(System.DateTimeOffset?), MicrosoftDynamicsCRMcustomeraddress billtoaddress = default(MicrosoftDynamicsCRMcustomeraddress), System.DateTimeOffset? cancelon = default(System.DateTimeOffset?), IList<MicrosoftDynamicsCRMactivityparty> contractActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), IList<MicrosoftDynamicsCRMincident> contractCases = default(IList<MicrosoftDynamicsCRMincident>), IList<MicrosoftDynamicsCRMconnection> contractConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMconnection> contractConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMcontractdetail> contractLineItems = default(IList<MicrosoftDynamicsCRMcontractdetail>), IList<MicrosoftDynamicsCRMcontract> contractOriginatingContract = default(IList<MicrosoftDynamicsCRMcontract>), string contractid = default(string), string contractlanguage = default(string), string contractnumber = default(string), int? contractservicelevelcode = default(int?), string contracttemplateabbreviation = default(string), MicrosoftDynamicsCRMcontracttemplate contracttemplateid = default(MicrosoftDynamicsCRMcontracttemplate), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMaccount customeridAccount = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMcontact customeridContact = default(MicrosoftDynamicsCRMcontact), int? duration = default(int?), string effectivitycalendar = default(string), string entityimage = default(string), object entityimageTimestamp = default(object), string entityimageUrl = default(string), string entityimageid = default(string), double? exchangerate = default(double?), System.DateTimeOffset? expireson = default(System.DateTimeOffset?), int? importsequencenumber = default(int?), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), double? netprice = default(double?), double? netpriceBase = default(double?), MicrosoftDynamicsCRMcontract originatingcontract = default(MicrosoftDynamicsCRMcontract), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMcustomeraddress serviceaddress = default(MicrosoftDynamicsCRMcustomeraddress), IList<MicrosoftDynamicsCRMcontact> servicecontractcontactsAssociation = default(IList<MicrosoftDynamicsCRMcontact>), int? statecode = default(int?), int? statuscode = default(int?), int? timezoneruleversionnumber = default(int?), string title = default(string), double? totaldiscount = default(double?), double? totaldiscountBase = default(double?), double? totalprice = default(double?), double? totalpriceBase = default(double?), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), bool? usediscountaspercentage = default(bool?), int? utcconversiontimezonecode = default(int?), object versionnumber = default(object))
        {
            ContractActivityPointers = contractActivityPointers;
            ContractAnnotation = contractAnnotation;
            ContractAppointments = contractAppointments;
            ContractAsyncOperations = contractAsyncOperations;
            ContractBulkDeleteFailures = contractBulkDeleteFailures;
            ContractDuplicateBaseRecord = contractDuplicateBaseRecord;
            ContractDuplicateMatchingRecord = contractDuplicateMatchingRecord;
            ContractEmails = contractEmails;
            ContractFaxes = contractFaxes;
            ContractLetters = contractLetters;
            ContractPhonecalls = contractPhonecalls;
            ContractRecurringAppointmentMasters = contractRecurringAppointmentMasters;
            ContractServiceAppointments = contractServiceAppointments;
            ContractSocialActivities = contractSocialActivities;
            ContractSyncErrors = contractSyncErrors;
            ContractTasks = contractTasks;
            this._accountidValue = _accountidValue;
            this._billingaccountidValue = _billingaccountidValue;
            this._billingcontactidValue = _billingcontactidValue;
            this._billingcustomeridValue = _billingcustomeridValue;
            this._billtoaddressValue = _billtoaddressValue;
            this._contactidValue = _contactidValue;
            this._contracttemplateidValue = _contracttemplateidValue;
            this._createdbyValue = _createdbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._customeridValue = _customeridValue;
            this._modifiedbyValue = _modifiedbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._originatingcontractValue = _originatingcontractValue;
            this._owneridValue = _owneridValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._owningteamValue = _owningteamValue;
            this._owninguserValue = _owninguserValue;
            this._serviceaddressValue = _serviceaddressValue;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Activeon = activeon;
            Allotmenttypecode = allotmenttypecode;
            BillingcustomeridAccount = billingcustomeridAccount;
            BillingcustomeridContact = billingcustomeridContact;
            Billingendon = billingendon;
            Billingfrequencycode = billingfrequencycode;
            Billingstarton = billingstarton;
            Billtoaddress = billtoaddress;
            Cancelon = cancelon;
            ContractActivityParties = contractActivityParties;
            ContractCases = contractCases;
            ContractConnections1 = contractConnections1;
            ContractConnections2 = contractConnections2;
            ContractLineItems = contractLineItems;
            ContractOriginatingContract = contractOriginatingContract;
            Contractid = contractid;
            Contractlanguage = contractlanguage;
            Contractnumber = contractnumber;
            Contractservicelevelcode = contractservicelevelcode;
            Contracttemplateabbreviation = contracttemplateabbreviation;
            Contracttemplateid = contracttemplateid;
            Createdby = createdby;
            Createdon = createdon;
            Createdonbehalfby = createdonbehalfby;
            CustomeridAccount = customeridAccount;
            CustomeridContact = customeridContact;
            Duration = duration;
            Effectivitycalendar = effectivitycalendar;
            Entityimage = entityimage;
            EntityimageTimestamp = entityimageTimestamp;
            EntityimageUrl = entityimageUrl;
            Entityimageid = entityimageid;
            Exchangerate = exchangerate;
            Expireson = expireson;
            Importsequencenumber = importsequencenumber;
            Modifiedby = modifiedby;
            Modifiedon = modifiedon;
            Modifiedonbehalfby = modifiedonbehalfby;
            Netprice = netprice;
            NetpriceBase = netpriceBase;
            Originatingcontract = originatingcontract;
            Overriddencreatedon = overriddencreatedon;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            Owningteam = owningteam;
            Owninguser = owninguser;
            Serviceaddress = serviceaddress;
            ServicecontractcontactsAssociation = servicecontractcontactsAssociation;
            Statecode = statecode;
            Statuscode = statuscode;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Title = title;
            Totaldiscount = totaldiscount;
            TotaldiscountBase = totaldiscountBase;
            Totalprice = totalprice;
            TotalpriceBase = totalpriceBase;
            Transactioncurrencyid = transactioncurrencyid;
            Usediscountaspercentage = usediscountaspercentage;
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
        [JsonProperty(PropertyName = "Contract_ActivityPointers")]
        public IList<MicrosoftDynamicsCRMactivitypointer> ContractActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Contract_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> ContractAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Contract_Appointments")]
        public IList<MicrosoftDynamicsCRMappointment> ContractAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Contract_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> ContractAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Contract_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> ContractBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Contract_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> ContractDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Contract_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> ContractDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Contract_Emails")]
        public IList<MicrosoftDynamicsCRMemail> ContractEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Contract_Faxes")]
        public IList<MicrosoftDynamicsCRMfax> ContractFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Contract_Letters")]
        public IList<MicrosoftDynamicsCRMletter> ContractLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Contract_Phonecalls")]
        public IList<MicrosoftDynamicsCRMphonecall> ContractPhonecalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Contract_RecurringAppointmentMasters")]
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> ContractRecurringAppointmentMasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Contract_ServiceAppointments")]
        public IList<MicrosoftDynamicsCRMserviceappointment> ContractServiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Contract_SocialActivities")]
        public IList<MicrosoftDynamicsCRMsocialactivity> ContractSocialActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Contract_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> ContractSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Contract_Tasks")]
        public IList<MicrosoftDynamicsCRMtask> ContractTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_accountid_value")]
        public string _accountidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_billingaccountid_value")]
        public string _billingaccountidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_billingcontactid_value")]
        public string _billingcontactidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_billingcustomerid_value")]
        public string _billingcustomeridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_billtoaddress_value")]
        public string _billtoaddressValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_contactid_value")]
        public string _contactidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_contracttemplateid_value")]
        public string _contracttemplateidValue { get; set; }

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
        [JsonProperty(PropertyName = "_customerid_value")]
        public string _customeridValue { get; set; }

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
        [JsonProperty(PropertyName = "_originatingcontract_value")]
        public string _originatingcontractValue { get; set; }

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
        [JsonProperty(PropertyName = "_serviceaddress_value")]
        public string _serviceaddressValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activeon")]
        public System.DateTimeOffset? Activeon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "allotmenttypecode")]
        public int? Allotmenttypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billingcustomerid_account")]
        public MicrosoftDynamicsCRMaccount BillingcustomeridAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billingcustomerid_contact")]
        public MicrosoftDynamicsCRMcontact BillingcustomeridContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billingendon")]
        public System.DateTimeOffset? Billingendon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billingfrequencycode")]
        public int? Billingfrequencycode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billingstarton")]
        public System.DateTimeOffset? Billingstarton { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billtoaddress")]
        public MicrosoftDynamicsCRMcustomeraddress Billtoaddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "cancelon")]
        public System.DateTimeOffset? Cancelon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contract_activity_parties")]
        public IList<MicrosoftDynamicsCRMactivityparty> ContractActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contract_cases")]
        public IList<MicrosoftDynamicsCRMincident> ContractCases { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contract_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> ContractConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contract_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> ContractConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contract_line_items")]
        public IList<MicrosoftDynamicsCRMcontractdetail> ContractLineItems { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contract_originating_contract")]
        public IList<MicrosoftDynamicsCRMcontract> ContractOriginatingContract { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contractid")]
        public string Contractid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contractlanguage")]
        public string Contractlanguage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contractnumber")]
        public string Contractnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contractservicelevelcode")]
        public int? Contractservicelevelcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contracttemplateabbreviation")]
        public string Contracttemplateabbreviation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contracttemplateid")]
        public MicrosoftDynamicsCRMcontracttemplate Contracttemplateid { get; set; }

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
        [JsonProperty(PropertyName = "customerid_account")]
        public MicrosoftDynamicsCRMaccount CustomeridAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customerid_contact")]
        public MicrosoftDynamicsCRMcontact CustomeridContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "effectivitycalendar")]
        public string Effectivitycalendar { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage")]
        public string Entityimage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_timestamp")]
        public object EntityimageTimestamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_url")]
        public string EntityimageUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimageid")]
        public string Entityimageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public double? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "expireson")]
        public System.DateTimeOffset? Expireson { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

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
        [JsonProperty(PropertyName = "netprice")]
        public double? Netprice { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "netprice_base")]
        public double? NetpriceBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "originatingcontract")]
        public MicrosoftDynamicsCRMcontract Originatingcontract { get; set; }

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
        [JsonProperty(PropertyName = "serviceaddress")]
        public MicrosoftDynamicsCRMcustomeraddress Serviceaddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "servicecontractcontacts_association")]
        public IList<MicrosoftDynamicsCRMcontact> ServicecontractcontactsAssociation { get; set; }

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
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totaldiscount")]
        public double? Totaldiscount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totaldiscount_base")]
        public double? TotaldiscountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalprice")]
        public double? Totalprice { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalprice_base")]
        public double? TotalpriceBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "usediscountaspercentage")]
        public bool? Usediscountaspercentage { get; set; }

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
