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
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Shipping.CreateShippingLabelAsync(
    shippingLabel: new ShippingLabel() {
        CreatedAt = System.DateTime.Parse("2022-11-18T16:45:38.067Z").ToUniversalTime(),
        Id = "d6458695-9de6-4cec-b0d5-4f76286ed88f",
        IsVoided = false,
        LabelCost = 40.83653403213248D,
        LabelCostCurrency = "USD",
        LabelFormat = LabelFormat.Png,
        LabelUrl = "https://optimal-meadow.net",
        ServiceCode = "GIz",
        Status = ShippingLabelStatus.Exception,
        TrackingNumber = "zYv60FOIBUJ6",
        UpdatedAt = System.DateTime.Parse("2024-04-17T03:05:58.324Z").ToUniversalTime(),
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

## CreateShippingShipment

Create a shipment

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createShippingShipment" method="post" path="/shipping/{connection_id}/shipment" example="shipping_shipment" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Shipping.CreateShippingShipmentAsync(
    shippingShipment: new ShippingShipment() {
        CarrierName = "Bogisich, Franey and Koelpin",
        CreatedAt = System.DateTime.Parse("2022-09-12T03:11:28.960Z").ToUniversalTime(),
        Id = "f68467ce-9d8c-4d4e-b5df-6e5d979f62db",
        RateAmount = 8.86546263936907D,
        RateCurrency = "USD",
        RateEstimatedDays = 8D,
        RateServiceName = "Fisher - Kilback",
        ServiceCode = "F7U",
        ShippedAt = System.DateTime.Parse("2025-08-25T11:48:45.393Z").ToUniversalTime(),
        Status = ShippingShipmentStatus.Pending,
        TrackingUrl = "https://shallow-secrecy.info/",
        UpdatedAt = System.DateTime.Parse("2025-07-03T18:44:34.139Z").ToUniversalTime(),
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
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchShippingLabelRequest req = new PatchShippingLabelRequest() {
    ShippingLabel = new ShippingLabel() {
        CreatedAt = System.DateTime.Parse("2022-11-18T16:45:38.067Z").ToUniversalTime(),
        Id = "13715a3a-14c6-45ef-84ab-31a750d763d9",
        IsVoided = false,
        LabelCost = 40.83653403213248D,
        LabelCostCurrency = "USD",
        LabelFormat = LabelFormat.Png,
        LabelUrl = "https://optimal-meadow.net",
        ServiceCode = "GIz",
        Status = ShippingLabelStatus.Exception,
        TrackingNumber = "zYv60FOIBUJ6",
        UpdatedAt = System.DateTime.Parse("2024-04-17T03:05:58.329Z").ToUniversalTime(),
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
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchShippingShipmentRequest req = new PatchShippingShipmentRequest() {
    ShippingShipment = new ShippingShipment() {
        CarrierName = "Bogisich, Franey and Koelpin",
        CreatedAt = System.DateTime.Parse("2022-09-12T03:11:28.960Z").ToUniversalTime(),
        Id = "0caee800-9099-4cbb-8e1c-4f229d2b98f2",
        RateAmount = 8.86546263936907D,
        RateCurrency = "USD",
        RateEstimatedDays = 8D,
        RateServiceName = "Fisher - Kilback",
        ServiceCode = "F7U",
        ShippedAt = System.DateTime.Parse("2025-08-25T11:48:45.466Z").ToUniversalTime(),
        Status = ShippingShipmentStatus.Pending,
        TrackingUrl = "https://shallow-secrecy.info/",
        UpdatedAt = System.DateTime.Parse("2025-07-03T18:44:34.209Z").ToUniversalTime(),
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
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateShippingLabelRequest req = new UpdateShippingLabelRequest() {
    ShippingLabel = new ShippingLabel() {
        CreatedAt = System.DateTime.Parse("2022-11-18T16:45:38.067Z").ToUniversalTime(),
        Id = "13715a3a-14c6-45ef-84ab-31a750d763d9",
        IsVoided = false,
        LabelCost = 40.83653403213248D,
        LabelCostCurrency = "USD",
        LabelFormat = LabelFormat.Png,
        LabelUrl = "https://optimal-meadow.net",
        ServiceCode = "GIz",
        Status = ShippingLabelStatus.Exception,
        TrackingNumber = "zYv60FOIBUJ6",
        UpdatedAt = System.DateTime.Parse("2024-04-17T03:05:58.329Z").ToUniversalTime(),
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
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateShippingShipmentRequest req = new UpdateShippingShipmentRequest() {
    ShippingShipment = new ShippingShipment() {
        CarrierName = "Bogisich, Franey and Koelpin",
        CreatedAt = System.DateTime.Parse("2022-09-12T03:11:28.960Z").ToUniversalTime(),
        Id = "0caee800-9099-4cbb-8e1c-4f229d2b98f2",
        RateAmount = 8.86546263936907D,
        RateCurrency = "USD",
        RateEstimatedDays = 8D,
        RateServiceName = "Fisher - Kilback",
        ServiceCode = "F7U",
        ShippedAt = System.DateTime.Parse("2025-08-25T11:48:45.466Z").ToUniversalTime(),
        Status = ShippingShipmentStatus.Pending,
        TrackingUrl = "https://shallow-secrecy.info/",
        UpdatedAt = System.DateTime.Parse("2025-07-03T18:44:34.209Z").ToUniversalTime(),
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