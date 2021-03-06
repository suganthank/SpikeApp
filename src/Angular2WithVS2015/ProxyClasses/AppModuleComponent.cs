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
    [EntityLogicalNameAttribute("appmodulecomponent")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XrmToolkit", "4.0")]
    public partial class AppModuleComponent : BaseProxyClass
    {
        public new const string LogicalName = "appmodulecomponent";
        public const int ObjectTypeCode = 9007;
        public const string PrimaryIdAttribute = "appmodulecomponentid";
        public const string PrimaryNameAttribute = "";
        
        static AppModuleComponent()
        {
            BaseProxyClass.RegisterProxyType(typeof(AppModuleComponent), "appmodulecomponent");
            _textOptions = new Dictionary<string, eTextOptions>();
            _numberOptions = new Dictionary<string, eNumberOptions>();
            _errorStrings = new Dictionary<string, string>();
            TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
            NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
        }
        public AppModuleComponent() : base(new Entity("appmodulecomponent")) { }
        public AppModuleComponent(Entity original) : base(original) { }
        public static string GetLogicalName() { return BaseProxyClass.GetLogicalName<AppModuleComponent>(); }
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
///<para>Logical Name: versionnumber</para>
///</summary>
[AttributeLogicalNameAttribute("versionnumber")]
public int? VersionNumber
{
	get { return this.GetPropertyValue<int?>("versionnumber"); }
}
///<summary>
///<para>Logical Name: appmoduleidname</para>
///<para>Max Length: 256 characters</para>
///</summary>
[AttributeLogicalNameAttribute("appmoduleidname")]
public string AppModuleIdName
{
	get { return this.GetPropertyValue<string>("appmoduleidname"); }
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
///<para>Logical Name: modifiedonbehalfbyname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("modifiedonbehalfbyname")]
public string ModifiedOnBehalfByName
{
	get { return this.GetPropertyValue<string>("modifiedonbehalfbyname"); }
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
///<para>Key Property (Uniqueidentifier)</para>
///<para>Logical Name: appmodulecomponentid</para>
///</summary>
[AttributeLogicalNameAttribute("appmodulecomponentid")]
public Guid AppModuleComponentId
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
///<para>Logical Name: appmodulecomponentidunique</para>
///</summary>
[AttributeLogicalNameAttribute("appmodulecomponentidunique")]
public Guid ApplicationComponentUniqueId
{
	get { return this.GetPropertyValue<Guid>("appmodulecomponentidunique"); }
	set { this.SetPropertyValue<Guid>("appmodulecomponentidunique", value, "ApplicationComponentUniqueId"); }
}
///<summary>
///<para>Logical Name: appmoduleidunique</para>
///</summary>
[AttributeLogicalNameAttribute("appmoduleidunique")]
public EntityReference AppModule
{
	get { return this.GetPropertyValue<EntityReference>("appmoduleidunique"); }
	set { this.SetPropertyValue<EntityReference>("appmoduleidunique", value, "AppModule"); }
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
///<para>Logical Name: exchangerate</para>
///<para>Minimum Value: 0.0000000001</para>
///<para>Maximum Value: 100000000000</para>
///<para>Precision: 10</para>
///</summary>
[AttributeLogicalNameAttribute("exchangerate")]
public decimal? ExchangeRate
{
	get { return this.GetPropertyValue<decimal?>("exchangerate"); }
}
///<summary>
///<para>Logical Name: introducedversion</para>
///<para>Max Length: 48 characters</para>
///</summary>
[AttributeLogicalNameAttribute("introducedversion")]
public string IntroducedVersion
{
	get { return this.GetPropertyValue<string>("introducedversion"); }
	set { this.SetPropertyValue("introducedversion", value, 48, "IntroducedVersion"); }
}
///<summary>
///<para>Logical Name: isdefault</para>
///<para>True = Yes</para>
///<para>False = No</para>
///</summary>
[AttributeLogicalNameAttribute("isdefault")]
public bool? IsDefault
{
	get { return this.GetPropertyValue<bool?>("isdefault"); }
	set { this.SetPropertyValue<bool?>("isdefault", value, "IsDefault"); }
}
///<summary>
///<para>Logical Name: ismetadata</para>
///<para>True = Metadata</para>
///<para>False = Data</para>
///</summary>
[AttributeLogicalNameAttribute("ismetadata")]
public bool? IsMetadata
{
	get { return this.GetPropertyValue<bool?>("ismetadata"); }
	set { this.SetPropertyValue<bool?>("ismetadata", value, "IsMetadata"); }
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
///<para>Logical Name: objectid</para>
///</summary>
[AttributeLogicalNameAttribute("objectid")]
public Guid @Object
{
	get { return this.GetPropertyValue<Guid>("objectid"); }
	set { this.SetPropertyValue<Guid>("objectid", value, "@Object"); }
}
/// <summary>
///Logical Name: componenttype
/// </summary>
[AttributeLogicalNameAttribute("componenttype")]
public eComponentType? ObjectTypeCode2
{
	get
	{
		if (ObjectTypeCode2_OptionSetValue != null) { return (eComponentType)ObjectTypeCode2_OptionSetValue.Value; }
		return null;
	}
	set
	{
		if (value != null) { this.ObjectTypeCode2_OptionSetValue = new OptionSetValue((int)value); }
		else this.ObjectTypeCode2_OptionSetValue = null;
	}
}
///<summary>
///<para>Logical Name: componenttype</para>
///</summary>
[AttributeLogicalNameAttribute("componenttype")]
public OptionSetValue ObjectTypeCode2_OptionSetValue
{
	get { return this.GetPropertyValue<OptionSetValue>("componenttype"); }
	set { this.SetPropertyValue<OptionSetValue>("componenttype", value, "ObjectTypeCode2_OptionSetValue"); }
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="Service">CRM Organization Service</param>
/// <returns></returns>
public string ObjectTypeCode2_Text(IOrganizationService Service)
{
	return this.ObjectTypeCode2_OptionSetValue.GetOptionSetText(Service, this, "componenttype");
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="AttributeMetadata">The attribute metadata previously retrieved using the 'GetAttributeMetadata' extension method on the IOrganizationService object.</param>
/// <returns></returns>
public string ObjectTypeCode2_Text(EnumAttributeMetadata AttributeMetadata)
{
	return AttributeMetadata.GetOptionSetText(this.ObjectTypeCode2_OptionSetValue.Value);
}
///<summary>
///<para>Logical Name: rootappmodulecomponentid</para>
///</summary>
[AttributeLogicalNameAttribute("rootappmodulecomponentid")]
public Guid RootAppModuleComponent
{
	get { return this.GetPropertyValue<Guid>("rootappmodulecomponentid"); }
	set { this.SetPropertyValue<Guid>("rootappmodulecomponentid", value, "RootAppModuleComponent"); }
}
/// <summary>
///Logical Name: rootcomponentbehavior
/// </summary>
[AttributeLogicalNameAttribute("rootcomponentbehavior")]
public eIncludeBehavior? RootComponentBehavior
{
	get
	{
		if (RootComponentBehavior_OptionSetValue != null) { return (eIncludeBehavior)RootComponentBehavior_OptionSetValue.Value; }
		return null;
	}
	set
	{
		if (value != null) { this.RootComponentBehavior_OptionSetValue = new OptionSetValue((int)value); }
		else this.RootComponentBehavior_OptionSetValue = null;
	}
}
///<summary>
///<para>Logical Name: rootcomponentbehavior</para>
///</summary>
[AttributeLogicalNameAttribute("rootcomponentbehavior")]
public OptionSetValue RootComponentBehavior_OptionSetValue
{
	get { return this.GetPropertyValue<OptionSetValue>("rootcomponentbehavior"); }
	set { this.SetPropertyValue<OptionSetValue>("rootcomponentbehavior", value, "RootComponentBehavior_OptionSetValue"); }
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="Service">CRM Organization Service</param>
/// <returns></returns>
public string RootComponentBehavior_Text(IOrganizationService Service)
{
	return this.RootComponentBehavior_OptionSetValue.GetOptionSetText(Service, this, "rootcomponentbehavior");
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="AttributeMetadata">The attribute metadata previously retrieved using the 'GetAttributeMetadata' extension method on the IOrganizationService object.</param>
/// <returns></returns>
public string RootComponentBehavior_Text(EnumAttributeMetadata AttributeMetadata)
{
	return AttributeMetadata.GetOptionSetText(this.RootComponentBehavior_OptionSetValue.Value);
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


        

        

        

        public enum eComponentType
{
	///<summary><para>Entities</para>
	///<para>Value = 1</para></summary>
	[Description("Entities")]
	Entities = 1, 
	///<summary><para>Views</para>
	///<para>Value = 26</para></summary>
	[Description("Views")]
	Views = 26, 
	///<summary><para>Business Process Flows</para>
	///<para>Value = 29</para></summary>
	[Description("Business Process Flows")]
	BusinessProcessFlows = 29, 
	///<summary><para>Command (Ribbon) for Forms, Grids, sub grids</para>
	///<para>Value = 48</para></summary>
	[Description("Command (Ribbon) for Forms, Grids, sub grids")]
	Command_Ribbon_ForForms_Grids_SubGrids = 48, 
	///<summary><para>Charts</para>
	///<para>Value = 59</para></summary>
	[Description("Charts")]
	Charts = 59, 
	///<summary><para>Forms</para>
	///<para>Value = 60</para></summary>
	[Description("Forms")]
	Forms = 60, 
	///<summary><para>Sitemap</para>
	///<para>Value = 62</para></summary>
	[Description("Sitemap")]
	Sitemap = 62
}
public enum eIncludeBehavior
{
	///<summary><para>Include Subcomponents</para>
	///<para>Value = 0</para></summary>
	[Description("Include Subcomponents")]
	IncludeSubcomponents = 0, 
	///<summary><para>Do not include subcomponents</para>
	///<para>Value = 1</para></summary>
	[Description("Do not include subcomponents")]
	DoNotIncludeSubcomponents = 1, 
	///<summary><para>Include As Shell Only</para>
	///<para>Value = 2</para></summary>
	[Description("Include As Shell Only")]
	IncludeAsShellOnly = 2
}


        public static class Properties
{
	/// <summary><para>createdonbehalfbyyominame</para>
	/// <para>createdonbehalfbyyominame</para></summary>
	public const string CreatedOnBehalfByYomiName = "createdonbehalfbyyominame";
	/// <summary><para>modifiedbyyominame</para>
	/// <para>modifiedbyyominame</para></summary>
	public const string ModifiedByYomiName = "modifiedbyyominame";
	/// <summary><para>createdbyyominame</para>
	/// <para>createdbyyominame</para></summary>
	public const string CreatedByYomiName = "createdbyyominame";
	/// <summary><para>modifiedbyname</para>
	/// <para>modifiedbyname</para></summary>
	public const string ModifiedByName = "modifiedbyname";
	/// <summary><para>versionnumber</para>
	/// <para>versionnumber</para></summary>
	public const string VersionNumber = "versionnumber";
	/// <summary><para>appmoduleidname</para>
	/// <para>appmoduleidname</para></summary>
	public const string AppModuleIdName = "appmoduleidname";
	/// <summary><para>modifiedonbehalfbyyominame</para>
	/// <para>modifiedonbehalfbyyominame</para></summary>
	public const string ModifiedOnBehalfByYomiName = "modifiedonbehalfbyyominame";
	/// <summary><para>createdbyname</para>
	/// <para>createdbyname</para></summary>
	public const string CreatedByName = "createdbyname";
	/// <summary><para>modifiedonbehalfbyname</para>
	/// <para>modifiedonbehalfbyname</para></summary>
	public const string ModifiedOnBehalfByName = "modifiedonbehalfbyname";
	/// <summary><para>createdonbehalfbyname</para>
	/// <para>createdonbehalfbyname</para></summary>
	public const string CreatedOnBehalfByName = "createdonbehalfbyname";
	/// <summary><para>App Module Component</para>
	/// <para>appmodulecomponentid</para></summary>
	public const string AppModuleComponentId = "appmodulecomponentid";
	/// <summary><para>Application Component Unique Id</para>
	/// <para>appmodulecomponentidunique</para></summary>
	public const string ApplicationComponentUniqueId = "appmodulecomponentidunique";
	/// <summary><para>AppModule</para>
	/// <para>appmoduleidunique</para></summary>
	public const string AppModule = "appmoduleidunique";
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
	/// <summary><para>ExchangeRate</para>
	/// <para>exchangerate</para></summary>
	public const string ExchangeRate = "exchangerate";
	/// <summary><para>Introduced Version</para>
	/// <para>introducedversion</para></summary>
	public const string IntroducedVersion = "introducedversion";
	/// <summary><para>Is Default</para>
	/// <para>isdefault</para></summary>
	public const string IsDefault = "isdefault";
	/// <summary><para>Is Metadata</para>
	/// <para>ismetadata</para></summary>
	public const string IsMetadata = "ismetadata";
	/// <summary><para>Modified By</para>
	/// <para>modifiedby</para></summary>
	public const string ModifiedBy = "modifiedby";
	/// <summary><para>Modified By (Delegate)</para>
	/// <para>modifiedonbehalfby</para></summary>
	public const string ModifiedBy_Delegate = "modifiedonbehalfby";
	/// <summary><para>Modified On</para>
	/// <para>modifiedon</para></summary>
	public const string ModifiedOn = "modifiedon";
	/// <summary><para>Object</para>
	/// <para>objectid</para></summary>
	public const string @Object = "objectid";
	/// <summary><para>Object Type Code</para>
	/// <para>componenttype</para></summary>
	public const string ObjectTypeCode2 = "componenttype";
	/// <summary><para>Root App Module Component</para>
	/// <para>rootappmodulecomponentid</para></summary>
	public const string RootAppModuleComponent = "rootappmodulecomponentid";
	/// <summary><para>Root Component Behavior</para>
	/// <para>rootcomponentbehavior</para></summary>
	public const string RootComponentBehavior = "rootcomponentbehavior";
	/// <summary><para>Time Zone Rule Version Number</para>
	/// <para>timezoneruleversionnumber</para></summary>
	public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
	/// <summary><para>UTC Conversion Time Zone Code</para>
	/// <para>utcconversiontimezonecode</para></summary>
	public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
}

    }
}
