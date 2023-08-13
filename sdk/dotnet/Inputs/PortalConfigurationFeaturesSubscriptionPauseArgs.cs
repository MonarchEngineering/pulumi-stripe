// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Stripe.Inputs
{

    public sealed class PortalConfigurationFeaturesSubscriptionPauseArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Bool. Set to true to generate a shareable URL login_page.url that will take your customers to a hosted login page for the customer portal.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        public PortalConfigurationFeaturesSubscriptionPauseArgs()
        {
        }
        public static new PortalConfigurationFeaturesSubscriptionPauseArgs Empty => new PortalConfigurationFeaturesSubscriptionPauseArgs();
    }
}
