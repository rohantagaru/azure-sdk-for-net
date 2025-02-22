// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    public partial class VmPlacementPolicyProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("vmMembers"u8);
            writer.WriteStartArray();
            foreach (var item in VmMembers)
            {
                if (item == null)
                {
                    writer.WriteNullValue();
                    continue;
                }
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("affinityType"u8);
            writer.WriteStringValue(AffinityType.ToString());
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(PolicyType.ToString());
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            writer.WriteEndObject();
        }

        internal static VmPlacementPolicyProperties DeserializeVmPlacementPolicyProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ResourceIdentifier> vmMembers = default;
            AvsPlacementPolicyAffinityType affinityType = default;
            PlacementPolicyType type = default;
            Optional<PlacementPolicyState> state = default;
            Optional<string> displayName = default;
            Optional<PlacementPolicyProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmMembers"u8))
                {
                    List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new ResourceIdentifier(item.GetString()));
                        }
                    }
                    vmMembers = array;
                    continue;
                }
                if (property.NameEquals("affinityType"u8))
                {
                    affinityType = new AvsPlacementPolicyAffinityType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new PlacementPolicyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new PlacementPolicyState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new PlacementPolicyProvisioningState(property.Value.GetString());
                    continue;
                }
            }
            return new VmPlacementPolicyProperties(type, Optional.ToNullable(state), displayName.Value, Optional.ToNullable(provisioningState), vmMembers, affinityType);
        }
    }
}
