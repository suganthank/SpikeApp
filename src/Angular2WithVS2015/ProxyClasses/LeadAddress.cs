// <auto-generated />

using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Client;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ProxyClasses
{
    [EntityLogicalNameAttribute("leadaddress")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XrmToolkit", "4.0")]
    public partial class LeadAddress : BaseProxyClass
    {
        public new const string LogicalName = "leadaddress";
        public const int ObjectTypeCode = 1017;
        public const string PrimaryIdAttribute = "leadaddressid";
        public const string PrimaryNameAttribute = "";
        
        static LeadAddress()
        {
            BaseProxyClass.RegisterProxyType(typeof(LeadAddress), "leadaddress");
            _textOptions = new Dictionary<string, eTextOptions>();
            _numberOptions = new Dictionary<string, eNumberOptions>();
            _errorStrings = new Dictionary<string, string>();
            TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
            NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
        }
        public LeadAddress() : base(new Entity("leadaddress")) { }
        public LeadAddress(Entity original) : base(original) { }
        public static string GetLogicalName() { return BaseProxyClass.GetLogicalName<LeadAddress>(); }
        /// <summary>
        /// Action to perform when the string value is greater than the allowed length.
        /// <para>This is the default for any string attribute in this Entity</para>
        /// </summary>
        public static eTextOptions TextOptions { get; set; }
        private static Dictionary<string, eTextOptions> _textOptions;
        /// <summary>
        /// Use this to set an action and error string when a value is greater than the allowed length
        /// </summary>
        /// <param name="logicalName">Name of Attribute</param>
        /// <param name="options">Action to perform when the value is greater than the allowed length</param>
        /// <param name="errorString">Optional: Error to throw if the eTextOptions == ThrowError
        /// <para>If nothing is specified then the 'TextError' string is used.</para>
        /// <para>You may use the following parameters:</para>
        /// <para>{0} = Attribute Logical Name</para>
        /// <para>{1} = Value</para>
        /// <para>{2} = Length</para>
        /// <para>{3} = Max Length</para>
        /// </param>
        public static void SetTextOptions(string logicalName, eTextOptions options, string errorString = null)
        {
            if (_textOptions.ContainsKey(logicalName)) { _textOptions[logicalName] = options; }
            else { _textOptions.Add(logicalName, options); }
            if (!string.IsNullOrEmpty(errorString))
            {
                if (_errorStrings.ContainsKey(logicalName)) { _errorStrings[logicalName] = errorString; }
                else { _errorStrings.Add(logicalName, errorString); }
            }
            else if (_errorStrings.ContainsKey(logicalName)) { _errorStrings.Remove(logicalName); }
        }
        protected override eTextOptions GetTextOptions(string logicalName)
        {
            if (_textOptions.ContainsKey(logicalName)) { return _textOptions[logicalName]; }
            return TextOptions;
        }
        /// <summary>
        /// Action to perform when the number value is greater or less than the allowed value.
        /// <para>This is the default for any int, decimal, double, or money attribute in this Entity</para>
        /// </summary>
        public static eNumberOptions NumberOptions { get; set; }
        private static Dictionary<string, eNumberOptions> _numberOptions;
        /// <summary>
        /// Use this to set an action and error string when a value is greater or less than the allowed value
        /// </summary>
        /// <param name="logicalName">Name of Attribute</param>
        /// <param name="options">Action to perform when the value is greater or less than the allowed value</param>
        /// <param name="errorString">Optional: Error to throw if the eNumberOptions == ThrowError
        /// <para>If nothing is specified then the 'NumberError' string is used.</para>
        /// <para>You may use the following parameters:</para>
        /// <para>{0} = Attribute Logical Name</para>
        /// <para>{1} = Value</para>
        /// <para>{2} = Min Value</para>
        /// <para>{3} = Max Value</para>
        /// </param>
        public static void SetNumberOptions(string logicalName, eNumberOptions options, string errorString = null)
        {
            if (_numberOptions.ContainsKey(logicalName)) { _numberOptions[logicalName] = options; }
            else { _numberOptions.Add(logicalName, options); }
            if (!string.IsNullOrEmpty(errorString))
            {
                if (_errorStrings.ContainsKey(logicalName)) { _errorStrings[logicalName] = errorString; }
                else { _errorStrings.Add(logicalName, errorString); }
            }
            else if (_errorStrings.ContainsKey(logicalName)) { _errorStrings.Remove(logicalName); }
        }
        protected override eNumberOptions GetNumberOptions(string logicalName)
        {
            if (_numberOptions.ContainsKey(logicalName)) { return _numberOptions[logicalName]; }
            return NumberOptions;
        }
        private static Dictionary<string, string> _errorStrings;
        protected override string GetErrorString(string attributeName, BaseProxyClass.eErrorType defaultErrorType)
        {
            if (_errorStrings.ContainsKey(attributeName))
            {
                return _errorStrings[attributeName];
            }
            return defaultErrorType == BaseProxyClass.eErrorType.Text ? TextError : NumberError;
        }
        /// <summary>
        /// <para>Default error string is: The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.</para>
        /// <para>You may use the following parameters</para>
        /// <para>{0} = Attribute Name</para>
        /// <para>{1} = Value</para>
        /// <para>{2} = Length</para>
        /// <para>{3} = Max Length</para>
        /// </summary>
        public static string TextError { get; set; }
        /// <summary>
        /// <para>Default error string is: The value for attribute '{0}' must be between {2} and {3}. The value is {1}.</para>
        /// <para>You may use the following parameters</para>
        /// <para>{0} = Attribute Name</para>
        /// <para>{1} = Value</para>
        /// <para>{2} = Min Value</para>
        /// <para>{3} = Max Value</para>
        /// </summary>
        public static string NumberError { get; set; }

        ///<summary>
///<para>Logical Name: createdonbehalfbyyominame</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("createdonbehalfbyyominame")]
public string CreatedOnBehalfByYomiName
{
	get { return this.GetPropertyValue<string>("createdonbehalfbyyominame"); }
}
///<summary>
///<para>Logical Name: transactioncurrencyidname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("transactioncurrencyidname")]
public string TransactionCurrencyIdName
{
	get { return this.GetPropertyValue<string>("transactioncurrencyidname"); }
}
///<summary>
///<para>Logical Name: parentidyominame</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("parentidyominame")]
public string ParentIdYomiName
{
	get { return this.GetPropertyValue<string>("parentidyominame"); }
}
///<summary>
///<para>Logical Name: owningbusinessunit</para>
///</summary>
[AttributeLogicalNameAttribute("owningbusinessunit")]
public Guid OwningBusinessUnit
{
	get { return this.GetPropertyValue<Guid>("owningbusinessunit"); }
}
///<summary>
///<para>Logical Name: createdbyyominame</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("createdbyyominame")]
public string CreatedByYomiName
{
	get { return this.GetPropertyValue<string>("createdbyyominame"); }
}
///<summary>
///<para>Logical Name: modifiedbyname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("modifiedbyname")]
public string ModifiedByName
{
	get { return this.GetPropertyValue<string>("modifiedbyname"); }
}
///<summary>
///<para>Logical Name: modifiedbyyominame</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("modifiedbyyominame")]
public string ModifiedByYomiName
{
	get { return this.GetPropertyValue<string>("modifiedbyyominame"); }
}
///<summary>
///<para>Logical Name: parentidname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("parentidname")]
public string ParentIdName
{
	get { return this.GetPropertyValue<string>("parentidname"); }
}
///<summary>
///<para>Logical Name: modifiedonbehalfbyyominame</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("modifiedonbehalfbyyominame")]
public string ModifiedOnBehalfByYomiName
{
	get { return this.GetPropertyValue<string>("modifiedonbehalfbyyominame"); }
}
///<summary>
///<para>Logical Name: modifiedonbehalfbyname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("modifiedonbehalfbyname")]
public string ModifiedOnBehalfByName
{
	get { return this.GetPropertyValue<string>("modifiedonbehalfbyname"); }
}
///<summary>
///<para>Logical Name: createdbyname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("createdbyname")]
public string CreatedByName
{
	get { return this.GetPropertyValue<string>("createdbyname"); }
}
///<summary>
///<para>Logical Name: createdonbehalfbyname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("createdonbehalfbyname")]
public string CreatedOnBehalfByName
{
	get { return this.GetPropertyValue<string>("createdonbehalfbyname"); }
}
///<summary>
///<para>Logical Name: ownerid</para>
///</summary>
[AttributeLogicalNameAttribute("ownerid")]
public Guid OwnerId
{
	get { return this.GetPropertyValue<Guid>("ownerid"); }
}
///<summary>
///<para>Logical Name: composite</para>
///<para>Max Length: 1000 characters</para>
///</summary>
[AttributeLogicalNameAttribute("composite")]
public string Address
{
	get { return this.GetPropertyValue<string>("composite"); }
}
///<summary>
///<para>Key Property (Uniqueidentifier)</para>
///<para>Logical Name: leadaddressid</para>
///</summary>
[AttributeLogicalNameAttribute("leadaddressid")]
public Guid AddressId
{
	get
	{
		return this.Id;
	}
	set
	{
		this.Id = value;
	}
}
///<summary>
///<para>Logical Name: name</para>
///<para>Max Length: 200 characters</para>
///</summary>
[AttributeLogicalNameAttribute("name")]
public string AddressName
{
	get { return this.GetPropertyValue<string>("name"); }
	set { this.SetPropertyValue("name", value, 200, "AddressName"); }
}
///<summary>
///<para>Logical Name: addressnumber</para>
///<para>Minimum Value: -2147483648</para>
///<para>Maximum Value: 2147483647</para>
///</summary>
[AttributeLogicalNameAttribute("addressnumber")]
public int? AddressNumber
{
	get { return this.GetPropertyValue<int?>("addressnumber"); }
	set { this.SetPropertyValue("addressnumber", (int?)value, (int)-2147483648, (int)2147483647, "AddressNumber"); }
}
///<summary>
///<para>Logical Name: addresstypecode</para>
///</summary>
[AttributeLogicalNameAttribute("addresstypecode")]
public OptionSetValue AddressType
{
	get { return this.GetPropertyValue<OptionSetValue>("addresstypecode"); }
	set { this.SetPropertyValue<OptionSetValue>("addresstypecode", value, "AddressType"); }
}
///<summary>
///<para>Logical Name: city</para>
///<para>Max Length: 80 characters</para>
///</summary>
[AttributeLogicalNameAttribute("city")]
public string City
{
	get { return this.GetPropertyValue<string>("city"); }
	set { this.SetPropertyValue("city", value, 80, "City"); }
}
///<summary>
///<para>Logical Name: country</para>
///<para>Max Length: 80 characters</para>
///</summary>
[AttributeLogicalNameAttribute("country")]
public string Country_Region
{
	get { return this.GetPropertyValue<string>("country"); }
	set { this.SetPropertyValue("country", value, 80, "Country_Region"); }
}
///<summary>
///<para>Logical Name: county</para>
///<para>Max Length: 50 characters</para>
///</summary>
[AttributeLogicalNameAttribute("county")]
public string County
{
	get { return this.GetPropertyValue<string>("county"); }
	set { this.SetPropertyValue("county", value, 50, "County"); }
}
///<summary>
///<para>Logical Name: createdby</para>
///</summary>
[AttributeLogicalNameAttribute("createdby")]
public EntityReference CreatedBy
{
	get { return this.GetPropertyValue<EntityReference>("createdby"); }
}
///<summary>
///<para>Logical Name: createdonbehalfby</para>
///</summary>
[AttributeLogicalNameAttribute("createdonbehalfby")]
public EntityReference CreatedBy_Delegate
{
	get { return this.GetPropertyValue<EntityReference>("createdonbehalfby"); }
}
///<summary>
///<para>Logical Name: createdon</para>
///</summary>
[AttributeLogicalNameAttribute("createdon")]
public DateTime? CreatedOn
{
	get { return this.GetPropertyValue<DateTime?>("createdon"); }
}
///<summary>
///<para>Logical Name: transactioncurrencyid</para>
///</summary>
[AttributeLogicalNameAttribute("transactioncurrencyid")]
public EntityReference Currency
{
	get { return this.GetPropertyValue<EntityReference>("transactioncurrencyid"); }
	set { this.SetPropertyValue<EntityReference>("transactioncurrencyid", value, "Currency"); }
}
///<summary>
///<para>Logical Name: exchangerate</para>
///<para>Minimum Value: 0.0000000001</para>
///<para>Maximum Value: 100000000000</para>
///<para>Precision: 10</para>
///</summary>
[AttributeLogicalNameAttribute("exchangerate")]
public decimal? ExchangeRate
{
	get { return this.GetPropertyValue<decimal?>("exchangerate"); }
}
///<summary>
///<para>Logical Name: fax</para>
///<para>Max Length: 50 characters</para>
///</summary>
[AttributeLogicalNameAttribute("fax")]
public string Fax
{
	get { return this.GetPropertyValue<string>("fax"); }
	set { this.SetPropertyValue("fax", value, 50, "Fax"); }
}
///<summary>
///<para>Logical Name: latitude</para>
///<para>Minimum Value: -90</para>
///<para>Maximum Value: 90</para>
///<para>Precision: 5</para>
///</summary>
[AttributeLogicalNameAttribute("latitude")]
public double? Latitude
{
	get { return this.GetPropertyValue<double?>("latitude"); }
	set { this.SetPropertyValue("latitude", (double?)value, (double)-90, (double)90, "Latitude"); }
}
///<summary>
///<para>Logical Name: longitude</para>
///<para>Minimum Value: -180</para>
///<para>Maximum Value: 180</para>
///<para>Precision: 5</para>
///</summary>
[AttributeLogicalNameAttribute("longitude")]
public double? Longitude
{
	get { return this.GetPropertyValue<double?>("longitude"); }
	set { this.SetPropertyValue("longitude", (double?)value, (double)-180, (double)180, "Longitude"); }
}
///<summary>
///<para>Logical Name: telephone1</para>
///<para>Max Length: 50 characters</para>
///</summary>
[AttributeLogicalNameAttribute("telephone1")]
public string MainPhone
{
	get { return this.GetPropertyValue<string>("telephone1"); }
	set { this.SetPropertyValue("telephone1", value, 50, "MainPhone"); }
}
///<summary>
///<para>Logical Name: modifiedby</para>
///</summary>
[AttributeLogicalNameAttribute("modifiedby")]
public EntityReference ModifiedBy
{
	get { return this.GetPropertyValue<EntityReference>("modifiedby"); }
}
///<summary>
///<para>Logical Name: modifiedonbehalfby</para>
///</summary>
[AttributeLogicalNameAttribute("modifiedonbehalfby")]
public EntityReference ModifiedBy_Delegate
{
	get { return this.GetPropertyValue<EntityReference>("modifiedonbehalfby"); }
}
///<summary>
///<para>Logical Name: modifiedon</para>
///</summary>
[AttributeLogicalNameAttribute("modifiedon")]
public DateTime? ModifiedOn
{
	get { return this.GetPropertyValue<DateTime?>("modifiedon"); }
}
///<summary>
///<para>Logical Name: parentid</para>
///</summary>
[AttributeLogicalNameAttribute("parentid")]
public EntityReference Parent
{
	get { return this.GetPropertyValue<EntityReference>("parentid"); }
	set { this.SetPropertyValue<EntityReference>("parentid", value, "Parent"); }
}
///<summary>
///<para>Logical Name: telephone2</para>
///<para>Max Length: 50 characters</para>
///</summary>
[AttributeLogicalNameAttribute("telephone2")]
public string Phone2
{
	get { return this.GetPropertyValue<string>("telephone2"); }
	set { this.SetPropertyValue("telephone2", value, 50, "Phone2"); }
}
///<summary>
///<para>Logical Name: postofficebox</para>
///<para>Max Length: 20 characters</para>
///</summary>
[AttributeLogicalNameAttribute("postofficebox")]
public string PostOfficeBox
{
	get { return this.GetPropertyValue<string>("postofficebox"); }
	set { this.SetPropertyValue("postofficebox", value, 20, "PostOfficeBox"); }
}
///<summary>
///<para>Logical Name: shippingmethodcode</para>
///</summary>
[AttributeLogicalNameAttribute("shippingmethodcode")]
public OptionSetValue ShippingMethod
{
	get { return this.GetPropertyValue<OptionSetValue>("shippingmethodcode"); }
	set { this.SetPropertyValue<OptionSetValue>("shippingmethodcode", value, "ShippingMethod"); }
}
///<summary>
///<para>Logical Name: stateorprovince</para>
///<para>Max Length: 50 characters</para>
///</summary>
[AttributeLogicalNameAttribute("stateorprovince")]
public string State_Province
{
	get { return this.GetPropertyValue<string>("stateorprovince"); }
	set { this.SetPropertyValue("stateorprovince", value, 50, "State_Province"); }
}
///<summary>
///<para>Logical Name: line1</para>
///<para>Max Length: 250 characters</para>
///</summary>
[AttributeLogicalNameAttribute("line1")]
public string Street1
{
	get { return this.GetPropertyValue<string>("line1"); }
	set { this.SetPropertyValue("line1", value, 250, "Street1"); }
}
///<summary>
///<para>Logical Name: line2</para>
///<para>Max Length: 250 characters</para>
///</summary>
[AttributeLogicalNameAttribute("line2")]
public string Street2
{
	get { return this.GetPropertyValue<string>("line2"); }
	set { this.SetPropertyValue("line2", value, 250, "Street2"); }
}
///<summary>
///<para>Logical Name: line3</para>
///<para>Max Length: 250 characters</para>
///</summary>
[AttributeLogicalNameAttribute("line3")]
public string Street3
{
	get { return this.GetPropertyValue<string>("line3"); }
	set { this.SetPropertyValue("line3", value, 250, "Street3"); }
}
///<summary>
///<para>Logical Name: telephone3</para>
///<para>Max Length: 50 characters</para>
///</summary>
[AttributeLogicalNameAttribute("telephone3")]
public string Telephone3
{
	get { return this.GetPropertyValue<string>("telephone3"); }
	set { this.SetPropertyValue("telephone3", value, 50, "Telephone3"); }
}
///<summary>
///<para>Logical Name: upszone</para>
///<para>Max Length: 4 characters</para>
///</summary>
[AttributeLogicalNameAttribute("upszone")]
public string UPSZone
{
	get { return this.GetPropertyValue<string>("upszone"); }
	set { this.SetPropertyValue("upszone", value, 4, "UPSZone"); }
}
///<summary>
///<para>Logical Name: utcoffset</para>
///<para>Minimum Value: -2147483648</para>
///<para>Maximum Value: 2147483647</para>
///</summary>
[AttributeLogicalNameAttribute("utcoffset")]
public int? UTCOffset
{
	get { return this.GetPropertyValue<int?>("utcoffset"); }
	set { this.SetPropertyValue("utcoffset", (int?)value, (int)-2147483648, (int)2147483647, "UTCOffset"); }
}
///<summary>
///<para>Logical Name: versionnumber</para>
///</summary>
[AttributeLogicalNameAttribute("versionnumber")]
public int? VersionNumber
{
	get { return this.GetPropertyValue<int?>("versionnumber"); }
}
///<summary>
///<para>Logical Name: postalcode</para>
///<para>Max Length: 20 characters</para>
///</summary>
[AttributeLogicalNameAttribute("postalcode")]
public string ZIP_PostalCode
{
	get { return this.GetPropertyValue<string>("postalcode"); }
	set { this.SetPropertyValue("postalcode", value, 20, "ZIP_PostalCode"); }
}


        /// <summary>
/// <para><b>SyncError (Record)</b></para>
/// <para>Schema Name: LeadAddress_SyncErrors</para>
/// </summary>
public List<SyncError> GetSyncErrors_Record (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<SyncError>(Service, this.Id, "syncerror", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>SyncError (Record)</b></para>
/// <para>Schema Name: LeadAddress_SyncErrors</para>
/// </summary>
public List<SyncError> GetSyncErrors_Record (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<SyncError>(Service, this.Id, "syncerror", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>UserEntityInstanceData (Object Id)</b></para>
/// <para>Schema Name: userentityinstancedata_leadaddress</para>
/// </summary>
public List<UserEntityInstanceData> GetUserEntityInstanceData_ObjectId (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<UserEntityInstanceData>(Service, this.Id, "userentityinstancedata", "objectid", Columns); }
/// <summary>
/// <para><b>UserEntityInstanceData (Object Id)</b></para>
/// <para>Schema Name: userentityinstancedata_leadaddress</para>
/// </summary>
public List<UserEntityInstanceData> GetUserEntityInstanceData_ObjectId (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<UserEntityInstanceData>(Service, this.Id, "userentityinstancedata", "objectid", Columns); }


        

        

        

        public static class Properties
{
	/// <summary><para>createdonbehalfbyyominame</para>
	/// <para>createdonbehalfbyyominame</para></summary>
	public const string CreatedOnBehalfByYomiName = "createdonbehalfbyyominame";
	/// <summary><para>transactioncurrencyidname</para>
	/// <para>transactioncurrencyidname</para></summary>
	public const string TransactionCurrencyIdName = "transactioncurrencyidname";
	/// <summary><para>parentidyominame</para>
	/// <para>parentidyominame</para></summary>
	public const string ParentIdYomiName = "parentidyominame";
	/// <summary><para>owningbusinessunit</para>
	/// <para>owningbusinessunit</para></summary>
	public const string OwningBusinessUnit = "owningbusinessunit";
	/// <summary><para>createdbyyominame</para>
	/// <para>createdbyyominame</para></summary>
	public const string CreatedByYomiName = "createdbyyominame";
	/// <summary><para>modifiedbyname</para>
	/// <para>modifiedbyname</para></summary>
	public const string ModifiedByName = "modifiedbyname";
	/// <summary><para>modifiedbyyominame</para>
	/// <para>modifiedbyyominame</para></summary>
	public const string ModifiedByYomiName = "modifiedbyyominame";
	/// <summary><para>parentidname</para>
	/// <para>parentidname</para></summary>
	public const string ParentIdName = "parentidname";
	/// <summary><para>modifiedonbehalfbyyominame</para>
	/// <para>modifiedonbehalfbyyominame</para></summary>
	public const string ModifiedOnBehalfByYomiName = "modifiedonbehalfbyyominame";
	/// <summary><para>modifiedonbehalfbyname</para>
	/// <para>modifiedonbehalfbyname</para></summary>
	public const string ModifiedOnBehalfByName = "modifiedonbehalfbyname";
	/// <summary><para>createdbyname</para>
	/// <para>createdbyname</para></summary>
	public const string CreatedByName = "createdbyname";
	/// <summary><para>createdonbehalfbyname</para>
	/// <para>createdonbehalfbyname</para></summary>
	public const string CreatedOnBehalfByName = "createdonbehalfbyname";
	/// <summary><para>ownerid</para>
	/// <para>ownerid</para></summary>
	public const string OwnerId = "ownerid";
	/// <summary><para>Address</para>
	/// <para>composite</para></summary>
	public const string Address = "composite";
	/// <summary><para>Address</para>
	/// <para>leadaddressid</para></summary>
	public const string AddressId = "leadaddressid";
	/// <summary><para>Address Name</para>
	/// <para>name</para></summary>
	public const string AddressName = "name";
	/// <summary><para>Address Number</para>
	/// <para>addressnumber</para></summary>
	public const string AddressNumber = "addressnumber";
	/// <summary><para>Address Type</para>
	/// <para>addresstypecode</para></summary>
	public const string AddressType = "addresstypecode";
	/// <summary><para>City</para>
	/// <para>city</para></summary>
	public const string City = "city";
	/// <summary><para>Country/Region</para>
	/// <para>country</para></summary>
	public const string Country_Region = "country";
	/// <summary><para>County</para>
	/// <para>county</para></summary>
	public const string County = "county";
	/// <summary><para>Created By</para>
	/// <para>createdby</para></summary>
	public const string CreatedBy = "createdby";
	/// <summary><para>Created By (Delegate)</para>
	/// <para>createdonbehalfby</para></summary>
	public const string CreatedBy_Delegate = "createdonbehalfby";
	/// <summary><para>Created On</para>
	/// <para>createdon</para></summary>
	public const string CreatedOn = "createdon";
	/// <summary><para>Currency</para>
	/// <para>transactioncurrencyid</para></summary>
	public const string Currency = "transactioncurrencyid";
	/// <summary><para>Exchange Rate</para>
	/// <para>exchangerate</para></summary>
	public const string ExchangeRate = "exchangerate";
	/// <summary><para>Fax</para>
	/// <para>fax</para></summary>
	public const string Fax = "fax";
	/// <summary><para>Latitude</para>
	/// <para>latitude</para></summary>
	public const string Latitude = "latitude";
	/// <summary><para>Longitude</para>
	/// <para>longitude</para></summary>
	public const string Longitude = "longitude";
	/// <summary><para>Main Phone</para>
	/// <para>telephone1</para></summary>
	public const string MainPhone = "telephone1";
	/// <summary><para>Modified By</para>
	/// <para>modifiedby</para></summary>
	public const string ModifiedBy = "modifiedby";
	/// <summary><para>Modified By (Delegate)</para>
	/// <para>modifiedonbehalfby</para></summary>
	public const string ModifiedBy_Delegate = "modifiedonbehalfby";
	/// <summary><para>Modified On</para>
	/// <para>modifiedon</para></summary>
	public const string ModifiedOn = "modifiedon";
	/// <summary><para>Parent</para>
	/// <para>parentid</para></summary>
	public const string Parent = "parentid";
	/// <summary><para>Phone 2</para>
	/// <para>telephone2</para></summary>
	public const string Phone2 = "telephone2";
	/// <summary><para>Post Office Box</para>
	/// <para>postofficebox</para></summary>
	public const string PostOfficeBox = "postofficebox";
	/// <summary><para>Shipping Method</para>
	/// <para>shippingmethodcode</para></summary>
	public const string ShippingMethod = "shippingmethodcode";
	/// <summary><para>State/Province</para>
	/// <para>stateorprovince</para></summary>
	public const string State_Province = "stateorprovince";
	/// <summary><para>Street 1</para>
	/// <para>line1</para></summary>
	public const string Street1 = "line1";
	/// <summary><para>Street 2</para>
	/// <para>line2</para></summary>
	public const string Street2 = "line2";
	/// <summary><para>Street 3</para>
	/// <para>line3</para></summary>
	public const string Street3 = "line3";
	/// <summary><para>Telephone 3</para>
	/// <para>telephone3</para></summary>
	public const string Telephone3 = "telephone3";
	/// <summary><para>UPS Zone</para>
	/// <para>upszone</para></summary>
	public const string UPSZone = "upszone";
	/// <summary><para>UTC Offset</para>
	/// <para>utcoffset</para></summary>
	public const string UTCOffset = "utcoffset";
	/// <summary><para>Version Number</para>
	/// <para>versionnumber</para></summary>
	public const string VersionNumber = "versionnumber";
	/// <summary><para>ZIP/Postal Code</para>
	/// <para>postalcode</para></summary>
	public const string ZIP_PostalCode = "postalcode";
}

    }
}