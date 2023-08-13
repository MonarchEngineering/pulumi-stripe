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
    /// With this resource, you can create a webhook endpoint - [Stripe API webhook endpoint documentation](https://stripe.com/docs/api/webhook_endpoints).
    /// 
    /// You can configure webhook endpoints via the API to be notified about events that happen in your Stripe account or connected accounts.
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
    ///     var webhook = new Stripe.WebhookEndpoint("webhook", new()
    ///     {
    ///         Description = "example of webhook",
    ///         EnabledEvents = new[]
    ///         {
    ///             "customer.subscription.created",
    ///             "customer.subscription.updated",
    ///         },
    ///         Url = "https://webhook-url-consumer.com",
    ///     });
    /// 
    /// });
    /// ```
    /// </summary>
    [StripeResourceType("stripe:index/webhookEndpoint:WebhookEndpoint")]
    public partial class WebhookEndpoint : global::Pulumi.CustomResource
    {
        /// <summary>
        /// String. Events sent to this endpoint will be generated with this Stripe Version instead of your account’s default Stripe Version.
        /// </summary>
        [Output("apiVersion")]
        public Output<string?> ApiVersion { get; private set; } = null!;

        /// <summary>
        /// Bool. Whether this endpoint should receive events from connected accounts (`true`), or from your account (`false`). Defaults to `false`.
        /// </summary>
        [Output("connect")]
        public Output<bool?> Connect { get; private set; } = null!;

        /// <summary>
        /// String. Description of what the webhook is used for.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Bool. Disable the webhook endpoint if set to `true`. Can be used only for modification already existing webhook endpoint.
        /// </summary>
        [Output("disabled")]
        public Output<bool?> Disabled { get; private set; } = null!;

        /// <summary>
        /// List(String). The list of events to enable for this endpoint. `[*]` indicates that all events are enabled, except those that require explicit selection. All supported events listed here: [Stripe event types](https://stripe.com/docs/api/events/types).
        /// </summary>
        [Output("enabledEvents")]
        public Output<ImmutableArray<string>> EnabledEvents { get; private set; } = null!;

        /// <summary>
        /// Map(String). Set of key-value pairs that you can attach to an object. This can be useful for storing additional information about the object in a structured format.
        /// </summary>
        [Output("metadata")]
        public Output<ImmutableDictionary<string, string>?> Metadata { get; private set; } = null!;

        /// <summary>
        /// String. The endpoint’s secret, used to generate webhook signatures. This field is marked as `sensitive`.
        /// </summary>
        [Output("secret")]
        public Output<string> Secret { get; private set; } = null!;

        /// <summary>
        /// String. The URL of the webhook endpoint.
        /// </summary>
        [Output("url")]
        public Output<string> Url { get; private set; } = null!;


        /// <summary>
        /// Create a WebhookEndpoint resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public WebhookEndpoint(string name, WebhookEndpointArgs args, CustomResourceOptions? options = null)
            : base("stripe:index/webhookEndpoint:WebhookEndpoint", name, args ?? new WebhookEndpointArgs(), MakeResourceOptions(options, ""))
        {
        }

        private WebhookEndpoint(string name, Input<string> id, WebhookEndpointState? state = null, CustomResourceOptions? options = null)
            : base("stripe:index/webhookEndpoint:WebhookEndpoint", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                AdditionalSecretOutputs =
                {
                    "secret",
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing WebhookEndpoint resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static WebhookEndpoint Get(string name, Input<string> id, WebhookEndpointState? state = null, CustomResourceOptions? options = null)
        {
            return new WebhookEndpoint(name, id, state, options);
        }
    }

    public sealed class WebhookEndpointArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// String. Events sent to this endpoint will be generated with this Stripe Version instead of your account’s default Stripe Version.
        /// </summary>
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        /// <summary>
        /// Bool. Whether this endpoint should receive events from connected accounts (`true`), or from your account (`false`). Defaults to `false`.
        /// </summary>
        [Input("connect")]
        public Input<bool>? Connect { get; set; }

        /// <summary>
        /// String. Description of what the webhook is used for.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Bool. Disable the webhook endpoint if set to `true`. Can be used only for modification already existing webhook endpoint.
        /// </summary>
        [Input("disabled")]
        public Input<bool>? Disabled { get; set; }

        [Input("enabledEvents", required: true)]
        private InputList<string>? _enabledEvents;

        /// <summary>
        /// List(String). The list of events to enable for this endpoint. `[*]` indicates that all events are enabled, except those that require explicit selection. All supported events listed here: [Stripe event types](https://stripe.com/docs/api/events/types).
        /// </summary>
        public InputList<string> EnabledEvents
        {
            get => _enabledEvents ?? (_enabledEvents = new InputList<string>());
            set => _enabledEvents = value;
        }

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

        /// <summary>
        /// String. The URL of the webhook endpoint.
        /// </summary>
        [Input("url", required: true)]
        public Input<string> Url { get; set; } = null!;

        public WebhookEndpointArgs()
        {
        }
        public static new WebhookEndpointArgs Empty => new WebhookEndpointArgs();
    }

    public sealed class WebhookEndpointState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// String. Events sent to this endpoint will be generated with this Stripe Version instead of your account’s default Stripe Version.
        /// </summary>
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        /// <summary>
        /// Bool. Whether this endpoint should receive events from connected accounts (`true`), or from your account (`false`). Defaults to `false`.
        /// </summary>
        [Input("connect")]
        public Input<bool>? Connect { get; set; }

        /// <summary>
        /// String. Description of what the webhook is used for.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Bool. Disable the webhook endpoint if set to `true`. Can be used only for modification already existing webhook endpoint.
        /// </summary>
        [Input("disabled")]
        public Input<bool>? Disabled { get; set; }

        [Input("enabledEvents")]
        private InputList<string>? _enabledEvents;

        /// <summary>
        /// List(String). The list of events to enable for this endpoint. `[*]` indicates that all events are enabled, except those that require explicit selection. All supported events listed here: [Stripe event types](https://stripe.com/docs/api/events/types).
        /// </summary>
        public InputList<string> EnabledEvents
        {
            get => _enabledEvents ?? (_enabledEvents = new InputList<string>());
            set => _enabledEvents = value;
        }

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

        [Input("secret")]
        private Input<string>? _secret;

        /// <summary>
        /// String. The endpoint’s secret, used to generate webhook signatures. This field is marked as `sensitive`.
        /// </summary>
        public Input<string>? Secret
        {
            get => _secret;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _secret = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// String. The URL of the webhook endpoint.
        /// </summary>
        [Input("url")]
        public Input<string>? Url { get; set; }

        public WebhookEndpointState()
        {
        }
        public static new WebhookEndpointState Empty => new WebhookEndpointState();
    }
}
