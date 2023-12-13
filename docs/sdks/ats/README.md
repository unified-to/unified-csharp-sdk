# Ats
(*Ats*)

### Available Operations

* [CreateAtsApplication](#createatsapplication) - Create an application
* [CreateAtsCandidate](#createatscandidate) - Create a candidate
* [CreateAtsDocument](#createatsdocument) - Create a document
* [CreateAtsInterview](#createatsinterview) - Create a interview
* [CreateAtsJob](#createatsjob) - Create a job
* [CreateAtsScorecard](#createatsscorecard) - Create a scorecard
* [GetAtsApplication](#getatsapplication) - Retrieve an application
* [GetAtsCandidate](#getatscandidate) - Retrieve a candidate
* [GetAtsDocument](#getatsdocument) - Retrieve a document
* [GetAtsInterview](#getatsinterview) - Retrieve a interview
* [GetAtsJob](#getatsjob) - Retrieve a job
* [GetAtsScorecard](#getatsscorecard) - Retrieve a scorecard
* [ListAtsApplications](#listatsapplications) - List all applications
* [ListAtsApplicationstatuses](#listatsapplicationstatuses) - List all application statuses
* [ListAtsCandidates](#listatscandidates) - List all candidates
* [ListAtsDocuments](#listatsdocuments) - List all documents
* [ListAtsInterviews](#listatsinterviews) - List all interviews
* [ListAtsJobs](#listatsjobs) - List all jobs
* [ListAtsScorecards](#listatsscorecards) - List all scorecards
* [PatchAtsApplication](#patchatsapplication) - Update an application
* [PatchAtsCandidate](#patchatscandidate) - Update a candidate
* [PatchAtsDocument](#patchatsdocument) - Update a document
* [PatchAtsInterview](#patchatsinterview) - Update a interview
* [PatchAtsJob](#patchatsjob) - Update a job
* [PatchAtsScorecard](#patchatsscorecard) - Update a scorecard
* [RemoveAtsApplication](#removeatsapplication) - Remove an application
* [RemoveAtsCandidate](#removeatscandidate) - Remove a candidate
* [RemoveAtsDocument](#removeatsdocument) - Remove a document
* [RemoveAtsInterview](#removeatsinterview) - Remove a interview
* [RemoveAtsJob](#removeatsjob) - Remove a job
* [RemoveAtsScorecard](#removeatsscorecard) - Remove a scorecard
* [UpdateAtsApplication](#updateatsapplication) - Update an application
* [UpdateAtsCandidate](#updateatscandidate) - Update a candidate
* [UpdateAtsDocument](#updateatsdocument) - Update a document
* [UpdateAtsInterview](#updateatsinterview) - Update a interview
* [UpdateAtsJob](#updateatsjob) - Update a job
* [UpdateAtsScorecard](#updateatsscorecard) - Update a scorecard

## CreateAtsApplication

Create an application

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.CreateAtsApplicationAsync(ConnectionId: "string", AtsApplication: new AtsApplication() {
    Raw = new PropertyAtsApplicationRaw() {},
});

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `ConnectionId`                                              | *string*                                                    | :heavy_check_mark:                                          | ID of the connection                                        |
| `AtsApplication`                                            | [AtsApplication](../../Models/Components/AtsApplication.md) | :heavy_minus_sign:                                          | N/A                                                         |


### Response

**[CreateAtsApplicationResponse](../../Models/Requests/CreateAtsApplicationResponse.md)**


## CreateAtsCandidate

Create a candidate

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.CreateAtsCandidateAsync(ConnectionId: "string", AtsCandidate: new AtsCandidate() {
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


## CreateAtsDocument

Create a document

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.CreateAtsDocumentAsync(ConnectionId: "string", AtsDocument: new AtsDocument() {
    Raw = new PropertyAtsDocumentRaw() {},
});

// handle response
```

### Parameters

| Parameter                                             | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `ConnectionId`                                        | *string*                                              | :heavy_check_mark:                                    | ID of the connection                                  |
| `AtsDocument`                                         | [AtsDocument](../../Models/Components/AtsDocument.md) | :heavy_minus_sign:                                    | N/A                                                   |


### Response

**[CreateAtsDocumentResponse](../../Models/Requests/CreateAtsDocumentResponse.md)**


## CreateAtsInterview

Create a interview

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.CreateAtsInterviewAsync(ConnectionId: "string", AtsInterview: new AtsInterview() {
    Raw = new PropertyAtsInterviewRaw() {},
    UserIds = new List<string>() {
        "string",
    },
});

// handle response
```

### Parameters

| Parameter                                               | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `ConnectionId`                                          | *string*                                                | :heavy_check_mark:                                      | ID of the connection                                    |
| `AtsInterview`                                          | [AtsInterview](../../Models/Components/AtsInterview.md) | :heavy_minus_sign:                                      | N/A                                                     |


### Response

**[CreateAtsInterviewResponse](../../Models/Requests/CreateAtsInterviewResponse.md)**


## CreateAtsJob

Create a job

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.CreateAtsJobAsync(ConnectionId: "string", AtsJob: new AtsJob() {
    Addresses = new List<AtsAddress>() {
        new AtsAddress() {},
    },
    Compensation = new List<AtsCompensation>() {
        new AtsCompensation() {
            Type = AtsCompensationType.Salary,
        },
    },
    Departments = new List<string>() {
        "string",
    },
    HiringManagerIds = new List<string>() {
        "string",
    },
    PublicJobUrls = new List<string>() {
        "string",
    },
    Raw = new PropertyAtsJobRaw() {},
    RecruiterIds = new List<string>() {
        "string",
    },
});

// handle response
```

### Parameters

| Parameter                                   | Type                                        | Required                                    | Description                                 |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| `ConnectionId`                              | *string*                                    | :heavy_check_mark:                          | ID of the connection                        |
| `AtsJob`                                    | [AtsJob](../../Models/Components/AtsJob.md) | :heavy_minus_sign:                          | N/A                                         |


### Response

**[CreateAtsJobResponse](../../Models/Requests/CreateAtsJobResponse.md)**


## CreateAtsScorecard

Create a scorecard

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.CreateAtsScorecardAsync(ConnectionId: "string", AtsScorecard: new AtsScorecard() {
    Raw = new PropertyAtsScorecardRaw() {},
});

// handle response
```

### Parameters

| Parameter                                               | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `ConnectionId`                                          | *string*                                                | :heavy_check_mark:                                      | ID of the connection                                    |
| `AtsScorecard`                                          | [AtsScorecard](../../Models/Components/AtsScorecard.md) | :heavy_minus_sign:                                      | N/A                                                     |


### Response

**[CreateAtsScorecardResponse](../../Models/Requests/CreateAtsScorecardResponse.md)**


## GetAtsApplication

Retrieve an application

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.GetAtsApplicationAsync(ConnectionId: "string", Id: "string", Fields: new List<string>() {
    "string",
});

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Application            |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetAtsApplicationResponse](../../Models/Requests/GetAtsApplicationResponse.md)**


## GetAtsCandidate

Retrieve a candidate

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.GetAtsCandidateAsync(ConnectionId: "string", Id: "string", Fields: new List<string>() {
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


## GetAtsDocument

Retrieve a document

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.GetAtsDocumentAsync(ConnectionId: "string", Id: "string", Fields: new List<string>() {
    "string",
});

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Document               |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetAtsDocumentResponse](../../Models/Requests/GetAtsDocumentResponse.md)**


## GetAtsInterview

Retrieve a interview

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.GetAtsInterviewAsync(ConnectionId: "string", Id: "string", Fields: new List<string>() {
    "string",
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


## GetAtsJob

Retrieve a job

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.GetAtsJobAsync(ConnectionId: "string", Id: "string", Fields: new List<string>() {
    "string",
});

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Job                    |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetAtsJobResponse](../../Models/Requests/GetAtsJobResponse.md)**


## GetAtsScorecard

Retrieve a scorecard

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.GetAtsScorecardAsync(ConnectionId: "string", Id: "string", Fields: new List<string>() {
    "string",
});

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Scorecard              |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetAtsScorecardResponse](../../Models/Requests/GetAtsScorecardResponse.md)**


## ListAtsApplications

List all applications

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListAtsApplicationsRequest req = new ListAtsApplicationsRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
};

var res = await sdk.Ats.ListAtsApplicationsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ListAtsApplicationsRequest](../../Models/Requests/ListAtsApplicationsRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |


### Response

**[ListAtsApplicationsResponse](../../Models/Requests/ListAtsApplicationsResponse.md)**


## ListAtsApplicationstatuses

List all application statuses

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListAtsApplicationstatusesRequest req = new ListAtsApplicationstatusesRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
};

var res = await sdk.Ats.ListAtsApplicationstatusesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [ListAtsApplicationstatusesRequest](../../Models/Requests/ListAtsApplicationstatusesRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |


### Response

**[ListAtsApplicationstatusesResponse](../../Models/Requests/ListAtsApplicationstatusesResponse.md)**


## ListAtsCandidates

List all candidates

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
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

var res = await sdk.Ats.ListAtsCandidatesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListAtsCandidatesRequest](../../Models/Requests/ListAtsCandidatesRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |


### Response

**[ListAtsCandidatesResponse](../../Models/Requests/ListAtsCandidatesResponse.md)**


## ListAtsDocuments

List all documents

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListAtsDocumentsRequest req = new ListAtsDocumentsRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
};

var res = await sdk.Ats.ListAtsDocumentsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListAtsDocumentsRequest](../../Models/Requests/ListAtsDocumentsRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |


### Response

**[ListAtsDocumentsResponse](../../Models/Requests/ListAtsDocumentsResponse.md)**


## ListAtsInterviews

List all interviews

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListAtsInterviewsRequest req = new ListAtsInterviewsRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
};

var res = await sdk.Ats.ListAtsInterviewsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListAtsInterviewsRequest](../../Models/Requests/ListAtsInterviewsRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |


### Response

**[ListAtsInterviewsResponse](../../Models/Requests/ListAtsInterviewsResponse.md)**


## ListAtsJobs

List all jobs

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListAtsJobsRequest req = new ListAtsJobsRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
};

var res = await sdk.Ats.ListAtsJobsAsync(req);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [ListAtsJobsRequest](../../Models/Requests/ListAtsJobsRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |


### Response

**[ListAtsJobsResponse](../../Models/Requests/ListAtsJobsResponse.md)**


## ListAtsScorecards

List all scorecards

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListAtsScorecardsRequest req = new ListAtsScorecardsRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
};

var res = await sdk.Ats.ListAtsScorecardsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListAtsScorecardsRequest](../../Models/Requests/ListAtsScorecardsRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |


### Response

**[ListAtsScorecardsResponse](../../Models/Requests/ListAtsScorecardsResponse.md)**


## PatchAtsApplication

Update an application

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.PatchAtsApplicationAsync(ConnectionId: "string", Id: "string", AtsApplication: new AtsApplication() {
    Raw = new PropertyAtsApplicationRaw() {},
});

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `ConnectionId`                                              | *string*                                                    | :heavy_check_mark:                                          | ID of the connection                                        |
| `Id`                                                        | *string*                                                    | :heavy_check_mark:                                          | ID of the Application                                       |
| `AtsApplication`                                            | [AtsApplication](../../Models/Components/AtsApplication.md) | :heavy_minus_sign:                                          | N/A                                                         |


### Response

**[PatchAtsApplicationResponse](../../Models/Requests/PatchAtsApplicationResponse.md)**


## PatchAtsCandidate

Update a candidate

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.PatchAtsCandidateAsync(ConnectionId: "string", Id: "string", AtsCandidate: new AtsCandidate() {
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


## PatchAtsDocument

Update a document

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.PatchAtsDocumentAsync(ConnectionId: "string", Id: "string", AtsDocument: new AtsDocument() {
    Raw = new PropertyAtsDocumentRaw() {},
});

// handle response
```

### Parameters

| Parameter                                             | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `ConnectionId`                                        | *string*                                              | :heavy_check_mark:                                    | ID of the connection                                  |
| `Id`                                                  | *string*                                              | :heavy_check_mark:                                    | ID of the Document                                    |
| `AtsDocument`                                         | [AtsDocument](../../Models/Components/AtsDocument.md) | :heavy_minus_sign:                                    | N/A                                                   |


### Response

**[PatchAtsDocumentResponse](../../Models/Requests/PatchAtsDocumentResponse.md)**


## PatchAtsInterview

Update a interview

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.PatchAtsInterviewAsync(ConnectionId: "string", Id: "string", AtsInterview: new AtsInterview() {
    Raw = new PropertyAtsInterviewRaw() {},
    UserIds = new List<string>() {
        "string",
    },
});

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


## PatchAtsJob

Update a job

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.PatchAtsJobAsync(ConnectionId: "string", Id: "string", AtsJob: new AtsJob() {
    Addresses = new List<AtsAddress>() {
        new AtsAddress() {},
    },
    Compensation = new List<AtsCompensation>() {
        new AtsCompensation() {
            Type = AtsCompensationType.Bonus,
        },
    },
    Departments = new List<string>() {
        "string",
    },
    HiringManagerIds = new List<string>() {
        "string",
    },
    PublicJobUrls = new List<string>() {
        "string",
    },
    Raw = new PropertyAtsJobRaw() {},
    RecruiterIds = new List<string>() {
        "string",
    },
});

// handle response
```

### Parameters

| Parameter                                   | Type                                        | Required                                    | Description                                 |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| `ConnectionId`                              | *string*                                    | :heavy_check_mark:                          | ID of the connection                        |
| `Id`                                        | *string*                                    | :heavy_check_mark:                          | ID of the Job                               |
| `AtsJob`                                    | [AtsJob](../../Models/Components/AtsJob.md) | :heavy_minus_sign:                          | N/A                                         |


### Response

**[PatchAtsJobResponse](../../Models/Requests/PatchAtsJobResponse.md)**


## PatchAtsScorecard

Update a scorecard

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.PatchAtsScorecardAsync(ConnectionId: "string", Id: "string", AtsScorecard: new AtsScorecard() {
    Raw = new PropertyAtsScorecardRaw() {},
});

// handle response
```

### Parameters

| Parameter                                               | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `ConnectionId`                                          | *string*                                                | :heavy_check_mark:                                      | ID of the connection                                    |
| `Id`                                                    | *string*                                                | :heavy_check_mark:                                      | ID of the Scorecard                                     |
| `AtsScorecard`                                          | [AtsScorecard](../../Models/Components/AtsScorecard.md) | :heavy_minus_sign:                                      | N/A                                                     |


### Response

**[PatchAtsScorecardResponse](../../Models/Requests/PatchAtsScorecardResponse.md)**


## RemoveAtsApplication

Remove an application

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.RemoveAtsApplicationAsync(ConnectionId: "string", Id: "string");

// handle response
```

### Parameters

| Parameter             | Type                  | Required              | Description           |
| --------------------- | --------------------- | --------------------- | --------------------- |
| `ConnectionId`        | *string*              | :heavy_check_mark:    | ID of the connection  |
| `Id`                  | *string*              | :heavy_check_mark:    | ID of the Application |


### Response

**[RemoveAtsApplicationResponse](../../Models/Requests/RemoveAtsApplicationResponse.md)**


## RemoveAtsCandidate

Remove a candidate

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.RemoveAtsCandidateAsync(ConnectionId: "string", Id: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Candidate  |


### Response

**[RemoveAtsCandidateResponse](../../Models/Requests/RemoveAtsCandidateResponse.md)**


## RemoveAtsDocument

Remove a document

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.RemoveAtsDocumentAsync(ConnectionId: "string", Id: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Document   |


### Response

**[RemoveAtsDocumentResponse](../../Models/Requests/RemoveAtsDocumentResponse.md)**


## RemoveAtsInterview

Remove a interview

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.RemoveAtsInterviewAsync(ConnectionId: "string", Id: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Interview  |


### Response

**[RemoveAtsInterviewResponse](../../Models/Requests/RemoveAtsInterviewResponse.md)**


## RemoveAtsJob

Remove a job

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.RemoveAtsJobAsync(ConnectionId: "string", Id: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Job        |


### Response

**[RemoveAtsJobResponse](../../Models/Requests/RemoveAtsJobResponse.md)**


## RemoveAtsScorecard

Remove a scorecard

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.RemoveAtsScorecardAsync(ConnectionId: "string", Id: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Scorecard  |


### Response

**[RemoveAtsScorecardResponse](../../Models/Requests/RemoveAtsScorecardResponse.md)**


## UpdateAtsApplication

Update an application

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.UpdateAtsApplicationAsync(ConnectionId: "string", Id: "string", AtsApplication: new AtsApplication() {
    Raw = new PropertyAtsApplicationRaw() {},
});

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `ConnectionId`                                              | *string*                                                    | :heavy_check_mark:                                          | ID of the connection                                        |
| `Id`                                                        | *string*                                                    | :heavy_check_mark:                                          | ID of the Application                                       |
| `AtsApplication`                                            | [AtsApplication](../../Models/Components/AtsApplication.md) | :heavy_minus_sign:                                          | N/A                                                         |


### Response

**[UpdateAtsApplicationResponse](../../Models/Requests/UpdateAtsApplicationResponse.md)**


## UpdateAtsCandidate

Update a candidate

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.UpdateAtsCandidateAsync(ConnectionId: "string", Id: "string", AtsCandidate: new AtsCandidate() {
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


## UpdateAtsDocument

Update a document

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.UpdateAtsDocumentAsync(ConnectionId: "string", Id: "string", AtsDocument: new AtsDocument() {
    Raw = new PropertyAtsDocumentRaw() {},
});

// handle response
```

### Parameters

| Parameter                                             | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `ConnectionId`                                        | *string*                                              | :heavy_check_mark:                                    | ID of the connection                                  |
| `Id`                                                  | *string*                                              | :heavy_check_mark:                                    | ID of the Document                                    |
| `AtsDocument`                                         | [AtsDocument](../../Models/Components/AtsDocument.md) | :heavy_minus_sign:                                    | N/A                                                   |


### Response

**[UpdateAtsDocumentResponse](../../Models/Requests/UpdateAtsDocumentResponse.md)**


## UpdateAtsInterview

Update a interview

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.UpdateAtsInterviewAsync(ConnectionId: "string", Id: "string", AtsInterview: new AtsInterview() {
    Raw = new PropertyAtsInterviewRaw() {},
    UserIds = new List<string>() {
        "string",
    },
});

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


## UpdateAtsJob

Update a job

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.UpdateAtsJobAsync(ConnectionId: "string", Id: "string", AtsJob: new AtsJob() {
    Addresses = new List<AtsAddress>() {
        new AtsAddress() {},
    },
    Compensation = new List<AtsCompensation>() {
        new AtsCompensation() {
            Type = AtsCompensationType.Equity,
        },
    },
    Departments = new List<string>() {
        "string",
    },
    HiringManagerIds = new List<string>() {
        "string",
    },
    PublicJobUrls = new List<string>() {
        "string",
    },
    Raw = new PropertyAtsJobRaw() {},
    RecruiterIds = new List<string>() {
        "string",
    },
});

// handle response
```

### Parameters

| Parameter                                   | Type                                        | Required                                    | Description                                 |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| `ConnectionId`                              | *string*                                    | :heavy_check_mark:                          | ID of the connection                        |
| `Id`                                        | *string*                                    | :heavy_check_mark:                          | ID of the Job                               |
| `AtsJob`                                    | [AtsJob](../../Models/Components/AtsJob.md) | :heavy_minus_sign:                          | N/A                                         |


### Response

**[UpdateAtsJobResponse](../../Models/Requests/UpdateAtsJobResponse.md)**


## UpdateAtsScorecard

Update a scorecard

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.UpdateAtsScorecardAsync(ConnectionId: "string", Id: "string", AtsScorecard: new AtsScorecard() {
    Raw = new PropertyAtsScorecardRaw() {},
});

// handle response
```

### Parameters

| Parameter                                               | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `ConnectionId`                                          | *string*                                                | :heavy_check_mark:                                      | ID of the connection                                    |
| `Id`                                                    | *string*                                                | :heavy_check_mark:                                      | ID of the Scorecard                                     |
| `AtsScorecard`                                          | [AtsScorecard](../../Models/Components/AtsScorecard.md) | :heavy_minus_sign:                                      | N/A                                                     |


### Response

**[UpdateAtsScorecardResponse](../../Models/Requests/UpdateAtsScorecardResponse.md)**

