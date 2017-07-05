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
    [EntityLogicalNameAttribute("userentityinstancedata")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XrmToolkit", "4.0")]
    public partial class UserEntityInstanceData : BaseProxyClass
    {
        public new const string LogicalName = "userentityinstancedata";
        public const int ObjectTypeCode = 2501;
        public const string PrimaryIdAttribute = "userentityinstancedataid";
        public const string PrimaryNameAttribute = "";
        
        static UserEntityInstanceData()
        {
            BaseProxyClass.RegisterProxyType(typeof(UserEntityInstanceData), "userentityinstancedata");
            _textOptions = new Dictionary<string, eTextOptions>();
            _numberOptions = new Dictionary<string, eNumberOptions>();
            _errorStrings = new Dictionary<string, string>();
            TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
            NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
        }
        public UserEntityInstanceData() : base(new Entity("userentityinstancedata")) { }
        public UserEntityInstanceData(Entity original) : base(original) { }
        public static string GetLogicalName() { return BaseProxyClass.GetLogicalName<UserEntityInstanceData>(); }
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
///<para>Logical Name: flagstatus</para>
///<para>Minimum Value: -2147483648</para>
///<para>Maximum Value: 2147483647</para>
///</summary>
[AttributeLogicalNameAttribute("flagstatus")]
public int? FlagStatus
{
	get { return this.GetPropertyValue<int?>("flagstatus"); }
	set { this.SetPropertyValue("flagstatus", (int?)value, (int)-2147483648, (int)2147483647, "FlagStatus"); }
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
///<para>Logical Name: versionnumber</para>
///</summary>
[AttributeLogicalNameAttribute("versionnumber")]
public int? VersionNumber
{
	get { return this.GetPropertyValue<int?>("versionnumber"); }
}
///<summary>
///<para>Key Property (Uniqueidentifier)</para>
///<para>Logical Name: userentityinstancedataid</para>
///</summary>
[AttributeLogicalNameAttribute("userentityinstancedataid")]
public Guid UserEntityInstanceDataId
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
///<para>Logical Name: todoitemflags</para>
///<para>Minimum Value: -2147483648</para>
///<para>Maximum Value: 2147483647</para>
///</summary>
[AttributeLogicalNameAttribute("todoitemflags")]
public int? ToDoItemFlags
{
	get { return this.GetPropertyValue<int?>("todoitemflags"); }
	set { this.SetPropertyValue("todoitemflags", (int?)value, (int)-2147483648, (int)2147483647, "ToDoItemFlags"); }
}
///<summary>
///<para>Logical Name: objecttypecode</para>
///<para>Minimum Value: 0</para>
///<para>Maximum Value: 2147483647</para>
///</summary>
[AttributeLogicalNameAttribute("objecttypecode")]
public int? ObjectTypeCode2
{
	get { return this.GetPropertyValue<int?>("objecttypecode"); }
	set { this.SetPropertyValue("objecttypecode", (int?)value, (int)0, (int)2147483647, "ObjectTypeCode2"); }
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
///<para>Logical Name: owneridtype</para>
///</summary>
[AttributeLogicalNameAttribute("owneridtype")]
public string OwnerIdType
{
	get { return this.GetPropertyValue<string>("owneridtype"); }
	set { this.SetPropertyValue<string>("owneridtype", value, "OwnerIdType"); }
}
///<summary>
///<para>Logical Name: commonend</para>
///</summary>
[AttributeLogicalNameAttribute("commonend")]
public DateTime? CommonEndDate
{
	get { return this.GetPropertyValue<DateTime?>("commonend"); }
	set { this.SetPropertyValue<DateTime?>("commonend", value, "CommonEndDate"); }
}
///<summary>
///<para>Logical Name: commonstart</para>
///</summary>
[AttributeLogicalNameAttribute("commonstart")]
public DateTime? CommonStartDate
{
	get { return this.GetPropertyValue<DateTime?>("commonstart"); }
	set { this.SetPropertyValue<DateTime?>("commonstart", value, "CommonStartDate"); }
}
///<summary>
///<para>Logical Name: duedate</para>
///</summary>
[AttributeLogicalNameAttribute("duedate")]
public DateTime? DueDate
{
	get { return this.GetPropertyValue<DateTime?>("duedate"); }
	set { this.SetPropertyValue<DateTime?>("duedate", value, "DueDate"); }
}
///<summary>
///<para>Logical Name: flagdueby</para>
///</summary>
[AttributeLogicalNameAttribute("flagdueby")]
public DateTime? FlagDueBy
{
	get { return this.GetPropertyValue<DateTime?>("flagdueby"); }
	set { this.SetPropertyValue<DateTime?>("flagdueby", value, "FlagDueBy"); }
}
///<summary>
///<para>Logical Name: flagrequest</para>
///<para>Max Length: 20 characters</para>
///</summary>
[AttributeLogicalNameAttribute("flagrequest")]
public string FlagRequest
{
	get { return this.GetPropertyValue<string>("flagrequest"); }
	set { this.SetPropertyValue("flagrequest", value, 20, "FlagRequest"); }
}
///<summary>
///<para>Logical Name: reminderset</para>
///<para>True = Remind Set</para>
///<para>False = Reminder Not Set</para>
///</summary>
[AttributeLogicalNameAttribute("reminderset")]
public bool? IsReminderSet
{
	get { return this.GetPropertyValue<bool?>("reminderset"); }
	set { this.SetPropertyValue<bool?>("reminderset", value, "IsReminderSet"); }
}
///<summary>
///<para>Logical Name: objectid</para>
///</summary>
[AttributeLogicalNameAttribute("objectid")]
public EntityReference ObjectId
{
	get { return this.GetPropertyValue<EntityReference>("objectid"); }
	set { this.SetPropertyValue<EntityReference>("objectid", value, "ObjectId"); }
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
}
///<summary>
///<para>Logical Name: owningteam</para>
///</summary>
[AttributeLogicalNameAttribute("owningteam")]
public EntityReference OwningTeam
{
	get { return this.GetPropertyValue<EntityReference>("owningteam"); }
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
///<para>Logical Name: personalcategories</para>
///<para>Max Length: 2000 characters</para>
///</summary>
[AttributeLogicalNameAttribute("personalcategories")]
public string PersonalCategories
{
	get { return this.GetPropertyValue<string>("personalcategories"); }
	set { this.SetPropertyValue("personalcategories", value, 2000, "PersonalCategories"); }
}
///<summary>
///<para>Logical Name: remindertime</para>
///</summary>
[AttributeLogicalNameAttribute("remindertime")]
public DateTime? ReminderTime
{
	get { return this.GetPropertyValue<DateTime?>("remindertime"); }
	set { this.SetPropertyValue<DateTime?>("remindertime", value, "ReminderTime"); }
}
///<summary>
///<para>Logical Name: starttime</para>
///</summary>
[AttributeLogicalNameAttribute("starttime")]
public DateTime? StartTime
{
	get { return this.GetPropertyValue<DateTime?>("starttime"); }
	set { this.SetPropertyValue<DateTime?>("starttime", value, "StartTime"); }
}
///<summary>
///<para>Logical Name: todoordinaldate</para>
///</summary>
[AttributeLogicalNameAttribute("todoordinaldate")]
public DateTime? ToDoPrimarySortDate
{
	get { return this.GetPropertyValue<DateTime?>("todoordinaldate"); }
	set { this.SetPropertyValue<DateTime?>("todoordinaldate", value, "ToDoPrimarySortDate"); }
}
///<summary>
///<para>Logical Name: todosubordinal</para>
///<para>Max Length: 20 characters</para>
///</summary>
[AttributeLogicalNameAttribute("todosubordinal")]
public string ToDoSortTieBreaker
{
	get { return this.GetPropertyValue<string>("todosubordinal"); }
	set { this.SetPropertyValue("todosubordinal", value, 20, "ToDoSortTieBreaker"); }
}
///<summary>
///<para>Logical Name: todotitle</para>
///<para>Max Length: 4000 characters</para>
///</summary>
[AttributeLogicalNameAttribute("todotitle")]
public string ToDoTitle
{
	get { return this.GetPropertyValue<string>("todotitle"); }
	set { this.SetPropertyValue("todotitle", value, 4000, "ToDoTitle"); }
}


        

        

        

        

        public static class Properties
{
	/// <summary><para>flagstatus</para>
	/// <para>flagstatus</para></summary>
	public const string FlagStatus = "flagstatus";
	/// <summary><para>owneridname</para>
	/// <para>owneridname</para></summary>
	public const string OwnerIdName = "owneridname";
	/// <summary><para>versionnumber</para>
	/// <para>versionnumber</para></summary>
	public const string VersionNumber = "versionnumber";
	/// <summary><para>userentityinstancedataid</para>
	/// <para>userentityinstancedataid</para></summary>
	public const string UserEntityInstanceDataId = "userentityinstancedataid";
	/// <summary><para>todoitemflags</para>
	/// <para>todoitemflags</para></summary>
	public const string ToDoItemFlags = "todoitemflags";
	/// <summary><para>objecttypecode</para>
	/// <para>objecttypecode</para></summary>
	public const string ObjectTypeCode2 = "objecttypecode";
	/// <summary><para>owneridyominame</para>
	/// <para>owneridyominame</para></summary>
	public const string OwnerIdYomiName = "owneridyominame";
	/// <summary><para>owneridtype</para>
	/// <para>owneridtype</para></summary>
	public const string OwnerIdType = "owneridtype";
	/// <summary><para>Common end date</para>
	/// <para>commonend</para></summary>
	public const string CommonEndDate = "commonend";
	/// <summary><para>Common start date</para>
	/// <para>commonstart</para></summary>
	public const string CommonStartDate = "commonstart";
	/// <summary><para>Due Date</para>
	/// <para>duedate</para></summary>
	public const string DueDate = "duedate";
	/// <summary><para>Flag due by</para>
	/// <para>flagdueby</para></summary>
	public const string FlagDueBy = "flagdueby";
	/// <summary><para>Flag Request</para>
	/// <para>flagrequest</para></summary>
	public const string FlagRequest = "flagrequest";
	/// <summary><para>Is Reminder set</para>
	/// <para>reminderset</para></summary>
	public const string IsReminderSet = "reminderset";
	/// <summary><para>Object Id</para>
	/// <para>objectid</para></summary>
	public const string ObjectId = "objectid";
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
	/// <summary><para>personal categories</para>
	/// <para>personalcategories</para></summary>
	public const string PersonalCategories = "personalcategories";
	/// <summary><para>Reminder time</para>
	/// <para>remindertime</para></summary>
	public const string ReminderTime = "remindertime";
	/// <summary><para>Start Time</para>
	/// <para>starttime</para></summary>
	public const string StartTime = "starttime";
	/// <summary><para>To Do Primary Sort Date</para>
	/// <para>todoordinaldate</para></summary>
	public const string ToDoPrimarySortDate = "todoordinaldate";
	/// <summary><para>To Do Sort Tie Breaker</para>
	/// <para>todosubordinal</para></summary>
	public const string ToDoSortTieBreaker = "todosubordinal";
	/// <summary><para>To Do Title</para>
	/// <para>todotitle</para></summary>
	public const string ToDoTitle = "todotitle";
}

    }
}
