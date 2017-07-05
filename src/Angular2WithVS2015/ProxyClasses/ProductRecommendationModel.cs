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
    [EntityLogicalNameAttribute("recommendationmodel")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XrmToolkit", "4.0")]
    public partial class ProductRecommendationModel : BaseProxyClass
    {
        public new const string LogicalName = "recommendationmodel";
        public const int ObjectTypeCode = 9933;
        public const string PrimaryIdAttribute = "recommendationmodelid";
        public const string PrimaryNameAttribute = "name";
        
        static ProductRecommendationModel()
        {
            BaseProxyClass.RegisterProxyType(typeof(ProductRecommendationModel), "recommendationmodel");
            _textOptions = new Dictionary<string, eTextOptions>();
            _numberOptions = new Dictionary<string, eNumberOptions>();
            _errorStrings = new Dictionary<string, string>();
            TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
            NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
        }
        public ProductRecommendationModel() : base(new Entity("recommendationmodel")) { }
        public ProductRecommendationModel(Entity original) : base(original) { }
        public static string GetLogicalName() { return BaseProxyClass.GetLogicalName<ProductRecommendationModel>(); }
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
///<para>Logical Name: azureserviceconnectionidname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("azureserviceconnectionidname")]
public string AzureServiceConnectionIdName
{
	get { return this.GetPropertyValue<string>("azureserviceconnectionidname"); }
}
///<summary>
///<para>Logical Name: recommendationmodelversionidname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("recommendationmodelversionidname")]
public string RecommendationModelVersionIdName
{
	get { return this.GetPropertyValue<string>("recommendationmodelversionidname"); }
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
///<para>Logical Name: organizationidname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("organizationidname")]
public string OrganizationIdName
{
	get { return this.GetPropertyValue<string>("organizationidname"); }
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
///<para>Logical Name: azuremodelid</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("azuremodelid")]
public string AzureModelId
{
	get { return this.GetPropertyValue<string>("azuremodelid"); }
	set { this.SetPropertyValue("azuremodelid", value, 100, "AzureModelId"); }
}
///<summary>
///<para>Logical Name: azureserviceconnectionid</para>
///</summary>
[AttributeLogicalNameAttribute("azureserviceconnectionid")]
public EntityReference AzureServiceConnection
{
	get { return this.GetPropertyValue<EntityReference>("azureserviceconnectionid"); }
	set { this.SetPropertyValue<EntityReference>("azureserviceconnectionid", value, "AzureServiceConnection"); }
}
/// <summary>
///Logical Name: basketdatalastsynchronizationstatus
/// </summary>
[AttributeLogicalNameAttribute("basketdatalastsynchronizationstatus")]
public eBasketDataLastSynchronizationStatus? BasketDataLastSynchronizationStatus
{
	get
	{
		if (BasketDataLastSynchronizationStatus_OptionSetValue != null) { return (eBasketDataLastSynchronizationStatus)BasketDataLastSynchronizationStatus_OptionSetValue.Value; }
		return null;
	}
	set
	{
		if (value != null) { this.BasketDataLastSynchronizationStatus_OptionSetValue = new OptionSetValue((int)value); }
		else this.BasketDataLastSynchronizationStatus_OptionSetValue = null;
	}
}
///<summary>
///<para>Logical Name: basketdatalastsynchronizationstatus</para>
///</summary>
[AttributeLogicalNameAttribute("basketdatalastsynchronizationstatus")]
public OptionSetValue BasketDataLastSynchronizationStatus_OptionSetValue
{
	get { return this.GetPropertyValue<OptionSetValue>("basketdatalastsynchronizationstatus"); }
	set { this.SetPropertyValue<OptionSetValue>("basketdatalastsynchronizationstatus", value, "BasketDataLastSynchronizationStatus_OptionSetValue"); }
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="Service">CRM Organization Service</param>
/// <returns></returns>
public string BasketDataLastSynchronizationStatus_Text(IOrganizationService Service)
{
	return this.BasketDataLastSynchronizationStatus_OptionSetValue.GetOptionSetText(Service, this, "basketdatalastsynchronizationstatus");
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="AttributeMetadata">The attribute metadata previously retrieved using the 'GetAttributeMetadata' extension method on the IOrganizationService object.</param>
/// <returns></returns>
public string BasketDataLastSynchronizationStatus_Text(EnumAttributeMetadata AttributeMetadata)
{
	return AttributeMetadata.GetOptionSetText(this.BasketDataLastSynchronizationStatus_OptionSetValue.Value);
}
///<summary>
///<para>Logical Name: basketdatalastsynchronizedon</para>
///</summary>
[AttributeLogicalNameAttribute("basketdatalastsynchronizedon")]
public DateTime? BasketDataLastSynchronizedOn
{
	get { return this.GetPropertyValue<DateTime?>("basketdatalastsynchronizedon"); }
	set { this.SetPropertyValue<DateTime?>("basketdatalastsynchronizedon", value, "BasketDataLastSynchronizedOn"); }
}
/// <summary>
///Logical Name: cataloglastsynchronizationstatus
/// </summary>
[AttributeLogicalNameAttribute("cataloglastsynchronizationstatus")]
public eCatalogLastSynchronizationStatus? CatalogLastSynchronizationStatus
{
	get
	{
		if (CatalogLastSynchronizationStatus_OptionSetValue != null) { return (eCatalogLastSynchronizationStatus)CatalogLastSynchronizationStatus_OptionSetValue.Value; }
		return null;
	}
	set
	{
		if (value != null) { this.CatalogLastSynchronizationStatus_OptionSetValue = new OptionSetValue((int)value); }
		else this.CatalogLastSynchronizationStatus_OptionSetValue = null;
	}
}
///<summary>
///<para>Logical Name: cataloglastsynchronizationstatus</para>
///</summary>
[AttributeLogicalNameAttribute("cataloglastsynchronizationstatus")]
public OptionSetValue CatalogLastSynchronizationStatus_OptionSetValue
{
	get { return this.GetPropertyValue<OptionSetValue>("cataloglastsynchronizationstatus"); }
	set { this.SetPropertyValue<OptionSetValue>("cataloglastsynchronizationstatus", value, "CatalogLastSynchronizationStatus_OptionSetValue"); }
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="Service">CRM Organization Service</param>
/// <returns></returns>
public string CatalogLastSynchronizationStatus_Text(IOrganizationService Service)
{
	return this.CatalogLastSynchronizationStatus_OptionSetValue.GetOptionSetText(Service, this, "cataloglastsynchronizationstatus");
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="AttributeMetadata">The attribute metadata previously retrieved using the 'GetAttributeMetadata' extension method on the IOrganizationService object.</param>
/// <returns></returns>
public string CatalogLastSynchronizationStatus_Text(EnumAttributeMetadata AttributeMetadata)
{
	return AttributeMetadata.GetOptionSetText(this.CatalogLastSynchronizationStatus_OptionSetValue.Value);
}
///<summary>
///<para>Logical Name: cataloglastsynchronizedon</para>
///</summary>
[AttributeLogicalNameAttribute("cataloglastsynchronizedon")]
public DateTime? CatalogLastSynchronizedOn
{
	get { return this.GetPropertyValue<DateTime?>("cataloglastsynchronizedon"); }
	set { this.SetPropertyValue<DateTime?>("cataloglastsynchronizedon", value, "CatalogLastSynchronizedOn"); }
}
/// <summary>
///Logical Name: componentstate
/// </summary>
[AttributeLogicalNameAttribute("componentstate")]
public eComponentState? ComponentState
{
	get
	{
		if (ComponentState_OptionSetValue != null) { return (eComponentState)ComponentState_OptionSetValue.Value; }
		return null;
	}
}
///<summary>
///<para>Logical Name: componentstate</para>
///</summary>
[AttributeLogicalNameAttribute("componentstate")]
public OptionSetValue ComponentState_OptionSetValue
{
	get { return this.GetPropertyValue<OptionSetValue>("componentstate"); }
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="Service">CRM Organization Service</param>
/// <returns></returns>
public string ComponentState_Text(IOrganizationService Service)
{
	return this.ComponentState_OptionSetValue.GetOptionSetText(Service, this, "componentstate");
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="AttributeMetadata">The attribute metadata previously retrieved using the 'GetAttributeMetadata' extension method on the IOrganizationService object.</param>
/// <returns></returns>
public string ComponentState_Text(EnumAttributeMetadata AttributeMetadata)
{
	return AttributeMetadata.GetOptionSetText(this.ComponentState_OptionSetValue.Value);
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
///<para>Logical Name: overwritetime</para>
///</summary>
[AttributeLogicalNameAttribute("overwritetime")]
public DateTime? CreatedOn
{
	get { return this.GetPropertyValue<DateTime?>("overwritetime"); }
}
///<summary>
///<para>Logical Name: createdon</para>
///</summary>
[AttributeLogicalNameAttribute("createdon")]
public DateTime? CreatedOn2
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
///<para>Logical Name: ismanaged</para>
///<para>True = Managed</para>
///<para>False = Unmanaged</para>
///</summary>
[AttributeLogicalNameAttribute("ismanaged")]
public bool? IndicatesWhetherTheSolutionComponentIsPartOfAManagedSolution
{
	get { return this.GetPropertyValue<bool?>("ismanaged"); }
}
///<summary>
///<para>Logical Name: maxrecommendations</para>
///<para>Minimum Value: 2</para>
///<para>Maximum Value: 10</para>
///</summary>
[AttributeLogicalNameAttribute("maxrecommendations")]
public int? MaximumRecommendations
{
	get { return this.GetPropertyValue<int?>("maxrecommendations"); }
	set { this.SetPropertyValue("maxrecommendations", (int?)value, (int)2, (int)10, "MaximumRecommendations"); }
}
///<summary>
///<para>Logical Name: maximumversions</para>
///<para>Minimum Value: 1</para>
///<para>Maximum Value: 15</para>
///</summary>
[AttributeLogicalNameAttribute("maximumversions")]
public int? MaximumVersions
{
	get { return this.GetPropertyValue<int?>("maximumversions"); }
	set { this.SetPropertyValue("maximumversions", (int?)value, (int)1, (int)15, "MaximumVersions"); }
}
///<summary>
///<para>Logical Name: minrecommendationrating</para>
///<para>Minimum Value: 0</para>
///<para>Maximum Value: 1</para>
///<para>Precision: 2</para>
///</summary>
[AttributeLogicalNameAttribute("minrecommendationrating")]
public decimal? MinimumRecommendationRating
{
	get { return this.GetPropertyValue<decimal?>("minrecommendationrating"); }
	set { this.SetPropertyValue("minrecommendationrating", (decimal?)value, (decimal)0, (decimal)1, "MinimumRecommendationRating"); }
}
///<summary>
///<para>Logical Name: name</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("name")]
public string ModelName
{
	get { return this.GetPropertyValue<string>("name"); }
	set { this.SetPropertyValue("name", value, 100, "ModelName"); }
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
///<para>Logical Name: organizationid</para>
///</summary>
[AttributeLogicalNameAttribute("organizationid")]
public EntityReference Organization
{
	get { return this.GetPropertyValue<EntityReference>("organizationid"); }
}
///<summary>
///<para>Logical Name: productcatalogaccessorylinkrating</para>
///<para>Minimum Value: 0</para>
///<para>Maximum Value: 1</para>
///<para>Precision: 1</para>
///</summary>
[AttributeLogicalNameAttribute("productcatalogaccessorylinkrating")]
public decimal? ProductCatalogAccessoryLinkRating
{
	get { return this.GetPropertyValue<decimal?>("productcatalogaccessorylinkrating"); }
	set { this.SetPropertyValue("productcatalogaccessorylinkrating", (decimal?)value, (decimal)0, (decimal)1, "ProductCatalogAccessoryLinkRating"); }
}
///<summary>
///<para>Logical Name: productcatalogcrossselllinkrating</para>
///<para>Minimum Value: 0</para>
///<para>Maximum Value: 1</para>
///<para>Precision: 1</para>
///</summary>
[AttributeLogicalNameAttribute("productcatalogcrossselllinkrating")]
public decimal? ProductCatalogCross_sellLinkRating
{
	get { return this.GetPropertyValue<decimal?>("productcatalogcrossselllinkrating"); }
	set { this.SetPropertyValue("productcatalogcrossselllinkrating", (decimal?)value, (decimal)0, (decimal)1, "ProductCatalogCross_sellLinkRating"); }
}
///<summary>
///<para>Logical Name: productcatalogname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("productcatalogname")]
public string ProductCatalogName
{
	get { return this.GetPropertyValue<string>("productcatalogname"); }
	set { this.SetPropertyValue("productcatalogname", value, 100, "ProductCatalogName"); }
}
///<summary>
///<para>Key Property (Uniqueidentifier)</para>
///<para>Logical Name: recommendationmodelid</para>
///</summary>
[AttributeLogicalNameAttribute("recommendationmodelid")]
public Guid RecommendationModelIdentifierId
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
///<para>Logical Name: recommendationmodelidunique</para>
///</summary>
[AttributeLogicalNameAttribute("recommendationmodelidunique")]
public Guid RecommendationModelUniqueId
{
	get { return this.GetPropertyValue<Guid>("recommendationmodelidunique"); }
}
///<summary>
///<para>Logical Name: recommendationmodelversioncount</para>
///<para>Minimum Value: 0</para>
///<para>Maximum Value: 2147483647</para>
///</summary>
[AttributeLogicalNameAttribute("recommendationmodelversioncount")]
public int? RecommendationModelVersionCount
{
	get { return this.GetPropertyValue<int?>("recommendationmodelversioncount"); }
	set { this.SetPropertyValue("recommendationmodelversioncount", (int?)value, (int)0, (int)2147483647, "RecommendationModelVersionCount"); }
}
///<summary>
///<para>Logical Name: recommendationmodelversionid</para>
///</summary>
[AttributeLogicalNameAttribute("recommendationmodelversionid")]
public EntityReference RecommendationVersion
{
	get { return this.GetPropertyValue<EntityReference>("recommendationmodelversionid"); }
	set { this.SetPropertyValue<EntityReference>("recommendationmodelversionid", value, "RecommendationVersion"); }
}
///<summary>
///<para>Logical Name: supportingsolutionid</para>
///</summary>
[AttributeLogicalNameAttribute("supportingsolutionid")]
public Guid Solution
{
	get { return this.GetPropertyValue<Guid>("supportingsolutionid"); }
}
///<summary>
///<para>Logical Name: solutionid</para>
///</summary>
[AttributeLogicalNameAttribute("solutionid")]
public Guid Solution2
{
	get { return this.GetPropertyValue<Guid>("solutionid"); }
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
///<summary>
///<para>Logical Name: validuntil</para>
///</summary>
[AttributeLogicalNameAttribute("validuntil")]
public DateTime? ValidUntil
{
	get { return this.GetPropertyValue<DateTime?>("validuntil"); }
	set { this.SetPropertyValue<DateTime?>("validuntil", value, "ValidUntil"); }
}


        /// <summary>
/// <para><b>RecommendationCache (Recommendation Model)</b></para>
/// <para>Schema Name: RecommendationModel_RecommendationCache</para>
/// </summary>
public List<RecommendationCache> GetRecommendationCaches_RecommendationModel (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<RecommendationCache>(Service, this.Id, "recommendationcache", "recommendationmodelid", Columns); }
/// <summary>
/// <para><b>RecommendationCache (Recommendation Model)</b></para>
/// <para>Schema Name: RecommendationModel_RecommendationCache</para>
/// </summary>
public List<RecommendationCache> GetRecommendationCaches_RecommendationModel (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<RecommendationCache>(Service, this.Id, "recommendationcache", "recommendationmodelid", Columns); }
/// <summary>
/// <para><b>ModelEntityMapping (Recommendation Model)</b></para>
/// <para>Schema Name: recommendationmodel_recommendationmodelmapping</para>
/// </summary>
public List<ModelEntityMapping> GetModelEntityMappings_RecommendationModel (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<ModelEntityMapping>(Service, this.Id, "recommendationmodelmapping", "recommendationmodelid", Columns); }
/// <summary>
/// <para><b>ModelEntityMapping (Recommendation Model)</b></para>
/// <para>Schema Name: recommendationmodel_recommendationmodelmapping</para>
/// </summary>
public List<ModelEntityMapping> GetModelEntityMappings_RecommendationModel (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<ModelEntityMapping>(Service, this.Id, "recommendationmodelmapping", "recommendationmodelid", Columns); }
/// <summary>
/// <para><b>RecommendationModelVersion (RecommendationModelId)</b></para>
/// <para>Schema Name: recommendationmodel_recommendationmodelversion</para>
/// </summary>
public List<RecommendationModelVersion> GetRecommendationModelVersions_RecommendationModelId (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<RecommendationModelVersion>(Service, this.Id, "recommendationmodelversion", "recommendationmodelid", Columns); }
/// <summary>
/// <para><b>RecommendationModelVersion (RecommendationModelId)</b></para>
/// <para>Schema Name: recommendationmodel_recommendationmodelversion</para>
/// </summary>
public List<RecommendationModelVersion> GetRecommendationModelVersions_RecommendationModelId (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<RecommendationModelVersion>(Service, this.Id, "recommendationmodelversion", "recommendationmodelid", Columns); }


        

        

        public enum eBasketDataLastSynchronizationStatus
{
	///<summary><para>Failure</para>
	///<para>Value = 1</para></summary>
	[Description("Failure")]
	Failure = 1, 
	///<summary><para>Success</para>
	///<para>Value = 2</para></summary>
	[Description("Success")]
	Success = 2
}
public enum eCatalogLastSynchronizationStatus
{
	///<summary><para>Failure</para>
	///<para>Value = 1</para></summary>
	[Description("Failure")]
	Failure = 1, 
	///<summary><para>Success</para>
	///<para>Value = 2</para></summary>
	[Description("Success")]
	Success = 2
}
public enum eComponentState
{
	///<summary><para>Published</para>
	///<para>Value = 0</para></summary>
	[Description("Published")]
	Published = 0, 
	///<summary><para>Unpublished</para>
	///<para>Value = 1</para></summary>
	[Description("Unpublished")]
	Unpublished = 1, 
	///<summary><para>Deleted</para>
	///<para>Value = 2</para></summary>
	[Description("Deleted")]
	Deleted = 2, 
	///<summary><para>Deleted Unpublished</para>
	///<para>Value = 3</para></summary>
	[Description("Deleted Unpublished")]
	DeletedUnpublished = 3
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
	/// <summary><para>azureserviceconnectionidname</para>
	/// <para>azureserviceconnectionidname</para></summary>
	public const string AzureServiceConnectionIdName = "azureserviceconnectionidname";
	/// <summary><para>recommendationmodelversionidname</para>
	/// <para>recommendationmodelversionidname</para></summary>
	public const string RecommendationModelVersionIdName = "recommendationmodelversionidname";
	/// <summary><para>modifiedbyname</para>
	/// <para>modifiedbyname</para></summary>
	public const string ModifiedByName = "modifiedbyname";
	/// <summary><para>organizationidname</para>
	/// <para>organizationidname</para></summary>
	public const string OrganizationIdName = "organizationidname";
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
	/// <summary><para>Azure Model Id</para>
	/// <para>azuremodelid</para></summary>
	public const string AzureModelId = "azuremodelid";
	/// <summary><para>Azure Service Connection</para>
	/// <para>azureserviceconnectionid</para></summary>
	public const string AzureServiceConnection = "azureserviceconnectionid";
	/// <summary><para>Basket Data Last Synchronization Status</para>
	/// <para>basketdatalastsynchronizationstatus</para></summary>
	public const string BasketDataLastSynchronizationStatus = "basketdatalastsynchronizationstatus";
	/// <summary><para>Basket Data Last Synchronized On</para>
	/// <para>basketdatalastsynchronizedon</para></summary>
	public const string BasketDataLastSynchronizedOn = "basketdatalastsynchronizedon";
	/// <summary><para>Catalog Last Synchronization Status</para>
	/// <para>cataloglastsynchronizationstatus</para></summary>
	public const string CatalogLastSynchronizationStatus = "cataloglastsynchronizationstatus";
	/// <summary><para>Catalog Last Synchronized On</para>
	/// <para>cataloglastsynchronizedon</para></summary>
	public const string CatalogLastSynchronizedOn = "cataloglastsynchronizedon";
	/// <summary><para>Component State</para>
	/// <para>componentstate</para></summary>
	public const string ComponentState = "componentstate";
	/// <summary><para>Created By</para>
	/// <para>createdby</para></summary>
	public const string CreatedBy = "createdby";
	/// <summary><para>Created By (Delegate)</para>
	/// <para>createdonbehalfby</para></summary>
	public const string CreatedBy_Delegate = "createdonbehalfby";
	/// <summary><para>Created On</para>
	/// <para>overwritetime</para></summary>
	public const string CreatedOn = "overwritetime";
	/// <summary><para>Created On</para>
	/// <para>createdon</para></summary>
	public const string CreatedOn2 = "createdon";
	/// <summary><para>Description</para>
	/// <para>description</para></summary>
	public const string Description = "description";
	/// <summary><para>Indicates whether the solution component is part of a managed solution.</para>
	/// <para>ismanaged</para></summary>
	public const string IndicatesWhetherTheSolutionComponentIsPartOfAManagedSolution = "ismanaged";
	/// <summary><para>Maximum Recommendations</para>
	/// <para>maxrecommendations</para></summary>
	public const string MaximumRecommendations = "maxrecommendations";
	/// <summary><para>Maximum Versions</para>
	/// <para>maximumversions</para></summary>
	public const string MaximumVersions = "maximumversions";
	/// <summary><para>Minimum Recommendation Rating</para>
	/// <para>minrecommendationrating</para></summary>
	public const string MinimumRecommendationRating = "minrecommendationrating";
	/// <summary><para>Model Name</para>
	/// <para>name</para></summary>
	public const string ModelName = "name";
	/// <summary><para>Modified By</para>
	/// <para>modifiedby</para></summary>
	public const string ModifiedBy = "modifiedby";
	/// <summary><para>Modified By (Delegate)</para>
	/// <para>modifiedonbehalfby</para></summary>
	public const string ModifiedBy_Delegate = "modifiedonbehalfby";
	/// <summary><para>Modified On</para>
	/// <para>modifiedon</para></summary>
	public const string ModifiedOn = "modifiedon";
	/// <summary><para>Organization</para>
	/// <para>organizationid</para></summary>
	public const string Organization = "organizationid";
	/// <summary><para>Product Catalog Accessory Link Rating</para>
	/// <para>productcatalogaccessorylinkrating</para></summary>
	public const string ProductCatalogAccessoryLinkRating = "productcatalogaccessorylinkrating";
	/// <summary><para>Product Catalog Cross-sell Link Rating</para>
	/// <para>productcatalogcrossselllinkrating</para></summary>
	public const string ProductCatalogCross_sellLinkRating = "productcatalogcrossselllinkrating";
	/// <summary><para>Product Catalog Name</para>
	/// <para>productcatalogname</para></summary>
	public const string ProductCatalogName = "productcatalogname";
	/// <summary><para>Recommendation Model Identifier</para>
	/// <para>recommendationmodelid</para></summary>
	public const string RecommendationModelIdentifierId = "recommendationmodelid";
	/// <summary><para>Recommendation Model Unique Id</para>
	/// <para>recommendationmodelidunique</para></summary>
	public const string RecommendationModelUniqueId = "recommendationmodelidunique";
	/// <summary><para>Recommendation Model Version Count</para>
	/// <para>recommendationmodelversioncount</para></summary>
	public const string RecommendationModelVersionCount = "recommendationmodelversioncount";
	/// <summary><para>Recommendation Version</para>
	/// <para>recommendationmodelversionid</para></summary>
	public const string RecommendationVersion = "recommendationmodelversionid";
	/// <summary><para>Solution</para>
	/// <para>supportingsolutionid</para></summary>
	public const string Solution = "supportingsolutionid";
	/// <summary><para>Solution</para>
	/// <para>solutionid</para></summary>
	public const string Solution2 = "solutionid";
	/// <summary><para>Status</para>
	/// <para>statecode</para></summary>
	public const string Status = "statecode";
	/// <summary><para>Status Reason</para>
	/// <para>statuscode</para></summary>
	public const string StatusReason = "statuscode";
	/// <summary><para>Valid Until</para>
	/// <para>validuntil</para></summary>
	public const string ValidUntil = "validuntil";
}

    }
}