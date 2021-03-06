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
    [EntityLogicalNameAttribute("usersearchfacet")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XrmToolkit", "4.0")]
    public partial class UserSearchFacet : BaseProxyClass
    {
        public new const string LogicalName = "usersearchfacet";
        public const int ObjectTypeCode = 52;
        public const string PrimaryIdAttribute = "usersearchfacetid";
        public const string PrimaryNameAttribute = "";
        
        static UserSearchFacet()
        {
            BaseProxyClass.RegisterProxyType(typeof(UserSearchFacet), "usersearchfacet");
            _textOptions = new Dictionary<string, eTextOptions>();
            _numberOptions = new Dictionary<string, eNumberOptions>();
            _errorStrings = new Dictionary<string, string>();
            TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
            NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
        }
        public UserSearchFacet() : base(new Entity("usersearchfacet")) { }
        public UserSearchFacet(Entity original) : base(original) { }
        public static string GetLogicalName() { return BaseProxyClass.GetLogicalName<UserSearchFacet>(); }
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
///<para>Logical Name: facetorder</para>
///<para>Minimum Value: 1</para>
///<para>Maximum Value: 4</para>
///</summary>
[AttributeLogicalNameAttribute("facetorder")]
public int? FacetOrder
{
	get { return this.GetPropertyValue<int?>("facetorder"); }
	set { this.SetPropertyValue("facetorder", (int?)value, (int)1, (int)4, "FacetOrder"); }
}
///<summary>
///<para>Logical Name: attributename</para>
///<para>Max Length: 50 characters</para>
///</summary>
[AttributeLogicalNameAttribute("attributename")]
public string AttributeName
{
	get { return this.GetPropertyValue<string>("attributename"); }
	set { this.SetPropertyValue("attributename", value, 50, "AttributeName"); }
}
///<summary>
///<para>Key Property (Uniqueidentifier)</para>
///<para>Logical Name: usersearchfacetid</para>
///</summary>
[AttributeLogicalNameAttribute("usersearchfacetid")]
public Guid UserSearchFacetId
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
///<para>Logical Name: entityname</para>
///<para>Max Length: 64 characters</para>
///</summary>
[AttributeLogicalNameAttribute("entityname")]
public string EntityName
{
	get { return this.GetPropertyValue<string>("entityname"); }
	set { this.SetPropertyValue("entityname", value, 64, "EntityName"); }
}
///<summary>
///<para>Logical Name: systemuserid</para>
///</summary>
[AttributeLogicalNameAttribute("systemuserid")]
public Guid SystemUserId
{
	get { return this.GetPropertyValue<Guid>("systemuserid"); }
	set { this.SetPropertyValue<Guid>("systemuserid", value, "SystemUserId"); }
}


        

        

        

        

        public static class Properties
{
	/// <summary><para>facetorder</para>
	/// <para>facetorder</para></summary>
	public const string FacetOrder = "facetorder";
	/// <summary><para>attributename</para>
	/// <para>attributename</para></summary>
	public const string AttributeName = "attributename";
	/// <summary><para>usersearchfacetid</para>
	/// <para>usersearchfacetid</para></summary>
	public const string UserSearchFacetId = "usersearchfacetid";
	/// <summary><para>entityname</para>
	/// <para>entityname</para></summary>
	public const string EntityName = "entityname";
	/// <summary><para>systemuserid</para>
	/// <para>systemuserid</para></summary>
	public const string SystemUserId = "systemuserid";
}

    }
}
