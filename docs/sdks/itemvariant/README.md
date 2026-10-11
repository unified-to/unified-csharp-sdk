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

Create an itemvariant

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
        AvailableAt = System.DateTime.Parse("2022-02-02T16:10:33.503Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2022-01-20T13:49:12.968Z").ToUniversalTime(),
        Description = "Featuring Helium-enhanced technology, our Chips offers unparalleled helpful performance",
        Height = 52D,
        Id = "5c490591-d2a1-470c-a016-2a6bc92b5377",
        IsActive = false,
        IsFeatured = false,
        IsVisible = false,
        Length = 94D,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Calcar delibero cursim summisse.",
                Height = 394D,
                Id = "adbef15f-8a7d-4e18-9ef1-afe5f9510c49",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "1ccc71f9-b4b2-4a6b-a857-a85c5ebacefa",
                        Slug = "illo",
                        Value = CommerceMetadataValue.CreateStr(
                            "quia"
                        ),
                    },
                },
                Position = 92D,
                Type = CommerceItemMediaType.Image,
                Url = "https://picsum.photos/seed/u0YdHqlRu/2007/3208",
                Width = 54D,
            },
            new CommerceItemMedia() {
                Alt = "Civitas acies substantia tergo.",
                Height = 351D,
                Id = "c4f98acb-c50f-45a8-abab-3ea6a74d9a59",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "d3334b35-1a0e-44c0-a048-8e40794de17c",
                        Slug = "libero",
                        Value = CommerceMetadataValue.CreateStr(
                            "capitulus"
                        ),
                    },
                },
                Position = 44D,
                Type = CommerceItemMediaType.Image,
                Url = "https://loremflickr.com/2230/1237?lock=8628070842159966",
                Width = 55D,
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
                Id = "06ff2d54-be89-434e-a272-0cb2cfa18c70",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CommerceMetadataValue.CreateStr(
                    "nihil"
                ),
            },
        },
        Name = "Keyboard",
        Options = new List<CommerceItemOption>() {
            new CommerceItemOption() {
                Id = "f889225a-cbca-42ae-b96c-aa0e18aabed0",
                Name = "Steel",
                Position = 97D,
                Values = new List<string>() {
                    "Granite",
                    "Plastic",
                },
            },
        },
        Prices = new List<CommerceItemPrice>() {
            new CommerceItemPrice() {
                CompareAtPrice = 3745D,
                Currency = "COP",
                Price = 4913D,
            },
            new CommerceItemPrice() {
                CompareAtPrice = 438D,
                Currency = "PHP",
                Price = 1378D,
            },
            new CommerceItemPrice() {
                CompareAtPrice = 1614D,
                Currency = "PHP",
                Price = 8702D,
            },
        },
        PublicDescription = "Stylish Soap designed to make you stand out with insistent looks",
        PublicName = "Keyboard",
        RequiresShipping = false,
        SizeUnit = SizeUnit.Cm,
        Sku = "978-0-7051-0955-0",
        Tags = new List<string>() {
            "vomito",
            "custodia",
        },
        TotalStock = 929D,
        UpdatedAt = System.DateTime.Parse("2025-06-09T21:37:46.891Z").ToUniversalTime(),
        Weight = 61D,
        WeightUnit = CommerceItemvariantWeightUnit.Oz,
        Width = 26D,
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

Retrieve an itemvariant

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

List all itemvariants

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

