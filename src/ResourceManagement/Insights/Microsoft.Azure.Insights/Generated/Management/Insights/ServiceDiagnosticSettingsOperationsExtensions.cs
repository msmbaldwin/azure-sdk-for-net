// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Insights
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for ServiceDiagnosticSettingsOperations.
    /// </summary>
    public static partial class ServiceDiagnosticSettingsOperationsExtensions
    {
            /// <summary>
            /// Gets the active diagnostic settings for the specified resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceUri'>
            /// The identifier of the resource.
            /// </param>
            public static ServiceDiagnosticSettingsResource Get(this IServiceDiagnosticSettingsOperations operations, string resourceUri)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IServiceDiagnosticSettingsOperations)s).GetAsync(resourceUri), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the active diagnostic settings for the specified resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceUri'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ServiceDiagnosticSettingsResource> GetAsync(this IServiceDiagnosticSettingsOperations operations, string resourceUri, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceUri, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update new diagnostic settings for the specified resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceUri'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the operation.
            /// </param>
            public static ServiceDiagnosticSettingsResource CreateOrUpdate(this IServiceDiagnosticSettingsOperations operations, string resourceUri, ServiceDiagnosticSettingsCreateOrUpdateParameters parameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IServiceDiagnosticSettingsOperations)s).CreateOrUpdateAsync(resourceUri, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update new diagnostic settings for the specified resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceUri'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ServiceDiagnosticSettingsResource> CreateOrUpdateAsync(this IServiceDiagnosticSettingsOperations operations, string resourceUri, ServiceDiagnosticSettingsCreateOrUpdateParameters parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceUri, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
