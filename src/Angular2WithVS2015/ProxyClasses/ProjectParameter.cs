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
    [EntityLogicalNameAttribute("msdyn_projectparameter")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XrmToolkit", "4.0")]
    public partial class ProjectParameter : BaseProxyClass
    {
        public new const string LogicalName = "msdyn_projectparameter";
        public const int ObjectTypeCode = 10066;
        public const string PrimaryIdAttribute = "msdyn_projectparameterid";
        public const string PrimaryNameAttribute = "msdyn_description";
        
        static ProjectParameter()
        {
            BaseProxyClass.RegisterProxyType(typeof(ProjectParameter), "msdyn_projectparameter");
            _textOptions = new Dictionary<string, eTextOptions>();
            _numberOptions = new Dictionary<string, eNumberOptions>();
            _errorStrings = new Dictionary<string, string>();
            TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
            NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
        }
        public ProjectParameter() : base(new Entity("msdyn_projectparameter")) { }
        public ProjectParameter(Entity original) : base(original) { }
        public static string GetLogicalName() { return BaseProxyClass.GetLogicalName<ProjectParameter>(); }
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
///<para>Logical Name: msdyn_defaultworktemplatename</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("msdyn_defaultworktemplatename")]
public string Msdyn_defaultWorkTemplateName
{
	get { return this.GetPropertyValue<string>("msdyn_defaultworktemplatename"); }
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
///<para>Logical Name: msdyn_invoicefrequencyname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("msdyn_invoicefrequencyname")]
public string Msdyn_invoicefrequencyName
{
	get { return this.GetPropertyValue<string>("msdyn_invoicefrequencyname"); }
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
///<para>Logical Name: msdyn_teammemberrolename</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("msdyn_teammemberrolename")]
public string Msdyn_teammemberroleName
{
	get { return this.GetPropertyValue<string>("msdyn_teammemberrolename"); }
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
///<para>Logical Name: msdyn_projectmanagerrolename</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("msdyn_projectmanagerrolename")]
public string Msdyn_projectmanagerroleName
{
	get { return this.GetPropertyValue<string>("msdyn_projectmanagerrolename"); }
}
///<summary>
///<para>Logical Name: msdyn_defaultorganizationalunitname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("msdyn_defaultorganizationalunitname")]
public string Msdyn_defaultorganizationalunitName
{
	get { return this.GetPropertyValue<string>("msdyn_defaultorganizationalunitname"); }
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
///<para>Logical Name: msdyn_allowskillupdatebyresource</para>
///<para>True = Yes</para>
///<para>False = No</para>
///</summary>
[AttributeLogicalNameAttribute("msdyn_allowskillupdatebyresource")]
public bool? AllowSkillUpdateByResource
{
	get { return this.GetPropertyValue<bool?>("msdyn_allowskillupdatebyresource"); }
	set { this.SetPropertyValue<bool?>("msdyn_allowskillupdatebyresource", value, "AllowSkillUpdateByResource"); }
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
///<para>Logical Name: msdyn_defaultorganizationalunit</para>
///</summary>
[AttributeLogicalNameAttribute("msdyn_defaultorganizationalunit")]
public EntityReference DefaultOrganizationalUnit
{
	get { return this.GetPropertyValue<EntityReference>("msdyn_defaultorganizationalunit"); }
	set { this.SetPropertyValue<EntityReference>("msdyn_defaultorganizationalunit", value, "DefaultOrganizationalUnit"); }
}
///<summary>
///<para>Logical Name: msdyn_defaultworktemplate</para>
///</summary>
[AttributeLogicalNameAttribute("msdyn_defaultworktemplate")]
public EntityReference DefaultWorkTemplate
{
	get { return this.GetPropertyValue<EntityReference>("msdyn_defaultworktemplate"); }
	set { this.SetPropertyValue<EntityReference>("msdyn_defaultworktemplate", value, "DefaultWorkTemplate"); }
}
///<summary>
///<para>Logical Name: msdyn_description</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("msdyn_description")]
public string Description
{
	get { return this.GetPropertyValue<string>("msdyn_description"); }
	set { this.SetPropertyValue("msdyn_description", value, 100, "Description"); }
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
///<para>Logical Name: msdyn_invoicefrequency</para>
///</summary>
[AttributeLogicalNameAttribute("msdyn_invoicefrequency")]
public EntityReference InvoiceFrequency
{
	get { return this.GetPropertyValue<EntityReference>("msdyn_invoicefrequency"); }
	set { this.SetPropertyValue<EntityReference>("msdyn_invoicefrequency", value, "InvoiceFrequency"); }
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
///<para>Logical Name: organizationid</para>
///</summary>
[AttributeLogicalNameAttribute("organizationid")]
public EntityReference OrganizationId
{
	get { return this.GetPropertyValue<EntityReference>("organizationid"); }
}
///<summary>
///<para>Logical Name: msdyn_projectmanagerrole</para>
///</summary>
[AttributeLogicalNameAttribute("msdyn_projectmanagerrole")]
public EntityReference ProjectManagerRole
{
	get { return this.GetPropertyValue<EntityReference>("msdyn_projectmanagerrole"); }
	set { this.SetPropertyValue<EntityReference>("msdyn_projectmanagerrole", value, "ProjectManagerRole"); }
}
///<summary>
///<para>Key Property (Uniqueidentifier)</para>
///<para>Logical Name: msdyn_projectparameterid</para>
///</summary>
[AttributeLogicalNameAttribute("msdyn_projectparameterid")]
public Guid ProjectParameterId
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
///<para>Logical Name: overriddencreatedon</para>
///</summary>
[AttributeLogicalNameAttribute("overriddencreatedon")]
public DateTime? RecordCreatedOn
{
	get { return this.GetPropertyValue<DateTime?>("overriddencreatedon"); }
	set { this.SetPropertyValue<DateTime?>("overriddencreatedon", value, "RecordCreatedOn"); }
}
/// <summary>
///Logical Name: msdyn_resourceallocationmode
/// </summary>
[AttributeLogicalNameAttribute("msdyn_resourceallocationmode")]
public eResourceAllocationMode? ResourceAllocationMode
{
	get
	{
		if (ResourceAllocationMode_OptionSetValue != null) { return (eResourceAllocationMode)ResourceAllocationMode_OptionSetValue.Value; }
		return null;
	}
	set
	{
		if (value != null) { this.ResourceAllocationMode_OptionSetValue = new OptionSetValue((int)value); }
		else this.ResourceAllocationMode_OptionSetValue = null;
	}
}
///<summary>
///<para>Logical Name: msdyn_resourceallocationmode</para>
///</summary>
[AttributeLogicalNameAttribute("msdyn_resourceallocationmode")]
public OptionSetValue ResourceAllocationMode_OptionSetValue
{
	get { return this.GetPropertyValue<OptionSetValue>("msdyn_resourceallocationmode"); }
	set { this.SetPropertyValue<OptionSetValue>("msdyn_resourceallocationmode", value, "ResourceAllocationMode_OptionSetValue"); }
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="Service">CRM Organization Service</param>
/// <returns></returns>
public string ResourceAllocationMode_Text(IOrganizationService Service)
{
	return this.ResourceAllocationMode_OptionSetValue.GetOptionSetText(Service, this, "msdyn_resourceallocationmode");
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="AttributeMetadata">The attribute metadata previously retrieved using the 'GetAttributeMetadata' extension method on the IOrganizationService object.</param>
/// <returns></returns>
public string ResourceAllocationMode_Text(EnumAttributeMetadata AttributeMetadata)
{
	return AttributeMetadata.GetOptionSetText(this.ResourceAllocationMode_OptionSetValue.Value);
}
///<summary>
///<para>Logical Name: msdyn_projectresourcerequirementsvisibletore</para>
///<para>True = Yes</para>
///<para>False = No</para>
///</summary>
[AttributeLogicalNameAttribute("msdyn_projectresourcerequirementsvisibletore")]
public bool? ResourceRequirementsVisibleToResources
{
	get { return this.GetPropertyValue<bool?>("msdyn_projectresourcerequirementsvisibletore"); }
	set { this.SetPropertyValue<bool?>("msdyn_projectresourcerequirementsvisibletore", value, "ResourceRequirementsVisibleToResources"); }
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
///<para>Logical Name: msdyn_teammemberrole</para>
///</summary>
[AttributeLogicalNameAttribute("msdyn_teammemberrole")]
public EntityReference TeamMemberRole
{
	get { return this.GetPropertyValue<EntityReference>("msdyn_teammemberrole"); }
	set { this.SetPropertyValue<EntityReference>("msdyn_teammemberrole", value, "TeamMemberRole"); }
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
///<summary>
///<para>Logical Name: versionnumber</para>
///</summary>
[AttributeLogicalNameAttribute("versionnumber")]
public int? VersionNumber
{
	get { return this.GetPropertyValue<int?>("versionnumber"); }
}


        /// <summary>
/// <para><b>Note (Regarding)</b></para>
/// <para>Schema Name: msdyn_projectparameter_Annotations</para>
/// </summary>
public List<Note> GetNotes_Regarding (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<Note>(Service, this.Id, "annotation", "objectid", Columns); }
/// <summary>
/// <para><b>Note (Regarding)</b></para>
/// <para>Schema Name: msdyn_projectparameter_Annotations</para>
/// </summary>
public List<Note> GetNotes_Regarding (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<Note>(Service, this.Id, "annotation", "objectid", Columns); }
/// <summary>
/// <para><b>SystemJob (Regarding)</b></para>
/// <para>Schema Name: msdyn_projectparameter_AsyncOperations</para>
/// </summary>
public List<SystemJob> GetSystemJobs_Regarding (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<SystemJob>(Service, this.Id, "asyncoperation", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>SystemJob (Regarding)</b></para>
/// <para>Schema Name: msdyn_projectparameter_AsyncOperations</para>
/// </summary>
public List<SystemJob> GetSystemJobs_Regarding (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<SystemJob>(Service, this.Id, "asyncoperation", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>BulkDeleteFailure (Name)</b></para>
/// <para>Schema Name: msdyn_projectparameter_BulkDeleteFailures</para>
/// </summary>
public List<BulkDeleteFailure> GetBulkDeleteFailures_Name (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<BulkDeleteFailure>(Service, this.Id, "bulkdeletefailure", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>BulkDeleteFailure (Name)</b></para>
/// <para>Schema Name: msdyn_projectparameter_BulkDeleteFailures</para>
/// </summary>
public List<BulkDeleteFailure> GetBulkDeleteFailures_Name (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<BulkDeleteFailure>(Service, this.Id, "bulkdeletefailure", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>DuplicateRecord (Base Record ID)</b></para>
/// <para>Schema Name: msdyn_projectparameter_DuplicateBaseRecord</para>
/// </summary>
public List<DuplicateRecord> GetDuplicateRecords_BaseRecordID (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<DuplicateRecord>(Service, this.Id, "duplicaterecord", "baserecordid", Columns); }
/// <summary>
/// <para><b>DuplicateRecord (Base Record ID)</b></para>
/// <para>Schema Name: msdyn_projectparameter_DuplicateBaseRecord</para>
/// </summary>
public List<DuplicateRecord> GetDuplicateRecords_BaseRecordID (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<DuplicateRecord>(Service, this.Id, "duplicaterecord", "baserecordid", Columns); }
/// <summary>
/// <para><b>DuplicateRecord (Duplicate Record ID)</b></para>
/// <para>Schema Name: msdyn_projectparameter_DuplicateMatchingRecord</para>
/// </summary>
public List<DuplicateRecord> GetDuplicateRecords_DuplicateRecordID (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<DuplicateRecord>(Service, this.Id, "duplicaterecord", "duplicaterecordid", Columns); }
/// <summary>
/// <para><b>DuplicateRecord (Duplicate Record ID)</b></para>
/// <para>Schema Name: msdyn_projectparameter_DuplicateMatchingRecord</para>
/// </summary>
public List<DuplicateRecord> GetDuplicateRecords_DuplicateRecordID (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<DuplicateRecord>(Service, this.Id, "duplicaterecord", "duplicaterecordid", Columns); }
/// <summary>
/// <para><b>MailboxAutoTrackingFolder (Regarding Object Id)</b></para>
/// <para>Schema Name: msdyn_projectparameter_MailboxTrackingFolders</para>
/// </summary>
public List<MailboxAutoTrackingFolder> GetMailboxAutoTrackingFolders_RegardingObjectId (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<MailboxAutoTrackingFolder>(Service, this.Id, "mailboxtrackingfolder", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>MailboxAutoTrackingFolder (Regarding Object Id)</b></para>
/// <para>Schema Name: msdyn_projectparameter_MailboxTrackingFolders</para>
/// </summary>
public List<MailboxAutoTrackingFolder> GetMailboxAutoTrackingFolders_RegardingObjectId (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<MailboxAutoTrackingFolder>(Service, this.Id, "mailboxtrackingfolder", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>ProjectParameterPriceList (Project Parameter)</b></para>
/// <para>Schema Name: msdyn_msdyn_projectparameter_msdyn_projectparameterpricelist_ProjectParameter</para>
/// </summary>
public List<ProjectParameterPriceList> GetProjectParameterPriceLists_ProjectParameter (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<ProjectParameterPriceList>(Service, this.Id, "msdyn_projectparameterpricelist", "msdyn_projectparameter", Columns); }
/// <summary>
/// <para><b>ProjectParameterPriceList (Project Parameter)</b></para>
/// <para>Schema Name: msdyn_msdyn_projectparameter_msdyn_projectparameterpricelist_ProjectParameter</para>
/// </summary>
public List<ProjectParameterPriceList> GetProjectParameterPriceLists_ProjectParameter (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<ProjectParameterPriceList>(Service, this.Id, "msdyn_projectparameterpricelist", "msdyn_projectparameter", Columns); }
/// <summary>
/// <para><b>FieldSharing (Entity instance)</b></para>
/// <para>Schema Name: msdyn_projectparameter_PrincipalObjectAttributeAccesses</para>
/// </summary>
public List<FieldSharing> GetFieldSharing_EntityInstance (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<FieldSharing>(Service, this.Id, "principalobjectattributeaccess", "objectid", Columns); }
/// <summary>
/// <para><b>FieldSharing (Entity instance)</b></para>
/// <para>Schema Name: msdyn_projectparameter_PrincipalObjectAttributeAccesses</para>
/// </summary>
public List<FieldSharing> GetFieldSharing_EntityInstance (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<FieldSharing>(Service, this.Id, "principalobjectattributeaccess", "objectid", Columns); }
/// <summary>
/// <para><b>ProcessSession (Regarding)</b></para>
/// <para>Schema Name: msdyn_projectparameter_ProcessSession</para>
/// </summary>
public List<ProcessSession> GetProcessSessions_Regarding (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<ProcessSession>(Service, this.Id, "processsession", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>ProcessSession (Regarding)</b></para>
/// <para>Schema Name: msdyn_projectparameter_ProcessSession</para>
/// </summary>
public List<ProcessSession> GetProcessSessions_Regarding (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<ProcessSession>(Service, this.Id, "processsession", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>SyncError (Record)</b></para>
/// <para>Schema Name: msdyn_projectparameter_SyncErrors</para>
/// </summary>
public List<SyncError> GetSyncErrors_Record (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<SyncError>(Service, this.Id, "syncerror", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>SyncError (Record)</b></para>
/// <para>Schema Name: msdyn_projectparameter_SyncErrors</para>
/// </summary>
public List<SyncError> GetSyncErrors_Record (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<SyncError>(Service, this.Id, "syncerror", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>UserEntityInstanceData (Object Id)</b></para>
/// <para>Schema Name: msdyn_projectparameter_UserEntityInstanceDatas</para>
/// </summary>
public List<UserEntityInstanceData> GetUserEntityInstanceData_ObjectId (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<UserEntityInstanceData>(Service, this.Id, "userentityinstancedata", "objectid", Columns); }
/// <summary>
/// <para><b>UserEntityInstanceData (Object Id)</b></para>
/// <para>Schema Name: msdyn_projectparameter_UserEntityInstanceDatas</para>
/// </summary>
public List<UserEntityInstanceData> GetUserEntityInstanceData_ObjectId (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<UserEntityInstanceData>(Service, this.Id, "userentityinstancedata", "objectid", Columns); }


        

        

        public enum eResourceAllocationMode
{
	///<summary><para>Centralized</para>
	///<para>Value = 1</para></summary>
	[Description("Centralized")]
	Centralized = 1, 
	///<summary><para>Hybrid</para>
	///<para>Value = 2</para></summary>
	[Description("Hybrid")]
	Hybrid = 2
}
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
	/// <summary><para>msdyn_defaultworktemplatename</para>
	/// <para>msdyn_defaultworktemplatename</para></summary>
	public const string Msdyn_defaultWorkTemplateName = "msdyn_defaultworktemplatename";
	/// <summary><para>organizationidname</para>
	/// <para>organizationidname</para></summary>
	public const string OrganizationIdName = "organizationidname";
	/// <summary><para>msdyn_invoicefrequencyname</para>
	/// <para>msdyn_invoicefrequencyname</para></summary>
	public const string Msdyn_invoicefrequencyName = "msdyn_invoicefrequencyname";
	/// <summary><para>modifiedbyyominame</para>
	/// <para>modifiedbyyominame</para></summary>
	public const string ModifiedByYomiName = "modifiedbyyominame";
	/// <summary><para>msdyn_teammemberrolename</para>
	/// <para>msdyn_teammemberrolename</para></summary>
	public const string Msdyn_teammemberroleName = "msdyn_teammemberrolename";
	/// <summary><para>createdbyyominame</para>
	/// <para>createdbyyominame</para></summary>
	public const string CreatedByYomiName = "createdbyyominame";
	/// <summary><para>modifiedbyname</para>
	/// <para>modifiedbyname</para></summary>
	public const string ModifiedByName = "modifiedbyname";
	/// <summary><para>msdyn_projectmanagerrolename</para>
	/// <para>msdyn_projectmanagerrolename</para></summary>
	public const string Msdyn_projectmanagerroleName = "msdyn_projectmanagerrolename";
	/// <summary><para>msdyn_defaultorganizationalunitname</para>
	/// <para>msdyn_defaultorganizationalunitname</para></summary>
	public const string Msdyn_defaultorganizationalunitName = "msdyn_defaultorganizationalunitname";
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
	/// <summary><para>Allow skill update by resource</para>
	/// <para>msdyn_allowskillupdatebyresource</para></summary>
	public const string AllowSkillUpdateByResource = "msdyn_allowskillupdatebyresource";
	/// <summary><para>Created By</para>
	/// <para>createdby</para></summary>
	public const string CreatedBy = "createdby";
	/// <summary><para>Created By (Delegate)</para>
	/// <para>createdonbehalfby</para></summary>
	public const string CreatedBy_Delegate = "createdonbehalfby";
	/// <summary><para>Created On</para>
	/// <para>createdon</para></summary>
	public const string CreatedOn = "createdon";
	/// <summary><para>Default Organizational Unit</para>
	/// <para>msdyn_defaultorganizationalunit</para></summary>
	public const string DefaultOrganizationalUnit = "msdyn_defaultorganizationalunit";
	/// <summary><para>defaultWorkTemplate</para>
	/// <para>msdyn_defaultworktemplate</para></summary>
	public const string DefaultWorkTemplate = "msdyn_defaultworktemplate";
	/// <summary><para>Description</para>
	/// <para>msdyn_description</para></summary>
	public const string Description = "msdyn_description";
	/// <summary><para>Import Sequence Number</para>
	/// <para>importsequencenumber</para></summary>
	public const string ImportSequenceNumber = "importsequencenumber";
	/// <summary><para>Invoice Frequency</para>
	/// <para>msdyn_invoicefrequency</para></summary>
	public const string InvoiceFrequency = "msdyn_invoicefrequency";
	/// <summary><para>Modified By</para>
	/// <para>modifiedby</para></summary>
	public const string ModifiedBy = "modifiedby";
	/// <summary><para>Modified By (Delegate)</para>
	/// <para>modifiedonbehalfby</para></summary>
	public const string ModifiedBy_Delegate = "modifiedonbehalfby";
	/// <summary><para>Modified On</para>
	/// <para>modifiedon</para></summary>
	public const string ModifiedOn = "modifiedon";
	/// <summary><para>Organization Id</para>
	/// <para>organizationid</para></summary>
	public const string OrganizationId = "organizationid";
	/// <summary><para>Project Manager Role</para>
	/// <para>msdyn_projectmanagerrole</para></summary>
	public const string ProjectManagerRole = "msdyn_projectmanagerrole";
	/// <summary><para>Project Parameter</para>
	/// <para>msdyn_projectparameterid</para></summary>
	public const string ProjectParameterId = "msdyn_projectparameterid";
	/// <summary><para>Record Created On</para>
	/// <para>overriddencreatedon</para></summary>
	public const string RecordCreatedOn = "overriddencreatedon";
	/// <summary><para>Resource allocation mode</para>
	/// <para>msdyn_resourceallocationmode</para></summary>
	public const string ResourceAllocationMode = "msdyn_resourceallocationmode";
	/// <summary><para>Resource requirements visible to resources</para>
	/// <para>msdyn_projectresourcerequirementsvisibletore</para></summary>
	public const string ResourceRequirementsVisibleToResources = "msdyn_projectresourcerequirementsvisibletore";
	/// <summary><para>Status</para>
	/// <para>statecode</para></summary>
	public const string Status = "statecode";
	/// <summary><para>Status Reason</para>
	/// <para>statuscode</para></summary>
	public const string StatusReason = "statuscode";
	/// <summary><para>Team Member Role</para>
	/// <para>msdyn_teammemberrole</para></summary>
	public const string TeamMemberRole = "msdyn_teammemberrole";
	/// <summary><para>Time Zone Rule Version Number</para>
	/// <para>timezoneruleversionnumber</para></summary>
	public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
	/// <summary><para>UTC Conversion Time Zone Code</para>
	/// <para>utcconversiontimezonecode</para></summary>
	public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
	/// <summary><para>Version Number</para>
	/// <para>versionnumber</para></summary>
	public const string VersionNumber = "versionnumber";
}

    }
}