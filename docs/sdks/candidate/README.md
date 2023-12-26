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
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Candidate.CreateAtsCandidateAsync(ConnectionId: "string", AtsCandidate: new AtsCandidate() {
    Address = new PropertyAtsCandidateAddress() {},
    Emails = new List<AtsEmail>() {
        new AtsEmail() {
            Email = "Robin_Feeney@hotmail.com",
        },
    },
    LinkUrls = new List<string>() {
        "string",
    },
    Raw = new PropertyAtsCandidateRaw() {},
    Tags = new List<string>() {
        "string",
    },
    Telephones = new List<AtsTelephone>() {
        new AtsTelephone() {
            Telephone = "string",
        },
    },
});

// handle response
```

### Parameters

| Parameter                                               | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `ConnectionId`                                          | *string*                                                | :heavy_check_mark:                                      | ID of the connection                                    |
| `AtsCandidate`                                          | [AtsCandidate](../../Models/Components/AtsCandidate.md) | :heavy_minus_sign:                                      | N/A                                                     |


### Response

**[CreateAtsCandidateResponse](../../Models/Requests/CreateAtsCandidateResponse.md)**


## GetAtsCandidate

Retrieve a candidate

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Candidate.GetAtsCandidateAsync(ConnectionId: "string", Id: "string", Fields: new List<string>() {
    "string",
});

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Candidate              |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetAtsCandidateResponse](../../Models/Requests/GetAtsCandidateResponse.md)**


## ListAtsCandidates

List all candidates

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListAtsCandidatesRequest req = new ListAtsCandidatesRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
};

var res = await sdk.Candidate.ListAtsCandidatesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListAtsCandidatesRequest](../../Models/Requests/ListAtsCandidatesRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |


### Response

**[ListAtsCandidatesResponse](../../Models/Requests/ListAtsCandidatesResponse.md)**


## PatchAtsCandidate

Update a candidate

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Candidate.PatchAtsCandidateAsync(ConnectionId: "string", Id: "string", AtsCandidate: new AtsCandidate() {
    Address = new PropertyAtsCandidateAddress() {},
    Emails = new List<AtsEmail>() {
        new AtsEmail() {
            Email = "Tracy.Collins13@gmail.com",
        },
    },
    LinkUrls = new List<string>() {
        "string",
    },
    Raw = new PropertyAtsCandidateRaw() {},
    Tags = new List<string>() {
        "string",
    },
    Telephones = new List<AtsTelephone>() {
        new AtsTelephone() {
            Telephone = "string",
        },
    },
});

// handle response
```

### Parameters

| Parameter                                               | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `ConnectionId`                                          | *string*                                                | :heavy_check_mark:                                      | ID of the connection                                    |
| `Id`                                                    | *string*                                                | :heavy_check_mark:                                      | ID of the Candidate                                     |
| `AtsCandidate`                                          | [AtsCandidate](../../Models/Components/AtsCandidate.md) | :heavy_minus_sign:                                      | N/A                                                     |


### Response

**[PatchAtsCandidateResponse](../../Models/Requests/PatchAtsCandidateResponse.md)**


## RemoveAtsCandidate

Remove a candidate

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Candidate.RemoveAtsCandidateAsync(ConnectionId: "string", Id: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Candidate  |


### Response

**[RemoveAtsCandidateResponse](../../Models/Requests/RemoveAtsCandidateResponse.md)**


## UpdateAtsCandidate

Update a candidate

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Candidate.UpdateAtsCandidateAsync(ConnectionId: "string", Id: "string", AtsCandidate: new AtsCandidate() {
    Address = new PropertyAtsCandidateAddress() {},
    Emails = new List<AtsEmail>() {
        new AtsEmail() {
            Email = "Gaetano86@hotmail.com",
        },
    },
    LinkUrls = new List<string>() {
        "string",
    },
    Raw = new PropertyAtsCandidateRaw() {},
    Tags = new List<string>() {
        "string",
    },
    Telephones = new List<AtsTelephone>() {
        new AtsTelephone() {
            Telephone = "string",
        },
    },
});

// handle response
```

### Parameters

| Parameter                                               | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `ConnectionId`                                          | *string*                                                | :heavy_check_mark:                                      | ID of the connection                                    |
| `Id`                                                    | *string*                                                | :heavy_check_mark:                                      | ID of the Candidate                                     |
| `AtsCandidate`                                          | [AtsCandidate](../../Models/Components/AtsCandidate.md) | :heavy_minus_sign:                                      | N/A                                                     |


### Response

**[UpdateAtsCandidateResponse](../../Models/Requests/UpdateAtsCandidateResponse.md)**

