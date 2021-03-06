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
    [EntityLogicalNameAttribute("textanalyticsentitymapping")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XrmToolkit", "4.0")]
    public partial class TextAnalyticsEntityMapping : BaseProxyClass
    {
        public new const string LogicalName = "textanalyticsentitymapping";
        public const int ObjectTypeCode = 9945;
        public const string PrimaryIdAttribute = "textanalyticsentitymappingid";
        public const string PrimaryNameAttribute = "";
        
        static TextAnalyticsEntityMapping()
        {
            BaseProxyClass.RegisterProxyType(typeof(TextAnalyticsEntityMapping), "textanalyticsentitymapping");
            _textOptions = new Dictionary<string, eTextOptions>();
            _numberOptions = new Dictionary<string, eNumberOptions>();
            _errorStrings = new Dictionary<string, string>();
            TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
            NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
        }
        public TextAnalyticsEntityMapping() : base(new Entity("textanalyticsentitymapping")) { }
        public TextAnalyticsEntityMapping(Entity original) : base(original) { }
        public static string GetLogicalName() { return BaseProxyClass.GetLogicalName<TextAnalyticsEntityMapping>(); }
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
///<para>Logical Name: knowledgesearchmodelidname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("knowledgesearchmodelidname")]
public string KnowledgeSearchModelIdName
{
	get { return this.GetPropertyValue<string>("knowledgesearchmodelidname"); }
}
///<summary>
///<para>Logical Name: topicmodelconfigurationidname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("topicmodelconfigurationidname")]
public string TopicModelConfigurationIdName
{
	get { return this.GetPropertyValue<string>("topicmodelconfigurationidname"); }
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
///<para>Logical Name: advancedsimilarityruleidname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("advancedsimilarityruleidname")]
public string AdvancedSimilarityRuleIdName
{
	get { return this.GetPropertyValue<string>("advancedsimilarityruleidname"); }
}
///<summary>
///<para>Logical Name: similarityruleidname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("similarityruleidname")]
public string SimilarityRuleIdName
{
	get { return this.GetPropertyValue<string>("similarityruleidname"); }
}
///<summary>
///<para>Logical Name: advancedsimilarityruleid</para>
///</summary>
[AttributeLogicalNameAttribute("advancedsimilarityruleid")]
public EntityReference AdvancedSimilarityRuleId
{
	get { return this.GetPropertyValue<EntityReference>("advancedsimilarityruleid"); }
	set { this.SetPropertyValue<EntityReference>("advancedsimilarityruleid", value, "AdvancedSimilarityRuleId"); }
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
///<summary>
///<para>Logical Name: overwritetime</para>
///</summary>
[AttributeLogicalNameAttribute("overwritetime")]
public DateTime? CreatedOn
{
	get { return this.GetPropertyValue<DateTime?>("overwritetime"); }
}
///<summary>
///<para>Logical Name: istextmatchmapping</para>
///<para>True = Text Match</para>
///<para>False = Exact Match</para>
///</summary>
[AttributeLogicalNameAttribute("istextmatchmapping")]
public bool? Criteria
{
	get { return this.GetPropertyValue<bool?>("istextmatchmapping"); }
	set { this.SetPropertyValue<bool?>("istextmatchmapping", value, "Criteria"); }
}
///<summary>
///<para>Logical Name: entity</para>
///<para>Max Length: 50 characters</para>
///</summary>
[AttributeLogicalNameAttribute("entity")]
public string Entity
{
	get { return this.GetPropertyValue<string>("entity"); }
	set { this.SetPropertyValue("entity", value, 50, "Entity"); }
}
///<summary>
///<para>Logical Name: entitypicklist</para>
///</summary>
[AttributeLogicalNameAttribute("entitypicklist")]
public string Entity2
{
	get { return this.GetPropertyValue<string>("entitypicklist"); }
	set { this.SetPropertyValue<string>("entitypicklist", value, "Entity2"); }
}
///<summary>
///<para>Logical Name: entitydisplayname</para>
///<para>Max Length: 50 characters</para>
///</summary>
[AttributeLogicalNameAttribute("entitydisplayname")]
public string EntityName
{
	get { return this.GetPropertyValue<string>("entitydisplayname"); }
	set { this.SetPropertyValue("entitydisplayname", value, 50, "EntityName"); }
}
///<summary>
///<para>Logical Name: field</para>
///<para>Max Length: 50 characters</para>
///</summary>
[AttributeLogicalNameAttribute("field")]
public string Field
{
	get { return this.GetPropertyValue<string>("field"); }
	set { this.SetPropertyValue("field", value, 50, "Field"); }
}
/// <summary>
///Logical Name: fieldpicklist
/// </summary>
[AttributeLogicalNameAttribute("fieldpicklist")]
public eField? Field2
{
	get
	{
		if (Field2_OptionSetValue != null) { return (eField)Field2_OptionSetValue.Value; }
		return null;
	}
	set
	{
		if (value != null) { this.Field2_OptionSetValue = new OptionSetValue((int)value); }
		else this.Field2_OptionSetValue = null;
	}
}
///<summary>
///<para>Logical Name: fieldpicklist</para>
///</summary>
[AttributeLogicalNameAttribute("fieldpicklist")]
public OptionSetValue Field2_OptionSetValue
{
	get { return this.GetPropertyValue<OptionSetValue>("fieldpicklist"); }
	set { this.SetPropertyValue<OptionSetValue>("fieldpicklist", value, "Field2_OptionSetValue"); }
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="Service">CRM Organization Service</param>
/// <returns></returns>
public string Field2_Text(IOrganizationService Service)
{
	return this.Field2_OptionSetValue.GetOptionSetText(Service, this, "fieldpicklist");
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="AttributeMetadata">The attribute metadata previously retrieved using the 'GetAttributeMetadata' extension method on the IOrganizationService object.</param>
/// <returns></returns>
public string Field2_Text(EnumAttributeMetadata AttributeMetadata)
{
	return AttributeMetadata.GetOptionSetText(this.Field2_OptionSetValue.Value);
}
///<summary>
///<para>Logical Name: fielddisplayname</para>
///<para>Max Length: 50 characters</para>
///</summary>
[AttributeLogicalNameAttribute("fielddisplayname")]
public string FieldName
{
	get { return this.GetPropertyValue<string>("fielddisplayname"); }
	set { this.SetPropertyValue("fielddisplayname", value, 50, "FieldName"); }
}
///<summary>
///<para>Logical Name: knowledgesearchmodelid</para>
///</summary>
[AttributeLogicalNameAttribute("knowledgesearchmodelid")]
public EntityReference KnowledgeSearchModelId
{
	get { return this.GetPropertyValue<EntityReference>("knowledgesearchmodelid"); }
	set { this.SetPropertyValue<EntityReference>("knowledgesearchmodelid", value, "KnowledgeSearchModelId"); }
}
///<summary>
///<para>Logical Name: modeltype</para>
///<para>Minimum Value: 0</para>
///<para>Maximum Value: 2147483647</para>
///</summary>
[AttributeLogicalNameAttribute("modeltype")]
public int? ModelType
{
	get { return this.GetPropertyValue<int?>("modeltype"); }
	set { this.SetPropertyValue("modeltype", (int?)value, (int)0, (int)2147483647, "ModelType"); }
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
///<para>Logical Name: relationshipname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("relationshipname")]
public string RelationshipName
{
	get { return this.GetPropertyValue<string>("relationshipname"); }
	set { this.SetPropertyValue("relationshipname", value, 100, "RelationshipName"); }
}
///<summary>
///<para>Logical Name: similarityruleid</para>
///</summary>
[AttributeLogicalNameAttribute("similarityruleid")]
public EntityReference SimilarityRuleId
{
	get { return this.GetPropertyValue<EntityReference>("similarityruleid"); }
	set { this.SetPropertyValue<EntityReference>("similarityruleid", value, "SimilarityRuleId"); }
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
///<summary>
///<para>Key Property (Uniqueidentifier)</para>
///<para>Logical Name: textanalyticsentitymappingid</para>
///</summary>
[AttributeLogicalNameAttribute("textanalyticsentitymappingid")]
public Guid TextAnalyticsEntityMappingId
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
///<para>Logical Name: textanalyticsentitymappingidunique</para>
///</summary>
[AttributeLogicalNameAttribute("textanalyticsentitymappingidunique")]
public Guid TextAnalyticsEntityMappingUniqueId
{
	get { return this.GetPropertyValue<Guid>("textanalyticsentitymappingidunique"); }
}
///<summary>
///<para>Logical Name: topicmodelconfigurationid</para>
///</summary>
[AttributeLogicalNameAttribute("topicmodelconfigurationid")]
public EntityReference TopicModelConfigurationId
{
	get { return this.GetPropertyValue<EntityReference>("topicmodelconfigurationid"); }
	set { this.SetPropertyValue<EntityReference>("topicmodelconfigurationid", value, "TopicModelConfigurationId"); }
}


        

        

        

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
public enum eField
{
	///<summary><para>No</para>
	///<para>Value = 1</para></summary>
	[Description("No")]
	No = 1, 
	///<summary><para>Yes</para>
	///<para>Value = 2</para></summary>
	[Description("Yes")]
	Yes = 2
}


        public static class Properties
{
	/// <summary><para>knowledgesearchmodelidname</para>
	/// <para>knowledgesearchmodelidname</para></summary>
	public const string KnowledgeSearchModelIdName = "knowledgesearchmodelidname";
	/// <summary><para>topicmodelconfigurationidname</para>
	/// <para>topicmodelconfigurationidname</para></summary>
	public const string TopicModelConfigurationIdName = "topicmodelconfigurationidname";
	/// <summary><para>organizationidname</para>
	/// <para>organizationidname</para></summary>
	public const string OrganizationIdName = "organizationidname";
	/// <summary><para>advancedsimilarityruleidname</para>
	/// <para>advancedsimilarityruleidname</para></summary>
	public const string AdvancedSimilarityRuleIdName = "advancedsimilarityruleidname";
	/// <summary><para>similarityruleidname</para>
	/// <para>similarityruleidname</para></summary>
	public const string SimilarityRuleIdName = "similarityruleidname";
	/// <summary><para>Advanced Similarity RuleId</para>
	/// <para>advancedsimilarityruleid</para></summary>
	public const string AdvancedSimilarityRuleId = "advancedsimilarityruleid";
	/// <summary><para>Component State</para>
	/// <para>componentstate</para></summary>
	public const string ComponentState = "componentstate";
	/// <summary><para>Created On</para>
	/// <para>overwritetime</para></summary>
	public const string CreatedOn = "overwritetime";
	/// <summary><para>Criteria</para>
	/// <para>istextmatchmapping</para></summary>
	public const string Criteria = "istextmatchmapping";
	/// <summary><para>Entity</para>
	/// <para>entity</para></summary>
	public const string Entity = "entity";
	/// <summary><para>Entity</para>
	/// <para>entitypicklist</para></summary>
	public const string Entity2 = "entitypicklist";
	/// <summary><para>Entity Name</para>
	/// <para>entitydisplayname</para></summary>
	public const string EntityName = "entitydisplayname";
	/// <summary><para>Field</para>
	/// <para>field</para></summary>
	public const string Field = "field";
	/// <summary><para>Field</para>
	/// <para>fieldpicklist</para></summary>
	public const string Field2 = "fieldpicklist";
	/// <summary><para>Field Name</para>
	/// <para>fielddisplayname</para></summary>
	public const string FieldName = "fielddisplayname";
	/// <summary><para>Knowledge Search Model Id</para>
	/// <para>knowledgesearchmodelid</para></summary>
	public const string KnowledgeSearchModelId = "knowledgesearchmodelid";
	/// <summary><para>Model Type</para>
	/// <para>modeltype</para></summary>
	public const string ModelType = "modeltype";
	/// <summary><para>Organization</para>
	/// <para>organizationid</para></summary>
	public const string Organization = "organizationid";
	/// <summary><para>Relationship Name</para>
	/// <para>relationshipname</para></summary>
	public const string RelationshipName = "relationshipname";
	/// <summary><para>Similarity Rule Id</para>
	/// <para>similarityruleid</para></summary>
	public const string SimilarityRuleId = "similarityruleid";
	/// <summary><para>Solution</para>
	/// <para>supportingsolutionid</para></summary>
	public const string Solution = "supportingsolutionid";
	/// <summary><para>Solution</para>
	/// <para>solutionid</para></summary>
	public const string Solution2 = "solutionid";
	/// <summary><para>State</para>
	/// <para>ismanaged</para></summary>
	public const string State = "ismanaged";
	/// <summary><para>Text Analytics Entity Mapping</para>
	/// <para>textanalyticsentitymappingid</para></summary>
	public const string TextAnalyticsEntityMappingId = "textanalyticsentitymappingid";
	/// <summary><para>Text Analytics Entity Mapping Unique Id</para>
	/// <para>textanalyticsentitymappingidunique</para></summary>
	public const string TextAnalyticsEntityMappingUniqueId = "textanalyticsentitymappingidunique";
	/// <summary><para>Topic Model Configuration Id</para>
	/// <para>topicmodelconfigurationid</para></summary>
	public const string TopicModelConfigurationId = "topicmodelconfigurationid";
}

    }
}
