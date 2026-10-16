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
        Id = "840c39c3-4666-4e53-8edb-8f3b6209a1a4",
        IsActive = false,
        IsFeatured = false,
        IsVisible = false,
        Length = 94D,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Calcar delibero cursim summisse.",
                Height = 394D,
                Id = "d4b9028d-9519-4c85-902a-9bd56502cb4f",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "ed5697e9-b01d-4694-966a-7ff520836dc0",
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
                Id = "59897d88-51be-49d4-a8ec-d20882dbf0b4",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "bec70192-cce5-4589-8e23-d20210a2a8c8",
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
                Id = "7177f5b1-27cd-416f-a1f6-bacc3872cc47",
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
                Id = "8e81dabf-ad52-4ec2-ac94-f788dad6485e",
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
        UpdatedAt = System.DateTime.Parse("2025-06-13T11:57:26.827Z").ToUniversalTime(),
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
        Id = "e02669a1-9c38-45b6-951a-b58ff514c549",
        IsActive = false,
        IsFeatured = false,
        IsVisible = false,
        Length = 94D,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Calcar delibero cursim summisse.",
                Height = 394D,
                Id = "f4955e03-a761-4e2e-90d7-10eca795614a",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "20021036-5071-4f66-b6c0-fe75d9d1a2e9",
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
                Id = "c80679b3-b457-47ec-8ed5-ca60931dd293",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "afb13f6f-6930-418c-8750-d8d4c7ebaea0",
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
                Id = "3867e967-ba80-4a30-9935-f776d64a4028",
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
                Id = "9fce62f7-5c0e-4b19-ac7c-dee81bf410fd",
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
        UpdatedAt = System.DateTime.Parse("2025-06-13T11:57:26.850Z").ToUniversalTime(),
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
        Id = "e02669a1-9c38-45b6-951a-b58ff514c549",
        IsActive = false,
        IsFeatured = false,
        IsVisible = false,
        Length = 94D,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Calcar delibero cursim summisse.",
                Height = 394D,
                Id = "f4955e03-a761-4e2e-90d7-10eca795614a",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "20021036-5071-4f66-b6c0-fe75d9d1a2e9",
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
                Id = "c80679b3-b457-47ec-8ed5-ca60931dd293",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "afb13f6f-6930-418c-8750-d8d4c7ebaea0",
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
                Id = "3867e967-ba80-4a30-9935-f776d64a4028",
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
                Id = "9fce62f7-5c0e-4b19-ac7c-dee81bf410fd",
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
        UpdatedAt = System.DateTime.Parse("2025-06-13T11:57:26.850Z").ToUniversalTime(),
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