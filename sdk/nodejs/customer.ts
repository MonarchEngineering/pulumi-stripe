// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * With this resource, you can create a customer - [Stripe API customer documentation](https://stripe.com/docs/api/customers).
 *
 * Customer objects allow you to perform recurring charges, and to track multiple charges,
 * that are associated with the same customer.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as stripe from "@pulumi/stripe";
 *
 * // A customer with other details
 * const customer = new stripe.Customer("customer", {
 *     balance: 10000,
 *     invoicePrefix: "LA000",
 *     invoiceSettings: {
 *         customFieldName: "customFieldValue",
 *         footer: "--- Lukas Aron ---",
 *     },
 *     nextInvoiceSequence: 1001,
 *     preferredLocales: [
 *         "eng",
 *         "esp",
 *     ],
 *     shipping: {
 *         city: "Sydney",
 *         country: "AU",
 *         line1: "1 The Best Street",
 *         line2: "Apartment 401",
 *         name: "Lukas Aron",
 *         phone: "+610123456789",
 *         postal_code: "2000",
 *         state: "New South Wales",
 *     },
 * });
 * ```
 */
export class Customer extends pulumi.CustomResource {
    /**
     * Get an existing Customer resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: CustomerState, opts?: pulumi.CustomResourceOptions): Customer {
        return new Customer(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'stripe:index/customer:Customer';

    /**
     * Returns true if the given object is an instance of Customer.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Customer {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Customer.__pulumiType;
    }

    /**
     * Map(String). The customer’s address, for all individual fields see: Address Fields.
     */
    public readonly address!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Int. Current balance, if any, being stored on the customer. If negative, the customer has credit to apply to their next invoice. If positive, the customer has an amount owed that will be added to their next invoice. The balance does not refer to any unpaid invoices; it solely takes into account amounts that have yet to be successfully applied to any invoice. This balance is only taken into account as invoices are finalized.
     */
    public readonly balance!: pulumi.Output<number | undefined>;
    /**
     * String. The default invoice prefix generated by Stripe when not individual invoice prefix provided.
     */
    public /*out*/ readonly defaultInvoicePrefix!: pulumi.Output<string>;
    /**
     * String. An arbitrary string that you can attach to a customer object. It is displayed alongside the customer in the dashboard.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * String. Customer’s email address. It’s displayed alongside the customer in your dashboard and can be useful for searching and tracking. This may be up to 512 characters.
     */
    public readonly email!: pulumi.Output<string | undefined>;
    /**
     * String. The prefix for the customer used to generate unique invoice numbers. Must be `3–12 uppercase letters or numbers`.
     */
    public readonly invoicePrefix!: pulumi.Output<string | undefined>;
    /**
     * Map(String). Default invoice settings for this customer. For supported fields see: Invoice Settings Fields.
     */
    public readonly invoiceSettings!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Map(String). Set of key-value pairs that you can attach to an object. This can be useful for storing additional information about the object in a structured format.
     */
    public readonly metadata!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * String. The customer’s full name or business name.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Int. The sequence to be used on the customer’s next invoice. Defaults to 1.
     */
    public readonly nextInvoiceSequence!: pulumi.Output<number | undefined>;
    /**
     * String. The customer’s phone number.
     */
    public readonly phone!: pulumi.Output<string | undefined>;
    /**
     * List(String). Customer’s preferred languages, ordered by preference.
     */
    public readonly preferredLocales!: pulumi.Output<string[] | undefined>;
    /**
     * Map(String). Mailing and shipping address for the customer. Appears on invoices emailed to this customer. For all individual fields see: Shipping Fields.
     */
    public readonly shipping!: pulumi.Output<{[key: string]: string} | undefined>;

    /**
     * Create a Customer resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: CustomerArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: CustomerArgs | CustomerState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as CustomerState | undefined;
            resourceInputs["address"] = state ? state.address : undefined;
            resourceInputs["balance"] = state ? state.balance : undefined;
            resourceInputs["defaultInvoicePrefix"] = state ? state.defaultInvoicePrefix : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["email"] = state ? state.email : undefined;
            resourceInputs["invoicePrefix"] = state ? state.invoicePrefix : undefined;
            resourceInputs["invoiceSettings"] = state ? state.invoiceSettings : undefined;
            resourceInputs["metadata"] = state ? state.metadata : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["nextInvoiceSequence"] = state ? state.nextInvoiceSequence : undefined;
            resourceInputs["phone"] = state ? state.phone : undefined;
            resourceInputs["preferredLocales"] = state ? state.preferredLocales : undefined;
            resourceInputs["shipping"] = state ? state.shipping : undefined;
        } else {
            const args = argsOrState as CustomerArgs | undefined;
            resourceInputs["address"] = args ? args.address : undefined;
            resourceInputs["balance"] = args ? args.balance : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["email"] = args ? args.email : undefined;
            resourceInputs["invoicePrefix"] = args ? args.invoicePrefix : undefined;
            resourceInputs["invoiceSettings"] = args ? args.invoiceSettings : undefined;
            resourceInputs["metadata"] = args ? args.metadata : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["nextInvoiceSequence"] = args ? args.nextInvoiceSequence : undefined;
            resourceInputs["phone"] = args ? args.phone : undefined;
            resourceInputs["preferredLocales"] = args ? args.preferredLocales : undefined;
            resourceInputs["shipping"] = args ? args.shipping : undefined;
            resourceInputs["defaultInvoicePrefix"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Customer.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Customer resources.
 */
export interface CustomerState {
    /**
     * Map(String). The customer’s address, for all individual fields see: Address Fields.
     */
    address?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Int. Current balance, if any, being stored on the customer. If negative, the customer has credit to apply to their next invoice. If positive, the customer has an amount owed that will be added to their next invoice. The balance does not refer to any unpaid invoices; it solely takes into account amounts that have yet to be successfully applied to any invoice. This balance is only taken into account as invoices are finalized.
     */
    balance?: pulumi.Input<number>;
    /**
     * String. The default invoice prefix generated by Stripe when not individual invoice prefix provided.
     */
    defaultInvoicePrefix?: pulumi.Input<string>;
    /**
     * String. An arbitrary string that you can attach to a customer object. It is displayed alongside the customer in the dashboard.
     */
    description?: pulumi.Input<string>;
    /**
     * String. Customer’s email address. It’s displayed alongside the customer in your dashboard and can be useful for searching and tracking. This may be up to 512 characters.
     */
    email?: pulumi.Input<string>;
    /**
     * String. The prefix for the customer used to generate unique invoice numbers. Must be `3–12 uppercase letters or numbers`.
     */
    invoicePrefix?: pulumi.Input<string>;
    /**
     * Map(String). Default invoice settings for this customer. For supported fields see: Invoice Settings Fields.
     */
    invoiceSettings?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Map(String). Set of key-value pairs that you can attach to an object. This can be useful for storing additional information about the object in a structured format.
     */
    metadata?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * String. The customer’s full name or business name.
     */
    name?: pulumi.Input<string>;
    /**
     * Int. The sequence to be used on the customer’s next invoice. Defaults to 1.
     */
    nextInvoiceSequence?: pulumi.Input<number>;
    /**
     * String. The customer’s phone number.
     */
    phone?: pulumi.Input<string>;
    /**
     * List(String). Customer’s preferred languages, ordered by preference.
     */
    preferredLocales?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Map(String). Mailing and shipping address for the customer. Appears on invoices emailed to this customer. For all individual fields see: Shipping Fields.
     */
    shipping?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}

/**
 * The set of arguments for constructing a Customer resource.
 */
export interface CustomerArgs {
    /**
     * Map(String). The customer’s address, for all individual fields see: Address Fields.
     */
    address?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Int. Current balance, if any, being stored on the customer. If negative, the customer has credit to apply to their next invoice. If positive, the customer has an amount owed that will be added to their next invoice. The balance does not refer to any unpaid invoices; it solely takes into account amounts that have yet to be successfully applied to any invoice. This balance is only taken into account as invoices are finalized.
     */
    balance?: pulumi.Input<number>;
    /**
     * String. An arbitrary string that you can attach to a customer object. It is displayed alongside the customer in the dashboard.
     */
    description?: pulumi.Input<string>;
    /**
     * String. Customer’s email address. It’s displayed alongside the customer in your dashboard and can be useful for searching and tracking. This may be up to 512 characters.
     */
    email?: pulumi.Input<string>;
    /**
     * String. The prefix for the customer used to generate unique invoice numbers. Must be `3–12 uppercase letters or numbers`.
     */
    invoicePrefix?: pulumi.Input<string>;
    /**
     * Map(String). Default invoice settings for this customer. For supported fields see: Invoice Settings Fields.
     */
    invoiceSettings?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Map(String). Set of key-value pairs that you can attach to an object. This can be useful for storing additional information about the object in a structured format.
     */
    metadata?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * String. The customer’s full name or business name.
     */
    name?: pulumi.Input<string>;
    /**
     * Int. The sequence to be used on the customer’s next invoice. Defaults to 1.
     */
    nextInvoiceSequence?: pulumi.Input<number>;
    /**
     * String. The customer’s phone number.
     */
    phone?: pulumi.Input<string>;
    /**
     * List(String). Customer’s preferred languages, ordered by preference.
     */
    preferredLocales?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Map(String). Mailing and shipping address for the customer. Appears on invoices emailed to this customer. For all individual fields see: Shipping Fields.
     */
    shipping?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
