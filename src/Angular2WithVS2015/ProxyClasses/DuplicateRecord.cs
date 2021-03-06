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
    [EntityLogicalNameAttribute("duplicaterecord")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XrmToolkit", "4.0")]
    public partial class DuplicateRecord : BaseProxyClass
    {
        public new const string LogicalName = "duplicaterecord";
        public const int ObjectTypeCode = 4415;
        public const string PrimaryIdAttribute = "duplicateid";
        public const string PrimaryNameAttribute = "";
        
        static DuplicateRecord()
        {
            BaseProxyClass.RegisterProxyType(typeof(DuplicateRecord), "duplicaterecord");
            _textOptions = new Dictionary<string, eTextOptions>();
            _numberOptions = new Dictionary<string, eNumberOptions>();
            _errorStrings = new Dictionary<string, string>();
            TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
            NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
        }
        public DuplicateRecord() : base(new Entity("duplicaterecord")) { }
        public DuplicateRecord(Entity original) : base(original) { }
        public static string GetLogicalName() { return BaseProxyClass.GetLogicalName<DuplicateRecord>(); }
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
///<para>Key Property (Uniqueidentifier)</para>
///<para>Logical Name: duplicateid</para>
///</summary>
[AttributeLogicalNameAttribute("duplicateid")]
public Guid DuplicateId
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
///<para>Logical Name: duplicaterecordidtypecode</para>
///</summary>
[AttributeLogicalNameAttribute("duplicaterecordidtypecode")]
public string DuplicateRecordIdTypeCode
{
	get { return this.GetPropertyValue<string>("duplicaterecordidtypecode"); }
}
///<summary>
///<para>Logical Name: baserecordidyominame</para>
///<para>Max Length: 400 characters</para>
///</summary>
[AttributeLogicalNameAttribute("baserecordidyominame")]
public string BaseRecordIdYomiName
{
	get { return this.GetPropertyValue<string>("baserecordidyominame"); }
}
///<summary>
///<para>Logical Name: duplicaterecordidyominame</para>
///<para>Max Length: 400 characters</para>
///</summary>
[AttributeLogicalNameAttribute("duplicaterecordidyominame")]
public string DuplicateRecordIdYomiName
{
	get { return this.GetPropertyValue<string>("duplicaterecordidyominame"); }
}
///<summary>
///<para>Logical Name: owneridtype</para>
///</summary>
[AttributeLogicalNameAttribute("owneridtype")]
public string OwnerIdType
{
	get { return this.GetPropertyValue<string>("owneridtype"); }
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
///<para>Logical Name: baserecordidtypecode</para>
///</summary>
[AttributeLogicalNameAttribute("baserecordidtypecode")]
public string BaseRecordIdTypeCode
{
	get { return this.GetPropertyValue<string>("baserecordidtypecode"); }
}
///<summary>
///<para>Logical Name: duplicaterecordidname</para>
///<para>Max Length: 400 characters</para>
///</summary>
[AttributeLogicalNameAttribute("duplicaterecordidname")]
public string DuplicateRecordIdName
{
	get { return this.GetPropertyValue<string>("duplicaterecordidname"); }
}
///<summary>
///<para>Logical Name: baserecordidname</para>
///<para>Max Length: 400 characters</para>
///</summary>
[AttributeLogicalNameAttribute("baserecordidname")]
public string BaseRecordIdName
{
	get { return this.GetPropertyValue<string>("baserecordidname"); }
}
///<summary>
///<para>Logical Name: duplicateruleid</para>
///</summary>
[AttributeLogicalNameAttribute("duplicateruleid")]
public EntityReference DuplicateRuleId
{
	get { return this.GetPropertyValue<EntityReference>("duplicateruleid"); }
}
///<summary>
///<para>Logical Name: baserecordid</para>
///</summary>
[AttributeLogicalNameAttribute("baserecordid")]
public EntityReference BaseRecordID
{
	get { return this.GetPropertyValue<EntityReference>("baserecordid"); }
}
///<summary>
///<para>Logical Name: duplicaterecordid</para>
///</summary>
[AttributeLogicalNameAttribute("duplicaterecordid")]
public EntityReference DuplicateRecordID
{
	get { return this.GetPropertyValue<EntityReference>("duplicaterecordid"); }
}
///<summary>
///<para>Logical Name: ownerid</para>
///</summary>
[AttributeLogicalNameAttribute("ownerid")]
public EntityReference Owner
{
	get { return this.GetPropertyValue<EntityReference>("ownerid"); }
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
///<para>Logical Name: owninguser</para>
///</summary>
[AttributeLogicalNameAttribute("owninguser")]
public Guid OwningUser
{
	get { return this.GetPropertyValue<Guid>("owninguser"); }
}
///<summary>
///<para>Logical Name: asyncoperationid</para>
///</summary>
[AttributeLogicalNameAttribute("asyncoperationid")]
public EntityReference SystemJob
{
	get { return this.GetPropertyValue<EntityReference>("asyncoperationid"); }
}


        /// <summary>
/// <para><b>UserEntityInstanceData (Object Id)</b></para>
/// <para>Schema Name: userentityinstancedata_duplicaterecord</para>
/// </summary>
public List<UserEntityInstanceData> GetUserEntityInstanceData_ObjectId (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<UserEntityInstanceData>(Service, this.Id, "userentityinstancedata", "objectid", Columns); }
/// <summary>
/// <para><b>UserEntityInstanceData (Object Id)</b></para>
/// <para>Schema Name: userentityinstancedata_duplicaterecord</para>
/// </summary>
public List<UserEntityInstanceData> GetUserEntityInstanceData_ObjectId (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<UserEntityInstanceData>(Service, this.Id, "userentityinstancedata", "objectid", Columns); }


        

        

        

        public static class Properties
{
	/// <summary><para>duplicateid</para>
	/// <para>duplicateid</para></summary>
	public const string DuplicateId = "duplicateid";
	/// <summary><para>duplicaterecordidtypecode</para>
	/// <para>duplicaterecordidtypecode</para></summary>
	public const string DuplicateRecordIdTypeCode = "duplicaterecordidtypecode";
	/// <summary><para>baserecordidyominame</para>
	/// <para>baserecordidyominame</para></summary>
	public const string BaseRecordIdYomiName = "baserecordidyominame";
	/// <summary><para>duplicaterecordidyominame</para>
	/// <para>duplicaterecordidyominame</para></summary>
	public const string DuplicateRecordIdYomiName = "duplicaterecordidyominame";
	/// <summary><para>owneridtype</para>
	/// <para>owneridtype</para></summary>
	public const string OwnerIdType = "owneridtype";
	/// <summary><para>createdon</para>
	/// <para>createdon</para></summary>
	public const string CreatedOn = "createdon";
	/// <summary><para>baserecordidtypecode</para>
	/// <para>baserecordidtypecode</para></summary>
	public const string BaseRecordIdTypeCode = "baserecordidtypecode";
	/// <summary><para>duplicaterecordidname</para>
	/// <para>duplicaterecordidname</para></summary>
	public const string DuplicateRecordIdName = "duplicaterecordidname";
	/// <summary><para>baserecordidname</para>
	/// <para>baserecordidname</para></summary>
	public const string BaseRecordIdName = "baserecordidname";
	/// <summary><para>duplicateruleid</para>
	/// <para>duplicateruleid</para></summary>
	public const string DuplicateRuleId = "duplicateruleid";
	/// <summary><para>Base Record ID</para>
	/// <para>baserecordid</para></summary>
	public const string BaseRecordID = "baserecordid";
	/// <summary><para>Duplicate Record ID</para>
	/// <para>duplicaterecordid</para></summary>
	public const string DuplicateRecordID = "duplicaterecordid";
	/// <summary><para>Owner</para>
	/// <para>ownerid</para></summary>
	public const string Owner = "ownerid";
	/// <summary><para>Owning Business Unit</para>
	/// <para>owningbusinessunit</para></summary>
	public const string OwningBusinessUnit = "owningbusinessunit";
	/// <summary><para>Owning User</para>
	/// <para>owninguser</para></summary>
	public const string OwningUser = "owninguser";
	/// <summary><para>System Job</para>
	/// <para>asyncoperationid</para></summary>
	public const string SystemJob = "asyncoperationid";
}

    }
}
