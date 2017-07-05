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
    [EntityLogicalNameAttribute("slakpiinstance")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XrmToolkit", "4.0")]
    public partial class SLAKPIInstance : BaseProxyClass
    {
        public new const string LogicalName = "slakpiinstance";
        public const int ObjectTypeCode = 9752;
        public const string PrimaryIdAttribute = "slakpiinstanceid";
        public const string PrimaryNameAttribute = "name";
        
        static SLAKPIInstance()
        {
            BaseProxyClass.RegisterProxyType(typeof(SLAKPIInstance), "slakpiinstance");
            _textOptions = new Dictionary<string, eTextOptions>();
            _numberOptions = new Dictionary<string, eNumberOptions>();
            _errorStrings = new Dictionary<string, string>();
            TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
            NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
        }
        public SLAKPIInstance() : base(new Entity("slakpiinstance")) { }
        public SLAKPIInstance(Entity original) : base(original) { }
        public static string GetLogicalName() { return BaseProxyClass.GetLogicalName<SLAKPIInstance>(); }
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
///<para>Logical Name: transactioncurrencyidname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("transactioncurrencyidname")]
public string TransactionCurrencyIdName
{
	get { return this.GetPropertyValue<string>("transactioncurrencyidname"); }
}
///<summary>
///<para>Logical Name: owneridname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("owneridname")]
public string OwnerIdName
{
	get { return this.GetPropertyValue<string>("owneridname"); }
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
///<para>Logical Name: owneridtype</para>
///</summary>
[AttributeLogicalNameAttribute("owneridtype")]
public string OwnerIdType
{
	get { return this.GetPropertyValue<string>("owneridtype"); }
	set { this.SetPropertyValue<string>("owneridtype", value, "OwnerIdType"); }
}
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
///<para>Logical Name: owneridyominame</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("owneridyominame")]
public string OwnerIdYomiName
{
	get { return this.GetPropertyValue<string>("owneridyominame"); }
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
///<para>Logical Name: regardingname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("regardingname")]
public string RegardingName
{
	get { return this.GetPropertyValue<string>("regardingname"); }
}
///<summary>
///<para>Logical Name: computedfailuretime</para>
///</summary>
[AttributeLogicalNameAttribute("computedfailuretime")]
public DateTime? ComputedFailureTime
{
	get { return this.GetPropertyValue<DateTime?>("computedfailuretime"); }
	set { this.SetPropertyValue<DateTime?>("computedfailuretime", value, "ComputedFailureTime"); }
}
///<summary>
///<para>Logical Name: computedwarningtime</para>
///</summary>
[AttributeLogicalNameAttribute("computedwarningtime")]
public DateTime? ComputedWarningTime
{
	get { return this.GetPropertyValue<DateTime?>("computedwarningtime"); }
	set { this.SetPropertyValue<DateTime?>("computedwarningtime", value, "ComputedWarningTime"); }
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
///<para>Logical Name: description</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("description")]
public string Description
{
	get { return this.GetPropertyValue<string>("description"); }
	set { this.SetPropertyValue("description", value, 100, "Description"); }
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
///<para>Logical Name: failuretime</para>
///</summary>
[AttributeLogicalNameAttribute("failuretime")]
public DateTime? FailureTime
{
	get { return this.GetPropertyValue<DateTime?>("failuretime"); }
	set { this.SetPropertyValue<DateTime?>("failuretime", value, "FailureTime"); }
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
///<para>Logical Name: name</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("name")]
public string Name
{
	get { return this.GetPropertyValue<string>("name"); }
	set { this.SetPropertyValue("name", value, 100, "Name"); }
}
///<summary>
///<para>Logical Name: ownerid</para>
///</summary>
[AttributeLogicalNameAttribute("ownerid")]
public EntityReference Owner
{
	get { return this.GetPropertyValue<EntityReference>("ownerid"); }
	set { this.SetPropertyValue<EntityReference>("ownerid", value, "Owner"); }
}
///<summary>
///<para>Logical Name: owningbusinessunit</para>
///</summary>
[AttributeLogicalNameAttribute("owningbusinessunit")]
public EntityReference OwningBusinessUnit
{
	get { return this.GetPropertyValue<EntityReference>("owningbusinessunit"); }
	set { this.SetPropertyValue<EntityReference>("owningbusinessunit", value, "OwningBusinessUnit"); }
}
///<summary>
///<para>Logical Name: owningteam</para>
///</summary>
[AttributeLogicalNameAttribute("owningteam")]
public EntityReference OwningTeam
{
	get { return this.GetPropertyValue<EntityReference>("owningteam"); }
	set { this.SetPropertyValue<EntityReference>("owningteam", value, "OwningTeam"); }
}
///<summary>
///<para>Logical Name: owninguser</para>
///</summary>
[AttributeLogicalNameAttribute("owninguser")]
public EntityReference OwningUser
{
	get { return this.GetPropertyValue<EntityReference>("owninguser"); }
	set { this.SetPropertyValue<EntityReference>("owninguser", value, "OwningUser"); }
}
///<summary>
///<para>Logical Name: regarding</para>
///</summary>
[AttributeLogicalNameAttribute("regarding")]
public EntityReference Regarding
{
	get { return this.GetPropertyValue<EntityReference>("regarding"); }
	set { this.SetPropertyValue<EntityReference>("regarding", value, "Regarding"); }
}
///<summary>
///<para>Logical Name: regardingidname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("regardingidname")]
public string RegardingName2
{
	get { return this.GetPropertyValue<string>("regardingidname"); }
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
///<para>Logical Name: regardingyominame</para>
///<para>Max Length: 400 characters</para>
///</summary>
[AttributeLogicalNameAttribute("regardingyominame")]
public string RegardingYomiName
{
	get { return this.GetPropertyValue<string>("regardingyominame"); }
}
///<summary>
///<para>Key Property (Uniqueidentifier)</para>
///<para>Logical Name: slakpiinstanceid</para>
///</summary>
[AttributeLogicalNameAttribute("slakpiinstanceid")]
public Guid SLAKPIInstanceId
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
/// <summary>
///Logical Name: status
/// </summary>
[AttributeLogicalNameAttribute("status")]
public eSLAKPIInstanceType? Status
{
	get
	{
		if (Status_OptionSetValue != null) { return (eSLAKPIInstanceType)Status_OptionSetValue.Value; }
		return null;
	}
	set
	{
		if (value != null) { this.Status_OptionSetValue = new OptionSetValue((int)value); }
		else this.Status_OptionSetValue = null;
	}
}
///<summary>
///<para>Logical Name: status</para>
///</summary>
[AttributeLogicalNameAttribute("status")]
public OptionSetValue Status_OptionSetValue
{
	get { return this.GetPropertyValue<OptionSetValue>("status"); }
	set { this.SetPropertyValue<OptionSetValue>("status", value, "Status_OptionSetValue"); }
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="Service">CRM Organization Service</param>
/// <returns></returns>
public string Status_Text(IOrganizationService Service)
{
	return this.Status_OptionSetValue.GetOptionSetText(Service, this, "status");
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
///<summary>
///<para>Logical Name: succeededon</para>
///</summary>
[AttributeLogicalNameAttribute("succeededon")]
public DateTime? SucceededOn
{
	get { return this.GetPropertyValue<DateTime?>("succeededon"); }
	set { this.SetPropertyValue<DateTime?>("succeededon", value, "SucceededOn"); }
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
///<para>Logical Name: warningtime</para>
///</summary>
[AttributeLogicalNameAttribute("warningtime")]
public DateTime? WarningTime
{
	get { return this.GetPropertyValue<DateTime?>("warningtime"); }
	set { this.SetPropertyValue<DateTime?>("warningtime", value, "WarningTime"); }
}
/// <summary>
///Logical Name: warningtimereached
/// </summary>
[AttributeLogicalNameAttribute("warningtimereached")]
public eWarningTimeReached? WarningTimeReached
{
	get
	{
		if (WarningTimeReached_OptionSetValue != null) { return (eWarningTimeReached)WarningTimeReached_OptionSetValue.Value; }
		return null;
	}
	set
	{
		if (value != null) { this.WarningTimeReached_OptionSetValue = new OptionSetValue((int)value); }
		else this.WarningTimeReached_OptionSetValue = null;
	}
}
///<summary>
///<para>Logical Name: warningtimereached</para>
///</summary>
[AttributeLogicalNameAttribute("warningtimereached")]
public OptionSetValue WarningTimeReached_OptionSetValue
{
	get { return this.GetPropertyValue<OptionSetValue>("warningtimereached"); }
	set { this.SetPropertyValue<OptionSetValue>("warningtimereached", value, "WarningTimeReached_OptionSetValue"); }
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="Service">CRM Organization Service</param>
/// <returns></returns>
public string WarningTimeReached_Text(IOrganizationService Service)
{
	return this.WarningTimeReached_OptionSetValue.GetOptionSetText(Service, this, "warningtimereached");
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="AttributeMetadata">The attribute metadata previously retrieved using the 'GetAttributeMetadata' extension method on the IOrganizationService object.</param>
/// <returns></returns>
public string WarningTimeReached_Text(EnumAttributeMetadata AttributeMetadata)
{
	return AttributeMetadata.GetOptionSetText(this.WarningTimeReached_OptionSetValue.Value);
}


        /// <summary>
/// <para><b>@Case (First Response By KPI)</b></para>
/// <para>Schema Name: slakpiinstance_incident_firstresponsebykpi</para>
/// </summary>
public List<@Case> GetCases_FirstResponseByKPI (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<@Case>(Service, this.Id, "incident", "firstresponsebykpiid", Columns); }
/// <summary>
/// <para><b>@Case (First Response By KPI)</b></para>
/// <para>Schema Name: slakpiinstance_incident_firstresponsebykpi</para>
/// </summary>
public List<@Case> GetCases_FirstResponseByKPI (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<@Case>(Service, this.Id, "incident", "firstresponsebykpiid", Columns); }
/// <summary>
/// <para><b>@Case (Resolve By KPI)</b></para>
/// <para>Schema Name: slakpiinstance_incident_resolvebykpi</para>
/// </summary>
public List<@Case> GetCases_ResolveByKPI (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<@Case>(Service, this.Id, "incident", "resolvebykpiid", Columns); }
/// <summary>
/// <para><b>@Case (Resolve By KPI)</b></para>
/// <para>Schema Name: slakpiinstance_incident_resolvebykpi</para>
/// </summary>
public List<@Case> GetCases_ResolveByKPI (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<@Case>(Service, this.Id, "incident", "resolvebykpiid", Columns); }
/// <summary>
/// <para><b>SyncError (Record)</b></para>
/// <para>Schema Name: SLAKPIInstance_SyncErrors</para>
/// </summary>
public List<SyncError> GetSyncErrors_Record (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<SyncError>(Service, this.Id, "syncerror", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>SyncError (Record)</b></para>
/// <para>Schema Name: SLAKPIInstance_SyncErrors</para>
/// </summary>
public List<SyncError> GetSyncErrors_Record (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<SyncError>(Service, this.Id, "syncerror", "regardingobjectid", Columns); }


        

        

        public enum eSLAKPIInstanceType
{
	///<summary><para>In Progress</para>
	///<para>Value = 0</para></summary>
	[Description("In Progress")]
	InProgress = 0, 
	///<summary><para>Noncompliant</para>
	///<para>Value = 1</para></summary>
	[Description("Noncompliant")]
	Noncompliant = 1, 
	///<summary><para>Nearing Noncompliance</para>
	///<para>Value = 2</para></summary>
	[Description("Nearing Noncompliance")]
	NearingNoncompliance = 2, 
	///<summary><para>Paused</para>
	///<para>Value = 3</para></summary>
	[Description("Paused")]
	Paused = 3, 
	///<summary><para>Succeeded</para>
	///<para>Value = 4</para></summary>
	[Description("Succeeded")]
	Succeeded = 4, 
	///<summary><para>Canceled</para>
	///<para>Value = 5</para></summary>
	[Description("Canceled")]
	Canceled = 5
}
public enum eWarningTimeReached
{
	///<summary><para>No</para>
	///<para>Value = 0</para></summary>
	[Description("No")]
	No = 0, 
	///<summary><para>Yes</para>
	///<para>Value = 1</para></summary>
	[Description("Yes")]
	Yes = 1
}


        public static class Properties
{
	/// <summary><para>transactioncurrencyidname</para>
	/// <para>transactioncurrencyidname</para></summary>
	public const string TransactionCurrencyIdName = "transactioncurrencyidname";
	/// <summary><para>owneridname</para>
	/// <para>owneridname</para></summary>
	public const string OwnerIdName = "owneridname";
	/// <summary><para>modifiedonbehalfbyname</para>
	/// <para>modifiedonbehalfbyname</para></summary>
	public const string ModifiedOnBehalfByName = "modifiedonbehalfbyname";
	/// <summary><para>createdbyyominame</para>
	/// <para>createdbyyominame</para></summary>
	public const string CreatedByYomiName = "createdbyyominame";
	/// <summary><para>modifiedbyname</para>
	/// <para>modifiedbyname</para></summary>
	public const string ModifiedByName = "modifiedbyname";
	/// <summary><para>modifiedbyyominame</para>
	/// <para>modifiedbyyominame</para></summary>
	public const string ModifiedByYomiName = "modifiedbyyominame";
	/// <summary><para>owneridtype</para>
	/// <para>owneridtype</para></summary>
	public const string OwnerIdType = "owneridtype";
	/// <summary><para>createdonbehalfbyyominame</para>
	/// <para>createdonbehalfbyyominame</para></summary>
	public const string CreatedOnBehalfByYomiName = "createdonbehalfbyyominame";
	/// <summary><para>owneridyominame</para>
	/// <para>owneridyominame</para></summary>
	public const string OwnerIdYomiName = "owneridyominame";
	/// <summary><para>modifiedonbehalfbyyominame</para>
	/// <para>modifiedonbehalfbyyominame</para></summary>
	public const string ModifiedOnBehalfByYomiName = "modifiedonbehalfbyyominame";
	/// <summary><para>createdbyname</para>
	/// <para>createdbyname</para></summary>
	public const string CreatedByName = "createdbyname";
	/// <summary><para>createdonbehalfbyname</para>
	/// <para>createdonbehalfbyname</para></summary>
	public const string CreatedOnBehalfByName = "createdonbehalfbyname";
	/// <summary><para>regardingname</para>
	/// <para>regardingname</para></summary>
	public const string RegardingName = "regardingname";
	/// <summary><para>Computed Failure Time</para>
	/// <para>computedfailuretime</para></summary>
	public const string ComputedFailureTime = "computedfailuretime";
	/// <summary><para>Computed Warning Time</para>
	/// <para>computedwarningtime</para></summary>
	public const string ComputedWarningTime = "computedwarningtime";
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
	/// <summary><para>Description</para>
	/// <para>description</para></summary>
	public const string Description = "description";
	/// <summary><para>Exchange Rate</para>
	/// <para>exchangerate</para></summary>
	public const string ExchangeRate = "exchangerate";
	/// <summary><para>Failure Time</para>
	/// <para>failuretime</para></summary>
	public const string FailureTime = "failuretime";
	/// <summary><para>Modified By</para>
	/// <para>modifiedby</para></summary>
	public const string ModifiedBy = "modifiedby";
	/// <summary><para>Modified By (Delegate)</para>
	/// <para>modifiedonbehalfby</para></summary>
	public const string ModifiedBy_Delegate = "modifiedonbehalfby";
	/// <summary><para>Modified On</para>
	/// <para>modifiedon</para></summary>
	public const string ModifiedOn = "modifiedon";
	/// <summary><para>Name</para>
	/// <para>name</para></summary>
	public const string Name = "name";
	/// <summary><para>Owner</para>
	/// <para>ownerid</para></summary>
	public const string Owner = "ownerid";
	/// <summary><para>Owning Business Unit</para>
	/// <para>owningbusinessunit</para></summary>
	public const string OwningBusinessUnit = "owningbusinessunit";
	/// <summary><para>Owning Team</para>
	/// <para>owningteam</para></summary>
	public const string OwningTeam = "owningteam";
	/// <summary><para>Owning User</para>
	/// <para>owninguser</para></summary>
	public const string OwningUser = "owninguser";
	/// <summary><para>Regarding</para>
	/// <para>regarding</para></summary>
	public const string Regarding = "regarding";
	/// <summary><para>RegardingName</para>
	/// <para>regardingidname</para></summary>
	public const string RegardingName2 = "regardingidname";
	/// <summary><para>RegardingObjectTypeCode</para>
	/// <para>regardingobjecttypecode</para></summary>
	public const string RegardingObjectTypeCode = "regardingobjecttypecode";
	/// <summary><para>RegardingYomiName</para>
	/// <para>regardingyominame</para></summary>
	public const string RegardingYomiName = "regardingyominame";
	/// <summary><para>SLA KPI InstanceId</para>
	/// <para>slakpiinstanceid</para></summary>
	public const string SLAKPIInstanceId = "slakpiinstanceid";
	/// <summary><para>Status</para>
	/// <para>status</para></summary>
	public const string Status = "status";
	/// <summary><para>Succeeded On</para>
	/// <para>succeededon</para></summary>
	public const string SucceededOn = "succeededon";
	/// <summary><para>Version Number</para>
	/// <para>versionnumber</para></summary>
	public const string VersionNumber = "versionnumber";
	/// <summary><para>Warning Time</para>
	/// <para>warningtime</para></summary>
	public const string WarningTime = "warningtime";
	/// <summary><para>Warning Time Reached</para>
	/// <para>warningtimereached</para></summary>
	public const string WarningTimeReached = "warningtimereached";
}

    }
}
