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
    [EntityLogicalNameAttribute("msdyn_organizationalunit_pricelevel")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XrmToolkit", "4.0")]
    public partial class msdyn_organizationalunit_pricelevel : BaseProxyClass
    {
        public new const string LogicalName = "msdyn_organizationalunit_pricelevel";
        public const int ObjectTypeCode = 10100;
        public const string PrimaryIdAttribute = "msdyn_organizationalunit_pricelevelid";
        public const string PrimaryNameAttribute = "";
        
        static msdyn_organizationalunit_pricelevel()
        {
            BaseProxyClass.RegisterProxyType(typeof(msdyn_organizationalunit_pricelevel), "msdyn_organizationalunit_pricelevel");
            _textOptions = new Dictionary<string, eTextOptions>();
            _numberOptions = new Dictionary<string, eNumberOptions>();
            _errorStrings = new Dictionary<string, string>();
            TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
            NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
        }
        public msdyn_organizationalunit_pricelevel() : base(new Entity("msdyn_organizationalunit_pricelevel")) { }
        public msdyn_organizationalunit_pricelevel(Entity original) : base(original) { }
        public static string GetLogicalName() { return BaseProxyClass.GetLogicalName<msdyn_organizationalunit_pricelevel>(); }
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
///<para>Logical Name: pricelevelid</para>
///</summary>
[AttributeLogicalNameAttribute("pricelevelid")]
public Guid Pricelevelid
{
	get { return this.GetPropertyValue<Guid>("pricelevelid"); }
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
///<para>Key Property (Uniqueidentifier)</para>
///<para>Logical Name: msdyn_organizationalunit_pricelevelid</para>
///</summary>
[AttributeLogicalNameAttribute("msdyn_organizationalunit_pricelevelid")]
public Guid Msdyn_organizationalunit_pricelevelId
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
///<para>Logical Name: msdyn_organizationalunitid</para>
///</summary>
[AttributeLogicalNameAttribute("msdyn_organizationalunitid")]
public Guid Msdyn_organizationalunitid
{
	get { return this.GetPropertyValue<Guid>("msdyn_organizationalunitid"); }
}


        

        /// <summary>
/// <para>Related Entity: <b>Organizational Unit</b></para>
/// <para>N:N Relationship</para>
/// <para>Schema Name: msdyn_organizationalunit_pricelevel</para>
/// </summary>
public List<OrganizationalUnit> GetOrganizationalUnits (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedManyToManyEntities<OrganizationalUnit>(Service, this, "msdyn_organizationalunit_pricelevel", "msdyn_organizationalunit_pricelevelid", "msdyn_organizationalunit", "msdyn_organizationalunitid", "msdyn_organizationalunit_pricelevel", "pricelevelid", "msdyn_organizationalunitid", Columns); }
public List<OrganizationalUnit> GetOrganizationalUnits (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedManyToManyEntities<OrganizationalUnit>(Service, this, "msdyn_organizationalunit_pricelevel", "msdyn_organizationalunit_pricelevelid", "msdyn_organizationalunit", "msdyn_organizationalunitid", "msdyn_organizationalunit_pricelevel", "pricelevelid", "msdyn_organizationalunitid", Columns); }
public void RelateOrganizationalUnits (IOrganizationService Service, params Entity[] Items) { Service.RelateEntities(this, "msdyn_organizationalunit_pricelevel", Items); }
public void RelateOrganizationalUnits (IOrganizationService Service, params EntityReference[] Items) { Service.RelateEntities(this, "msdyn_organizationalunit_pricelevel", Items); }
public void UnRelateOrganizationalUnits (IOrganizationService Service, params Entity[] Items) { Service.UnRelateEntities(this, "msdyn_organizationalunit_pricelevel", Items); }
public void UnRelateOrganizationalUnits (IOrganizationService Service, params EntityReference[] Items) { Service.UnRelateEntities(this, "msdyn_organizationalunit_pricelevel", Items); }


        

        

        public static class Properties
{
	/// <summary><para>pricelevelid</para>
	/// <para>pricelevelid</para></summary>
	public const string Pricelevelid = "pricelevelid";
	/// <summary><para>versionnumber</para>
	/// <para>versionnumber</para></summary>
	public const string VersionNumber = "versionnumber";
	/// <summary><para>msdyn_organizationalunit_pricelevelid</para>
	/// <para>msdyn_organizationalunit_pricelevelid</para></summary>
	public const string Msdyn_organizationalunit_pricelevelId = "msdyn_organizationalunit_pricelevelid";
	/// <summary><para>msdyn_organizationalunitid</para>
	/// <para>msdyn_organizationalunitid</para></summary>
	public const string Msdyn_organizationalunitid = "msdyn_organizationalunitid";
}

    }
}
