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
    [EntityLogicalNameAttribute("subscriptionsyncinfo")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XrmToolkit", "4.0")]
    public partial class SubscriptionSynchronizationInformation : BaseProxyClass
    {
        public new const string LogicalName = "subscriptionsyncinfo";
        public const int ObjectTypeCode = 33;
        public const string PrimaryIdAttribute = "subscriptionsyncinfoid";
        public const string PrimaryNameAttribute = "";
        
        static SubscriptionSynchronizationInformation()
        {
            BaseProxyClass.RegisterProxyType(typeof(SubscriptionSynchronizationInformation), "subscriptionsyncinfo");
            _textOptions = new Dictionary<string, eTextOptions>();
            _numberOptions = new Dictionary<string, eNumberOptions>();
            _errorStrings = new Dictionary<string, string>();
            TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
            NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
        }
        public SubscriptionSynchronizationInformation() : base(new Entity("subscriptionsyncinfo")) { }
        public SubscriptionSynchronizationInformation(Entity original) : base(original) { }
        public static string GetLogicalName() { return BaseProxyClass.GetLogicalName<SubscriptionSynchronizationInformation>(); }
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
///<para>Logical Name: syncresult</para>
///<para>True = Yes</para>
///<para>False = No</para>
///</summary>
[AttributeLogicalNameAttribute("syncresult")]
public bool? SyncResult
{
	get { return this.GetPropertyValue<bool?>("syncresult"); }
	set { this.SetPropertyValue<bool?>("syncresult", value, "SyncResult"); }
}
///<summary>
///<para>Logical Name: endtime</para>
///</summary>
[AttributeLogicalNameAttribute("endtime")]
public DateTime? EndTime
{
	get { return this.GetPropertyValue<DateTime?>("endtime"); }
}
///<summary>
///<para>Logical Name: subscriptionsyncinfoid</para>
///<para>Minimum Value: -2147483648</para>
///<para>Maximum Value: 2147483647</para>
///</summary>
[AttributeLogicalNameAttribute("subscriptionsyncinfoid")]
public int? SubscriptionSyncInfoId
{
	get { return this.GetPropertyValue<int?>("subscriptionsyncinfoid"); }
}
///<summary>
///<para>Logical Name: insertobjectcount</para>
///<para>Minimum Value: 0</para>
///<para>Maximum Value: 2147483647</para>
///</summary>
[AttributeLogicalNameAttribute("insertobjectcount")]
public int? InsertObjectCount
{
	get { return this.GetPropertyValue<int?>("insertobjectcount"); }
	set { this.SetPropertyValue("insertobjectcount", (int?)value, (int)0, (int)2147483647, "InsertObjectCount"); }
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
///<para>Logical Name: datasize</para>
///<para>Minimum Value: 0</para>
///<para>Maximum Value: 2147483647</para>
///</summary>
[AttributeLogicalNameAttribute("datasize")]
public int? DataSize
{
	get { return this.GetPropertyValue<int?>("datasize"); }
	set { this.SetPropertyValue("datasize", (int?)value, (int)0, (int)2147483647, "DataSize"); }
}
///<summary>
///<para>Logical Name: clientversion</para>
///<para>Max Length: 20 characters</para>
///</summary>
[AttributeLogicalNameAttribute("clientversion")]
public string ClientVersion
{
	get { return this.GetPropertyValue<string>("clientversion"); }
	set { this.SetPropertyValue("clientversion", value, 20, "ClientVersion"); }
}
///<summary>
///<para>Logical Name: starttime</para>
///</summary>
[AttributeLogicalNameAttribute("starttime")]
public DateTime? StartTime
{
	get { return this.GetPropertyValue<DateTime?>("starttime"); }
}
///<summary>
///<para>Logical Name: subscriptionid</para>
///</summary>
[AttributeLogicalNameAttribute("subscriptionid")]
public EntityReference SubscriptionId
{
	get { return this.GetPropertyValue<EntityReference>("subscriptionid"); }
	set { this.SetPropertyValue<EntityReference>("subscriptionid", value, "SubscriptionId"); }
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
///<para>Logical Name: deleteobjectcount</para>
///<para>Minimum Value: 0</para>
///<para>Maximum Value: 2147483647</para>
///</summary>
[AttributeLogicalNameAttribute("deleteobjectcount")]
public int? DeleteObjectCount
{
	get { return this.GetPropertyValue<int?>("deleteobjectcount"); }
	set { this.SetPropertyValue("deleteobjectcount", (int?)value, (int)0, (int)2147483647, "DeleteObjectCount"); }
}


        /// <summary>
/// <para><b>UserEntityInstanceData (Object Id)</b></para>
/// <para>Schema Name: userentityinstancedata_subscriptionsyncinfo</para>
/// </summary>
public List<UserEntityInstanceData> GetUserEntityInstanceData_ObjectId (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<UserEntityInstanceData>(Service, this.Id, "userentityinstancedata", "objectid", Columns); }
/// <summary>
/// <para><b>UserEntityInstanceData (Object Id)</b></para>
/// <para>Schema Name: userentityinstancedata_subscriptionsyncinfo</para>
/// </summary>
public List<UserEntityInstanceData> GetUserEntityInstanceData_ObjectId (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<UserEntityInstanceData>(Service, this.Id, "userentityinstancedata", "objectid", Columns); }


        

        

        

        public static class Properties
{
	/// <summary><para>syncresult</para>
	/// <para>syncresult</para></summary>
	public const string SyncResult = "syncresult";
	/// <summary><para>endtime</para>
	/// <para>endtime</para></summary>
	public const string EndTime = "endtime";
	/// <summary><para>subscriptionsyncinfoid</para>
	/// <para>subscriptionsyncinfoid</para></summary>
	public const string SubscriptionSyncInfoId = "subscriptionsyncinfoid";
	/// <summary><para>insertobjectcount</para>
	/// <para>insertobjectcount</para></summary>
	public const string InsertObjectCount = "insertobjectcount";
	/// <summary><para>utcconversiontimezonecode</para>
	/// <para>utcconversiontimezonecode</para></summary>
	public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
	/// <summary><para>datasize</para>
	/// <para>datasize</para></summary>
	public const string DataSize = "datasize";
	/// <summary><para>clientversion</para>
	/// <para>clientversion</para></summary>
	public const string ClientVersion = "clientversion";
	/// <summary><para>starttime</para>
	/// <para>starttime</para></summary>
	public const string StartTime = "starttime";
	/// <summary><para>subscriptionid</para>
	/// <para>subscriptionid</para></summary>
	public const string SubscriptionId = "subscriptionid";
	/// <summary><para>timezoneruleversionnumber</para>
	/// <para>timezoneruleversionnumber</para></summary>
	public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
	/// <summary><para>deleteobjectcount</para>
	/// <para>deleteobjectcount</para></summary>
	public const string DeleteObjectCount = "deleteobjectcount";
}

    }
}
