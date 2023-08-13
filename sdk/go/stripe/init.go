// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package stripe

import (
	"fmt"

	"github.com/blang/semver"
	"github.com/georgegebbett/pulumi-stripe/sdk/go/stripe/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type module struct {
	version semver.Version
}

func (m *module) Version() semver.Version {
	return m.version
}

func (m *module) Construct(ctx *pulumi.Context, name, typ, urn string) (r pulumi.Resource, err error) {
	switch typ {
	case "stripe:index/card:Card":
		r = &Card{}
	case "stripe:index/coupon:Coupon":
		r = &Coupon{}
	case "stripe:index/customer:Customer":
		r = &Customer{}
	case "stripe:index/portalConfiguration:PortalConfiguration":
		r = &PortalConfiguration{}
	case "stripe:index/price:Price":
		r = &Price{}
	case "stripe:index/product:Product":
		r = &Product{}
	case "stripe:index/promotionCode:PromotionCode":
		r = &PromotionCode{}
	case "stripe:index/taxRate:TaxRate":
		r = &TaxRate{}
	case "stripe:index/webhookEndpoint:WebhookEndpoint":
		r = &WebhookEndpoint{}
	default:
		return nil, fmt.Errorf("unknown resource type: %s", typ)
	}

	err = ctx.RegisterResource(typ, name, nil, r, pulumi.URN_(urn))
	return
}

type pkg struct {
	version semver.Version
}

func (p *pkg) Version() semver.Version {
	return p.version
}

func (p *pkg) ConstructProvider(ctx *pulumi.Context, name, typ, urn string) (pulumi.ProviderResource, error) {
	if typ != "pulumi:providers:stripe" {
		return nil, fmt.Errorf("unknown provider type: %s", typ)
	}

	r := &Provider{}
	err := ctx.RegisterResource(typ, name, nil, r, pulumi.URN_(urn))
	return r, err
}

func init() {
	version, err := internal.PkgVersion()
	if err != nil {
		version = semver.Version{Major: 1}
	}
	pulumi.RegisterResourceModule(
		"stripe",
		"index/card",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"stripe",
		"index/coupon",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"stripe",
		"index/customer",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"stripe",
		"index/portalConfiguration",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"stripe",
		"index/price",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"stripe",
		"index/product",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"stripe",
		"index/promotionCode",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"stripe",
		"index/taxRate",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"stripe",
		"index/webhookEndpoint",
		&module{version},
	)
	pulumi.RegisterResourcePackage(
		"stripe",
		&pkg{version},
	)
}
