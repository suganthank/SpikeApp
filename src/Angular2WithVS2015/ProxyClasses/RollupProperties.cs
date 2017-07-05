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
    [EntityLogicalNameAttribute("rollupproperties")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XrmToolkit", "4.0")]
    public partial class RollupProperties : BaseProxyClass
    {
        public new const string LogicalName = "rollupproperties";
        public const int ObjectTypeCode = 9510;
        public const string PrimaryIdAttribute = "rolluppropertiesid";
        public const string PrimaryNameAttribute = "";
        
        static RollupProperties()
        {
            BaseProxyClass.RegisterProxyType(typeof(RollupProperties), "rollupproperties");
            _textOptions = new Dictionary<string, eTextOptions>();
            _numberOptions = new Dictionary<string, eNumberOptions>();
            _errorStrings = new Dictionary<string, string>();
            TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
            NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
        }
        public RollupProperties() : base(new Entity("rollupproperties")) { }
        public RollupProperties(Entity original) : base(original) { }
        public static string GetLogicalName() { return BaseProxyClass.GetLogicalName<RollupProperties>(); }
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
///<para>Logical Name: aggregateentitytypecode</para>
///<para>Minimum Value: -2147483648</para>
///<para>Maximum Value: 2147483647</para>
///</summary>
[AttributeLogicalNameAttribute("aggregateentitytypecode")]
public int? AggregateEntityTypeCode
{
	get { return this.GetPropertyValue<int?>("aggregateentitytypecode"); }
}
///<summary>
///<para>Logical Name: allowhierarchyonsource</para>
///<para>True = Yes</para>
///<para>False = No</para>
///</summary>
[AttributeLogicalNameAttribute("allowhierarchyonsource")]
public bool? AllowHierarchyOnSource
{
	get { return this.GetPropertyValue<bool?>("allowhierarchyonsource"); }
}
///<summary>
///<para>Logical Name: bootstrapretrycount</para>
///<para>Minimum Value: -2147483648</para>
///<para>Maximum Value: 2147483647</para>
///</summary>
[AttributeLogicalNameAttribute("bootstrapretrycount")]
public int? BootstrapRetryCount
{
	get { return this.GetPropertyValue<int?>("bootstrapretrycount"); }
}
///<summary>
///<para>Logical Name: incrementalrollupasyncjobid</para>
///</summary>
[AttributeLogicalNameAttribute("incrementalrollupasyncjobid")]
public Guid CalculateEntityAsyncJobId
{
	get { return this.GetPropertyValue<Guid>("incrementalrollupasyncjobid"); }
}
///<summary>
///<para>Logical Name: bootstrapcurrentdepth</para>
///<para>Minimum Value: -2147483648</para>
///<para>Maximum Value: 2147483647</para>
///</summary>
[AttributeLogicalNameAttribute("bootstrapcurrentdepth")]
public int? DepthUsedForBootstrapCalculations
{
	get { return this.GetPropertyValue<int?>("bootstrapcurrentdepth"); }
}
///<summary>
///<para>Logical Name: isactivitypartyincluded</para>
///<para>Minimum Value: 0</para>
///<para>Maximum Value: 2</para>
///</summary>
[AttributeLogicalNameAttribute("isactivitypartyincluded")]
public int? FlagIndicatingWhetherActivityPartyIsIncluded
{
	get { return this.GetPropertyValue<int?>("isactivitypartyincluded"); }
}
///<summary>
///<para>Logical Name: initialvaluecalculationstatus</para>
///</summary>
[AttributeLogicalNameAttribute("initialvaluecalculationstatus")]
public OptionSetValue InitialValueCalculationStatus
{
	get { return this.GetPropertyValue<OptionSetValue>("initialvaluecalculationstatus"); }
}
///<summary>
///<para>Logical Name: lastcalculationtime</para>
///</summary>
[AttributeLogicalNameAttribute("lastcalculationtime")]
public DateTime? LastCalculationTime
{
	get { return this.GetPropertyValue<DateTime?>("lastcalculationtime"); }
}
///<summary>
///<para>Logical Name: bootstraprollupasyncjobid</para>
///</summary>
[AttributeLogicalNameAttribute("bootstraprollupasyncjobid")]
public Guid MassCalculateAsyncJobId
{
	get { return this.GetPropertyValue<Guid>("bootstraprollupasyncjobid"); }
}
///<summary>
///<para>Logical Name: aggregatetype</para>
///</summary>
[AttributeLogicalNameAttribute("aggregatetype")]
public OptionSetValue RollupAggregationType
{
	get { return this.GetPropertyValue<OptionSetValue>("aggregatetype"); }
}
///<summary>
///<para>Logical Name: rollupentitybasetablename</para>
///<para>Max Length: 64 characters</para>
///</summary>
[AttributeLogicalNameAttribute("rollupentitybasetablename")]
public string RollupEntityBaseTableName
{
	get { return this.GetPropertyValue<string>("rollupentitybasetablename"); }
}
///<summary>
///<para>Logical Name: rollupentityprimarykeyphysicalname</para>
///<para>Max Length: 64 characters</para>
///</summary>
[AttributeLogicalNameAttribute("rollupentityprimarykeyphysicalname")]
public string RollupEntityPrimaryKeyPhysicalName
{
	get { return this.GetPropertyValue<string>("rollupentityprimarykeyphysicalname"); }
}
///<summary>
///<para>Logical Name: rollupentitytypecode</para>
///<para>Minimum Value: -2147483648</para>
///<para>Maximum Value: 2147483647</para>
///</summary>
[AttributeLogicalNameAttribute("rollupentitytypecode")]
public int? RollupEntityTypeCode
{
	get { return this.GetPropertyValue<int?>("rollupentitytypecode"); }
}
///<summary>
///<para>Logical Name: datatype</para>
///<para>Max Length: 64 characters</para>
///</summary>
[AttributeLogicalNameAttribute("datatype")]
public string RollupFieldDataType
{
	get { return this.GetPropertyValue<string>("datatype"); }
}
///<summary>
///<para>Key Property (Uniqueidentifier)</para>
///<para>Logical Name: rolluppropertiesid</para>
///</summary>
[AttributeLogicalNameAttribute("rolluppropertiesid")]
public Guid RollupPropertiesId
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
///<para>Logical Name: rollupstateattributephysicalname</para>
///<para>Max Length: 64 characters</para>
///</summary>
[AttributeLogicalNameAttribute("rollupstateattributephysicalname")]
public string RollupStateAttributePhysicalName
{
	get { return this.GetPropertyValue<string>("rollupstateattributephysicalname"); }
}
///<summary>
///<para>Logical Name: rollupattributelogicalname</para>
///<para>Max Length: 50 characters</para>
///</summary>
[AttributeLogicalNameAttribute("rollupattributelogicalname")]
public string SourceAttributeLogicalName
{
	get { return this.GetPropertyValue<string>("rollupattributelogicalname"); }
}
///<summary>
///<para>Logical Name: rollupentitylogicalname</para>
///<para>Max Length: 64 characters</para>
///</summary>
[AttributeLogicalNameAttribute("rollupentitylogicalname")]
public string SourceEntityLogicalName
{
	get { return this.GetPropertyValue<string>("rollupentitylogicalname"); }
}
///<summary>
///<para>Logical Name: rollupfilterattributes</para>
///<para>Max Length: 4000 characters</para>
///</summary>
[AttributeLogicalNameAttribute("rollupfilterattributes")]
public string SourceFilterCriteria
{
	get { return this.GetPropertyValue<string>("rollupfilterattributes"); }
}
///<summary>
///<para>Logical Name: sourcehierarchicalrelationshipname</para>
///<para>Max Length: 4000 characters</para>
///</summary>
[AttributeLogicalNameAttribute("sourcehierarchicalrelationshipname")]
public string SourceHierarchicalRelationshipName
{
	get { return this.GetPropertyValue<string>("sourcehierarchicalrelationshipname"); }
}
///<summary>
///<para>Logical Name: aggregaterelationshipname</para>
///<para>Max Length: 4000 characters</para>
///</summary>
[AttributeLogicalNameAttribute("aggregaterelationshipname")]
public string Source_TargetRelationshipName
{
	get { return this.GetPropertyValue<string>("aggregaterelationshipname"); }
}
///<summary>
///<para>Logical Name: statecode</para>
///</summary>
[AttributeLogicalNameAttribute("statecode")]
public OptionSetValue Status
{
	get { return this.GetPropertyValue<OptionSetValue>("statecode"); }
}
/// <summary>
///Logical Name: statuscode
/// </summary>
[AttributeLogicalNameAttribute("statuscode")]
public eStatusReason? StatusReason
{
	get
	{
		if (StatusReason_OptionSetValue != null) { return (eStatusReason)StatusReason_OptionSetValue.Value; }
		return null;
	}
}
///<summary>
///<para>Logical Name: statuscode</para>
///</summary>
[AttributeLogicalNameAttribute("statuscode")]
public OptionSetValue StatusReason_OptionSetValue
{
	get { return this.GetPropertyValue<OptionSetValue>("statuscode"); }
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="Service">CRM Organization Service</param>
/// <returns></returns>
public string StatusReason_Text(IOrganizationService Service)
{
	return this.StatusReason_OptionSetValue.GetOptionSetText(Service, this, "statuscode");
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="AttributeMetadata">The attribute metadata previously retrieved using the 'GetAttributeMetadata' extension method on the IOrganizationService object.</param>
/// <returns></returns>
public string StatusReason_Text(EnumAttributeMetadata AttributeMetadata)
{
	return AttributeMetadata.GetOptionSetText(this.StatusReason_OptionSetValue.Value);
}
///<summary>
///<para>Logical Name: bootstrapstepnumber</para>
///<para>Minimum Value: -2147483648</para>
///<para>Maximum Value: 2147483647</para>
///</summary>
[AttributeLogicalNameAttribute("bootstrapstepnumber")]
public int? StepNumberToStartBootstrapExecution
{
	get { return this.GetPropertyValue<int?>("bootstrapstepnumber"); }
}
///<summary>
///<para>Logical Name: aggregateattributelogicalname</para>
///<para>Max Length: 50 characters</para>
///</summary>
[AttributeLogicalNameAttribute("aggregateattributelogicalname")]
public string TargetAttributeLogicalName
{
	get { return this.GetPropertyValue<string>("aggregateattributelogicalname"); }
}
///<summary>
///<para>Logical Name: aggregateentitylogicalname</para>
///<para>Max Length: 64 characters</para>
///</summary>
[AttributeLogicalNameAttribute("aggregateentitylogicalname")]
public string TargetEntityLogicalName
{
	get { return this.GetPropertyValue<string>("aggregateentitylogicalname"); }
}
///<summary>
///<para>Logical Name: aggregatefilterattributes</para>
///<para>Max Length: 4000 characters</para>
///</summary>
[AttributeLogicalNameAttribute("aggregatefilterattributes")]
public string TargetFilterCriteria
{
	get { return this.GetPropertyValue<string>("aggregatefilterattributes"); }
}
///<summary>
///<para>Logical Name: bootstraptargetpointer</para>
///<para>Minimum Value: -2147483648</para>
///<para>Maximum Value: 2147483647</para>
///</summary>
[AttributeLogicalNameAttribute("bootstraptargetpointer")]
public int? TargetPointerUsedForBootstrapCalculations
{
	get { return this.GetPropertyValue<int?>("bootstraptargetpointer"); }
}
///<summary>
///<para>Logical Name: versionnumber</para>
///</summary>
[AttributeLogicalNameAttribute("versionnumber")]
public int? VersionNumber
{
	get { return this.GetPropertyValue<int?>("versionnumber"); }
}


        /// <summary>
/// <para><b>RollupJob ()</b></para>
/// <para>Schema Name: rollupjob_rollupproperties</para>
/// </summary>
public List<RollupJob> GetRollupJobs (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<RollupJob>(Service, this.Id, "rollupjob", "rolluppropertiesid", Columns); }
/// <summary>
/// <para><b>RollupJob ()</b></para>
/// <para>Schema Name: rollupjob_rollupproperties</para>
/// </summary>
public List<RollupJob> GetRollupJobs (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities<RollupJob>(Service, this.Id, "rollupjob", "rolluppropertiesid", Columns); }


        

        

        public enum eStatusReason
{
	///<summary><para>Valid</para>
	///<para>Value = 1</para></summary>
	[Description("Valid")]
	Valid_Valid = 1, 
	///<summary><para>Invalid</para>
	///<para>Value = 2</para></summary>
	[Description("Invalid")]
	Invalid_Invalid = 2
}


        public static class Properties
{
	/// <summary><para>Aggregate entity type code</para>
	/// <para>aggregateentitytypecode</para></summary>
	public const string AggregateEntityTypeCode = "aggregateentitytypecode";
	/// <summary><para>Allow Hierarchy on Source</para>
	/// <para>allowhierarchyonsource</para></summary>
	public const string AllowHierarchyOnSource = "allowhierarchyonsource";
	/// <summary><para>Bootstrap Retry count</para>
	/// <para>bootstrapretrycount</para></summary>
	public const string BootstrapRetryCount = "bootstrapretrycount";
	/// <summary><para>Calculate entity async job Id</para>
	/// <para>incrementalrollupasyncjobid</para></summary>
	public const string CalculateEntityAsyncJobId = "incrementalrollupasyncjobid";
	/// <summary><para>Depth used for bootstrap calculations</para>
	/// <para>bootstrapcurrentdepth</para></summary>
	public const string DepthUsedForBootstrapCalculations = "bootstrapcurrentdepth";
	/// <summary><para>Flag indicating whether Activity Party is included</para>
	/// <para>isactivitypartyincluded</para></summary>
	public const string FlagIndicatingWhetherActivityPartyIsIncluded = "isactivitypartyincluded";
	/// <summary><para>Initial Value Calculation Status</para>
	/// <para>initialvaluecalculationstatus</para></summary>
	public const string InitialValueCalculationStatus = "initialvaluecalculationstatus";
	/// <summary><para>Last Calculation Time</para>
	/// <para>lastcalculationtime</para></summary>
	public const string LastCalculationTime = "lastcalculationtime";
	/// <summary><para>Mass calculate async job id.</para>
	/// <para>bootstraprollupasyncjobid</para></summary>
	public const string MassCalculateAsyncJobId = "bootstraprollupasyncjobid";
	/// <summary><para>Rollup Aggregation Type</para>
	/// <para>aggregatetype</para></summary>
	public const string RollupAggregationType = "aggregatetype";
	/// <summary><para>Rollup Entity Base Table Name</para>
	/// <para>rollupentitybasetablename</para></summary>
	public const string RollupEntityBaseTableName = "rollupentitybasetablename";
	/// <summary><para>Rollup Entity Primary Key Physical Name</para>
	/// <para>rollupentityprimarykeyphysicalname</para></summary>
	public const string RollupEntityPrimaryKeyPhysicalName = "rollupentityprimarykeyphysicalname";
	/// <summary><para>Rollup Entity Type Code</para>
	/// <para>rollupentitytypecode</para></summary>
	public const string RollupEntityTypeCode = "rollupentitytypecode";
	/// <summary><para>Rollup field data type</para>
	/// <para>datatype</para></summary>
	public const string RollupFieldDataType = "datatype";
	/// <summary><para>Rollup Properties Id</para>
	/// <para>rolluppropertiesid</para></summary>
	public const string RollupPropertiesId = "rolluppropertiesid";
	/// <summary><para>Rollup State Attribute Physical Name</para>
	/// <para>rollupstateattributephysicalname</para></summary>
	public const string RollupStateAttributePhysicalName = "rollupstateattributephysicalname";
	/// <summary><para>Source Attribute Logical Name</para>
	/// <para>rollupattributelogicalname</para></summary>
	public const string SourceAttributeLogicalName = "rollupattributelogicalname";
	/// <summary><para>Source Entity Logical Name</para>
	/// <para>rollupentitylogicalname</para></summary>
	public const string SourceEntityLogicalName = "rollupentitylogicalname";
	/// <summary><para>Source filter criteria</para>
	/// <para>rollupfilterattributes</para></summary>
	public const string SourceFilterCriteria = "rollupfilterattributes";
	/// <summary><para>Source hierarchical relationship name</para>
	/// <para>sourcehierarchicalrelationshipname</para></summary>
	public const string SourceHierarchicalRelationshipName = "sourcehierarchicalrelationshipname";
	/// <summary><para>Source-Target relationship name</para>
	/// <para>aggregaterelationshipname</para></summary>
	public const string Source_TargetRelationshipName = "aggregaterelationshipname";
	/// <summary><para>Status</para>
	/// <para>statecode</para></summary>
	public const string Status = "statecode";
	/// <summary><para>Status Reason</para>
	/// <para>statuscode</para></summary>
	public const string StatusReason = "statuscode";
	/// <summary><para>Step number to start bootstrap execution</para>
	/// <para>bootstrapstepnumber</para></summary>
	public const string StepNumberToStartBootstrapExecution = "bootstrapstepnumber";
	/// <summary><para>Target attribute logical name</para>
	/// <para>aggregateattributelogicalname</para></summary>
	public const string TargetAttributeLogicalName = "aggregateattributelogicalname";
	/// <summary><para>Target entity logical name</para>
	/// <para>aggregateentitylogicalname</para></summary>
	public const string TargetEntityLogicalName = "aggregateentitylogicalname";
	/// <summary><para>Target filter criteria</para>
	/// <para>aggregatefilterattributes</para></summary>
	public const string TargetFilterCriteria = "aggregatefilterattributes";
	/// <summary><para>Target pointer used for bootstrap calculations</para>
	/// <para>bootstraptargetpointer</para></summary>
	public const string TargetPointerUsedForBootstrapCalculations = "bootstraptargetpointer";
	/// <summary><para>Version Number</para>
	/// <para>versionnumber</para></summary>
	public const string VersionNumber = "versionnumber";
}

    }
}
