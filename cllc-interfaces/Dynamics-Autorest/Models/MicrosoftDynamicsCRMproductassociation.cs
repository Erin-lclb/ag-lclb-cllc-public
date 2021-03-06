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

    public partial class MicrosoftDynamicsCRMproductassociation
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMproductassociation class.
        /// </summary>
        public MicrosoftDynamicsCRMproductassociation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMproductassociation class.
        /// </summary>
        public MicrosoftDynamicsCRMproductassociation(IList<MicrosoftDynamicsCRMasyncoperation> productAssociationAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMdynamicproperty> productAssociationDynamicProperty = default(IList<MicrosoftDynamicsCRMdynamicproperty>), IList<MicrosoftDynamicsCRMdynamicpropertyassociation> productAssociationDynamicPropertyAssociation = default(IList<MicrosoftDynamicsCRMdynamicpropertyassociation>), IList<MicrosoftDynamicsCRMsyncerror> productAssociationSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), string _associatedproductValue = default(string), string _createdbyValue = default(string), string _createdonbehalfbyValue = default(string), string _modifiedbyValue = default(string), string _modifiedonbehalfbyValue = default(string), string _organizationidValue = default(string), string _productidValue = default(string), string _transactioncurrencyidValue = default(string), string _uomidValue = default(string), MicrosoftDynamicsCRMproduct associatedproduct = default(MicrosoftDynamicsCRMproduct), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), int? dmtimportstate = default(int?), double? exchangerate = default(double?), int? importsequencenumber = default(int?), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), IList<MicrosoftDynamicsCRMinvoicedetail> productAssociationInvoiceDetails = default(IList<MicrosoftDynamicsCRMinvoicedetail>), IList<MicrosoftDynamicsCRMopportunityproduct> productAssociationOpportunityProduct = default(IList<MicrosoftDynamicsCRMopportunityproduct>), IList<MicrosoftDynamicsCRMquotedetail> productAssociationQuoteDetails = default(IList<MicrosoftDynamicsCRMquotedetail>), IList<MicrosoftDynamicsCRMsalesorderdetail> productAssociationSalesorderDetails = default(IList<MicrosoftDynamicsCRMsalesorderdetail>), string productassociationid = default(string), MicrosoftDynamicsCRMproduct productid = default(MicrosoftDynamicsCRMproduct), int? productisrequired = default(int?), int? propertycustomizationstatus = default(int?), double? quantity = default(double?), int? statecode = default(int?), int? statuscode = default(int?), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMuom uomid = default(MicrosoftDynamicsCRMuom), object versionnumber = default(object))
        {
            ProductAssociationAsyncOperations = productAssociationAsyncOperations;
            ProductAssociationDynamicProperty = productAssociationDynamicProperty;
            ProductAssociationDynamicPropertyAssociation = productAssociationDynamicPropertyAssociation;
            ProductAssociationSyncErrors = productAssociationSyncErrors;
            this._associatedproductValue = _associatedproductValue;
            this._createdbyValue = _createdbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._organizationidValue = _organizationidValue;
            this._productidValue = _productidValue;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            this._uomidValue = _uomidValue;
            Associatedproduct = associatedproduct;
            Createdby = createdby;
            Createdon = createdon;
            Createdonbehalfby = createdonbehalfby;
            Dmtimportstate = dmtimportstate;
            Exchangerate = exchangerate;
            Importsequencenumber = importsequencenumber;
            Modifiedby = modifiedby;
            Modifiedon = modifiedon;
            Modifiedonbehalfby = modifiedonbehalfby;
            Organizationid = organizationid;
            Overriddencreatedon = overriddencreatedon;
            ProductAssociationInvoiceDetails = productAssociationInvoiceDetails;
            ProductAssociationOpportunityProduct = productAssociationOpportunityProduct;
            ProductAssociationQuoteDetails = productAssociationQuoteDetails;
            ProductAssociationSalesorderDetails = productAssociationSalesorderDetails;
            Productassociationid = productassociationid;
            Productid = productid;
            Productisrequired = productisrequired;
            Propertycustomizationstatus = propertycustomizationstatus;
            Quantity = quantity;
            Statecode = statecode;
            Statuscode = statuscode;
            Transactioncurrencyid = transactioncurrencyid;
            Uomid = uomid;
            Versionnumber = versionnumber;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProductAssociation_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> ProductAssociationAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProductAssociation_DynamicProperty")]
        public IList<MicrosoftDynamicsCRMdynamicproperty> ProductAssociationDynamicProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProductAssociation_DynamicPropertyAssociation")]
        public IList<MicrosoftDynamicsCRMdynamicpropertyassociation> ProductAssociationDynamicPropertyAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProductAssociation_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> ProductAssociationSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_associatedproduct_value")]
        public string _associatedproductValue { get; set; }

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
        [JsonProperty(PropertyName = "associatedproduct")]
        public MicrosoftDynamicsCRMproduct Associatedproduct { get; set; }

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
        [JsonProperty(PropertyName = "dmtimportstate")]
        public int? Dmtimportstate { get; set; }

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
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productAssociation_invoice_details")]
        public IList<MicrosoftDynamicsCRMinvoicedetail> ProductAssociationInvoiceDetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productAssociation_opportunity_product")]
        public IList<MicrosoftDynamicsCRMopportunityproduct> ProductAssociationOpportunityProduct { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productAssociation_quote_details")]
        public IList<MicrosoftDynamicsCRMquotedetail> ProductAssociationQuoteDetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productAssociation_salesorder_details")]
        public IList<MicrosoftDynamicsCRMsalesorderdetail> ProductAssociationSalesorderDetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productassociationid")]
        public string Productassociationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productid")]
        public MicrosoftDynamicsCRMproduct Productid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productisrequired")]
        public int? Productisrequired { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "propertycustomizationstatus")]
        public int? Propertycustomizationstatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quantity")]
        public double? Quantity { get; set; }

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
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uomid")]
        public MicrosoftDynamicsCRMuom Uomid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public object Versionnumber { get; set; }

    }
}
