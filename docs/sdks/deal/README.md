# Deal

## Overview

### Available Operations

* [CreateCrmDeal](#createcrmdeal) - Create a deal
* [GetCrmDeal](#getcrmdeal) - Retrieve a deal
* [ListCrmDeals](#listcrmdeals) - List all deals
* [PatchCrmDeal](#patchcrmdeal) - Update a deal
* [RemoveCrmDeal](#removecrmdeal) - Remove a deal
* [UpdateCrmDeal](#updatecrmdeal) - Update a deal

## CreateCrmDeal

Create a deal

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createCrmDeal" method="post" path="/crm/{connection_id}/deal" example="crm_deal" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Deal.CreateCrmDealAsync(
    crmDeal: new CrmDeal() {
        Amount = 98162D,
        ClosedAt = System.DateTime.Parse("2024-03-08T08:20:31.024Z").ToUniversalTime(),
        ClosingAt = System.DateTime.Parse("2025-08-24T23:29:40.318Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2023-07-04T12:48:48.470Z").ToUniversalTime(),
        Currency = "IQD",
        Description = "Tabula cicuta sophismata comis tepidus sit cavus.",
        Id = "205a38cf-b0f6-40bc-8544-ff04eb9ffb55",
        Metadata = new List<CrmMetadata>() {
            new CrmMetadata() {
                ExtraData = CrmMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = CrmMetadataFormat.Text,
                Id = "6ad25ffe-54aa-4a31-8517-928d9609dc6a",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CrmMetadataValue.CreateStr(
                    "conatus"
                ),
            },
        },
        Name = "Frozen Silk Chicken",
        Pipelines = new List<CrmReference>() {
            new CrmReference() {
                Id = "d3e980ee-1e17-407e-84e8-c7c8ad0d9116",
                Name = "trans",
            },
        },
        Probability = 65D,
        Source = "cubo",
        Stages = new List<CrmReference>() {
            new CrmReference() {
                Id = "addc2637-1d57-4ab0-ad07-605e424b73e3",
                Name = "tubineus",
            },
            new CrmReference() {
                Id = "ad929775-18d4-45a7-9a5e-eb5ef618480f",
                Name = "adfectus",
            },
        },
        Tags = new List<string>() {
            "causa",
            "suus",
        },
        UpdatedAt = System.DateTime.Parse("2024-10-08T00:32:10.775Z").ToUniversalTime(),
        WonReason = "Usque libero soleo.",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `CrmDeal`                                                                                                                                        | [CrmDeal](../../Models/Components/CrmDeal.md)                                                                                                    | :heavy_check_mark:                                                                                                                               | A deal represents an opportunity with companies and/or contacts                                                                                  |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateCrmDealQueryParamFields](../../Models/Requests/CreateCrmDealQueryParamFields.md)>                                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateCrmDealResponse](../../Models/Requests/CreateCrmDealResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetCrmDeal

Retrieve a deal

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCrmDeal" method="get" path="/crm/{connection_id}/deal/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Deal.GetCrmDealAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Deal                                                                                                                                   |
| `Fields`                                                                                                                                         | List<[GetCrmDealQueryParamFields](../../Models/Requests/GetCrmDealQueryParamFields.md)>                                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetCrmDealResponse](../../Models/Requests/GetCrmDealResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListCrmDeals

List all deals

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listCrmDeals" method="get" path="/crm/{connection_id}/deal" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListCrmDealsRequest req = new ListCrmDealsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Deal.ListCrmDealsAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [ListCrmDealsRequest](../../Models/Requests/ListCrmDealsRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[ListCrmDealsResponse](../../Models/Requests/ListCrmDealsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchCrmDeal

Update a deal

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchCrmDeal" method="patch" path="/crm/{connection_id}/deal/{id}" example="crm_deal" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchCrmDealRequest req = new PatchCrmDealRequest() {
    CrmDeal = new CrmDeal() {
        Amount = 98162D,
        ClosedAt = System.DateTime.Parse("2024-03-08T08:20:31.029Z").ToUniversalTime(),
        ClosingAt = System.DateTime.Parse("2025-08-24T23:29:40.333Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2023-07-04T12:48:48.470Z").ToUniversalTime(),
        Currency = "IQD",
        Description = "Tabula cicuta sophismata comis tepidus sit cavus.",
        Id = "f41f5d60-f6ea-4fb2-b3c4-61e997f3dd66",
        Metadata = new List<CrmMetadata>() {
            new CrmMetadata() {
                ExtraData = CrmMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = CrmMetadataFormat.Text,
                Id = "8ddf385b-1f76-4701-975a-619fadafa352",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CrmMetadataValue.CreateStr(
                    "conatus"
                ),
            },
        },
        Name = "Frozen Silk Chicken",
        Pipelines = new List<CrmReference>() {
            new CrmReference() {
                Id = "d0e9f42b-f335-4181-a2af-d309419b2203",
                Name = "trans",
            },
        },
        Probability = 65D,
        Source = "cubo",
        Stages = new List<CrmReference>() {
            new CrmReference() {
                Id = "7456e13a-38f3-4500-93f0-94810912aba0",
                Name = "tubineus",
            },
            new CrmReference() {
                Id = "1aad3541-dac5-4cea-ac3f-039d90d807ce",
                Name = "adfectus",
            },
        },
        Tags = new List<string>() {
            "causa",
            "suus",
        },
        UpdatedAt = System.DateTime.Parse("2024-10-08T00:32:10.784Z").ToUniversalTime(),
        WonReason = "Usque libero soleo.",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Deal.PatchCrmDealAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [PatchCrmDealRequest](../../Models/Requests/PatchCrmDealRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[PatchCrmDealResponse](../../Models/Requests/PatchCrmDealResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveCrmDeal

Remove a deal

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeCrmDeal" method="delete" path="/crm/{connection_id}/deal/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Deal.RemoveCrmDealAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Deal       |

### Response

**[RemoveCrmDealResponse](../../Models/Requests/RemoveCrmDealResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateCrmDeal

Update a deal

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateCrmDeal" method="put" path="/crm/{connection_id}/deal/{id}" example="crm_deal" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateCrmDealRequest req = new UpdateCrmDealRequest() {
    CrmDeal = new CrmDeal() {
        Amount = 98162D,
        ClosedAt = System.DateTime.Parse("2024-03-08T08:20:31.029Z").ToUniversalTime(),
        ClosingAt = System.DateTime.Parse("2025-08-24T23:29:40.333Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2023-07-04T12:48:48.470Z").ToUniversalTime(),
        Currency = "IQD",
        Description = "Tabula cicuta sophismata comis tepidus sit cavus.",
        Id = "f41f5d60-f6ea-4fb2-b3c4-61e997f3dd66",
        Metadata = new List<CrmMetadata>() {
            new CrmMetadata() {
                ExtraData = CrmMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = CrmMetadataFormat.Text,
                Id = "8ddf385b-1f76-4701-975a-619fadafa352",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CrmMetadataValue.CreateStr(
                    "conatus"
                ),
            },
        },
        Name = "Frozen Silk Chicken",
        Pipelines = new List<CrmReference>() {
            new CrmReference() {
                Id = "d0e9f42b-f335-4181-a2af-d309419b2203",
                Name = "trans",
            },
        },
        Probability = 65D,
        Source = "cubo",
        Stages = new List<CrmReference>() {
            new CrmReference() {
                Id = "7456e13a-38f3-4500-93f0-94810912aba0",
                Name = "tubineus",
            },
            new CrmReference() {
                Id = "1aad3541-dac5-4cea-ac3f-039d90d807ce",
                Name = "adfectus",
            },
        },
        Tags = new List<string>() {
            "causa",
            "suus",
        },
        UpdatedAt = System.DateTime.Parse("2024-10-08T00:32:10.784Z").ToUniversalTime(),
        WonReason = "Usque libero soleo.",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Deal.UpdateCrmDealAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [UpdateCrmDealRequest](../../Models/Requests/UpdateCrmDealRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[UpdateCrmDealResponse](../../Models/Requests/UpdateCrmDealResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |