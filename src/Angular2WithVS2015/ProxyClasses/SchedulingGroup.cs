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
    [EntityLogicalNameAttribute("resourcegroup")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XrmToolkit", "4.0")]
    public partial class SchedulingGroup : BaseProxyClass
    {
        public new const string LogicalName = "resourcegroup";
        public const int ObjectTypeCode = 4005;
        public const string PrimaryIdAttribute = "resourcegroupid";
        public const string PrimaryNameAttribute = "name";
        
        static SchedulingGroup()
        {
            BaseProxyClass.RegisterProxyType(typeof(SchedulingGroup), "resourcegroup");
            _textOptions = new Dictionary<string, eTextOptions>();
            _numberOptions = new Dictionary<string, eNumberOptions>();
            _errorStrings = new Dictionary<string, string>();
            TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
            NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
        }
        public SchedulingGroup() : base(new Entity("resourcegroup")) { }
        public SchedulingGroup(Entity original) : base(original) { }
        public static string GetLogicalName() { return BaseProxyClass.GetLogicalName<SchedulingGroup>(); }
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
///<para>Logical Name: organizationidname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("organizationidname")]
public string OrganizationIdName
{
	get { return this.GetPropertyValue<string>("organizationidname"); }
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
///<para>Logical Name: businessunitid</para>
///</summary>
[AttributeLogicalNameAttribute("businessunitid")]
public EntityReference BusinessUnit
{
	get { return this.GetPropertyValue<EntityReference>("businessunitid"); }
	set { this.SetPropertyValue<EntityReference>("businessunitid", value, "BusinessUnit"); }
}
///<summary>
///<para>Logical Name: objecttypecode</para>
///</summary>
[AttributeLogicalNameAttribute("objecttypecode")]
public string Entity
{
	get { return this.GetPropertyValue<string>("objecttypecode"); }
	set { this.SetPropertyValue<string>("objecttypecode", value, "Entity"); }
}
///<summary>
///<para>Logical Name: grouptypecode</para>
///</summary>
[AttributeLogicalNameAttribute("grouptypecode")]
public OptionSetValue GroupTypeCode
{
	get { return this.GetPropertyValue<OptionSetValue>("grouptypecode"); }
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
///<para>Logical Name: resourcegroupid</para>
///</summary>
[AttributeLogicalNameAttribute("resourcegroupid")]
public Guid SchedulingGroupId
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
///<para>Logical Name: versionnumber</para>
///</summary>
[AttributeLogicalNameAttribute("versionnumber")]
public int? VersionNumber
{
	get { return this.GetPropertyValue<int?>("versionnumber"); }
}


        /// <summary>
/// <para><b>SystemJob (Regarding)</b></para>
/// <para>Schema Name: ResourceGroup_AsyncOperations</para>
/// </summary>
public List<SystemJob> GetSystemJobs_Regarding (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<SystemJob>(Service, this.Id, "asyncoperation", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>SystemJob (Regarding)</b></para>
/// <para>Schema Name: ResourceGroup_AsyncOperations</para>
/// </summary>
public List<SystemJob> GetSystemJobs_Regarding (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<SystemJob>(Service, this.Id, "asyncoperation", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>BulkDeleteFailure (Name)</b></para>
/// <para>Schema Name: ResourceGroup_BulkDeleteFailures</para>
/// </summary>
public List<BulkDeleteFailure> GetBulkDeleteFailures_Name (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<BulkDeleteFailure>(Service, this.Id, "bulkdeletefailure", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>BulkDeleteFailure (Name)</b></para>
/// <para>Schema Name: ResourceGroup_BulkDeleteFailures</para>
/// </summary>
public List<BulkDeleteFailure> GetBulkDeleteFailures_Name (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<BulkDeleteFailure>(Service, this.Id, "bulkdeletefailure", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>Connection (Connected From)</b></para>
/// <para>Schema Name: resourcegroup_connections1</para>
/// </summary>
public List<Connection> GetConnections_ConnectedFrom (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<Connection>(Service, this.Id, "connection", "record1id", Columns); }
/// <summary>
/// <para><b>Connection (Connected From)</b></para>
/// <para>Schema Name: resourcegroup_connections1</para>
/// </summary>
public List<Connection> GetConnections_ConnectedFrom (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<Connection>(Service, this.Id, "connection", "record1id", Columns); }
/// <summary>
/// <para><b>Connection (Connected To)</b></para>
/// <para>Schema Name: resourcegroup_connections2</para>
/// </summary>
public List<Connection> GetConnections_ConnectedTo (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<Connection>(Service, this.Id, "connection", "record2id", Columns); }
/// <summary>
/// <para><b>Connection (Connected To)</b></para>
/// <para>Schema Name: resourcegroup_connections2</para>
/// </summary>
public List<Connection> GetConnections_ConnectedTo (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<Connection>(Service, this.Id, "connection", "record2id", Columns); }
/// <summary>
/// <para><b>DuplicateRecord (Base Record ID)</b></para>
/// <para>Schema Name: ResourceGroup_DuplicateBaseRecord</para>
/// </summary>
public List<DuplicateRecord> GetDuplicateRecords_BaseRecordID (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<DuplicateRecord>(Service, this.Id, "duplicaterecord", "baserecordid", Columns); }
/// <summary>
/// <para><b>DuplicateRecord (Base Record ID)</b></para>
/// <para>Schema Name: ResourceGroup_DuplicateBaseRecord</para>
/// </summary>
public List<DuplicateRecord> GetDuplicateRecords_BaseRecordID (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<DuplicateRecord>(Service, this.Id, "duplicaterecord", "baserecordid", Columns); }
/// <summary>
/// <para><b>DuplicateRecord (Duplicate Record ID)</b></para>
/// <para>Schema Name: ResourceGroup_DuplicateMatchingRecord</para>
/// </summary>
public List<DuplicateRecord> GetDuplicateRecords_DuplicateRecordID (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<DuplicateRecord>(Service, this.Id, "duplicaterecord", "duplicaterecordid", Columns); }
/// <summary>
/// <para><b>DuplicateRecord (Duplicate Record ID)</b></para>
/// <para>Schema Name: ResourceGroup_DuplicateMatchingRecord</para>
/// </summary>
public List<DuplicateRecord> GetDuplicateRecords_DuplicateRecordID (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<DuplicateRecord>(Service, this.Id, "duplicaterecord", "duplicaterecordid", Columns); }
/// <summary>
/// <para><b>SyncError (Record)</b></para>
/// <para>Schema Name: ResourceGroup_SyncErrors</para>
/// </summary>
public List<SyncError> GetSyncErrors_Record (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<SyncError>(Service, this.Id, "syncerror", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>SyncError (Record)</b></para>
/// <para>Schema Name: ResourceGroup_SyncErrors</para>
/// </summary>
public List<SyncError> GetSyncErrors_Record (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<SyncError>(Service, this.Id, "syncerror", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>UserEntityInstanceData (Object Id)</b></para>
/// <para>Schema Name: userentityinstancedata_resourcegroup</para>
/// </summary>
public List<UserEntityInstanceData> GetUserEntityInstanceData_ObjectId (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<UserEntityInstanceData>(Service, this.Id, "userentityinstancedata", "objectid", Columns); }
/// <summary>
/// <para><b>UserEntityInstanceData (Object Id)</b></para>
/// <para>Schema Name: userentityinstancedata_resourcegroup</para>
/// </summary>
public List<UserEntityInstanceData> GetUserEntityInstanceData_ObjectId (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<UserEntityInstanceData>(Service, this.Id, "userentityinstancedata", "objectid", Columns); }


        

        

        

        public static class Properties
{
	/// <summary><para>organizationidname</para>
	/// <para>organizationidname</para></summary>
	public const string OrganizationIdName = "organizationidname";
	/// <summary><para>businessunitidname</para>
	/// <para>businessunitidname</para></summary>
	public const string BusinessUnitIdName = "businessunitidname";
	/// <summary><para>Business Unit</para>
	/// <para>businessunitid</para></summary>
	public const string BusinessUnit = "businessunitid";
	/// <summary><para>Entity</para>
	/// <para>objecttypecode</para></summary>
	public const string Entity = "objecttypecode";
	/// <summary><para>Group Type Code</para>
	/// <para>grouptypecode</para></summary>
	public const string GroupTypeCode = "grouptypecode";
	/// <summary><para>Name</para>
	/// <para>name</para></summary>
	public const string Name = "name";
	/// <summary><para>Organization</para>
	/// <para>organizationid</para></summary>
	public const string Organization = "organizationid";
	/// <summary><para>Scheduling Group</para>
	/// <para>resourcegroupid</para></summary>
	public const string SchedulingGroupId = "resourcegroupid";
	/// <summary><para>Version Number</para>
	/// <para>versionnumber</para></summary>
	public const string VersionNumber = "versionnumber";
}

    }
}
