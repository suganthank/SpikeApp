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
    [EntityLogicalNameAttribute("msdyn_quotelineinvoiceschedule")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XrmToolkit", "4.0")]
    public partial class QuoteLineInvoiceSchedule : BaseProxyClass
    {
        public new const string LogicalName = "msdyn_quotelineinvoiceschedule";
        public const int ObjectTypeCode = 10076;
        public const string PrimaryIdAttribute = "msdyn_quotelineinvoicescheduleid";
        public const string PrimaryNameAttribute = "msdyn_name";
        
        static QuoteLineInvoiceSchedule()
        {
            BaseProxyClass.RegisterProxyType(typeof(QuoteLineInvoiceSchedule), "msdyn_quotelineinvoiceschedule");
            _textOptions = new Dictionary<string, eTextOptions>();
            _numberOptions = new Dictionary<string, eNumberOptions>();
            _errorStrings = new Dictionary<string, string>();
            TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
            NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
        }
        public QuoteLineInvoiceSchedule() : base(new Entity("msdyn_quotelineinvoiceschedule")) { }
        public QuoteLineInvoiceSchedule(Entity original) : base(original) { }
        public static string GetLogicalName() { return BaseProxyClass.GetLogicalName<QuoteLineInvoiceSchedule>(); }
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
///<para>Logical Name: organizationidname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("organizationidname")]
public string OrganizationIdName
{
	get { return this.GetPropertyValue<string>("organizationidname"); }
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
///<para>Logical Name: modifiedonbehalfbyname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("modifiedonbehalfbyname")]
public string ModifiedOnBehalfByName
{
	get { return this.GetPropertyValue<string>("modifiedonbehalfbyname"); }
}
///<summary>
///<para>Logical Name: msdyn_quotelinescheduleofvaluename</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("msdyn_quotelinescheduleofvaluename")]
public string Msdyn_QuoteLineScheduleOfValueName
{
	get { return this.GetPropertyValue<string>("msdyn_quotelinescheduleofvaluename"); }
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
///<para>Logical Name: importsequencenumber</para>
///<para>Minimum Value: -2147483648</para>
///<para>Maximum Value: 2147483647</para>
///</summary>
[AttributeLogicalNameAttribute("importsequencenumber")]
public int? ImportSequenceNumber
{
	get { return this.GetPropertyValue<int?>("importsequencenumber"); }
	set { this.SetPropertyValue("importsequencenumber", (int?)value, (int)-2147483648, (int)2147483647, "ImportSequenceNumber"); }
}
///<summary>
///<para>Logical Name: msdyn_invoicerundate</para>
///</summary>
[AttributeLogicalNameAttribute("msdyn_invoicerundate")]
public DateTime? InvoiceRunDate
{
	get { return this.GetPropertyValue<DateTime?>("msdyn_invoicerundate"); }
	set { this.SetPropertyValue<DateTime?>("msdyn_invoicerundate", value, "InvoiceRunDate"); }
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
///<para>Logical Name: msdyn_name</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("msdyn_name")]
public string Name
{
	get { return this.GetPropertyValue<string>("msdyn_name"); }
	set { this.SetPropertyValue("msdyn_name", value, 100, "Name"); }
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
///<para>Logical Name: msdyn_quoteline</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("msdyn_quoteline")]
public string QuoteLine
{
	get { return this.GetPropertyValue<string>("msdyn_quoteline"); }
	set { this.SetPropertyValue("msdyn_quoteline", value, 100, "QuoteLine"); }
}
///<summary>
///<para>Key Property (Uniqueidentifier)</para>
///<para>Logical Name: msdyn_quotelineinvoicescheduleid</para>
///</summary>
[AttributeLogicalNameAttribute("msdyn_quotelineinvoicescheduleid")]
public Guid QuoteLineInvoiceScheduleId
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
///<para>Logical Name: msdyn_quotelinescheduleofvalue</para>
///</summary>
[AttributeLogicalNameAttribute("msdyn_quotelinescheduleofvalue")]
public EntityReference QuoteLineScheduleOfValue
{
	get { return this.GetPropertyValue<EntityReference>("msdyn_quotelinescheduleofvalue"); }
	set { this.SetPropertyValue<EntityReference>("msdyn_quotelinescheduleofvalue", value, "QuoteLineScheduleOfValue"); }
}
///<summary>
///<para>Logical Name: overriddencreatedon</para>
///</summary>
[AttributeLogicalNameAttribute("overriddencreatedon")]
public DateTime? RecordCreatedOn
{
	get { return this.GetPropertyValue<DateTime?>("overriddencreatedon"); }
	set { this.SetPropertyValue<DateTime?>("overriddencreatedon", value, "RecordCreatedOn"); }
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
///<para>Logical Name: msdyn_transactioncutoffdate</para>
///</summary>
[AttributeLogicalNameAttribute("msdyn_transactioncutoffdate")]
public DateTime? TransactionCutOffDate
{
	get { return this.GetPropertyValue<DateTime?>("msdyn_transactioncutoffdate"); }
	set { this.SetPropertyValue<DateTime?>("msdyn_transactioncutoffdate", value, "TransactionCutOffDate"); }
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
///<summary>
///<para>Logical Name: versionnumber</para>
///</summary>
[AttributeLogicalNameAttribute("versionnumber")]
public int? VersionNumber
{
	get { return this.GetPropertyValue<int?>("versionnumber"); }
}


        /// <summary>
/// <para><b>SystemJob (Regarding)</b></para>
/// <para>Schema Name: msdyn_quotelineinvoiceschedule_AsyncOperations</para>
/// </summary>
public List<SystemJob> GetSystemJobs_Regarding (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<SystemJob>(Service, this.Id, "asyncoperation", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>SystemJob (Regarding)</b></para>
/// <para>Schema Name: msdyn_quotelineinvoiceschedule_AsyncOperations</para>
/// </summary>
public List<SystemJob> GetSystemJobs_Regarding (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<SystemJob>(Service, this.Id, "asyncoperation", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>BulkDeleteFailure (Name)</b></para>
/// <para>Schema Name: msdyn_quotelineinvoiceschedule_BulkDeleteFailures</para>
/// </summary>
public List<BulkDeleteFailure> GetBulkDeleteFailures_Name (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<BulkDeleteFailure>(Service, this.Id, "bulkdeletefailure", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>BulkDeleteFailure (Name)</b></para>
/// <para>Schema Name: msdyn_quotelineinvoiceschedule_BulkDeleteFailures</para>
/// </summary>
public List<BulkDeleteFailure> GetBulkDeleteFailures_Name (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<BulkDeleteFailure>(Service, this.Id, "bulkdeletefailure", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>DuplicateRecord (Base Record ID)</b></para>
/// <para>Schema Name: msdyn_quotelineinvoiceschedule_DuplicateBaseRecord</para>
/// </summary>
public List<DuplicateRecord> GetDuplicateRecords_BaseRecordID (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<DuplicateRecord>(Service, this.Id, "duplicaterecord", "baserecordid", Columns); }
/// <summary>
/// <para><b>DuplicateRecord (Base Record ID)</b></para>
/// <para>Schema Name: msdyn_quotelineinvoiceschedule_DuplicateBaseRecord</para>
/// </summary>
public List<DuplicateRecord> GetDuplicateRecords_BaseRecordID (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<DuplicateRecord>(Service, this.Id, "duplicaterecord", "baserecordid", Columns); }
/// <summary>
/// <para><b>DuplicateRecord (Duplicate Record ID)</b></para>
/// <para>Schema Name: msdyn_quotelineinvoiceschedule_DuplicateMatchingRecord</para>
/// </summary>
public List<DuplicateRecord> GetDuplicateRecords_DuplicateRecordID (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<DuplicateRecord>(Service, this.Id, "duplicaterecord", "duplicaterecordid", Columns); }
/// <summary>
/// <para><b>DuplicateRecord (Duplicate Record ID)</b></para>
/// <para>Schema Name: msdyn_quotelineinvoiceschedule_DuplicateMatchingRecord</para>
/// </summary>
public List<DuplicateRecord> GetDuplicateRecords_DuplicateRecordID (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<DuplicateRecord>(Service, this.Id, "duplicaterecord", "duplicaterecordid", Columns); }
/// <summary>
/// <para><b>MailboxAutoTrackingFolder (Regarding Object Id)</b></para>
/// <para>Schema Name: msdyn_quotelineinvoiceschedule_MailboxTrackingFolders</para>
/// </summary>
public List<MailboxAutoTrackingFolder> GetMailboxAutoTrackingFolders_RegardingObjectId (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<MailboxAutoTrackingFolder>(Service, this.Id, "mailboxtrackingfolder", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>MailboxAutoTrackingFolder (Regarding Object Id)</b></para>
/// <para>Schema Name: msdyn_quotelineinvoiceschedule_MailboxTrackingFolders</para>
/// </summary>
public List<MailboxAutoTrackingFolder> GetMailboxAutoTrackingFolders_RegardingObjectId (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<MailboxAutoTrackingFolder>(Service, this.Id, "mailboxtrackingfolder", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>FieldSharing (Entity instance)</b></para>
/// <para>Schema Name: msdyn_quotelineinvoiceschedule_PrincipalObjectAttributeAccesses</para>
/// </summary>
public List<FieldSharing> GetFieldSharing_EntityInstance (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<FieldSharing>(Service, this.Id, "principalobjectattributeaccess", "objectid", Columns); }
/// <summary>
/// <para><b>FieldSharing (Entity instance)</b></para>
/// <para>Schema Name: msdyn_quotelineinvoiceschedule_PrincipalObjectAttributeAccesses</para>
/// </summary>
public List<FieldSharing> GetFieldSharing_EntityInstance (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<FieldSharing>(Service, this.Id, "principalobjectattributeaccess", "objectid", Columns); }
/// <summary>
/// <para><b>ProcessSession (Regarding)</b></para>
/// <para>Schema Name: msdyn_quotelineinvoiceschedule_ProcessSession</para>
/// </summary>
public List<ProcessSession> GetProcessSessions_Regarding (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<ProcessSession>(Service, this.Id, "processsession", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>ProcessSession (Regarding)</b></para>
/// <para>Schema Name: msdyn_quotelineinvoiceschedule_ProcessSession</para>
/// </summary>
public List<ProcessSession> GetProcessSessions_Regarding (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<ProcessSession>(Service, this.Id, "processsession", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>SyncError (Record)</b></para>
/// <para>Schema Name: msdyn_quotelineinvoiceschedule_SyncErrors</para>
/// </summary>
public List<SyncError> GetSyncErrors_Record (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<SyncError>(Service, this.Id, "syncerror", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>SyncError (Record)</b></para>
/// <para>Schema Name: msdyn_quotelineinvoiceschedule_SyncErrors</para>
/// </summary>
public List<SyncError> GetSyncErrors_Record (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<SyncError>(Service, this.Id, "syncerror", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>UserEntityInstanceData (Object Id)</b></para>
/// <para>Schema Name: msdyn_quotelineinvoiceschedule_UserEntityInstanceDatas</para>
/// </summary>
public List<UserEntityInstanceData> GetUserEntityInstanceData_ObjectId (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<UserEntityInstanceData>(Service, this.Id, "userentityinstancedata", "objectid", Columns); }
/// <summary>
/// <para><b>UserEntityInstanceData (Object Id)</b></para>
/// <para>Schema Name: msdyn_quotelineinvoiceschedule_UserEntityInstanceDatas</para>
/// </summary>
public List<UserEntityInstanceData> GetUserEntityInstanceData_ObjectId (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<UserEntityInstanceData>(Service, this.Id, "userentityinstancedata", "objectid", Columns); }


        

        

        public enum eStatus
{
	///<summary><para>Active</para>
	///<para>Value = 0</para></summary>
	[Description("Active")]
	Active = 0, 
	///<summary><para>Inactive</para>
	///<para>Value = 1</para></summary>
	[Description("Inactive")]
	Inactive = 1
}
public enum eStatusReason
{
	///<summary><para>Active</para>
	///<para>Value = 1</para></summary>
	[Description("Active")]
	Active_Active = 1, 
	///<summary><para>Inactive</para>
	///<para>Value = 2</para></summary>
	[Description("Inactive")]
	Inactive_Inactive = 2
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
	/// <summary><para>organizationidname</para>
	/// <para>organizationidname</para></summary>
	public const string OrganizationIdName = "organizationidname";
	/// <summary><para>modifiedbyyominame</para>
	/// <para>modifiedbyyominame</para></summary>
	public const string ModifiedByYomiName = "modifiedbyyominame";
	/// <summary><para>createdbyyominame</para>
	/// <para>createdbyyominame</para></summary>
	public const string CreatedByYomiName = "createdbyyominame";
	/// <summary><para>modifiedbyname</para>
	/// <para>modifiedbyname</para></summary>
	public const string ModifiedByName = "modifiedbyname";
	/// <summary><para>modifiedonbehalfbyyominame</para>
	/// <para>modifiedonbehalfbyyominame</para></summary>
	public const string ModifiedOnBehalfByYomiName = "modifiedonbehalfbyyominame";
	/// <summary><para>createdbyname</para>
	/// <para>createdbyname</para></summary>
	public const string CreatedByName = "createdbyname";
	/// <summary><para>createdonbehalfbyname</para>
	/// <para>createdonbehalfbyname</para></summary>
	public const string CreatedOnBehalfByName = "createdonbehalfbyname";
	/// <summary><para>modifiedonbehalfbyname</para>
	/// <para>modifiedonbehalfbyname</para></summary>
	public const string ModifiedOnBehalfByName = "modifiedonbehalfbyname";
	/// <summary><para>msdyn_quotelinescheduleofvaluename</para>
	/// <para>msdyn_quotelinescheduleofvaluename</para></summary>
	public const string Msdyn_QuoteLineScheduleOfValueName = "msdyn_quotelinescheduleofvaluename";
	/// <summary><para>Created By</para>
	/// <para>createdby</para></summary>
	public const string CreatedBy = "createdby";
	/// <summary><para>Created By (Delegate)</para>
	/// <para>createdonbehalfby</para></summary>
	public const string CreatedBy_Delegate = "createdonbehalfby";
	/// <summary><para>Created On</para>
	/// <para>createdon</para></summary>
	public const string CreatedOn = "createdon";
	/// <summary><para>Import Sequence Number</para>
	/// <para>importsequencenumber</para></summary>
	public const string ImportSequenceNumber = "importsequencenumber";
	/// <summary><para>Invoice Run Date</para>
	/// <para>msdyn_invoicerundate</para></summary>
	public const string InvoiceRunDate = "msdyn_invoicerundate";
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
	/// <para>msdyn_name</para></summary>
	public const string Name = "msdyn_name";
	/// <summary><para>Organization Id</para>
	/// <para>organizationid</para></summary>
	public const string OrganizationId = "organizationid";
	/// <summary><para>Quote Line</para>
	/// <para>msdyn_quoteline</para></summary>
	public const string QuoteLine = "msdyn_quoteline";
	/// <summary><para>Quote Line Invoice Schedule</para>
	/// <para>msdyn_quotelineinvoicescheduleid</para></summary>
	public const string QuoteLineInvoiceScheduleId = "msdyn_quotelineinvoicescheduleid";
	/// <summary><para>Quote Line Schedule Of Value</para>
	/// <para>msdyn_quotelinescheduleofvalue</para></summary>
	public const string QuoteLineScheduleOfValue = "msdyn_quotelinescheduleofvalue";
	/// <summary><para>Record Created On</para>
	/// <para>overriddencreatedon</para></summary>
	public const string RecordCreatedOn = "overriddencreatedon";
	/// <summary><para>Status</para>
	/// <para>statecode</para></summary>
	public const string Status = "statecode";
	/// <summary><para>Status Reason</para>
	/// <para>statuscode</para></summary>
	public const string StatusReason = "statuscode";
	/// <summary><para>Time Zone Rule Version Number</para>
	/// <para>timezoneruleversionnumber</para></summary>
	public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
	/// <summary><para>Transaction Cut Off Date</para>
	/// <para>msdyn_transactioncutoffdate</para></summary>
	public const string TransactionCutOffDate = "msdyn_transactioncutoffdate";
	/// <summary><para>UTC Conversion Time Zone Code</para>
	/// <para>utcconversiontimezonecode</para></summary>
	public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
	/// <summary><para>Version Number</para>
	/// <para>versionnumber</para></summary>
	public const string VersionNumber = "versionnumber";
}

    }
}
