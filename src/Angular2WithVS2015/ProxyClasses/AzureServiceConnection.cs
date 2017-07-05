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
    [EntityLogicalNameAttribute("azureserviceconnection")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XrmToolkit", "4.0")]
    public partial class AzureServiceConnection : BaseProxyClass
    {
        public new const string LogicalName = "azureserviceconnection";
        public const int ObjectTypeCode = 9936;
        public const string PrimaryIdAttribute = "azureserviceconnectionid";
        public const string PrimaryNameAttribute = "name";
        
        static AzureServiceConnection()
        {
            BaseProxyClass.RegisterProxyType(typeof(AzureServiceConnection), "azureserviceconnection");
            _textOptions = new Dictionary<string, eTextOptions>();
            _numberOptions = new Dictionary<string, eNumberOptions>();
            _errorStrings = new Dictionary<string, string>();
            TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
            NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
        }
        public AzureServiceConnection() : base(new Entity("azureserviceconnection")) { }
        public AzureServiceConnection(Entity original) : base(original) { }
        public static string GetLogicalName() { return BaseProxyClass.GetLogicalName<AzureServiceConnection>(); }
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
///<para>Logical Name: modifiedbyname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("modifiedbyname")]
public string ModifiedByName
{
	get { return this.GetPropertyValue<string>("modifiedbyname"); }
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
///<para>Logical Name: accountkey</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("accountkey")]
public string AzureAccountKey
{
	get { return this.GetPropertyValue<string>("accountkey"); }
	set { this.SetPropertyValue("accountkey", value, 100, "AzureAccountKey"); }
}
///<summary>
///<para>Key Property (Uniqueidentifier)</para>
///<para>Logical Name: azureserviceconnectionid</para>
///</summary>
[AttributeLogicalNameAttribute("azureserviceconnectionid")]
public Guid AzureServiceConnectionId
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
///<para>Logical Name: serviceuri</para>
///<para>Max Length: 500 characters</para>
///</summary>
[AttributeLogicalNameAttribute("serviceuri")]
public string AzureServiceURL
{
	get { return this.GetPropertyValue<string>("serviceuri"); }
	set { this.SetPropertyValue("serviceuri", value, 500, "AzureServiceURL"); }
}
/// <summary>
///Logical Name: connectiontype
/// </summary>
[AttributeLogicalNameAttribute("connectiontype")]
public eConnectionType? ConnectionType
{
	get
	{
		if (ConnectionType_OptionSetValue != null) { return (eConnectionType)ConnectionType_OptionSetValue.Value; }
		return null;
	}
	set
	{
		if (value != null) { this.ConnectionType_OptionSetValue = new OptionSetValue((int)value); }
		else this.ConnectionType_OptionSetValue = null;
	}
}
///<summary>
///<para>Logical Name: connectiontype</para>
///</summary>
[AttributeLogicalNameAttribute("connectiontype")]
public OptionSetValue ConnectionType_OptionSetValue
{
	get { return this.GetPropertyValue<OptionSetValue>("connectiontype"); }
	set { this.SetPropertyValue<OptionSetValue>("connectiontype", value, "ConnectionType_OptionSetValue"); }
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="Service">CRM Organization Service</param>
/// <returns></returns>
public string ConnectionType_Text(IOrganizationService Service)
{
	return this.ConnectionType_OptionSetValue.GetOptionSetText(Service, this, "connectiontype");
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="AttributeMetadata">The attribute metadata previously retrieved using the 'GetAttributeMetadata' extension method on the IOrganizationService object.</param>
/// <returns></returns>
public string ConnectionType_Text(EnumAttributeMetadata AttributeMetadata)
{
	return AttributeMetadata.GetOptionSetText(this.ConnectionType_OptionSetValue.Value);
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
///Logical Name: lastconnectionstatuscode
/// </summary>
[AttributeLogicalNameAttribute("lastconnectionstatuscode")]
public eLastConnectionStatus? LastConnectionStatus
{
	get
	{
		if (LastConnectionStatus_OptionSetValue != null) { return (eLastConnectionStatus)LastConnectionStatus_OptionSetValue.Value; }
		return null;
	}
	set
	{
		if (value != null) { this.LastConnectionStatus_OptionSetValue = new OptionSetValue((int)value); }
		else this.LastConnectionStatus_OptionSetValue = null;
	}
}
///<summary>
///<para>Logical Name: lastconnectionstatuscode</para>
///</summary>
[AttributeLogicalNameAttribute("lastconnectionstatuscode")]
public OptionSetValue LastConnectionStatus_OptionSetValue
{
	get { return this.GetPropertyValue<OptionSetValue>("lastconnectionstatuscode"); }
	set { this.SetPropertyValue<OptionSetValue>("lastconnectionstatuscode", value, "LastConnectionStatus_OptionSetValue"); }
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="Service">CRM Organization Service</param>
/// <returns></returns>
public string LastConnectionStatus_Text(IOrganizationService Service)
{
	return this.LastConnectionStatus_OptionSetValue.GetOptionSetText(Service, this, "lastconnectionstatuscode");
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="AttributeMetadata">The attribute metadata previously retrieved using the 'GetAttributeMetadata' extension method on the IOrganizationService object.</param>
/// <returns></returns>
public string LastConnectionStatus_Text(EnumAttributeMetadata AttributeMetadata)
{
	return AttributeMetadata.GetOptionSetText(this.LastConnectionStatus_OptionSetValue.Value);
}
///<summary>
///<para>Logical Name: lastconnectiontime</para>
///</summary>
[AttributeLogicalNameAttribute("lastconnectiontime")]
public DateTime? LastConnectionTime
{
	get { return this.GetPropertyValue<DateTime?>("lastconnectiontime"); }
	set { this.SetPropertyValue<DateTime?>("lastconnectiontime", value, "LastConnectionTime"); }
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


        /// <summary>
/// <para><b>AdvancedSimilarityRule (Connection)</b></para>
/// <para>Schema Name: azureserviceconnection_advancedsimilarityrule</para>
/// </summary>
public List<AdvancedSimilarityRule> GetAdvancedSimilarityRules_Connection (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<AdvancedSimilarityRule>(Service, this.Id, "advancedsimilarityrule", "azureserviceconnectionid", Columns); }
/// <summary>
/// <para><b>AdvancedSimilarityRule (Connection)</b></para>
/// <para>Schema Name: azureserviceconnection_advancedsimilarityrule</para>
/// </summary>
public List<AdvancedSimilarityRule> GetAdvancedSimilarityRules_Connection (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<AdvancedSimilarityRule>(Service, this.Id, "advancedsimilarityrule", "azureserviceconnectionid", Columns); }
/// <summary>
/// <para><b>KnowledgeSearchModel (Connection)</b></para>
/// <para>Schema Name: azureserviceconnection_knowledgesearchmodel</para>
/// </summary>
public List<KnowledgeSearchModel> GetKnowledgeSearchModel_Connection (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<KnowledgeSearchModel>(Service, this.Id, "knowledgesearchmodel", "azureserviceconnectionid", Columns); }
/// <summary>
/// <para><b>KnowledgeSearchModel (Connection)</b></para>
/// <para>Schema Name: azureserviceconnection_knowledgesearchmodel</para>
/// </summary>
public List<KnowledgeSearchModel> GetKnowledgeSearchModel_Connection (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<KnowledgeSearchModel>(Service, this.Id, "knowledgesearchmodel", "azureserviceconnectionid", Columns); }
/// <summary>
/// <para><b>ProductRecommendationModel (Azure Service Connection)</b></para>
/// <para>Schema Name: azureserviceconnection_recommendationmodel</para>
/// </summary>
public List<ProductRecommendationModel> GetProductRecommendationModels_AzureServiceConnection (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<ProductRecommendationModel>(Service, this.Id, "recommendationmodel", "azureserviceconnectionid", Columns); }
/// <summary>
/// <para><b>ProductRecommendationModel (Azure Service Connection)</b></para>
/// <para>Schema Name: azureserviceconnection_recommendationmodel</para>
/// </summary>
public List<ProductRecommendationModel> GetProductRecommendationModels_AzureServiceConnection (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<ProductRecommendationModel>(Service, this.Id, "recommendationmodel", "azureserviceconnectionid", Columns); }
/// <summary>
/// <para><b>TopicModel (Connection)</b></para>
/// <para>Schema Name: azureserviceconnection_topicmodel</para>
/// </summary>
public List<TopicModel> GetTopicModel_Connection (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<TopicModel>(Service, this.Id, "topicmodel", "azureserviceconnectionid", Columns); }
/// <summary>
/// <para><b>TopicModel (Connection)</b></para>
/// <para>Schema Name: azureserviceconnection_topicmodel</para>
/// </summary>
public List<TopicModel> GetTopicModel_Connection (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<TopicModel>(Service, this.Id, "topicmodel", "azureserviceconnectionid", Columns); }


        

        

        public enum eConnectionType
{
	///<summary><para>Recommendation</para>
	///<para>Value = 1</para></summary>
	[Description("Recommendation")]
	Recommendation = 1, 
	///<summary><para>Text Analytics</para>
	///<para>Value = 2</para></summary>
	[Description("Text Analytics")]
	TextAnalytics = 2
}
public enum eLastConnectionStatus
{
	///<summary><para>Success</para>
	///<para>Value = 1</para></summary>
	[Description("Success")]
	Success = 1, 
	///<summary><para>Failure</para>
	///<para>Value = 2</para></summary>
	[Description("Failure")]
	Failure = 2
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
	/// <summary><para>organizationidname</para>
	/// <para>organizationidname</para></summary>
	public const string OrganizationIdName = "organizationidname";
	/// <summary><para>modifiedbyname</para>
	/// <para>modifiedbyname</para></summary>
	public const string ModifiedByName = "modifiedbyname";
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
	/// <summary><para>Azure Account Key</para>
	/// <para>accountkey</para></summary>
	public const string AzureAccountKey = "accountkey";
	/// <summary><para>Azure Service Connection</para>
	/// <para>azureserviceconnectionid</para></summary>
	public const string AzureServiceConnectionId = "azureserviceconnectionid";
	/// <summary><para>Azure Service URL</para>
	/// <para>serviceuri</para></summary>
	public const string AzureServiceURL = "serviceuri";
	/// <summary><para>Connection Type</para>
	/// <para>connectiontype</para></summary>
	public const string ConnectionType = "connectiontype";
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
	/// <summary><para>Last Connection Status</para>
	/// <para>lastconnectionstatuscode</para></summary>
	public const string LastConnectionStatus = "lastconnectionstatuscode";
	/// <summary><para>Last Connection Time</para>
	/// <para>lastconnectiontime</para></summary>
	public const string LastConnectionTime = "lastconnectiontime";
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
	/// <summary><para>Status</para>
	/// <para>statecode</para></summary>
	public const string Status = "statecode";
	/// <summary><para>Status Reason</para>
	/// <para>statuscode</para></summary>
	public const string StatusReason = "statuscode";
}

    }
}
