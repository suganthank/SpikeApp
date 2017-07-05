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
    [EntityLogicalNameAttribute("sdkmessagerequest")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XrmToolkit", "4.0")]
    public partial class SdkMessageRequest : BaseProxyClass
    {
        public new const string LogicalName = "sdkmessagerequest";
        public const int ObjectTypeCode = 4609;
        public const string PrimaryIdAttribute = "sdkmessagerequestid";
        public const string PrimaryNameAttribute = "";
        
        static SdkMessageRequest()
        {
            BaseProxyClass.RegisterProxyType(typeof(SdkMessageRequest), "sdkmessagerequest");
            _textOptions = new Dictionary<string, eTextOptions>();
            _numberOptions = new Dictionary<string, eNumberOptions>();
            _errorStrings = new Dictionary<string, string>();
            TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
            NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
        }
        public SdkMessageRequest() : base(new Entity("sdkmessagerequest")) { }
        public SdkMessageRequest(Entity original) : base(original) { }
        public static string GetLogicalName() { return BaseProxyClass.GetLogicalName<SdkMessageRequest>(); }
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
///<para>Logical Name: createdonbehalfbyname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("createdonbehalfbyname")]
public string CreatedOnBehalfByName
{
	get { return this.GetPropertyValue<string>("createdonbehalfbyname"); }
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
///<para>Logical Name: modifiedonbehalfbyyominame</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("modifiedonbehalfbyyominame")]
public string ModifiedOnBehalfByYomiName
{
	get { return this.GetPropertyValue<string>("modifiedonbehalfbyyominame"); }
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
///<para>Logical Name: versionnumber</para>
///</summary>
[AttributeLogicalNameAttribute("versionnumber")]
public int? VersionNumber
{
	get { return this.GetPropertyValue<int?>("versionnumber"); }
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
///<para>Logical Name: modifiedby</para>
///</summary>
[AttributeLogicalNameAttribute("modifiedby")]
public EntityReference ModifiedBy
{
	get { return this.GetPropertyValue<EntityReference>("modifiedby"); }
}
///<summary>
///<para>Logical Name: sdkmessagepairid</para>
///</summary>
[AttributeLogicalNameAttribute("sdkmessagepairid")]
public EntityReference SdkMessagePairId
{
	get { return this.GetPropertyValue<EntityReference>("sdkmessagepairid"); }
}
///<summary>
///<para>Logical Name: sdkmessagerequestidunique</para>
///</summary>
[AttributeLogicalNameAttribute("sdkmessagerequestidunique")]
public Guid SdkMessageRequestIdUnique
{
	get { return this.GetPropertyValue<Guid>("sdkmessagerequestidunique"); }
}
///<summary>
///<para>Logical Name: customizationlevel</para>
///<para>Minimum Value: -255</para>
///<para>Maximum Value: 255</para>
///</summary>
[AttributeLogicalNameAttribute("customizationlevel")]
public int? CustomizationLevel
{
	get { return this.GetPropertyValue<int?>("customizationlevel"); }
}
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
///<para>Logical Name: primaryobjecttypecode</para>
///</summary>
[AttributeLogicalNameAttribute("primaryobjecttypecode")]
public string PrimaryObjectTypeCode
{
	get { return this.GetPropertyValue<string>("primaryobjecttypecode"); }
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
///<para>Key Property (Uniqueidentifier)</para>
///<para>Logical Name: sdkmessagerequestid</para>
///</summary>
[AttributeLogicalNameAttribute("sdkmessagerequestid")]
public Guid SdkMessageRequestId
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
///<para>Logical Name: name</para>
///<para>Max Length: 256 characters</para>
///</summary>
[AttributeLogicalNameAttribute("name")]
public string Name
{
	get { return this.GetPropertyValue<string>("name"); }
	set { this.SetPropertyValue("name", value, 256, "Name"); }
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
///<para>Logical Name: modifiedonbehalfby</para>
///</summary>
[AttributeLogicalNameAttribute("modifiedonbehalfby")]
public EntityReference ModifiedBy_Delegate
{
	get { return this.GetPropertyValue<EntityReference>("modifiedonbehalfby"); }
}


        /// <summary>
/// <para><b>SdkMessageRequestField ()</b></para>
/// <para>Schema Name: messagerequest_sdkmessagerequestfield</para>
/// </summary>
public List<SdkMessageRequestField> GetSdkMessageRequestFields (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<SdkMessageRequestField>(Service, this.Id, "sdkmessagerequestfield", "sdkmessagerequestid", Columns); }
/// <summary>
/// <para><b>SdkMessageRequestField ()</b></para>
/// <para>Schema Name: messagerequest_sdkmessagerequestfield</para>
/// </summary>
public List<SdkMessageRequestField> GetSdkMessageRequestFields (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<SdkMessageRequestField>(Service, this.Id, "sdkmessagerequestfield", "sdkmessagerequestid", Columns); }
/// <summary>
/// <para><b>SdkMessageResponse ()</b></para>
/// <para>Schema Name: messagerequest_sdkmessageresponse</para>
/// </summary>
public List<SdkMessageResponse> GetSdkMessageResponses (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<SdkMessageResponse>(Service, this.Id, "sdkmessageresponse", "sdkmessagerequestid", Columns); }
/// <summary>
/// <para><b>SdkMessageResponse ()</b></para>
/// <para>Schema Name: messagerequest_sdkmessageresponse</para>
/// </summary>
public List<SdkMessageResponse> GetSdkMessageResponses (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<SdkMessageResponse>(Service, this.Id, "sdkmessageresponse", "sdkmessagerequestid", Columns); }
/// <summary>
/// <para><b>UserEntityInstanceData (Object Id)</b></para>
/// <para>Schema Name: userentityinstancedata_sdkmessagerequest</para>
/// </summary>
public List<UserEntityInstanceData> GetUserEntityInstanceData_ObjectId (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<UserEntityInstanceData>(Service, this.Id, "userentityinstancedata", "objectid", Columns); }
/// <summary>
/// <para><b>UserEntityInstanceData (Object Id)</b></para>
/// <para>Schema Name: userentityinstancedata_sdkmessagerequest</para>
/// </summary>
public List<UserEntityInstanceData> GetUserEntityInstanceData_ObjectId (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<UserEntityInstanceData>(Service, this.Id, "userentityinstancedata", "objectid", Columns); }


        

        

        

        public static class Properties
{
	/// <summary><para>organizationid</para>
	/// <para>organizationid</para></summary>
	public const string OrganizationId = "organizationid";
	/// <summary><para>createdonbehalfbyname</para>
	/// <para>createdonbehalfbyname</para></summary>
	public const string CreatedOnBehalfByName = "createdonbehalfbyname";
	/// <summary><para>createdon</para>
	/// <para>createdon</para></summary>
	public const string CreatedOn = "createdon";
	/// <summary><para>modifiedonbehalfbyyominame</para>
	/// <para>modifiedonbehalfbyyominame</para></summary>
	public const string ModifiedOnBehalfByYomiName = "modifiedonbehalfbyyominame";
	/// <summary><para>createdby</para>
	/// <para>createdby</para></summary>
	public const string CreatedBy = "createdby";
	/// <summary><para>versionnumber</para>
	/// <para>versionnumber</para></summary>
	public const string VersionNumber = "versionnumber";
	/// <summary><para>modifiedonbehalfbyname</para>
	/// <para>modifiedonbehalfbyname</para></summary>
	public const string ModifiedOnBehalfByName = "modifiedonbehalfbyname";
	/// <summary><para>modifiedby</para>
	/// <para>modifiedby</para></summary>
	public const string ModifiedBy = "modifiedby";
	/// <summary><para>sdkmessagepairid</para>
	/// <para>sdkmessagepairid</para></summary>
	public const string SdkMessagePairId = "sdkmessagepairid";
	/// <summary><para>sdkmessagerequestidunique</para>
	/// <para>sdkmessagerequestidunique</para></summary>
	public const string SdkMessageRequestIdUnique = "sdkmessagerequestidunique";
	/// <summary><para>customizationlevel</para>
	/// <para>customizationlevel</para></summary>
	public const string CustomizationLevel = "customizationlevel";
	/// <summary><para>createdonbehalfbyyominame</para>
	/// <para>createdonbehalfbyyominame</para></summary>
	public const string CreatedOnBehalfByYomiName = "createdonbehalfbyyominame";
	/// <summary><para>primaryobjecttypecode</para>
	/// <para>primaryobjecttypecode</para></summary>
	public const string PrimaryObjectTypeCode = "primaryobjecttypecode";
	/// <summary><para>modifiedon</para>
	/// <para>modifiedon</para></summary>
	public const string ModifiedOn = "modifiedon";
	/// <summary><para>sdkmessagerequestid</para>
	/// <para>sdkmessagerequestid</para></summary>
	public const string SdkMessageRequestId = "sdkmessagerequestid";
	/// <summary><para>name</para>
	/// <para>name</para></summary>
	public const string Name = "name";
	/// <summary><para>Created By (Delegate)</para>
	/// <para>createdonbehalfby</para></summary>
	public const string CreatedBy_Delegate = "createdonbehalfby";
	/// <summary><para>Modified By (Delegate)</para>
	/// <para>modifiedonbehalfby</para></summary>
	public const string ModifiedBy_Delegate = "modifiedonbehalfby";
}

    }
}