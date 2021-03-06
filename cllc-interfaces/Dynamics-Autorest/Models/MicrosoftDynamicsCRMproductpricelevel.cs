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

    public partial class MicrosoftDynamicsCRMproductpricelevel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMproductpricelevel class.
        /// </summary>
        public MicrosoftDynamicsCRMproductpricelevel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMproductpricelevel class.
        /// </summary>
        public MicrosoftDynamicsCRMproductpricelevel(IList<MicrosoftDynamicsCRMasyncoperation> productPriceLevelAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> productPriceLevelBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMsyncerror> productPriceLevelSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), string _createdbyValue = default(string), string _createdonbehalfbyValue = default(string), string _discounttypeidValue = default(string), string _modifiedbyValue = default(string), string _modifiedonbehalfbyValue = default(string), string _pricelevelidValue = default(string), string _productidValue = default(string), string _transactioncurrencyidValue = default(string), string _uomidValue = default(string), string _uomscheduleidValue = default(string), double? amount = default(double?), double? amountBase = default(double?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMdiscounttype discounttypeid = default(MicrosoftDynamicsCRMdiscounttype), double? exchangerate = default(double?), int? importsequencenumber = default(int?), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), string organizationid = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), double? percentage = default(double?), MicrosoftDynamicsCRMpricelevel pricelevelid = default(MicrosoftDynamicsCRMpricelevel), int? pricingmethodcode = default(int?), string processid = default(string), MicrosoftDynamicsCRMproduct productid = default(MicrosoftDynamicsCRMproduct), string productnumber = default(string), string productpricelevelid = default(string), int? quantitysellingcode = default(int?), double? roundingoptionamount = default(double?), double? roundingoptionamountBase = default(double?), int? roundingoptioncode = default(int?), int? roundingpolicycode = default(int?), string stageid = default(string), MicrosoftDynamicsCRMprocessstage stageidProcessstage = default(MicrosoftDynamicsCRMprocessstage), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), string traversedpath = default(string), MicrosoftDynamicsCRMuom uomid = default(MicrosoftDynamicsCRMuom), MicrosoftDynamicsCRMuomschedule uomscheduleid = default(MicrosoftDynamicsCRMuomschedule), object versionnumber = default(object))
        {
            ProductPriceLevelAsyncOperations = productPriceLevelAsyncOperations;
            ProductPriceLevelBulkDeleteFailures = productPriceLevelBulkDeleteFailures;
            ProductPriceLevelSyncErrors = productPriceLevelSyncErrors;
            this._createdbyValue = _createdbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._discounttypeidValue = _discounttypeidValue;
            this._modifiedbyValue = _modifiedbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._pricelevelidValue = _pricelevelidValue;
            this._productidValue = _productidValue;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            this._uomidValue = _uomidValue;
            this._uomscheduleidValue = _uomscheduleidValue;
            Amount = amount;
            AmountBase = amountBase;
            Createdby = createdby;
            Createdon = createdon;
            Createdonbehalfby = createdonbehalfby;
            Discounttypeid = discounttypeid;
            Exchangerate = exchangerate;
            Importsequencenumber = importsequencenumber;
            Modifiedby = modifiedby;
            Modifiedon = modifiedon;
            Modifiedonbehalfby = modifiedonbehalfby;
            Organizationid = organizationid;
            Overriddencreatedon = overriddencreatedon;
            Percentage = percentage;
            Pricelevelid = pricelevelid;
            Pricingmethodcode = pricingmethodcode;
            Processid = processid;
            Productid = productid;
            Productnumber = productnumber;
            Productpricelevelid = productpricelevelid;
            Quantitysellingcode = quantitysellingcode;
            Roundingoptionamount = roundingoptionamount;
            RoundingoptionamountBase = roundingoptionamountBase;
            Roundingoptioncode = roundingoptioncode;
            Roundingpolicycode = roundingpolicycode;
            Stageid = stageid;
            StageidProcessstage = stageidProcessstage;
            Transactioncurrencyid = transactioncurrencyid;
            Traversedpath = traversedpath;
            Uomid = uomid;
            Uomscheduleid = uomscheduleid;
            Versionnumber = versionnumber;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProductPriceLevel_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> ProductPriceLevelAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProductPriceLevel_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> ProductPriceLevelBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProductPriceLevel_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> ProductPriceLevelSyncErrors { get; set; }

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
        [JsonProperty(PropertyName = "_discounttypeid_value")]
        public string _discounttypeidValue { get; set; }

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
        [JsonProperty(PropertyName = "_pricelevelid_value")]
        public string _pricelevelidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_productid_value")]
        public string _productidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_uomid_value")]
        public string _uomidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_uomscheduleid_value")]
        public string _uomscheduleidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "amount_base")]
        public double? AmountBase { get; set; }

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
        [JsonProperty(PropertyName = "discounttypeid")]
        public MicrosoftDynamicsCRMdiscounttype Discounttypeid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public double? Exchangerate { get; set; }

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
        [JsonProperty(PropertyName = "organizationid")]
        public string Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "percentage")]
        public double? Percentage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pricelevelid")]
        public MicrosoftDynamicsCRMpricelevel Pricelevelid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pricingmethodcode")]
        public int? Pricingmethodcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public string Processid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productid")]
        public MicrosoftDynamicsCRMproduct Productid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productnumber")]
        public string Productnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productpricelevelid")]
        public string Productpricelevelid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quantitysellingcode")]
        public int? Quantitysellingcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "roundingoptionamount")]
        public double? Roundingoptionamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "roundingoptionamount_base")]
        public double? RoundingoptionamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "roundingoptioncode")]
        public int? Roundingoptioncode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "roundingpolicycode")]
        public int? Roundingpolicycode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid")]
        public string Stageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid_processstage")]
        public MicrosoftDynamicsCRMprocessstage StageidProcessstage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "traversedpath")]
        public string Traversedpath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uomid")]
        public MicrosoftDynamicsCRMuom Uomid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uomscheduleid")]
        public MicrosoftDynamicsCRMuomschedule Uomscheduleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public object Versionnumber { get; set; }

    }
}
