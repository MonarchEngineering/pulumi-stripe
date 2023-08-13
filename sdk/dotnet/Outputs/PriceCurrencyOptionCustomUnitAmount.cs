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
    public sealed class PriceCurrencyOptionCustomUnitAmount
    {
        /// <summary>
        /// Bool. Pass in `true` to enable `custom_unit_amount`, otherwise omit `custom_unit_amount`.
        /// </summary>
        public readonly bool Enabled;
        /// <summary>
        /// Int. The maximum unit amount the customer can specify for this item.
        /// </summary>
        public readonly int? Maximum;
        /// <summary>
        /// Int. The minimum unit amount the customer can specify for this item. 
        /// Must be at least the minimum charge amount.
        /// </summary>
        public readonly int? Minimum;
        /// <summary>
        /// Int. The starting unit amount which can be updated by the customer.
        /// </summary>
        public readonly int? Preset;

        [OutputConstructor]
        private PriceCurrencyOptionCustomUnitAmount(
            bool enabled,

            int? maximum,

            int? minimum,

            int? preset)
        {
            Enabled = enabled;
            Maximum = maximum;
            Minimum = minimum;
            Preset = preset;
        }
    }
}
