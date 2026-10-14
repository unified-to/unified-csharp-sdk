# Interview

## Overview

### Available Operations

* [CreateAtsInterview](#createatsinterview) - Create an interview
* [GetAtsInterview](#getatsinterview) - Retrieve an interview
* [ListAtsInterviews](#listatsinterviews) - List all interviews
* [PatchAtsInterview](#patchatsinterview) - Update an interview
* [RemoveAtsInterview](#removeatsinterview) - Remove an interview
* [UpdateAtsInterview](#updateatsinterview) - Update an interview

## CreateAtsInterview

Create an interview

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAtsInterview" method="post" path="/ats/{connection_id}/interview" example="ats_interview" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Interview.CreateAtsInterviewAsync(
    atsInterview: new AtsInterview() {
        CreatedAt = System.DateTime.Parse("2021-11-28T03:14:47.774Z").ToUniversalTime(),
        EndAt = System.DateTime.Parse("2025-10-13T22:00:37.244Z").ToUniversalTime(),
        ExternalEventXref = "a40eb7ac-cd10-4b46-99f5-8e728e38f0f4",
        Id = "5a4b7e8c-337b-4202-b7f8-627bab19d525",
        Location = "26596 Halle Trafficway",
        StartAt = System.DateTime.Parse("2025-06-06T23:10:32.576Z").ToUniversalTime(),
        Status = AtsInterviewStatus.Scheduled,
        UpdatedAt = System.DateTime.Parse("2026-02-26T13:38:18.244Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AtsInterview`                                                                                                                                   | [AtsInterview](../../Models/Components/AtsInterview.md)                                                                                          | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAtsInterviewQueryParamFields](../../Models/Requests/CreateAtsInterviewQueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAtsInterviewResponse](../../Models/Requests/CreateAtsInterviewResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAtsInterview

Retrieve an interview

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAtsInterview" method="get" path="/ats/{connection_id}/interview/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Interview.GetAtsInterviewAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Interview                                                                                                                              |
| `Fields`                                                                                                                                         | List<[GetAtsInterviewQueryParamFields](../../Models/Requests/GetAtsInterviewQueryParamFields.md)>                                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAtsInterviewResponse](../../Models/Requests/GetAtsInterviewResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAtsInterviews

List all interviews

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAtsInterviews" method="get" path="/ats/{connection_id}/interview" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAtsInterviewsRequest req = new ListAtsInterviewsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Interview.ListAtsInterviewsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListAtsInterviewsRequest](../../Models/Requests/ListAtsInterviewsRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[ListAtsInterviewsResponse](../../Models/Requests/ListAtsInterviewsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAtsInterview

Update an interview

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAtsInterview" method="patch" path="/ats/{connection_id}/interview/{id}" example="ats_interview" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAtsInterviewRequest req = new PatchAtsInterviewRequest() {
    AtsInterview = new AtsInterview() {
        CreatedAt = System.DateTime.Parse("2021-11-28T03:14:47.774Z").ToUniversalTime(),
        EndAt = System.DateTime.Parse("2025-10-13T22:00:37.254Z").ToUniversalTime(),
        ExternalEventXref = "3379dc34-abf0-4651-b335-558ac3e14b6a",
        Id = "96badb51-4abd-4e88-b4b4-bb32574f1b22",
        Location = "26596 Halle Trafficway",
        StartAt = System.DateTime.Parse("2025-06-06T23:10:32.585Z").ToUniversalTime(),
        Status = AtsInterviewStatus.Scheduled,
        UpdatedAt = System.DateTime.Parse("2026-02-26T13:38:18.255Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Interview.PatchAtsInterviewAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [PatchAtsInterviewRequest](../../Models/Requests/PatchAtsInterviewRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[PatchAtsInterviewResponse](../../Models/Requests/PatchAtsInterviewResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAtsInterview

Remove an interview

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeAtsInterview" method="delete" path="/ats/{connection_id}/interview/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Interview.RemoveAtsInterviewAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Interview  |

### Response

**[RemoveAtsInterviewResponse](../../Models/Requests/RemoveAtsInterviewResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAtsInterview

Update an interview

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAtsInterview" method="put" path="/ats/{connection_id}/interview/{id}" example="ats_interview" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAtsInterviewRequest req = new UpdateAtsInterviewRequest() {
    AtsInterview = new AtsInterview() {
        CreatedAt = System.DateTime.Parse("2021-11-28T03:14:47.774Z").ToUniversalTime(),
        EndAt = System.DateTime.Parse("2025-10-13T22:00:37.254Z").ToUniversalTime(),
        ExternalEventXref = "3379dc34-abf0-4651-b335-558ac3e14b6a",
        Id = "96badb51-4abd-4e88-b4b4-bb32574f1b22",
        Location = "26596 Halle Trafficway",
        StartAt = System.DateTime.Parse("2025-06-06T23:10:32.585Z").ToUniversalTime(),
        Status = AtsInterviewStatus.Scheduled,
        UpdatedAt = System.DateTime.Parse("2026-02-26T13:38:18.255Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Interview.UpdateAtsInterviewAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [UpdateAtsInterviewRequest](../../Models/Requests/UpdateAtsInterviewRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[UpdateAtsInterviewResponse](../../Models/Requests/UpdateAtsInterviewResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |