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

<!-- UsageSnippet language="csharp" operationID="createShippingShipment" method="post" path="/shipping/{connection_id}/shipment" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Shipment.CreateShippingShipmentAsync(
    shippingShipment: new ShippingShipment() {},
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

<!-- UsageSnippet language="csharp" operationID="patchShippingShipment" method="patch" path="/shipping/{connection_id}/shipment/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchShippingShipmentRequest req = new PatchShippingShipmentRequest() {
    ShippingShipment = new ShippingShipment() {},
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

<!-- UsageSnippet language="csharp" operationID="updateShippingShipment" method="put" path="/shipping/{connection_id}/shipment/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateShippingShipmentRequest req = new UpdateShippingShipmentRequest() {
    ShippingShipment = new ShippingShipment() {},
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