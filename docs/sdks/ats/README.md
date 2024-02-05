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
* [GetAtsCompany](#getatscompany) - Retrieve a company
* [GetAtsDocument](#getatsdocument) - Retrieve a document
* [GetAtsInterview](#getatsinterview) - Retrieve a interview
* [GetAtsJob](#getatsjob) - Retrieve a job
* [GetAtsScorecard](#getatsscorecard) - Retrieve a scorecard
* [ListAtsApplications](#listatsapplications) - List all applications
* [ListAtsApplicationstatuses](#listatsapplicationstatuses) - List all application statuses
* [ListAtsCandidates](#listatscandidates) - List all candidates
* [ListAtsCompanies](#listatscompanies) - List all companies
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
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.CreateAtsApplicationAsync(
    connectionId: "string",
    atsApplication: new AtsApplication() {
    Raw = new Dictionary<string, object>() {
        { "key", "string" },
    },
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
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.CreateAtsCandidateAsync(
    connectionId: "string",
    atsCandidate: new AtsCandidate() {
    Address = new PropertyAtsCandidateAddress() {},
    Emails = new List<AtsEmail>() {
        new AtsEmail() {
            Email = "Robin_Feeney@hotmail.com",
        },
    },
    LinkUrls = new List<string>() {
        "string",
    },
    Raw = new Dictionary<string, object>() {
        { "key", "string" },
    },
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
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.CreateAtsDocumentAsync(
    connectionId: "string",
    atsDocument: new AtsDocument() {
    Raw = new Dictionary<string, object>() {
        { "key", "string" },
    },
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
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.CreateAtsInterviewAsync(
    connectionId: "string",
    atsInterview: new AtsInterview() {
    Raw = new Dictionary<string, object>() {
        { "key", "string" },
    },
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
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.CreateAtsJobAsync(
    connectionId: "string",
    atsJob: new AtsJob() {
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
    Raw = new Dictionary<string, object>() {
        { "key", "string" },
    },
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
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.CreateAtsScorecardAsync(
    connectionId: "string",
    atsScorecard: new AtsScorecard() {
    Raw = new Dictionary<string, object>() {
        { "key", "string" },
    },
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
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.GetAtsApplicationAsync(
    connectionId: "string",
    id: "string",
    fields: new List<string>() {
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
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.GetAtsCandidateAsync(
    connectionId: "string",
    id: "string",
    fields: new List<string>() {
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


## GetAtsCompany

Retrieve a company

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.GetAtsCompanyAsync(
    connectionId: "string",
    id: "string",
    fields: new List<string>() {
    "string",
});

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Company                |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetAtsCompanyResponse](../../Models/Requests/GetAtsCompanyResponse.md)**


## GetAtsDocument

Retrieve a document

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.GetAtsDocumentAsync(
    connectionId: "string",
    id: "string",
    fields: new List<string>() {
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
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.GetAtsInterviewAsync(
    connectionId: "string",
    id: "string",
    fields: new List<string>() {
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
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.GetAtsJobAsync(
    connectionId: "string",
    id: "string",
    fields: new List<string>() {
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
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.GetAtsScorecardAsync(
    connectionId: "string",
    id: "string",
    fields: new List<string>() {
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
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
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
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
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
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
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


## ListAtsCompanies

List all companies

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListAtsCompaniesRequest req = new ListAtsCompaniesRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
};

var res = await sdk.Ats.ListAtsCompaniesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListAtsCompaniesRequest](../../Models/Requests/ListAtsCompaniesRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |


### Response

**[ListAtsCompaniesResponse](../../Models/Requests/ListAtsCompaniesResponse.md)**


## ListAtsDocuments

List all documents

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
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
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
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
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
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
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
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
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.PatchAtsApplicationAsync(
    connectionId: "string",
    id: "string",
    atsApplication: new AtsApplication() {
    Raw = new Dictionary<string, object>() {
        { "key", "string" },
    },
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
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.PatchAtsCandidateAsync(
    connectionId: "string",
    id: "string",
    atsCandidate: new AtsCandidate() {
    Address = new PropertyAtsCandidateAddress() {},
    Emails = new List<AtsEmail>() {
        new AtsEmail() {
            Email = "Tracy.Collins13@gmail.com",
        },
    },
    LinkUrls = new List<string>() {
        "string",
    },
    Raw = new Dictionary<string, object>() {
        { "key", "string" },
    },
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
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.PatchAtsDocumentAsync(
    connectionId: "string",
    id: "string",
    atsDocument: new AtsDocument() {
    Raw = new Dictionary<string, object>() {
        { "key", "string" },
    },
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
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.PatchAtsInterviewAsync(
    connectionId: "string",
    id: "string",
    atsInterview: new AtsInterview() {
    Raw = new Dictionary<string, object>() {
        { "key", "string" },
    },
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
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.PatchAtsJobAsync(
    connectionId: "string",
    id: "string",
    atsJob: new AtsJob() {
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
    Raw = new Dictionary<string, object>() {
        { "key", "string" },
    },
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
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.PatchAtsScorecardAsync(
    connectionId: "string",
    id: "string",
    atsScorecard: new AtsScorecard() {
    Raw = new Dictionary<string, object>() {
        { "key", "string" },
    },
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
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.RemoveAtsApplicationAsync(
    connectionId: "string",
    id: "string");

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
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.RemoveAtsCandidateAsync(
    connectionId: "string",
    id: "string");

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
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.RemoveAtsDocumentAsync(
    connectionId: "string",
    id: "string");

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
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.RemoveAtsInterviewAsync(
    connectionId: "string",
    id: "string");

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
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.RemoveAtsJobAsync(
    connectionId: "string",
    id: "string");

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
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.RemoveAtsScorecardAsync(
    connectionId: "string",
    id: "string");

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
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.UpdateAtsApplicationAsync(
    connectionId: "string",
    id: "string",
    atsApplication: new AtsApplication() {
    Raw = new Dictionary<string, object>() {
        { "key", "string" },
    },
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
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.UpdateAtsCandidateAsync(
    connectionId: "string",
    id: "string",
    atsCandidate: new AtsCandidate() {
    Address = new PropertyAtsCandidateAddress() {},
    Emails = new List<AtsEmail>() {
        new AtsEmail() {
            Email = "Gaetano86@hotmail.com",
        },
    },
    LinkUrls = new List<string>() {
        "string",
    },
    Raw = new Dictionary<string, object>() {
        { "key", "string" },
    },
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
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.UpdateAtsDocumentAsync(
    connectionId: "string",
    id: "string",
    atsDocument: new AtsDocument() {
    Raw = new Dictionary<string, object>() {
        { "key", "string" },
    },
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
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.UpdateAtsInterviewAsync(
    connectionId: "string",
    id: "string",
    atsInterview: new AtsInterview() {
    Raw = new Dictionary<string, object>() {
        { "key", "string" },
    },
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
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.UpdateAtsJobAsync(
    connectionId: "string",
    id: "string",
    atsJob: new AtsJob() {
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
    Raw = new Dictionary<string, object>() {
        { "key", "string" },
    },
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
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Ats.UpdateAtsScorecardAsync(
    connectionId: "string",
    id: "string",
    atsScorecard: new AtsScorecard() {
    Raw = new Dictionary<string, object>() {
        { "key", "string" },
    },
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

