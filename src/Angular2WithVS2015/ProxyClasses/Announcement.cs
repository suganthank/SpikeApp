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
    [EntityLogicalNameAttribute("businessunitnewsarticle")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XrmToolkit", "4.0")]
    public partial class Announcement : BaseProxyClass
    {
        public new const string LogicalName = "businessunitnewsarticle";
        public const int ObjectTypeCode = 132;
        public const string PrimaryIdAttribute = "businessunitnewsarticleid";
        public const string PrimaryNameAttribute = "articletitle";
        
        static Announcement()
        {
            BaseProxyClass.RegisterProxyType(typeof(Announcement), "businessunitnewsarticle");
            _textOptions = new Dictionary<string, eTextOptions>();
            _numberOptions = new Dictionary<string, eNumberOptions>();
            _errorStrings = new Dictionary<string, string>();
            TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
            NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
        }
        public Announcement() : base(new Entity("businessunitnewsarticle")) { }
        public Announcement(Entity original) : base(original) { }
        public static string GetLogicalName() { return BaseProxyClass.GetLogicalName<Announcement>(); }
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
///<para>Logical Name: activeon</para>
///</summary>
[AttributeLogicalNameAttribute("activeon")]
public DateTime? ActiveOn
{
	get { return this.GetPropertyValue<DateTime?>("activeon"); }
	set { this.SetPropertyValue<DateTime?>("activeon", value, "ActiveOn"); }
}
///<summary>
///<para>Key Property (Uniqueidentifier)</para>
///<para>Logical Name: businessunitnewsarticleid</para>
///</summary>
[AttributeLogicalNameAttribute("businessunitnewsarticleid")]
public Guid AnnouncementId
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
///<para>Logical Name: newsarticle</para>
///<para>Max Length: 1073741823 characters</para>
///</summary>
[AttributeLogicalNameAttribute("newsarticle")]
public string Description
{
	get { return this.GetPropertyValue<string>("newsarticle"); }
	set { this.SetPropertyValue("newsarticle", value, 1073741823, "Description"); }
}
///<summary>
///<para>Logical Name: activeuntil</para>
///</summary>
[AttributeLogicalNameAttribute("activeuntil")]
public DateTime? ExpirationDate
{
	get { return this.GetPropertyValue<DateTime?>("activeuntil"); }
	set { this.SetPropertyValue<DateTime?>("activeuntil", value, "ExpirationDate"); }
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
///<para>Logical Name: articleurl</para>
///<para>Max Length: 200 characters</para>
///</summary>
[AttributeLogicalNameAttribute("articleurl")]
public string MoreInformationURL
{
	get { return this.GetPropertyValue<string>("articleurl"); }
	set { this.SetPropertyValue("articleurl", value, 200, "MoreInformationURL"); }
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
///<para>Logical Name: overriddencreatedon</para>
///</summary>
[AttributeLogicalNameAttribute("overriddencreatedon")]
public DateTime? RecordCreatedOn
{
	get { return this.GetPropertyValue<DateTime?>("overriddencreatedon"); }
	set { this.SetPropertyValue<DateTime?>("overriddencreatedon", value, "RecordCreatedOn"); }
}
///<summary>
///<para>Logical Name: showonhomepage</para>
///<para>True = Yes</para>
///<para>False = No</para>
///</summary>
[AttributeLogicalNameAttribute("showonhomepage")]
public bool? ShowInWorkplace
{
	get { return this.GetPropertyValue<bool?>("showonhomepage"); }
	set { this.SetPropertyValue<bool?>("showonhomepage", value, "ShowInWorkplace"); }
}
///<summary>
///<para>Logical Name: articletitle</para>
///<para>Max Length: 300 characters</para>
///</summary>
[AttributeLogicalNameAttribute("articletitle")]
public string Title
{
	get { return this.GetPropertyValue<string>("articletitle"); }
	set { this.SetPropertyValue("articletitle", value, 300, "Title"); }
}
/// <summary>
///Logical Name: articletypecode
/// </summary>
[AttributeLogicalNameAttribute("articletypecode")]
public eVisibleTo? VisibleTo
{
	get
	{
		if (VisibleTo_OptionSetValue != null) { return (eVisibleTo)VisibleTo_OptionSetValue.Value; }
		return null;
	}
	set
	{
		if (value != null) { this.VisibleTo_OptionSetValue = new OptionSetValue((int)value); }
		else this.VisibleTo_OptionSetValue = null;
	}
}
///<summary>
///<para>Logical Name: articletypecode</para>
///</summary>
[AttributeLogicalNameAttribute("articletypecode")]
public OptionSetValue VisibleTo_OptionSetValue
{
	get { return this.GetPropertyValue<OptionSetValue>("articletypecode"); }
	set { this.SetPropertyValue<OptionSetValue>("articletypecode", value, "VisibleTo_OptionSetValue"); }
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="Service">CRM Organization Service</param>
/// <returns></returns>
public string VisibleTo_Text(IOrganizationService Service)
{
	return this.VisibleTo_OptionSetValue.GetOptionSetText(Service, this, "articletypecode");
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="AttributeMetadata">The attribute metadata previously retrieved using the 'GetAttributeMetadata' extension method on the IOrganizationService object.</param>
/// <returns></returns>
public string VisibleTo_Text(EnumAttributeMetadata AttributeMetadata)
{
	return AttributeMetadata.GetOptionSetText(this.VisibleTo_OptionSetValue.Value);
}


        /// <summary>
/// <para><b>SystemJob (Regarding)</b></para>
/// <para>Schema Name: BusinessUnitNewsArticle_AsyncOperations</para>
/// </summary>
public List<SystemJob> GetSystemJobs_Regarding (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<SystemJob>(Service, this.Id, "asyncoperation", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>SystemJob (Regarding)</b></para>
/// <para>Schema Name: BusinessUnitNewsArticle_AsyncOperations</para>
/// </summary>
public List<SystemJob> GetSystemJobs_Regarding (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<SystemJob>(Service, this.Id, "asyncoperation", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>BulkDeleteFailure (Name)</b></para>
/// <para>Schema Name: BusinessUnitNewsArticle_BulkDeleteFailures</para>
/// </summary>
public List<BulkDeleteFailure> GetBulkDeleteFailures_Name (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<BulkDeleteFailure>(Service, this.Id, "bulkdeletefailure", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>BulkDeleteFailure (Name)</b></para>
/// <para>Schema Name: BusinessUnitNewsArticle_BulkDeleteFailures</para>
/// </summary>
public List<BulkDeleteFailure> GetBulkDeleteFailures_Name (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<BulkDeleteFailure>(Service, this.Id, "bulkdeletefailure", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>ProcessSession (Regarding)</b></para>
/// <para>Schema Name: BusinessUnitNewsArticle_ProcessSessions</para>
/// </summary>
public List<ProcessSession> GetProcessSessions_Regarding (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<ProcessSession>(Service, this.Id, "processsession", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>ProcessSession (Regarding)</b></para>
/// <para>Schema Name: BusinessUnitNewsArticle_ProcessSessions</para>
/// </summary>
public List<ProcessSession> GetProcessSessions_Regarding (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<ProcessSession>(Service, this.Id, "processsession", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>UserEntityInstanceData (Object Id)</b></para>
/// <para>Schema Name: userentityinstancedata_businessunitnewsarticle</para>
/// </summary>
public List<UserEntityInstanceData> GetUserEntityInstanceData_ObjectId (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<UserEntityInstanceData>(Service, this.Id, "userentityinstancedata", "objectid", Columns); }
/// <summary>
/// <para><b>UserEntityInstanceData (Object Id)</b></para>
/// <para>Schema Name: userentityinstancedata_businessunitnewsarticle</para>
/// </summary>
public List<UserEntityInstanceData> GetUserEntityInstanceData_ObjectId (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<UserEntityInstanceData>(Service, this.Id, "userentityinstancedata", "objectid", Columns); }


        

        

        public enum eVisibleTo
{
	///<summary><para>All Users</para>
	///<para>Value = 1</para></summary>
	[Description("All Users")]
	AllUsers = 1, 
	///<summary><para>Sales Users</para>
	///<para>Value = 2</para></summary>
	[Description("Sales Users")]
	SalesUsers = 2, 
	///<summary><para>Service Users</para>
	///<para>Value = 3</para></summary>
	[Description("Service Users")]
	ServiceUsers = 3
}


        public static class Properties
{
	/// <summary><para>createdonbehalfbyyominame</para>
	/// <para>createdonbehalfbyyominame</para></summary>
	public const string CreatedOnBehalfByYomiName = "createdonbehalfbyyominame";
	/// <summary><para>organizationidname</para>
	/// <para>organizationidname</para></summary>
	public const string OrganizationIdName = "organizationidname";
	/// <summary><para>utcconversiontimezonecode</para>
	/// <para>utcconversiontimezonecode</para></summary>
	public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
	/// <summary><para>createdbyyominame</para>
	/// <para>createdbyyominame</para></summary>
	public const string CreatedByYomiName = "createdbyyominame";
	/// <summary><para>versionnumber</para>
	/// <para>versionnumber</para></summary>
	public const string VersionNumber = "versionnumber";
	/// <summary><para>modifiedbyyominame</para>
	/// <para>modifiedbyyominame</para></summary>
	public const string ModifiedByYomiName = "modifiedbyyominame";
	/// <summary><para>timezoneruleversionnumber</para>
	/// <para>timezoneruleversionnumber</para></summary>
	public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
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
	/// <summary><para>Active On</para>
	/// <para>activeon</para></summary>
	public const string ActiveOn = "activeon";
	/// <summary><para>Announcement</para>
	/// <para>businessunitnewsarticleid</para></summary>
	public const string AnnouncementId = "businessunitnewsarticleid";
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
	/// <para>newsarticle</para></summary>
	public const string Description = "newsarticle";
	/// <summary><para>Expiration Date</para>
	/// <para>activeuntil</para></summary>
	public const string ExpirationDate = "activeuntil";
	/// <summary><para>Import Sequence Number</para>
	/// <para>importsequencenumber</para></summary>
	public const string ImportSequenceNumber = "importsequencenumber";
	/// <summary><para>Modified By</para>
	/// <para>modifiedby</para></summary>
	public const string ModifiedBy = "modifiedby";
	/// <summary><para>Modified By (Delegate)</para>
	/// <para>modifiedonbehalfby</para></summary>
	public const string ModifiedBy_Delegate = "modifiedonbehalfby";
	/// <summary><para>Modified On</para>
	/// <para>modifiedon</para></summary>
	public const string ModifiedOn = "modifiedon";
	/// <summary><para>More Information URL</para>
	/// <para>articleurl</para></summary>
	public const string MoreInformationURL = "articleurl";
	/// <summary><para>Organization</para>
	/// <para>organizationid</para></summary>
	public const string Organization = "organizationid";
	/// <summary><para>Record Created On</para>
	/// <para>overriddencreatedon</para></summary>
	public const string RecordCreatedOn = "overriddencreatedon";
	/// <summary><para>Show in Workplace</para>
	/// <para>showonhomepage</para></summary>
	public const string ShowInWorkplace = "showonhomepage";
	/// <summary><para>Title</para>
	/// <para>articletitle</para></summary>
	public const string Title = "articletitle";
	/// <summary><para>Visible To</para>
	/// <para>articletypecode</para></summary>
	public const string VisibleTo = "articletypecode";
}

    }
}
