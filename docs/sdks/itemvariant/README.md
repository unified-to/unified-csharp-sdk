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
        Id = "01b74347-b259-4cd6-978a-29e043a2d60d",
        IsActive = false,
        IsFeatured = false,
        IsVisible = false,
        Length = 94D,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Calcar delibero cursim summisse.",
                Height = 394D,
                Id = "298793f0-9e6e-4f46-8ad7-94fb85412f0b",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "681cfc4d-9e3a-4353-8403-e9f85ab9a973",
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
                Id = "56b8fcfd-e09a-4b60-b921-83e8a6639043",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "3a1bd105-ab9a-4998-8254-cc33eb6641ab",
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
                Id = "06aab4da-b604-44ee-9561-4c2532394d35",
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
                Id = "9d179cdb-b3c0-4d54-a087-821d811a5882",
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
        UpdatedAt = System.DateTime.Parse("2025-06-15T13:55:20.190Z").ToUniversalTime(),
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
        Id = "4d887027-2de7-46d1-9e73-4ac9443cbc37",
        IsActive = false,
        IsFeatured = false,
        IsVisible = false,
        Length = 94D,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Calcar delibero cursim summisse.",
                Height = 394D,
                Id = "3fa772dc-71cc-477d-a290-5db8c375c715",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "08588754-dc85-4fb7-a3dd-7f33c3d9dbec",
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
                Id = "a52d675e-8808-4e77-b06f-1817144fe9b6",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "f2ab4835-68c9-45d0-beff-e3f34ff449f0",
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
                Id = "305e9867-8d9f-46c3-a8e5-7cbf159c6b79",
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
                Id = "d937821f-b18f-40c9-ad4d-9f7005edcdf8",
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
        UpdatedAt = System.DateTime.Parse("2025-06-15T13:55:20.215Z").ToUniversalTime(),
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
        Id = "4d887027-2de7-46d1-9e73-4ac9443cbc37",
        IsActive = false,
        IsFeatured = false,
        IsVisible = false,
        Length = 94D,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Calcar delibero cursim summisse.",
                Height = 394D,
                Id = "3fa772dc-71cc-477d-a290-5db8c375c715",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "08588754-dc85-4fb7-a3dd-7f33c3d9dbec",
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
                Id = "a52d675e-8808-4e77-b06f-1817144fe9b6",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "f2ab4835-68c9-45d0-beff-e3f34ff449f0",
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
                Id = "305e9867-8d9f-46c3-a8e5-7cbf159c6b79",
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
                Id = "d937821f-b18f-40c9-ad4d-9f7005edcdf8",
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
        UpdatedAt = System.DateTime.Parse("2025-06-15T13:55:20.215Z").ToUniversalTime(),
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