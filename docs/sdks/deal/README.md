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
        ClosedAt = System.DateTime.Parse("2024-03-08T12:43:43.391Z").ToUniversalTime(),
        ClosingAt = System.DateTime.Parse("2025-08-25T13:20:43.017Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2023-07-04T12:48:48.470Z").ToUniversalTime(),
        Currency = "IQD",
        Description = "Tabula cicuta sophismata comis tepidus sit cavus.",
        Id = "2c9b1123-2c28-43a5-ab7e-70abdafdccf4",
        Metadata = new List<CrmMetadata>() {
            new CrmMetadata() {
                ExtraData = CrmMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = CrmMetadataFormat.Text,
                Id = "ef38b827-2bdb-4fff-9db0-925c8c2e3984",
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
                Id = "152552ee-40e5-4019-a87f-880699bbf387",
                Name = "trans",
            },
        },
        Probability = 65D,
        Source = "cubo",
        Stages = new List<CrmReference>() {
            new CrmReference() {
                Id = "6117e68c-bd79-4098-9261-c8e862fecb97",
                Name = "tubineus",
            },
            new CrmReference() {
                Id = "46eb49e1-6f80-4d9c-a965-580100946157",
                Name = "adfectus",
            },
        },
        Tags = new List<string>() {
            "causa",
            "suus",
        },
        UpdatedAt = System.DateTime.Parse("2024-10-08T08:42:19.946Z").ToUniversalTime(),
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
        ClosedAt = System.DateTime.Parse("2024-03-08T12:43:43.395Z").ToUniversalTime(),
        ClosingAt = System.DateTime.Parse("2025-08-25T13:20:43.028Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2023-07-04T12:48:48.470Z").ToUniversalTime(),
        Currency = "IQD",
        Description = "Tabula cicuta sophismata comis tepidus sit cavus.",
        Id = "977abf23-805c-4cd2-96f6-b96f05fe69c4",
        Metadata = new List<CrmMetadata>() {
            new CrmMetadata() {
                ExtraData = CrmMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = CrmMetadataFormat.Text,
                Id = "9b1a0ff6-0864-49ca-8e4a-741b92ed51b5",
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
                Id = "b7c563bc-2562-4fc4-8bb0-5038e4da5221",
                Name = "trans",
            },
        },
        Probability = 65D,
        Source = "cubo",
        Stages = new List<CrmReference>() {
            new CrmReference() {
                Id = "737140b3-e947-49a8-a9b6-bb34532b9c03",
                Name = "tubineus",
            },
            new CrmReference() {
                Id = "c6e900f4-ec7f-476e-a5d3-bb4d6f4669b6",
                Name = "adfectus",
            },
        },
        Tags = new List<string>() {
            "causa",
            "suus",
        },
        UpdatedAt = System.DateTime.Parse("2024-10-08T08:42:19.952Z").ToUniversalTime(),
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
        ClosedAt = System.DateTime.Parse("2024-03-08T12:43:43.395Z").ToUniversalTime(),
        ClosingAt = System.DateTime.Parse("2025-08-25T13:20:43.028Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2023-07-04T12:48:48.470Z").ToUniversalTime(),
        Currency = "IQD",
        Description = "Tabula cicuta sophismata comis tepidus sit cavus.",
        Id = "977abf23-805c-4cd2-96f6-b96f05fe69c4",
        Metadata = new List<CrmMetadata>() {
            new CrmMetadata() {
                ExtraData = CrmMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = CrmMetadataFormat.Text,
                Id = "9b1a0ff6-0864-49ca-8e4a-741b92ed51b5",
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
                Id = "b7c563bc-2562-4fc4-8bb0-5038e4da5221",
                Name = "trans",
            },
        },
        Probability = 65D,
        Source = "cubo",
        Stages = new List<CrmReference>() {
            new CrmReference() {
                Id = "737140b3-e947-49a8-a9b6-bb34532b9c03",
                Name = "tubineus",
            },
            new CrmReference() {
                Id = "c6e900f4-ec7f-476e-a5d3-bb4d6f4669b6",
                Name = "adfectus",
            },
        },
        Tags = new List<string>() {
            "causa",
            "suus",
        },
        UpdatedAt = System.DateTime.Parse("2024-10-08T08:42:19.952Z").ToUniversalTime(),
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