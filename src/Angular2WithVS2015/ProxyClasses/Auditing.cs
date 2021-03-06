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
    [EntityLogicalNameAttribute("audit")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XrmToolkit", "4.0")]
    public partial class Auditing : BaseProxyClass
    {
        public new const string LogicalName = "audit";
        public const int ObjectTypeCode = 4567;
        public const string PrimaryIdAttribute = "auditid";
        public const string PrimaryNameAttribute = "";
        
        static Auditing()
        {
            BaseProxyClass.RegisterProxyType(typeof(Auditing), "audit");
            _textOptions = new Dictionary<string, eTextOptions>();
            _numberOptions = new Dictionary<string, eNumberOptions>();
            _errorStrings = new Dictionary<string, string>();
            TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
            NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
        }
        public Auditing() : base(new Entity("audit")) { }
        public Auditing(Entity original) : base(original) { }
        public static string GetLogicalName() { return BaseProxyClass.GetLogicalName<Auditing>(); }
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
///<para>Logical Name: useridname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("useridname")]
public string UserIdName
{
	get { return this.GetPropertyValue<string>("useridname"); }
}
///<summary>
///<para>Logical Name: callinguseridname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("callinguseridname")]
public string CallingUserIdName
{
	get { return this.GetPropertyValue<string>("callinguseridname"); }
}
///<summary>
///<para>Logical Name: regardingobjectidname</para>
///<para>Max Length: 400 characters</para>
///</summary>
[AttributeLogicalNameAttribute("regardingobjectidname")]
public string RegardingObjectIdName
{
	get { return this.GetPropertyValue<string>("regardingobjectidname"); }
	set { this.SetPropertyValue("regardingobjectidname", value, 400, "RegardingObjectIdName"); }
}
///<summary>
///<para>Logical Name: objectidname</para>
///<para>Max Length: 160 characters</para>
///</summary>
[AttributeLogicalNameAttribute("objectidname")]
public string ObjectIdName
{
	get { return this.GetPropertyValue<string>("objectidname"); }
}
///<summary>
///<para>Logical Name: callinguserid</para>
///</summary>
[AttributeLogicalNameAttribute("callinguserid")]
public EntityReference CallingUser
{
	get { return this.GetPropertyValue<EntityReference>("callinguserid"); }
}
///<summary>
///<para>Logical Name: changedata</para>
///<para>Max Length: 2000 characters</para>
///</summary>
[AttributeLogicalNameAttribute("changedata")]
public string ChangeData
{
	get { return this.GetPropertyValue<string>("changedata"); }
}
///<summary>
///<para>Logical Name: userid</para>
///</summary>
[AttributeLogicalNameAttribute("userid")]
public EntityReference ChangedBy
{
	get { return this.GetPropertyValue<EntityReference>("userid"); }
}
///<summary>
///<para>Logical Name: createdon</para>
///</summary>
[AttributeLogicalNameAttribute("createdon")]
public DateTime? ChangedDate
{
	get { return this.GetPropertyValue<DateTime?>("createdon"); }
}
///<summary>
///<para>Logical Name: attributemask</para>
///<para>Max Length: 2000 characters</para>
///</summary>
[AttributeLogicalNameAttribute("attributemask")]
public string ChangedField
{
	get { return this.GetPropertyValue<string>("attributemask"); }
}
///<summary>
///<para>Logical Name: objecttypecode</para>
///</summary>
[AttributeLogicalNameAttribute("objecttypecode")]
public string Entity
{
	get { return this.GetPropertyValue<string>("objecttypecode"); }
}
/// <summary>
///Logical Name: action
/// </summary>
[AttributeLogicalNameAttribute("action")]
public eAction? @Event
{
	get
	{
		if (Event_OptionSetValue != null) { return (eAction)Event_OptionSetValue.Value; }
		return null;
	}
}
///<summary>
///<para>Logical Name: action</para>
///</summary>
[AttributeLogicalNameAttribute("action")]
public OptionSetValue Event_OptionSetValue
{
	get { return this.GetPropertyValue<OptionSetValue>("action"); }
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="Service">CRM Organization Service</param>
/// <returns></returns>
public string Event_Text(IOrganizationService Service)
{
	return this.Event_OptionSetValue.GetOptionSetText(Service, this, "action");
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="AttributeMetadata">The attribute metadata previously retrieved using the 'GetAttributeMetadata' extension method on the IOrganizationService object.</param>
/// <returns></returns>
public string Event_Text(EnumAttributeMetadata AttributeMetadata)
{
	return AttributeMetadata.GetOptionSetText(this.Event_OptionSetValue.Value);
}
/// <summary>
///Logical Name: operation
/// </summary>
[AttributeLogicalNameAttribute("operation")]
public eOperation? Operation
{
	get
	{
		if (Operation_OptionSetValue != null) { return (eOperation)Operation_OptionSetValue.Value; }
		return null;
	}
}
///<summary>
///<para>Logical Name: operation</para>
///</summary>
[AttributeLogicalNameAttribute("operation")]
public OptionSetValue Operation_OptionSetValue
{
	get { return this.GetPropertyValue<OptionSetValue>("operation"); }
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="Service">CRM Organization Service</param>
/// <returns></returns>
public string Operation_Text(IOrganizationService Service)
{
	return this.Operation_OptionSetValue.GetOptionSetText(Service, this, "operation");
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="AttributeMetadata">The attribute metadata previously retrieved using the 'GetAttributeMetadata' extension method on the IOrganizationService object.</param>
/// <returns></returns>
public string Operation_Text(EnumAttributeMetadata AttributeMetadata)
{
	return AttributeMetadata.GetOptionSetText(this.Operation_OptionSetValue.Value);
}
///<summary>
///<para>Logical Name: objectid</para>
///</summary>
[AttributeLogicalNameAttribute("objectid")]
public EntityReference Record
{
	get { return this.GetPropertyValue<EntityReference>("objectid"); }
}
///<summary>
///<para>Key Property (Uniqueidentifier)</para>
///<para>Logical Name: auditid</para>
///</summary>
[AttributeLogicalNameAttribute("auditid")]
public Guid RecordId
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
///<para>Logical Name: regardingobjectid</para>
///</summary>
[AttributeLogicalNameAttribute("regardingobjectid")]
public EntityReference Regarding
{
	get { return this.GetPropertyValue<EntityReference>("regardingobjectid"); }
	set { this.SetPropertyValue<EntityReference>("regardingobjectid", value, "Regarding"); }
}
///<summary>
///<para>Logical Name: transactionid</para>
///</summary>
[AttributeLogicalNameAttribute("transactionid")]
public Guid TransactionId
{
	get { return this.GetPropertyValue<Guid>("transactionid"); }
}
///<summary>
///<para>Logical Name: useradditionalinfo</para>
///<para>Max Length: 350 characters</para>
///</summary>
[AttributeLogicalNameAttribute("useradditionalinfo")]
public string UserInfo
{
	get { return this.GetPropertyValue<string>("useradditionalinfo"); }
	set { this.SetPropertyValue("useradditionalinfo", value, 350, "UserInfo"); }
}


        /// <summary>
/// <para><b>UserEntityInstanceData (Object Id)</b></para>
/// <para>Schema Name: userentityinstancedata_audit</para>
/// </summary>
public List<UserEntityInstanceData> GetUserEntityInstanceData_ObjectId (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<UserEntityInstanceData>(Service, this.Id, "userentityinstancedata", "objectid", Columns); }
/// <summary>
/// <para><b>UserEntityInstanceData (Object Id)</b></para>
/// <para>Schema Name: userentityinstancedata_audit</para>
/// </summary>
public List<UserEntityInstanceData> GetUserEntityInstanceData_ObjectId (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<UserEntityInstanceData>(Service, this.Id, "userentityinstancedata", "objectid", Columns); }


        

        

        public enum eAction
{
	///<summary><para>Unknown</para>
	///<para>Value = 0</para></summary>
	[Description("Unknown")]
	Unknown = 0, 
	///<summary><para>Create</para>
	///<para>Value = 1</para></summary>
	[Description("Create")]
	Create = 1, 
	///<summary><para>Update</para>
	///<para>Value = 2</para></summary>
	[Description("Update")]
	Update = 2, 
	///<summary><para>Delete</para>
	///<para>Value = 3</para></summary>
	[Description("Delete")]
	Delete = 3, 
	///<summary><para>Activate</para>
	///<para>Value = 4</para></summary>
	[Description("Activate")]
	Activate = 4, 
	///<summary><para>Deactivate</para>
	///<para>Value = 5</para></summary>
	[Description("Deactivate")]
	Deactivate = 5, 
	///<summary><para>Cascade</para>
	///<para>Value = 11</para></summary>
	[Description("Cascade")]
	Cascade = 11, 
	///<summary><para>Merge</para>
	///<para>Value = 12</para></summary>
	[Description("Merge")]
	Merge = 12, 
	///<summary><para>Assign</para>
	///<para>Value = 13</para></summary>
	[Description("Assign")]
	Assign = 13, 
	///<summary><para>Share</para>
	///<para>Value = 14</para></summary>
	[Description("Share")]
	Share = 14, 
	///<summary><para>Retrieve</para>
	///<para>Value = 15</para></summary>
	[Description("Retrieve")]
	Retrieve = 15, 
	///<summary><para>Close</para>
	///<para>Value = 16</para></summary>
	[Description("Close")]
	Close = 16, 
	///<summary><para>Cancel</para>
	///<para>Value = 17</para></summary>
	[Description("Cancel")]
	Cancel = 17, 
	///<summary><para>Complete</para>
	///<para>Value = 18</para></summary>
	[Description("Complete")]
	Complete = 18, 
	///<summary><para>Resolve</para>
	///<para>Value = 20</para></summary>
	[Description("Resolve")]
	Resolve = 20, 
	///<summary><para>Reopen</para>
	///<para>Value = 21</para></summary>
	[Description("Reopen")]
	Reopen = 21, 
	///<summary><para>Fulfill</para>
	///<para>Value = 22</para></summary>
	[Description("Fulfill")]
	Fulfill = 22, 
	///<summary><para>Paid</para>
	///<para>Value = 23</para></summary>
	[Description("Paid")]
	Paid = 23, 
	///<summary><para>Qualify</para>
	///<para>Value = 24</para></summary>
	[Description("Qualify")]
	Qualify = 24, 
	///<summary><para>Disqualify</para>
	///<para>Value = 25</para></summary>
	[Description("Disqualify")]
	Disqualify = 25, 
	///<summary><para>Submit</para>
	///<para>Value = 26</para></summary>
	[Description("Submit")]
	Submit = 26, 
	///<summary><para>Reject</para>
	///<para>Value = 27</para></summary>
	[Description("Reject")]
	Reject = 27, 
	///<summary><para>Approve</para>
	///<para>Value = 28</para></summary>
	[Description("Approve")]
	Approve = 28, 
	///<summary><para>Invoice</para>
	///<para>Value = 29</para></summary>
	[Description("Invoice")]
	Invoice = 29, 
	///<summary><para>Hold</para>
	///<para>Value = 30</para></summary>
	[Description("Hold")]
	Hold = 30, 
	///<summary><para>Add Member</para>
	///<para>Value = 31</para></summary>
	[Description("Add Member")]
	AddMember = 31, 
	///<summary><para>Remove Member</para>
	///<para>Value = 32</para></summary>
	[Description("Remove Member")]
	RemoveMember = 32, 
	///<summary><para>Associate Entities</para>
	///<para>Value = 33</para></summary>
	[Description("Associate Entities")]
	AssociateEntities = 33, 
	///<summary><para>Disassociate Entities</para>
	///<para>Value = 34</para></summary>
	[Description("Disassociate Entities")]
	DisassociateEntities = 34, 
	///<summary><para>Add Members</para>
	///<para>Value = 35</para></summary>
	[Description("Add Members")]
	AddMembers = 35, 
	///<summary><para>Remove Members</para>
	///<para>Value = 36</para></summary>
	[Description("Remove Members")]
	RemoveMembers = 36, 
	///<summary><para>Add Item</para>
	///<para>Value = 37</para></summary>
	[Description("Add Item")]
	AddItem = 37, 
	///<summary><para>Remove Item</para>
	///<para>Value = 38</para></summary>
	[Description("Remove Item")]
	RemoveItem = 38, 
	///<summary><para>Add Substitute</para>
	///<para>Value = 39</para></summary>
	[Description("Add Substitute")]
	AddSubstitute = 39, 
	///<summary><para>Remove Substitute</para>
	///<para>Value = 40</para></summary>
	[Description("Remove Substitute")]
	RemoveSubstitute = 40, 
	///<summary><para>Set State</para>
	///<para>Value = 41</para></summary>
	[Description("Set State")]
	SetState = 41, 
	///<summary><para>Renew</para>
	///<para>Value = 42</para></summary>
	[Description("Renew")]
	Renew = 42, 
	///<summary><para>Revise</para>
	///<para>Value = 43</para></summary>
	[Description("Revise")]
	Revise = 43, 
	///<summary><para>Win</para>
	///<para>Value = 44</para></summary>
	[Description("Win")]
	Win = 44, 
	///<summary><para>Lose</para>
	///<para>Value = 45</para></summary>
	[Description("Lose")]
	Lose = 45, 
	///<summary><para>Internal Processing</para>
	///<para>Value = 46</para></summary>
	[Description("Internal Processing")]
	InternalProcessing = 46, 
	///<summary><para>Reschedule</para>
	///<para>Value = 47</para></summary>
	[Description("Reschedule")]
	Reschedule = 47, 
	///<summary><para>Modify Share</para>
	///<para>Value = 48</para></summary>
	[Description("Modify Share")]
	ModifyShare = 48, 
	///<summary><para>Unshare</para>
	///<para>Value = 49</para></summary>
	[Description("Unshare")]
	Unshare = 49, 
	///<summary><para>Book</para>
	///<para>Value = 50</para></summary>
	[Description("Book")]
	Book = 50, 
	///<summary><para>Generate Quote From Opportunity</para>
	///<para>Value = 51</para></summary>
	[Description("Generate Quote From Opportunity")]
	GenerateQuoteFromOpportunity = 51, 
	///<summary><para>Add To Queue</para>
	///<para>Value = 52</para></summary>
	[Description("Add To Queue")]
	AddToQueue = 52, 
	///<summary><para>Assign Role To Team</para>
	///<para>Value = 53</para></summary>
	[Description("Assign Role To Team")]
	AssignRoleToTeam = 53, 
	///<summary><para>Remove Role From Team</para>
	///<para>Value = 54</para></summary>
	[Description("Remove Role From Team")]
	RemoveRoleFromTeam = 54, 
	///<summary><para>Assign Role To User</para>
	///<para>Value = 55</para></summary>
	[Description("Assign Role To User")]
	AssignRoleToUser = 55, 
	///<summary><para>Remove Role From User</para>
	///<para>Value = 56</para></summary>
	[Description("Remove Role From User")]
	RemoveRoleFromUser = 56, 
	///<summary><para>Add Privileges to Role</para>
	///<para>Value = 57</para></summary>
	[Description("Add Privileges to Role")]
	AddPrivilegesToRole = 57, 
	///<summary><para>Remove Privileges From Role</para>
	///<para>Value = 58</para></summary>
	[Description("Remove Privileges From Role")]
	RemovePrivilegesFromRole = 58, 
	///<summary><para>Replace Privileges In Role</para>
	///<para>Value = 59</para></summary>
	[Description("Replace Privileges In Role")]
	ReplacePrivilegesInRole = 59, 
	///<summary><para>Import Mappings</para>
	///<para>Value = 60</para></summary>
	[Description("Import Mappings")]
	ImportMappings = 60, 
	///<summary><para>Clone</para>
	///<para>Value = 61</para></summary>
	[Description("Clone")]
	Clone = 61, 
	///<summary><para>Send Direct Email</para>
	///<para>Value = 62</para></summary>
	[Description("Send Direct Email")]
	SendDirectEmail = 62, 
	///<summary><para>Enabled for organization</para>
	///<para>Value = 63</para></summary>
	[Description("Enabled for organization")]
	EnabledForOrganization = 63, 
	///<summary><para>User Access via Web</para>
	///<para>Value = 64</para></summary>
	[Description("User Access via Web")]
	UserAccessViaWeb = 64, 
	///<summary><para>User Access via Web Services</para>
	///<para>Value = 65</para></summary>
	[Description("User Access via Web Services")]
	UserAccessViaWebServices = 65, 
	///<summary><para>Delete Entity</para>
	///<para>Value = 100</para></summary>
	[Description("Delete Entity")]
	DeleteEntity = 100, 
	///<summary><para>Delete Attribute</para>
	///<para>Value = 101</para></summary>
	[Description("Delete Attribute")]
	DeleteAttribute = 101, 
	///<summary><para>Audit Change at Entity Level</para>
	///<para>Value = 102</para></summary>
	[Description("Audit Change at Entity Level")]
	AuditChangeAtEntityLevel = 102, 
	///<summary><para>Audit Change at Attribute Level</para>
	///<para>Value = 103</para></summary>
	[Description("Audit Change at Attribute Level")]
	AuditChangeAtAttributeLevel = 103, 
	///<summary><para>Audit Change at Org Level</para>
	///<para>Value = 104</para></summary>
	[Description("Audit Change at Org Level")]
	AuditChangeAtOrgLevel = 104, 
	///<summary><para>Entity Audit Started</para>
	///<para>Value = 105</para></summary>
	[Description("Entity Audit Started")]
	EntityAuditStarted = 105, 
	///<summary><para>Attribute Audit Started</para>
	///<para>Value = 106</para></summary>
	[Description("Attribute Audit Started")]
	AttributeAuditStarted = 106, 
	///<summary><para>Audit Enabled</para>
	///<para>Value = 107</para></summary>
	[Description("Audit Enabled")]
	AuditEnabled = 107, 
	///<summary><para>Entity Audit Stopped</para>
	///<para>Value = 108</para></summary>
	[Description("Entity Audit Stopped")]
	EntityAuditStopped = 108, 
	///<summary><para>Attribute Audit Stopped</para>
	///<para>Value = 109</para></summary>
	[Description("Attribute Audit Stopped")]
	AttributeAuditStopped = 109, 
	///<summary><para>Audit Disabled</para>
	///<para>Value = 110</para></summary>
	[Description("Audit Disabled")]
	AuditDisabled = 110, 
	///<summary><para>Audit Log Deletion</para>
	///<para>Value = 111</para></summary>
	[Description("Audit Log Deletion")]
	AuditLogDeletion = 111, 
	///<summary><para>User Access Audit Started</para>
	///<para>Value = 112</para></summary>
	[Description("User Access Audit Started")]
	UserAccessAuditStarted = 112, 
	///<summary><para>User Access Audit Stopped</para>
	///<para>Value = 113</para></summary>
	[Description("User Access Audit Stopped")]
	UserAccessAuditStopped = 113
}
public enum eOperation
{
	///<summary><para>Create</para>
	///<para>Value = 1</para></summary>
	[Description("Create")]
	Create = 1, 
	///<summary><para>Update</para>
	///<para>Value = 2</para></summary>
	[Description("Update")]
	Update = 2, 
	///<summary><para>Delete</para>
	///<para>Value = 3</para></summary>
	[Description("Delete")]
	Delete = 3, 
	///<summary><para>Access</para>
	///<para>Value = 4</para></summary>
	[Description("Access")]
	Access = 4
}


        public static class Properties
{
	/// <summary><para>useridname</para>
	/// <para>useridname</para></summary>
	public const string UserIdName = "useridname";
	/// <summary><para>callinguseridname</para>
	/// <para>callinguseridname</para></summary>
	public const string CallingUserIdName = "callinguseridname";
	/// <summary><para>regardingobjectidname</para>
	/// <para>regardingobjectidname</para></summary>
	public const string RegardingObjectIdName = "regardingobjectidname";
	/// <summary><para>objectidname</para>
	/// <para>objectidname</para></summary>
	public const string ObjectIdName = "objectidname";
	/// <summary><para>Calling User</para>
	/// <para>callinguserid</para></summary>
	public const string CallingUser = "callinguserid";
	/// <summary><para>Change Data</para>
	/// <para>changedata</para></summary>
	public const string ChangeData = "changedata";
	/// <summary><para>Changed By</para>
	/// <para>userid</para></summary>
	public const string ChangedBy = "userid";
	/// <summary><para>Changed Date</para>
	/// <para>createdon</para></summary>
	public const string ChangedDate = "createdon";
	/// <summary><para>Changed Field</para>
	/// <para>attributemask</para></summary>
	public const string ChangedField = "attributemask";
	/// <summary><para>Entity</para>
	/// <para>objecttypecode</para></summary>
	public const string Entity = "objecttypecode";
	/// <summary><para>Event</para>
	/// <para>action</para></summary>
	public const string @Event = "action";
	/// <summary><para>Operation</para>
	/// <para>operation</para></summary>
	public const string Operation = "operation";
	/// <summary><para>Record</para>
	/// <para>objectid</para></summary>
	public const string Record = "objectid";
	/// <summary><para>Record Id</para>
	/// <para>auditid</para></summary>
	public const string RecordId = "auditid";
	/// <summary><para>Regarding</para>
	/// <para>regardingobjectid</para></summary>
	public const string Regarding = "regardingobjectid";
	/// <summary><para>Transaction Id</para>
	/// <para>transactionid</para></summary>
	public const string TransactionId = "transactionid";
	/// <summary><para>User Info</para>
	/// <para>useradditionalinfo</para></summary>
	public const string UserInfo = "useradditionalinfo";
}

    }
}
