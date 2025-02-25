﻿using System;
using Kontent.Ai.Delivery.Abstractions;
using Kontent.Ai.Delivery.Configuration;

namespace Kontent.Ai.Delivery.Builders.DeliveryClient
{
    /// <summary>
    /// A builder of <see cref="IDeliveryClient"/> instances.
    /// </summary>
    public sealed class DeliveryClientBuilder
    {
        private static IDeliveryClientBuilder Builder => new DeliveryClientBuilderImplementation();

        /// <summary>
        /// Use project identifier.
        /// </summary>
        /// <param name="projectId">The identifier of a Kontent.ai project.</param>
        public static IOptionalClientSetup WithProjectId(string projectId)
            => Builder.BuildWithProjectId(projectId);

        /// <summary>
        /// Use project identifier.
        /// </summary>
        /// <param name="projectId">The identifier of a Kontent.ai project.</param>
        public static IOptionalClientSetup WithProjectId(Guid projectId)
            => Builder.BuildWithProjectId(projectId);

        /// <summary>
        /// Use additional configuration.
        /// </summary>
        /// <param name="buildDeliveryOptions">A delegate that creates an instance of the <see cref="DeliveryOptions"/> using the specified <see cref="DeliveryOptionsBuilder"/>.</param>
        public static IOptionalClientSetup WithOptions(Func<IDeliveryOptionsBuilder, DeliveryOptions> buildDeliveryOptions)
            => Builder.BuildWithDeliveryOptions(buildDeliveryOptions);
    }
}
