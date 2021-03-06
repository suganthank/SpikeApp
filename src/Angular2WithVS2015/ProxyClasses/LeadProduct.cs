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
    [EntityLogicalNameAttribute("leadproduct")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XrmToolkit", "4.0")]
    public partial class LeadProduct : BaseProxyClass
    {
        public new const string LogicalName = "leadproduct";
        public const int ObjectTypeCode = 27;
        public const string PrimaryIdAttribute = "leadproductid";
        public const string PrimaryNameAttribute = "";
        
        static LeadProduct()
        {
            BaseProxyClass.RegisterProxyType(typeof(LeadProduct), "leadproduct");
            _textOptions = new Dictionary<string, eTextOptions>();
            _numberOptions = new Dictionary<string, eNumberOptions>();
            _errorStrings = new Dictionary<string, string>();
            TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
            NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
        }
        public LeadProduct() : base(new Entity("leadproduct")) { }
        public LeadProduct(Entity original) : base(original) { }
        public static string GetLogicalName() { return BaseProxyClass.GetLogicalName<LeadProduct>(); }
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
///<para>Logical Name: versionnumber</para>
///</summary>
[AttributeLogicalNameAttribute("versionnumber")]
public int? VersionNumber
{
	get { return this.GetPropertyValue<int?>("versionnumber"); }
}
///<summary>
///<para>Logical Name: leadid</para>
///</summary>
[AttributeLogicalNameAttribute("leadid")]
public Guid LeadId
{
	get { return this.GetPropertyValue<Guid>("leadid"); }
}
///<summary>
///<para>Logical Name: productid</para>
///</summary>
[AttributeLogicalNameAttribute("productid")]
public Guid ProductId
{
	get { return this.GetPropertyValue<Guid>("productid"); }
}
///<summary>
///<para>Key Property (Uniqueidentifier)</para>
///<para>Logical Name: leadproductid</para>
///</summary>
[AttributeLogicalNameAttribute("leadproductid")]
public Guid LeadProductId
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
/// <para>Schema Name: userentityinstancedata_leadproduct</para>
/// </summary>
public List<UserEntityInstanceData> GetUserEntityInstanceData_ObjectId (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<UserEntityInstanceData>(Service, this.Id, "userentityinstancedata", "objectid", Columns); }
/// <summary>
/// <para><b>UserEntityInstanceData (Object Id)</b></para>
/// <para>Schema Name: userentityinstancedata_leadproduct</para>
/// </summary>
public List<UserEntityInstanceData> GetUserEntityInstanceData_ObjectId (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<UserEntityInstanceData>(Service, this.Id, "userentityinstancedata", "objectid", Columns); }


        /// <summary>
/// <para>Related Entity: <b>Lead</b></para>
/// <para>N:N Relationship</para>
/// <para>Schema Name: leadproduct_association</para>
/// </summary>
public List<Lead> GetLeads (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedManyToManyEntities<Lead>(Service, this, "leadproduct", "leadproductid", "lead", "leadid", "leadproduct", "productid", "leadid", Columns); }
public List<Lead> GetLeads (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedManyToManyEntities<Lead>(Service, this, "leadproduct", "leadproductid", "lead", "leadid", "leadproduct", "productid", "leadid", Columns); }
public void RelateLeads (IOrganizationService Service, params Entity[] Items) { Service.RelateEntities(this, "leadproduct_association", Items); }
public void RelateLeads (IOrganizationService Service, params EntityReference[] Items) { Service.RelateEntities(this, "leadproduct_association", Items); }
public void UnRelateLeads (IOrganizationService Service, params Entity[] Items) { Service.UnRelateEntities(this, "leadproduct_association", Items); }
public void UnRelateLeads (IOrganizationService Service, params EntityReference[] Items) { Service.UnRelateEntities(this, "leadproduct_association", Items); }


        

        

        public static class Properties
{
	/// <summary><para>versionnumber</para>
	/// <para>versionnumber</para></summary>
	public const string VersionNumber = "versionnumber";
	/// <summary><para>leadid</para>
	/// <para>leadid</para></summary>
	public const string LeadId = "leadid";
	/// <summary><para>productid</para>
	/// <para>productid</para></summary>
	public const string ProductId = "productid";
	/// <summary><para>leadproductid</para>
	/// <para>leadproductid</para></summary>
	public const string LeadProductId = "leadproductid";
}

    }
}
