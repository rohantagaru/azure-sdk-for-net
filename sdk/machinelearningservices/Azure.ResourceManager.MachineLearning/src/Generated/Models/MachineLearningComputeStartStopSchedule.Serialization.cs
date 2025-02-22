// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningComputeStartStopSchedule
    {
        internal static MachineLearningComputeStartStopSchedule DeserializeMachineLearningComputeStartStopSchedule(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<MachineLearningComputeProvisioningStatus> provisioningStatus = default;
            Optional<MachineLearningScheduleStatus> status = default;
            Optional<MachineLearningComputePowerAction> action = default;
            Optional<MachineLearningTriggerType> triggerType = default;
            Optional<MachineLearningRecurrenceTrigger> recurrence = default;
            Optional<CronTrigger> cron = default;
            Optional<MachineLearningScheduleBase> schedule = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        id = null;
                        continue;
                    }
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningStatus = new MachineLearningComputeProvisioningStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new MachineLearningScheduleStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("action"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    action = new MachineLearningComputePowerAction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("triggerType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    triggerType = new MachineLearningTriggerType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recurrence"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recurrence = MachineLearningRecurrenceTrigger.DeserializeMachineLearningRecurrenceTrigger(property.Value);
                    continue;
                }
                if (property.NameEquals("cron"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cron = CronTrigger.DeserializeCronTrigger(property.Value);
                    continue;
                }
                if (property.NameEquals("schedule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schedule = MachineLearningScheduleBase.DeserializeMachineLearningScheduleBase(property.Value);
                    continue;
                }
            }
            return new MachineLearningComputeStartStopSchedule(id.Value, Optional.ToNullable(provisioningStatus), Optional.ToNullable(status), Optional.ToNullable(action), Optional.ToNullable(triggerType), recurrence.Value, cron.Value, schedule.Value);
        }
    }
}
