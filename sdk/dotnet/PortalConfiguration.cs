// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Stripe
{
    /// <summary>
    /// With this resource, you can create a Customer Portal Configuration - [Stripe API portal configuration documentation](https://stripe.com/docs/api/customer_portal/configuration).
    /// 
    /// The Billing customer portal is a Stripe-hosted UI for subscription and billing management.
    /// 
    /// A portal configuration describes the functionality and features that you want to provide to your customers through the portal.
    /// 
    /// &gt; Removal of the Customer Portal isn't supported through the Stripe SDK. The best practice, which this provider follows,
    /// is to deactivate the Customer Portal by marking it as inactive on destroy, which indicates that resource is no longer
    /// available.
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Stripe = Pulumi.Stripe;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     // A billing portal using all the available options
    ///     var portalConfiguration = new Stripe.PortalConfiguration("portalConfiguration", new()
    ///     {
    ///         BusinessProfile = new Stripe.Inputs.PortalConfigurationBusinessProfileArgs
    ///         {
    ///             Headline = "My special headline",
    ///             PrivacyPolicyUrl = "https://example.com/privacy",
    ///             TermsOfServiceUrl = "https://example.com/terms",
    ///         },
    ///         DefaultReturnUrl = "https://example.com/special_headline",
    ///         Features = new Stripe.Inputs.PortalConfigurationFeaturesArgs
    ///         {
    ///             CustomerUpdate = new Stripe.Inputs.PortalConfigurationFeaturesCustomerUpdateArgs
    ///             {
    ///                 AllowedUpdates = new[]
    ///                 {
    ///                     "email",
    ///                     "address",
    ///                     "shipping",
    ///                     "phone",
    ///                     "tax_id",
    ///                 },
    ///                 Enabled = true,
    ///             },
    ///             InvoiceHistory = new Stripe.Inputs.PortalConfigurationFeaturesInvoiceHistoryArgs
    ///             {
    ///                 Enabled = true,
    ///             },
    ///             PaymentMethodUpdate = new Stripe.Inputs.PortalConfigurationFeaturesPaymentMethodUpdateArgs
    ///             {
    ///                 Enabled = true,
    ///             },
    ///             SubscriptionCancel = new Stripe.Inputs.PortalConfigurationFeaturesSubscriptionCancelArgs
    ///             {
    ///                 CancellationReason = new Stripe.Inputs.PortalConfigurationFeaturesSubscriptionCancelCancellationReasonArgs
    ///                 {
    ///                     Enabled = true,
    ///                     Options = new[]
    ///                     {
    ///                         "too_expensive",
    ///                         "missing_features",
    ///                         "switched_service",
    ///                         "unused",
    ///                         "customer_service",
    ///                         "too_complex",
    ///                         "low_quality",
    ///                         "other",
    ///                     },
    ///                 },
    ///                 Enabled = true,
    ///                 Mode = "at_period_end",
    ///                 ProrationBehavior = "none",
    ///             },
    ///             SubscriptionPauses = new[]
    ///             {
    ///                 new Stripe.Inputs.PortalConfigurationFeaturesSubscriptionPauseArgs
    ///                 {
    ///                     Enabled = true,
    ///                 },
    ///             },
    ///             SubscriptionUpdates = new[]
    ///             {
    ///                 new Stripe.Inputs.PortalConfigurationFeaturesSubscriptionUpdateArgs
    ///                 {
    ///                     DefaultAllowedUpdates = new[]
    ///                     {
    ///                         "price",
    ///                         "quantity",
    ///                         "promotion_code",
    ///                     },
    ///                     Enabled = true,
    ///                     Products = new[]
    ///                     {
    ///                         new Stripe.Inputs.PortalConfigurationFeaturesSubscriptionUpdateProductArgs
    ///                         {
    ///                             Prices = new[]
    ///                             {
    ///                                 "my_price_id1",
    ///                                 "my_price_id2",
    ///                             },
    ///                             Product = "my_product_id",
    ///                         },
    ///                     },
    ///                     ProrationBehavior = "none",
    ///                 },
    ///             },
    ///         },
    ///         Metadata = 
    ///         {
    ///             { "foo", "bar" },
    ///         },
    ///     });
    /// 
    /// });
    /// ```
    /// </summary>
    [StripeResourceType("stripe:index/portalConfiguration:PortalConfiguration")]
    public partial class PortalConfiguration : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Bool. Whether the configuration is active and can be used to create portal sessions. (On create it is always set as `true`)
        /// </summary>
        [Output("active")]
        public Output<bool?> Active { get; private set; } = null!;

        /// <summary>
        /// List(Resource). The business information shown to customers in the portal. More details in Business Profile section
        /// </summary>
        [Output("businessProfile")]
        public Output<Outputs.PortalConfigurationBusinessProfile> BusinessProfile { get; private set; } = null!;

        /// <summary>
        /// String. The default URL to redirect customers to when they click on the portal’s link to return to your website. This can be overriden when creating the session.
        /// </summary>
        [Output("defaultReturnUrl")]
        public Output<string?> DefaultReturnUrl { get; private set; } = null!;

        /// <summary>
        /// List(Resource). Information about the features available in the portal. Feature section described in Feature section
        /// </summary>
        [Output("features")]
        public Output<Outputs.PortalConfigurationFeatures> Features { get; private set; } = null!;

        /// <summary>
        /// List(Resource). The hosted login page for this configuration. See details in Login Page Section.
        /// </summary>
        [Output("loginPage")]
        public Output<Outputs.PortalConfigurationLoginPage> LoginPage { get; private set; } = null!;

        /// <summary>
        /// Map(String). Set of key-value pairs that you can attach to an object. This can be useful for storing additional information about the object in a structured format.
        /// </summary>
        [Output("metadata")]
        public Output<ImmutableDictionary<string, string>?> Metadata { get; private set; } = null!;


        /// <summary>
        /// Create a PortalConfiguration resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public PortalConfiguration(string name, PortalConfigurationArgs args, CustomResourceOptions? options = null)
            : base("stripe:index/portalConfiguration:PortalConfiguration", name, args ?? new PortalConfigurationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private PortalConfiguration(string name, Input<string> id, PortalConfigurationState? state = null, CustomResourceOptions? options = null)
            : base("stripe:index/portalConfiguration:PortalConfiguration", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing PortalConfiguration resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static PortalConfiguration Get(string name, Input<string> id, PortalConfigurationState? state = null, CustomResourceOptions? options = null)
        {
            return new PortalConfiguration(name, id, state, options);
        }
    }

    public sealed class PortalConfigurationArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Bool. Whether the configuration is active and can be used to create portal sessions. (On create it is always set as `true`)
        /// </summary>
        [Input("active")]
        public Input<bool>? Active { get; set; }

        /// <summary>
        /// List(Resource). The business information shown to customers in the portal. More details in Business Profile section
        /// </summary>
        [Input("businessProfile", required: true)]
        public Input<Inputs.PortalConfigurationBusinessProfileArgs> BusinessProfile { get; set; } = null!;

        /// <summary>
        /// String. The default URL to redirect customers to when they click on the portal’s link to return to your website. This can be overriden when creating the session.
        /// </summary>
        [Input("defaultReturnUrl")]
        public Input<string>? DefaultReturnUrl { get; set; }

        /// <summary>
        /// List(Resource). Information about the features available in the portal. Feature section described in Feature section
        /// </summary>
        [Input("features", required: true)]
        public Input<Inputs.PortalConfigurationFeaturesArgs> Features { get; set; } = null!;

        /// <summary>
        /// List(Resource). The hosted login page for this configuration. See details in Login Page Section.
        /// </summary>
        [Input("loginPage")]
        public Input<Inputs.PortalConfigurationLoginPageArgs>? LoginPage { get; set; }

        [Input("metadata")]
        private InputMap<string>? _metadata;

        /// <summary>
        /// Map(String). Set of key-value pairs that you can attach to an object. This can be useful for storing additional information about the object in a structured format.
        /// </summary>
        public InputMap<string> Metadata
        {
            get => _metadata ?? (_metadata = new InputMap<string>());
            set => _metadata = value;
        }

        public PortalConfigurationArgs()
        {
        }
        public static new PortalConfigurationArgs Empty => new PortalConfigurationArgs();
    }

    public sealed class PortalConfigurationState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Bool. Whether the configuration is active and can be used to create portal sessions. (On create it is always set as `true`)
        /// </summary>
        [Input("active")]
        public Input<bool>? Active { get; set; }

        /// <summary>
        /// List(Resource). The business information shown to customers in the portal. More details in Business Profile section
        /// </summary>
        [Input("businessProfile")]
        public Input<Inputs.PortalConfigurationBusinessProfileGetArgs>? BusinessProfile { get; set; }

        /// <summary>
        /// String. The default URL to redirect customers to when they click on the portal’s link to return to your website. This can be overriden when creating the session.
        /// </summary>
        [Input("defaultReturnUrl")]
        public Input<string>? DefaultReturnUrl { get; set; }

        /// <summary>
        /// List(Resource). Information about the features available in the portal. Feature section described in Feature section
        /// </summary>
        [Input("features")]
        public Input<Inputs.PortalConfigurationFeaturesGetArgs>? Features { get; set; }

        /// <summary>
        /// List(Resource). The hosted login page for this configuration. See details in Login Page Section.
        /// </summary>
        [Input("loginPage")]
        public Input<Inputs.PortalConfigurationLoginPageGetArgs>? LoginPage { get; set; }

        [Input("metadata")]
        private InputMap<string>? _metadata;

        /// <summary>
        /// Map(String). Set of key-value pairs that you can attach to an object. This can be useful for storing additional information about the object in a structured format.
        /// </summary>
        public InputMap<string> Metadata
        {
            get => _metadata ?? (_metadata = new InputMap<string>());
            set => _metadata = value;
        }

        public PortalConfigurationState()
        {
        }
        public static new PortalConfigurationState Empty => new PortalConfigurationState();
    }
}
