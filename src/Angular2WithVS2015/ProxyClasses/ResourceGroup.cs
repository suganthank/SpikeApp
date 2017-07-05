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
    [EntityLogicalNameAttribute("constraintbasedgroup")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XrmToolkit", "4.0")]
    public partial class ResourceGroup : BaseProxyClass
    {
        public new const string LogicalName = "constraintbasedgroup";
        public const int ObjectTypeCode = 4007;
        public const string PrimaryIdAttribute = "constraintbasedgroupid";
        public const string PrimaryNameAttribute = "name";
        
        static ResourceGroup()
        {
            BaseProxyClass.RegisterProxyType(typeof(ResourceGroup), "constraintbasedgroup");
            _textOptions = new Dictionary<string, eTextOptions>();
            _numberOptions = new Dictionary<string, eNumberOptions>();
            _errorStrings = new Dictionary<string, string>();
            TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
            NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
        }
        public ResourceGroup() : base(new Entity("constraintbasedgroup")) { }
        public ResourceGroup(Entity original) : base(original) { }
        public static string GetLogicalName() { return BaseProxyClass.GetLogicalName<ResourceGroup>(); }
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
///<para>Logical Name: businessunitidname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("businessunitidname")]
public string BusinessUnitIdName
{
	get { return this.GetPropertyValue<string>("businessunitidname"); }
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
///<para>Logical Name: businessunitid</para>
///</summary>
[AttributeLogicalNameAttribute("businessunitid")]
public EntityReference BusinessUnit
{
	get { return this.GetPropertyValue<EntityReference>("businessunitid"); }
	set { this.SetPropertyValue<EntityReference>("businessunitid", value, "BusinessUnit"); }
}
///<summary>
///<para>Logical Name: constraints</para>
///<para>Max Length: 1073741823 characters</para>
///</summary>
[AttributeLogicalNameAttribute("constraints")]
public string Constraints
{
	get { return this.GetPropertyValue<string>("constraints"); }
	set { this.SetPropertyValue("constraints", value, 1073741823, "Constraints"); }
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
///<para>Logical Name: description</para>
///<para>Max Length: 2000 characters</para>
///</summary>
[AttributeLogicalNameAttribute("description")]
public string Description
{
	get { return this.GetPropertyValue<string>("description"); }
	set { this.SetPropertyValue("description", value, 2000, "Description"); }
}
/// <summary>
///Logical Name: grouptypecode
/// </summary>
[AttributeLogicalNameAttribute("grouptypecode")]
public eGroupType? GroupType
{
	get
	{
		if (GroupType_OptionSetValue != null) { return (eGroupType)GroupType_OptionSetValue.Value; }
		return null;
	}
	set
	{
		if (value != null) { this.GroupType_OptionSetValue = new OptionSetValue((int)value); }
		else this.GroupType_OptionSetValue = null;
	}
}
///<summary>
///<para>Logical Name: grouptypecode</para>
///</summary>
[AttributeLogicalNameAttribute("grouptypecode")]
public OptionSetValue GroupType_OptionSetValue
{
	get { return this.GetPropertyValue<OptionSetValue>("grouptypecode"); }
	set { this.SetPropertyValue<OptionSetValue>("grouptypecode", value, "GroupType_OptionSetValue"); }
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="Service">CRM Organization Service</param>
/// <returns></returns>
public string GroupType_Text(IOrganizationService Service)
{
	return this.GroupType_OptionSetValue.GetOptionSetText(Service, this, "grouptypecode");
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="AttributeMetadata">The attribute metadata previously retrieved using the 'GetAttributeMetadata' extension method on the IOrganizationService object.</param>
/// <returns></returns>
public string GroupType_Text(EnumAttributeMetadata AttributeMetadata)
{
	return AttributeMetadata.GetOptionSetText(this.GroupType_OptionSetValue.Value);
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
///<para>Max Length: 160 characters</para>
///</summary>
[AttributeLogicalNameAttribute("name")]
public string Name
{
	get { return this.GetPropertyValue<string>("name"); }
	set { this.SetPropertyValue("name", value, 160, "Name"); }
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
///<para>Key Property (Uniqueidentifier)</para>
///<para>Logical Name: constraintbasedgroupid</para>
///</summary>
[AttributeLogicalNameAttribute("constraintbasedgroupid")]
public Guid ResourceGroupId
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
/// <para><b>SystemJob (Regarding)</b></para>
/// <para>Schema Name: ConstraintBasedGroup_AsyncOperations</para>
/// </summary>
public List<SystemJob> GetSystemJobs_Regarding (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<SystemJob>(Service, this.Id, "asyncoperation", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>SystemJob (Regarding)</b></para>
/// <para>Schema Name: ConstraintBasedGroup_AsyncOperations</para>
/// </summary>
public List<SystemJob> GetSystemJobs_Regarding (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<SystemJob>(Service, this.Id, "asyncoperation", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>BulkDeleteFailure (Name)</b></para>
/// <para>Schema Name: ConstraintBasedGroup_BulkDeleteFailures</para>
/// </summary>
public List<BulkDeleteFailure> GetBulkDeleteFailures_Name (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<BulkDeleteFailure>(Service, this.Id, "bulkdeletefailure", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>BulkDeleteFailure (Name)</b></para>
/// <para>Schema Name: ConstraintBasedGroup_BulkDeleteFailures</para>
/// </summary>
public List<BulkDeleteFailure> GetBulkDeleteFailures_Name (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<BulkDeleteFailure>(Service, this.Id, "bulkdeletefailure", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>BusinessUnitMap ()</b></para>
/// <para>Schema Name: business_map_constraint</para>
/// </summary>
public List<BusinessUnitMap> GetBusinessUnitMaps (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<BusinessUnitMap>(Service, this.Id, "businessunitmap", "subbusinessid", Columns); }
/// <summary>
/// <para><b>BusinessUnitMap ()</b></para>
/// <para>Schema Name: business_map_constraint</para>
/// </summary>
public List<BusinessUnitMap> GetBusinessUnitMaps (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<BusinessUnitMap>(Service, this.Id, "businessunitmap", "subbusinessid", Columns); }
/// <summary>
/// <para><b>Connection (Connected From)</b></para>
/// <para>Schema Name: constraintbasedgroup_connections1</para>
/// </summary>
public List<Connection> GetConnections_ConnectedFrom (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<Connection>(Service, this.Id, "connection", "record1id", Columns); }
/// <summary>
/// <para><b>Connection (Connected From)</b></para>
/// <para>Schema Name: constraintbasedgroup_connections1</para>
/// </summary>
public List<Connection> GetConnections_ConnectedFrom (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<Connection>(Service, this.Id, "connection", "record1id", Columns); }
/// <summary>
/// <para><b>Connection (Connected To)</b></para>
/// <para>Schema Name: constraintbasedgroup_connections2</para>
/// </summary>
public List<Connection> GetConnections_ConnectedTo (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<Connection>(Service, this.Id, "connection", "record2id", Columns); }
/// <summary>
/// <para><b>Connection (Connected To)</b></para>
/// <para>Schema Name: constraintbasedgroup_connections2</para>
/// </summary>
public List<Connection> GetConnections_ConnectedTo (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<Connection>(Service, this.Id, "connection", "record2id", Columns); }
/// <summary>
/// <para><b>ProcessSession (Regarding)</b></para>
/// <para>Schema Name: ConstraintBasedGroup_ProcessSessions</para>
/// </summary>
public List<ProcessSession> GetProcessSessions_Regarding (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<ProcessSession>(Service, this.Id, "processsession", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>ProcessSession (Regarding)</b></para>
/// <para>Schema Name: ConstraintBasedGroup_ProcessSessions</para>
/// </summary>
public List<ProcessSession> GetProcessSessions_Regarding (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<ProcessSession>(Service, this.Id, "processsession", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>SchedulingGroup (Scheduling Group)</b></para>
/// <para>Schema Name: constraintbasedgroup_resource_groups</para>
/// </summary>
public List<SchedulingGroup> GetSchedulingGroups_SchedulingGroup (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<SchedulingGroup>(Service, this.Id, "resourcegroup", "resourcegroupid", Columns); }
/// <summary>
/// <para><b>SchedulingGroup (Scheduling Group)</b></para>
/// <para>Schema Name: constraintbasedgroup_resource_groups</para>
/// </summary>
public List<SchedulingGroup> GetSchedulingGroups_SchedulingGroup (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<SchedulingGroup>(Service, this.Id, "resourcegroup", "resourcegroupid", Columns); }
/// <summary>
/// <para><b>ResourceSpecification (Group Object)</b></para>
/// <para>Schema Name: constraint_based_group_resource_specs</para>
/// </summary>
public List<ResourceSpecification> GetResourceSpecifications_GroupObject (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<ResourceSpecification>(Service, this.Id, "resourcespec", "groupobjectid", Columns); }
/// <summary>
/// <para><b>ResourceSpecification (Group Object)</b></para>
/// <para>Schema Name: constraint_based_group_resource_specs</para>
/// </summary>
public List<ResourceSpecification> GetResourceSpecifications_GroupObject (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<ResourceSpecification>(Service, this.Id, "resourcespec", "groupobjectid", Columns); }
/// <summary>
/// <para><b>UserEntityInstanceData (Object Id)</b></para>
/// <para>Schema Name: userentityinstancedata_constraintbasedgroup</para>
/// </summary>
public List<UserEntityInstanceData> GetUserEntityInstanceData_ObjectId (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<UserEntityInstanceData>(Service, this.Id, "userentityinstancedata", "objectid", Columns); }
/// <summary>
/// <para><b>UserEntityInstanceData (Object Id)</b></para>
/// <para>Schema Name: userentityinstancedata_constraintbasedgroup</para>
/// </summary>
public List<UserEntityInstanceData> GetUserEntityInstanceData_ObjectId (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<UserEntityInstanceData>(Service, this.Id, "userentityinstancedata", "objectid", Columns); }


        

        

        public enum eGroupType
{
	///<summary><para>Static</para>
	///<para>Value = 0</para></summary>
	[Description("Static")]
	@Static = 0, 
	///<summary><para>Dynamic</para>
	///<para>Value = 1</para></summary>
	[Description("Dynamic")]
	@Dynamic = 1, 
	///<summary><para>Hidden</para>
	///<para>Value = 2</para></summary>
	[Description("Hidden")]
	Hidden = 2
}


        public static class Properties
{
	/// <summary><para>createdonbehalfbyyominame</para>
	/// <para>createdonbehalfbyyominame</para></summary>
	public const string CreatedOnBehalfByYomiName = "createdonbehalfbyyominame";
	/// <summary><para>organizationidname</para>
	/// <para>organizationidname</para></summary>
	public const string OrganizationIdName = "organizationidname";
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
	/// <summary><para>businessunitidname</para>
	/// <para>businessunitidname</para></summary>
	public const string BusinessUnitIdName = "businessunitidname";
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
	/// <summary><para>Business Unit</para>
	/// <para>businessunitid</para></summary>
	public const string BusinessUnit = "businessunitid";
	/// <summary><para>Constraints</para>
	/// <para>constraints</para></summary>
	public const string Constraints = "constraints";
	/// <summary><para>Created By</para>
	/// <para>createdby</para></summary>
	public const string CreatedBy = "createdby";
	/// <summary><para>Created By (Delegate)</para>
	/// <para>createdonbehalfby</para></summary>
	public const string CreatedBy_Delegate = "createdonbehalfby";
	/// <summary><para>Created On</para>
	/// <para>createdon</para></summary>
	public const string CreatedOn = "createdon";
	/// <summary><para>Description</para>
	/// <para>description</para></summary>
	public const string Description = "description";
	/// <summary><para>Group Type</para>
	/// <para>grouptypecode</para></summary>
	public const string GroupType = "grouptypecode";
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
	/// <summary><para>Resource Group</para>
	/// <para>constraintbasedgroupid</para></summary>
	public const string ResourceGroupId = "constraintbasedgroupid";
}

    }
}
