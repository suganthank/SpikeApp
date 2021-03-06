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
    [EntityLogicalNameAttribute("appmodule")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XrmToolkit", "4.0")]
    public partial class App : BaseProxyClass
    {
        public new const string LogicalName = "appmodule";
        public const int ObjectTypeCode = 9006;
        public const string PrimaryIdAttribute = "appmoduleid";
        public const string PrimaryNameAttribute = "name";
        
        static App()
        {
            BaseProxyClass.RegisterProxyType(typeof(App), "appmodule");
            _textOptions = new Dictionary<string, eTextOptions>();
            _numberOptions = new Dictionary<string, eNumberOptions>();
            _errorStrings = new Dictionary<string, string>();
            TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
            NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
        }
        public App() : base(new Entity("appmodule")) { }
        public App(Entity original) : base(original) { }
        public static string GetLogicalName() { return BaseProxyClass.GetLogicalName<App>(); }
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
///<para>Logical Name: modifiedonbehalfbyname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("modifiedonbehalfbyname")]
public string ModifiedOnBehalfByName
{
	get { return this.GetPropertyValue<string>("modifiedonbehalfbyname"); }
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
///<para>Logical Name: appmodulexmlmanaged</para>
///<para>Max Length: 1073741823 characters</para>
///</summary>
[AttributeLogicalNameAttribute("appmodulexmlmanaged")]
public string AppModuleXmlManaged
{
	get { return this.GetPropertyValue<string>("appmodulexmlmanaged"); }
	set { this.SetPropertyValue("appmodulexmlmanaged", value, 1073741823, "AppModuleXmlManaged"); }
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
///<para>Logical Name: configxml</para>
///<para>Max Length: 1073741823 characters</para>
///</summary>
[AttributeLogicalNameAttribute("configxml")]
public string ConfigXML
{
	get { return this.GetPropertyValue<string>("configxml"); }
	set { this.SetPropertyValue("configxml", value, 1073741823, "ConfigXML"); }
}
///<summary>
///<para>Logical Name: appmoduleidunique</para>
///</summary>
[AttributeLogicalNameAttribute("appmoduleidunique")]
public Guid AppModuleUniqueId
{
	get { return this.GetPropertyValue<Guid>("appmoduleidunique"); }
	set { this.SetPropertyValue<Guid>("appmoduleidunique", value, "AppModuleUniqueId"); }
}
///<summary>
///<para>Logical Name: appmoduleversion</para>
///<para>Max Length: 48 characters</para>
///</summary>
[AttributeLogicalNameAttribute("appmoduleversion")]
public string AppModuleVersion
{
	get { return this.GetPropertyValue<string>("appmoduleversion"); }
	set { this.SetPropertyValue("appmoduleversion", value, 48, "AppModuleVersion"); }
}
///<summary>
///<para>Key Property (Uniqueidentifier)</para>
///<para>Logical Name: appmoduleid</para>
///</summary>
[AttributeLogicalNameAttribute("appmoduleid")]
public Guid AppModuleId
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
///<para>Logical Name: clienttype</para>
///<para>Minimum Value: 1</para>
///<para>Maximum Value: 8</para>
///</summary>
[AttributeLogicalNameAttribute("clienttype")]
public int? ClientType
{
	get { return this.GetPropertyValue<int?>("clienttype"); }
	set { this.SetPropertyValue("clienttype", (int?)value, (int)1, (int)8, "ClientType"); }
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
///<para>Logical Name: formfactor</para>
///<para>Minimum Value: 1</para>
///<para>Maximum Value: 8</para>
///</summary>
[AttributeLogicalNameAttribute("formfactor")]
public int? FormFactor
{
	get { return this.GetPropertyValue<int?>("formfactor"); }
	set { this.SetPropertyValue("formfactor", (int?)value, (int)1, (int)8, "FormFactor"); }
}
///<summary>
///<para>Logical Name: importsequencenumber</para>
///<para>Minimum Value: -2147483648</para>
///<para>Maximum Value: 2147483647</para>
///</summary>
[AttributeLogicalNameAttribute("importsequencenumber")]
public int? ImportSequenceNumber
{
	get { return this.GetPropertyValue<int?>("importsequencenumber"); }
	set { this.SetPropertyValue("importsequencenumber", (int?)value, (int)-2147483648, (int)2147483647, "ImportSequenceNumber"); }
}
///<summary>
///<para>Logical Name: introducedversion</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("introducedversion")]
public string IntroducedVersion
{
	get { return this.GetPropertyValue<string>("introducedversion"); }
	set { this.SetPropertyValue("introducedversion", value, 100, "IntroducedVersion"); }
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
///<para>Logical Name: isfeatured</para>
///<para>True = Yes</para>
///<para>False = No</para>
///</summary>
[AttributeLogicalNameAttribute("isfeatured")]
public bool? IsFeatured
{
	get { return this.GetPropertyValue<bool?>("isfeatured"); }
	set { this.SetPropertyValue<bool?>("isfeatured", value, "IsFeatured"); }
}
///<summary>
///<para>Logical Name: ismanaged</para>
///<para>True = Managed</para>
///<para>False = Unmanaged</para>
///</summary>
[AttributeLogicalNameAttribute("ismanaged")]
public bool? IsManaged
{
	get { return this.GetPropertyValue<bool?>("ismanaged"); }
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
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("name")]
public string Name
{
	get { return this.GetPropertyValue<string>("name"); }
	set { this.SetPropertyValue("name", value, 100, "Name"); }
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
///<para>Logical Name: overwritetime</para>
///</summary>
[AttributeLogicalNameAttribute("overwritetime")]
public DateTime? OverwriteTime
{
	get { return this.GetPropertyValue<DateTime?>("overwritetime"); }
}
///<summary>
///<para>Logical Name: publishedon</para>
///</summary>
[AttributeLogicalNameAttribute("publishedon")]
public DateTime? PublishedOn
{
	get { return this.GetPropertyValue<DateTime?>("publishedon"); }
	set { this.SetPropertyValue<DateTime?>("publishedon", value, "PublishedOn"); }
}
///<summary>
///<para>Logical Name: publisherid</para>
///</summary>
[AttributeLogicalNameAttribute("publisherid")]
public EntityReference Publisher
{
	get { return this.GetPropertyValue<EntityReference>("publisherid"); }
	set { this.SetPropertyValue<EntityReference>("publisherid", value, "Publisher"); }
}
///<summary>
///<para>Logical Name: publisheridname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("publisheridname")]
public string Publisher2
{
	get { return this.GetPropertyValue<string>("publisheridname"); }
}
///<summary>
///<para>Logical Name: overriddencreatedon</para>
///</summary>
[AttributeLogicalNameAttribute("overriddencreatedon")]
public DateTime? RecordCreatedOn
{
	get { return this.GetPropertyValue<DateTime?>("overriddencreatedon"); }
	set { this.SetPropertyValue<DateTime?>("overriddencreatedon", value, "RecordCreatedOn"); }
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
///<summary>
///<para>Logical Name: uniquename</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("uniquename")]
public string UniqueName
{
	get { return this.GetPropertyValue<string>("uniquename"); }
	set { this.SetPropertyValue("uniquename", value, 100, "UniqueName"); }
}
///<summary>
///<para>Logical Name: url</para>
///<para>Max Length: 200 characters</para>
///</summary>
[AttributeLogicalNameAttribute("url")]
public string URL
{
	get { return this.GetPropertyValue<string>("url"); }
	set { this.SetPropertyValue("url", value, 200, "URL"); }
}
///<summary>
///<para>Logical Name: webresourceid</para>
///</summary>
[AttributeLogicalNameAttribute("webresourceid")]
public Guid WebResourceId
{
	get { return this.GetPropertyValue<Guid>("webresourceid"); }
	set { this.SetPropertyValue<Guid>("webresourceid", value, "WebResourceId"); }
}


        /// <summary>
/// <para><b>AppModuleComponent (AppModule)</b></para>
/// <para>Schema Name: appmodule_appmodulecomponent</para>
/// </summary>
public List<AppModuleComponent> GetAppModuleComponents_AppModule (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<AppModuleComponent>(Service, this.Id, "appmodulecomponent", "appmoduleidunique", Columns); }
/// <summary>
/// <para><b>AppModuleComponent (AppModule)</b></para>
/// <para>Schema Name: appmodule_appmodulecomponent</para>
/// </summary>
public List<AppModuleComponent> GetAppModuleComponents_AppModule (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<AppModuleComponent>(Service, this.Id, "appmodulecomponent", "appmoduleidunique", Columns); }


        /// <summary>
/// <para>Related Entity: <b>Security Role</b></para>
/// <para>N:N Relationship</para>
/// <para>Schema Name: appmoduleroles_association</para>
/// </summary>
public List<SecurityRole> GetSecurityRoles (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedManyToManyEntities<SecurityRole>(Service, this, "appmodule", "appmoduleid", "role", "roleid", "appmoduleroles", "appmoduleid", "roleid", Columns); }
public List<SecurityRole> GetSecurityRoles (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedManyToManyEntities<SecurityRole>(Service, this, "appmodule", "appmoduleid", "role", "roleid", "appmoduleroles", "appmoduleid", "roleid", Columns); }
public void RelateSecurityRoles (IOrganizationService Service, params Entity[] Items) { Service.RelateEntities(this, "appmoduleroles_association", Items); }
public void RelateSecurityRoles (IOrganizationService Service, params EntityReference[] Items) { Service.RelateEntities(this, "appmoduleroles_association", Items); }
public void UnRelateSecurityRoles (IOrganizationService Service, params Entity[] Items) { Service.UnRelateEntities(this, "appmoduleroles_association", Items); }
public void UnRelateSecurityRoles (IOrganizationService Service, params EntityReference[] Items) { Service.UnRelateEntities(this, "appmoduleroles_association", Items); }


        

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


        public static class Properties
{
	/// <summary><para>createdonbehalfbyyominame</para>
	/// <para>createdonbehalfbyyominame</para></summary>
	public const string CreatedOnBehalfByYomiName = "createdonbehalfbyyominame";
	/// <summary><para>modifiedonbehalfbyname</para>
	/// <para>modifiedonbehalfbyname</para></summary>
	public const string ModifiedOnBehalfByName = "modifiedonbehalfbyname";
	/// <summary><para>modifiedbyname</para>
	/// <para>modifiedbyname</para></summary>
	public const string ModifiedByName = "modifiedbyname";
	/// <summary><para>versionnumber</para>
	/// <para>versionnumber</para></summary>
	public const string VersionNumber = "versionnumber";
	/// <summary><para>appmodulexmlmanaged</para>
	/// <para>appmodulexmlmanaged</para></summary>
	public const string AppModuleXmlManaged = "appmodulexmlmanaged";
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
	/// <summary><para>configxml</para>
	/// <para>configxml</para></summary>
	public const string ConfigXML = "configxml";
	/// <summary><para>App Module Unique Id</para>
	/// <para>appmoduleidunique</para></summary>
	public const string AppModuleUniqueId = "appmoduleidunique";
	/// <summary><para>App Module Version</para>
	/// <para>appmoduleversion</para></summary>
	public const string AppModuleVersion = "appmoduleversion";
	/// <summary><para>AppModuleId</para>
	/// <para>appmoduleid</para></summary>
	public const string AppModuleId = "appmoduleid";
	/// <summary><para>Client Type</para>
	/// <para>clienttype</para></summary>
	public const string ClientType = "clienttype";
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
	/// <para>createdon</para></summary>
	public const string CreatedOn = "createdon";
	/// <summary><para>Description</para>
	/// <para>description</para></summary>
	public const string Description = "description";
	/// <summary><para>Form Factor</para>
	/// <para>formfactor</para></summary>
	public const string FormFactor = "formfactor";
	/// <summary><para>Import Sequence Number</para>
	/// <para>importsequencenumber</para></summary>
	public const string ImportSequenceNumber = "importsequencenumber";
	/// <summary><para>Introduced Version</para>
	/// <para>introducedversion</para></summary>
	public const string IntroducedVersion = "introducedversion";
	/// <summary><para>Is Default</para>
	/// <para>isdefault</para></summary>
	public const string IsDefault = "isdefault";
	/// <summary><para>IsFeatured</para>
	/// <para>isfeatured</para></summary>
	public const string IsFeatured = "isfeatured";
	/// <summary><para>IsManaged</para>
	/// <para>ismanaged</para></summary>
	public const string IsManaged = "ismanaged";
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
	/// <summary><para>Overwrite Time</para>
	/// <para>overwritetime</para></summary>
	public const string OverwriteTime = "overwritetime";
	/// <summary><para>Published On</para>
	/// <para>publishedon</para></summary>
	public const string PublishedOn = "publishedon";
	/// <summary><para>Publisher</para>
	/// <para>publisherid</para></summary>
	public const string Publisher = "publisherid";
	/// <summary><para>Publisher</para>
	/// <para>publisheridname</para></summary>
	public const string Publisher2 = "publisheridname";
	/// <summary><para>Record Created On</para>
	/// <para>overriddencreatedon</para></summary>
	public const string RecordCreatedOn = "overriddencreatedon";
	/// <summary><para>Solution</para>
	/// <para>supportingsolutionid</para></summary>
	public const string Solution = "supportingsolutionid";
	/// <summary><para>Solution</para>
	/// <para>solutionid</para></summary>
	public const string Solution2 = "solutionid";
	/// <summary><para>Unique Name</para>
	/// <para>uniquename</para></summary>
	public const string UniqueName = "uniquename";
	/// <summary><para>URL</para>
	/// <para>url</para></summary>
	public const string URL = "url";
	/// <summary><para>Web Resource Id</para>
	/// <para>webresourceid</para></summary>
	public const string WebResourceId = "webresourceid";
}

    }
}
