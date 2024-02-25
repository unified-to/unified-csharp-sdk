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
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Interview.CreateAtsInterviewAsync(
    security: new CreateAtsInterviewSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    atsInterview: new AtsInterview() {});

// handle response
```

### Parameters

| Parameter                                                                                                   | Type                                                                                                        | Required                                                                                                    | Description                                                                                                 |
| ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                  | [UnifiedTo.Models.Requests.CreateAtsInterviewSecurity](../../Models/Requests/CreateAtsInterviewSecurity.md) | :heavy_check_mark:                                                                                          | The security requirements to use for the request.                                                           |
| `ConnectionId`                                                                                              | *string*                                                                                                    | :heavy_check_mark:                                                                                          | ID of the connection                                                                                        |
| `AtsInterview`                                                                                              | [AtsInterview](../../Models/Components/AtsInterview.md)                                                     | :heavy_minus_sign:                                                                                          | N/A                                                                                                         |


### Response

**[CreateAtsInterviewResponse](../../Models/Requests/CreateAtsInterviewResponse.md)**


## GetAtsInterview

Retrieve a interview

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Interview.GetAtsInterviewAsync(
    security: new GetAtsInterviewSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    fields: new List<string>() {
    "<value>",
});

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `security`                                                                                            | [UnifiedTo.Models.Requests.GetAtsInterviewSecurity](../../Models/Requests/GetAtsInterviewSecurity.md) | :heavy_check_mark:                                                                                    | The security requirements to use for the request.                                                     |
| `ConnectionId`                                                                                        | *string*                                                                                              | :heavy_check_mark:                                                                                    | ID of the connection                                                                                  |
| `Id`                                                                                                  | *string*                                                                                              | :heavy_check_mark:                                                                                    | ID of the Interview                                                                                   |
| `Fields`                                                                                              | List<*string*>                                                                                        | :heavy_minus_sign:                                                                                    | Comma-delimited fields to return                                                                      |


### Response

**[GetAtsInterviewResponse](../../Models/Requests/GetAtsInterviewResponse.md)**


## ListAtsInterviews

List all interviews

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListAtsInterviewsRequest req = new ListAtsInterviewsRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Interview.ListAtsInterviewsAsync(
    security: new ListAtsInterviewsSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                 | [ListAtsInterviewsRequest](../../Models/Requests/ListAtsInterviewsRequest.md)                             | :heavy_check_mark:                                                                                        | The request object to use for the request.                                                                |
| `security`                                                                                                | [UnifiedTo.Models.Requests.ListAtsInterviewsSecurity](../../Models/Requests/ListAtsInterviewsSecurity.md) | :heavy_check_mark:                                                                                        | The security requirements to use for the request.                                                         |


### Response

**[ListAtsInterviewsResponse](../../Models/Requests/ListAtsInterviewsResponse.md)**


## PatchAtsInterview

Update a interview

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Interview.PatchAtsInterviewAsync(
    security: new PatchAtsInterviewSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    atsInterview: new AtsInterview() {});

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                | [UnifiedTo.Models.Requests.PatchAtsInterviewSecurity](../../Models/Requests/PatchAtsInterviewSecurity.md) | :heavy_check_mark:                                                                                        | The security requirements to use for the request.                                                         |
| `ConnectionId`                                                                                            | *string*                                                                                                  | :heavy_check_mark:                                                                                        | ID of the connection                                                                                      |
| `Id`                                                                                                      | *string*                                                                                                  | :heavy_check_mark:                                                                                        | ID of the Interview                                                                                       |
| `AtsInterview`                                                                                            | [AtsInterview](../../Models/Components/AtsInterview.md)                                                   | :heavy_minus_sign:                                                                                        | N/A                                                                                                       |


### Response

**[PatchAtsInterviewResponse](../../Models/Requests/PatchAtsInterviewResponse.md)**


## RemoveAtsInterview

Remove a interview

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Interview.RemoveAtsInterviewAsync(
    security: new RemoveAtsInterviewSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                                   | Type                                                                                                        | Required                                                                                                    | Description                                                                                                 |
| ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                  | [UnifiedTo.Models.Requests.RemoveAtsInterviewSecurity](../../Models/Requests/RemoveAtsInterviewSecurity.md) | :heavy_check_mark:                                                                                          | The security requirements to use for the request.                                                           |
| `ConnectionId`                                                                                              | *string*                                                                                                    | :heavy_check_mark:                                                                                          | ID of the connection                                                                                        |
| `Id`                                                                                                        | *string*                                                                                                    | :heavy_check_mark:                                                                                          | ID of the Interview                                                                                         |


### Response

**[RemoveAtsInterviewResponse](../../Models/Requests/RemoveAtsInterviewResponse.md)**


## UpdateAtsInterview

Update a interview

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Interview.UpdateAtsInterviewAsync(
    security: new UpdateAtsInterviewSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    atsInterview: new AtsInterview() {});

// handle response
```

### Parameters

| Parameter                                                                                                   | Type                                                                                                        | Required                                                                                                    | Description                                                                                                 |
| ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                  | [UnifiedTo.Models.Requests.UpdateAtsInterviewSecurity](../../Models/Requests/UpdateAtsInterviewSecurity.md) | :heavy_check_mark:                                                                                          | The security requirements to use for the request.                                                           |
| `ConnectionId`                                                                                              | *string*                                                                                                    | :heavy_check_mark:                                                                                          | ID of the connection                                                                                        |
| `Id`                                                                                                        | *string*                                                                                                    | :heavy_check_mark:                                                                                          | ID of the Interview                                                                                         |
| `AtsInterview`                                                                                              | [AtsInterview](../../Models/Components/AtsInterview.md)                                                     | :heavy_minus_sign:                                                                                          | N/A                                                                                                         |


### Response

**[UpdateAtsInterviewResponse](../../Models/Requests/UpdateAtsInterviewResponse.md)**

