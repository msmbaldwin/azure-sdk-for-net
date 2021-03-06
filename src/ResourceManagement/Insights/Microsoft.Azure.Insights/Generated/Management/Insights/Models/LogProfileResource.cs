// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Insights.Models
{
    using System.Linq;

    /// <summary>
    /// The log profile resource.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class LogProfileResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the LogProfileResource class.
        /// </summary>
        public LogProfileResource() { }

        /// <summary>
        /// Initializes a new instance of the LogProfileResource class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="id">Azure resource Id</param>
        /// <param name="name">Azure resource name</param>
        /// <param name="type">Azure resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="storageAccountId">the resource id of the storage
        /// account.</param>
        /// <param name="serviceBusRuleId">the resource id of the service bus
        /// rule.</param>
        /// <param name="locations">the locations.</param>
        /// <param name="categories"> the categories.</param>
        /// <param name="retentionPolicy">the retention policy for this
        /// log.</param>
        public LogProfileResource(string location, string id = default(string), string name = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), string storageAccountId = default(string), string serviceBusRuleId = default(string), System.Collections.Generic.IList<string> locations = default(System.Collections.Generic.IList<string>), System.Collections.Generic.IList<string> categories = default(System.Collections.Generic.IList<string>), RetentionPolicy retentionPolicy = default(RetentionPolicy))
            : base(location, id, name, type, tags)
        {
            StorageAccountId = storageAccountId;
            ServiceBusRuleId = serviceBusRuleId;
            Locations = locations;
            Categories = categories;
            RetentionPolicy = retentionPolicy;
        }

        /// <summary>
        /// Gets or sets the resource id of the storage account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.storageAccountId")]
        public string StorageAccountId { get; set; }

        /// <summary>
        /// Gets or sets the resource id of the service bus rule.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.serviceBusRuleId")]
        public string ServiceBusRuleId { get; set; }

        /// <summary>
        /// Gets or sets the locations.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.locations")]
        public System.Collections.Generic.IList<string> Locations { get; set; }

        /// <summary>
        /// Gets or sets  the categories.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.categories")]
        public System.Collections.Generic.IList<string> Categories { get; set; }

        /// <summary>
        /// Gets or sets the retention policy for this log.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.retentionPolicy")]
        public RetentionPolicy RetentionPolicy { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (this.RetentionPolicy != null)
            {
                this.RetentionPolicy.Validate();
            }
        }
    }
}
