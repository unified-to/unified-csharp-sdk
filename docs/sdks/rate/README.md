# Rate

## Overview

### Available Operations

* [CreateShippingRate](#createshippingrate) - Create a rate

## CreateShippingRate

Create a rate

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
        Id = "1b533f30-3a5a-4969-8111-e6b7627a54ee",
        Rates = new List<ShippingRateRate>() {
            new ShippingRateRate() {
                Amount = 54.679719475097954D,
                BaseAmount = 76.45537888631225D,
                Currency = "USD",
                DeliveryDays = 8D,
                Description = "Bos turpis pax amet dolorem sufficio demonstro complectus benevolentia rerum.",
                EstimatedDays = 10D,
                EstimatedDeliveryEndAt = System.DateTime.Parse("2024-02-01T10:35:07.872Z").ToUniversalTime(),
                IsGuaranteed = true,
                IsNegotiatedRate = true,
                TaxAmount = 2.2701712837442756D,
                Title = "Turcotte Inc",
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