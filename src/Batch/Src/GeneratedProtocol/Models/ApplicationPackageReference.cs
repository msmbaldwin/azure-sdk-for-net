// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// A reference to an application package to be installed on compute nodes
    /// in a pool.
    /// </summary>
    public partial class ApplicationPackageReference
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationPackageReference
        /// class.
        /// </summary>
        public ApplicationPackageReference() { }

        /// <summary>
        /// Initializes a new instance of the ApplicationPackageReference
        /// class.
        /// </summary>
        public ApplicationPackageReference(string applicationId, string version = default(string))
        {
            ApplicationId = applicationId;
            Version = version;
        }

        /// <summary>
        /// Gets or sets the application package id.
        /// </summary>
        [JsonProperty(PropertyName = "applicationId")]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets or sets the application package version. If not specified,
        /// the default is used.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (ApplicationId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ApplicationId");
            }
        }
    }
}