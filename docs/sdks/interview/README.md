# Interview
(*Interview*)

### Available Operations

* [CreateAtsInterview](#createatsinterview) - Create a interview
* [GetAtsInterview](#getatsinterview) - Retrieve a interview
* [ListAtsInterviews](#listatsinterviews) - List all interviews
* [PatchAtsInterview](#patchatsinterview) - Update a interview
* [RemoveAtsInterview](#removeatsinterview) - Remove a interview
* [UpdateAtsInterview](#updateatsinterview) - Update a interview

## CreateAtsInterview

Create a interview

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Interview.CreateAtsInterviewAsync(
    connectionId: "<value>",
    atsInterview: new AtsInterview() {});

// handle response
```

### Parameters

| Parameter                                               | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `ConnectionId`                                          | *string*                                                | :heavy_check_mark:                                      | ID of the connection                                    |
| `AtsInterview`                                          | [AtsInterview](../../Models/Components/AtsInterview.md) | :heavy_minus_sign:                                      | N/A                                                     |


### Response

**[CreateAtsInterviewResponse](../../Models/Requests/CreateAtsInterviewResponse.md)**


## GetAtsInterview

Retrieve a interview

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Interview.GetAtsInterviewAsync(
    connectionId: "<value>",
    id: "<value>",
    fields: new List<string>() {
    "<value>",
});

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Interview              |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetAtsInterviewResponse](../../Models/Requests/GetAtsInterviewResponse.md)**


## ListAtsInterviews

List all interviews

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListAtsInterviewsRequest req = new ListAtsInterviewsRequest() {
    ConnectionId = "<value>",
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


## PatchAtsInterview

Update a interview

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Interview.PatchAtsInterviewAsync(
    connectionId: "<value>",
    id: "<value>",
    atsInterview: new AtsInterview() {});

// handle response
```

### Parameters

| Parameter                                               | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `ConnectionId`                                          | *string*                                                | :heavy_check_mark:                                      | ID of the connection                                    |
| `Id`                                                    | *string*                                                | :heavy_check_mark:                                      | ID of the Interview                                     |
| `AtsInterview`                                          | [AtsInterview](../../Models/Components/AtsInterview.md) | :heavy_minus_sign:                                      | N/A                                                     |


### Response

**[PatchAtsInterviewResponse](../../Models/Requests/PatchAtsInterviewResponse.md)**


## RemoveAtsInterview

Remove a interview

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Interview.RemoveAtsInterviewAsync(
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Interview  |


### Response

**[RemoveAtsInterviewResponse](../../Models/Requests/RemoveAtsInterviewResponse.md)**


## UpdateAtsInterview

Update a interview

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Interview.UpdateAtsInterviewAsync(
    connectionId: "<value>",
    id: "<value>",
    atsInterview: new AtsInterview() {});

// handle response
```

### Parameters

| Parameter                                               | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `ConnectionId`                                          | *string*                                                | :heavy_check_mark:                                      | ID of the connection                                    |
| `Id`                                                    | *string*                                                | :heavy_check_mark:                                      | ID of the Interview                                     |
| `AtsInterview`                                          | [AtsInterview](../../Models/Components/AtsInterview.md) | :heavy_minus_sign:                                      | N/A                                                     |


### Response

**[UpdateAtsInterviewResponse](../../Models/Requests/UpdateAtsInterviewResponse.md)**

