// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class MicrosoftDynamicsCRMStatusOptionMetadata : MicrosoftDynamicsCRMOptionMetadata
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMStatusOptionMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMStatusOptionMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMStatusOptionMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMStatusOptionMetadata(string color = default(string), MicrosoftDynamicsCRMLabel description = default(MicrosoftDynamicsCRMLabel), bool? hasChanged = default(bool?), bool? isManaged = default(bool?), MicrosoftDynamicsCRMLabel label = default(MicrosoftDynamicsCRMLabel), string metadataId = default(string), int? value = default(int?), int? state = default(int?), string transitionData = default(string))
            : base(color, description, hasChanged, isManaged, label, metadataId, value)
        {
            State = state;
            TransitionData = transitionData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "State")]
        public int? State { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TransitionData")]
        public string TransitionData { get; set; }

    }
}
