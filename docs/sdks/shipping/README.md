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

Create a label

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
        Id = "48383374-4753-4aee-9411-320f7b6bf89d",
        IsVoided = false,
        LabelCost = 40.83653403213248D,
        LabelCostCurrency = "USD",
        LabelFormat = LabelFormat.Png,
        LabelUrl = "https://labels.example.com/48383374-4753-4aee-9411-320f7b6bf89d.pdf",
        Metadata = new List<ShippingMetadata>() {},
        ServiceCode = "Dzy",
        Status = ShippingLabelStatus.Exception,
        TrackingNumber = "ZYV60FOIBUJ6",
        UpdatedAt = System.DateTime.Parse("2024-04-28T11:12:55.432Z").ToUniversalTime(),
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

var res = await sdk.Shipping.CreateShippingRateAsync(
    shippingRate: new ShippingRate() {
        Currency = "USD",
        Id = "8229f47d-c3ae-421e-8ccb-f8dd38631ae1",
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

Create a shipment

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
        Id = "2bd43d13-f0c6-4b60-814b-afb18e364ff6",
        IsReturn = false,
        Lineitems = new List<ShippingShipmentLineitem>() {},
        Metadata = new List<ShippingMetadata>() {},
        RateCurrency = "USD",
        RateEstimatedDays = 4D,
        RateServiceName = "2nd Day Air",
        ServiceCode = "OVERNIGHT",
        ShippedAt = System.DateTime.Parse("2022-09-12T07:26:48.479Z").ToUniversalTime(),
        Status = ShippingShipmentStatus.Delivered,
        UpdatedAt = System.DateTime.Parse("2022-11-15T05:31:52.568Z").ToUniversalTime(),
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

Retrieve a carrier

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

Retrieve a label

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

Retrieve a shipment

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

Retrieve a tracking

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

List all carriers

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

List all labels

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

List all shipments

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

List all trackings

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

Update a label

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
        Id = "bb30434d-bf4a-4b92-81c0-11e1fc3851de",
        IsVoided = false,
        LabelCost = 40.83653403213248D,
        LabelCostCurrency = "USD",
        LabelFormat = LabelFormat.Png,
        LabelUrl = "https://labels.example.com/bb30434d-bf4a-4b92-81c0-11e1fc3851de.pdf",
        Metadata = new List<ShippingMetadata>() {},
        ServiceCode = "Dzy",
        Status = ShippingLabelStatus.Exception,
        TrackingNumber = "ZYV60FOIBUJ6",
        UpdatedAt = System.DateTime.Parse("2024-04-28T11:12:55.440Z").ToUniversalTime(),
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

Update a shipment

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
        Id = "25d6e632-f8ea-4cb8-9dfb-be46020986cd",
        IsReturn = false,
        Lineitems = new List<ShippingShipmentLineitem>() {},
        Metadata = new List<ShippingMetadata>() {},
        RateCurrency = "USD",
        RateEstimatedDays = 4D,
        RateServiceName = "2nd Day Air",
        ServiceCode = "OVERNIGHT",
        ShippedAt = System.DateTime.Parse("2022-09-12T07:26:48.479Z").ToUniversalTime(),
        Status = ShippingShipmentStatus.Delivered,
        UpdatedAt = System.DateTime.Parse("2022-11-15T05:31:52.574Z").ToUniversalTime(),
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

Remove a label

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

Remove a shipment

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

Update a label

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
        Id = "bb30434d-bf4a-4b92-81c0-11e1fc3851de",
        IsVoided = false,
        LabelCost = 40.83653403213248D,
        LabelCostCurrency = "USD",
        LabelFormat = LabelFormat.Png,
        LabelUrl = "https://labels.example.com/bb30434d-bf4a-4b92-81c0-11e1fc3851de.pdf",
        Metadata = new List<ShippingMetadata>() {},
        ServiceCode = "Dzy",
        Status = ShippingLabelStatus.Exception,
        TrackingNumber = "ZYV60FOIBUJ6",
        UpdatedAt = System.DateTime.Parse("2024-04-28T11:12:55.440Z").ToUniversalTime(),
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

Update a shipment

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
        Id = "25d6e632-f8ea-4cb8-9dfb-be46020986cd",
        IsReturn = false,
        Lineitems = new List<ShippingShipmentLineitem>() {},
        Metadata = new List<ShippingMetadata>() {},
        RateCurrency = "USD",
        RateEstimatedDays = 4D,
        RateServiceName = "2nd Day Air",
        ServiceCode = "OVERNIGHT",
        ShippedAt = System.DateTime.Parse("2022-09-12T07:26:48.479Z").ToUniversalTime(),
        Status = ShippingShipmentStatus.Delivered,
        UpdatedAt = System.DateTime.Parse("2022-11-15T05:31:52.574Z").ToUniversalTime(),
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