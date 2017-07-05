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
    [EntityLogicalNameAttribute("workflowdependency")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XrmToolkit", "4.0")]
    public partial class ProcessDependency : BaseProxyClass
    {
        public new const string LogicalName = "workflowdependency";
        public const int ObjectTypeCode = 4704;
        public const string PrimaryIdAttribute = "workflowdependencyid";
        public const string PrimaryNameAttribute = "";
        
        static ProcessDependency()
        {
            BaseProxyClass.RegisterProxyType(typeof(ProcessDependency), "workflowdependency");
            _textOptions = new Dictionary<string, eTextOptions>();
            _numberOptions = new Dictionary<string, eNumberOptions>();
            _errorStrings = new Dictionary<string, string>();
            TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
            NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
        }
        public ProcessDependency() : base(new Entity("workflowdependency")) { }
        public ProcessDependency(Entity original) : base(original) { }
        public static string GetLogicalName() { return BaseProxyClass.GetLogicalName<ProcessDependency>(); }
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
///<para>Logical Name: modifiedbyyominame</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("modifiedbyyominame")]
public string ModifiedByYomiName
{
	get { return this.GetPropertyValue<string>("modifiedbyyominame"); }
}
///<summary>
///<para>Logical Name: relatedattributename</para>
///<para>Max Length: 256 characters</para>
///</summary>
[AttributeLogicalNameAttribute("relatedattributename")]
public string RelatedAttributeName
{
	get { return this.GetPropertyValue<string>("relatedattributename"); }
	set { this.SetPropertyValue("relatedattributename", value, 256, "RelatedAttributeName"); }
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
///<para>Logical Name: createdbyyominame</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("createdbyyominame")]
public string CreatedByYomiName
{
	get { return this.GetPropertyValue<string>("createdbyyominame"); }
}
///<summary>
///<para>Logical Name: sdkmessageid</para>
///</summary>
[AttributeLogicalNameAttribute("sdkmessageid")]
public EntityReference SdkMessageId
{
	get { return this.GetPropertyValue<EntityReference>("sdkmessageid"); }
	set { this.SetPropertyValue<EntityReference>("sdkmessageid", value, "SdkMessageId"); }
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
///<para>Logical Name: entityattributes</para>
///<para>Max Length: 100000 characters</para>
///</summary>
[AttributeLogicalNameAttribute("entityattributes")]
public string EntityAttributes
{
	get { return this.GetPropertyValue<string>("entityattributes"); }
	set { this.SetPropertyValue("entityattributes", value, 100000, "EntityAttributes"); }
}
///<summary>
///<para>Logical Name: parametername</para>
///<para>Max Length: 256 characters</para>
///</summary>
[AttributeLogicalNameAttribute("parametername")]
public string ParameterName
{
	get { return this.GetPropertyValue<string>("parametername"); }
	set { this.SetPropertyValue("parametername", value, 256, "ParameterName"); }
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
///<para>Logical Name: parametertype</para>
///<para>Max Length: 256 characters</para>
///</summary>
[AttributeLogicalNameAttribute("parametertype")]
public string ParameterType
{
	get { return this.GetPropertyValue<string>("parametertype"); }
	set { this.SetPropertyValue("parametertype", value, 256, "ParameterType"); }
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
///<para>Logical Name: customentityname</para>
///<para>Max Length: 50 characters</para>
///</summary>
[AttributeLogicalNameAttribute("customentityname")]
public string CustomEntity
{
	get { return this.GetPropertyValue<string>("customentityname"); }
	set { this.SetPropertyValue("customentityname", value, 50, "CustomEntity"); }
}
///<summary>
///<para>Logical Name: dependentattributename</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("dependentattributename")]
public string DependentAttributeName
{
	get { return this.GetPropertyValue<string>("dependentattributename"); }
	set { this.SetPropertyValue("dependentattributename", value, 100, "DependentAttributeName"); }
}
///<summary>
///<para>Logical Name: dependententityname</para>
///<para>Max Length: 50 characters</para>
///</summary>
[AttributeLogicalNameAttribute("dependententityname")]
public string DependentEntityName
{
	get { return this.GetPropertyValue<string>("dependententityname"); }
	set { this.SetPropertyValue("dependententityname", value, 50, "DependentEntityName"); }
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
///<para>Logical Name: ownerid</para>
///</summary>
[AttributeLogicalNameAttribute("ownerid")]
public EntityReference Owner
{
	get { return this.GetPropertyValue<EntityReference>("ownerid"); }
}
///<summary>
///<para>Logical Name: workflowid</para>
///</summary>
[AttributeLogicalNameAttribute("workflowid")]
public EntityReference Process
{
	get { return this.GetPropertyValue<EntityReference>("workflowid"); }
	set { this.SetPropertyValue<EntityReference>("workflowid", value, "Process"); }
}
///<summary>
///<para>Key Property (Uniqueidentifier)</para>
///<para>Logical Name: workflowdependencyid</para>
///</summary>
[AttributeLogicalNameAttribute("workflowdependencyid")]
public Guid ProcessDependencyId
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
///<para>Logical Name: relatedentityname</para>
///<para>Max Length: 50 characters</para>
///</summary>
[AttributeLogicalNameAttribute("relatedentityname")]
public string RelatedEntity
{
	get { return this.GetPropertyValue<string>("relatedentityname"); }
	set { this.SetPropertyValue("relatedentityname", value, 50, "RelatedEntity"); }
}
/// <summary>
///Logical Name: type
/// </summary>
[AttributeLogicalNameAttribute("type")]
public eType? Type
{
	get
	{
		if (Type_OptionSetValue != null) { return (eType)Type_OptionSetValue.Value; }
		return null;
	}
	set
	{
		if (value != null) { this.Type_OptionSetValue = new OptionSetValue((int)value); }
		else this.Type_OptionSetValue = null;
	}
}
///<summary>
///<para>Logical Name: type</para>
///</summary>
[AttributeLogicalNameAttribute("type")]
public OptionSetValue Type_OptionSetValue
{
	get { return this.GetPropertyValue<OptionSetValue>("type"); }
	set { this.SetPropertyValue<OptionSetValue>("type", value, "Type_OptionSetValue"); }
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="Service">CRM Organization Service</param>
/// <returns></returns>
public string Type_Text(IOrganizationService Service)
{
	return this.Type_OptionSetValue.GetOptionSetText(Service, this, "type");
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="AttributeMetadata">The attribute metadata previously retrieved using the 'GetAttributeMetadata' extension method on the IOrganizationService object.</param>
/// <returns></returns>
public string Type_Text(EnumAttributeMetadata AttributeMetadata)
{
	return AttributeMetadata.GetOptionSetText(this.Type_OptionSetValue.Value);
}


        /// <summary>
/// <para><b>UserEntityInstanceData (Object Id)</b></para>
/// <para>Schema Name: userentityinstancedata_workflowdependency</para>
/// </summary>
public List<UserEntityInstanceData> GetUserEntityInstanceData_ObjectId (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<UserEntityInstanceData>(Service, this.Id, "userentityinstancedata", "objectid", Columns); }
/// <summary>
/// <para><b>UserEntityInstanceData (Object Id)</b></para>
/// <para>Schema Name: userentityinstancedata_workflowdependency</para>
/// </summary>
public List<UserEntityInstanceData> GetUserEntityInstanceData_ObjectId (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<UserEntityInstanceData>(Service, this.Id, "userentityinstancedata", "objectid", Columns); }


        

        

        public enum eType
{
	///<summary><para>Sdk association</para>
	///<para>Value = 1</para></summary>
	[Description("Sdk association")]
	SdkAssociation = 1, 
	///<summary><para>Local parameter</para>
	///<para>Value = 2</para></summary>
	[Description("Local parameter")]
	LocalParameter = 2, 
	///<summary><para>Primary entity</para>
	///<para>Value = 3</para></summary>
	[Description("Primary entity")]
	PrimaryEntity = 3, 
	///<summary><para>Primary entity - before SDK operation</para>
	///<para>Value = 4</para></summary>
	[Description("Primary entity - before SDK operation")]
	PrimaryEntity_BeforeSDKOperation = 4, 
	///<summary><para>Primary entity - after SDK operation</para>
	///<para>Value = 5</para></summary>
	[Description("Primary entity - after SDK operation")]
	PrimaryEntity_AfterSDKOperation = 5, 
	///<summary><para>Related entity</para>
	///<para>Value = 6</para></summary>
	[Description("Related entity")]
	RelatedEntity = 6, 
	///<summary><para>Custom entity definition that workflow depends on</para>
	///<para>Value = 7</para></summary>
	[Description("Custom entity definition that workflow depends on")]
	CustomEntityDefinitionThatWorkflowDependsOn = 7, 
	///<summary><para>Attribute definition that workflow depends on</para>
	///<para>Value = 8</para></summary>
	[Description("Attribute definition that workflow depends on")]
	AttributeDefinitionThatWorkflowDependsOn = 8, 
	///<summary><para>Argument Entity that workflow depends on</para>
	///<para>Value = 9</para></summary>
	[Description("Argument Entity that workflow depends on")]
	ArgumentEntityThatWorkflowDependsOn = 9
}


        public static class Properties
{
	/// <summary><para>createdonbehalfbyyominame</para>
	/// <para>createdonbehalfbyyominame</para></summary>
	public const string CreatedOnBehalfByYomiName = "createdonbehalfbyyominame";
	/// <summary><para>owninguser</para>
	/// <para>owninguser</para></summary>
	public const string OwningUser = "owninguser";
	/// <summary><para>modifiedbyyominame</para>
	/// <para>modifiedbyyominame</para></summary>
	public const string ModifiedByYomiName = "modifiedbyyominame";
	/// <summary><para>relatedattributename</para>
	/// <para>relatedattributename</para></summary>
	public const string RelatedAttributeName = "relatedattributename";
	/// <summary><para>modifiedbyname</para>
	/// <para>modifiedbyname</para></summary>
	public const string ModifiedByName = "modifiedbyname";
	/// <summary><para>versionnumber</para>
	/// <para>versionnumber</para></summary>
	public const string VersionNumber = "versionnumber";
	/// <summary><para>createdbyyominame</para>
	/// <para>createdbyyominame</para></summary>
	public const string CreatedByYomiName = "createdbyyominame";
	/// <summary><para>sdkmessageid</para>
	/// <para>sdkmessageid</para></summary>
	public const string SdkMessageId = "sdkmessageid";
	/// <summary><para>owneridtype</para>
	/// <para>owneridtype</para></summary>
	public const string OwnerIdType = "owneridtype";
	/// <summary><para>entityattributes</para>
	/// <para>entityattributes</para></summary>
	public const string EntityAttributes = "entityattributes";
	/// <summary><para>parametername</para>
	/// <para>parametername</para></summary>
	public const string ParameterName = "parametername";
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
	/// <summary><para>parametertype</para>
	/// <para>parametertype</para></summary>
	public const string ParameterType = "parametertype";
	/// <summary><para>owningbusinessunit</para>
	/// <para>owningbusinessunit</para></summary>
	public const string OwningBusinessUnit = "owningbusinessunit";
	/// <summary><para>Created By</para>
	/// <para>createdby</para></summary>
	public const string CreatedBy = "createdby";
	/// <summary><para>Created By (Delegate)</para>
	/// <para>createdonbehalfby</para></summary>
	public const string CreatedBy_Delegate = "createdonbehalfby";
	/// <summary><para>Created On</para>
	/// <para>createdon</para></summary>
	public const string CreatedOn = "createdon";
	/// <summary><para>Custom Entity</para>
	/// <para>customentityname</para></summary>
	public const string CustomEntity = "customentityname";
	/// <summary><para>Dependent Attribute Name</para>
	/// <para>dependentattributename</para></summary>
	public const string DependentAttributeName = "dependentattributename";
	/// <summary><para>Dependent Entity Name</para>
	/// <para>dependententityname</para></summary>
	public const string DependentEntityName = "dependententityname";
	/// <summary><para>Modified By</para>
	/// <para>modifiedby</para></summary>
	public const string ModifiedBy = "modifiedby";
	/// <summary><para>Modified By (Delegate)</para>
	/// <para>modifiedonbehalfby</para></summary>
	public const string ModifiedBy_Delegate = "modifiedonbehalfby";
	/// <summary><para>Modified On</para>
	/// <para>modifiedon</para></summary>
	public const string ModifiedOn = "modifiedon";
	/// <summary><para>Owner</para>
	/// <para>ownerid</para></summary>
	public const string Owner = "ownerid";
	/// <summary><para>Process</para>
	/// <para>workflowid</para></summary>
	public const string Process = "workflowid";
	/// <summary><para>Process Dependency</para>
	/// <para>workflowdependencyid</para></summary>
	public const string ProcessDependencyId = "workflowdependencyid";
	/// <summary><para>Related Entity</para>
	/// <para>relatedentityname</para></summary>
	public const string RelatedEntity = "relatedentityname";
	/// <summary><para>Type</para>
	/// <para>type</para></summary>
	public const string Type = "type";
}

    }
}