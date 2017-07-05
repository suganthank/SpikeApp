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
    [EntityLogicalNameAttribute("solution")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XrmToolkit", "4.0")]
    public partial class Solution : BaseProxyClass
    {
        public new const string LogicalName = "solution";
        public const int ObjectTypeCode = 7100;
        public const string PrimaryIdAttribute = "solutionid";
        public const string PrimaryNameAttribute = "friendlyname";
        
        static Solution()
        {
            BaseProxyClass.RegisterProxyType(typeof(Solution), "solution");
            _textOptions = new Dictionary<string, eTextOptions>();
            _numberOptions = new Dictionary<string, eNumberOptions>();
            _errorStrings = new Dictionary<string, string>();
            TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
            NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
        }
        public Solution() : base(new Entity("solution")) { }
        public Solution(Entity original) : base(original) { }
        public static string GetLogicalName() { return BaseProxyClass.GetLogicalName<Solution>(); }
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
///<para>Logical Name: configurationpageidname</para>
///<para>Max Length: 256 characters</para>
///</summary>
[AttributeLogicalNameAttribute("configurationpageidname")]
public string ConfigurationPageIdName
{
	get { return this.GetPropertyValue<string>("configurationpageidname"); }
}
///<summary>
///<para>Logical Name: pinpointsolutiondefaultlocale</para>
///<para>Max Length: 16 characters</para>
///</summary>
[AttributeLogicalNameAttribute("pinpointsolutiondefaultlocale")]
public string PinpointSolutionDefaultLocale
{
	get { return this.GetPropertyValue<string>("pinpointsolutiondefaultlocale"); }
}
///<summary>
///<para>Logical Name: pinpointassetid</para>
///<para>Max Length: 255 characters</para>
///</summary>
[AttributeLogicalNameAttribute("pinpointassetid")]
public string PinpointAssetId
{
	get { return this.GetPropertyValue<string>("pinpointassetid"); }
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
///<para>Logical Name: publisheridprefix</para>
///<para>Max Length: 256 characters</para>
///</summary>
[AttributeLogicalNameAttribute("publisheridprefix")]
public string PublisherIdPrefix
{
	get { return this.GetPropertyValue<string>("publisheridprefix"); }
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
///<para>Logical Name: pinpointsolutionid</para>
///</summary>
[AttributeLogicalNameAttribute("pinpointsolutionid")]
public int? PinpointSolutionId
{
	get { return this.GetPropertyValue<int?>("pinpointsolutionid"); }
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
///<para>Logical Name: pinpointpublisherid</para>
///</summary>
[AttributeLogicalNameAttribute("pinpointpublisherid")]
public int? PinpointPublisherId
{
	get { return this.GetPropertyValue<int?>("pinpointpublisherid"); }
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
///<para>Logical Name: parentsolutionidname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("parentsolutionidname")]
public string ParentSolutionIdName
{
	get { return this.GetPropertyValue<string>("parentsolutionidname"); }
}
///<summary>
///<para>Logical Name: publisheridoptionvalueprefix</para>
///<para>Minimum Value: -2147483648</para>
///<para>Maximum Value: 2147483647</para>
///</summary>
[AttributeLogicalNameAttribute("publisheridoptionvalueprefix")]
public int? PublisherIdOptionValuePrefix
{
	get { return this.GetPropertyValue<int?>("publisheridoptionvalueprefix"); }
}
///<summary>
///<para>Logical Name: configurationpageid</para>
///</summary>
[AttributeLogicalNameAttribute("configurationpageid")]
public EntityReference ConfigurationPage
{
	get { return this.GetPropertyValue<EntityReference>("configurationpageid"); }
	set { this.SetPropertyValue<EntityReference>("configurationpageid", value, "ConfigurationPage"); }
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
///<para>Logical Name: friendlyname</para>
///<para>Max Length: 256 characters</para>
///</summary>
[AttributeLogicalNameAttribute("friendlyname")]
public string DisplayName
{
	get { return this.GetPropertyValue<string>("friendlyname"); }
	set { this.SetPropertyValue("friendlyname", value, 256, "DisplayName"); }
}
///<summary>
///<para>Logical Name: installedon</para>
///</summary>
[AttributeLogicalNameAttribute("installedon")]
public DateTime? InstalledOn
{
	get { return this.GetPropertyValue<DateTime?>("installedon"); }
}
///<summary>
///<para>Logical Name: isinternal</para>
///<para>True = Yes</para>
///<para>False = No</para>
///</summary>
[AttributeLogicalNameAttribute("isinternal")]
public bool? IsInternalSolution
{
	get { return this.GetPropertyValue<bool?>("isinternal"); }
}
///<summary>
///<para>Logical Name: isvisible</para>
///<para>True = Yes</para>
///<para>False = No</para>
///</summary>
[AttributeLogicalNameAttribute("isvisible")]
public bool? IsVisibleOutsidePlatform
{
	get { return this.GetPropertyValue<bool?>("isvisible"); }
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
///<para>Logical Name: uniquename</para>
///<para>Max Length: 65 characters</para>
///</summary>
[AttributeLogicalNameAttribute("uniquename")]
public string Name
{
	get { return this.GetPropertyValue<string>("uniquename"); }
	set { this.SetPropertyValue("uniquename", value, 65, "Name"); }
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
///<para>Logical Name: ismanaged</para>
///<para>True = Managed</para>
///<para>False = Unmanaged</para>
///</summary>
[AttributeLogicalNameAttribute("ismanaged")]
public bool? PackageType
{
	get { return this.GetPropertyValue<bool?>("ismanaged"); }
}
///<summary>
///<para>Logical Name: parentsolutionid</para>
///</summary>
[AttributeLogicalNameAttribute("parentsolutionid")]
public EntityReference ParentSolution
{
	get { return this.GetPropertyValue<EntityReference>("parentsolutionid"); }
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
///<para>Key Property (Uniqueidentifier)</para>
///<para>Logical Name: solutionid</para>
///</summary>
[AttributeLogicalNameAttribute("solutionid")]
public Guid SolutionIdentifierId
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
///<para>Logical Name: solutionpackageversion</para>
///<para>Max Length: 256 characters</para>
///</summary>
[AttributeLogicalNameAttribute("solutionpackageversion")]
public string SolutionPackageVersion
{
	get { return this.GetPropertyValue<string>("solutionpackageversion"); }
	set { this.SetPropertyValue("solutionpackageversion", value, 256, "SolutionPackageVersion"); }
}
///<summary>
///<para>Logical Name: solutiontype</para>
///</summary>
[AttributeLogicalNameAttribute("solutiontype")]
public OptionSetValue SolutionType
{
	get { return this.GetPropertyValue<OptionSetValue>("solutiontype"); }
	set { this.SetPropertyValue<OptionSetValue>("solutiontype", value, "SolutionType"); }
}
///<summary>
///<para>Logical Name: version</para>
///<para>Max Length: 256 characters</para>
///</summary>
[AttributeLogicalNameAttribute("version")]
public string Version
{
	get { return this.GetPropertyValue<string>("version"); }
	set { this.SetPropertyValue("version", value, 256, "Version"); }
}


        /// <summary>
/// <para><b>DependencyNode (Base Solution)</b></para>
/// <para>Schema Name: solution_base_dependencynode</para>
/// </summary>
public List<DependencyNode> GetDependencyNodes_BaseSolution (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<DependencyNode>(Service, this.Id, "dependencynode", "basesolutionid", Columns); }
/// <summary>
/// <para><b>DependencyNode (Base Solution)</b></para>
/// <para>Schema Name: solution_base_dependencynode</para>
/// </summary>
public List<DependencyNode> GetDependencyNodes_BaseSolution (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<DependencyNode>(Service, this.Id, "dependencynode", "basesolutionid", Columns); }
/// <summary>
/// <para><b>DependencyNode (Top Solution)</b></para>
/// <para>Schema Name: solution_top_dependencynode</para>
/// </summary>
public List<DependencyNode> GetDependencyNodes_TopSolution (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<DependencyNode>(Service, this.Id, "dependencynode", "topsolutionid", Columns); }
/// <summary>
/// <para><b>DependencyNode (Top Solution)</b></para>
/// <para>Schema Name: solution_top_dependencynode</para>
/// </summary>
public List<DependencyNode> GetDependencyNodes_TopSolution (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<DependencyNode>(Service, this.Id, "dependencynode", "topsolutionid", Columns); }
/// <summary>
/// <para><b>Solution (Parent Solution)</b></para>
/// <para>Schema Name: solution_parent_solution</para>
/// </summary>
public List<Solution> GetSolutions_ParentSolution (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<Solution>(Service, this.Id, "solution", "parentsolutionid", Columns); }
/// <summary>
/// <para><b>Solution (Parent Solution)</b></para>
/// <para>Schema Name: solution_parent_solution</para>
/// </summary>
public List<Solution> GetSolutions_ParentSolution (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<Solution>(Service, this.Id, "solution", "parentsolutionid", Columns); }
/// <summary>
/// <para><b>SolutionComponent (Solution)</b></para>
/// <para>Schema Name: solution_solutioncomponent</para>
/// </summary>
public List<SolutionComponent> GetSolutionComponents_Solution (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<SolutionComponent>(Service, this.Id, "solutioncomponent", "solutionid", Columns); }
/// <summary>
/// <para><b>SolutionComponent (Solution)</b></para>
/// <para>Schema Name: solution_solutioncomponent</para>
/// </summary>
public List<SolutionComponent> GetSolutionComponents_Solution (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<SolutionComponent>(Service, this.Id, "solutioncomponent", "solutionid", Columns); }
/// <summary>
/// <para><b>SyncError (Record)</b></para>
/// <para>Schema Name: Solution_SyncErrors</para>
/// </summary>
public List<SyncError> GetSyncErrors_Record (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<SyncError>(Service, this.Id, "syncerror", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>SyncError (Record)</b></para>
/// <para>Schema Name: Solution_SyncErrors</para>
/// </summary>
public List<SyncError> GetSyncErrors_Record (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<SyncError>(Service, this.Id, "syncerror", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>UserEntityInstanceData (Object Id)</b></para>
/// <para>Schema Name: userentityinstancedata_solution</para>
/// </summary>
public List<UserEntityInstanceData> GetUserEntityInstanceData_ObjectId (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<UserEntityInstanceData>(Service, this.Id, "userentityinstancedata", "objectid", Columns); }
/// <summary>
/// <para><b>UserEntityInstanceData (Object Id)</b></para>
/// <para>Schema Name: userentityinstancedata_solution</para>
/// </summary>
public List<UserEntityInstanceData> GetUserEntityInstanceData_ObjectId (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<UserEntityInstanceData>(Service, this.Id, "userentityinstancedata", "objectid", Columns); }


        

        

        

        public static class Properties
{
	/// <summary><para>createdonbehalfbyyominame</para>
	/// <para>createdonbehalfbyyominame</para></summary>
	public const string CreatedOnBehalfByYomiName = "createdonbehalfbyyominame";
	/// <summary><para>configurationpageidname</para>
	/// <para>configurationpageidname</para></summary>
	public const string ConfigurationPageIdName = "configurationpageidname";
	/// <summary><para>pinpointsolutiondefaultlocale</para>
	/// <para>pinpointsolutiondefaultlocale</para></summary>
	public const string PinpointSolutionDefaultLocale = "pinpointsolutiondefaultlocale";
	/// <summary><para>pinpointassetid</para>
	/// <para>pinpointassetid</para></summary>
	public const string PinpointAssetId = "pinpointassetid";
	/// <summary><para>versionnumber</para>
	/// <para>versionnumber</para></summary>
	public const string VersionNumber = "versionnumber";
	/// <summary><para>publisheridprefix</para>
	/// <para>publisheridprefix</para></summary>
	public const string PublisherIdPrefix = "publisheridprefix";
	/// <summary><para>modifiedbyname</para>
	/// <para>modifiedbyname</para></summary>
	public const string ModifiedByName = "modifiedbyname";
	/// <summary><para>organizationidname</para>
	/// <para>organizationidname</para></summary>
	public const string OrganizationIdName = "organizationidname";
	/// <summary><para>pinpointsolutionid</para>
	/// <para>pinpointsolutionid</para></summary>
	public const string PinpointSolutionId = "pinpointsolutionid";
	/// <summary><para>modifiedonbehalfbyname</para>
	/// <para>modifiedonbehalfbyname</para></summary>
	public const string ModifiedOnBehalfByName = "modifiedonbehalfbyname";
	/// <summary><para>pinpointpublisherid</para>
	/// <para>pinpointpublisherid</para></summary>
	public const string PinpointPublisherId = "pinpointpublisherid";
	/// <summary><para>modifiedonbehalfbyyominame</para>
	/// <para>modifiedonbehalfbyyominame</para></summary>
	public const string ModifiedOnBehalfByYomiName = "modifiedonbehalfbyyominame";
	/// <summary><para>createdbyname</para>
	/// <para>createdbyname</para></summary>
	public const string CreatedByName = "createdbyname";
	/// <summary><para>createdonbehalfbyname</para>
	/// <para>createdonbehalfbyname</para></summary>
	public const string CreatedOnBehalfByName = "createdonbehalfbyname";
	/// <summary><para>parentsolutionidname</para>
	/// <para>parentsolutionidname</para></summary>
	public const string ParentSolutionIdName = "parentsolutionidname";
	/// <summary><para>publisheridoptionvalueprefix</para>
	/// <para>publisheridoptionvalueprefix</para></summary>
	public const string PublisherIdOptionValuePrefix = "publisheridoptionvalueprefix";
	/// <summary><para>Configuration Page</para>
	/// <para>configurationpageid</para></summary>
	public const string ConfigurationPage = "configurationpageid";
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
	/// <summary><para>Display Name</para>
	/// <para>friendlyname</para></summary>
	public const string DisplayName = "friendlyname";
	/// <summary><para>Installed On</para>
	/// <para>installedon</para></summary>
	public const string InstalledOn = "installedon";
	/// <summary><para>Is internal solution</para>
	/// <para>isinternal</para></summary>
	public const string IsInternalSolution = "isinternal";
	/// <summary><para>Is Visible Outside Platform</para>
	/// <para>isvisible</para></summary>
	public const string IsVisibleOutsidePlatform = "isvisible";
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
	/// <para>uniquename</para></summary>
	public const string Name = "uniquename";
	/// <summary><para>Organization</para>
	/// <para>organizationid</para></summary>
	public const string Organization = "organizationid";
	/// <summary><para>Package Type</para>
	/// <para>ismanaged</para></summary>
	public const string PackageType = "ismanaged";
	/// <summary><para>Parent Solution</para>
	/// <para>parentsolutionid</para></summary>
	public const string ParentSolution = "parentsolutionid";
	/// <summary><para>Publisher</para>
	/// <para>publisherid</para></summary>
	public const string Publisher = "publisherid";
	/// <summary><para>Publisher</para>
	/// <para>publisheridname</para></summary>
	public const string Publisher2 = "publisheridname";
	/// <summary><para>Solution Identifier</para>
	/// <para>solutionid</para></summary>
	public const string SolutionIdentifierId = "solutionid";
	/// <summary><para>Solution Package Version</para>
	/// <para>solutionpackageversion</para></summary>
	public const string SolutionPackageVersion = "solutionpackageversion";
	/// <summary><para>Solution Type</para>
	/// <para>solutiontype</para></summary>
	public const string SolutionType = "solutiontype";
	/// <summary><para>Version</para>
	/// <para>version</para></summary>
	public const string Version = "version";
}

    }
}