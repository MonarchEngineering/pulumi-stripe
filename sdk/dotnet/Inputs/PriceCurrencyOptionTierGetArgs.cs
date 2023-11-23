// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Stripe.Inputs
{

    public sealed class PriceCurrencyOptionTierGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Int. The flat billing amount for an entire tier, regardless of the number of units in the
        /// tier.
        /// </summary>
        [Input("flatAmount")]
        public Input<int>? FlatAmount { get; set; }

        /// <summary>
        /// Float. Same as `flat_amount`, but accepts a decimal value representing an integer
        /// in the minor units of the currency. Only one of `flat_amount` and `flat_amount_decimal` can be set.
        /// </summary>
        [Input("flatAmountDecimal")]
        public Input<double>? FlatAmountDecimal { get; set; }

        /// <summary>
        /// Int. The per-unit billing amount for each individual unit for which this tier applies.
        /// </summary>
        [Input("unitAmount")]
        public Input<int>? UnitAmount { get; set; }

        /// <summary>
        /// Float. Same as `unit_amount`, but accepts a decimal value in cents with at most 12
        /// decimal places. Only one of `unit_amount` and `unit_amount_decimal` can be set.
        /// </summary>
        [Input("unitAmountDecimal")]
        public Input<double>? UnitAmountDecimal { get; set; }

        /// <summary>
        /// Int. Specifies the upper bound of this tier. The lower bound of a tier is the upper bound of the
        /// previous tier adding one. Use `-1` to define a fallback tier.
        /// </summary>
        [Input("upTo")]
        public Input<int>? UpTo { get; set; }

        public PriceCurrencyOptionTierGetArgs()
        {
        }
        public static new PriceCurrencyOptionTierGetArgs Empty => new PriceCurrencyOptionTierGetArgs();
    }
}
