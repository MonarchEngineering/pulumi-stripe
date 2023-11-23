// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Stripe.Inputs
{

    public sealed class ShippingRateDeliveryEstimateMaximumArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// String. A unit of time. Possible values `hour`, `day`, `business_day`, `week` and `month`.
        /// </summary>
        [Input("unit", required: true)]
        public Input<string> Unit { get; set; } = null!;

        /// <summary>
        /// Int. Must be greater than 0.
        /// </summary>
        [Input("value", required: true)]
        public Input<int> Value { get; set; } = null!;

        public ShippingRateDeliveryEstimateMaximumArgs()
        {
        }
        public static new ShippingRateDeliveryEstimateMaximumArgs Empty => new ShippingRateDeliveryEstimateMaximumArgs();
    }
}
