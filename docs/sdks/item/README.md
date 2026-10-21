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
        Description = "Decretum vulnero ustulo abeo.",
        Duration = 104D,
        GlobalCode = "978-0-85270-680-0",
        Id = "2a9440ca-5ea3-4a4b-ba1d-541b2c4b4ea4",
        IsActive = false,
        IsFeatured = false,
        IsTaxable = true,
        IsVisible = true,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Caterva eveniet acies candidus.",
                Height = 876D,
                Id = "bf760972-4280-4350-a465-10bc7322a355",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "398e34ea-52c5-4d8d-9110-87dad8a78cb6",
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
                Id = "700a824a-d204-45ae-82e5-c9013ca7c37a",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "c62b7a82-7984-4b15-ac66-f210f1d0f955",
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
                Id = "8dc4e756-ba52-4d88-afd6-f23960ff0eb3",
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
        UpdatedAt = System.DateTime.Parse("2022-04-19T12:07:52.299Z").ToUniversalTime(),
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
        Description = "Decretum vulnero ustulo abeo.",
        Duration = 104D,
        GlobalCode = "978-0-85270-680-0",
        Id = "889641b6-5238-40b2-8f6e-5efa654f91f2",
        IsActive = false,
        IsFeatured = false,
        IsTaxable = true,
        IsVisible = true,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Caterva eveniet acies candidus.",
                Height = 876D,
                Id = "3f21a39b-3714-4ea2-b673-9aaa02478b93",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "664806ad-0293-42e1-881e-4769875c1799",
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
                Id = "61e74e24-2690-4a98-8764-787c1cf7e4b6",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "b469541d-ab4c-42af-a1c0-edaa7abb65c5",
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
                Id = "8088de66-4139-4874-9203-1325a0bc7656",
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
        UpdatedAt = System.DateTime.Parse("2022-04-19T12:07:52.307Z").ToUniversalTime(),
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
        Description = "Decretum vulnero ustulo abeo.",
        Duration = 104D,
        GlobalCode = "978-0-85270-680-0",
        Id = "889641b6-5238-40b2-8f6e-5efa654f91f2",
        IsActive = false,
        IsFeatured = false,
        IsTaxable = true,
        IsVisible = true,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Caterva eveniet acies candidus.",
                Height = 876D,
                Id = "3f21a39b-3714-4ea2-b673-9aaa02478b93",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "664806ad-0293-42e1-881e-4769875c1799",
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
                Id = "61e74e24-2690-4a98-8764-787c1cf7e4b6",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "b469541d-ab4c-42af-a1c0-edaa7abb65c5",
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
                Id = "8088de66-4139-4874-9203-1325a0bc7656",
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
        UpdatedAt = System.DateTime.Parse("2022-04-19T12:07:52.307Z").ToUniversalTime(),
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