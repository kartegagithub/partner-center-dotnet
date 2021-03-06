﻿// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Analytics
{
    using GenericOperations;
    using Models;
    using Models.Analytics;

    /// <summary>
    /// Encapsulates the operations on the customer's licenses' deployment insights collection.
    /// </summary>
    public interface ICustomerLicensesDeploymentInsightsCollection : IPartnerComponent<string>, IEntireEntityCollectionRetrievalOperations<CustomerLicensesDeploymentInsights, ResourceCollection<CustomerLicensesDeploymentInsights>>
    {
    }
}