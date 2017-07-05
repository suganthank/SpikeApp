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
    [EntityLogicalNameAttribute("delveactionhub")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XrmToolkit", "4.0")]
    public partial class DelveActionHub : BaseProxyClass
    {
        public new const string LogicalName = "delveactionhub";
        public const int ObjectTypeCode = 9961;
        public const string PrimaryIdAttribute = "delveactionhubid";
        public const string PrimaryNameAttribute = "subject";
        
        static DelveActionHub()
        {
            BaseProxyClass.RegisterProxyType(typeof(DelveActionHub), "delveactionhub");
            _textOptions = new Dictionary<string, eTextOptions>();
            _numberOptions = new Dictionary<string, eNumberOptions>();
            _errorStrings = new Dictionary<string, string>();
            TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
            NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
        }
        public DelveActionHub() : base(new Entity("delveactionhub")) { }
        public DelveActionHub(Entity original) : base(original) { }
        public static string GetLogicalName() { return BaseProxyClass.GetLogicalName<DelveActionHub>(); }
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
///<para>Logical Name: recordidobjecttypecode</para>
///</summary>
[AttributeLogicalNameAttribute("recordidobjecttypecode")]
public string RecordIdObjectTypeCode
{
	get { return this.GetPropertyValue<string>("recordidobjecttypecode"); }
	set { this.SetPropertyValue<string>("recordidobjecttypecode", value, "RecordIdObjectTypeCode"); }
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
///<para>Logical Name: recordidname</para>
///<para>Max Length: 400 characters</para>
///</summary>
[AttributeLogicalNameAttribute("recordidname")]
public string RecordIdName
{
	get { return this.GetPropertyValue<string>("recordidname"); }
}
///<summary>
///<para>Logical Name: regardingobjectidname</para>
///<para>Max Length: 256 characters</para>
///</summary>
[AttributeLogicalNameAttribute("regardingobjectidname")]
public string RegardingObjectIdName
{
	get { return this.GetPropertyValue<string>("regardingobjectidname"); }
	set { this.SetPropertyValue("regardingobjectidname", value, 256, "RegardingObjectIdName"); }
}
///<summary>
///<para>Logical Name: regardingobjecttypecode</para>
///</summary>
[AttributeLogicalNameAttribute("regardingobjecttypecode")]
public string RegardingObjectTypeCode
{
	get { return this.GetPropertyValue<string>("regardingobjecttypecode"); }
	set { this.SetPropertyValue<string>("regardingobjecttypecode", value, "RegardingObjectTypeCode"); }
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
///<para>Logical Name: organizationidname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("organizationidname")]
public string OrganizationIdName
{
	get { return this.GetPropertyValue<string>("organizationidname"); }
}
///<summary>
///<para>Logical Name: recordiddsc</para>
///<para>Minimum Value: -2147483648</para>
///<para>Maximum Value: 2147483647</para>
///</summary>
[AttributeLogicalNameAttribute("recordiddsc")]
public int? RecordIdDsc
{
	get { return this.GetPropertyValue<int?>("recordiddsc"); }
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
///<para>Logical Name: versionnumber</para>
///</summary>
[AttributeLogicalNameAttribute("versionnumber")]
public int? VersionNumber
{
	get { return this.GetPropertyValue<int?>("versionnumber"); }
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
///<para>Logical Name: regardingobjectiddsc</para>
///<para>Minimum Value: -2147483648</para>
///<para>Maximum Value: 2147483647</para>
///</summary>
[AttributeLogicalNameAttribute("regardingobjectiddsc")]
public int? RegardingObjectIdDsc
{
	get { return this.GetPropertyValue<int?>("regardingobjectiddsc"); }
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
///<para>Logical Name: description</para>
///<para>Max Length: 8192 characters</para>
///</summary>
[AttributeLogicalNameAttribute("description")]
public string CardDescription
{
	get { return this.GetPropertyValue<string>("description"); }
	set { this.SetPropertyValue("description", value, 8192, "CardDescription"); }
}
/// <summary>
///Logical Name: cardtype
/// </summary>
[AttributeLogicalNameAttribute("cardtype")]
public eCardType? CardType
{
	get
	{
		if (CardType_OptionSetValue != null) { return (eCardType)CardType_OptionSetValue.Value; }
		return null;
	}
}
///<summary>
///<para>Logical Name: cardtype</para>
///</summary>
[AttributeLogicalNameAttribute("cardtype")]
public OptionSetValue CardType_OptionSetValue
{
	get { return this.GetPropertyValue<OptionSetValue>("cardtype"); }
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="Service">CRM Organization Service</param>
/// <returns></returns>
public string CardType_Text(IOrganizationService Service)
{
	return this.CardType_OptionSetValue.GetOptionSetText(Service, this, "cardtype");
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="AttributeMetadata">The attribute metadata previously retrieved using the 'GetAttributeMetadata' extension method on the IOrganizationService object.</param>
/// <returns></returns>
public string CardType_Text(EnumAttributeMetadata AttributeMetadata)
{
	return AttributeMetadata.GetOptionSetText(this.CardType_OptionSetValue.Value);
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
///<para>Logical Name: createdtime</para>
///</summary>
[AttributeLogicalNameAttribute("createdtime")]
public DateTime? CreatedTime
{
	get { return this.GetPropertyValue<DateTime?>("createdtime"); }
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
///<para>Key Property (Uniqueidentifier)</para>
///<para>Logical Name: delveactionhubid</para>
///</summary>
[AttributeLogicalNameAttribute("delveactionhubid")]
public Guid DelveActionHubId
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
///<para>Logical Name: sender</para>
///<para>Max Length: 250 characters</para>
///</summary>
[AttributeLogicalNameAttribute("sender")]
public string @From
{
	get { return this.GetPropertyValue<string>("sender"); }
	set { this.SetPropertyValue("sender", value, 250, "@From"); }
}
///<summary>
///<para>Logical Name: iconclassname</para>
///<para>Max Length: 2000 characters</para>
///</summary>
[AttributeLogicalNameAttribute("iconclassname")]
public string IconClassName
{
	get { return this.GetPropertyValue<string>("iconclassname"); }
}
///<summary>
///<para>Logical Name: mailweblink</para>
///<para>Max Length: 250 characters</para>
///</summary>
[AttributeLogicalNameAttribute("mailweblink")]
public string MailWebLink
{
	get { return this.GetPropertyValue<string>("mailweblink"); }
	set { this.SetPropertyValue("mailweblink", value, 250, "MailWebLink"); }
}
///<summary>
///<para>Logical Name: messageid</para>
///<para>Max Length: 320 characters</para>
///</summary>
[AttributeLogicalNameAttribute("messageid")]
public string MessageID
{
	get { return this.GetPropertyValue<string>("messageid"); }
	set { this.SetPropertyValue("messageid", value, 320, "MessageID"); }
}
///<summary>
///<para>Logical Name: subject</para>
///<para>Max Length: 200 characters</para>
///</summary>
[AttributeLogicalNameAttribute("subject")]
public string MessageSubject
{
	get { return this.GetPropertyValue<string>("subject"); }
	set { this.SetPropertyValue("subject", value, 200, "MessageSubject"); }
}
///<summary>
///<para>Logical Name: messagetime</para>
///</summary>
[AttributeLogicalNameAttribute("messagetime")]
public DateTime? MessageTime
{
	get { return this.GetPropertyValue<DateTime?>("messagetime"); }
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
///<para>Logical Name: modifiedtime</para>
///</summary>
[AttributeLogicalNameAttribute("modifiedtime")]
public DateTime? ModifiedTime
{
	get { return this.GetPropertyValue<DateTime?>("modifiedtime"); }
}
///<summary>
///<para>Logical Name: organizationid</para>
///</summary>
[AttributeLogicalNameAttribute("organizationid")]
public EntityReference OrganizationId
{
	get { return this.GetPropertyValue<EntityReference>("organizationid"); }
}
///<summary>
///<para>Logical Name: recordid</para>
///</summary>
[AttributeLogicalNameAttribute("recordid")]
public EntityReference RecordId
{
	get { return this.GetPropertyValue<EntityReference>("recordid"); }
	set { this.SetPropertyValue<EntityReference>("recordid", value, "RecordId"); }
}
///<summary>
///<para>Logical Name: regardingobjectid</para>
///</summary>
[AttributeLogicalNameAttribute("regardingobjectid")]
public EntityReference Regarding
{
	get { return this.GetPropertyValue<EntityReference>("regardingobjectid"); }
	set { this.SetPropertyValue<EntityReference>("regardingobjectid", value, "Regarding"); }
}
///<summary>
///<para>Logical Name: relatedmailids</para>
///<para>Max Length: 8192 characters</para>
///</summary>
[AttributeLogicalNameAttribute("relatedmailids")]
public string RelatedEmailIds
{
	get { return this.GetPropertyValue<string>("relatedmailids"); }
	set { this.SetPropertyValue("relatedmailids", value, 8192, "RelatedEmailIds"); }
}
///<summary>
///<para>Logical Name: senderentityobjecttypecode</para>
///<para>Minimum Value: -2147483648</para>
///<para>Maximum Value: 2147483647</para>
///</summary>
[AttributeLogicalNameAttribute("senderentityobjecttypecode")]
public int? SenderEntityObjectTypeCode
{
	get { return this.GetPropertyValue<int?>("senderentityobjecttypecode"); }
}
///<summary>
///<para>Logical Name: senderimageurl</para>
///<para>Max Length: 250 characters</para>
///</summary>
[AttributeLogicalNameAttribute("senderimageurl")]
public string SenderImageUrl
{
	get { return this.GetPropertyValue<string>("senderimageurl"); }
	set { this.SetPropertyValue("senderimageurl", value, 250, "SenderImageUrl"); }
}
///<summary>
///<para>Logical Name: senderentityid</para>
///</summary>
[AttributeLogicalNameAttribute("senderentityid")]
public Guid SenderRecordId
{
	get { return this.GetPropertyValue<Guid>("senderentityid"); }
	set { this.SetPropertyValue<Guid>("senderentityid", value, "SenderRecordId"); }
}
/// <summary>
///Logical Name: statecode
/// </summary>
[AttributeLogicalNameAttribute("statecode")]
public eStatus? Status
{
	get
	{
		if (Status_OptionSetValue != null) { return (eStatus)Status_OptionSetValue.Value; }
		return null;
	}
	set
	{
		if (value != null) { this.Status_OptionSetValue = new OptionSetValue((int)value); }
		else this.Status_OptionSetValue = null;
	}
}
///<summary>
///<para>Logical Name: statecode</para>
///</summary>
[AttributeLogicalNameAttribute("statecode")]
public OptionSetValue Status_OptionSetValue
{
	get { return this.GetPropertyValue<OptionSetValue>("statecode"); }
	set { this.SetPropertyValue<OptionSetValue>("statecode", value, "Status_OptionSetValue"); }
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="Service">CRM Organization Service</param>
/// <returns></returns>
public string Status_Text(IOrganizationService Service)
{
	return this.Status_OptionSetValue.GetOptionSetText(Service, this, "statecode");
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="AttributeMetadata">The attribute metadata previously retrieved using the 'GetAttributeMetadata' extension method on the IOrganizationService object.</param>
/// <returns></returns>
public string Status_Text(EnumAttributeMetadata AttributeMetadata)
{
	return AttributeMetadata.GetOptionSetText(this.Status_OptionSetValue.Value);
}
/// <summary>
///Logical Name: statuscode
/// </summary>
[AttributeLogicalNameAttribute("statuscode")]
public eStatusReason? StatusReason
{
	get
	{
		if (StatusReason_OptionSetValue != null) { return (eStatusReason)StatusReason_OptionSetValue.Value; }
		return null;
	}
	set
	{
		if (value != null) { this.StatusReason_OptionSetValue = new OptionSetValue((int)value); }
		else this.StatusReason_OptionSetValue = null;
	}
}
///<summary>
///<para>Logical Name: statuscode</para>
///</summary>
[AttributeLogicalNameAttribute("statuscode")]
public OptionSetValue StatusReason_OptionSetValue
{
	get { return this.GetPropertyValue<OptionSetValue>("statuscode"); }
	set { this.SetPropertyValue<OptionSetValue>("statuscode", value, "StatusReason_OptionSetValue"); }
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="Service">CRM Organization Service</param>
/// <returns></returns>
public string StatusReason_Text(IOrganizationService Service)
{
	return this.StatusReason_OptionSetValue.GetOptionSetText(Service, this, "statuscode");
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="AttributeMetadata">The attribute metadata previously retrieved using the 'GetAttributeMetadata' extension method on the IOrganizationService object.</param>
/// <returns></returns>
public string StatusReason_Text(EnumAttributeMetadata AttributeMetadata)
{
	return AttributeMetadata.GetOptionSetText(this.StatusReason_OptionSetValue.Value);
}
///<summary>
///<para>Logical Name: timezoneruleversionnumber</para>
///<para>Minimum Value: -1</para>
///<para>Maximum Value: 2147483647</para>
///</summary>
[AttributeLogicalNameAttribute("timezoneruleversionnumber")]
public int? TimeZoneRuleVersionNumber
{
	get { return this.GetPropertyValue<int?>("timezoneruleversionnumber"); }
	set { this.SetPropertyValue("timezoneruleversionnumber", (int?)value, (int)-1, (int)2147483647, "TimeZoneRuleVersionNumber"); }
}
///<summary>
///<para>Logical Name: utcconversiontimezonecode</para>
///<para>Minimum Value: -1</para>
///<para>Maximum Value: 2147483647</para>
///</summary>
[AttributeLogicalNameAttribute("utcconversiontimezonecode")]
public int? UTCConversionTimeZoneCode
{
	get { return this.GetPropertyValue<int?>("utcconversiontimezonecode"); }
	set { this.SetPropertyValue("utcconversiontimezonecode", (int?)value, (int)-1, (int)2147483647, "UTCConversionTimeZoneCode"); }
}


        

        

        

        public enum eCardType
{
	///<summary><para>Default</para>
	///<para>Value = 0</para></summary>
	[Description("Default")]
	@Default = 0, 
	///<summary><para>SendContentRequest</para>
	///<para>Value = 1</para></summary>
	[Description("SendContentRequest")]
	SendContentRequest = 1, 
	///<summary><para>YesNo</para>
	///<para>Value = 2</para></summary>
	[Description("YesNo")]
	YesNo = 2, 
	///<summary><para>MeetingRequest</para>
	///<para>Value = 3</para></summary>
	[Description("MeetingRequest")]
	MeetingRequest = 3
}
public enum eStatus
{
	///<summary><para>Pending</para>
	///<para>Value = 0</para></summary>
	[Description("Pending")]
	Pending = 0, 
	///<summary><para>Completed</para>
	///<para>Value = 1</para></summary>
	[Description("Completed")]
	Completed = 1, 
	///<summary><para>Dismiss</para>
	///<para>Value = 2</para></summary>
	[Description("Dismiss")]
	Dismiss = 2
}
public enum eStatusReason
{
	///<summary><para>Pending</para>
	///<para>Value = 1</para></summary>
	[Description("Pending")]
	Pending_Pending = 1, 
	///<summary><para>Completed</para>
	///<para>Value = 2</para></summary>
	[Description("Completed")]
	Completed_Completed = 2, 
	///<summary><para>Dismiss</para>
	///<para>Value = 3</para></summary>
	[Description("Dismiss")]
	Dismiss_Dismiss = 3
}
public void SetState(IOrganizationService Service, eStatus State, eStatusReason Status)
{
	Service.SetState(this, (int)State, (int)Status);
}
public async System.Threading.Tasks.Task SetStateAsync(IOrganizationService Service, eStatus State, eStatusReason Status)
{
	 await Service.SetStateAsync(this, (int)State, (int)Status);
}


        public static class Properties
{
	/// <summary><para>createdonbehalfbyyominame</para>
	/// <para>createdonbehalfbyyominame</para></summary>
	public const string CreatedOnBehalfByYomiName = "createdonbehalfbyyominame";
	/// <summary><para>recordidobjecttypecode</para>
	/// <para>recordidobjecttypecode</para></summary>
	public const string RecordIdObjectTypeCode = "recordidobjecttypecode";
	/// <summary><para>transactioncurrencyidname</para>
	/// <para>transactioncurrencyidname</para></summary>
	public const string TransactionCurrencyIdName = "transactioncurrencyidname";
	/// <summary><para>recordidname</para>
	/// <para>recordidname</para></summary>
	public const string RecordIdName = "recordidname";
	/// <summary><para>regardingobjectidname</para>
	/// <para>regardingobjectidname</para></summary>
	public const string RegardingObjectIdName = "regardingobjectidname";
	/// <summary><para>regardingobjecttypecode</para>
	/// <para>regardingobjecttypecode</para></summary>
	public const string RegardingObjectTypeCode = "regardingobjecttypecode";
	/// <summary><para>createdbyname</para>
	/// <para>createdbyname</para></summary>
	public const string CreatedByName = "createdbyname";
	/// <summary><para>organizationidname</para>
	/// <para>organizationidname</para></summary>
	public const string OrganizationIdName = "organizationidname";
	/// <summary><para>recordiddsc</para>
	/// <para>recordiddsc</para></summary>
	public const string RecordIdDsc = "recordiddsc";
	/// <summary><para>createdbyyominame</para>
	/// <para>createdbyyominame</para></summary>
	public const string CreatedByYomiName = "createdbyyominame";
	/// <summary><para>modifiedbyname</para>
	/// <para>modifiedbyname</para></summary>
	public const string ModifiedByName = "modifiedbyname";
	/// <summary><para>versionnumber</para>
	/// <para>versionnumber</para></summary>
	public const string VersionNumber = "versionnumber";
	/// <summary><para>modifiedbyyominame</para>
	/// <para>modifiedbyyominame</para></summary>
	public const string ModifiedByYomiName = "modifiedbyyominame";
	/// <summary><para>regardingobjectiddsc</para>
	/// <para>regardingobjectiddsc</para></summary>
	public const string RegardingObjectIdDsc = "regardingobjectiddsc";
	/// <summary><para>modifiedonbehalfbyyominame</para>
	/// <para>modifiedonbehalfbyyominame</para></summary>
	public const string ModifiedOnBehalfByYomiName = "modifiedonbehalfbyyominame";
	/// <summary><para>createdonbehalfbyname</para>
	/// <para>createdonbehalfbyname</para></summary>
	public const string CreatedOnBehalfByName = "createdonbehalfbyname";
	/// <summary><para>modifiedonbehalfbyname</para>
	/// <para>modifiedonbehalfbyname</para></summary>
	public const string ModifiedOnBehalfByName = "modifiedonbehalfbyname";
	/// <summary><para>Card Description</para>
	/// <para>description</para></summary>
	public const string CardDescription = "description";
	/// <summary><para>Card Type</para>
	/// <para>cardtype</para></summary>
	public const string CardType = "cardtype";
	/// <summary><para>Created By</para>
	/// <para>createdby</para></summary>
	public const string CreatedBy = "createdby";
	/// <summary><para>Created By (Delegate)</para>
	/// <para>createdonbehalfby</para></summary>
	public const string CreatedBy_Delegate = "createdonbehalfby";
	/// <summary><para>Created On</para>
	/// <para>createdon</para></summary>
	public const string CreatedOn = "createdon";
	/// <summary><para>Created Time</para>
	/// <para>createdtime</para></summary>
	public const string CreatedTime = "createdtime";
	/// <summary><para>Currency</para>
	/// <para>transactioncurrencyid</para></summary>
	public const string Currency = "transactioncurrencyid";
	/// <summary><para>Delve Action Hub</para>
	/// <para>delveactionhubid</para></summary>
	public const string DelveActionHubId = "delveactionhubid";
	/// <summary><para>ExchangeRate</para>
	/// <para>exchangerate</para></summary>
	public const string ExchangeRate = "exchangerate";
	/// <summary><para>From</para>
	/// <para>sender</para></summary>
	public const string @From = "sender";
	/// <summary><para>Icon ClassName</para>
	/// <para>iconclassname</para></summary>
	public const string IconClassName = "iconclassname";
	/// <summary><para>Mail Web Link</para>
	/// <para>mailweblink</para></summary>
	public const string MailWebLink = "mailweblink";
	/// <summary><para>Message ID</para>
	/// <para>messageid</para></summary>
	public const string MessageID = "messageid";
	/// <summary><para>Message Subject</para>
	/// <para>subject</para></summary>
	public const string MessageSubject = "subject";
	/// <summary><para>Message Time</para>
	/// <para>messagetime</para></summary>
	public const string MessageTime = "messagetime";
	/// <summary><para>Modified By</para>
	/// <para>modifiedby</para></summary>
	public const string ModifiedBy = "modifiedby";
	/// <summary><para>Modified By (Delegate)</para>
	/// <para>modifiedonbehalfby</para></summary>
	public const string ModifiedBy_Delegate = "modifiedonbehalfby";
	/// <summary><para>Modified On</para>
	/// <para>modifiedon</para></summary>
	public const string ModifiedOn = "modifiedon";
	/// <summary><para>Modified Time</para>
	/// <para>modifiedtime</para></summary>
	public const string ModifiedTime = "modifiedtime";
	/// <summary><para>Organization Id</para>
	/// <para>organizationid</para></summary>
	public const string OrganizationId = "organizationid";
	/// <summary><para>RecordId</para>
	/// <para>recordid</para></summary>
	public const string RecordId = "recordid";
	/// <summary><para>Regarding</para>
	/// <para>regardingobjectid</para></summary>
	public const string Regarding = "regardingobjectid";
	/// <summary><para>Related Email Ids</para>
	/// <para>relatedmailids</para></summary>
	public const string RelatedEmailIds = "relatedmailids";
	/// <summary><para>Sender Entity Object Type Code</para>
	/// <para>senderentityobjecttypecode</para></summary>
	public const string SenderEntityObjectTypeCode = "senderentityobjecttypecode";
	/// <summary><para>Sender Image Url</para>
	/// <para>senderimageurl</para></summary>
	public const string SenderImageUrl = "senderimageurl";
	/// <summary><para>Sender Record Id</para>
	/// <para>senderentityid</para></summary>
	public const string SenderRecordId = "senderentityid";
	/// <summary><para>Status</para>
	/// <para>statecode</para></summary>
	public const string Status = "statecode";
	/// <summary><para>Status Reason</para>
	/// <para>statuscode</para></summary>
	public const string StatusReason = "statuscode";
	/// <summary><para>Time Zone Rule Version Number</para>
	/// <para>timezoneruleversionnumber</para></summary>
	public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
	/// <summary><para>UTC Conversion Time Zone Code</para>
	/// <para>utcconversiontimezonecode</para></summary>
	public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
}

    }
}