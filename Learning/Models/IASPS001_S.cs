﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.7.3081.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class IASPS001 {
    
    private IASPS001Header[] headerField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Header", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public IASPS001Header[] Header {
        get {
            return this.headerField;
        }
        set {
            this.headerField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class IASPS001Header {
    
    private int parentLineField;
    
    private string dealerCodeField;
    
    private string invoiceNumberField;
    
    private string customerCodeField;
    
    private string customerTypeField;
    
    private string customerNameField;
    
    private string genderField;
    
    private string taxIDField;
    
    private string customerBranchTaxIDField;
    
    private string houseNumberField;
    
    private string addressField;
    
    private string roomNoField;
    
    private string buildingField;
    
    private string villageField;
    
    private string soiField;
    
    private string mooField;
    
    private string roadField;
    
    private string subDistrictField;
    
    private string districtField;
    
    private string provinceField;
    
    private string zipCodeField;
    
    private string telephoneNumberField;
    
    private string occupationRemarkField;
    
    private string businessTypeRemarkField;
    
    private string salesOrderTypeField;
    
    private string paymentMethodField;
    
    private string invoiceIssuedDateField;
    
    private string totalRetailPriceField;
    
    private string totalDiscountAmountField;
    
    private string invoiceAmountWithoutTaxField;
    
    private string taxAmountField;
    
    private string branchCodeField;
    
    private string calendarYearField;
    
    private string calendarMonthField;
    
    private string salesOrderStatusField;
    
    private string paymentTermField;
    
    private string orderDueDateField;
    
    private string referenceDocumentNumberField;
    
    private string returnReasonField;
    
    private string totalCostField;
    
    private string profitField;
    
    private string sDDocumentCurrencyField;
    
    private string totalAmountField;
    
    private string transactionDateField;
    
    private string vINNumberField;
    
    private string engineNumberField;
    
    private string chassisNumberField;
    
    private IASPS001HeaderPartSaleData[] partSaleDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int ParentLine {
        get {
            return this.parentLineField;
        }
        set {
            this.parentLineField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string DealerCode {
        get {
            return this.dealerCodeField;
        }
        set {
            this.dealerCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string InvoiceNumber {
        get {
            return this.invoiceNumberField;
        }
        set {
            this.invoiceNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string CustomerCode {
        get {
            return this.customerCodeField;
        }
        set {
            this.customerCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string CustomerType {
        get {
            return this.customerTypeField;
        }
        set {
            this.customerTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string CustomerName {
        get {
            return this.customerNameField;
        }
        set {
            this.customerNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Gender {
        get {
            return this.genderField;
        }
        set {
            this.genderField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string TaxID {
        get {
            return this.taxIDField;
        }
        set {
            this.taxIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string CustomerBranchTaxID {
        get {
            return this.customerBranchTaxIDField;
        }
        set {
            this.customerBranchTaxIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string HouseNumber {
        get {
            return this.houseNumberField;
        }
        set {
            this.houseNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Address {
        get {
            return this.addressField;
        }
        set {
            this.addressField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string RoomNo {
        get {
            return this.roomNoField;
        }
        set {
            this.roomNoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Building {
        get {
            return this.buildingField;
        }
        set {
            this.buildingField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Village {
        get {
            return this.villageField;
        }
        set {
            this.villageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Soi {
        get {
            return this.soiField;
        }
        set {
            this.soiField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Moo {
        get {
            return this.mooField;
        }
        set {
            this.mooField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Road {
        get {
            return this.roadField;
        }
        set {
            this.roadField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string SubDistrict {
        get {
            return this.subDistrictField;
        }
        set {
            this.subDistrictField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string District {
        get {
            return this.districtField;
        }
        set {
            this.districtField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Province {
        get {
            return this.provinceField;
        }
        set {
            this.provinceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ZipCode {
        get {
            return this.zipCodeField;
        }
        set {
            this.zipCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string TelephoneNumber {
        get {
            return this.telephoneNumberField;
        }
        set {
            this.telephoneNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string OccupationRemark {
        get {
            return this.occupationRemarkField;
        }
        set {
            this.occupationRemarkField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string BusinessTypeRemark {
        get {
            return this.businessTypeRemarkField;
        }
        set {
            this.businessTypeRemarkField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string SalesOrderType {
        get {
            return this.salesOrderTypeField;
        }
        set {
            this.salesOrderTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string PaymentMethod {
        get {
            return this.paymentMethodField;
        }
        set {
            this.paymentMethodField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string InvoiceIssuedDate {
        get {
            return this.invoiceIssuedDateField;
        }
        set {
            this.invoiceIssuedDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string TotalRetailPrice {
        get {
            return this.totalRetailPriceField;
        }
        set {
            this.totalRetailPriceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string TotalDiscountAmount {
        get {
            return this.totalDiscountAmountField;
        }
        set {
            this.totalDiscountAmountField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string InvoiceAmountWithoutTax {
        get {
            return this.invoiceAmountWithoutTaxField;
        }
        set {
            this.invoiceAmountWithoutTaxField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string TaxAmount {
        get {
            return this.taxAmountField;
        }
        set {
            this.taxAmountField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string BranchCode {
        get {
            return this.branchCodeField;
        }
        set {
            this.branchCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string CalendarYear {
        get {
            return this.calendarYearField;
        }
        set {
            this.calendarYearField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string CalendarMonth {
        get {
            return this.calendarMonthField;
        }
        set {
            this.calendarMonthField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string SalesOrderStatus {
        get {
            return this.salesOrderStatusField;
        }
        set {
            this.salesOrderStatusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string PaymentTerm {
        get {
            return this.paymentTermField;
        }
        set {
            this.paymentTermField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string OrderDueDate {
        get {
            return this.orderDueDateField;
        }
        set {
            this.orderDueDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ReferenceDocumentNumber {
        get {
            return this.referenceDocumentNumberField;
        }
        set {
            this.referenceDocumentNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ReturnReason {
        get {
            return this.returnReasonField;
        }
        set {
            this.returnReasonField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string TotalCost {
        get {
            return this.totalCostField;
        }
        set {
            this.totalCostField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Profit {
        get {
            return this.profitField;
        }
        set {
            this.profitField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string SDDocumentCurrency {
        get {
            return this.sDDocumentCurrencyField;
        }
        set {
            this.sDDocumentCurrencyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string TotalAmount {
        get {
            return this.totalAmountField;
        }
        set {
            this.totalAmountField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string TransactionDate {
        get {
            return this.transactionDateField;
        }
        set {
            this.transactionDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string VINNumber {
        get {
            return this.vINNumberField;
        }
        set {
            this.vINNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string EngineNumber {
        get {
            return this.engineNumberField;
        }
        set {
            this.engineNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ChassisNumber {
        get {
            return this.chassisNumberField;
        }
        set {
            this.chassisNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PartSaleData", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public IASPS001HeaderPartSaleData[] PartSaleData {
        get {
            return this.partSaleDataField;
        }
        set {
            this.partSaleDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class IASPS001HeaderPartSaleData {
    
    private int parentLineField;
    
    private string partNumberField;
    
    private string itemNumberField;
    
    private string sONumberRONumberField;
    
    private string sOItemROItemField;
    
    private string issueQuantityField;
    
    private string supplyPartNumberField;
    
    private string supplyPartNameField;
    
    private string modelGroupField;
    
    private string modelNameField;
    
    private string modelTypeField;
    
    private string retailPriceBeforeDiscountField;
    
    private string unitPriceAfterDiscountField;
    
    private string discountRateField;
    
    private string discountAmountField;
    
    private string unitCostField;
    
    private string vATRateField;
    
    private string vATAmountField;
    
    private string amountField;
    
    private string costAmountField;
    
    private string totalSalesAmountInclVATField;
    
    private string salesUnitOfMeasureField;
    
    private string issueQuantityInBaseUnitField;
    
    private string baseUnitOfMeasureField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int ParentLine {
        get {
            return this.parentLineField;
        }
        set {
            this.parentLineField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string PartNumber {
        get {
            return this.partNumberField;
        }
        set {
            this.partNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ItemNumber {
        get {
            return this.itemNumberField;
        }
        set {
            this.itemNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string SONumberRONumber {
        get {
            return this.sONumberRONumberField;
        }
        set {
            this.sONumberRONumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string SOItemROItem {
        get {
            return this.sOItemROItemField;
        }
        set {
            this.sOItemROItemField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string IssueQuantity {
        get {
            return this.issueQuantityField;
        }
        set {
            this.issueQuantityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string SupplyPartNumber {
        get {
            return this.supplyPartNumberField;
        }
        set {
            this.supplyPartNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string SupplyPartName {
        get {
            return this.supplyPartNameField;
        }
        set {
            this.supplyPartNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ModelGroup {
        get {
            return this.modelGroupField;
        }
        set {
            this.modelGroupField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ModelName {
        get {
            return this.modelNameField;
        }
        set {
            this.modelNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ModelType {
        get {
            return this.modelTypeField;
        }
        set {
            this.modelTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string RetailPriceBeforeDiscount {
        get {
            return this.retailPriceBeforeDiscountField;
        }
        set {
            this.retailPriceBeforeDiscountField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string UnitPriceAfterDiscount {
        get {
            return this.unitPriceAfterDiscountField;
        }
        set {
            this.unitPriceAfterDiscountField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string DiscountRate {
        get {
            return this.discountRateField;
        }
        set {
            this.discountRateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string DiscountAmount {
        get {
            return this.discountAmountField;
        }
        set {
            this.discountAmountField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string UnitCost {
        get {
            return this.unitCostField;
        }
        set {
            this.unitCostField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string VATRate {
        get {
            return this.vATRateField;
        }
        set {
            this.vATRateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string VATAmount {
        get {
            return this.vATAmountField;
        }
        set {
            this.vATAmountField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Amount {
        get {
            return this.amountField;
        }
        set {
            this.amountField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string CostAmount {
        get {
            return this.costAmountField;
        }
        set {
            this.costAmountField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string TotalSalesAmountInclVAT {
        get {
            return this.totalSalesAmountInclVATField;
        }
        set {
            this.totalSalesAmountInclVATField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string SalesUnitOfMeasure {
        get {
            return this.salesUnitOfMeasureField;
        }
        set {
            this.salesUnitOfMeasureField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string IssueQuantityInBaseUnit {
        get {
            return this.issueQuantityInBaseUnitField;
        }
        set {
            this.issueQuantityInBaseUnitField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string BaseUnitOfMeasure {
        get {
            return this.baseUnitOfMeasureField;
        }
        set {
            this.baseUnitOfMeasureField = value;
        }
    }
}
