# Shipment

## Overview

### Available Operations

* [CreateShippingShipment](#createshippingshipment) - Create a shipment
* [GetShippingShipment](#getshippingshipment) - Retrieve a shipment
* [ListShippingShipments](#listshippingshipments) - List all shipments
* [PatchShippingShipment](#patchshippingshipment) - Update a shipment
* [RemoveShippingShipment](#removeshippingshipment) - Remove a shipment
* [UpdateShippingShipment](#updateshippingshipment) - Update a shipment

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

var res = await sdk.Shipment.CreateShippingShipmentAsync(
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

var res = await sdk.Shipment.GetShippingShipmentAsync(
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

var res = await sdk.Shipment.ListShippingShipmentsAsync(req);

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

var res = await sdk.Shipment.PatchShippingShipmentAsync(req);

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

var res = await sdk.Shipment.RemoveShippingShipmentAsync(
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

var res = await sdk.Shipment.UpdateShippingShipmentAsync(req);

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