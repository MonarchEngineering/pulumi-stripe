// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Stripe.Outputs
{

    [OutputType]
    public sealed class PortalConfigurationFeaturesSubscriptionPause
    {
        /// <summary>
        /// Bool. Whether the feature is enabled.
        /// </summary>
        public readonly bool? Enabled;

        [OutputConstructor]
        private PortalConfigurationFeaturesSubscriptionPause(bool? enabled)
        {
            Enabled = enabled;
        }
    }
}
