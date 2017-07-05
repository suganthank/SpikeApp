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
    [EntityLogicalNameAttribute("ribboncommand")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XrmToolkit", "4.0")]
    public partial class RibbonCommand : BaseProxyClass
    {
        public new const string LogicalName = "ribboncommand";
        public const int ObjectTypeCode = 1116;
        public const string PrimaryIdAttribute = "ribboncommandid";
        public const string PrimaryNameAttribute = "";
        
        static RibbonCommand()
        {
            BaseProxyClass.RegisterProxyType(typeof(RibbonCommand), "ribboncommand");
            _textOptions = new Dictionary<string, eTextOptions>();
            _numberOptions = new Dictionary<string, eNumberOptions>();
            _errorStrings = new Dictionary<string, string>();
            TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
            NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
        }
        public RibbonCommand() : base(new Entity("ribboncommand")) { }
        public RibbonCommand(Entity original) : base(original) { }
        public static string GetLogicalName() { return BaseProxyClass.GetLogicalName<RibbonCommand>(); }
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
///<para>Logical Name: organizationid</para>
///</summary>
[AttributeLogicalNameAttribute("organizationid")]
public EntityReference OrganizationId
{
	get { return this.GetPropertyValue<EntityReference>("organizationid"); }
}
///<summary>
///<para>Logical Name: commanddefinition</para>
///<para>Max Length: 10000 characters</para>
///</summary>
[AttributeLogicalNameAttribute("commanddefinition")]
public string CommandDefinition
{
	get { return this.GetPropertyValue<string>("commanddefinition"); }
	set { this.SetPropertyValue("commanddefinition", value, 10000, "CommandDefinition"); }
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
///<para>Logical Name: ribboncommanduniqueid</para>
///</summary>
[AttributeLogicalNameAttribute("ribboncommanduniqueid")]
public Guid RibbonCommandUniqueId
{
	get { return this.GetPropertyValue<Guid>("ribboncommanduniqueid"); }
}
///<summary>
///<para>Logical Name: command</para>
///<para>Max Length: 200 characters</para>
///</summary>
[AttributeLogicalNameAttribute("command")]
public string Command
{
	get { return this.GetPropertyValue<string>("command"); }
	set { this.SetPropertyValue("command", value, 200, "Command"); }
}
///<summary>
///<para>Logical Name: entity</para>
///<para>Max Length: 50 characters</para>
///</summary>
[AttributeLogicalNameAttribute("entity")]
public string Entity
{
	get { return this.GetPropertyValue<string>("entity"); }
	set { this.SetPropertyValue("entity", value, 50, "Entity"); }
}
///<summary>
///<para>Logical Name: ribboncustomizationid</para>
///</summary>
[AttributeLogicalNameAttribute("ribboncustomizationid")]
public EntityReference RibbonCustomizationId
{
	get { return this.GetPropertyValue<EntityReference>("ribboncustomizationid"); }
	set { this.SetPropertyValue<EntityReference>("ribboncustomizationid", value, "RibbonCustomizationId"); }
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
///<para>Key Property (Uniqueidentifier)</para>
///<para>Logical Name: ribboncommandid</para>
///</summary>
[AttributeLogicalNameAttribute("ribboncommandid")]
public Guid PrimaryKeyId
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
///<para>Logical Name: overwritetime</para>
///</summary>
[AttributeLogicalNameAttribute("overwritetime")]
public DateTime? RecordOverwriteTime
{
	get { return this.GetPropertyValue<DateTime?>("overwritetime"); }
}
///<summary>
///<para>Logical Name: solutionid</para>
///</summary>
[AttributeLogicalNameAttribute("solutionid")]
public Guid Solution
{
	get { return this.GetPropertyValue<Guid>("solutionid"); }
}
///<summary>
///<para>Logical Name: supportingsolutionid</para>
///</summary>
[AttributeLogicalNameAttribute("supportingsolutionid")]
public Guid Solution2
{
	get { return this.GetPropertyValue<Guid>("supportingsolutionid"); }
}


        /// <summary>
/// <para><b>UserEntityInstanceData (Object Id)</b></para>
/// <para>Schema Name: userentityinstancedata_ribboncommand</para>
/// </summary>
public List<UserEntityInstanceData> GetUserEntityInstanceData_ObjectId (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<UserEntityInstanceData>(Service, this.Id, "userentityinstancedata", "objectid", Columns); }
/// <summary>
/// <para><b>UserEntityInstanceData (Object Id)</b></para>
/// <para>Schema Name: userentityinstancedata_ribboncommand</para>
/// </summary>
public List<UserEntityInstanceData> GetUserEntityInstanceData_ObjectId (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<UserEntityInstanceData>(Service, this.Id, "userentityinstancedata", "objectid", Columns); }


        

        

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
	/// <summary><para>organizationid</para>
	/// <para>organizationid</para></summary>
	public const string OrganizationId = "organizationid";
	/// <summary><para>commanddefinition</para>
	/// <para>commanddefinition</para></summary>
	public const string CommandDefinition = "commanddefinition";
	/// <summary><para>versionnumber</para>
	/// <para>versionnumber</para></summary>
	public const string VersionNumber = "versionnumber";
	/// <summary><para>ribboncommanduniqueid</para>
	/// <para>ribboncommanduniqueid</para></summary>
	public const string RibbonCommandUniqueId = "ribboncommanduniqueid";
	/// <summary><para>command</para>
	/// <para>command</para></summary>
	public const string Command = "command";
	/// <summary><para>entity</para>
	/// <para>entity</para></summary>
	public const string Entity = "entity";
	/// <summary><para>ribboncustomizationid</para>
	/// <para>ribboncustomizationid</para></summary>
	public const string RibbonCustomizationId = "ribboncustomizationid";
	/// <summary><para>ismanaged</para>
	/// <para>ismanaged</para></summary>
	public const string IsManaged = "ismanaged";
	/// <summary><para>Component State</para>
	/// <para>componentstate</para></summary>
	public const string ComponentState = "componentstate";
	/// <summary><para>Primary Key</para>
	/// <para>ribboncommandid</para></summary>
	public const string PrimaryKeyId = "ribboncommandid";
	/// <summary><para>Record Overwrite Time</para>
	/// <para>overwritetime</para></summary>
	public const string RecordOverwriteTime = "overwritetime";
	/// <summary><para>Solution</para>
	/// <para>solutionid</para></summary>
	public const string Solution = "solutionid";
	/// <summary><para>Solution</para>
	/// <para>supportingsolutionid</para></summary>
	public const string Solution2 = "supportingsolutionid";
}

    }
}