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
    [EntityLogicalNameAttribute("opportunitycompetitors")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XrmToolkit", "4.0")]
    public partial class OpportunityCompetitors : BaseProxyClass
    {
        public new const string LogicalName = "opportunitycompetitors";
        public const int ObjectTypeCode = 25;
        public const string PrimaryIdAttribute = "opportunitycompetitorid";
        public const string PrimaryNameAttribute = "";
        
        static OpportunityCompetitors()
        {
            BaseProxyClass.RegisterProxyType(typeof(OpportunityCompetitors), "opportunitycompetitors");
            _textOptions = new Dictionary<string, eTextOptions>();
            _numberOptions = new Dictionary<string, eNumberOptions>();
            _errorStrings = new Dictionary<string, string>();
            TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
            NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
        }
        public OpportunityCompetitors() : base(new Entity("opportunitycompetitors")) { }
        public OpportunityCompetitors(Entity original) : base(original) { }
        public static string GetLogicalName() { return BaseProxyClass.GetLogicalName<OpportunityCompetitors>(); }
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
///<para>Logical Name: opportunitycompetitorid</para>
///</summary>
[AttributeLogicalNameAttribute("opportunitycompetitorid")]
public Guid OpportunityCompetitorId
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
///<para>Logical Name: opportunityid</para>
///</summary>
[AttributeLogicalNameAttribute("opportunityid")]
public Guid OpportunityId
{
	get { return this.GetPropertyValue<Guid>("opportunityid"); }
}
///<summary>
///<para>Logical Name: competitorid</para>
///</summary>
[AttributeLogicalNameAttribute("competitorid")]
public Guid CompetitorId
{
	get { return this.GetPropertyValue<Guid>("competitorid"); }
}


        

        /// <summary>
/// <para>Related Entity: <b>Opportunity</b></para>
/// <para>N:N Relationship</para>
/// <para>Schema Name: opportunitycompetitors_association</para>
/// </summary>
public List<Opportunity> GetOpportunities (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedManyToManyEntities<Opportunity>(Service, this, "opportunitycompetitors", "opportunitycompetitorid", "opportunity", "opportunityid", "opportunitycompetitors", "competitorid", "opportunityid", Columns); }
public List<Opportunity> GetOpportunities (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedManyToManyEntities<Opportunity>(Service, this, "opportunitycompetitors", "opportunitycompetitorid", "opportunity", "opportunityid", "opportunitycompetitors", "competitorid", "opportunityid", Columns); }
public void RelateOpportunities (IOrganizationService Service, params Entity[] Items) { Service.RelateEntities(this, "opportunitycompetitors_association", Items); }
public void RelateOpportunities (IOrganizationService Service, params EntityReference[] Items) { Service.RelateEntities(this, "opportunitycompetitors_association", Items); }
public void UnRelateOpportunities (IOrganizationService Service, params Entity[] Items) { Service.UnRelateEntities(this, "opportunitycompetitors_association", Items); }
public void UnRelateOpportunities (IOrganizationService Service, params EntityReference[] Items) { Service.UnRelateEntities(this, "opportunitycompetitors_association", Items); }


        

        

        public static class Properties
{
	/// <summary><para>opportunitycompetitorid</para>
	/// <para>opportunitycompetitorid</para></summary>
	public const string OpportunityCompetitorId = "opportunitycompetitorid";
	/// <summary><para>versionnumber</para>
	/// <para>versionnumber</para></summary>
	public const string VersionNumber = "versionnumber";
	/// <summary><para>opportunityid</para>
	/// <para>opportunityid</para></summary>
	public const string OpportunityId = "opportunityid";
	/// <summary><para>competitorid</para>
	/// <para>competitorid</para></summary>
	public const string CompetitorId = "competitorid";
}

    }
}
