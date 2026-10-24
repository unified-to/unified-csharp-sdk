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

Creates a CommerceItem. Provide the unified CommerceItem fields in the request body; they are mapped to the provider's API. Returns the created CommerceItem.

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
        Description = "Decretum vulnero ustulo abeo.",
        Duration = 104D,
        GlobalCode = "978-0-85270-680-0",
        Id = "9cd7b1f6-640e-4066-aed5-bf503eac4778",
        IsActive = false,
        IsFeatured = false,
        IsTaxable = true,
        IsVisible = true,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Caterva eveniet acies candidus.",
                Height = 876D,
                Id = "36b70497-1b81-427b-8ac4-ff16f791be01",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "676cda5e-f328-444d-9367-1f990a1c97b7",
                        Slug = "doloremque",
                        Value = CommerceMetadataValue.CreateStr(
                            "allatus"
                        ),
                    },
                },
                Position = 21D,
                Type = CommerceItemMediaType.Video,
                Url = "https://picsum.photos/seed/v73y0uzyK/3001/972",
                Width = 67D,
            },
            new CommerceItemMedia() {
                Alt = "Comedo.",
                Height = 651D,
                Id = "08bbe206-b5d3-411a-9cc5-1f42c2c550ee",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "c89888b9-b723-4819-a554-24d8d1511ea1",
                        Slug = "bis",
                        Value = CommerceMetadataValue.CreateStr(
                            "somniculosus"
                        ),
                    },
                },
                Position = 51D,
                Type = CommerceItemMediaType.Image,
                Url = "https://picsum.photos/seed/Ao4iatfO/771/3906",
                Width = 3D,
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
                Id = "f21d0053-fa47-4a3f-b83d-9090d51bd07b",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CommerceMetadataValue.CreateStr(
                    "abstergo"
                ),
            },
        },
        Name = "Handcrafted Rubber Tuna",
        Prices = new List<CommerceItemPrice>() {
            new CommerceItemPrice() {
                Currency = "USD",
                Price = 78.11D,
            },
        },
        PublicDescription = "Custodia ventus solio compono.",
        PublicName = "Handcrafted Rubber Tuna",
        RequiresShipping = true,
        Slug = "handcrafted-rubber-tuna",
        Tags = new List<string>() {
            "beatae",
            "blanditiis",
        },
        TotalStock = 682D,
        Type = "SERVICE",
        UpdatedAt = System.DateTime.Parse("2022-04-20T14:24:18.321Z").ToUniversalTime(),
        VendorName = "Mayer - Flatley",
        Weight = 37D,
        WeightUnit = WeightUnit.Oz,
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

Retrieves a single CommerceItem by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Returns a list of CommerceItems. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Updates the CommerceItem identified by `id`. Provide the unified CommerceItem fields to change in the request body.

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
        Description = "Decretum vulnero ustulo abeo.",
        Duration = 104D,
        GlobalCode = "978-0-85270-680-0",
        Id = "4e90d428-afb8-4214-bb07-d525b68c6117",
        IsActive = false,
        IsFeatured = false,
        IsTaxable = true,
        IsVisible = true,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Caterva eveniet acies candidus.",
                Height = 876D,
                Id = "4710531f-607c-431c-b4c9-352c64fc51d6",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "959c10eb-8b29-4c0d-8332-9ae213880645",
                        Slug = "doloremque",
                        Value = CommerceMetadataValue.CreateStr(
                            "allatus"
                        ),
                    },
                },
                Position = 21D,
                Type = CommerceItemMediaType.Video,
                Url = "https://picsum.photos/seed/v73y0uzyK/3001/972",
                Width = 67D,
            },
            new CommerceItemMedia() {
                Alt = "Comedo.",
                Height = 651D,
                Id = "4760c377-99bc-4cd8-bcf7-c2dfda207bb7",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "72cfc1a4-88e1-49d0-8ada-89c07db382d2",
                        Slug = "bis",
                        Value = CommerceMetadataValue.CreateStr(
                            "somniculosus"
                        ),
                    },
                },
                Position = 51D,
                Type = CommerceItemMediaType.Image,
                Url = "https://picsum.photos/seed/Ao4iatfO/771/3906",
                Width = 3D,
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
                Id = "59a81611-a3a0-44c4-a650-a5e7f0d834e9",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CommerceMetadataValue.CreateStr(
                    "abstergo"
                ),
            },
        },
        Name = "Handcrafted Rubber Tuna",
        Prices = new List<CommerceItemPrice>() {
            new CommerceItemPrice() {
                Currency = "USD",
                Price = 78.11D,
            },
        },
        PublicDescription = "Custodia ventus solio compono.",
        PublicName = "Handcrafted Rubber Tuna",
        RequiresShipping = true,
        Slug = "handcrafted-rubber-tuna",
        Tags = new List<string>() {
            "beatae",
            "blanditiis",
        },
        TotalStock = 682D,
        Type = "SERVICE",
        UpdatedAt = System.DateTime.Parse("2022-04-20T14:24:18.337Z").ToUniversalTime(),
        VendorName = "Mayer - Flatley",
        Weight = 37D,
        WeightUnit = WeightUnit.Oz,
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

Deletes the CommerceItem identified by `id`.

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

Updates the CommerceItem identified by `id`. Provide the unified CommerceItem fields to change in the request body.

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
        Description = "Decretum vulnero ustulo abeo.",
        Duration = 104D,
        GlobalCode = "978-0-85270-680-0",
        Id = "4e90d428-afb8-4214-bb07-d525b68c6117",
        IsActive = false,
        IsFeatured = false,
        IsTaxable = true,
        IsVisible = true,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Caterva eveniet acies candidus.",
                Height = 876D,
                Id = "4710531f-607c-431c-b4c9-352c64fc51d6",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "959c10eb-8b29-4c0d-8332-9ae213880645",
                        Slug = "doloremque",
                        Value = CommerceMetadataValue.CreateStr(
                            "allatus"
                        ),
                    },
                },
                Position = 21D,
                Type = CommerceItemMediaType.Video,
                Url = "https://picsum.photos/seed/v73y0uzyK/3001/972",
                Width = 67D,
            },
            new CommerceItemMedia() {
                Alt = "Comedo.",
                Height = 651D,
                Id = "4760c377-99bc-4cd8-bcf7-c2dfda207bb7",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "72cfc1a4-88e1-49d0-8ada-89c07db382d2",
                        Slug = "bis",
                        Value = CommerceMetadataValue.CreateStr(
                            "somniculosus"
                        ),
                    },
                },
                Position = 51D,
                Type = CommerceItemMediaType.Image,
                Url = "https://picsum.photos/seed/Ao4iatfO/771/3906",
                Width = 3D,
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
                Id = "59a81611-a3a0-44c4-a650-a5e7f0d834e9",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CommerceMetadataValue.CreateStr(
                    "abstergo"
                ),
            },
        },
        Name = "Handcrafted Rubber Tuna",
        Prices = new List<CommerceItemPrice>() {
            new CommerceItemPrice() {
                Currency = "USD",
                Price = 78.11D,
            },
        },
        PublicDescription = "Custodia ventus solio compono.",
        PublicName = "Handcrafted Rubber Tuna",
        RequiresShipping = true,
        Slug = "handcrafted-rubber-tuna",
        Tags = new List<string>() {
            "beatae",
            "blanditiis",
        },
        TotalStock = 682D,
        Type = "SERVICE",
        UpdatedAt = System.DateTime.Parse("2022-04-20T14:24:18.337Z").ToUniversalTime(),
        VendorName = "Mayer - Flatley",
        Weight = 37D,
        WeightUnit = WeightUnit.Oz,
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