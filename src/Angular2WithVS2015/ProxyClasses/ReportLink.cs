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
    [EntityLogicalNameAttribute("reportlink")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XrmToolkit", "4.0")]
    public partial class ReportLink : BaseProxyClass
    {
        public new const string LogicalName = "reportlink";
        public const int ObjectTypeCode = 9104;
        public const string PrimaryIdAttribute = "reportlinkid";
        public const string PrimaryNameAttribute = "";
        
        static ReportLink()
        {
            BaseProxyClass.RegisterProxyType(typeof(ReportLink), "reportlink");
            _textOptions = new Dictionary<string, eTextOptions>();
            _numberOptions = new Dictionary<string, eNumberOptions>();
            _errorStrings = new Dictionary<string, string>();
            TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
            NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
        }
        public ReportLink() : base(new Entity("reportlink")) { }
        public ReportLink(Entity original) : base(original) { }
        public static string GetLogicalName() { return BaseProxyClass.GetLogicalName<ReportLink>(); }
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
///<para>Logical Name: modifiedbyyominame</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("modifiedbyyominame")]
public string ModifiedByYomiName
{
	get { return this.GetPropertyValue<string>("modifiedbyyominame"); }
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
///<para>Logical Name: reportlinkidunique</para>
///</summary>
[AttributeLogicalNameAttribute("reportlinkidunique")]
public Guid ReportLinkIdUnique
{
	get { return this.GetPropertyValue<Guid>("reportlinkidunique"); }
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
/// <summary>
///Logical Name: linktypecode
/// </summary>
[AttributeLogicalNameAttribute("linktypecode")]
public eLinkType? LinkType
{
	get
	{
		if (LinkType_OptionSetValue != null) { return (eLinkType)LinkType_OptionSetValue.Value; }
		return null;
	}
	set
	{
		if (value != null) { this.LinkType_OptionSetValue = new OptionSetValue((int)value); }
		else this.LinkType_OptionSetValue = null;
	}
}
///<summary>
///<para>Logical Name: linktypecode</para>
///</summary>
[AttributeLogicalNameAttribute("linktypecode")]
public OptionSetValue LinkType_OptionSetValue
{
	get { return this.GetPropertyValue<OptionSetValue>("linktypecode"); }
	set { this.SetPropertyValue<OptionSetValue>("linktypecode", value, "LinkType_OptionSetValue"); }
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="Service">CRM Organization Service</param>
/// <returns></returns>
public string LinkType_Text(IOrganizationService Service)
{
	return this.LinkType_OptionSetValue.GetOptionSetText(Service, this, "linktypecode");
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="AttributeMetadata">The attribute metadata previously retrieved using the 'GetAttributeMetadata' extension method on the IOrganizationService object.</param>
/// <returns></returns>
public string LinkType_Text(EnumAttributeMetadata AttributeMetadata)
{
	return AttributeMetadata.GetOptionSetText(this.LinkType_OptionSetValue.Value);
}
///<summary>
///<para>Logical Name: linkedreportid</para>
///</summary>
[AttributeLogicalNameAttribute("linkedreportid")]
public EntityReference LinkedReport
{
	get { return this.GetPropertyValue<EntityReference>("linkedreportid"); }
	set { this.SetPropertyValue<EntityReference>("linkedreportid", value, "LinkedReport"); }
}
///<summary>
///<para>Logical Name: linkedreportname</para>
///<para>Max Length: 255 characters</para>
///</summary>
[AttributeLogicalNameAttribute("linkedreportname")]
public string LinkedReportName
{
	get { return this.GetPropertyValue<string>("linkedreportname"); }
	set { this.SetPropertyValue("linkedreportname", value, 255, "LinkedReportName"); }
}
///<summary>
///<para>Logical Name: reportid</para>
///</summary>
[AttributeLogicalNameAttribute("reportid")]
public EntityReference MainReport
{
	get { return this.GetPropertyValue<EntityReference>("reportid"); }
	set { this.SetPropertyValue<EntityReference>("reportid", value, "MainReport"); }
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
///<para>Logical Name: owningbusinessunit</para>
///</summary>
[AttributeLogicalNameAttribute("owningbusinessunit")]
public Guid OwningBusinessUnit
{
	get { return this.GetPropertyValue<Guid>("owningbusinessunit"); }
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
///<para>Key Property (Uniqueidentifier)</para>
///<para>Logical Name: reportlinkid</para>
///</summary>
[AttributeLogicalNameAttribute("reportlinkid")]
public Guid ReportLinkId
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


        /// <summary>
/// <para><b>UserEntityInstanceData (Object Id)</b></para>
/// <para>Schema Name: userentityinstancedata_reportlink</para>
/// </summary>
public List<UserEntityInstanceData> GetUserEntityInstanceData_ObjectId (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<UserEntityInstanceData>(Service, this.Id, "userentityinstancedata", "objectid", Columns); }
/// <summary>
/// <para><b>UserEntityInstanceData (Object Id)</b></para>
/// <para>Schema Name: userentityinstancedata_reportlink</para>
/// </summary>
public List<UserEntityInstanceData> GetUserEntityInstanceData_ObjectId (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<UserEntityInstanceData>(Service, this.Id, "userentityinstancedata", "objectid", Columns); }


        

        

        public enum eLinkType
{
	///<summary><para>Drill-through</para>
	///<para>Value = 1</para></summary>
	[Description("Drill-through")]
	Drill_through = 1, 
	///<summary><para>Sub-report</para>
	///<para>Value = 2</para></summary>
	[Description("Sub-report")]
	Sub_report = 2, 
	///<summary><para>Drill-through and sub-report</para>
	///<para>Value = 3</para></summary>
	[Description("Drill-through and sub-report")]
	Drill_throughAndSub_report = 3
}


        public static class Properties
{
	/// <summary><para>createdonbehalfbyyominame</para>
	/// <para>createdonbehalfbyyominame</para></summary>
	public const string CreatedOnBehalfByYomiName = "createdonbehalfbyyominame";
	/// <summary><para>createdbyyominame</para>
	/// <para>createdbyyominame</para></summary>
	public const string CreatedByYomiName = "createdbyyominame";
	/// <summary><para>modifiedbyname</para>
	/// <para>modifiedbyname</para></summary>
	public const string ModifiedByName = "modifiedbyname";
	/// <summary><para>versionnumber</para>
	/// <para>versionnumber</para></summary>
	public const string VersionNumber = "versionnumber";
	/// <summary><para>modifiedbyyominame</para>
	/// <para>modifiedbyyominame</para></summary>
	public const string ModifiedByYomiName = "modifiedbyyominame";
	/// <summary><para>owneridtype</para>
	/// <para>owneridtype</para></summary>
	public const string OwnerIdType = "owneridtype";
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
	/// <summary><para>reportlinkidunique</para>
	/// <para>reportlinkidunique</para></summary>
	public const string ReportLinkIdUnique = "reportlinkidunique";
	/// <summary><para>Created By</para>
	/// <para>createdby</para></summary>
	public const string CreatedBy = "createdby";
	/// <summary><para>Created By (Delegate)</para>
	/// <para>createdonbehalfby</para></summary>
	public const string CreatedBy_Delegate = "createdonbehalfby";
	/// <summary><para>Created On</para>
	/// <para>createdon</para></summary>
	public const string CreatedOn = "createdon";
	/// <summary><para>Import Sequence Number</para>
	/// <para>importsequencenumber</para></summary>
	public const string ImportSequenceNumber = "importsequencenumber";
	/// <summary><para>Link Type</para>
	/// <para>linktypecode</para></summary>
	public const string LinkType = "linktypecode";
	/// <summary><para>Linked Report</para>
	/// <para>linkedreportid</para></summary>
	public const string LinkedReport = "linkedreportid";
	/// <summary><para>Linked Report Name</para>
	/// <para>linkedreportname</para></summary>
	public const string LinkedReportName = "linkedreportname";
	/// <summary><para>Main Report</para>
	/// <para>reportid</para></summary>
	public const string MainReport = "reportid";
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
	/// <summary><para>Owning Business Unit</para>
	/// <para>owningbusinessunit</para></summary>
	public const string OwningBusinessUnit = "owningbusinessunit";
	/// <summary><para>Owning User</para>
	/// <para>owninguser</para></summary>
	public const string OwningUser = "owninguser";
	/// <summary><para>Report Link</para>
	/// <para>reportlinkid</para></summary>
	public const string ReportLinkId = "reportlinkid";
}

    }
}
