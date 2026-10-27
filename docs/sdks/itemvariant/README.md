# Itemvariant

## Overview

### Available Operations

* [CreateCommerceItemvariant](#createcommerceitemvariant) - Create an itemvariant
* [GetCommerceItemvariant](#getcommerceitemvariant) - Retrieve an itemvariant
* [ListCommerceItemvariants](#listcommerceitemvariants) - List all itemvariants
* [PatchCommerceItemvariant](#patchcommerceitemvariant) - Update an itemvariant
* [RemoveCommerceItemvariant](#removecommerceitemvariant) - Remove an itemvariant
* [UpdateCommerceItemvariant](#updatecommerceitemvariant) - Update an itemvariant

## CreateCommerceItemvariant

Creates a CommerceItemvariant. Provide the unified CommerceItemvariant fields in the request body; they are mapped to the provider's API. Returns the created CommerceItemvariant.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createCommerceItemvariant" method="post" path="/commerce/{connection_id}/itemvariant" example="commerce_itemvariant" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Itemvariant.CreateCommerceItemvariantAsync(
    commerceItemvariant: new CommerceItemvariant() {
        AvailableAt = System.DateTime.Parse("2022-02-06T18:14:41.644Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2022-01-20T13:49:12.968Z").ToUniversalTime(),
        Description = "Stylish Salad designed to make you stand out with little looks",
        Height = 54D,
        Id = "7a58958f-1834-4b31-870d-619993521864",
        IsActive = true,
        IsFeatured = false,
        IsVisible = false,
        Length = 92D,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Hic desipio thorax.",
                Height = 961D,
                Id = "7594164a-1d2b-4d45-96e6-f76dec515cb2",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "00983fd2-1fc1-4bcf-ab59-31011e0bed79",
                        Slug = "ubi",
                        Value = CommerceMetadataValue.CreateStr(
                            "textus"
                        ),
                    },
                },
                Position = 72D,
                Type = CommerceItemMediaType.Image,
                Url = "https://loremflickr.com/2126/721?lock=8820088623807162",
                Width = 35D,
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
                Id = "42bc72ce-9bc1-43d9-b6d9-33e70e39784a",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CommerceMetadataValue.CreateStr(
                    "absens"
                ),
            },
        },
        Name = "Chair",
        Options = new List<CommerceItemOption>() {
            new CommerceItemOption() {
                Id = "230eafcb-18fb-4bf8-88f2-8951b9319620",
                Name = "Color",
                Position = 1D,
                Values = new List<string>() {
                    "olive",
                },
            },
            new CommerceItemOption() {
                Id = "a0a95a6b-60dc-4e0c-8bf6-9fddc366240b",
                Name = "Size",
                Position = 2D,
                Values = new List<string>() {
                    "S",
                },
            },
        },
        Prices = new List<CommerceItemPrice>() {
            new CommerceItemPrice() {
                Currency = "USD",
                Price = 382.23D,
            },
        },
        PublicDescription = "Stylish Cheese designed to make you stand out with grave looks",
        PublicName = "Chair",
        RequiresShipping = false,
        SizeUnit = SizeUnit.Cm,
        Sku = "978-1-368-44270-1",
        Tags = new List<string>() {
            "deserunt",
        },
        TotalStock = 436D,
        UpdatedAt = System.DateTime.Parse("2026-03-14T22:05:59.069Z").ToUniversalTime(),
        Weight = 46D,
        WeightUnit = CommerceItemvariantWeightUnit.Oz,
        Width = 40D,
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `CommerceItemvariant`                                                                                                                            | [CommerceItemvariant](../../Models/Components/CommerceItemvariant.md)                                                                            | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateCommerceItemvariantQueryParamFields](../../Models/Requests/CreateCommerceItemvariantQueryParamFields.md)>                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateCommerceItemvariantResponse](../../Models/Requests/CreateCommerceItemvariantResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetCommerceItemvariant

Retrieves a single CommerceItemvariant by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCommerceItemvariant" method="get" path="/commerce/{connection_id}/itemvariant/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Itemvariant.GetCommerceItemvariantAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Itemvariant                                                                                                                            |
| `Fields`                                                                                                                                         | List<[GetCommerceItemvariantQueryParamFields](../../Models/Requests/GetCommerceItemvariantQueryParamFields.md)>                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetCommerceItemvariantResponse](../../Models/Requests/GetCommerceItemvariantResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListCommerceItemvariants

Returns a list of CommerceItemvariants. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listCommerceItemvariants" method="get" path="/commerce/{connection_id}/itemvariant" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListCommerceItemvariantsRequest req = new ListCommerceItemvariantsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Itemvariant.ListCommerceItemvariantsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [ListCommerceItemvariantsRequest](../../Models/Requests/ListCommerceItemvariantsRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[ListCommerceItemvariantsResponse](../../Models/Requests/ListCommerceItemvariantsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchCommerceItemvariant

Updates the CommerceItemvariant identified by `id`. Provide the unified CommerceItemvariant fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchCommerceItemvariant" method="patch" path="/commerce/{connection_id}/itemvariant/{id}" example="commerce_itemvariant" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchCommerceItemvariantRequest req = new PatchCommerceItemvariantRequest() {
    CommerceItemvariant = new CommerceItemvariant() {
        AvailableAt = System.DateTime.Parse("2022-02-06T18:14:41.644Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2022-01-20T13:49:12.968Z").ToUniversalTime(),
        Description = "Stylish Salad designed to make you stand out with little looks",
        Height = 54D,
        Id = "5c8c7eac-eb2c-463e-b767-dc08de2afdfa",
        IsActive = true,
        IsFeatured = false,
        IsVisible = false,
        Length = 92D,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Hic desipio thorax.",
                Height = 961D,
                Id = "c68a7b98-c947-45bf-a0dc-3e2fa7752d01",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "81e0c547-3051-43cb-bfb1-203a1510ae44",
                        Slug = "ubi",
                        Value = CommerceMetadataValue.CreateStr(
                            "textus"
                        ),
                    },
                },
                Position = 72D,
                Type = CommerceItemMediaType.Image,
                Url = "https://loremflickr.com/2126/721?lock=8820088623807162",
                Width = 35D,
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
                Id = "13d28843-4e97-48fa-b6d9-8c77fc71c197",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CommerceMetadataValue.CreateStr(
                    "absens"
                ),
            },
        },
        Name = "Chair",
        Options = new List<CommerceItemOption>() {
            new CommerceItemOption() {
                Id = "cd1ecab9-6b42-483a-89cd-e7644a8ead82",
                Name = "Color",
                Position = 1D,
                Values = new List<string>() {
                    "olive",
                },
            },
            new CommerceItemOption() {
                Id = "f5cb4bdd-3a2f-4d89-b032-b8ad2ba26dbb",
                Name = "Size",
                Position = 2D,
                Values = new List<string>() {
                    "S",
                },
            },
        },
        Prices = new List<CommerceItemPrice>() {
            new CommerceItemPrice() {
                Currency = "USD",
                Price = 382.23D,
            },
        },
        PublicDescription = "Stylish Cheese designed to make you stand out with grave looks",
        PublicName = "Chair",
        RequiresShipping = false,
        SizeUnit = SizeUnit.Cm,
        Sku = "978-1-368-44270-1",
        Tags = new List<string>() {
            "deserunt",
        },
        TotalStock = 436D,
        UpdatedAt = System.DateTime.Parse("2026-03-14T22:05:59.108Z").ToUniversalTime(),
        Weight = 46D,
        WeightUnit = CommerceItemvariantWeightUnit.Oz,
        Width = 40D,
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Itemvariant.PatchCommerceItemvariantAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [PatchCommerceItemvariantRequest](../../Models/Requests/PatchCommerceItemvariantRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[PatchCommerceItemvariantResponse](../../Models/Requests/PatchCommerceItemvariantResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveCommerceItemvariant

Deletes the CommerceItemvariant identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeCommerceItemvariant" method="delete" path="/commerce/{connection_id}/itemvariant/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Itemvariant.RemoveCommerceItemvariantAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter             | Type                  | Required              | Description           |
| --------------------- | --------------------- | --------------------- | --------------------- |
| `ConnectionId`        | *string*              | :heavy_check_mark:    | ID of the connection  |
| `Id`                  | *string*              | :heavy_check_mark:    | ID of the Itemvariant |

### Response

**[RemoveCommerceItemvariantResponse](../../Models/Requests/RemoveCommerceItemvariantResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateCommerceItemvariant

Updates the CommerceItemvariant identified by `id`. Provide the unified CommerceItemvariant fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateCommerceItemvariant" method="put" path="/commerce/{connection_id}/itemvariant/{id}" example="commerce_itemvariant" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateCommerceItemvariantRequest req = new UpdateCommerceItemvariantRequest() {
    CommerceItemvariant = new CommerceItemvariant() {
        AvailableAt = System.DateTime.Parse("2022-02-06T18:14:41.644Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2022-01-20T13:49:12.968Z").ToUniversalTime(),
        Description = "Stylish Salad designed to make you stand out with little looks",
        Height = 54D,
        Id = "5c8c7eac-eb2c-463e-b767-dc08de2afdfa",
        IsActive = true,
        IsFeatured = false,
        IsVisible = false,
        Length = 92D,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Hic desipio thorax.",
                Height = 961D,
                Id = "c68a7b98-c947-45bf-a0dc-3e2fa7752d01",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "81e0c547-3051-43cb-bfb1-203a1510ae44",
                        Slug = "ubi",
                        Value = CommerceMetadataValue.CreateStr(
                            "textus"
                        ),
                    },
                },
                Position = 72D,
                Type = CommerceItemMediaType.Image,
                Url = "https://loremflickr.com/2126/721?lock=8820088623807162",
                Width = 35D,
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
                Id = "13d28843-4e97-48fa-b6d9-8c77fc71c197",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CommerceMetadataValue.CreateStr(
                    "absens"
                ),
            },
        },
        Name = "Chair",
        Options = new List<CommerceItemOption>() {
            new CommerceItemOption() {
                Id = "cd1ecab9-6b42-483a-89cd-e7644a8ead82",
                Name = "Color",
                Position = 1D,
                Values = new List<string>() {
                    "olive",
                },
            },
            new CommerceItemOption() {
                Id = "f5cb4bdd-3a2f-4d89-b032-b8ad2ba26dbb",
                Name = "Size",
                Position = 2D,
                Values = new List<string>() {
                    "S",
                },
            },
        },
        Prices = new List<CommerceItemPrice>() {
            new CommerceItemPrice() {
                Currency = "USD",
                Price = 382.23D,
            },
        },
        PublicDescription = "Stylish Cheese designed to make you stand out with grave looks",
        PublicName = "Chair",
        RequiresShipping = false,
        SizeUnit = SizeUnit.Cm,
        Sku = "978-1-368-44270-1",
        Tags = new List<string>() {
            "deserunt",
        },
        TotalStock = 436D,
        UpdatedAt = System.DateTime.Parse("2026-03-14T22:05:59.108Z").ToUniversalTime(),
        Weight = 46D,
        WeightUnit = CommerceItemvariantWeightUnit.Oz,
        Width = 40D,
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Itemvariant.UpdateCommerceItemvariantAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [UpdateCommerceItemvariantRequest](../../Models/Requests/UpdateCommerceItemvariantRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[UpdateCommerceItemvariantResponse](../../Models/Requests/UpdateCommerceItemvariantResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |