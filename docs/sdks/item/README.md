# Item

## Overview

### Available Operations

* [CreateCommerceItem](#createcommerceitem) - Create an item
* [GetCommerceItem](#getcommerceitem) - Retrieve an item
* [ListCommerceItems](#listcommerceitems) - List all items
* [PatchCommerceItem](#patchcommerceitem) - Update an item
* [RemoveCommerceItem](#removecommerceitem) - Remove an item
* [UpdateCommerceItem](#updatecommerceitem) - Update an item

## CreateCommerceItem

Create an item

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createCommerceItem" method="post" path="/commerce/{connection_id}/item" example="commerce_item" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Item.CreateCommerceItemAsync(
    commerceItem: new CommerceItem() {
        Collections = new List<CommerceReference>() {},
        CreatedAt = System.DateTime.Parse("2019-06-21T20:16:18.628Z").ToUniversalTime(),
        Description = "Vulnero ustulo abeo.",
        Duration = 87D,
        GlobalCode = "calamitas",
        Id = "c4ae4fb0-5939-49de-a784-28f0a2628cf4",
        IsActive = false,
        IsFeatured = true,
        IsTaxable = true,
        IsVisible = true,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Caterva eveniet acies candidus.",
                Height = 663D,
                Id = "2e062d01-1772-444a-a28f-75026cb422d6",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "ea10adde-6a80-4699-a75e-e5b9307ccde6",
                        Slug = "doloremque",
                        Value = CommerceMetadataValue.CreateStr(
                            "allatus"
                        ),
                    },
                },
                Position = 67D,
                Type = CommerceItemMediaType.Video,
                Url = "https://picsum.photos/seed/73y0uzyK/972/3753",
                Width = 88D,
            },
            new CommerceItemMedia() {
                Alt = "Comedo.",
                Height = 189D,
                Id = "3ea8c316-50ef-4fa4-897a-c3258a431b6e",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "1520ca9b-5896-4880-872a-db6a2089a516",
                        Slug = "bis",
                        Value = CommerceMetadataValue.CreateStr(
                            "somniculosus"
                        ),
                    },
                },
                Position = 3D,
                Type = CommerceItemMediaType.Image,
                Url = "https://picsum.photos/seed/Ao4iatfO/771/3906",
                Width = 66D,
            },
        },
        Metadata = new List<CommerceMetadata>() {
            new CommerceMetadata() {
                ExtraData = CommerceMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = CommerceMetadataFormat.Text,
                Id = "9ff77460-2a3b-42dd-9c06-ece8564d1b82",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CommerceMetadataValue.CreateStr(
                    "terebro"
                ),
            },
        },
        Name = "Handcrafted Rubber Tuna",
        Prices = new List<CommerceItemPrice>() {
            new CommerceItemPrice() {
                CompareAtPrice = 474D,
                Currency = "OMR",
                Price = 1438D,
            },
        },
        PublicDescription = "Custodia ventus solio compono.",
        PublicName = "Handcrafted Rubber Tuna",
        RequiresShipping = true,
        Slug = "cohors-turba-optio",
        Tags = new List<string>() {
            "blanditiis",
            "tandem",
        },
        TotalStock = 579D,
        Type = "beatae",
        UpdatedAt = System.DateTime.Parse("2022-04-07T13:13:57.339Z").ToUniversalTime(),
        VendorName = "Mayer - Flatley",
        Weight = 22D,
        WeightUnit = WeightUnit.Kg,
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `CommerceItem`                                                                                                                                   | [CommerceItem](../../Models/Components/CommerceItem.md)                                                                                          | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateCommerceItemQueryParamFields](../../Models/Requests/CreateCommerceItemQueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateCommerceItemResponse](../../Models/Requests/CreateCommerceItemResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetCommerceItem

Retrieve an item

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCommerceItem" method="get" path="/commerce/{connection_id}/item/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Item.GetCommerceItemAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Item                                                                                                                                   |
| `Fields`                                                                                                                                         | List<[GetCommerceItemQueryParamFields](../../Models/Requests/GetCommerceItemQueryParamFields.md)>                                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetCommerceItemResponse](../../Models/Requests/GetCommerceItemResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListCommerceItems

List all items

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listCommerceItems" method="get" path="/commerce/{connection_id}/item" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListCommerceItemsRequest req = new ListCommerceItemsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Item.ListCommerceItemsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListCommerceItemsRequest](../../Models/Requests/ListCommerceItemsRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[ListCommerceItemsResponse](../../Models/Requests/ListCommerceItemsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchCommerceItem

Update an item

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchCommerceItem" method="patch" path="/commerce/{connection_id}/item/{id}" example="commerce_item" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchCommerceItemRequest req = new PatchCommerceItemRequest() {
    CommerceItem = new CommerceItem() {
        Collections = new List<CommerceReference>() {},
        CreatedAt = System.DateTime.Parse("2019-06-21T20:16:18.628Z").ToUniversalTime(),
        Description = "Vulnero ustulo abeo.",
        Duration = 87D,
        GlobalCode = "calamitas",
        Id = "39f0112a-7ef3-42f6-9c7d-db1995c23982",
        IsActive = false,
        IsFeatured = true,
        IsTaxable = true,
        IsVisible = true,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Caterva eveniet acies candidus.",
                Height = 663D,
                Id = "7d0fc7bd-1973-4cb9-aa31-39c8e8b4c7e8",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "cfd67087-d64a-4579-8276-c3f59e321672",
                        Slug = "doloremque",
                        Value = CommerceMetadataValue.CreateStr(
                            "allatus"
                        ),
                    },
                },
                Position = 67D,
                Type = CommerceItemMediaType.Video,
                Url = "https://picsum.photos/seed/73y0uzyK/972/3753",
                Width = 88D,
            },
            new CommerceItemMedia() {
                Alt = "Comedo.",
                Height = 189D,
                Id = "be9da297-83f2-454e-b508-c392c2382653",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "54d64983-78be-4bcb-bf42-e814c9d5154f",
                        Slug = "bis",
                        Value = CommerceMetadataValue.CreateStr(
                            "somniculosus"
                        ),
                    },
                },
                Position = 3D,
                Type = CommerceItemMediaType.Image,
                Url = "https://picsum.photos/seed/Ao4iatfO/771/3906",
                Width = 66D,
            },
        },
        Metadata = new List<CommerceMetadata>() {
            new CommerceMetadata() {
                ExtraData = CommerceMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = CommerceMetadataFormat.Text,
                Id = "f1cc3521-fb88-4deb-b85d-a3d6387a8c25",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CommerceMetadataValue.CreateStr(
                    "terebro"
                ),
            },
        },
        Name = "Handcrafted Rubber Tuna",
        Prices = new List<CommerceItemPrice>() {
            new CommerceItemPrice() {
                CompareAtPrice = 474D,
                Currency = "OMR",
                Price = 1438D,
            },
        },
        PublicDescription = "Custodia ventus solio compono.",
        PublicName = "Handcrafted Rubber Tuna",
        RequiresShipping = true,
        Slug = "cohors-turba-optio",
        Tags = new List<string>() {
            "blanditiis",
            "tandem",
        },
        TotalStock = 579D,
        Type = "beatae",
        UpdatedAt = System.DateTime.Parse("2022-04-07T13:13:57.351Z").ToUniversalTime(),
        VendorName = "Mayer - Flatley",
        Weight = 22D,
        WeightUnit = WeightUnit.Kg,
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Item.PatchCommerceItemAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [PatchCommerceItemRequest](../../Models/Requests/PatchCommerceItemRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[PatchCommerceItemResponse](../../Models/Requests/PatchCommerceItemResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveCommerceItem

Remove an item

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeCommerceItem" method="delete" path="/commerce/{connection_id}/item/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Item.RemoveCommerceItemAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Item       |

### Response

**[RemoveCommerceItemResponse](../../Models/Requests/RemoveCommerceItemResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateCommerceItem

Update an item

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateCommerceItem" method="put" path="/commerce/{connection_id}/item/{id}" example="commerce_item" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateCommerceItemRequest req = new UpdateCommerceItemRequest() {
    CommerceItem = new CommerceItem() {
        Collections = new List<CommerceReference>() {},
        CreatedAt = System.DateTime.Parse("2019-06-21T20:16:18.628Z").ToUniversalTime(),
        Description = "Vulnero ustulo abeo.",
        Duration = 87D,
        GlobalCode = "calamitas",
        Id = "39f0112a-7ef3-42f6-9c7d-db1995c23982",
        IsActive = false,
        IsFeatured = true,
        IsTaxable = true,
        IsVisible = true,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Caterva eveniet acies candidus.",
                Height = 663D,
                Id = "7d0fc7bd-1973-4cb9-aa31-39c8e8b4c7e8",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "cfd67087-d64a-4579-8276-c3f59e321672",
                        Slug = "doloremque",
                        Value = CommerceMetadataValue.CreateStr(
                            "allatus"
                        ),
                    },
                },
                Position = 67D,
                Type = CommerceItemMediaType.Video,
                Url = "https://picsum.photos/seed/73y0uzyK/972/3753",
                Width = 88D,
            },
            new CommerceItemMedia() {
                Alt = "Comedo.",
                Height = 189D,
                Id = "be9da297-83f2-454e-b508-c392c2382653",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "54d64983-78be-4bcb-bf42-e814c9d5154f",
                        Slug = "bis",
                        Value = CommerceMetadataValue.CreateStr(
                            "somniculosus"
                        ),
                    },
                },
                Position = 3D,
                Type = CommerceItemMediaType.Image,
                Url = "https://picsum.photos/seed/Ao4iatfO/771/3906",
                Width = 66D,
            },
        },
        Metadata = new List<CommerceMetadata>() {
            new CommerceMetadata() {
                ExtraData = CommerceMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = CommerceMetadataFormat.Text,
                Id = "f1cc3521-fb88-4deb-b85d-a3d6387a8c25",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CommerceMetadataValue.CreateStr(
                    "terebro"
                ),
            },
        },
        Name = "Handcrafted Rubber Tuna",
        Prices = new List<CommerceItemPrice>() {
            new CommerceItemPrice() {
                CompareAtPrice = 474D,
                Currency = "OMR",
                Price = 1438D,
            },
        },
        PublicDescription = "Custodia ventus solio compono.",
        PublicName = "Handcrafted Rubber Tuna",
        RequiresShipping = true,
        Slug = "cohors-turba-optio",
        Tags = new List<string>() {
            "blanditiis",
            "tandem",
        },
        TotalStock = 579D,
        Type = "beatae",
        UpdatedAt = System.DateTime.Parse("2022-04-07T13:13:57.351Z").ToUniversalTime(),
        VendorName = "Mayer - Flatley",
        Weight = 22D,
        WeightUnit = WeightUnit.Kg,
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Item.UpdateCommerceItemAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [UpdateCommerceItemRequest](../../Models/Requests/UpdateCommerceItemRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[UpdateCommerceItemResponse](../../Models/Requests/UpdateCommerceItemResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |