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
    [EntityLogicalNameAttribute("savedorginsightsconfiguration")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XrmToolkit", "4.0")]
    public partial class SavedOrganizationInsightsConfiguration : BaseProxyClass
    {
        public new const string LogicalName = "savedorginsightsconfiguration";
        public const int ObjectTypeCode = 1309;
        public const string PrimaryIdAttribute = "savedorginsightsconfigurationid";
        public const string PrimaryNameAttribute = "";
        
        static SavedOrganizationInsightsConfiguration()
        {
            BaseProxyClass.RegisterProxyType(typeof(SavedOrganizationInsightsConfiguration), "savedorginsightsconfiguration");
            _textOptions = new Dictionary<string, eTextOptions>();
            _numberOptions = new Dictionary<string, eNumberOptions>();
            _errorStrings = new Dictionary<string, string>();
            TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
            NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
        }
        public SavedOrganizationInsightsConfiguration() : base(new Entity("savedorginsightsconfiguration")) { }
        public SavedOrganizationInsightsConfiguration(Entity original) : base(original) { }
        public static string GetLogicalName() { return BaseProxyClass.GetLogicalName<SavedOrganizationInsightsConfiguration>(); }
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
///<para>Logical Name: createdbyname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("createdbyname")]
public string CreatedByName
{
	get { return this.GetPropertyValue<string>("createdbyname"); }
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
///<para>Logical Name: modifiedbyyominame</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("modifiedbyyominame")]
public string ModifiedByYomiName
{
	get { return this.GetPropertyValue<string>("modifiedbyyominame"); }
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
///<para>Logical Name: isdefault</para>
///<para>True = Yes</para>
///<para>False = No</para>
///</summary>
[AttributeLogicalNameAttribute("isdefault")]
public bool? DefaultConfiguration
{
	get { return this.GetPropertyValue<bool?>("isdefault"); }
	set { this.SetPropertyValue<bool?>("isdefault", value, "DefaultConfiguration"); }
}
///<summary>
///<para>Logical Name: description</para>
///<para>Max Length: 1000 characters</para>
///</summary>
[AttributeLogicalNameAttribute("description")]
public string DescriptionOfTheSavedOrganizationInsightsConfiguration
{
	get { return this.GetPropertyValue<string>("description"); }
	set { this.SetPropertyValue("description", value, 1000, "DescriptionOfTheSavedOrganizationInsightsConfiguration"); }
}
///<summary>
///<para>Logical Name: name</para>
///<para>Max Length: 1000 characters</para>
///</summary>
[AttributeLogicalNameAttribute("name")]
public string DisplayNameForTheSavedOrganizationInsightsConfiguration
{
	get { return this.GetPropertyValue<string>("name"); }
	set { this.SetPropertyValue("name", value, 1000, "DisplayNameForTheSavedOrganizationInsightsConfiguration"); }
}
///<summary>
///<para>Logical Name: jsondataendtime</para>
///</summary>
[AttributeLogicalNameAttribute("jsondataendtime")]
public DateTime? EndTime
{
	get { return this.GetPropertyValue<DateTime?>("jsondataendtime"); }
}
///<summary>
///<para>Logical Name: isdrilldown</para>
///<para>True = Yes</para>
///<para>False = No</para>
///</summary>
[AttributeLogicalNameAttribute("isdrilldown")]
public bool? IsDrilldown
{
	get { return this.GetPropertyValue<bool?>("isdrilldown"); }
	set { this.SetPropertyValue<bool?>("isdrilldown", value, "IsDrilldown"); }
}
/// <summary>
///Logical Name: lookback
/// </summary>
[AttributeLogicalNameAttribute("lookback")]
public eLookback? Lookback
{
	get
	{
		if (Lookback_OptionSetValue != null) { return (eLookback)Lookback_OptionSetValue.Value; }
		return null;
	}
	set
	{
		if (value != null) { this.Lookback_OptionSetValue = new OptionSetValue((int)value); }
		else this.Lookback_OptionSetValue = null;
	}
}
///<summary>
///<para>Logical Name: lookback</para>
///</summary>
[AttributeLogicalNameAttribute("lookback")]
public OptionSetValue Lookback_OptionSetValue
{
	get { return this.GetPropertyValue<OptionSetValue>("lookback"); }
	set { this.SetPropertyValue<OptionSetValue>("lookback", value, "Lookback_OptionSetValue"); }
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="Service">CRM Organization Service</param>
/// <returns></returns>
public string Lookback_Text(IOrganizationService Service)
{
	return this.Lookback_OptionSetValue.GetOptionSetText(Service, this, "lookback");
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="AttributeMetadata">The attribute metadata previously retrieved using the 'GetAttributeMetadata' extension method on the IOrganizationService object.</param>
/// <returns></returns>
public string Lookback_Text(EnumAttributeMetadata AttributeMetadata)
{
	return AttributeMetadata.GetOptionSetText(this.Lookback_OptionSetValue.Value);
}
/// <summary>
///Logical Name: metrictype
/// </summary>
[AttributeLogicalNameAttribute("metrictype")]
public eSavedOrgInsightsConfigurationMetricType? MetricType
{
	get
	{
		if (MetricType_OptionSetValue != null) { return (eSavedOrgInsightsConfigurationMetricType)MetricType_OptionSetValue.Value; }
		return null;
	}
	set
	{
		if (value != null) { this.MetricType_OptionSetValue = new OptionSetValue((int)value); }
		else this.MetricType_OptionSetValue = null;
	}
}
///<summary>
///<para>Logical Name: metrictype</para>
///</summary>
[AttributeLogicalNameAttribute("metrictype")]
public OptionSetValue MetricType_OptionSetValue
{
	get { return this.GetPropertyValue<OptionSetValue>("metrictype"); }
	set { this.SetPropertyValue<OptionSetValue>("metrictype", value, "MetricType_OptionSetValue"); }
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="Service">CRM Organization Service</param>
/// <returns></returns>
public string MetricType_Text(IOrganizationService Service)
{
	return this.MetricType_OptionSetValue.GetOptionSetText(Service, this, "metrictype");
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="AttributeMetadata">The attribute metadata previously retrieved using the 'GetAttributeMetadata' extension method on the IOrganizationService object.</param>
/// <returns></returns>
public string MetricType_Text(EnumAttributeMetadata AttributeMetadata)
{
	return AttributeMetadata.GetOptionSetText(this.MetricType_OptionSetValue.Value);
}
///<summary>
///<para>Logical Name: jsondata</para>
///<para>Max Length: 2000 characters</para>
///</summary>
[AttributeLogicalNameAttribute("jsondata")]
public string MetricsDataInJsonFormatForTheMetricsDefinedInParameters
{
	get { return this.GetPropertyValue<string>("jsondata"); }
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
///<para>Logical Name: parameters</para>
///<para>Max Length: 1000 characters</para>
///</summary>
[AttributeLogicalNameAttribute("parameters")]
public string ParametersNeededForDataRetrieval
{
	get { return this.GetPropertyValue<string>("parameters"); }
	set { this.SetPropertyValue("parameters", value, 1000, "ParametersNeededForDataRetrieval"); }
}
/// <summary>
///Logical Name: plotoption
/// </summary>
[AttributeLogicalNameAttribute("plotoption")]
public ePlotOption? PlotOption
{
	get
	{
		if (PlotOption_OptionSetValue != null) { return (ePlotOption)PlotOption_OptionSetValue.Value; }
		return null;
	}
	set
	{
		if (value != null) { this.PlotOption_OptionSetValue = new OptionSetValue((int)value); }
		else this.PlotOption_OptionSetValue = null;
	}
}
///<summary>
///<para>Logical Name: plotoption</para>
///</summary>
[AttributeLogicalNameAttribute("plotoption")]
public OptionSetValue PlotOption_OptionSetValue
{
	get { return this.GetPropertyValue<OptionSetValue>("plotoption"); }
	set { this.SetPropertyValue<OptionSetValue>("plotoption", value, "PlotOption_OptionSetValue"); }
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="Service">CRM Organization Service</param>
/// <returns></returns>
public string PlotOption_Text(IOrganizationService Service)
{
	return this.PlotOption_OptionSetValue.GetOptionSetText(Service, this, "plotoption");
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="AttributeMetadata">The attribute metadata previously retrieved using the 'GetAttributeMetadata' extension method on the IOrganizationService object.</param>
/// <returns></returns>
public string PlotOption_Text(EnumAttributeMetadata AttributeMetadata)
{
	return AttributeMetadata.GetOptionSetText(this.PlotOption_OptionSetValue.Value);
}
///<summary>
///<para>Key Property (Uniqueidentifier)</para>
///<para>Logical Name: savedorginsightsconfigurationid</para>
///</summary>
[AttributeLogicalNameAttribute("savedorginsightsconfigurationid")]
public Guid SavedOrgInsightsConfigurationId
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
///<para>Logical Name: jsondatastarttime</para>
///</summary>
[AttributeLogicalNameAttribute("jsondatastarttime")]
public DateTime? StartTime
{
	get { return this.GetPropertyValue<DateTime?>("jsondatastarttime"); }
}


        

        

        

        public enum eLookback
{
	///<summary><para>2H</para>
	///<para>Value = 1</para></summary>
	[Description("2H")]
	_2H = 1, 
	///<summary><para>48H</para>
	///<para>Value = 2</para></summary>
	[Description("48H")]
	_48H = 2, 
	///<summary><para>7D</para>
	///<para>Value = 3</para></summary>
	[Description("7D")]
	_7D = 3, 
	///<summary><para>30D</para>
	///<para>Value = 4</para></summary>
	[Description("30D")]
	_30D = 4
}
public enum eSavedOrgInsightsConfigurationMetricType
{
	///<summary><para>Time Series</para>
	///<para>Value = 1</para></summary>
	[Description("Time Series")]
	TimeSeries = 1, 
	///<summary><para>Category</para>
	///<para>Value = 2</para></summary>
	[Description("Category")]
	Category = 2
}
public enum ePlotOption
{
	///<summary><para>Line</para>
	///<para>Value = 1</para></summary>
	[Description("Line")]
	Line = 1, 
	///<summary><para>Column</para>
	///<para>Value = 2</para></summary>
	[Description("Column")]
	Column = 2, 
	///<summary><para>Area</para>
	///<para>Value = 3</para></summary>
	[Description("Area")]
	Area = 3, 
	///<summary><para>Pie</para>
	///<para>Value = 4</para></summary>
	[Description("Pie")]
	Pie = 4, 
	///<summary><para>Bar</para>
	///<para>Value = 5</para></summary>
	[Description("Bar")]
	Bar = 5, 
	///<summary><para>Donut</para>
	///<para>Value = 6</para></summary>
	[Description("Donut")]
	Donut = 6, 
	///<summary><para>Infocard</para>
	///<para>Value = 7</para></summary>
	[Description("Infocard")]
	Infocard = 7, 
	///<summary><para>List</para>
	///<para>Value = 8</para></summary>
	[Description("List")]
	List = 8, 
	///<summary><para>DoubleDonut</para>
	///<para>Value = 9</para></summary>
	[Description("DoubleDonut")]
	DoubleDonut = 9, 
	///<summary><para>LinearGauge</para>
	///<para>Value = 10</para></summary>
	[Description("LinearGauge")]
	LinearGauge = 10, 
	///<summary><para>Bubble</para>
	///<para>Value = 11</para></summary>
	[Description("Bubble")]
	Bubble = 11
}


        public static class Properties
{
	/// <summary><para>createdonbehalfbyyominame</para>
	/// <para>createdonbehalfbyyominame</para></summary>
	public const string CreatedOnBehalfByYomiName = "createdonbehalfbyyominame";
	/// <summary><para>createdbyname</para>
	/// <para>createdbyname</para></summary>
	public const string CreatedByName = "createdbyname";
	/// <summary><para>organizationidname</para>
	/// <para>organizationidname</para></summary>
	public const string OrganizationIdName = "organizationidname";
	/// <summary><para>modifiedbyyominame</para>
	/// <para>modifiedbyyominame</para></summary>
	public const string ModifiedByYomiName = "modifiedbyyominame";
	/// <summary><para>createdbyyominame</para>
	/// <para>createdbyyominame</para></summary>
	public const string CreatedByYomiName = "createdbyyominame";
	/// <summary><para>modifiedbyname</para>
	/// <para>modifiedbyname</para></summary>
	public const string ModifiedByName = "modifiedbyname";
	/// <summary><para>modifiedonbehalfbyyominame</para>
	/// <para>modifiedonbehalfbyyominame</para></summary>
	public const string ModifiedOnBehalfByYomiName = "modifiedonbehalfbyyominame";
	/// <summary><para>createdonbehalfbyname</para>
	/// <para>createdonbehalfbyname</para></summary>
	public const string CreatedOnBehalfByName = "createdonbehalfbyname";
	/// <summary><para>modifiedonbehalfbyname</para>
	/// <para>modifiedonbehalfbyname</para></summary>
	public const string ModifiedOnBehalfByName = "modifiedonbehalfbyname";
	/// <summary><para>Created By</para>
	/// <para>createdby</para></summary>
	public const string CreatedBy = "createdby";
	/// <summary><para>Created By (Delegate)</para>
	/// <para>createdonbehalfby</para></summary>
	public const string CreatedBy_Delegate = "createdonbehalfby";
	/// <summary><para>Created On</para>
	/// <para>createdon</para></summary>
	public const string CreatedOn = "createdon";
	/// <summary><para>Default Configuration</para>
	/// <para>isdefault</para></summary>
	public const string DefaultConfiguration = "isdefault";
	/// <summary><para>Description of the saved organization insights configuration</para>
	/// <para>description</para></summary>
	public const string DescriptionOfTheSavedOrganizationInsightsConfiguration = "description";
	/// <summary><para>Display name for the saved organization insights configuration</para>
	/// <para>name</para></summary>
	public const string DisplayNameForTheSavedOrganizationInsightsConfiguration = "name";
	/// <summary><para>End Time</para>
	/// <para>jsondataendtime</para></summary>
	public const string EndTime = "jsondataendtime";
	/// <summary><para>Is Drilldown</para>
	/// <para>isdrilldown</para></summary>
	public const string IsDrilldown = "isdrilldown";
	/// <summary><para>Lookback</para>
	/// <para>lookback</para></summary>
	public const string Lookback = "lookback";
	/// <summary><para>Metric Type</para>
	/// <para>metrictype</para></summary>
	public const string MetricType = "metrictype";
	/// <summary><para>Metrics Data in Json format for the metrics defined in parameters</para>
	/// <para>jsondata</para></summary>
	public const string MetricsDataInJsonFormatForTheMetricsDefinedInParameters = "jsondata";
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
	/// <summary><para>Parameters needed for data retrieval</para>
	/// <para>parameters</para></summary>
	public const string ParametersNeededForDataRetrieval = "parameters";
	/// <summary><para>Plot Option</para>
	/// <para>plotoption</para></summary>
	public const string PlotOption = "plotoption";
	/// <summary><para>SavedOrgInsightsConfigurationId</para>
	/// <para>savedorginsightsconfigurationid</para></summary>
	public const string SavedOrgInsightsConfigurationId = "savedorginsightsconfigurationid";
	/// <summary><para>Start Time</para>
	/// <para>jsondatastarttime</para></summary>
	public const string StartTime = "jsondatastarttime";
}

    }
}
