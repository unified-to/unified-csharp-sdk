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
        EndAt = System.DateTime.Parse("2025-10-14T17:00:06.672Z").ToUniversalTime(),
        ExternalEventXref = "651bb3c9-9d97-4dfb-9ee9-8fa8ba3f12a3",
        Id = "5316e013-4cd0-4759-8ff8-1fd06244af0d",
        Location = "26596 Halle Trafficway",
        StartAt = System.DateTime.Parse("2025-06-07T16:26:14.818Z").ToUniversalTime(),
        Status = AtsInterviewStatus.Scheduled,
        UpdatedAt = System.DateTime.Parse("2026-02-27T10:26:58.393Z").ToUniversalTime(),
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
        EndAt = System.DateTime.Parse("2025-10-14T17:00:06.677Z").ToUniversalTime(),
        ExternalEventXref = "9776cf6b-4fd5-468a-8e94-dd4dc3bf15fc",
        Id = "ebd2b690-a375-42b3-82be-f774eb289869",
        Location = "26596 Halle Trafficway",
        StartAt = System.DateTime.Parse("2025-06-07T16:26:14.823Z").ToUniversalTime(),
        Status = AtsInterviewStatus.Scheduled,
        UpdatedAt = System.DateTime.Parse("2026-02-27T10:26:58.399Z").ToUniversalTime(),
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
        EndAt = System.DateTime.Parse("2025-10-14T17:00:06.677Z").ToUniversalTime(),
        ExternalEventXref = "9776cf6b-4fd5-468a-8e94-dd4dc3bf15fc",
        Id = "ebd2b690-a375-42b3-82be-f774eb289869",
        Location = "26596 Halle Trafficway",
        StartAt = System.DateTime.Parse("2025-06-07T16:26:14.823Z").ToUniversalTime(),
        Status = AtsInterviewStatus.Scheduled,
        UpdatedAt = System.DateTime.Parse("2026-02-27T10:26:58.399Z").ToUniversalTime(),
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