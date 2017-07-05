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
    [EntityLogicalNameAttribute("calendarrule")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XrmToolkit", "4.0")]
    public partial class CalendarRule : BaseProxyClass
    {
        public new const string LogicalName = "calendarrule";
        public const int ObjectTypeCode = 4004;
        public const string PrimaryIdAttribute = "calendarruleid";
        public const string PrimaryNameAttribute = "name";
        
        static CalendarRule()
        {
            BaseProxyClass.RegisterProxyType(typeof(CalendarRule), "calendarrule");
            _textOptions = new Dictionary<string, eTextOptions>();
            _numberOptions = new Dictionary<string, eNumberOptions>();
            _errorStrings = new Dictionary<string, string>();
            TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
            NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
        }
        public CalendarRule() : base(new Entity("calendarrule")) { }
        public CalendarRule(Entity original) : base(original) { }
        public static string GetLogicalName() { return BaseProxyClass.GetLogicalName<CalendarRule>(); }
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
///<para>Logical Name: createdbyyominame</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("createdbyyominame")]
public string CreatedByYomiName
{
	get { return this.GetPropertyValue<string>("createdbyyominame"); }
}
///<summary>
///<para>Logical Name: serviceidname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("serviceidname")]
public string ServiceIdName
{
	get { return this.GetPropertyValue<string>("serviceidname"); }
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
public Guid BusinessUnit
{
	get { return this.GetPropertyValue<Guid>("businessunitid"); }
}
///<summary>
///<para>Logical Name: calendarid</para>
///</summary>
[AttributeLogicalNameAttribute("calendarid")]
public EntityReference Calendar
{
	get { return this.GetPropertyValue<EntityReference>("calendarid"); }
	set { this.SetPropertyValue<EntityReference>("calendarid", value, "Calendar"); }
}
///<summary>
///<para>Key Property (Uniqueidentifier)</para>
///<para>Logical Name: calendarruleid</para>
///</summary>
[AttributeLogicalNameAttribute("calendarruleid")]
public Guid CalendarRuleId
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
///<para>Logical Name: duration</para>
///<para>Minimum Value: 0</para>
///<para>Maximum Value: 2147483647</para>
///</summary>
[AttributeLogicalNameAttribute("duration")]
public int? Duration
{
	get { return this.GetPropertyValue<int?>("duration"); }
	set { this.SetPropertyValue("duration", (int?)value, (int)0, (int)2147483647, "Duration"); }
}
///<summary>
///<para>Logical Name: effectiveintervalend</para>
///</summary>
[AttributeLogicalNameAttribute("effectiveintervalend")]
public DateTime? EffectiveIntervalEnd
{
	get { return this.GetPropertyValue<DateTime?>("effectiveintervalend"); }
	set { this.SetPropertyValue<DateTime?>("effectiveintervalend", value, "EffectiveIntervalEnd"); }
}
///<summary>
///<para>Logical Name: effectiveintervalstart</para>
///</summary>
[AttributeLogicalNameAttribute("effectiveintervalstart")]
public DateTime? EffectiveIntervalStart
{
	get { return this.GetPropertyValue<DateTime?>("effectiveintervalstart"); }
	set { this.SetPropertyValue<DateTime?>("effectiveintervalstart", value, "EffectiveIntervalStart"); }
}
///<summary>
///<para>Logical Name: effort</para>
///<para>Minimum Value: 0</para>
///<para>Maximum Value: 1000000000</para>
///<para>Precision: 2</para>
///</summary>
[AttributeLogicalNameAttribute("effort")]
public double? Effort
{
	get { return this.GetPropertyValue<double?>("effort"); }
	set { this.SetPropertyValue("effort", (double?)value, (double)0, (double)1000000000, "Effort"); }
}
///<summary>
///<para>Logical Name: endtime</para>
///</summary>
[AttributeLogicalNameAttribute("endtime")]
public DateTime? End
{
	get { return this.GetPropertyValue<DateTime?>("endtime"); }
	set { this.SetPropertyValue<DateTime?>("endtime", value, "End"); }
}
///<summary>
///<para>Logical Name: extentcode</para>
///<para>Minimum Value: 0</para>
///<para>Maximum Value: 1000000000</para>
///</summary>
[AttributeLogicalNameAttribute("extentcode")]
public int? ExtentCode
{
	get { return this.GetPropertyValue<int?>("extentcode"); }
	set { this.SetPropertyValue("extentcode", (int?)value, (int)0, (int)1000000000, "ExtentCode"); }
}
///<summary>
///<para>Logical Name: groupdesignator</para>
///<para>Max Length: 36 characters</para>
///</summary>
[AttributeLogicalNameAttribute("groupdesignator")]
public string GroupDesignator
{
	get { return this.GetPropertyValue<string>("groupdesignator"); }
	set { this.SetPropertyValue("groupdesignator", value, 36, "GroupDesignator"); }
}
///<summary>
///<para>Logical Name: innercalendarid</para>
///</summary>
[AttributeLogicalNameAttribute("innercalendarid")]
public EntityReference InnerCalendar
{
	get { return this.GetPropertyValue<EntityReference>("innercalendarid"); }
	set { this.SetPropertyValue<EntityReference>("innercalendarid", value, "InnerCalendar"); }
}
///<summary>
///<para>Logical Name: ismodified</para>
///<para>True = Yes</para>
///<para>False = No</para>
///</summary>
[AttributeLogicalNameAttribute("ismodified")]
public bool? IsModified
{
	get { return this.GetPropertyValue<bool?>("ismodified"); }
	set { this.SetPropertyValue<bool?>("ismodified", value, "IsModified"); }
}
///<summary>
///<para>Logical Name: isselected</para>
///<para>True = Yes</para>
///<para>False = No</para>
///</summary>
[AttributeLogicalNameAttribute("isselected")]
public bool? IsSelected
{
	get { return this.GetPropertyValue<bool?>("isselected"); }
	set { this.SetPropertyValue<bool?>("isselected", value, "IsSelected"); }
}
///<summary>
///<para>Logical Name: issimple</para>
///<para>True = Yes</para>
///<para>False = No</para>
///</summary>
[AttributeLogicalNameAttribute("issimple")]
public bool? IsSimple
{
	get { return this.GetPropertyValue<bool?>("issimple"); }
	set { this.SetPropertyValue<bool?>("issimple", value, "IsSimple"); }
}
///<summary>
///<para>Logical Name: isvaried</para>
///<para>True = Yes</para>
///<para>False = No</para>
///</summary>
[AttributeLogicalNameAttribute("isvaried")]
public bool? IsVaried
{
	get { return this.GetPropertyValue<bool?>("isvaried"); }
	set { this.SetPropertyValue<bool?>("isvaried", value, "IsVaried"); }
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
///<para>Logical Name: offset</para>
///<para>Minimum Value: 0</para>
///<para>Maximum Value: 1000000000</para>
///</summary>
[AttributeLogicalNameAttribute("offset")]
public int? Offset
{
	get { return this.GetPropertyValue<int?>("offset"); }
	set { this.SetPropertyValue("offset", (int?)value, (int)0, (int)1000000000, "Offset"); }
}
///<summary>
///<para>Logical Name: organizationid</para>
///</summary>
[AttributeLogicalNameAttribute("organizationid")]
public Guid Organization
{
	get { return this.GetPropertyValue<Guid>("organizationid"); }
}
///<summary>
///<para>Logical Name: rank</para>
///<para>Minimum Value: 0</para>
///<para>Maximum Value: 1000000000</para>
///</summary>
[AttributeLogicalNameAttribute("rank")]
public int? Rank
{
	get { return this.GetPropertyValue<int?>("rank"); }
	set { this.SetPropertyValue("rank", (int?)value, (int)0, (int)1000000000, "Rank"); }
}
///<summary>
///<para>Logical Name: pattern</para>
///<para>Max Length: 256 characters</para>
///</summary>
[AttributeLogicalNameAttribute("pattern")]
public string RecurrencePattern
{
	get { return this.GetPropertyValue<string>("pattern"); }
	set { this.SetPropertyValue("pattern", value, 256, "RecurrencePattern"); }
}
///<summary>
///<para>Logical Name: serviceid</para>
///</summary>
[AttributeLogicalNameAttribute("serviceid")]
public EntityReference Service
{
	get { return this.GetPropertyValue<EntityReference>("serviceid"); }
	set { this.SetPropertyValue<EntityReference>("serviceid", value, "Service"); }
}
///<summary>
///<para>Logical Name: starttime</para>
///</summary>
[AttributeLogicalNameAttribute("starttime")]
public DateTime? Start
{
	get { return this.GetPropertyValue<DateTime?>("starttime"); }
	set { this.SetPropertyValue<DateTime?>("starttime", value, "Start"); }
}
///<summary>
///<para>Logical Name: subcode</para>
///<para>Minimum Value: 0</para>
///<para>Maximum Value: 1000000000</para>
///</summary>
[AttributeLogicalNameAttribute("subcode")]
public int? SubCode
{
	get { return this.GetPropertyValue<int?>("subcode"); }
	set { this.SetPropertyValue("subcode", (int?)value, (int)0, (int)1000000000, "SubCode"); }
}
///<summary>
///<para>Logical Name: timezonecode</para>
///<para>Minimum Value: -2147483648</para>
///<para>Maximum Value: 2147483647</para>
///</summary>
[AttributeLogicalNameAttribute("timezonecode")]
public int? TimeZone
{
	get { return this.GetPropertyValue<int?>("timezonecode"); }
	set { this.SetPropertyValue("timezonecode", (int?)value, (int)-2147483648, (int)2147483647, "TimeZone"); }
}
///<summary>
///<para>Logical Name: timecode</para>
///<para>Minimum Value: -2147483648</para>
///<para>Maximum Value: 2147483647</para>
///</summary>
[AttributeLogicalNameAttribute("timecode")]
public int? Type
{
	get { return this.GetPropertyValue<int?>("timecode"); }
	set { this.SetPropertyValue("timecode", (int?)value, (int)-2147483648, (int)2147483647, "Type"); }
}


        /// <summary>
/// <para><b>UserEntityInstanceData (Object Id)</b></para>
/// <para>Schema Name: userentityinstancedata_calendarrule</para>
/// </summary>
public List<UserEntityInstanceData> GetUserEntityInstanceData_ObjectId (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<UserEntityInstanceData>(Service, this.Id, "userentityinstancedata", "objectid", Columns); }
/// <summary>
/// <para><b>UserEntityInstanceData (Object Id)</b></para>
/// <para>Schema Name: userentityinstancedata_calendarrule</para>
/// </summary>
public List<UserEntityInstanceData> GetUserEntityInstanceData_ObjectId (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<UserEntityInstanceData>(Service, this.Id, "userentityinstancedata", "objectid", Columns); }


        

        

        

        public static class Properties
{
	/// <summary><para>createdonbehalfbyyominame</para>
	/// <para>createdonbehalfbyyominame</para></summary>
	public const string CreatedOnBehalfByYomiName = "createdonbehalfbyyominame";
	/// <summary><para>createdbyyominame</para>
	/// <para>createdbyyominame</para></summary>
	public const string CreatedByYomiName = "createdbyyominame";
	/// <summary><para>serviceidname</para>
	/// <para>serviceidname</para></summary>
	public const string ServiceIdName = "serviceidname";
	/// <summary><para>modifiedbyname</para>
	/// <para>modifiedbyname</para></summary>
	public const string ModifiedByName = "modifiedbyname";
	/// <summary><para>versionnumber</para>
	/// <para>versionnumber</para></summary>
	public const string VersionNumber = "versionnumber";
	/// <summary><para>modifiedbyyominame</para>
	/// <para>modifiedbyyominame</para></summary>
	public const string ModifiedByYomiName = "modifiedbyyominame";
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
	/// <summary><para>Calendar</para>
	/// <para>calendarid</para></summary>
	public const string Calendar = "calendarid";
	/// <summary><para>Calendar Rule</para>
	/// <para>calendarruleid</para></summary>
	public const string CalendarRuleId = "calendarruleid";
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
	/// <summary><para>Duration</para>
	/// <para>duration</para></summary>
	public const string Duration = "duration";
	/// <summary><para>Effective Interval End</para>
	/// <para>effectiveintervalend</para></summary>
	public const string EffectiveIntervalEnd = "effectiveintervalend";
	/// <summary><para>Effective Interval Start</para>
	/// <para>effectiveintervalstart</para></summary>
	public const string EffectiveIntervalStart = "effectiveintervalstart";
	/// <summary><para>Effort</para>
	/// <para>effort</para></summary>
	public const string Effort = "effort";
	/// <summary><para>End</para>
	/// <para>endtime</para></summary>
	public const string End = "endtime";
	/// <summary><para>Extent Code</para>
	/// <para>extentcode</para></summary>
	public const string ExtentCode = "extentcode";
	/// <summary><para>Group Designator</para>
	/// <para>groupdesignator</para></summary>
	public const string GroupDesignator = "groupdesignator";
	/// <summary><para>Inner Calendar</para>
	/// <para>innercalendarid</para></summary>
	public const string InnerCalendar = "innercalendarid";
	/// <summary><para>Is Modified</para>
	/// <para>ismodified</para></summary>
	public const string IsModified = "ismodified";
	/// <summary><para>Is Selected</para>
	/// <para>isselected</para></summary>
	public const string IsSelected = "isselected";
	/// <summary><para>Is Simple</para>
	/// <para>issimple</para></summary>
	public const string IsSimple = "issimple";
	/// <summary><para>Is Varied</para>
	/// <para>isvaried</para></summary>
	public const string IsVaried = "isvaried";
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
	/// <summary><para>Offset</para>
	/// <para>offset</para></summary>
	public const string Offset = "offset";
	/// <summary><para>Organization </para>
	/// <para>organizationid</para></summary>
	public const string Organization = "organizationid";
	/// <summary><para>Rank</para>
	/// <para>rank</para></summary>
	public const string Rank = "rank";
	/// <summary><para>Recurrence Pattern</para>
	/// <para>pattern</para></summary>
	public const string RecurrencePattern = "pattern";
	/// <summary><para>Service</para>
	/// <para>serviceid</para></summary>
	public const string Service = "serviceid";
	/// <summary><para>Start</para>
	/// <para>starttime</para></summary>
	public const string Start = "starttime";
	/// <summary><para>Sub Code</para>
	/// <para>subcode</para></summary>
	public const string SubCode = "subcode";
	/// <summary><para>Time Zone</para>
	/// <para>timezonecode</para></summary>
	public const string TimeZone = "timezonecode";
	/// <summary><para>Type</para>
	/// <para>timecode</para></summary>
	public const string Type = "timecode";
}

    }
}
