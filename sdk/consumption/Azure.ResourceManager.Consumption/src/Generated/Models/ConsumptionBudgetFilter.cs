// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary> May be used to filter budgets by resource group, resource, or meter. </summary>
    public partial class ConsumptionBudgetFilter
    {
        /// <summary> Initializes a new instance of ConsumptionBudgetFilter. </summary>
        public ConsumptionBudgetFilter()
        {
            And = new ChangeTrackingList<BudgetFilterProperties>();
        }

        /// <summary> Initializes a new instance of ConsumptionBudgetFilter. </summary>
        /// <param name="and"> The logical "AND" expression. Must have at least 2 items. </param>
        /// <param name="dimensions"> Has comparison expression for a dimension. </param>
        /// <param name="tags"> Has comparison expression for a tag. </param>
        internal ConsumptionBudgetFilter(IList<BudgetFilterProperties> and, BudgetComparisonExpression dimensions, BudgetComparisonExpression tags)
        {
            And = and;
            Dimensions = dimensions;
            Tags = tags;
        }

        /// <summary> The logical "AND" expression. Must have at least 2 items. </summary>
        public IList<BudgetFilterProperties> And { get; }
        /// <summary> Has comparison expression for a dimension. </summary>
        public BudgetComparisonExpression Dimensions { get; set; }
        /// <summary> Has comparison expression for a tag. </summary>
        public BudgetComparisonExpression Tags { get; set; }
    }
}
