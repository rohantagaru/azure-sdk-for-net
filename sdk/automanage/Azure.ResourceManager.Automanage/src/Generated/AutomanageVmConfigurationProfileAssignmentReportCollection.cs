// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Automanage
{
    /// <summary>
    /// A class representing a collection of <see cref="AutomanageVmConfigurationProfileAssignmentReportResource" /> and their operations.
    /// Each <see cref="AutomanageVmConfigurationProfileAssignmentReportResource" /> in the collection will belong to the same instance of <see cref="AutomanageVmConfigurationProfileAssignmentResource" />.
    /// To get an <see cref="AutomanageVmConfigurationProfileAssignmentReportCollection" /> instance call the GetAutomanageVmConfigurationProfileAssignmentReports method from an instance of <see cref="AutomanageVmConfigurationProfileAssignmentResource" />.
    /// </summary>
    public partial class AutomanageVmConfigurationProfileAssignmentReportCollection : ArmCollection, IEnumerable<AutomanageVmConfigurationProfileAssignmentReportResource>, IAsyncEnumerable<AutomanageVmConfigurationProfileAssignmentReportResource>
    {
        private readonly ClientDiagnostics _automanageVmConfigurationProfileAssignmentReportreportsClientDiagnostics;
        private readonly ReportsRestOperations _automanageVmConfigurationProfileAssignmentReportreportsRestClient;

        /// <summary> Initializes a new instance of the <see cref="AutomanageVmConfigurationProfileAssignmentReportCollection"/> class for mocking. </summary>
        protected AutomanageVmConfigurationProfileAssignmentReportCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AutomanageVmConfigurationProfileAssignmentReportCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AutomanageVmConfigurationProfileAssignmentReportCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _automanageVmConfigurationProfileAssignmentReportreportsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automanage", AutomanageVmConfigurationProfileAssignmentReportResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AutomanageVmConfigurationProfileAssignmentReportResource.ResourceType, out string automanageVmConfigurationProfileAssignmentReportreportsApiVersion);
            _automanageVmConfigurationProfileAssignmentReportreportsRestClient = new ReportsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, automanageVmConfigurationProfileAssignmentReportreportsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != "Microsoft.Automanage/configurationProfileAssignments")
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, "Microsoft.Automanage/configurationProfileAssignments"), nameof(id));
        }

        /// <summary>
        /// Get information about a report associated with a configuration profile assignment run
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}/reports/{reportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>reports_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="reportName"> The report name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="reportName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="reportName"/> is null. </exception>
        public virtual async Task<Response<AutomanageVmConfigurationProfileAssignmentReportResource>> GetAsync(string reportName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reportName, nameof(reportName));

            using var scope = _automanageVmConfigurationProfileAssignmentReportreportsClientDiagnostics.CreateScope("AutomanageVmConfigurationProfileAssignmentReportCollection.Get");
            scope.Start();
            try
            {
                var response = await _automanageVmConfigurationProfileAssignmentReportreportsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, reportName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomanageVmConfigurationProfileAssignmentReportResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get information about a report associated with a configuration profile assignment run
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}/reports/{reportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>reports_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="reportName"> The report name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="reportName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="reportName"/> is null. </exception>
        public virtual Response<AutomanageVmConfigurationProfileAssignmentReportResource> Get(string reportName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reportName, nameof(reportName));

            using var scope = _automanageVmConfigurationProfileAssignmentReportreportsClientDiagnostics.CreateScope("AutomanageVmConfigurationProfileAssignmentReportCollection.Get");
            scope.Start();
            try
            {
                var response = _automanageVmConfigurationProfileAssignmentReportreportsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, reportName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomanageVmConfigurationProfileAssignmentReportResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve a list of reports within a given configuration profile assignment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}/reports</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>reports_ListByConfigurationProfileAssignments</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AutomanageVmConfigurationProfileAssignmentReportResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AutomanageVmConfigurationProfileAssignmentReportResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automanageVmConfigurationProfileAssignmentReportreportsRestClient.CreateListByConfigurationProfileAssignmentsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new AutomanageVmConfigurationProfileAssignmentReportResource(Client, AutomanageConfigurationProfileAssignmentReportData.DeserializeAutomanageConfigurationProfileAssignmentReportData(e)), _automanageVmConfigurationProfileAssignmentReportreportsClientDiagnostics, Pipeline, "AutomanageVmConfigurationProfileAssignmentReportCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Retrieve a list of reports within a given configuration profile assignment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}/reports</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>reports_ListByConfigurationProfileAssignments</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AutomanageVmConfigurationProfileAssignmentReportResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AutomanageVmConfigurationProfileAssignmentReportResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automanageVmConfigurationProfileAssignmentReportreportsRestClient.CreateListByConfigurationProfileAssignmentsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new AutomanageVmConfigurationProfileAssignmentReportResource(Client, AutomanageConfigurationProfileAssignmentReportData.DeserializeAutomanageConfigurationProfileAssignmentReportData(e)), _automanageVmConfigurationProfileAssignmentReportreportsClientDiagnostics, Pipeline, "AutomanageVmConfigurationProfileAssignmentReportCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}/reports/{reportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>reports_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="reportName"> The report name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="reportName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="reportName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string reportName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reportName, nameof(reportName));

            using var scope = _automanageVmConfigurationProfileAssignmentReportreportsClientDiagnostics.CreateScope("AutomanageVmConfigurationProfileAssignmentReportCollection.Exists");
            scope.Start();
            try
            {
                var response = await _automanageVmConfigurationProfileAssignmentReportreportsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, reportName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}/reports/{reportName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>reports_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="reportName"> The report name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="reportName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="reportName"/> is null. </exception>
        public virtual Response<bool> Exists(string reportName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reportName, nameof(reportName));

            using var scope = _automanageVmConfigurationProfileAssignmentReportreportsClientDiagnostics.CreateScope("AutomanageVmConfigurationProfileAssignmentReportCollection.Exists");
            scope.Start();
            try
            {
                var response = _automanageVmConfigurationProfileAssignmentReportreportsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, reportName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AutomanageVmConfigurationProfileAssignmentReportResource> IEnumerable<AutomanageVmConfigurationProfileAssignmentReportResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AutomanageVmConfigurationProfileAssignmentReportResource> IAsyncEnumerable<AutomanageVmConfigurationProfileAssignmentReportResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
