// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Vault setting properties. </summary>
    public partial class SiteRecoveryVaultSettingProperties
    {
        /// <summary> Initializes a new instance of SiteRecoveryVaultSettingProperties. </summary>
        internal SiteRecoveryVaultSettingProperties()
        {
        }

        /// <summary> Initializes a new instance of SiteRecoveryVaultSettingProperties. </summary>
        /// <param name="migrationSolutionId"> The migration solution ARM Id. </param>
        /// <param name="vmwareToAzureProviderType"> VMware to Azure provider type. </param>
        internal SiteRecoveryVaultSettingProperties(ResourceIdentifier migrationSolutionId, string vmwareToAzureProviderType)
        {
            MigrationSolutionId = migrationSolutionId;
            VMwareToAzureProviderType = vmwareToAzureProviderType;
        }

        /// <summary> The migration solution ARM Id. </summary>
        public ResourceIdentifier MigrationSolutionId { get; }
        /// <summary> VMware to Azure provider type. </summary>
        public string VMwareToAzureProviderType { get; }
    }
}
