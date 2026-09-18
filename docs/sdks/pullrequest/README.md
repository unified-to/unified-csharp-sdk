# Pullrequest

## Overview

### Available Operations

* [CreateRepoPullrequest](#createrepopullrequest) - Create a pullrequest
* [GetRepoPullrequest](#getrepopullrequest) - Retrieve a pullrequest
* [ListRepoPullrequests](#listrepopullrequests) - List all pullrequests
* [PatchRepoPullrequest](#patchrepopullrequest) - Update a pullrequest
* [RemoveRepoPullrequest](#removerepopullrequest) - Remove a pullrequest
* [UpdateRepoPullrequest](#updaterepopullrequest) - Update a pullrequest

## CreateRepoPullrequest

Create a pullrequest

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createRepoPullrequest" method="post" path="/repo/{connection_id}/pullrequest" example="repo_pullrequest" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Pullrequest.CreateRepoPullrequestAsync(
    repoPullrequest: new RepoPullrequest() {
        ClosedAt = System.DateTime.Parse("2025-04-11T21:29:15.705Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2023-02-27T09:37:13.663Z").ToUniversalTime(),
        Id = "a371259c-921a-4ab7-8890-66df1900e75a",
        Labels = new List<string>() {
            "adhuc",
            "quaerat",
        },
        Notes = "Coadunatio turbo curtus ceno consuasor aggero. Suggero adeo creptio tutamen vulnus aqua delicate adopto derelinquo caritas. Maiores vulgivagus succurro temporibus.",
        SourceBranchId = "microchip-navigate",
        Status = RepoPullrequestStatus.Rejected,
        TargetBranchId = "feed-reboot",
        Title = "Cunae aegrus averto texo advoco bibo amet asporto.",
        UpdatedAt = System.DateTime.Parse("2024-12-30T23:43:16.473Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `RepoPullrequest`                                                                                                                                | [RepoPullrequest](../../Models/Components/RepoPullrequest.md)                                                                                    | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateRepoPullrequestQueryParamFields](../../Models/Requests/CreateRepoPullrequestQueryParamFields.md)>                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateRepoPullrequestResponse](../../Models/Requests/CreateRepoPullrequestResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetRepoPullrequest

Retrieve a pullrequest

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getRepoPullrequest" method="get" path="/repo/{connection_id}/pullrequest/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Pullrequest.GetRepoPullrequestAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Pullrequest                                                                                                                            |
| `Fields`                                                                                                                                         | List<[GetRepoPullrequestQueryParamFields](../../Models/Requests/GetRepoPullrequestQueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetRepoPullrequestResponse](../../Models/Requests/GetRepoPullrequestResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListRepoPullrequests

List all pullrequests

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listRepoPullrequests" method="get" path="/repo/{connection_id}/pullrequest" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListRepoPullrequestsRequest req = new ListRepoPullrequestsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Pullrequest.ListRepoPullrequestsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [ListRepoPullrequestsRequest](../../Models/Requests/ListRepoPullrequestsRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[ListRepoPullrequestsResponse](../../Models/Requests/ListRepoPullrequestsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchRepoPullrequest

Update a pullrequest

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchRepoPullrequest" method="patch" path="/repo/{connection_id}/pullrequest/{id}" example="repo_pullrequest" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchRepoPullrequestRequest req = new PatchRepoPullrequestRequest() {
    RepoPullrequest = new RepoPullrequest() {
        ClosedAt = System.DateTime.Parse("2025-04-11T21:29:15.711Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2023-02-27T09:37:13.663Z").ToUniversalTime(),
        Id = "047c6837-52d0-4609-a236-614e474b832a",
        Labels = new List<string>() {
            "adhuc",
            "quaerat",
        },
        Notes = "Coadunatio turbo curtus ceno consuasor aggero. Suggero adeo creptio tutamen vulnus aqua delicate adopto derelinquo caritas. Maiores vulgivagus succurro temporibus.",
        SourceBranchId = "microchip-navigate",
        Status = RepoPullrequestStatus.Rejected,
        TargetBranchId = "feed-reboot",
        Title = "Cunae aegrus averto texo advoco bibo amet asporto.",
        UpdatedAt = System.DateTime.Parse("2024-12-30T23:43:16.479Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Pullrequest.PatchRepoPullrequestAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [PatchRepoPullrequestRequest](../../Models/Requests/PatchRepoPullrequestRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[PatchRepoPullrequestResponse](../../Models/Requests/PatchRepoPullrequestResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveRepoPullrequest

Remove a pullrequest

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeRepoPullrequest" method="delete" path="/repo/{connection_id}/pullrequest/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Pullrequest.RemoveRepoPullrequestAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter             | Type                  | Required              | Description           |
| --------------------- | --------------------- | --------------------- | --------------------- |
| `ConnectionId`        | *string*              | :heavy_check_mark:    | ID of the connection  |
| `Id`                  | *string*              | :heavy_check_mark:    | ID of the Pullrequest |

### Response

**[RemoveRepoPullrequestResponse](../../Models/Requests/RemoveRepoPullrequestResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateRepoPullrequest

Update a pullrequest

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateRepoPullrequest" method="put" path="/repo/{connection_id}/pullrequest/{id}" example="repo_pullrequest" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateRepoPullrequestRequest req = new UpdateRepoPullrequestRequest() {
    RepoPullrequest = new RepoPullrequest() {
        ClosedAt = System.DateTime.Parse("2025-04-11T21:29:15.711Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2023-02-27T09:37:13.663Z").ToUniversalTime(),
        Id = "047c6837-52d0-4609-a236-614e474b832a",
        Labels = new List<string>() {
            "adhuc",
            "quaerat",
        },
        Notes = "Coadunatio turbo curtus ceno consuasor aggero. Suggero adeo creptio tutamen vulnus aqua delicate adopto derelinquo caritas. Maiores vulgivagus succurro temporibus.",
        SourceBranchId = "microchip-navigate",
        Status = RepoPullrequestStatus.Rejected,
        TargetBranchId = "feed-reboot",
        Title = "Cunae aegrus averto texo advoco bibo amet asporto.",
        UpdatedAt = System.DateTime.Parse("2024-12-30T23:43:16.479Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Pullrequest.UpdateRepoPullrequestAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [UpdateRepoPullrequestRequest](../../Models/Requests/UpdateRepoPullrequestRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[UpdateRepoPullrequestResponse](../../Models/Requests/UpdateRepoPullrequestResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |