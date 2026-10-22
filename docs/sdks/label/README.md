# Label

## Overview

### Available Operations

* [CreateShippingLabel](#createshippinglabel) - Create a label
* [GetShippingLabel](#getshippinglabel) - Retrieve a label
* [ListShippingLabels](#listshippinglabels) - List all labels
* [PatchShippingLabel](#patchshippinglabel) - Update a label
* [RemoveShippingLabel](#removeshippinglabel) - Remove a label
* [UpdateShippingLabel](#updateshippinglabel) - Update a label

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

var res = await sdk.Label.CreateShippingLabelAsync(
    shippingLabel: new ShippingLabel() {
        CreatedAt = System.DateTime.Parse("2022-11-18T16:45:38.067Z").ToUniversalTime(),
        Id = "497fd9a7-bb5b-4f69-9a27-d165b32df801",
        IsVoided = false,
        LabelCost = 40.83653403213248D,
        LabelCostCurrency = "USD",
        LabelFormat = LabelFormat.Png,
        LabelUrl = "https://labels.example.com/497fd9a7-bb5b-4f69-9a27-d165b32df801.pdf",
        Metadata = new List<ShippingMetadata>() {},
        ServiceCode = "Dzy",
        Status = ShippingLabelStatus.Exception,
        TrackingNumber = "ZYV60FOIBUJ6",
        UpdatedAt = System.DateTime.Parse("2024-04-29T05:57:22.025Z").ToUniversalTime(),
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

var res = await sdk.Label.GetShippingLabelAsync(
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

var res = await sdk.Label.ListShippingLabelsAsync(req);

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
        Id = "30ef2873-699c-4444-b333-6081f7a58553",
        IsVoided = false,
        LabelCost = 40.83653403213248D,
        LabelCostCurrency = "USD",
        LabelFormat = LabelFormat.Png,
        LabelUrl = "https://labels.example.com/30ef2873-699c-4444-b333-6081f7a58553.pdf",
        Metadata = new List<ShippingMetadata>() {},
        ServiceCode = "Dzy",
        Status = ShippingLabelStatus.Exception,
        TrackingNumber = "ZYV60FOIBUJ6",
        UpdatedAt = System.DateTime.Parse("2024-04-29T05:57:22.033Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Label.PatchShippingLabelAsync(req);

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

var res = await sdk.Label.RemoveShippingLabelAsync(
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
        Id = "30ef2873-699c-4444-b333-6081f7a58553",
        IsVoided = false,
        LabelCost = 40.83653403213248D,
        LabelCostCurrency = "USD",
        LabelFormat = LabelFormat.Png,
        LabelUrl = "https://labels.example.com/30ef2873-699c-4444-b333-6081f7a58553.pdf",
        Metadata = new List<ShippingMetadata>() {},
        ServiceCode = "Dzy",
        Status = ShippingLabelStatus.Exception,
        TrackingNumber = "ZYV60FOIBUJ6",
        UpdatedAt = System.DateTime.Parse("2024-04-29T05:57:22.033Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Label.UpdateShippingLabelAsync(req);

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