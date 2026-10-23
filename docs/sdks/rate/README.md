# Rate

## Overview

### Available Operations

* [CreateShippingRate](#createshippingrate) - Create a rate

## CreateShippingRate

Creates a ShippingRate. Provide the unified ShippingRate fields in the request body; they are mapped to the provider's API. Returns the created ShippingRate.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createShippingRate" method="post" path="/shipping/{connection_id}/rate" example="shipping_rate" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Rate.CreateShippingRateAsync(
    shippingRate: new ShippingRate() {
        Currency = "USD",
        Id = "a732d9f3-6e4f-4644-a8b4-de714f61b35c",
        Metadata = new List<ShippingMetadata>() {},
        Rates = new List<ShippingRateRate>() {
            new ShippingRateRate() {
                Amount = 44.72D,
                BaseAmount = 46.01D,
                Currency = "USD",
                DeliveryDays = 2D,
                Description = "Veniam denego vulgo bos turpis pax.",
                DiscountAmount = 4.6D,
                EstimatedDays = 2D,
                EstimatedDeliveryEndAt = System.DateTime.Parse("2021-09-03T01:03:36.021Z").ToUniversalTime(),
                IsNegotiatedRate = true,
                TaxAmount = 3.31D,
                Title = "Express",
            },
        },
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ShippingRate`                                                                                                                                   | [ShippingRate](../../Models/Components/ShippingRate.md)                                                                                          | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateShippingRateQueryParamFields](../../Models/Requests/CreateShippingRateQueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateShippingRateResponse](../../Models/Requests/CreateShippingRateResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |