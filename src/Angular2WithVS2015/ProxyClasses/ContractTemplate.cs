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
    [EntityLogicalNameAttribute("contracttemplate")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XrmToolkit", "4.0")]
    public partial class ContractTemplate : BaseProxyClass
    {
        public new const string LogicalName = "contracttemplate";
        public const int ObjectTypeCode = 2011;
        public const string PrimaryIdAttribute = "contracttemplateid";
        public const string PrimaryNameAttribute = "name";
        
        static ContractTemplate()
        {
            BaseProxyClass.RegisterProxyType(typeof(ContractTemplate), "contracttemplate");
            _textOptions = new Dictionary<string, eTextOptions>();
            _numberOptions = new Dictionary<string, eNumberOptions>();
            _errorStrings = new Dictionary<string, string>();
            TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
            NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
        }
        public ContractTemplate() : base(new Entity("contracttemplate")) { }
        public ContractTemplate(Entity original) : base(original) { }
        public static string GetLogicalName() { return BaseProxyClass.GetLogicalName<ContractTemplate>(); }
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
///<para>Logical Name: contracttemplateidunique</para>
///</summary>
[AttributeLogicalNameAttribute("contracttemplateidunique")]
public Guid ContractTemplateIdUnique
{
	get { return this.GetPropertyValue<Guid>("contracttemplateidunique"); }
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
///<para>Logical Name: abbreviation</para>
///<para>Max Length: 20 characters</para>
///</summary>
[AttributeLogicalNameAttribute("abbreviation")]
public string Abbreviation
{
	get { return this.GetPropertyValue<string>("abbreviation"); }
	set { this.SetPropertyValue("abbreviation", value, 20, "Abbreviation"); }
}
/// <summary>
///Logical Name: allotmenttypecode
/// </summary>
[AttributeLogicalNameAttribute("allotmenttypecode")]
public eAllotmentType? AllotmentType
{
	get
	{
		if (AllotmentType_OptionSetValue != null) { return (eAllotmentType)AllotmentType_OptionSetValue.Value; }
		return null;
	}
	set
	{
		if (value != null) { this.AllotmentType_OptionSetValue = new OptionSetValue((int)value); }
		else this.AllotmentType_OptionSetValue = null;
	}
}
///<summary>
///<para>Logical Name: allotmenttypecode</para>
///</summary>
[AttributeLogicalNameAttribute("allotmenttypecode")]
public OptionSetValue AllotmentType_OptionSetValue
{
	get { return this.GetPropertyValue<OptionSetValue>("allotmenttypecode"); }
	set { this.SetPropertyValue<OptionSetValue>("allotmenttypecode", value, "AllotmentType_OptionSetValue"); }
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="Service">CRM Organization Service</param>
/// <returns></returns>
public string AllotmentType_Text(IOrganizationService Service)
{
	return this.AllotmentType_OptionSetValue.GetOptionSetText(Service, this, "allotmenttypecode");
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="AttributeMetadata">The attribute metadata previously retrieved using the 'GetAttributeMetadata' extension method on the IOrganizationService object.</param>
/// <returns></returns>
public string AllotmentType_Text(EnumAttributeMetadata AttributeMetadata)
{
	return AttributeMetadata.GetOptionSetText(this.AllotmentType_OptionSetValue.Value);
}
/// <summary>
///Logical Name: billingfrequencycode
/// </summary>
[AttributeLogicalNameAttribute("billingfrequencycode")]
public eBillingFrequency? BillingFrequency
{
	get
	{
		if (BillingFrequency_OptionSetValue != null) { return (eBillingFrequency)BillingFrequency_OptionSetValue.Value; }
		return null;
	}
	set
	{
		if (value != null) { this.BillingFrequency_OptionSetValue = new OptionSetValue((int)value); }
		else this.BillingFrequency_OptionSetValue = null;
	}
}
///<summary>
///<para>Logical Name: billingfrequencycode</para>
///</summary>
[AttributeLogicalNameAttribute("billingfrequencycode")]
public OptionSetValue BillingFrequency_OptionSetValue
{
	get { return this.GetPropertyValue<OptionSetValue>("billingfrequencycode"); }
	set { this.SetPropertyValue<OptionSetValue>("billingfrequencycode", value, "BillingFrequency_OptionSetValue"); }
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="Service">CRM Organization Service</param>
/// <returns></returns>
public string BillingFrequency_Text(IOrganizationService Service)
{
	return this.BillingFrequency_OptionSetValue.GetOptionSetText(Service, this, "billingfrequencycode");
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="AttributeMetadata">The attribute metadata previously retrieved using the 'GetAttributeMetadata' extension method on the IOrganizationService object.</param>
/// <returns></returns>
public string BillingFrequency_Text(EnumAttributeMetadata AttributeMetadata)
{
	return AttributeMetadata.GetOptionSetText(this.BillingFrequency_OptionSetValue.Value);
}
/// <summary>
///Logical Name: componentstate
/// </summary>
[AttributeLogicalNameAttribute("componentstate")]
public eComponentState? ComponentState
{
	get
	{
		if (ComponentState_OptionSetValue != null) { return (eComponentState)ComponentState_OptionSetValue.Value; }
		return null;
	}
}
///<summary>
///<para>Logical Name: componentstate</para>
///</summary>
[AttributeLogicalNameAttribute("componentstate")]
public OptionSetValue ComponentState_OptionSetValue
{
	get { return this.GetPropertyValue<OptionSetValue>("componentstate"); }
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="Service">CRM Organization Service</param>
/// <returns></returns>
public string ComponentState_Text(IOrganizationService Service)
{
	return this.ComponentState_OptionSetValue.GetOptionSetText(Service, this, "componentstate");
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="AttributeMetadata">The attribute metadata previously retrieved using the 'GetAttributeMetadata' extension method on the IOrganizationService object.</param>
/// <returns></returns>
public string ComponentState_Text(EnumAttributeMetadata AttributeMetadata)
{
	return AttributeMetadata.GetOptionSetText(this.ComponentState_OptionSetValue.Value);
}
/// <summary>
///Logical Name: contractservicelevelcode
/// </summary>
[AttributeLogicalNameAttribute("contractservicelevelcode")]
public eContractServiceLevel? ContractServiceLevel
{
	get
	{
		if (ContractServiceLevel_OptionSetValue != null) { return (eContractServiceLevel)ContractServiceLevel_OptionSetValue.Value; }
		return null;
	}
	set
	{
		if (value != null) { this.ContractServiceLevel_OptionSetValue = new OptionSetValue((int)value); }
		else this.ContractServiceLevel_OptionSetValue = null;
	}
}
///<summary>
///<para>Logical Name: contractservicelevelcode</para>
///</summary>
[AttributeLogicalNameAttribute("contractservicelevelcode")]
public OptionSetValue ContractServiceLevel_OptionSetValue
{
	get { return this.GetPropertyValue<OptionSetValue>("contractservicelevelcode"); }
	set { this.SetPropertyValue<OptionSetValue>("contractservicelevelcode", value, "ContractServiceLevel_OptionSetValue"); }
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="Service">CRM Organization Service</param>
/// <returns></returns>
public string ContractServiceLevel_Text(IOrganizationService Service)
{
	return this.ContractServiceLevel_OptionSetValue.GetOptionSetText(Service, this, "contractservicelevelcode");
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="AttributeMetadata">The attribute metadata previously retrieved using the 'GetAttributeMetadata' extension method on the IOrganizationService object.</param>
/// <returns></returns>
public string ContractServiceLevel_Text(EnumAttributeMetadata AttributeMetadata)
{
	return AttributeMetadata.GetOptionSetText(this.ContractServiceLevel_OptionSetValue.Value);
}
///<summary>
///<para>Key Property (Uniqueidentifier)</para>
///<para>Logical Name: contracttemplateid</para>
///</summary>
[AttributeLogicalNameAttribute("contracttemplateid")]
public Guid ContractTemplateId
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
///<para>Logical Name: iscustomizable</para>
///</summary>
[AttributeLogicalNameAttribute("iscustomizable")]
public BooleanManagedProperty Customizable
{
	get { return this.GetPropertyValue<BooleanManagedProperty>("iscustomizable"); }
	set { this.SetPropertyValue<BooleanManagedProperty>("iscustomizable", value, "Customizable"); }
}
///<summary>
///<para>Logical Name: description</para>
///<para>Max Length: 2000 characters</para>
///</summary>
[AttributeLogicalNameAttribute("description")]
public string Description
{
	get { return this.GetPropertyValue<string>("description"); }
	set { this.SetPropertyValue("description", value, 2000, "Description"); }
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
///<para>Logical Name: introducedversion</para>
///<para>Max Length: 48 characters</para>
///</summary>
[AttributeLogicalNameAttribute("introducedversion")]
public string IntroducedVersion
{
	get { return this.GetPropertyValue<string>("introducedversion"); }
	set { this.SetPropertyValue("introducedversion", value, 48, "IntroducedVersion"); }
}
///<summary>
///<para>Logical Name: ismanaged</para>
///<para>True = Managed</para>
///<para>False = Unmanaged</para>
///</summary>
[AttributeLogicalNameAttribute("ismanaged")]
public bool? IsManaged
{
	get { return this.GetPropertyValue<bool?>("ismanaged"); }
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
///<para>Logical Name: organizationid</para>
///</summary>
[AttributeLogicalNameAttribute("organizationid")]
public EntityReference Organization
{
	get { return this.GetPropertyValue<EntityReference>("organizationid"); }
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
///<summary>
///<para>Logical Name: overwritetime</para>
///</summary>
[AttributeLogicalNameAttribute("overwritetime")]
public DateTime? RecordOverwriteTime
{
	get { return this.GetPropertyValue<DateTime?>("overwritetime"); }
}
///<summary>
///<para>Logical Name: supportingsolutionid</para>
///</summary>
[AttributeLogicalNameAttribute("supportingsolutionid")]
public Guid Solution
{
	get { return this.GetPropertyValue<Guid>("supportingsolutionid"); }
}
///<summary>
///<para>Logical Name: solutionid</para>
///</summary>
[AttributeLogicalNameAttribute("solutionid")]
public Guid Solution2
{
	get { return this.GetPropertyValue<Guid>("solutionid"); }
}
///<summary>
///<para>Logical Name: effectivitycalendar</para>
///<para>Max Length: 168 characters</para>
///</summary>
[AttributeLogicalNameAttribute("effectivitycalendar")]
public string SupportCalendar
{
	get { return this.GetPropertyValue<string>("effectivitycalendar"); }
	set { this.SetPropertyValue("effectivitycalendar", value, 168, "SupportCalendar"); }
}
///<summary>
///<para>Logical Name: usediscountaspercentage</para>
///<para>True = Yes</para>
///<para>False = No</para>
///</summary>
[AttributeLogicalNameAttribute("usediscountaspercentage")]
public bool? UseDiscountAsPercentage
{
	get { return this.GetPropertyValue<bool?>("usediscountaspercentage"); }
	set { this.SetPropertyValue<bool?>("usediscountaspercentage", value, "UseDiscountAsPercentage"); }
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
/// <para>Schema Name: ContractTemplate_AsyncOperations</para>
/// </summary>
public List<SystemJob> GetSystemJobs_Regarding (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<SystemJob>(Service, this.Id, "asyncoperation", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>SystemJob (Regarding)</b></para>
/// <para>Schema Name: ContractTemplate_AsyncOperations</para>
/// </summary>
public List<SystemJob> GetSystemJobs_Regarding (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<SystemJob>(Service, this.Id, "asyncoperation", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>BulkDeleteFailure (Name)</b></para>
/// <para>Schema Name: ContractTemplate_BulkDeleteFailures</para>
/// </summary>
public List<BulkDeleteFailure> GetBulkDeleteFailures_Name (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<BulkDeleteFailure>(Service, this.Id, "bulkdeletefailure", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>BulkDeleteFailure (Name)</b></para>
/// <para>Schema Name: ContractTemplate_BulkDeleteFailures</para>
/// </summary>
public List<BulkDeleteFailure> GetBulkDeleteFailures_Name (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<BulkDeleteFailure>(Service, this.Id, "bulkdeletefailure", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>Contract (Contract Template)</b></para>
/// <para>Schema Name: contract_template_contracts</para>
/// </summary>
public List<Contract> GetContracts_ContractTemplate (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<Contract>(Service, this.Id, "contract", "contracttemplateid", Columns); }
/// <summary>
/// <para><b>Contract (Contract Template)</b></para>
/// <para>Schema Name: contract_template_contracts</para>
/// </summary>
public List<Contract> GetContracts_ContractTemplate (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<Contract>(Service, this.Id, "contract", "contracttemplateid", Columns); }
/// <summary>
/// <para><b>ProcessSession (Regarding)</b></para>
/// <para>Schema Name: ContractTemplate_ProcessSessions</para>
/// </summary>
public List<ProcessSession> GetProcessSessions_Regarding (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<ProcessSession>(Service, this.Id, "processsession", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>ProcessSession (Regarding)</b></para>
/// <para>Schema Name: ContractTemplate_ProcessSessions</para>
/// </summary>
public List<ProcessSession> GetProcessSessions_Regarding (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<ProcessSession>(Service, this.Id, "processsession", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>SyncError (Record)</b></para>
/// <para>Schema Name: ContractTemplate_SyncErrors</para>
/// </summary>
public List<SyncError> GetSyncErrors_Record (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<SyncError>(Service, this.Id, "syncerror", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>SyncError (Record)</b></para>
/// <para>Schema Name: ContractTemplate_SyncErrors</para>
/// </summary>
public List<SyncError> GetSyncErrors_Record (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<SyncError>(Service, this.Id, "syncerror", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>UserEntityInstanceData (Object Id)</b></para>
/// <para>Schema Name: userentityinstancedata_contracttemplate</para>
/// </summary>
public List<UserEntityInstanceData> GetUserEntityInstanceData_ObjectId (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<UserEntityInstanceData>(Service, this.Id, "userentityinstancedata", "objectid", Columns); }
/// <summary>
/// <para><b>UserEntityInstanceData (Object Id)</b></para>
/// <para>Schema Name: userentityinstancedata_contracttemplate</para>
/// </summary>
public List<UserEntityInstanceData> GetUserEntityInstanceData_ObjectId (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<UserEntityInstanceData>(Service, this.Id, "userentityinstancedata", "objectid", Columns); }


        

        

        public enum eAllotmentType
{
	///<summary><para>Number of Cases</para>
	///<para>Value = 1</para></summary>
	[Description("Number of Cases")]
	NumberOfCases = 1, 
	///<summary><para>Time</para>
	///<para>Value = 2</para></summary>
	[Description("Time")]
	Time = 2, 
	///<summary><para>Coverage Dates</para>
	///<para>Value = 3</para></summary>
	[Description("Coverage Dates")]
	CoverageDates = 3
}
public enum eBillingFrequency
{
	///<summary><para>Monthly</para>
	///<para>Value = 1</para></summary>
	[Description("Monthly")]
	Monthly = 1, 
	///<summary><para>Bimonthly</para>
	///<para>Value = 2</para></summary>
	[Description("Bimonthly")]
	Bimonthly = 2, 
	///<summary><para>Quarterly</para>
	///<para>Value = 3</para></summary>
	[Description("Quarterly")]
	Quarterly = 3, 
	///<summary><para>Semiannually</para>
	///<para>Value = 4</para></summary>
	[Description("Semiannually")]
	Semiannually = 4, 
	///<summary><para>Annually</para>
	///<para>Value = 5</para></summary>
	[Description("Annually")]
	Annually = 5
}
public enum eComponentState
{
	///<summary><para>Published</para>
	///<para>Value = 0</para></summary>
	[Description("Published")]
	Published = 0, 
	///<summary><para>Unpublished</para>
	///<para>Value = 1</para></summary>
	[Description("Unpublished")]
	Unpublished = 1, 
	///<summary><para>Deleted</para>
	///<para>Value = 2</para></summary>
	[Description("Deleted")]
	Deleted = 2, 
	///<summary><para>Deleted Unpublished</para>
	///<para>Value = 3</para></summary>
	[Description("Deleted Unpublished")]
	DeletedUnpublished = 3
}
public enum eContractServiceLevel
{
	///<summary><para>Gold</para>
	///<para>Value = 1</para></summary>
	[Description("Gold")]
	Gold = 1, 
	///<summary><para>Silver</para>
	///<para>Value = 2</para></summary>
	[Description("Silver")]
	Silver = 2, 
	///<summary><para>Bronze</para>
	///<para>Value = 3</para></summary>
	[Description("Bronze")]
	Bronze = 3
}


        public static class Properties
{
	/// <summary><para>createdonbehalfbyyominame</para>
	/// <para>createdonbehalfbyyominame</para></summary>
	public const string CreatedOnBehalfByYomiName = "createdonbehalfbyyominame";
	/// <summary><para>createdbyname</para>
	/// <para>createdbyname</para></summary>
	public const string CreatedByName = "createdbyname";
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
	/// <summary><para>contracttemplateidunique</para>
	/// <para>contracttemplateidunique</para></summary>
	public const string ContractTemplateIdUnique = "contracttemplateidunique";
	/// <summary><para>modifiedonbehalfbyyominame</para>
	/// <para>modifiedonbehalfbyyominame</para></summary>
	public const string ModifiedOnBehalfByYomiName = "modifiedonbehalfbyyominame";
	/// <summary><para>createdonbehalfbyname</para>
	/// <para>createdonbehalfbyname</para></summary>
	public const string CreatedOnBehalfByName = "createdonbehalfbyname";
	/// <summary><para>modifiedonbehalfbyname</para>
	/// <para>modifiedonbehalfbyname</para></summary>
	public const string ModifiedOnBehalfByName = "modifiedonbehalfbyname";
	/// <summary><para>Abbreviation</para>
	/// <para>abbreviation</para></summary>
	public const string Abbreviation = "abbreviation";
	/// <summary><para>Allotment Type</para>
	/// <para>allotmenttypecode</para></summary>
	public const string AllotmentType = "allotmenttypecode";
	/// <summary><para>Billing Frequency </para>
	/// <para>billingfrequencycode</para></summary>
	public const string BillingFrequency = "billingfrequencycode";
	/// <summary><para>Component State</para>
	/// <para>componentstate</para></summary>
	public const string ComponentState = "componentstate";
	/// <summary><para>Contract Service Level</para>
	/// <para>contractservicelevelcode</para></summary>
	public const string ContractServiceLevel = "contractservicelevelcode";
	/// <summary><para>Contract Template</para>
	/// <para>contracttemplateid</para></summary>
	public const string ContractTemplateId = "contracttemplateid";
	/// <summary><para>Created By</para>
	/// <para>createdby</para></summary>
	public const string CreatedBy = "createdby";
	/// <summary><para>Created By (Delegate)</para>
	/// <para>createdonbehalfby</para></summary>
	public const string CreatedBy_Delegate = "createdonbehalfby";
	/// <summary><para>Created On</para>
	/// <para>createdon</para></summary>
	public const string CreatedOn = "createdon";
	/// <summary><para>Customizable</para>
	/// <para>iscustomizable</para></summary>
	public const string Customizable = "iscustomizable";
	/// <summary><para>Description</para>
	/// <para>description</para></summary>
	public const string Description = "description";
	/// <summary><para>Import Sequence Number</para>
	/// <para>importsequencenumber</para></summary>
	public const string ImportSequenceNumber = "importsequencenumber";
	/// <summary><para>Introduced Version</para>
	/// <para>introducedversion</para></summary>
	public const string IntroducedVersion = "introducedversion";
	/// <summary><para>Is Managed</para>
	/// <para>ismanaged</para></summary>
	public const string IsManaged = "ismanaged";
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
	/// <summary><para>Organization</para>
	/// <para>organizationid</para></summary>
	public const string Organization = "organizationid";
	/// <summary><para>Record Created On</para>
	/// <para>overriddencreatedon</para></summary>
	public const string RecordCreatedOn = "overriddencreatedon";
	/// <summary><para>Record Overwrite Time</para>
	/// <para>overwritetime</para></summary>
	public const string RecordOverwriteTime = "overwritetime";
	/// <summary><para>Solution</para>
	/// <para>supportingsolutionid</para></summary>
	public const string Solution = "supportingsolutionid";
	/// <summary><para>Solution</para>
	/// <para>solutionid</para></summary>
	public const string Solution2 = "solutionid";
	/// <summary><para>Support Calendar</para>
	/// <para>effectivitycalendar</para></summary>
	public const string SupportCalendar = "effectivitycalendar";
	/// <summary><para>Use Discount as Percentage</para>
	/// <para>usediscountaspercentage</para></summary>
	public const string UseDiscountAsPercentage = "usediscountaspercentage";
	/// <summary><para>Version Number</para>
	/// <para>versionnumber</para></summary>
	public const string VersionNumber = "versionnumber";
}

    }
}
