# Candidate
(*Candidate*)

### Available Operations

* [CreateAtsCandidate](#createatscandidate) - Create a candidate
* [GetAtsCandidate](#getatscandidate) - Retrieve a candidate
* [ListAtsCandidates](#listatscandidates) - List all candidates
* [PatchAtsCandidate](#patchatscandidate) - Update a candidate
* [RemoveAtsCandidate](#removeatscandidate) - Remove a candidate
* [UpdateAtsCandidate](#updateatscandidate) - Update a candidate

## CreateAtsCandidate

Create a candidate

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Candidate.CreateAtsCandidateAsync(
    security: new CreateAtsCandidateSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    atsCandidate: new AtsCandidate() {});

// handle response
```

### Parameters

| Parameter                                                                                                   | Type                                                                                                        | Required                                                                                                    | Description                                                                                                 |
| ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                  | [UnifiedTo.Models.Requests.CreateAtsCandidateSecurity](../../Models/Requests/CreateAtsCandidateSecurity.md) | :heavy_check_mark:                                                                                          | The security requirements to use for the request.                                                           |
| `ConnectionId`                                                                                              | *string*                                                                                                    | :heavy_check_mark:                                                                                          | ID of the connection                                                                                        |
| `AtsCandidate`                                                                                              | [AtsCandidate](../../Models/Components/AtsCandidate.md)                                                     | :heavy_minus_sign:                                                                                          | N/A                                                                                                         |


### Response

**[CreateAtsCandidateResponse](../../Models/Requests/CreateAtsCandidateResponse.md)**


## GetAtsCandidate

Retrieve a candidate

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Candidate.GetAtsCandidateAsync(
    security: new GetAtsCandidateSecurity() {
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
| `security`                                                                                            | [UnifiedTo.Models.Requests.GetAtsCandidateSecurity](../../Models/Requests/GetAtsCandidateSecurity.md) | :heavy_check_mark:                                                                                    | The security requirements to use for the request.                                                     |
| `ConnectionId`                                                                                        | *string*                                                                                              | :heavy_check_mark:                                                                                    | ID of the connection                                                                                  |
| `Id`                                                                                                  | *string*                                                                                              | :heavy_check_mark:                                                                                    | ID of the Candidate                                                                                   |
| `Fields`                                                                                              | List<*string*>                                                                                        | :heavy_minus_sign:                                                                                    | Comma-delimited fields to return                                                                      |


### Response

**[GetAtsCandidateResponse](../../Models/Requests/GetAtsCandidateResponse.md)**


## ListAtsCandidates

List all candidates

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListAtsCandidatesRequest req = new ListAtsCandidatesRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Candidate.ListAtsCandidatesAsync(
    security: new ListAtsCandidatesSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                 | [ListAtsCandidatesRequest](../../Models/Requests/ListAtsCandidatesRequest.md)                             | :heavy_check_mark:                                                                                        | The request object to use for the request.                                                                |
| `security`                                                                                                | [UnifiedTo.Models.Requests.ListAtsCandidatesSecurity](../../Models/Requests/ListAtsCandidatesSecurity.md) | :heavy_check_mark:                                                                                        | The security requirements to use for the request.                                                         |


### Response

**[ListAtsCandidatesResponse](../../Models/Requests/ListAtsCandidatesResponse.md)**


## PatchAtsCandidate

Update a candidate

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Candidate.PatchAtsCandidateAsync(
    security: new PatchAtsCandidateSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    atsCandidate: new AtsCandidate() {});

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                | [UnifiedTo.Models.Requests.PatchAtsCandidateSecurity](../../Models/Requests/PatchAtsCandidateSecurity.md) | :heavy_check_mark:                                                                                        | The security requirements to use for the request.                                                         |
| `ConnectionId`                                                                                            | *string*                                                                                                  | :heavy_check_mark:                                                                                        | ID of the connection                                                                                      |
| `Id`                                                                                                      | *string*                                                                                                  | :heavy_check_mark:                                                                                        | ID of the Candidate                                                                                       |
| `AtsCandidate`                                                                                            | [AtsCandidate](../../Models/Components/AtsCandidate.md)                                                   | :heavy_minus_sign:                                                                                        | N/A                                                                                                       |


### Response

**[PatchAtsCandidateResponse](../../Models/Requests/PatchAtsCandidateResponse.md)**


## RemoveAtsCandidate

Remove a candidate

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Candidate.RemoveAtsCandidateAsync(
    security: new RemoveAtsCandidateSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                                   | Type                                                                                                        | Required                                                                                                    | Description                                                                                                 |
| ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                  | [UnifiedTo.Models.Requests.RemoveAtsCandidateSecurity](../../Models/Requests/RemoveAtsCandidateSecurity.md) | :heavy_check_mark:                                                                                          | The security requirements to use for the request.                                                           |
| `ConnectionId`                                                                                              | *string*                                                                                                    | :heavy_check_mark:                                                                                          | ID of the connection                                                                                        |
| `Id`                                                                                                        | *string*                                                                                                    | :heavy_check_mark:                                                                                          | ID of the Candidate                                                                                         |


### Response

**[RemoveAtsCandidateResponse](../../Models/Requests/RemoveAtsCandidateResponse.md)**


## UpdateAtsCandidate

Update a candidate

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Candidate.UpdateAtsCandidateAsync(
    security: new UpdateAtsCandidateSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    atsCandidate: new AtsCandidate() {});

// handle response
```

### Parameters

| Parameter                                                                                                   | Type                                                                                                        | Required                                                                                                    | Description                                                                                                 |
| ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                  | [UnifiedTo.Models.Requests.UpdateAtsCandidateSecurity](../../Models/Requests/UpdateAtsCandidateSecurity.md) | :heavy_check_mark:                                                                                          | The security requirements to use for the request.                                                           |
| `ConnectionId`                                                                                              | *string*                                                                                                    | :heavy_check_mark:                                                                                          | ID of the connection                                                                                        |
| `Id`                                                                                                        | *string*                                                                                                    | :heavy_check_mark:                                                                                          | ID of the Candidate                                                                                         |
| `AtsCandidate`                                                                                              | [AtsCandidate](../../Models/Components/AtsCandidate.md)                                                     | :heavy_minus_sign:                                                                                          | N/A                                                                                                         |


### Response

**[UpdateAtsCandidateResponse](../../Models/Requests/UpdateAtsCandidateResponse.md)**

