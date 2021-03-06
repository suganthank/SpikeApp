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
    [EntityLogicalNameAttribute("organizationui")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XrmToolkit", "4.0")]
    public partial class OrganizationUI : BaseProxyClass
    {
        public new const string LogicalName = "organizationui";
        public const int ObjectTypeCode = 1021;
        public const string PrimaryIdAttribute = "formid";
        public const string PrimaryNameAttribute = "";
        
        static OrganizationUI()
        {
            BaseProxyClass.RegisterProxyType(typeof(OrganizationUI), "organizationui");
            _textOptions = new Dictionary<string, eTextOptions>();
            _numberOptions = new Dictionary<string, eNumberOptions>();
            _errorStrings = new Dictionary<string, string>();
            TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
            NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
        }
        public OrganizationUI() : base(new Entity("organizationui")) { }
        public OrganizationUI(Entity original) : base(original) { }
        public static string GetLogicalName() { return BaseProxyClass.GetLogicalName<OrganizationUI>(); }
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
///<para>Key Property (Uniqueidentifier)</para>
///<para>Logical Name: formid</para>
///</summary>
[AttributeLogicalNameAttribute("formid")]
public Guid FormId
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
///<para>Logical Name: organizationid</para>
///</summary>
[AttributeLogicalNameAttribute("organizationid")]
public EntityReference OrganizationId
{
	get { return this.GetPropertyValue<EntityReference>("organizationid"); }
}
///<summary>
///<para>Logical Name: formidunique</para>
///</summary>
[AttributeLogicalNameAttribute("formidunique")]
public Guid FormIdUnique
{
	get { return this.GetPropertyValue<Guid>("formidunique"); }
}
///<summary>
///<para>Logical Name: previewcolumnsetxml</para>
///<para>Max Length: 1073741823 characters</para>
///</summary>
[AttributeLogicalNameAttribute("previewcolumnsetxml")]
public string PreviewColumnsetXml
{
	get { return this.GetPropertyValue<string>("previewcolumnsetxml"); }
	set { this.SetPropertyValue("previewcolumnsetxml", value, 1073741823, "PreviewColumnsetXml"); }
}
///<summary>
///<para>Logical Name: version</para>
///<para>Minimum Value: 0</para>
///<para>Maximum Value: 2147483647</para>
///</summary>
[AttributeLogicalNameAttribute("version")]
public int? Version
{
	get { return this.GetPropertyValue<int?>("version"); }
	set { this.SetPropertyValue("version", (int?)value, (int)0, (int)2147483647, "Version"); }
}
///<summary>
///<para>Logical Name: fieldxml</para>
///<para>Max Length: 1073741823 characters</para>
///</summary>
[AttributeLogicalNameAttribute("fieldxml")]
public string FieldXml
{
	get { return this.GetPropertyValue<string>("fieldxml"); }
	set { this.SetPropertyValue("fieldxml", value, 1073741823, "FieldXml"); }
}
///<summary>
///<para>Logical Name: formxml</para>
///<para>Max Length: 1073741823 characters</para>
///</summary>
[AttributeLogicalNameAttribute("formxml")]
public string FormXml
{
	get { return this.GetPropertyValue<string>("formxml"); }
	set { this.SetPropertyValue("formxml", value, 1073741823, "FormXml"); }
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
///<para>Logical Name: organizationidname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("organizationidname")]
public string OrganizationIdName
{
	get { return this.GetPropertyValue<string>("organizationidname"); }
}
///<summary>
///<para>Logical Name: gridicon</para>
///<para>Max Length: 1073741823 characters</para>
///</summary>
[AttributeLogicalNameAttribute("gridicon")]
public string GridIcon
{
	get { return this.GetPropertyValue<string>("gridicon"); }
	set { this.SetPropertyValue("gridicon", value, 1073741823, "GridIcon"); }
}
///<summary>
///<para>Logical Name: objecttypecode</para>
///</summary>
[AttributeLogicalNameAttribute("objecttypecode")]
public string ObjectTypeCode2
{
	get { return this.GetPropertyValue<string>("objecttypecode"); }
	set { this.SetPropertyValue<string>("objecttypecode", value, "ObjectTypeCode2"); }
}
///<summary>
///<para>Logical Name: outlookshortcuticon</para>
///<para>Max Length: 1073741823 characters</para>
///</summary>
[AttributeLogicalNameAttribute("outlookshortcuticon")]
public string OutlookShortcutIcon
{
	get { return this.GetPropertyValue<string>("outlookshortcuticon"); }
	set { this.SetPropertyValue("outlookshortcuticon", value, 1073741823, "OutlookShortcutIcon"); }
}
///<summary>
///<para>Logical Name: largeentityicon</para>
///<para>Max Length: 1073741823 characters</para>
///</summary>
[AttributeLogicalNameAttribute("largeentityicon")]
public string LargeEntityIcon
{
	get { return this.GetPropertyValue<string>("largeentityicon"); }
	set { this.SetPropertyValue("largeentityicon", value, 1073741823, "LargeEntityIcon"); }
}
///<summary>
///<para>Logical Name: previewxml</para>
///<para>Max Length: 1073741823 characters</para>
///</summary>
[AttributeLogicalNameAttribute("previewxml")]
public string PreviewXml
{
	get { return this.GetPropertyValue<string>("previewxml"); }
	set { this.SetPropertyValue("previewxml", value, 1073741823, "PreviewXml"); }
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
///<para>Logical Name: iscustomizable</para>
///</summary>
[AttributeLogicalNameAttribute("iscustomizable")]
public BooleanManagedProperty Customizable
{
	get { return this.GetPropertyValue<BooleanManagedProperty>("iscustomizable"); }
	set { this.SetPropertyValue<BooleanManagedProperty>("iscustomizable", value, "Customizable"); }
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
	/// <summary><para>formid</para>
	/// <para>formid</para></summary>
	public const string FormId = "formid";
	/// <summary><para>organizationid</para>
	/// <para>organizationid</para></summary>
	public const string OrganizationId = "organizationid";
	/// <summary><para>formidunique</para>
	/// <para>formidunique</para></summary>
	public const string FormIdUnique = "formidunique";
	/// <summary><para>previewcolumnsetxml</para>
	/// <para>previewcolumnsetxml</para></summary>
	public const string PreviewColumnsetXml = "previewcolumnsetxml";
	/// <summary><para>version</para>
	/// <para>version</para></summary>
	public const string Version = "version";
	/// <summary><para>fieldxml</para>
	/// <para>fieldxml</para></summary>
	public const string FieldXml = "fieldxml";
	/// <summary><para>formxml</para>
	/// <para>formxml</para></summary>
	public const string FormXml = "formxml";
	/// <summary><para>versionnumber</para>
	/// <para>versionnumber</para></summary>
	public const string VersionNumber = "versionnumber";
	/// <summary><para>organizationidname</para>
	/// <para>organizationidname</para></summary>
	public const string OrganizationIdName = "organizationidname";
	/// <summary><para>gridicon</para>
	/// <para>gridicon</para></summary>
	public const string GridIcon = "gridicon";
	/// <summary><para>objecttypecode</para>
	/// <para>objecttypecode</para></summary>
	public const string ObjectTypeCode2 = "objecttypecode";
	/// <summary><para>outlookshortcuticon</para>
	/// <para>outlookshortcuticon</para></summary>
	public const string OutlookShortcutIcon = "outlookshortcuticon";
	/// <summary><para>largeentityicon</para>
	/// <para>largeentityicon</para></summary>
	public const string LargeEntityIcon = "largeentityicon";
	/// <summary><para>previewxml</para>
	/// <para>previewxml</para></summary>
	public const string PreviewXml = "previewxml";
	/// <summary><para>ismanaged</para>
	/// <para>ismanaged</para></summary>
	public const string IsManaged = "ismanaged";
	/// <summary><para>Component State</para>
	/// <para>componentstate</para></summary>
	public const string ComponentState = "componentstate";
	/// <summary><para>Customizable</para>
	/// <para>iscustomizable</para></summary>
	public const string Customizable = "iscustomizable";
	/// <summary><para>Record Overwrite Time</para>
	/// <para>overwritetime</para></summary>
	public const string RecordOverwriteTime = "overwritetime";
	/// <summary><para>Solution</para>
	/// <para>supportingsolutionid</para></summary>
	public const string Solution = "supportingsolutionid";
	/// <summary><para>Solution</para>
	/// <para>solutionid</para></summary>
	public const string Solution2 = "solutionid";
}

    }
}
