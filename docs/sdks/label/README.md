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

var res = await sdk.Label.CreateShippingLabelAsync(
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

Remove a label

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