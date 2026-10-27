# Shipping

## Overview

### Available Operations

* [CreateShippingLabel](#createshippinglabel) - Create a label
* [CreateShippingRate](#createshippingrate) - Create a rate
* [CreateShippingShipment](#createshippingshipment) - Create a shipment
* [GetShippingCarrier](#getshippingcarrier) - Retrieve a carrier
* [GetShippingLabel](#getshippinglabel) - Retrieve a label
* [GetShippingShipment](#getshippingshipment) - Retrieve a shipment
* [GetShippingTracking](#getshippingtracking) - Retrieve a tracking
* [ListShippingCarriers](#listshippingcarriers) - List all carriers
* [ListShippingLabels](#listshippinglabels) - List all labels
* [ListShippingShipments](#listshippingshipments) - List all shipments
* [ListShippingTrackings](#listshippingtrackings) - List all trackings
* [PatchShippingLabel](#patchshippinglabel) - Update a label
* [PatchShippingShipment](#patchshippingshipment) - Update a shipment
* [RemoveShippingLabel](#removeshippinglabel) - Remove a label
* [RemoveShippingShipment](#removeshippingshipment) - Remove a shipment
* [UpdateShippingLabel](#updateshippinglabel) - Update a label
* [UpdateShippingShipment](#updateshippingshipment) - Update a shipment

## CreateShippingLabel

Creates a ShippingLabel. Provide the unified ShippingLabel fields in the request body; they are mapped to the provider's API. Returns the created ShippingLabel.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createShippingLabel" method="post" path="/shipping/{connection_id}/label" example="shipping_label" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Shipping.CreateShippingLabelAsync(
    shippingLabel: new ShippingLabel() {
        CreatedAt = System.DateTime.Parse("2022-11-18T16:45:38.067Z").ToUniversalTime(),
        Id = "7b57b347-54c6-4307-bcfc-7c2600e6d62c",
        IsVoided = false,
        LabelCost = 40.83653403213248D,
        LabelCostCurrency = "USD",
        LabelFormat = LabelFormat.Png,
        LabelUrl = "https://labels.example.com/7b57b347-54c6-4307-bcfc-7c2600e6d62c.pdf",
        Metadata = new List<ShippingMetadata>() {},
        ServiceCode = "Dzy",
        Status = ShippingLabelStatus.Exception,
        TrackingNumber = "ZYV60FOIBUJ6",
        UpdatedAt = System.DateTime.Parse("2024-05-01T03:05:50.998Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ShippingLabel`                                                                                                                                  | [ShippingLabel](../../Models/Components/ShippingLabel.md)                                                                                        | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateShippingLabelQueryParamFields](../../Models/Requests/CreateShippingLabelQueryParamFields.md)>                                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateShippingLabelResponse](../../Models/Requests/CreateShippingLabelResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

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

var res = await sdk.Shipping.CreateShippingRateAsync(
    shippingRate: new ShippingRate() {
        Currency = "USD",
        Id = "885b0e87-5891-4b34-95b3-38a1b4fe2915",
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

## CreateShippingShipment

Creates a ShippingShipment. Provide the unified ShippingShipment fields in the request body; they are mapped to the provider's API. Returns the created ShippingShipment.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createShippingShipment" method="post" path="/shipping/{connection_id}/shipment" example="shipping_shipment" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Shipping.CreateShippingShipmentAsync(
    shippingShipment: new ShippingShipment() {
        CreatedAt = System.DateTime.Parse("2022-09-12T03:11:28.960Z").ToUniversalTime(),
        Id = "7e429166-3838-45df-9ced-49a56fd794bb",
        IsReturn = false,
        Lineitems = new List<ShippingShipmentLineitem>() {},
        Metadata = new List<ShippingMetadata>() {},
        RateCurrency = "USD",
        RateEstimatedDays = 4D,
        RateServiceName = "2nd Day Air",
        ServiceCode = "OVERNIGHT",
        ShippedAt = System.DateTime.Parse("2022-09-12T07:26:48.479Z").ToUniversalTime(),
        Status = ShippingShipmentStatus.Delivered,
        UpdatedAt = System.DateTime.Parse("2022-11-15T12:57:14.485Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ShippingShipment`                                                                                                                               | [ShippingShipment](../../Models/Components/ShippingShipment.md)                                                                                  | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateShippingShipmentQueryParamFields](../../Models/Requests/CreateShippingShipmentQueryParamFields.md)>                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateShippingShipmentResponse](../../Models/Requests/CreateShippingShipmentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetShippingCarrier

Retrieves a single ShippingCarrier by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getShippingCarrier" method="get" path="/shipping/{connection_id}/carrier/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Shipping.GetShippingCarrierAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Carrier                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetShippingCarrierQueryParamFields](../../Models/Requests/GetShippingCarrierQueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetShippingCarrierResponse](../../Models/Requests/GetShippingCarrierResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetShippingLabel

Retrieves a single ShippingLabel by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getShippingLabel" method="get" path="/shipping/{connection_id}/label/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Shipping.GetShippingLabelAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Label                                                                                                                                  |
| `Fields`                                                                                                                                         | List<[GetShippingLabelQueryParamFields](../../Models/Requests/GetShippingLabelQueryParamFields.md)>                                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetShippingLabelResponse](../../Models/Requests/GetShippingLabelResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetShippingShipment

Retrieves a single ShippingShipment by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getShippingShipment" method="get" path="/shipping/{connection_id}/shipment/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Shipping.GetShippingShipmentAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Shipment                                                                                                                               |
| `Fields`                                                                                                                                         | List<[GetShippingShipmentQueryParamFields](../../Models/Requests/GetShippingShipmentQueryParamFields.md)>                                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetShippingShipmentResponse](../../Models/Requests/GetShippingShipmentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetShippingTracking

Retrieves a single ShippingTracking by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getShippingTracking" method="get" path="/shipping/{connection_id}/tracking/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Shipping.GetShippingTrackingAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Tracking                                                                                                                               |
| `Fields`                                                                                                                                         | List<[GetShippingTrackingQueryParamFields](../../Models/Requests/GetShippingTrackingQueryParamFields.md)>                                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetShippingTrackingResponse](../../Models/Requests/GetShippingTrackingResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListShippingCarriers

Returns a list of ShippingCarriers. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listShippingCarriers" method="get" path="/shipping/{connection_id}/carrier" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListShippingCarriersRequest req = new ListShippingCarriersRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Shipping.ListShippingCarriersAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [ListShippingCarriersRequest](../../Models/Requests/ListShippingCarriersRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[ListShippingCarriersResponse](../../Models/Requests/ListShippingCarriersResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListShippingLabels

Returns a list of ShippingLabels. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listShippingLabels" method="get" path="/shipping/{connection_id}/label" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListShippingLabelsRequest req = new ListShippingLabelsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Shipping.ListShippingLabelsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [ListShippingLabelsRequest](../../Models/Requests/ListShippingLabelsRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[ListShippingLabelsResponse](../../Models/Requests/ListShippingLabelsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListShippingShipments

Returns a list of ShippingShipments. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listShippingShipments" method="get" path="/shipping/{connection_id}/shipment" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListShippingShipmentsRequest req = new ListShippingShipmentsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Shipping.ListShippingShipmentsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [ListShippingShipmentsRequest](../../Models/Requests/ListShippingShipmentsRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[ListShippingShipmentsResponse](../../Models/Requests/ListShippingShipmentsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListShippingTrackings

Returns a list of ShippingTrackings. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listShippingTrackings" method="get" path="/shipping/{connection_id}/tracking" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListShippingTrackingsRequest req = new ListShippingTrackingsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Shipping.ListShippingTrackingsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [ListShippingTrackingsRequest](../../Models/Requests/ListShippingTrackingsRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[ListShippingTrackingsResponse](../../Models/Requests/ListShippingTrackingsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchShippingLabel

Updates the ShippingLabel identified by `id`. Provide the unified ShippingLabel fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchShippingLabel" method="patch" path="/shipping/{connection_id}/label/{id}" example="shipping_label" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchShippingLabelRequest req = new PatchShippingLabelRequest() {
    ShippingLabel = new ShippingLabel() {
        CreatedAt = System.DateTime.Parse("2022-11-18T16:45:38.067Z").ToUniversalTime(),
        Id = "05999c16-b397-4307-aa80-eeb9fdac578f",
        IsVoided = false,
        LabelCost = 40.83653403213248D,
        LabelCostCurrency = "USD",
        LabelFormat = LabelFormat.Png,
        LabelUrl = "https://labels.example.com/05999c16-b397-4307-aa80-eeb9fdac578f.pdf",
        Metadata = new List<ShippingMetadata>() {},
        ServiceCode = "Dzy",
        Status = ShippingLabelStatus.Exception,
        TrackingNumber = "ZYV60FOIBUJ6",
        UpdatedAt = System.DateTime.Parse("2024-05-01T03:05:51.009Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Shipping.PatchShippingLabelAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [PatchShippingLabelRequest](../../Models/Requests/PatchShippingLabelRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[PatchShippingLabelResponse](../../Models/Requests/PatchShippingLabelResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchShippingShipment

Updates the ShippingShipment identified by `id`. Provide the unified ShippingShipment fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchShippingShipment" method="patch" path="/shipping/{connection_id}/shipment/{id}" example="shipping_shipment" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchShippingShipmentRequest req = new PatchShippingShipmentRequest() {
    ShippingShipment = new ShippingShipment() {
        CreatedAt = System.DateTime.Parse("2022-09-12T03:11:28.960Z").ToUniversalTime(),
        Id = "92f98454-cbd2-45c5-aca6-ba9e099c0b20",
        IsReturn = false,
        Lineitems = new List<ShippingShipmentLineitem>() {},
        Metadata = new List<ShippingMetadata>() {},
        RateCurrency = "USD",
        RateEstimatedDays = 4D,
        RateServiceName = "2nd Day Air",
        ServiceCode = "OVERNIGHT",
        ShippedAt = System.DateTime.Parse("2022-09-12T07:26:48.479Z").ToUniversalTime(),
        Status = ShippingShipmentStatus.Delivered,
        UpdatedAt = System.DateTime.Parse("2022-11-15T12:57:14.490Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Shipping.PatchShippingShipmentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [PatchShippingShipmentRequest](../../Models/Requests/PatchShippingShipmentRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[PatchShippingShipmentResponse](../../Models/Requests/PatchShippingShipmentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveShippingLabel

Deletes the ShippingLabel identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeShippingLabel" method="delete" path="/shipping/{connection_id}/label/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Shipping.RemoveShippingLabelAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Label      |

### Response

**[RemoveShippingLabelResponse](../../Models/Requests/RemoveShippingLabelResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveShippingShipment

Deletes the ShippingShipment identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeShippingShipment" method="delete" path="/shipping/{connection_id}/shipment/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Shipping.RemoveShippingShipmentAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Shipment   |

### Response

**[RemoveShippingShipmentResponse](../../Models/Requests/RemoveShippingShipmentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateShippingLabel

Updates the ShippingLabel identified by `id`. Provide the unified ShippingLabel fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateShippingLabel" method="put" path="/shipping/{connection_id}/label/{id}" example="shipping_label" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateShippingLabelRequest req = new UpdateShippingLabelRequest() {
    ShippingLabel = new ShippingLabel() {
        CreatedAt = System.DateTime.Parse("2022-11-18T16:45:38.067Z").ToUniversalTime(),
        Id = "05999c16-b397-4307-aa80-eeb9fdac578f",
        IsVoided = false,
        LabelCost = 40.83653403213248D,
        LabelCostCurrency = "USD",
        LabelFormat = LabelFormat.Png,
        LabelUrl = "https://labels.example.com/05999c16-b397-4307-aa80-eeb9fdac578f.pdf",
        Metadata = new List<ShippingMetadata>() {},
        ServiceCode = "Dzy",
        Status = ShippingLabelStatus.Exception,
        TrackingNumber = "ZYV60FOIBUJ6",
        UpdatedAt = System.DateTime.Parse("2024-05-01T03:05:51.009Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Shipping.UpdateShippingLabelAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [UpdateShippingLabelRequest](../../Models/Requests/UpdateShippingLabelRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[UpdateShippingLabelResponse](../../Models/Requests/UpdateShippingLabelResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateShippingShipment

Updates the ShippingShipment identified by `id`. Provide the unified ShippingShipment fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateShippingShipment" method="put" path="/shipping/{connection_id}/shipment/{id}" example="shipping_shipment" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateShippingShipmentRequest req = new UpdateShippingShipmentRequest() {
    ShippingShipment = new ShippingShipment() {
        CreatedAt = System.DateTime.Parse("2022-09-12T03:11:28.960Z").ToUniversalTime(),
        Id = "92f98454-cbd2-45c5-aca6-ba9e099c0b20",
        IsReturn = false,
        Lineitems = new List<ShippingShipmentLineitem>() {},
        Metadata = new List<ShippingMetadata>() {},
        RateCurrency = "USD",
        RateEstimatedDays = 4D,
        RateServiceName = "2nd Day Air",
        ServiceCode = "OVERNIGHT",
        ShippedAt = System.DateTime.Parse("2022-09-12T07:26:48.479Z").ToUniversalTime(),
        Status = ShippingShipmentStatus.Delivered,
        UpdatedAt = System.DateTime.Parse("2022-11-15T12:57:14.490Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Shipping.UpdateShippingShipmentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [UpdateShippingShipmentRequest](../../Models/Requests/UpdateShippingShipmentRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[UpdateShippingShipmentResponse](../../Models/Requests/UpdateShippingShipmentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |