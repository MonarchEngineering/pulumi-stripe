// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Stripe.Inputs
{

    public sealed class PriceCurrencyOptionCustomUnitAmountArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Bool. Pass in `true` to enable `custom_unit_amount`, otherwise omit `custom_unit_amount`.
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// Int. The maximum unit amount the customer can specify for this item.
        /// </summary>
        [Input("maximum")]
        public Input<int>? Maximum { get; set; }

        /// <summary>
        /// Int. The minimum unit amount the customer can specify for this item. 
        /// Must be at least the minimum charge amount.
        /// </summary>
        [Input("minimum")]
        public Input<int>? Minimum { get; set; }

        /// <summary>
        /// Int. The starting unit amount which can be updated by the customer.
        /// </summary>
        [Input("preset")]
        public Input<int>? Preset { get; set; }

        public PriceCurrencyOptionCustomUnitAmountArgs()
        {
        }
        public static new PriceCurrencyOptionCustomUnitAmountArgs Empty => new PriceCurrencyOptionCustomUnitAmountArgs();
    }
}
