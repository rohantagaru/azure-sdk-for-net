// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> A query of triggers. </summary>
    internal partial class DataFactoryTriggerQueryResult
    {
        /// <summary> Initializes a new instance of DataFactoryTriggerQueryResult. </summary>
        /// <param name="value"> List of triggers. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal DataFactoryTriggerQueryResult(IEnumerable<DataFactoryTriggerData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of DataFactoryTriggerQueryResult. </summary>
        /// <param name="value"> List of triggers. </param>
        /// <param name="continuationToken"> The continuation token for getting the next page of results, if any remaining results exist, null otherwise. </param>
        internal DataFactoryTriggerQueryResult(IReadOnlyList<DataFactoryTriggerData> value, string continuationToken)
        {
            Value = value;
            ContinuationToken = continuationToken;
        }

        /// <summary> List of triggers. </summary>
        public IReadOnlyList<DataFactoryTriggerData> Value { get; }
        /// <summary> The continuation token for getting the next page of results, if any remaining results exist, null otherwise. </summary>
        public string ContinuationToken { get; }
    }
}
