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
    [EntityLogicalNameAttribute("listmember")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XrmToolkit", "4.0")]
    public partial class MarketingListMember : BaseProxyClass
    {
        public new const string LogicalName = "listmember";
        public const int ObjectTypeCode = 4301;
        public const string PrimaryIdAttribute = "listmemberid";
        public const string PrimaryNameAttribute = "";
        
        static MarketingListMember()
        {
            BaseProxyClass.RegisterProxyType(typeof(MarketingListMember), "listmember");
            _textOptions = new Dictionary<string, eTextOptions>();
            _numberOptions = new Dictionary<string, eNumberOptions>();
            _errorStrings = new Dictionary<string, string>();
            TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
            NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
        }
        public MarketingListMember() : base(new Entity("listmember")) { }
        public MarketingListMember(Entity original) : base(original) { }
        public static string GetLogicalName() { return BaseProxyClass.GetLogicalName<MarketingListMember>(); }
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
///<para>Logical Name: owninguser</para>
///</summary>
[AttributeLogicalNameAttribute("owninguser")]
public Guid OwningUser
{
	get { return this.GetPropertyValue<Guid>("owninguser"); }
}
///<summary>
///<para>Logical Name: entitytype</para>
///</summary>
[AttributeLogicalNameAttribute("entitytype")]
public string EntityType
{
	get { return this.GetPropertyValue<string>("entitytype"); }
	set { this.SetPropertyValue<string>("entitytype", value, "EntityType"); }
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
///<para>Logical Name: createdonbehalfby</para>
///</summary>
[AttributeLogicalNameAttribute("createdonbehalfby")]
public EntityReference CreatedOnBehalfBy
{
	get { return this.GetPropertyValue<EntityReference>("createdonbehalfby"); }
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
///<para>Key Property (Uniqueidentifier)</para>
///<para>Logical Name: listmemberid</para>
///</summary>
[AttributeLogicalNameAttribute("listmemberid")]
public Guid ListMemberId
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
///<para>Logical Name: owningbusinessunit</para>
///</summary>
[AttributeLogicalNameAttribute("owningbusinessunit")]
public Guid OwningBusinessUnit
{
	get { return this.GetPropertyValue<Guid>("owningbusinessunit"); }
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
///<para>Logical Name: createdbyyominame</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("createdbyyominame")]
public string CreatedByYomiName
{
	get { return this.GetPropertyValue<string>("createdbyyominame"); }
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
///<para>Logical Name: owneridtype</para>
///</summary>
[AttributeLogicalNameAttribute("owneridtype")]
public string OwnerIdType
{
	get { return this.GetPropertyValue<string>("owneridtype"); }
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
///<para>Logical Name: createdon</para>
///</summary>
[AttributeLogicalNameAttribute("createdon")]
public DateTime? CreatedOn
{
	get { return this.GetPropertyValue<DateTime?>("createdon"); }
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
///<para>Logical Name: versionnumber</para>
///</summary>
[AttributeLogicalNameAttribute("versionnumber")]
public int? VersionNumber
{
	get { return this.GetPropertyValue<int?>("versionnumber"); }
}
///<summary>
///<para>Logical Name: modifiedonbehalfby</para>
///</summary>
[AttributeLogicalNameAttribute("modifiedonbehalfby")]
public EntityReference ModifiedOnBehalfBy
{
	get { return this.GetPropertyValue<EntityReference>("modifiedonbehalfby"); }
}
///<summary>
///<para>Logical Name: entityid</para>
///</summary>
[AttributeLogicalNameAttribute("entityid")]
public EntityReference Entity
{
	get { return this.GetPropertyValue<EntityReference>("entityid"); }
	set { this.SetPropertyValue<EntityReference>("entityid", value, "Entity"); }
}
///<summary>
///<para>Logical Name: listid</para>
///</summary>
[AttributeLogicalNameAttribute("listid")]
public EntityReference MarketingList
{
	get { return this.GetPropertyValue<EntityReference>("listid"); }
	set { this.SetPropertyValue<EntityReference>("listid", value, "MarketingList"); }
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
///<para>Logical Name: entityidtypecode</para>
///</summary>
[AttributeLogicalNameAttribute("entityidtypecode")]
public string RegardingObjectType
{
	get { return this.GetPropertyValue<string>("entityidtypecode"); }
	set { this.SetPropertyValue<string>("entityidtypecode", value, "RegardingObjectType"); }
}


        /// <summary>
/// <para><b>UserEntityInstanceData (Object Id)</b></para>
/// <para>Schema Name: userentityinstancedata_listmember</para>
/// </summary>
public List<UserEntityInstanceData> GetUserEntityInstanceData_ObjectId (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<UserEntityInstanceData>(Service, this.Id, "userentityinstancedata", "objectid", Columns); }
/// <summary>
/// <para><b>UserEntityInstanceData (Object Id)</b></para>
/// <para>Schema Name: userentityinstancedata_listmember</para>
/// </summary>
public List<UserEntityInstanceData> GetUserEntityInstanceData_ObjectId (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<UserEntityInstanceData>(Service, this.Id, "userentityinstancedata", "objectid", Columns); }


        /// <summary>
/// <para>Related Entity: <b>Marketing List</b></para>
/// <para>N:N Relationship</para>
/// <para>Schema Name: listcontact_association</para>
/// </summary>
public List<MarketingList> GetMarketingLists (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedManyToManyEntities<MarketingList>(Service, this, "listmember", "listmemberid", "list", "listid", "listmember", "entityid", "listid", Columns); }
public List<MarketingList> GetMarketingLists (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedManyToManyEntities<MarketingList>(Service, this, "listmember", "listmemberid", "list", "listid", "listmember", "entityid", "listid", Columns); }
public void RelateMarketingLists (IOrganizationService Service, params Entity[] Items) { Service.RelateEntities(this, "listcontact_association", Items); }
public void RelateMarketingLists (IOrganizationService Service, params EntityReference[] Items) { Service.RelateEntities(this, "listcontact_association", Items); }
public void UnRelateMarketingLists (IOrganizationService Service, params Entity[] Items) { Service.UnRelateEntities(this, "listcontact_association", Items); }
public void UnRelateMarketingLists (IOrganizationService Service, params EntityReference[] Items) { Service.UnRelateEntities(this, "listcontact_association", Items); }
/// <summary>
/// <para>Related Entity: <b>Marketing List</b></para>
/// <para>N:N Relationship</para>
/// <para>Schema Name: listaccount_association</para>
/// </summary>
public List<MarketingList> GetMarketingLists2 (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedManyToManyEntities<MarketingList>(Service, this, "listmember", "listmemberid", "list", "listid", "listmember", "entityid", "listid", Columns); }
public List<MarketingList> GetMarketingLists2 (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedManyToManyEntities<MarketingList>(Service, this, "listmember", "listmemberid", "list", "listid", "listmember", "entityid", "listid", Columns); }
public void RelateMarketingLists2 (IOrganizationService Service, params Entity[] Items) { Service.RelateEntities(this, "listaccount_association", Items); }
public void RelateMarketingLists2 (IOrganizationService Service, params EntityReference[] Items) { Service.RelateEntities(this, "listaccount_association", Items); }
public void UnRelateMarketingLists2 (IOrganizationService Service, params Entity[] Items) { Service.UnRelateEntities(this, "listaccount_association", Items); }
public void UnRelateMarketingLists2 (IOrganizationService Service, params EntityReference[] Items) { Service.UnRelateEntities(this, "listaccount_association", Items); }
/// <summary>
/// <para>Related Entity: <b>Marketing List</b></para>
/// <para>N:N Relationship</para>
/// <para>Schema Name: listlead_association</para>
/// </summary>
public List<MarketingList> GetMarketingLists3 (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedManyToManyEntities<MarketingList>(Service, this, "listmember", "listmemberid", "list", "listid", "listmember", "entityid", "listid", Columns); }
public List<MarketingList> GetMarketingLists3 (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedManyToManyEntities<MarketingList>(Service, this, "listmember", "listmemberid", "list", "listid", "listmember", "entityid", "listid", Columns); }
public void RelateMarketingLists3 (IOrganizationService Service, params Entity[] Items) { Service.RelateEntities(this, "listlead_association", Items); }
public void RelateMarketingLists3 (IOrganizationService Service, params EntityReference[] Items) { Service.RelateEntities(this, "listlead_association", Items); }
public void UnRelateMarketingLists3 (IOrganizationService Service, params Entity[] Items) { Service.UnRelateEntities(this, "listlead_association", Items); }
public void UnRelateMarketingLists3 (IOrganizationService Service, params EntityReference[] Items) { Service.UnRelateEntities(this, "listlead_association", Items); }


        

        

        public static class Properties
{
	/// <summary><para>createdonbehalfbyyominame</para>
	/// <para>createdonbehalfbyyominame</para></summary>
	public const string CreatedOnBehalfByYomiName = "createdonbehalfbyyominame";
	/// <summary><para>owninguser</para>
	/// <para>owninguser</para></summary>
	public const string OwningUser = "owninguser";
	/// <summary><para>entitytype</para>
	/// <para>entitytype</para></summary>
	public const string EntityType = "entitytype";
	/// <summary><para>modifiedbyyominame</para>
	/// <para>modifiedbyyominame</para></summary>
	public const string ModifiedByYomiName = "modifiedbyyominame";
	/// <summary><para>createdonbehalfby</para>
	/// <para>createdonbehalfby</para></summary>
	public const string CreatedOnBehalfBy = "createdonbehalfby";
	/// <summary><para>createdby</para>
	/// <para>createdby</para></summary>
	public const string CreatedBy = "createdby";
	/// <summary><para>listmemberid</para>
	/// <para>listmemberid</para></summary>
	public const string ListMemberId = "listmemberid";
	/// <summary><para>owningbusinessunit</para>
	/// <para>owningbusinessunit</para></summary>
	public const string OwningBusinessUnit = "owningbusinessunit";
	/// <summary><para>modifiedbyname</para>
	/// <para>modifiedbyname</para></summary>
	public const string ModifiedByName = "modifiedbyname";
	/// <summary><para>createdbyyominame</para>
	/// <para>createdbyyominame</para></summary>
	public const string CreatedByYomiName = "createdbyyominame";
	/// <summary><para>modifiedby</para>
	/// <para>modifiedby</para></summary>
	public const string ModifiedBy = "modifiedby";
	/// <summary><para>owneridtype</para>
	/// <para>owneridtype</para></summary>
	public const string OwnerIdType = "owneridtype";
	/// <summary><para>modifiedon</para>
	/// <para>modifiedon</para></summary>
	public const string ModifiedOn = "modifiedon";
	/// <summary><para>modifiedonbehalfbyyominame</para>
	/// <para>modifiedonbehalfbyyominame</para></summary>
	public const string ModifiedOnBehalfByYomiName = "modifiedonbehalfbyyominame";
	/// <summary><para>createdbyname</para>
	/// <para>createdbyname</para></summary>
	public const string CreatedByName = "createdbyname";
	/// <summary><para>createdon</para>
	/// <para>createdon</para></summary>
	public const string CreatedOn = "createdon";
	/// <summary><para>createdonbehalfbyname</para>
	/// <para>createdonbehalfbyname</para></summary>
	public const string CreatedOnBehalfByName = "createdonbehalfbyname";
	/// <summary><para>modifiedonbehalfbyname</para>
	/// <para>modifiedonbehalfbyname</para></summary>
	public const string ModifiedOnBehalfByName = "modifiedonbehalfbyname";
	/// <summary><para>versionnumber</para>
	/// <para>versionnumber</para></summary>
	public const string VersionNumber = "versionnumber";
	/// <summary><para>modifiedonbehalfby</para>
	/// <para>modifiedonbehalfby</para></summary>
	public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
	/// <summary><para>Entity</para>
	/// <para>entityid</para></summary>
	public const string Entity = "entityid";
	/// <summary><para>Marketing List</para>
	/// <para>listid</para></summary>
	public const string MarketingList = "listid";
	/// <summary><para>Owner</para>
	/// <para>ownerid</para></summary>
	public const string Owner = "ownerid";
	/// <summary><para>Regarding Object Type</para>
	/// <para>entityidtypecode</para></summary>
	public const string RegardingObjectType = "entityidtypecode";
}

    }
}