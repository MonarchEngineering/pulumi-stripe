// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Stripe.Inputs
{

    public sealed class PriceCurrencyOptionGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// String. Three-letter ISO currency code, in lowercase - [supported currencies](https://stripe.com/docs/currencies).
        /// </summary>
        [Input("currency", required: true)]
        public Input<string> Currency { get; set; } = null!;

        /// <summary>
        /// List(Resource). When set, 
        /// provides configuration for the amount to be adjusted by the customer during Checkout Sessions and Payment Links.
        /// See details in custom unit amount.
        /// </summary>
        [Input("customUnitAmount")]
        public Input<Inputs.PriceCurrencyOptionCustomUnitAmountGetArgs>? CustomUnitAmount { get; set; }

        /// <summary>
        /// String. Only required if a default tax behavior was not provided in the Stripe Tax settings. 
        /// Specifies whether the price is considered inclusive of taxes or exclusive of taxes.
        /// One of `inclusive`, `exclusive`, or `unspecified`.
        /// Once specified as either inclusive or exclusive, it cannot be changed.
        /// </summary>
        [Input("taxBehavior")]
        public Input<string>? TaxBehavior { get; set; }

        [Input("tiers")]
        private InputList<Inputs.PriceCurrencyOptionTierGetArgs>? _tiers;

        /// <summary>
        /// List(Resource). Each element represents a pricing tier. 
        /// This parameter requires `billing_scheme` to be set to `tiered`. This resource can be used more than once and follows
        /// the same fields as the root tiers block
        /// </summary>
        public InputList<Inputs.PriceCurrencyOptionTierGetArgs> Tiers
        {
            get => _tiers ?? (_tiers = new InputList<Inputs.PriceCurrencyOptionTierGetArgs>());
            set => _tiers = value;
        }

        /// <summary>
        /// Int. A positive integer in cents (or 0 for a free price) representing how much to charge.
        /// </summary>
        [Input("unitAmount")]
        public Input<int>? UnitAmount { get; set; }

        /// <summary>
        /// Float. Same as unit_amount, but accepts a decimal value in cents with at most 12
        /// decimal places. Only one of unit_amount and unit_amount_decimal can be set.
        /// </summary>
        [Input("unitAmountDecimal")]
        public Input<double>? UnitAmountDecimal { get; set; }

        public PriceCurrencyOptionGetArgs()
        {
        }
        public static new PriceCurrencyOptionGetArgs Empty => new PriceCurrencyOptionGetArgs();
    }
}
