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
    [EntityLogicalNameAttribute("subscription")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XrmToolkit", "4.0")]
    public partial class Subscription : BaseProxyClass
    {
        public new const string LogicalName = "subscription";
        public const int ObjectTypeCode = 29;
        public const string PrimaryIdAttribute = "subscriptionid";
        public const string PrimaryNameAttribute = "";
        
        static Subscription()
        {
            BaseProxyClass.RegisterProxyType(typeof(Subscription), "subscription");
            _textOptions = new Dictionary<string, eTextOptions>();
            _numberOptions = new Dictionary<string, eNumberOptions>();
            _errorStrings = new Dictionary<string, string>();
            TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
            NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
        }
        public Subscription() : base(new Entity("subscription")) { }
        public Subscription(Entity original) : base(original) { }
        public static string GetLogicalName() { return BaseProxyClass.GetLogicalName<Subscription>(); }
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
///<para>Logical Name: machinename</para>
///<para>Max Length: 200 characters</para>
///</summary>
[AttributeLogicalNameAttribute("machinename")]
public string MachineName
{
	get { return this.GetPropertyValue<string>("machinename"); }
	set { this.SetPropertyValue("machinename", value, 200, "MachineName"); }
}
///<summary>
///<para>Logical Name: reinitialize</para>
///<para>True = Yes</para>
///<para>False = No</para>
///</summary>
[AttributeLogicalNameAttribute("reinitialize")]
public bool? ReInitialize
{
	get { return this.GetPropertyValue<bool?>("reinitialize"); }
	set { this.SetPropertyValue<bool?>("reinitialize", value, "ReInitialize"); }
}
///<summary>
///<para>Logical Name: lastsyncstartedon</para>
///</summary>
[AttributeLogicalNameAttribute("lastsyncstartedon")]
public DateTime? LastSyncStartedOn
{
	get { return this.GetPropertyValue<DateTime?>("lastsyncstartedon"); }
}
///<summary>
///<para>Logical Name: syncentrytablename</para>
///<para>Max Length: 128 characters</para>
///</summary>
[AttributeLogicalNameAttribute("syncentrytablename")]
public string SyncEntryTableName
{
	get { return this.GetPropertyValue<string>("syncentrytablename"); }
}
///<summary>
///<para>Logical Name: completedsyncstartedon</para>
///</summary>
[AttributeLogicalNameAttribute("completedsyncstartedon")]
public DateTime? CompletedSyncStartedOn
{
	get { return this.GetPropertyValue<DateTime?>("completedsyncstartedon"); }
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
///<para>Logical Name: completedsyncversionnumber</para>
///</summary>
[AttributeLogicalNameAttribute("completedsyncversionnumber")]
public int? CompletedSyncVersionNumber
{
	get { return this.GetPropertyValue<int?>("completedsyncversionnumber"); }
}
///<summary>
///<para>Logical Name: systemuserid</para>
///</summary>
[AttributeLogicalNameAttribute("systemuserid")]
public Guid SystemUserId
{
	get { return this.GetPropertyValue<Guid>("systemuserid"); }
}
///<summary>
///<para>Key Property (Uniqueidentifier)</para>
///<para>Logical Name: subscriptionid</para>
///</summary>
[AttributeLogicalNameAttribute("subscriptionid")]
public Guid SubscriptionId
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
///<para>Logical Name: subscriptiontype</para>
///<para>Minimum Value: -2147483648</para>
///<para>Maximum Value: 2147483647</para>
///</summary>
[AttributeLogicalNameAttribute("subscriptiontype")]
public int? SubscriptionType
{
	get { return this.GetPropertyValue<int?>("subscriptiontype"); }
	set { this.SetPropertyValue("subscriptiontype", (int?)value, (int)-2147483648, (int)2147483647, "SubscriptionType"); }
}
///<summary>
///<para>Logical Name: clientversion</para>
///<para>Max Length: 48 characters</para>
///</summary>
[AttributeLogicalNameAttribute("clientversion")]
public string ClientVersion
{
	get { return this.GetPropertyValue<string>("clientversion"); }
}


        /// <summary>
/// <para><b>SubscriptionClients ()</b></para>
/// <para>Schema Name: subscriptionclients_subscription</para>
/// </summary>
public List<SubscriptionClients> GetSubscriptionClients (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<SubscriptionClients>(Service, this.Id, "subscriptionclients", "subscriptionid", Columns); }
/// <summary>
/// <para><b>SubscriptionClients ()</b></para>
/// <para>Schema Name: subscriptionclients_subscription</para>
/// </summary>
public List<SubscriptionClients> GetSubscriptionClients (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<SubscriptionClients>(Service, this.Id, "subscriptionclients", "subscriptionid", Columns); }
/// <summary>
/// <para><b>SubscriptionSynchronizationInformation ()</b></para>
/// <para>Schema Name: subscription_subscriptionsyncinfo</para>
/// </summary>
public List<SubscriptionSynchronizationInformation> GetSubscriptionSynchronizationInformation (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<SubscriptionSynchronizationInformation>(Service, this.Id, "subscriptionsyncinfo", "subscriptionid", Columns); }
/// <summary>
/// <para><b>SubscriptionSynchronizationInformation ()</b></para>
/// <para>Schema Name: subscription_subscriptionsyncinfo</para>
/// </summary>
public List<SubscriptionSynchronizationInformation> GetSubscriptionSynchronizationInformation (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<SubscriptionSynchronizationInformation>(Service, this.Id, "subscriptionsyncinfo", "subscriptionid", Columns); }
/// <summary>
/// <para><b>UserEntityInstanceData (Object Id)</b></para>
/// <para>Schema Name: userentityinstancedata_subscription</para>
/// </summary>
public List<UserEntityInstanceData> GetUserEntityInstanceData_ObjectId (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<UserEntityInstanceData>(Service, this.Id, "userentityinstancedata", "objectid", Columns); }
/// <summary>
/// <para><b>UserEntityInstanceData (Object Id)</b></para>
/// <para>Schema Name: userentityinstancedata_subscription</para>
/// </summary>
public List<UserEntityInstanceData> GetUserEntityInstanceData_ObjectId (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<UserEntityInstanceData>(Service, this.Id, "userentityinstancedata", "objectid", Columns); }


        /// <summary>
/// <para>Related Entity: <b>Task</b></para>
/// <para>N:N Relationship</para>
/// <para>Schema Name: task_subscription_association</para>
/// </summary>
public List<Task> GetTasks (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedManyToManyEntities<Task>(Service, this, "subscription", "subscriptionid", "task", "activityid", "subscriptionmanuallytrackedobject", "subscriptionid", "objectid", Columns); }
public List<Task> GetTasks (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedManyToManyEntities<Task>(Service, this, "subscription", "subscriptionid", "task", "activityid", "subscriptionmanuallytrackedobject", "subscriptionid", "objectid", Columns); }
public void RelateTasks (IOrganizationService Service, params Entity[] Items) { Service.RelateEntities(this, "task_subscription_association", Items); }
public void RelateTasks (IOrganizationService Service, params EntityReference[] Items) { Service.RelateEntities(this, "task_subscription_association", Items); }
public void UnRelateTasks (IOrganizationService Service, params Entity[] Items) { Service.UnRelateEntities(this, "task_subscription_association", Items); }
public void UnRelateTasks (IOrganizationService Service, params EntityReference[] Items) { Service.UnRelateEntities(this, "task_subscription_association", Items); }
/// <summary>
/// <para>Related Entity: <b>Contact</b></para>
/// <para>N:N Relationship</para>
/// <para>Schema Name: contact_subscription_association</para>
/// </summary>
public List<Contact> GetContacts (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedManyToManyEntities<Contact>(Service, this, "subscription", "subscriptionid", "contact", "contactid", "subscriptionmanuallytrackedobject", "subscriptionid", "objectid", Columns); }
public List<Contact> GetContacts (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedManyToManyEntities<Contact>(Service, this, "subscription", "subscriptionid", "contact", "contactid", "subscriptionmanuallytrackedobject", "subscriptionid", "objectid", Columns); }
public void RelateContacts (IOrganizationService Service, params Entity[] Items) { Service.RelateEntities(this, "contact_subscription_association", Items); }
public void RelateContacts (IOrganizationService Service, params EntityReference[] Items) { Service.RelateEntities(this, "contact_subscription_association", Items); }
public void UnRelateContacts (IOrganizationService Service, params Entity[] Items) { Service.UnRelateEntities(this, "contact_subscription_association", Items); }
public void UnRelateContacts (IOrganizationService Service, params EntityReference[] Items) { Service.UnRelateEntities(this, "contact_subscription_association", Items); }


        

        

        public static class Properties
{
	/// <summary><para>machinename</para>
	/// <para>machinename</para></summary>
	public const string MachineName = "machinename";
	/// <summary><para>reinitialize</para>
	/// <para>reinitialize</para></summary>
	public const string ReInitialize = "reinitialize";
	/// <summary><para>lastsyncstartedon</para>
	/// <para>lastsyncstartedon</para></summary>
	public const string LastSyncStartedOn = "lastsyncstartedon";
	/// <summary><para>syncentrytablename</para>
	/// <para>syncentrytablename</para></summary>
	public const string SyncEntryTableName = "syncentrytablename";
	/// <summary><para>completedsyncstartedon</para>
	/// <para>completedsyncstartedon</para></summary>
	public const string CompletedSyncStartedOn = "completedsyncstartedon";
	/// <summary><para>utcconversiontimezonecode</para>
	/// <para>utcconversiontimezonecode</para></summary>
	public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
	/// <summary><para>completedsyncversionnumber</para>
	/// <para>completedsyncversionnumber</para></summary>
	public const string CompletedSyncVersionNumber = "completedsyncversionnumber";
	/// <summary><para>systemuserid</para>
	/// <para>systemuserid</para></summary>
	public const string SystemUserId = "systemuserid";
	/// <summary><para>subscriptionid</para>
	/// <para>subscriptionid</para></summary>
	public const string SubscriptionId = "subscriptionid";
	/// <summary><para>timezoneruleversionnumber</para>
	/// <para>timezoneruleversionnumber</para></summary>
	public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
	/// <summary><para>subscriptiontype</para>
	/// <para>subscriptiontype</para></summary>
	public const string SubscriptionType = "subscriptiontype";
	/// <summary><para>Client Version.</para>
	/// <para>clientversion</para></summary>
	public const string ClientVersion = "clientversion";
}

    }
}
