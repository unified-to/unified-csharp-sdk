# Scorecard

## Overview

### Available Operations

* [CreateAtsScorecard](#createatsscorecard) - Create a scorecard
* [GetAtsScorecard](#getatsscorecard) - Retrieve a scorecard
* [ListAtsScorecards](#listatsscorecards) - List all scorecards
* [PatchAtsScorecard](#patchatsscorecard) - Update a scorecard
* [RemoveAtsScorecard](#removeatsscorecard) - Remove a scorecard
* [UpdateAtsScorecard](#updateatsscorecard) - Update a scorecard

## CreateAtsScorecard

Create a scorecard

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAtsScorecard" method="post" path="/ats/{connection_id}/scorecard" example="ats_scorecard" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Scorecard.CreateAtsScorecardAsync(
    atsScorecard: new AtsScorecard() {
        Comment = "Maiores enim.",
        CreatedAt = System.DateTime.Parse("2022-02-20T17:09:45.498Z").ToUniversalTime(),
        Id = "47bb49f0-71b5-4a4f-9469-1344ea1e4870",
        Questions = new List<AtsScorecardQuestion>() {
            new AtsScorecardQuestion() {
                Description = "Sulum textor eveniet facere vita.",
                Text = "Aliquam.",
            },
            new AtsScorecardQuestion() {
                Answer = "Decretum.",
                Description = "Conatus cicuta doloremque statua bonus.",
                Text = "Pecto vulpes libero vomer comburo.",
            },
        },
        Recommendation = Recommendation.StrongYes,
        UpdatedAt = System.DateTime.Parse("2023-05-27T11:10:32.892Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AtsScorecard`                                                                                                                                   | [AtsScorecard](../../Models/Components/AtsScorecard.md)                                                                                          | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAtsScorecardQueryParamFields](../../Models/Requests/CreateAtsScorecardQueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAtsScorecardResponse](../../Models/Requests/CreateAtsScorecardResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAtsScorecard

Retrieve a scorecard

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAtsScorecard" method="get" path="/ats/{connection_id}/scorecard/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Scorecard.GetAtsScorecardAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Scorecard                                                                                                                              |
| `Fields`                                                                                                                                         | List<[GetAtsScorecardQueryParamFields](../../Models/Requests/GetAtsScorecardQueryParamFields.md)>                                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAtsScorecardResponse](../../Models/Requests/GetAtsScorecardResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAtsScorecards

List all scorecards

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAtsScorecards" method="get" path="/ats/{connection_id}/scorecard" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAtsScorecardsRequest req = new ListAtsScorecardsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Scorecard.ListAtsScorecardsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListAtsScorecardsRequest](../../Models/Requests/ListAtsScorecardsRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[ListAtsScorecardsResponse](../../Models/Requests/ListAtsScorecardsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAtsScorecard

Update a scorecard

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAtsScorecard" method="patch" path="/ats/{connection_id}/scorecard/{id}" example="ats_scorecard" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAtsScorecardRequest req = new PatchAtsScorecardRequest() {
    AtsScorecard = new AtsScorecard() {
        Comment = "Maiores enim.",
        CreatedAt = System.DateTime.Parse("2022-02-20T17:09:45.498Z").ToUniversalTime(),
        Id = "324dfa59-f358-4841-a28e-b7836ff6d9e4",
        Questions = new List<AtsScorecardQuestion>() {
            new AtsScorecardQuestion() {
                Description = "Sulum textor eveniet facere vita.",
                Text = "Aliquam.",
            },
            new AtsScorecardQuestion() {
                Answer = "Decretum.",
                Description = "Conatus cicuta doloremque statua bonus.",
                Text = "Pecto vulpes libero vomer comburo.",
            },
        },
        Recommendation = Recommendation.StrongYes,
        UpdatedAt = System.DateTime.Parse("2023-05-27T11:10:32.894Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Scorecard.PatchAtsScorecardAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [PatchAtsScorecardRequest](../../Models/Requests/PatchAtsScorecardRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[PatchAtsScorecardResponse](../../Models/Requests/PatchAtsScorecardResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAtsScorecard

Remove a scorecard

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeAtsScorecard" method="delete" path="/ats/{connection_id}/scorecard/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Scorecard.RemoveAtsScorecardAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Scorecard  |

### Response

**[RemoveAtsScorecardResponse](../../Models/Requests/RemoveAtsScorecardResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAtsScorecard

Update a scorecard

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAtsScorecard" method="put" path="/ats/{connection_id}/scorecard/{id}" example="ats_scorecard" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAtsScorecardRequest req = new UpdateAtsScorecardRequest() {
    AtsScorecard = new AtsScorecard() {
        Comment = "Maiores enim.",
        CreatedAt = System.DateTime.Parse("2022-02-20T17:09:45.498Z").ToUniversalTime(),
        Id = "324dfa59-f358-4841-a28e-b7836ff6d9e4",
        Questions = new List<AtsScorecardQuestion>() {
            new AtsScorecardQuestion() {
                Description = "Sulum textor eveniet facere vita.",
                Text = "Aliquam.",
            },
            new AtsScorecardQuestion() {
                Answer = "Decretum.",
                Description = "Conatus cicuta doloremque statua bonus.",
                Text = "Pecto vulpes libero vomer comburo.",
            },
        },
        Recommendation = Recommendation.StrongYes,
        UpdatedAt = System.DateTime.Parse("2023-05-27T11:10:32.894Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Scorecard.UpdateAtsScorecardAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [UpdateAtsScorecardRequest](../../Models/Requests/UpdateAtsScorecardRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[UpdateAtsScorecardResponse](../../Models/Requests/UpdateAtsScorecardResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |