// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SignalR.Models
{
    /// <summary> Resource log configuration of a Microsoft.SignalRService resource. </summary>
    internal partial class SignalRResourceLogCategoryListResult
    {
        /// <summary> Initializes a new instance of SignalRResourceLogCategoryListResult. </summary>
        public SignalRResourceLogCategoryListResult()
        {
            Categories = new ChangeTrackingList<SignalRResourceLogCategory>();
        }

        /// <summary> Initializes a new instance of SignalRResourceLogCategoryListResult. </summary>
        /// <param name="categories"> Gets or sets the list of category configurations. </param>
        internal SignalRResourceLogCategoryListResult(IList<SignalRResourceLogCategory> categories)
        {
            Categories = categories;
        }

        /// <summary> Gets or sets the list of category configurations. </summary>
        public IList<SignalRResourceLogCategory> Categories { get; }
    }
}
