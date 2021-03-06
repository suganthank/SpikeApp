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
    [EntityLogicalNameAttribute("serviceendpoint")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XrmToolkit", "4.0")]
    public partial class ServiceEndpoint : BaseProxyClass
    {
        public new const string LogicalName = "serviceendpoint";
        public const int ObjectTypeCode = 4618;
        public const string PrimaryIdAttribute = "serviceendpointid";
        public const string PrimaryNameAttribute = "name";
        
        static ServiceEndpoint()
        {
            BaseProxyClass.RegisterProxyType(typeof(ServiceEndpoint), "serviceendpoint");
            _textOptions = new Dictionary<string, eTextOptions>();
            _numberOptions = new Dictionary<string, eNumberOptions>();
            _errorStrings = new Dictionary<string, string>();
            TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
            NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
        }
        public ServiceEndpoint() : base(new Entity("serviceendpoint")) { }
        public ServiceEndpoint(Entity original) : base(original) { }
        public static string GetLogicalName() { return BaseProxyClass.GetLogicalName<ServiceEndpoint>(); }
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
///<para>Logical Name: issaskeyset</para>
///<para>True = Yes</para>
///<para>False = No</para>
///</summary>
[AttributeLogicalNameAttribute("issaskeyset")]
public bool? IsSASKeySet
{
	get { return this.GetPropertyValue<bool?>("issaskeyset"); }
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
///<para>Logical Name: modifiedonbehalfbyyominame</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("modifiedonbehalfbyyominame")]
public string ModifiedOnBehalfByYomiName
{
	get { return this.GetPropertyValue<string>("modifiedonbehalfbyyominame"); }
}
///<summary>
///<para>Key Property (Uniqueidentifier)</para>
///<para>Logical Name: serviceendpointid</para>
///</summary>
[AttributeLogicalNameAttribute("serviceendpointid")]
public Guid ServiceEndpointId
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
///<para>Logical Name: serviceendpointidunique</para>
///</summary>
[AttributeLogicalNameAttribute("serviceendpointidunique")]
public Guid ServiceEndpointIdUnique
{
	get { return this.GetPropertyValue<Guid>("serviceendpointidunique"); }
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
///<para>Logical Name: issastokenset</para>
///<para>True = Yes</para>
///<para>False = No</para>
///</summary>
[AttributeLogicalNameAttribute("issastokenset")]
public bool? IsSASTokenSet
{
	get { return this.GetPropertyValue<bool?>("issastokenset"); }
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
/// <summary>
///Logical Name: connectionmode
/// </summary>
[AttributeLogicalNameAttribute("connectionmode")]
public eConnectionMode? ConnectionMode
{
	get
	{
		if (ConnectionMode_OptionSetValue != null) { return (eConnectionMode)ConnectionMode_OptionSetValue.Value; }
		return null;
	}
	set
	{
		if (value != null) { this.ConnectionMode_OptionSetValue = new OptionSetValue((int)value); }
		else this.ConnectionMode_OptionSetValue = null;
	}
}
///<summary>
///<para>Logical Name: connectionmode</para>
///</summary>
[AttributeLogicalNameAttribute("connectionmode")]
public OptionSetValue ConnectionMode_OptionSetValue
{
	get { return this.GetPropertyValue<OptionSetValue>("connectionmode"); }
	set { this.SetPropertyValue<OptionSetValue>("connectionmode", value, "ConnectionMode_OptionSetValue"); }
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="Service">CRM Organization Service</param>
/// <returns></returns>
public string ConnectionMode_Text(IOrganizationService Service)
{
	return this.ConnectionMode_OptionSetValue.GetOptionSetText(Service, this, "connectionmode");
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="AttributeMetadata">The attribute metadata previously retrieved using the 'GetAttributeMetadata' extension method on the IOrganizationService object.</param>
/// <returns></returns>
public string ConnectionMode_Text(EnumAttributeMetadata AttributeMetadata)
{
	return AttributeMetadata.GetOptionSetText(this.ConnectionMode_OptionSetValue.Value);
}
/// <summary>
///Logical Name: messageformat
/// </summary>
[AttributeLogicalNameAttribute("messageformat")]
public eMessageFormat? ContentTypeOfTheMessage
{
	get
	{
		if (ContentTypeOfTheMessage_OptionSetValue != null) { return (eMessageFormat)ContentTypeOfTheMessage_OptionSetValue.Value; }
		return null;
	}
	set
	{
		if (value != null) { this.ContentTypeOfTheMessage_OptionSetValue = new OptionSetValue((int)value); }
		else this.ContentTypeOfTheMessage_OptionSetValue = null;
	}
}
///<summary>
///<para>Logical Name: messageformat</para>
///</summary>
[AttributeLogicalNameAttribute("messageformat")]
public OptionSetValue ContentTypeOfTheMessage_OptionSetValue
{
	get { return this.GetPropertyValue<OptionSetValue>("messageformat"); }
	set { this.SetPropertyValue<OptionSetValue>("messageformat", value, "ContentTypeOfTheMessage_OptionSetValue"); }
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="Service">CRM Organization Service</param>
/// <returns></returns>
public string ContentTypeOfTheMessage_Text(IOrganizationService Service)
{
	return this.ContentTypeOfTheMessage_OptionSetValue.GetOptionSetText(Service, this, "messageformat");
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="AttributeMetadata">The attribute metadata previously retrieved using the 'GetAttributeMetadata' extension method on the IOrganizationService object.</param>
/// <returns></returns>
public string ContentTypeOfTheMessage_Text(EnumAttributeMetadata AttributeMetadata)
{
	return AttributeMetadata.GetOptionSetText(this.ContentTypeOfTheMessage_OptionSetValue.Value);
}
/// <summary>
///Logical Name: contract
/// </summary>
[AttributeLogicalNameAttribute("contract")]
public eContract? Contract
{
	get
	{
		if (Contract_OptionSetValue != null) { return (eContract)Contract_OptionSetValue.Value; }
		return null;
	}
	set
	{
		if (value != null) { this.Contract_OptionSetValue = new OptionSetValue((int)value); }
		else this.Contract_OptionSetValue = null;
	}
}
///<summary>
///<para>Logical Name: contract</para>
///</summary>
[AttributeLogicalNameAttribute("contract")]
public OptionSetValue Contract_OptionSetValue
{
	get { return this.GetPropertyValue<OptionSetValue>("contract"); }
	set { this.SetPropertyValue<OptionSetValue>("contract", value, "Contract_OptionSetValue"); }
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="Service">CRM Organization Service</param>
/// <returns></returns>
public string Contract_Text(IOrganizationService Service)
{
	return this.Contract_OptionSetValue.GetOptionSetText(Service, this, "contract");
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="AttributeMetadata">The attribute metadata previously retrieved using the 'GetAttributeMetadata' extension method on the IOrganizationService object.</param>
/// <returns></returns>
public string Contract_Text(EnumAttributeMetadata AttributeMetadata)
{
	return AttributeMetadata.GetOptionSetText(this.Contract_OptionSetValue.Value);
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
///<para>Logical Name: iscustomizable</para>
///</summary>
[AttributeLogicalNameAttribute("iscustomizable")]
public BooleanManagedProperty Customizable
{
	get { return this.GetPropertyValue<BooleanManagedProperty>("iscustomizable"); }
	set { this.SetPropertyValue<BooleanManagedProperty>("iscustomizable", value, "Customizable"); }
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
/// <summary>
///Logical Name: namespaceformat
/// </summary>
[AttributeLogicalNameAttribute("namespaceformat")]
public eFormatForServiceBusNamespace? FormatOfServiceBusNamespace
{
	get
	{
		if (FormatOfServiceBusNamespace_OptionSetValue != null) { return (eFormatForServiceBusNamespace)FormatOfServiceBusNamespace_OptionSetValue.Value; }
		return null;
	}
	set
	{
		if (value != null) { this.FormatOfServiceBusNamespace_OptionSetValue = new OptionSetValue((int)value); }
		else this.FormatOfServiceBusNamespace_OptionSetValue = null;
	}
}
///<summary>
///<para>Logical Name: namespaceformat</para>
///</summary>
[AttributeLogicalNameAttribute("namespaceformat")]
public OptionSetValue FormatOfServiceBusNamespace_OptionSetValue
{
	get { return this.GetPropertyValue<OptionSetValue>("namespaceformat"); }
	set { this.SetPropertyValue<OptionSetValue>("namespaceformat", value, "FormatOfServiceBusNamespace_OptionSetValue"); }
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="Service">CRM Organization Service</param>
/// <returns></returns>
public string FormatOfServiceBusNamespace_Text(IOrganizationService Service)
{
	return this.FormatOfServiceBusNamespace_OptionSetValue.GetOptionSetText(Service, this, "namespaceformat");
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="AttributeMetadata">The attribute metadata previously retrieved using the 'GetAttributeMetadata' extension method on the IOrganizationService object.</param>
/// <returns></returns>
public string FormatOfServiceBusNamespace_Text(EnumAttributeMetadata AttributeMetadata)
{
	return AttributeMetadata.GetOptionSetText(this.FormatOfServiceBusNamespace_OptionSetValue.Value);
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
///<para>Max Length: 256 characters</para>
///</summary>
[AttributeLogicalNameAttribute("name")]
public string Name
{
	get { return this.GetPropertyValue<string>("name"); }
	set { this.SetPropertyValue("name", value, 256, "Name"); }
}
///<summary>
///<para>Logical Name: namespaceaddress</para>
///<para>Max Length: 255 characters</para>
///</summary>
[AttributeLogicalNameAttribute("namespaceaddress")]
public string NamespaceAddress
{
	get { return this.GetPropertyValue<string>("namespaceaddress"); }
	set { this.SetPropertyValue("namespaceaddress", value, 255, "NamespaceAddress"); }
}
///<summary>
///<para>Logical Name: path</para>
///<para>Max Length: 160 characters</para>
///</summary>
[AttributeLogicalNameAttribute("path")]
public string Path
{
	get { return this.GetPropertyValue<string>("path"); }
	set { this.SetPropertyValue("path", value, 160, "Path"); }
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
///<para>Logical Name: solutionnamespace</para>
///<para>Max Length: 160 characters</para>
///</summary>
[AttributeLogicalNameAttribute("solutionnamespace")]
public string ServiceNamespace
{
	get { return this.GetPropertyValue<string>("solutionnamespace"); }
	set { this.SetPropertyValue("solutionnamespace", value, 160, "ServiceNamespace"); }
}
///<summary>
///<para>Logical Name: saskey</para>
///<para>Max Length: 256 characters</para>
///</summary>
[AttributeLogicalNameAttribute("saskey")]
public string SharedAccessKey
{
	get { return this.GetPropertyValue<string>("saskey"); }
	set { this.SetPropertyValue("saskey", value, 256, "SharedAccessKey"); }
}
///<summary>
///<para>Logical Name: saskeyname</para>
///<para>Max Length: 256 characters</para>
///</summary>
[AttributeLogicalNameAttribute("saskeyname")]
public string SharedAccessKeyName
{
	get { return this.GetPropertyValue<string>("saskeyname"); }
	set { this.SetPropertyValue("saskeyname", value, 256, "SharedAccessKeyName"); }
}
///<summary>
///<para>Logical Name: sastoken</para>
///<para>Max Length: 256 characters</para>
///</summary>
[AttributeLogicalNameAttribute("sastoken")]
public string SharedAccessToken
{
	get { return this.GetPropertyValue<string>("sastoken"); }
	set { this.SetPropertyValue("sastoken", value, 256, "SharedAccessToken"); }
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
/// <summary>
///Logical Name: authtype
/// </summary>
[AttributeLogicalNameAttribute("authtype")]
public eAuthenticationTypeForServiceBus? SpecifiesModeOfAuthenticationWithSB
{
	get
	{
		if (SpecifiesModeOfAuthenticationWithSB_OptionSetValue != null) { return (eAuthenticationTypeForServiceBus)SpecifiesModeOfAuthenticationWithSB_OptionSetValue.Value; }
		return null;
	}
	set
	{
		if (value != null) { this.SpecifiesModeOfAuthenticationWithSB_OptionSetValue = new OptionSetValue((int)value); }
		else this.SpecifiesModeOfAuthenticationWithSB_OptionSetValue = null;
	}
}
///<summary>
///<para>Logical Name: authtype</para>
///</summary>
[AttributeLogicalNameAttribute("authtype")]
public OptionSetValue SpecifiesModeOfAuthenticationWithSB_OptionSetValue
{
	get { return this.GetPropertyValue<OptionSetValue>("authtype"); }
	set { this.SetPropertyValue<OptionSetValue>("authtype", value, "SpecifiesModeOfAuthenticationWithSB_OptionSetValue"); }
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="Service">CRM Organization Service</param>
/// <returns></returns>
public string SpecifiesModeOfAuthenticationWithSB_Text(IOrganizationService Service)
{
	return this.SpecifiesModeOfAuthenticationWithSB_OptionSetValue.GetOptionSetText(Service, this, "authtype");
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="AttributeMetadata">The attribute metadata previously retrieved using the 'GetAttributeMetadata' extension method on the IOrganizationService object.</param>
/// <returns></returns>
public string SpecifiesModeOfAuthenticationWithSB_Text(EnumAttributeMetadata AttributeMetadata)
{
	return AttributeMetadata.GetOptionSetText(this.SpecifiesModeOfAuthenticationWithSB_OptionSetValue.Value);
}
///<summary>
///<para>Logical Name: ismanaged</para>
///<para>True = Managed</para>
///<para>False = Unmanaged</para>
///</summary>
[AttributeLogicalNameAttribute("ismanaged")]
public bool? State
{
	get { return this.GetPropertyValue<bool?>("ismanaged"); }
}
/// <summary>
///Logical Name: userclaim
/// </summary>
[AttributeLogicalNameAttribute("userclaim")]
public eUserClaim? UserClaim
{
	get
	{
		if (UserClaim_OptionSetValue != null) { return (eUserClaim)UserClaim_OptionSetValue.Value; }
		return null;
	}
	set
	{
		if (value != null) { this.UserClaim_OptionSetValue = new OptionSetValue((int)value); }
		else this.UserClaim_OptionSetValue = null;
	}
}
///<summary>
///<para>Logical Name: userclaim</para>
///</summary>
[AttributeLogicalNameAttribute("userclaim")]
public OptionSetValue UserClaim_OptionSetValue
{
	get { return this.GetPropertyValue<OptionSetValue>("userclaim"); }
	set { this.SetPropertyValue<OptionSetValue>("userclaim", value, "UserClaim_OptionSetValue"); }
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="Service">CRM Organization Service</param>
/// <returns></returns>
public string UserClaim_Text(IOrganizationService Service)
{
	return this.UserClaim_OptionSetValue.GetOptionSetText(Service, this, "userclaim");
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="AttributeMetadata">The attribute metadata previously retrieved using the 'GetAttributeMetadata' extension method on the IOrganizationService object.</param>
/// <returns></returns>
public string UserClaim_Text(EnumAttributeMetadata AttributeMetadata)
{
	return AttributeMetadata.GetOptionSetText(this.UserClaim_OptionSetValue.Value);
}


        /// <summary>
/// <para><b>SdkMessageProcessingStep (Event Handler)</b></para>
/// <para>Schema Name: serviceendpoint_sdkmessageprocessingstep</para>
/// </summary>
public List<SdkMessageProcessingStep> GetSdkMessageProcessingSteps_EventHandler (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<SdkMessageProcessingStep>(Service, this.Id, "sdkmessageprocessingstep", "eventhandler", Columns); }
/// <summary>
/// <para><b>SdkMessageProcessingStep (Event Handler)</b></para>
/// <para>Schema Name: serviceendpoint_sdkmessageprocessingstep</para>
/// </summary>
public List<SdkMessageProcessingStep> GetSdkMessageProcessingSteps_EventHandler (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<SdkMessageProcessingStep>(Service, this.Id, "sdkmessageprocessingstep", "eventhandler", Columns); }
/// <summary>
/// <para><b>UserEntityInstanceData (Object Id)</b></para>
/// <para>Schema Name: userentityinstancedata_serviceendpoint</para>
/// </summary>
public List<UserEntityInstanceData> GetUserEntityInstanceData_ObjectId (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<UserEntityInstanceData>(Service, this.Id, "userentityinstancedata", "objectid", Columns); }
/// <summary>
/// <para><b>UserEntityInstanceData (Object Id)</b></para>
/// <para>Schema Name: userentityinstancedata_serviceendpoint</para>
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
public enum eConnectionMode
{
	///<summary><para>Normal</para>
	///<para>Value = 1</para></summary>
	[Description("Normal")]
	Normal = 1, 
	///<summary><para>Federated</para>
	///<para>Value = 2</para></summary>
	[Description("Federated")]
	Federated = 2
}
public enum eMessageFormat
{
	///<summary><para>Binary XML</para>
	///<para>Value = 1</para></summary>
	[Description("Binary XML")]
	BinaryXML = 1, 
	///<summary><para>Json</para>
	///<para>Value = 2</para></summary>
	[Description("Json")]
	Json = 2, 
	///<summary><para>Text XML</para>
	///<para>Value = 3</para></summary>
	[Description("Text XML")]
	TextXML = 3
}
public enum eContract
{
	///<summary><para>OneWay</para>
	///<para>Value = 1</para></summary>
	[Description("OneWay")]
	OneWay = 1, 
	///<summary><para>Queue</para>
	///<para>Value = 2</para></summary>
	[Description("Queue")]
	Queue = 2, 
	///<summary><para>Rest</para>
	///<para>Value = 3</para></summary>
	[Description("Rest")]
	Rest = 3, 
	///<summary><para>TwoWay</para>
	///<para>Value = 4</para></summary>
	[Description("TwoWay")]
	TwoWay = 4, 
	///<summary><para>Topic</para>
	///<para>Value = 5</para></summary>
	[Description("Topic")]
	Topic = 5, 
	///<summary><para>Queue (Persistent)</para>
	///<para>Value = 6</para></summary>
	[Description("Queue (Persistent)")]
	Queue_Persistent = 6, 
	///<summary><para>Event Hub</para>
	///<para>Value = 7</para></summary>
	[Description("Event Hub")]
	EventHub = 7
}
public enum eFormatForServiceBusNamespace
{
	///<summary><para>Namespace Name</para>
	///<para>Value = 1</para></summary>
	[Description("Namespace Name")]
	NamespaceName = 1, 
	///<summary><para>Namespace Address</para>
	///<para>Value = 2</para></summary>
	[Description("Namespace Address")]
	NamespaceAddress = 2
}
public enum eAuthenticationTypeForServiceBus
{
	///<summary><para>ACS</para>
	///<para>Value = 1</para></summary>
	[Description("ACS")]
	ACS = 1, 
	///<summary><para>SAS Key</para>
	///<para>Value = 2</para></summary>
	[Description("SAS Key")]
	SASKey = 2, 
	///<summary><para>SAS Token</para>
	///<para>Value = 3</para></summary>
	[Description("SAS Token")]
	SASToken = 3
}
public enum eUserClaim
{
	///<summary><para>None</para>
	///<para>Value = 1</para></summary>
	[Description("None")]
	None = 1, 
	///<summary><para>UserId</para>
	///<para>Value = 2</para></summary>
	[Description("UserId")]
	UserId = 2, 
	///<summary><para>UserInfo</para>
	///<para>Value = 3</para></summary>
	[Description("UserInfo")]
	UserInfo = 3
}


        public static class Properties
{
	/// <summary><para>createdonbehalfbyyominame</para>
	/// <para>createdonbehalfbyyominame</para></summary>
	public const string CreatedOnBehalfByYomiName = "createdonbehalfbyyominame";
	/// <summary><para>issaskeyset</para>
	/// <para>issaskeyset</para></summary>
	public const string IsSASKeySet = "issaskeyset";
	/// <summary><para>organizationid</para>
	/// <para>organizationid</para></summary>
	public const string OrganizationId = "organizationid";
	/// <summary><para>modifiedonbehalfbyyominame</para>
	/// <para>modifiedonbehalfbyyominame</para></summary>
	public const string ModifiedOnBehalfByYomiName = "modifiedonbehalfbyyominame";
	/// <summary><para>serviceendpointid</para>
	/// <para>serviceendpointid</para></summary>
	public const string ServiceEndpointId = "serviceendpointid";
	/// <summary><para>serviceendpointidunique</para>
	/// <para>serviceendpointidunique</para></summary>
	public const string ServiceEndpointIdUnique = "serviceendpointidunique";
	/// <summary><para>createdonbehalfbyname</para>
	/// <para>createdonbehalfbyname</para></summary>
	public const string CreatedOnBehalfByName = "createdonbehalfbyname";
	/// <summary><para>issastokenset</para>
	/// <para>issastokenset</para></summary>
	public const string IsSASTokenSet = "issastokenset";
	/// <summary><para>modifiedonbehalfbyname</para>
	/// <para>modifiedonbehalfbyname</para></summary>
	public const string ModifiedOnBehalfByName = "modifiedonbehalfbyname";
	/// <summary><para>Component State</para>
	/// <para>componentstate</para></summary>
	public const string ComponentState = "componentstate";
	/// <summary><para>Connection Mode</para>
	/// <para>connectionmode</para></summary>
	public const string ConnectionMode = "connectionmode";
	/// <summary><para>Content type of the message</para>
	/// <para>messageformat</para></summary>
	public const string ContentTypeOfTheMessage = "messageformat";
	/// <summary><para>Contract</para>
	/// <para>contract</para></summary>
	public const string Contract = "contract";
	/// <summary><para>Created By</para>
	/// <para>createdby</para></summary>
	public const string CreatedBy = "createdby";
	/// <summary><para>Created By (Delegate)</para>
	/// <para>createdonbehalfby</para></summary>
	public const string CreatedBy_Delegate = "createdonbehalfby";
	/// <summary><para>Created On</para>
	/// <para>createdon</para></summary>
	public const string CreatedOn = "createdon";
	/// <summary><para>Customizable</para>
	/// <para>iscustomizable</para></summary>
	public const string Customizable = "iscustomizable";
	/// <summary><para>Description</para>
	/// <para>description</para></summary>
	public const string Description = "description";
	/// <summary><para>Format of Service Bus Namespace</para>
	/// <para>namespaceformat</para></summary>
	public const string FormatOfServiceBusNamespace = "namespaceformat";
	/// <summary><para>Introduced Version</para>
	/// <para>introducedversion</para></summary>
	public const string IntroducedVersion = "introducedversion";
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
	/// <summary><para>Namespace Address</para>
	/// <para>namespaceaddress</para></summary>
	public const string NamespaceAddress = "namespaceaddress";
	/// <summary><para>Path</para>
	/// <para>path</para></summary>
	public const string Path = "path";
	/// <summary><para>Record Overwrite Time</para>
	/// <para>overwritetime</para></summary>
	public const string RecordOverwriteTime = "overwritetime";
	/// <summary><para>Service Namespace</para>
	/// <para>solutionnamespace</para></summary>
	public const string ServiceNamespace = "solutionnamespace";
	/// <summary><para>Shared Access Key</para>
	/// <para>saskey</para></summary>
	public const string SharedAccessKey = "saskey";
	/// <summary><para>Shared Access Key Name</para>
	/// <para>saskeyname</para></summary>
	public const string SharedAccessKeyName = "saskeyname";
	/// <summary><para>Shared Access Token</para>
	/// <para>sastoken</para></summary>
	public const string SharedAccessToken = "sastoken";
	/// <summary><para>Solution</para>
	/// <para>supportingsolutionid</para></summary>
	public const string Solution = "supportingsolutionid";
	/// <summary><para>Solution</para>
	/// <para>solutionid</para></summary>
	public const string Solution2 = "solutionid";
	/// <summary><para>Specifies mode of authentication with SB</para>
	/// <para>authtype</para></summary>
	public const string SpecifiesModeOfAuthenticationWithSB = "authtype";
	/// <summary><para>State</para>
	/// <para>ismanaged</para></summary>
	public const string State = "ismanaged";
	/// <summary><para>User Claim</para>
	/// <para>userclaim</para></summary>
	public const string UserClaim = "userclaim";
}

    }
}
