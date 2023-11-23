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
    public sealed class ShippingRateFixedAmount
    {
        /// <summary>
        /// Int. A non-negative integer in cents representing how much to charge.
        /// </summary>
        public readonly int Amount;
        /// <summary>
        /// String. Three-letter ISO currency code, in lowercase - [supported currencies](https://stripe.com/docs/currencies).
        /// </summary>
        public readonly string Currency;
        /// <summary>
        /// List(Resource). Please see argument details Currency Option
        /// </summary>
        public readonly ImmutableArray<Outputs.ShippingRateFixedAmountCurrencyOption> CurrencyOptions;

        [OutputConstructor]
        private ShippingRateFixedAmount(
            int amount,

            string currency,

            ImmutableArray<Outputs.ShippingRateFixedAmountCurrencyOption> currencyOptions)
        {
            Amount = amount;
            Currency = currency;
            CurrencyOptions = currencyOptions;
        }
    }
}
