// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Key Encryption Key (KEK) information. </summary>
    public partial class SiteRecoveryKeyEncryptionKeyInfo
    {
        /// <summary> Initializes a new instance of SiteRecoveryKeyEncryptionKeyInfo. </summary>
        public SiteRecoveryKeyEncryptionKeyInfo()
        {
        }

        /// <summary> Initializes a new instance of SiteRecoveryKeyEncryptionKeyInfo. </summary>
        /// <param name="keyIdentifier"> The key URL / identifier. </param>
        /// <param name="keyVaultResourceArmId"> The KeyVault resource ARM Id for key. </param>
        internal SiteRecoveryKeyEncryptionKeyInfo(string keyIdentifier, ResourceIdentifier keyVaultResourceArmId)
        {
            KeyIdentifier = keyIdentifier;
            KeyVaultResourceArmId = keyVaultResourceArmId;
        }

        /// <summary> The key URL / identifier. </summary>
        public string KeyIdentifier { get; set; }
        /// <summary> The KeyVault resource ARM Id for key. </summary>
        public ResourceIdentifier KeyVaultResourceArmId { get; set; }
    }
}
