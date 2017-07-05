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
    [EntityLogicalNameAttribute("entitlementcontacts")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XrmToolkit", "4.0")]
    public partial class EntitlementContacts : BaseProxyClass
    {
        public new const string LogicalName = "entitlementcontacts";
        public const int ObjectTypeCode = 7272;
        public const string PrimaryIdAttribute = "entitlementcontactid";
        public const string PrimaryNameAttribute = "";
        
        static EntitlementContacts()
        {
            BaseProxyClass.RegisterProxyType(typeof(EntitlementContacts), "entitlementcontacts");
            _textOptions = new Dictionary<string, eTextOptions>();
            _numberOptions = new Dictionary<string, eNumberOptions>();
            _errorStrings = new Dictionary<string, string>();
            TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
            NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
        }
        public EntitlementContacts() : base(new Entity("entitlementcontacts")) { }
        public EntitlementContacts(Entity original) : base(original) { }
        public static string GetLogicalName() { return BaseProxyClass.GetLogicalName<EntitlementContacts>(); }
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
///<para>Logical Name: entitlementcontactid</para>
///</summary>
[AttributeLogicalNameAttribute("entitlementcontactid")]
public Guid EntitlementContactId
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
///<para>Logical Name: versionnumber</para>
///</summary>
[AttributeLogicalNameAttribute("versionnumber")]
public int? VersionNumber
{
	get { return this.GetPropertyValue<int?>("versionnumber"); }
}
///<summary>
///<para>Logical Name: contactid</para>
///</summary>
[AttributeLogicalNameAttribute("contactid")]
public Guid ContactId
{
	get { return this.GetPropertyValue<Guid>("contactid"); }
}
///<summary>
///<para>Logical Name: entitlementid</para>
///</summary>
[AttributeLogicalNameAttribute("entitlementid")]
public Guid EntitlementId
{
	get { return this.GetPropertyValue<Guid>("entitlementid"); }
}


        

        /// <summary>
/// <para>Related Entity: <b>Contact</b></para>
/// <para>N:N Relationship</para>
/// <para>Schema Name: entitlementcontacts_association</para>
/// </summary>
public List<Contact> GetContacts (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedManyToManyEntities<Contact>(Service, this, "entitlementcontacts", "entitlementcontactid", "contact", "contactid", "entitlementcontacts", "entitlementid", "contactid", Columns); }
public List<Contact> GetContacts (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedManyToManyEntities<Contact>(Service, this, "entitlementcontacts", "entitlementcontactid", "contact", "contactid", "entitlementcontacts", "entitlementid", "contactid", Columns); }
public void RelateContacts (IOrganizationService Service, params Entity[] Items) { Service.RelateEntities(this, "entitlementcontacts_association", Items); }
public void RelateContacts (IOrganizationService Service, params EntityReference[] Items) { Service.RelateEntities(this, "entitlementcontacts_association", Items); }
public void UnRelateContacts (IOrganizationService Service, params Entity[] Items) { Service.UnRelateEntities(this, "entitlementcontacts_association", Items); }
public void UnRelateContacts (IOrganizationService Service, params EntityReference[] Items) { Service.UnRelateEntities(this, "entitlementcontacts_association", Items); }


        

        

        public static class Properties
{
	/// <summary><para>entitlementcontactid</para>
	/// <para>entitlementcontactid</para></summary>
	public const string EntitlementContactId = "entitlementcontactid";
	/// <summary><para>versionnumber</para>
	/// <para>versionnumber</para></summary>
	public const string VersionNumber = "versionnumber";
	/// <summary><para>contactid</para>
	/// <para>contactid</para></summary>
	public const string ContactId = "contactid";
	/// <summary><para>entitlementid</para>
	/// <para>entitlementid</para></summary>
	public const string EntitlementId = "entitlementid";
}

    }
}