Update an itemvariant

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
        AvailableAt = System.DateTime.Parse("2022-02-02T16:10:33.503Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2022-01-20T13:49:12.968Z").ToUniversalTime(),
        Description = "Featuring Helium-enhanced technology, our Chips offers unparalleled helpful performance",
        Height = 52D,
        Id = "1e16a20d-5b27-4741-9336-be01a198bdf4",
        IsActive = false,
        IsFeatured = false,
        IsVisible = false,
        Length = 94D,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Calcar delibero cursim summisse.",
                Height = 394D,
                Id = "63a8cf91-9c6f-44cf-8407-0d091259559d",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "4d748301-86bc-4b80-a72a-df88546c9736",
                        Slug = "illo",
                        Value = CommerceMetadataValue.CreateStr(
                            "quia"
                        ),
                    },
                },
                Position = 92D,
                Type = CommerceItemMediaType.Image,
                Url = "https://picsum.photos/seed/u0YdHqlRu/2007/3208",
                Width = 54D,
            },
            new CommerceItemMedia() {
                Alt = "Civitas acies substantia tergo.",
                Height = 351D,
                Id = "a7773b2c-5552-4ffe-b159-ae2a43fd49ca",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "60134ea9-6179-4a4a-b2d3-9d1de0c36de0",
                        Slug = "libero",
                        Value = CommerceMetadataValue.CreateStr(
                            "capitulus"
                        ),
                    },
                },
                Position = 44D,
                Type = CommerceItemMediaType.Image,
                Url = "https://loremflickr.com/2230/1237?lock=8628070842159966",
                Width = 55D,
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
                Id = "8a751d96-7b45-4f96-b698-b05f80be5677",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CommerceMetadataValue.CreateStr(
                    "nihil"
                ),
            },
        },
        Name = "Keyboard",
        Options = new List<CommerceItemOption>() {
            new CommerceItemOption() {
                Id = "2909b676-0d4a-4229-bc9a-1fa00cffb292",
                Name = "Steel",
                Position = 97D,
                Values = new List<string>() {
                    "Granite",
                    "Plastic",
                },
            },
        },
        Prices = new List<CommerceItemPrice>() {
            new CommerceItemPrice() {
                CompareAtPrice = 3745D,
                Currency = "COP",
                Price = 4913D,
            },
            new CommerceItemPrice() {
                CompareAtPrice = 438D,
                Currency = "PHP",
                Price = 1378D,
            },
            new CommerceItemPrice() {
                CompareAtPrice = 1614D,
                Currency = "PHP",
                Price = 8702D,
            },
        },
        PublicDescription = "Stylish Soap designed to make you stand out with insistent looks",
        PublicName = "Keyboard",
        RequiresShipping = false,
        SizeUnit = SizeUnit.Cm,
        Sku = "978-0-7051-0955-0",
        Tags = new List<string>() {
            "vomito",
            "custodia",
        },
        TotalStock = 929D,
        UpdatedAt = System.DateTime.Parse("2025-06-09T21:37:46.912Z").ToUniversalTime(),
        Weight = 61D,
        WeightUnit = CommerceItemvariantWeightUnit.Oz,
        Width = 26D,
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

Remove an itemvariant

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

Update an itemvariant

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
        AvailableAt = System.DateTime.Parse("2022-02-02T16:10:33.503Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2022-01-20T13:49:12.968Z").ToUniversalTime(),
        Description = "Featuring Helium-enhanced technology, our Chips offers unparalleled helpful performance",
        Height = 52D,
        Id = "1e16a20d-5b27-4741-9336-be01a198bdf4",
        IsActive = false,
        IsFeatured = false,
        IsVisible = false,
        Length = 94D,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Calcar delibero cursim summisse.",
                Height = 394D,
                Id = "63a8cf91-9c6f-44cf-8407-0d091259559d",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "4d748301-86bc-4b80-a72a-df88546c9736",
                        Slug = "illo",
                        Value = CommerceMetadataValue.CreateStr(
                            "quia"
                        ),
                    },
                },
                Position = 92D,
                Type = CommerceItemMediaType.Image,
                Url = "https://picsum.photos/seed/u0YdHqlRu/2007/3208",
                Width = 54D,
            },
            new CommerceItemMedia() {
                Alt = "Civitas acies substantia tergo.",
                Height = 351D,
                Id = "a7773b2c-5552-4ffe-b159-ae2a43fd49ca",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "60134ea9-6179-4a4a-b2d3-9d1de0c36de0",
                        Slug = "libero",
                        Value = CommerceMetadataValue.CreateStr(
                            "capitulus"
                        ),
                    },
                },
                Position = 44D,
                Type = CommerceItemMediaType.Image,
                Url = "https://loremflickr.com/2230/1237?lock=8628070842159966",
                Width = 55D,
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
                Id = "8a751d96-7b45-4f96-b698-b05f80be5677",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CommerceMetadataValue.CreateStr(
                    "nihil"
                ),
            },
        },
        Name = "Keyboard",
        Options = new List<CommerceItemOption>() {
            new CommerceItemOption() {
                Id = "2909b676-0d4a-4229-bc9a-1fa00cffb292",
                Name = "Steel",
                Position = 97D,
                Values = new List<string>() {
                    "Granite",
                    "Plastic",
                },
            },
        },
        Prices = new List<CommerceItemPrice>() {
            new CommerceItemPrice() {
                CompareAtPrice = 3745D,
                Currency = "COP",
                Price = 4913D,
            },
            new CommerceItemPrice() {
                CompareAtPrice = 438D,
                Currency = "PHP",
                Price = 1378D,
            },
            new CommerceItemPrice() {
                CompareAtPrice = 1614D,
                Currency = "PHP",
                Price = 8702D,
            },
        },
        PublicDescription = "Stylish Soap designed to make you stand out with insistent looks",
        PublicName = "Keyboard",
        RequiresShipping = false,
        SizeUnit = SizeUnit.Cm,
        Sku = "978-0-7051-0955-0",
        Tags = new List<string>() {
            "vomito",
            "custodia",
        },
        TotalStock = 929D,
        UpdatedAt = System.DateTime.Parse("2025-06-09T21:37:46.912Z").ToUniversalTime(),
        Weight = 61D,
        WeightUnit = CommerceItemvariantWeightUnit.Oz,
        Width = 26D,
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