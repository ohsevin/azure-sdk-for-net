// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of EncryptionProtector and their operations over its parent. </summary>
    public partial class EncryptionProtectorCollection : ArmCollection, IEnumerable<EncryptionProtector>, IAsyncEnumerable<EncryptionProtector>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly EncryptionProtectorsRestOperations _encryptionProtectorsRestClient;

        /// <summary> Initializes a new instance of the <see cref="EncryptionProtectorCollection"/> class for mocking. </summary>
        protected EncryptionProtectorCollection()
        {
        }

        /// <summary> Initializes a new instance of EncryptionProtectorCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal EncryptionProtectorCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _encryptionProtectorsRestClient = new EncryptionProtectorsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => SqlServer.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/encryptionProtector/{encryptionProtectorName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: EncryptionProtectors_CreateOrUpdate
        /// <summary> Updates an existing encryption protector. </summary>
        /// <param name="encryptionProtectorName"> The name of the encryption protector to be updated. </param>
        /// <param name="parameters"> The requested encryption protector resource state. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual EncryptionProtectorCreateOrUpdateOperation CreateOrUpdate(EncryptionProtectorName encryptionProtectorName, EncryptionProtectorData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("EncryptionProtectorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _encryptionProtectorsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, encryptionProtectorName, parameters, cancellationToken);
                var operation = new EncryptionProtectorCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _encryptionProtectorsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, encryptionProtectorName, parameters).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/encryptionProtector/{encryptionProtectorName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: EncryptionProtectors_CreateOrUpdate
        /// <summary> Updates an existing encryption protector. </summary>
        /// <param name="encryptionProtectorName"> The name of the encryption protector to be updated. </param>
        /// <param name="parameters"> The requested encryption protector resource state. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<EncryptionProtectorCreateOrUpdateOperation> CreateOrUpdateAsync(EncryptionProtectorName encryptionProtectorName, EncryptionProtectorData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("EncryptionProtectorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _encryptionProtectorsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, encryptionProtectorName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new EncryptionProtectorCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _encryptionProtectorsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, encryptionProtectorName, parameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/encryptionProtector/{encryptionProtectorName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: EncryptionProtectors_Get
        /// <summary> Gets a server encryption protector. </summary>
        /// <param name="encryptionProtectorName"> The name of the encryption protector to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<EncryptionProtector> Get(EncryptionProtectorName encryptionProtectorName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EncryptionProtectorCollection.Get");
            scope.Start();
            try
            {
                var response = _encryptionProtectorsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, encryptionProtectorName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EncryptionProtector(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/encryptionProtector/{encryptionProtectorName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: EncryptionProtectors_Get
        /// <summary> Gets a server encryption protector. </summary>
        /// <param name="encryptionProtectorName"> The name of the encryption protector to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<EncryptionProtector>> GetAsync(EncryptionProtectorName encryptionProtectorName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EncryptionProtectorCollection.Get");
            scope.Start();
            try
            {
                var response = await _encryptionProtectorsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, encryptionProtectorName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new EncryptionProtector(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="encryptionProtectorName"> The name of the encryption protector to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<EncryptionProtector> GetIfExists(EncryptionProtectorName encryptionProtectorName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EncryptionProtectorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _encryptionProtectorsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, encryptionProtectorName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<EncryptionProtector>(null, response.GetRawResponse())
                    : Response.FromValue(new EncryptionProtector(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="encryptionProtectorName"> The name of the encryption protector to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<EncryptionProtector>> GetIfExistsAsync(EncryptionProtectorName encryptionProtectorName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EncryptionProtectorCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _encryptionProtectorsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, encryptionProtectorName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<EncryptionProtector>(null, response.GetRawResponse())
                    : Response.FromValue(new EncryptionProtector(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="encryptionProtectorName"> The name of the encryption protector to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(EncryptionProtectorName encryptionProtectorName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EncryptionProtectorCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(encryptionProtectorName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="encryptionProtectorName"> The name of the encryption protector to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<bool>> ExistsAsync(EncryptionProtectorName encryptionProtectorName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EncryptionProtectorCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(encryptionProtectorName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/encryptionProtector
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: EncryptionProtectors_ListByServer
        /// <summary> Gets a list of server encryption protectors. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EncryptionProtector" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EncryptionProtector> GetAll(CancellationToken cancellationToken = default)
        {
            Page<EncryptionProtector> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("EncryptionProtectorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _encryptionProtectorsRestClient.ListByServer(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new EncryptionProtector(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<EncryptionProtector> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("EncryptionProtectorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _encryptionProtectorsRestClient.ListByServerNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new EncryptionProtector(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/encryptionProtector
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: EncryptionProtectors_ListByServer
        /// <summary> Gets a list of server encryption protectors. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EncryptionProtector" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EncryptionProtector> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<EncryptionProtector>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("EncryptionProtectorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _encryptionProtectorsRestClient.ListByServerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new EncryptionProtector(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<EncryptionProtector>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("EncryptionProtectorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _encryptionProtectorsRestClient.ListByServerNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new EncryptionProtector(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<EncryptionProtector> IEnumerable<EncryptionProtector>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<EncryptionProtector> IAsyncEnumerable<EncryptionProtector>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, EncryptionProtector, EncryptionProtectorData> Construct() { }
    }
}
