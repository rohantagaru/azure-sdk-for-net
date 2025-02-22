// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The instance pool capability. </summary>
    public partial class InstancePoolEditionCapability
    {
        /// <summary> Initializes a new instance of InstancePoolEditionCapability. </summary>
        internal InstancePoolEditionCapability()
        {
            SupportedFamilies = new ChangeTrackingList<InstancePoolFamilyCapability>();
        }

        /// <summary> Initializes a new instance of InstancePoolEditionCapability. </summary>
        /// <param name="name"> The instance pool version name. </param>
        /// <param name="supportedFamilies"> The supported families. </param>
        /// <param name="status"> The status of the capability. </param>
        /// <param name="reason"> The reason for the capability not being available. </param>
        internal InstancePoolEditionCapability(string name, IReadOnlyList<InstancePoolFamilyCapability> supportedFamilies, SqlCapabilityStatus? status, string reason)
        {
            Name = name;
            SupportedFamilies = supportedFamilies;
            Status = status;
            Reason = reason;
        }

        /// <summary> The instance pool version name. </summary>
        public string Name { get; }
        /// <summary> The supported families. </summary>
        public IReadOnlyList<InstancePoolFamilyCapability> SupportedFamilies { get; }
        /// <summary> The status of the capability. </summary>
        public SqlCapabilityStatus? Status { get; }
        /// <summary> The reason for the capability not being available. </summary>
        public string Reason { get; }
    }
}
