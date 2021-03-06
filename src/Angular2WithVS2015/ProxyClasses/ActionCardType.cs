// <auto-generated />
using .ProxyClasses;
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
    [EntityLogicalNameAttribute("cardtype")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XrmToolkit", "4.0")]
    public partial class ActionCardType : BaseProxyClass
    {
        public new const string LogicalName = "cardtype";
        public const int ObjectTypeCode = 9983;
        public const string PrimaryIdAttribute = "cardtypeid";
        public const string PrimaryNameAttribute = "cardname";
        
        static ActionCardType()
        {
            BaseProxyClass.RegisterProxyType(typeof(ActionCardType), "cardtype");
            _textOptions = new Dictionary<string, eTextOptions>();
            _numberOptions = new Dictionary<string, eNumberOptions>();
            _errorStrings = new Dictionary<string, string>();
            TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
            NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
        }
        public ActionCardType() : base(new Entity("cardtype")) { }
        public ActionCardType(Entity original) : base(original) { }
        public static string GetLogicalName() { return BaseProxyClass.GetLogicalName<ActionCardType>(); }
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
///<para>Logical Name: modifiedonbehalfbyyominame</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("modifiedonbehalfbyyominame")]
public string ModifiedOnBehalfByYomiName
{
	get { return this.GetPropertyValue<string>("modifiedonbehalfbyyominame"); }
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
///<para>Logical Name: modifiedbyyominame</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("modifiedbyyominame")]
public string ModifiedByYomiName
{
	get { return this.GetPropertyValue<string>("modifiedbyyominame"); }
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
///<para>Logical Name: modifiedonbehalfbyname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("modifiedonbehalfbyname")]
public string ModifiedOnBehalfByName
{
	get { return this.GetPropertyValue<string>("modifiedonbehalfbyname"); }
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
///<para>Logical Name: intcardoption</para>
///<para>Minimum Value: -2147483648</para>
///<para>Maximum Value: 2147483647</para>
///</summary>
[AttributeLogicalNameAttribute("intcardoption")]
public int? AnyIntOptionForACardtype
{
	get { return this.GetPropertyValue<int?>("intcardoption"); }
	set { this.SetPropertyValue("intcardoption", (int?)value, (int)-2147483648, (int)2147483647, "AnyIntOptionForACardtype"); }
}
///<summary>
///<para>Logical Name: stringcardoption</para>
///<para>Max Length: 8192 characters</para>
///</summary>
[AttributeLogicalNameAttribute("stringcardoption")]
public string AnyStringOptionForACardtype
{
	get { return this.GetPropertyValue<string>("stringcardoption"); }
	set { this.SetPropertyValue("stringcardoption", value, 8192, "AnyStringOptionForACardtype"); }
}
///<summary>
///<para>Logical Name: boolcardoption</para>
///<para>True = Check</para>
///<para>False = Uncheck</para>
///</summary>
[AttributeLogicalNameAttribute("boolcardoption")]
public bool? BoleanOptionForACardtype
{
	get { return this.GetPropertyValue<bool?>("boolcardoption"); }
	set { this.SetPropertyValue<bool?>("boolcardoption", value, "BoleanOptionForACardtype"); }
}
/// <summary>
///Logical Name: clientavailability
/// </summary>
[AttributeLogicalNameAttribute("clientavailability")]
public eClientAvaiabilityForCardType? CardClientAvailability
{
	get
	{
		if (CardClientAvailability_OptionSetValue != null) { return (eClientAvaiabilityForCardType)CardClientAvailability_OptionSetValue.Value; }
		return null;
	}
	set
	{
		if (value != null) { this.CardClientAvailability_OptionSetValue = new OptionSetValue((int)value); }
		else this.CardClientAvailability_OptionSetValue = null;
	}
}
///<summary>
///<para>Logical Name: clientavailability</para>
///</summary>
[AttributeLogicalNameAttribute("clientavailability")]
public OptionSetValue CardClientAvailability_OptionSetValue
{
	get { return this.GetPropertyValue<OptionSetValue>("clientavailability"); }
	set { this.SetPropertyValue<OptionSetValue>("clientavailability", value, "CardClientAvailability_OptionSetValue"); }
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="Service">CRM Organization Service</param>
/// <returns></returns>
public string CardClientAvailability_Text(IOrganizationService Service)
{
	return this.CardClientAvailability_OptionSetValue.GetOptionSetText(Service, this, "clientavailability");
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="AttributeMetadata">The attribute metadata previously retrieved using the 'GetAttributeMetadata' extension method on the IOrganizationService object.</param>
/// <returns></returns>
public string CardClientAvailability_Text(EnumAttributeMetadata AttributeMetadata)
{
	return AttributeMetadata.GetOptionSetText(this.CardClientAvailability_OptionSetValue.Value);
}
///<summary>
///<para>Logical Name: cardname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("cardname")]
public string CardName
{
	get { return this.GetPropertyValue<string>("cardname"); }
	set { this.SetPropertyValue("cardname", value, 100, "CardName"); }
}
///<summary>
///<para>Key Property (Uniqueidentifier)</para>
///<para>Logical Name: cardtypeid</para>
///</summary>
[AttributeLogicalNameAttribute("cardtypeid")]
public Guid CardTypeId
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
///<para>Logical Name: cardtype</para>
///<para>Minimum Value: 0</para>
///<para>Maximum Value: 2147483647</para>
///</summary>
[AttributeLogicalNameAttribute("cardtype")]
public int? CardTypeENUM
{
	get { return this.GetPropertyValue<int?>("cardtype"); }
	set { this.SetPropertyValue("cardtype", (int?)value, (int)0, (int)2147483647, "CardTypeENUM"); }
}
///<summary>
///<para>Logical Name: cardtypeicon</para>
///<para>Max Length: 500 characters</para>
///</summary>
[AttributeLogicalNameAttribute("cardtypeicon")]
public string CardTypeIcon
{
	get { return this.GetPropertyValue<string>("cardtypeicon"); }
	set { this.SetPropertyValue("cardtypeicon", value, 500, "CardTypeIcon"); }
}
///<summary>
///<para>Logical Name: actions</para>
///<para>Max Length: 8192 characters</para>
///</summary>
[AttributeLogicalNameAttribute("actions")]
public string CommandBarActionsJSONDefinition
{
	get { return this.GetPropertyValue<string>("actions"); }
	set { this.SetPropertyValue("actions", value, 8192, "CommandBarActionsJSONDefinition"); }
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
///<para>Logical Name: grouptype</para>
///<para>Max Length: 200 characters</para>
///</summary>
[AttributeLogicalNameAttribute("grouptype")]
public string GroupType
{
	get { return this.GetPropertyValue<string>("grouptype"); }
	set { this.SetPropertyValue("grouptype", value, 200, "GroupType"); }
}
///<summary>
///<para>Logical Name: hassnoozedismiss</para>
///<para>True = Yes</para>
///<para>False = No</para>
///</summary>
[AttributeLogicalNameAttribute("hassnoozedismiss")]
public bool? HasSnoozeDismiss
{
	get { return this.GetPropertyValue<bool?>("hassnoozedismiss"); }
	set { this.SetPropertyValue<bool?>("hassnoozedismiss", value, "HasSnoozeDismiss"); }
}
///<summary>
///<para>Logical Name: isbasecard</para>
///<para>True = Yes</para>
///<para>False = No</para>
///</summary>
[AttributeLogicalNameAttribute("isbasecard")]
public bool? IsBaseCard
{
	get { return this.GetPropertyValue<bool?>("isbasecard"); }
	set { this.SetPropertyValue<bool?>("isbasecard", value, "IsBaseCard"); }
}
///<summary>
///<para>Logical Name: isenabled</para>
///<para>True = Yes</para>
///<para>False = No</para>
///</summary>
[AttributeLogicalNameAttribute("isenabled")]
public bool? IsEnabled
{
	get { return this.GetPropertyValue<bool?>("isenabled"); }
	set { this.SetPropertyValue<bool?>("isenabled", value, "IsEnabled"); }
}
///<summary>
///<para>Logical Name: isliveonly</para>
///<para>True = Yes</para>
///<para>False = No</para>
///</summary>
[AttributeLogicalNameAttribute("isliveonly")]
public bool? IsLiveOnly
{
	get { return this.GetPropertyValue<bool?>("isliveonly"); }
	set { this.SetPropertyValue<bool?>("isliveonly", value, "IsLiveOnly"); }
}
///<summary>
///<para>Logical Name: ispreviewcard</para>
///<para>True = Yes</para>
///<para>False = No</para>
///</summary>
[AttributeLogicalNameAttribute("ispreviewcard")]
public bool? IsPreviewCard
{
	get { return this.GetPropertyValue<bool?>("ispreviewcard"); }
	set { this.SetPropertyValue<bool?>("ispreviewcard", value, "IsPreviewCard"); }
}
///<summary>
///<para>Logical Name: lastsynctime</para>
///</summary>
[AttributeLogicalNameAttribute("lastsynctime")]
public DateTime? LastSyncTime
{
	get { return this.GetPropertyValue<DateTime?>("lastsynctime"); }
	set { this.SetPropertyValue<DateTime?>("lastsynctime", value, "LastSyncTime"); }
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
///<para>Logical Name: scheduletime</para>
///</summary>
[AttributeLogicalNameAttribute("scheduletime")]
public DateTime? ScheduleTime
{
	get { return this.GetPropertyValue<DateTime?>("scheduletime"); }
	set { this.SetPropertyValue<DateTime?>("scheduletime", value, "ScheduleTime"); }
}
///<summary>
///<para>Logical Name: softtitle</para>
///<para>Max Length: 200 characters</para>
///</summary>
[AttributeLogicalNameAttribute("softtitle")]
public string SoftTitle
{
	get { return this.GetPropertyValue<string>("softtitle"); }
	set { this.SetPropertyValue("softtitle", value, 200, "SoftTitle"); }
}
///<summary>
///<para>Logical Name: summarytext</para>
///<para>Max Length: 500 characters</para>
///</summary>
[AttributeLogicalNameAttribute("summarytext")]
public string SummaryText
{
	get { return this.GetPropertyValue<string>("summarytext"); }
	set { this.SetPropertyValue("summarytext", value, 500, "SummaryText"); }
}


        /// <summary>
/// <para><b>ActionCard (Card Type)</b></para>
/// <para>Schema Name: cardtype_actioncard</para>
/// </summary>
public List<ActionCard> GetActionCards_CardType (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<ActionCard>(Service, this.Id, "actioncard", "cardtypeid", Columns); }
/// <summary>
/// <para><b>ActionCard (Card Type)</b></para>
/// <para>Schema Name: cardtype_actioncard</para>
/// </summary>
public List<ActionCard> GetActionCards_CardType (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<ActionCard>(Service, this.Id, "actioncard", "cardtypeid", Columns); }
/// <summary>
/// <para><b>ActionCardUserSettings (card type)</b></para>
/// <para>Schema Name: cardtype_actioncardusersettings</para>
/// </summary>
public List<ActionCardUserSettings> GetActionCardUserSettings_cardType (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<ActionCardUserSettings>(Service, this.Id, "actioncardusersettings", "cardtypeid", Columns); }
/// <summary>
/// <para><b>ActionCardUserSettings (card type)</b></para>
/// <para>Schema Name: cardtype_actioncardusersettings</para>
/// </summary>
public List<ActionCardUserSettings> GetActionCardUserSettings_cardType (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<ActionCardUserSettings>(Service, this.Id, "actioncardusersettings", "cardtypeid", Columns); }


        

        

        public enum eClientAvaiabilityForCardType
{
	///<summary><para>WebClientOnly</para>
	///<para>Value = 1</para></summary>
	[Description("WebClientOnly")]
	WebClientOnly = 1, 
	///<summary><para>MocaOnly</para>
	///<para>Value = 2</para></summary>
	[Description("MocaOnly")]
	MocaOnly = 2, 
	///<summary><para>MocaAndWeb</para>
	///<para>Value = 3</para></summary>
	[Description("MocaAndWeb")]
	MocaAndWeb = 3
}


        public static class Properties
{
	/// <summary><para>createdonbehalfbyyominame</para>
	/// <para>createdonbehalfbyyominame</para></summary>
	public const string CreatedOnBehalfByYomiName = "createdonbehalfbyyominame";
	/// <summary><para>modifiedonbehalfbyyominame</para>
	/// <para>modifiedonbehalfbyyominame</para></summary>
	public const string ModifiedOnBehalfByYomiName = "modifiedonbehalfbyyominame";
	/// <summary><para>transactioncurrencyidname</para>
	/// <para>transactioncurrencyidname</para></summary>
	public const string TransactionCurrencyIdName = "transactioncurrencyidname";
	/// <summary><para>modifiedbyyominame</para>
	/// <para>modifiedbyyominame</para></summary>
	public const string ModifiedByYomiName = "modifiedbyyominame";
	/// <summary><para>createdbyyominame</para>
	/// <para>createdbyyominame</para></summary>
	public const string CreatedByYomiName = "createdbyyominame";
	/// <summary><para>modifiedbyname</para>
	/// <para>modifiedbyname</para></summary>
	public const string ModifiedByName = "modifiedbyname";
	/// <summary><para>createdbyname</para>
	/// <para>createdbyname</para></summary>
	public const string CreatedByName = "createdbyname";
	/// <summary><para>createdonbehalfbyname</para>
	/// <para>createdonbehalfbyname</para></summary>
	public const string CreatedOnBehalfByName = "createdonbehalfbyname";
	/// <summary><para>modifiedonbehalfbyname</para>
	/// <para>modifiedonbehalfbyname</para></summary>
	public const string ModifiedOnBehalfByName = "modifiedonbehalfbyname";
	/// <summary><para>versionnumber</para>
	/// <para>versionnumber</para></summary>
	public const string VersionNumber = "versionnumber";
	/// <summary><para>Any int option for a cardtype.</para>
	/// <para>intcardoption</para></summary>
	public const string AnyIntOptionForACardtype = "intcardoption";
	/// <summary><para>Any string option for a cardtype.</para>
	/// <para>stringcardoption</para></summary>
	public const string AnyStringOptionForACardtype = "stringcardoption";
	/// <summary><para>Bolean option for a cardtype.</para>
	/// <para>boolcardoption</para></summary>
	public const string BoleanOptionForACardtype = "boolcardoption";
	/// <summary><para>Card Client Availability</para>
	/// <para>clientavailability</para></summary>
	public const string CardClientAvailability = "clientavailability";
	/// <summary><para>CardName</para>
	/// <para>cardname</para></summary>
	public const string CardName = "cardname";
	/// <summary><para>CardType</para>
	/// <para>cardtypeid</para></summary>
	public const string CardTypeId = "cardtypeid";
	/// <summary><para>CardType ENUM</para>
	/// <para>cardtype</para></summary>
	public const string CardTypeENUM = "cardtype";
	/// <summary><para>CardTypeIcon</para>
	/// <para>cardtypeicon</para></summary>
	public const string CardTypeIcon = "cardtypeicon";
	/// <summary><para>CommandBar Actions JSON definition</para>
	/// <para>actions</para></summary>
	public const string CommandBarActionsJSONDefinition = "actions";
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
	/// <summary><para>ExchangeRate</para>
	/// <para>exchangerate</para></summary>
	public const string ExchangeRate = "exchangerate";
	/// <summary><para>GroupType</para>
	/// <para>grouptype</para></summary>
	public const string GroupType = "grouptype";
	/// <summary><para>HasSnoozeDismiss</para>
	/// <para>hassnoozedismiss</para></summary>
	public const string HasSnoozeDismiss = "hassnoozedismiss";
	/// <summary><para>IsBaseCard</para>
	/// <para>isbasecard</para></summary>
	public const string IsBaseCard = "isbasecard";
	/// <summary><para>IsEnabled</para>
	/// <para>isenabled</para></summary>
	public const string IsEnabled = "isenabled";
	/// <summary><para>IsLiveOnly</para>
	/// <para>isliveonly</para></summary>
	public const string IsLiveOnly = "isliveonly";
	/// <summary><para>IsPreviewCard</para>
	/// <para>ispreviewcard</para></summary>
	public const string IsPreviewCard = "ispreviewcard";
	/// <summary><para>LastSyncTime</para>
	/// <para>lastsynctime</para></summary>
	public const string LastSyncTime = "lastsynctime";
	/// <summary><para>Modified By</para>
	/// <para>modifiedby</para></summary>
	public const string ModifiedBy = "modifiedby";
	/// <summary><para>Modified By (Delegate)</para>
	/// <para>modifiedonbehalfby</para></summary>
	public const string ModifiedBy_Delegate = "modifiedonbehalfby";
	/// <summary><para>Modified On</para>
	/// <para>modifiedon</para></summary>
	public const string ModifiedOn = "modifiedon";
	/// <summary><para>ScheduleTime</para>
	/// <para>scheduletime</para></summary>
	public const string ScheduleTime = "scheduletime";
	/// <summary><para>Soft Title</para>
	/// <para>softtitle</para></summary>
	public const string SoftTitle = "softtitle";
	/// <summary><para>Summary Text</para>
	/// <para>summarytext</para></summary>
	public const string SummaryText = "summarytext";
}

    }
}
