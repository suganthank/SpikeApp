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
    [EntityLogicalNameAttribute("bookableresourcebookingexchangesyncidmapping")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XrmToolkit", "4.0")]
    public partial class BookableResourceBookingToExchangeIdMapping : BaseProxyClass
    {
        public new const string LogicalName = "bookableresourcebookingexchangesyncidmapping";
        public const int ObjectTypeCode = 4421;
        public const string PrimaryIdAttribute = "bookableresourcebookingexchangesyncidmappingid";
        public const string PrimaryNameAttribute = "";
        
        static BookableResourceBookingToExchangeIdMapping()
        {
            BaseProxyClass.RegisterProxyType(typeof(BookableResourceBookingToExchangeIdMapping), "bookableresourcebookingexchangesyncidmapping");
            _textOptions = new Dictionary<string, eTextOptions>();
            _numberOptions = new Dictionary<string, eNumberOptions>();
            _errorStrings = new Dictionary<string, string>();
            TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
            NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
        }
        public BookableResourceBookingToExchangeIdMapping() : base(new Entity("bookableresourcebookingexchangesyncidmapping")) { }
        public BookableResourceBookingToExchangeIdMapping(Entity original) : base(original) { }
        public static string GetLogicalName() { return BaseProxyClass.GetLogicalName<BookableResourceBookingToExchangeIdMapping>(); }
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
///<para>Logical Name: exchangeentryid</para>
///<para>Max Length: 1024 characters</para>
///</summary>
[AttributeLogicalNameAttribute("exchangeentryid")]
public string ExchangeEntryId
{
	get { return this.GetPropertyValue<string>("exchangeentryid"); }
	set { this.SetPropertyValue("exchangeentryid", value, 1024, "ExchangeEntryId"); }
}
///<summary>
///<para>Logical Name: owningteam</para>
///</summary>
[AttributeLogicalNameAttribute("owningteam")]
public EntityReference OwningTeam
{
	get { return this.GetPropertyValue<EntityReference>("owningteam"); }
}
/// <summary>
///Logical Name: syncstatus
/// </summary>
[AttributeLogicalNameAttribute("syncstatus")]
public eSyncStatus? SyncStatus
{
	get
	{
		if (SyncStatus_OptionSetValue != null) { return (eSyncStatus)SyncStatus_OptionSetValue.Value; }
		return null;
	}
	set
	{
		if (value != null) { this.SyncStatus_OptionSetValue = new OptionSetValue((int)value); }
		else this.SyncStatus_OptionSetValue = null;
	}
}
///<summary>
///<para>Logical Name: syncstatus</para>
///</summary>
[AttributeLogicalNameAttribute("syncstatus")]
public OptionSetValue SyncStatus_OptionSetValue
{
	get { return this.GetPropertyValue<OptionSetValue>("syncstatus"); }
	set { this.SetPropertyValue<OptionSetValue>("syncstatus", value, "SyncStatus_OptionSetValue"); }
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="Service">CRM Organization Service</param>
/// <returns></returns>
public string SyncStatus_Text(IOrganizationService Service)
{
	return this.SyncStatus_OptionSetValue.GetOptionSetText(Service, this, "syncstatus");
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="AttributeMetadata">The attribute metadata previously retrieved using the 'GetAttributeMetadata' extension method on the IOrganizationService object.</param>
/// <returns></returns>
public string SyncStatus_Text(EnumAttributeMetadata AttributeMetadata)
{
	return AttributeMetadata.GetOptionSetText(this.SyncStatus_OptionSetValue.Value);
}
///<summary>
///<para>Logical Name: retries</para>
///<para>Minimum Value: -2147483648</para>
///<para>Maximum Value: 2147483647</para>
///</summary>
[AttributeLogicalNameAttribute("retries")]
public int? Retries
{
	get { return this.GetPropertyValue<int?>("retries"); }
	set { this.SetPropertyValue("retries", (int?)value, (int)-2147483648, (int)2147483647, "Retries"); }
}
///<summary>
///<para>Logical Name: isdeletedinexchange</para>
///<para>True = Yes</para>
///<para>False = No</para>
///</summary>
[AttributeLogicalNameAttribute("isdeletedinexchange")]
public bool? IsDeletedInExchange
{
	get { return this.GetPropertyValue<bool?>("isdeletedinexchange"); }
	set { this.SetPropertyValue<bool?>("isdeletedinexchange", value, "IsDeletedInExchange"); }
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
///<para>Logical Name: lastsyncerror</para>
///<para>Max Length: 2048 characters</para>
///</summary>
[AttributeLogicalNameAttribute("lastsyncerror")]
public string LastSyncError
{
	get { return this.GetPropertyValue<string>("lastsyncerror"); }
	set { this.SetPropertyValue("lastsyncerror", value, 2048, "LastSyncError"); }
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
///<para>Logical Name: userid</para>
///</summary>
[AttributeLogicalNameAttribute("userid")]
public EntityReference UserId
{
	get { return this.GetPropertyValue<EntityReference>("userid"); }
	set { this.SetPropertyValue<EntityReference>("userid", value, "UserId"); }
}
///<summary>
///<para>Logical Name: owningbusinessunit</para>
///</summary>
[AttributeLogicalNameAttribute("owningbusinessunit")]
public EntityReference OwningBusinessUnit
{
	get { return this.GetPropertyValue<EntityReference>("owningbusinessunit"); }
}
///<summary>
///<para>Logical Name: owninguser</para>
///</summary>
[AttributeLogicalNameAttribute("owninguser")]
public EntityReference OwningUser
{
	get { return this.GetPropertyValue<EntityReference>("owninguser"); }
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
///<para>Logical Name: bookableresourcebookingid</para>
///</summary>
[AttributeLogicalNameAttribute("bookableresourcebookingid")]
public Guid BookableResourceBookingId
{
	get { return this.GetPropertyValue<Guid>("bookableresourcebookingid"); }
	set { this.SetPropertyValue<Guid>("bookableresourcebookingid", value, "BookableResourceBookingId"); }
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
///<para>Logical Name: syncversionnumber</para>
///</summary>
[AttributeLogicalNameAttribute("syncversionnumber")]
public int? SyncVersionNumber
{
	get { return this.GetPropertyValue<int?>("syncversionnumber"); }
	set { this.SetPropertyValue<int?>("syncversionnumber", value, "SyncVersionNumber"); }
}
///<summary>
///<para>Key Property (Uniqueidentifier)</para>
///<para>Logical Name: bookableresourcebookingexchangesyncidmappingid</para>
///</summary>
[AttributeLogicalNameAttribute("bookableresourcebookingexchangesyncidmappingid")]
public Guid BookableResourceBookingExchangeSyncIdMappingId
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
///<para>Logical Name: lastsyncerrorcode</para>
///<para>Minimum Value: -2147483648</para>
///<para>Maximum Value: 2147483647</para>
///</summary>
[AttributeLogicalNameAttribute("lastsyncerrorcode")]
public int? LastSyncErrorCode
{
	get { return this.GetPropertyValue<int?>("lastsyncerrorcode"); }
	set { this.SetPropertyValue("lastsyncerrorcode", (int?)value, (int)-2147483648, (int)2147483647, "LastSyncErrorCode"); }
}
///<summary>
///<para>Logical Name: ownerid</para>
///</summary>
[AttributeLogicalNameAttribute("ownerid")]
public EntityReference OwnerId
{
	get { return this.GetPropertyValue<EntityReference>("ownerid"); }
	set { this.SetPropertyValue<EntityReference>("ownerid", value, "OwnerId"); }
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
///<para>Logical Name: lastsyncerroroccurredon</para>
///</summary>
[AttributeLogicalNameAttribute("lastsyncerroroccurredon")]
public DateTime? LastSyncErrorTime
{
	get { return this.GetPropertyValue<DateTime?>("lastsyncerroroccurredon"); }
	set { this.SetPropertyValue<DateTime?>("lastsyncerroroccurredon", value, "LastSyncErrorTime"); }
}
///<summary>
///<para>Logical Name: modifiedon</para>
///</summary>
[AttributeLogicalNameAttribute("modifiedon")]
public DateTime? ModifiedOn
{
	get { return this.GetPropertyValue<DateTime?>("modifiedon"); }
}


        

        

        

        public enum eSyncStatus
{
	///<summary><para>Completed</para>
	///<para>Value = 0</para></summary>
	[Description("Completed")]
	Completed = 0, 
	///<summary><para>Retry</para>
	///<para>Value = 1</para></summary>
	[Description("Retry")]
	Retry = 1, 
	///<summary><para>Pending</para>
	///<para>Value = 2</para></summary>
	[Description("Pending")]
	Pending = 2
}


        public static class Properties
{
	/// <summary><para>exchangeentryid</para>
	/// <para>exchangeentryid</para></summary>
	public const string ExchangeEntryId = "exchangeentryid";
	/// <summary><para>owningteam</para>
	/// <para>owningteam</para></summary>
	public const string OwningTeam = "owningteam";
	/// <summary><para>syncstatus</para>
	/// <para>syncstatus</para></summary>
	public const string SyncStatus = "syncstatus";
	/// <summary><para>retries</para>
	/// <para>retries</para></summary>
	public const string Retries = "retries";
	/// <summary><para>isdeletedinexchange</para>
	/// <para>isdeletedinexchange</para></summary>
	public const string IsDeletedInExchange = "isdeletedinexchange";
	/// <summary><para>versionnumber</para>
	/// <para>versionnumber</para></summary>
	public const string VersionNumber = "versionnumber";
	/// <summary><para>lastsyncerror</para>
	/// <para>lastsyncerror</para></summary>
	public const string LastSyncError = "lastsyncerror";
	/// <summary><para>owneridtype</para>
	/// <para>owneridtype</para></summary>
	public const string OwnerIdType = "owneridtype";
	/// <summary><para>userid</para>
	/// <para>userid</para></summary>
	public const string UserId = "userid";
	/// <summary><para>owningbusinessunit</para>
	/// <para>owningbusinessunit</para></summary>
	public const string OwningBusinessUnit = "owningbusinessunit";
	/// <summary><para>owninguser</para>
	/// <para>owninguser</para></summary>
	public const string OwningUser = "owninguser";
	/// <summary><para>owneridyominame</para>
	/// <para>owneridyominame</para></summary>
	public const string OwnerIdYomiName = "owneridyominame";
	/// <summary><para>bookableresourcebookingid</para>
	/// <para>bookableresourcebookingid</para></summary>
	public const string BookableResourceBookingId = "bookableresourcebookingid";
	/// <summary><para>owneridname</para>
	/// <para>owneridname</para></summary>
	public const string OwnerIdName = "owneridname";
	/// <summary><para>syncversionnumber</para>
	/// <para>syncversionnumber</para></summary>
	public const string SyncVersionNumber = "syncversionnumber";
	/// <summary><para>bookableresourcebookingexchangesyncidmappingid</para>
	/// <para>bookableresourcebookingexchangesyncidmappingid</para></summary>
	public const string BookableResourceBookingExchangeSyncIdMappingId = "bookableresourcebookingexchangesyncidmappingid";
	/// <summary><para>lastsyncerrorcode</para>
	/// <para>lastsyncerrorcode</para></summary>
	public const string LastSyncErrorCode = "lastsyncerrorcode";
	/// <summary><para>ownerid</para>
	/// <para>ownerid</para></summary>
	public const string OwnerId = "ownerid";
	/// <summary><para>Created On</para>
	/// <para>createdon</para></summary>
	public const string CreatedOn = "createdon";
	/// <summary><para>Last Sync Error Time</para>
	/// <para>lastsyncerroroccurredon</para></summary>
	public const string LastSyncErrorTime = "lastsyncerroroccurredon";
	/// <summary><para>Modified On</para>
	/// <para>modifiedon</para></summary>
	public const string ModifiedOn = "modifiedon";
}

    }
}
