// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class MicrosoftDynamicsCRMBooleanOptionSetMetadata : MicrosoftDynamicsCRMOptionSetMetadataBase
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMBooleanOptionSetMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMBooleanOptionSetMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMBooleanOptionSetMetadata class.
        /// </summary>
        /// <param name="optionSetType">Possible values include: 'Picklist',
        /// 'State', 'Status', 'Boolean'</param>
        public MicrosoftDynamicsCRMBooleanOptionSetMetadata(bool? hasChanged = default(bool?), string metadataId = default(string), MicrosoftDynamicsCRMLabel description = default(MicrosoftDynamicsCRMLabel), MicrosoftDynamicsCRMLabel displayName = default(MicrosoftDynamicsCRMLabel), string introducedVersion = default(string), bool? isCustomOptionSet = default(bool?), MicrosoftDynamicsCRMBooleanManagedProperty isCustomizable = default(MicrosoftDynamicsCRMBooleanManagedProperty), bool? isGlobal = default(bool?), bool? isManaged = default(bool?), string name = default(string), string optionSetType = default(string), MicrosoftDynamicsCRMOptionMetadata falseOption = default(MicrosoftDynamicsCRMOptionMetadata), MicrosoftDynamicsCRMOptionMetadata trueOption = default(MicrosoftDynamicsCRMOptionMetadata))
            : base(hasChanged, metadataId, description, displayName, introducedVersion, isCustomOptionSet, isCustomizable, isGlobal, isManaged, name, optionSetType)
        {
            FalseOption = falseOption;
            TrueOption = trueOption;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FalseOption")]
        public MicrosoftDynamicsCRMOptionMetadata FalseOption { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TrueOption")]
        public MicrosoftDynamicsCRMOptionMetadata TrueOption { get; set; }

    }
}
