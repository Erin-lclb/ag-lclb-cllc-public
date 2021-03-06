// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class MicrosoftDynamicsCRMactioncarduserstate
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMactioncarduserstate class.
        /// </summary>
        public MicrosoftDynamicsCRMactioncarduserstate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMactioncarduserstate class.
        /// </summary>
        public MicrosoftDynamicsCRMactioncarduserstate(string _actioncardidValue = default(string), string _owneridValue = default(string), string _owningbusinessunitValue = default(string), string _transactioncurrencyidValue = default(string), MicrosoftDynamicsCRMactioncard actioncardid = default(MicrosoftDynamicsCRMactioncard), string actioncarduserstateid = default(string), double? exchangerate = default(double?), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), System.DateTimeOffset? startdate = default(System.DateTimeOffset?), int? state = default(int?), int? timezoneruleversionnumber = default(int?), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), int? utcconversiontimezonecode = default(int?), object versionnumber = default(object))
        {
            this._actioncardidValue = _actioncardidValue;
            this._owneridValue = _owneridValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Actioncardid = actioncardid;
            Actioncarduserstateid = actioncarduserstateid;
            Exchangerate = exchangerate;
            Ownerid = ownerid;
            Startdate = startdate;
            State = state;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Transactioncurrencyid = transactioncurrencyid;
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
        [JsonProperty(PropertyName = "_actioncardid_value")]
        public string _actioncardidValue { get; set; }

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
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "actioncardid")]
        public MicrosoftDynamicsCRMactioncard Actioncardid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "actioncarduserstateid")]
        public string Actioncarduserstateid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public double? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "startdate")]
        public System.DateTimeOffset? Startdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public int? State { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

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
