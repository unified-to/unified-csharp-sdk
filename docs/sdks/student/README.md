# Student

## Overview

### Available Operations

* [CreateLmsStudent](#createlmsstudent) - Create a student
* [GetLmsStudent](#getlmsstudent) - Retrieve a student
* [ListLmsStudents](#listlmsstudents) - List all students
* [PatchLmsStudent](#patchlmsstudent) - Update a student
* [RemoveLmsStudent](#removelmsstudent) - Remove a student
* [UpdateLmsStudent](#updatelmsstudent) - Update a student

## CreateLmsStudent

Creates a LmsStudent. Provide the unified LmsStudent fields in the request body; they are mapped to the provider's API. Returns the created LmsStudent.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createLmsStudent" method="post" path="/lms/{connection_id}/student" example="lms_student" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Student.CreateLmsStudentAsync(
    lmsStudent: new LmsStudent() {
        Address = new PropertyLmsStudentAddress() {
            Address1 = "15033 Corwin Circles",
            City = "New Craigside",
            CountryCode = "US",
            PostalCode = "73966",
            Region = "New Jersey",
            RegionCode = "TX",
        },
        CreatedAt = System.DateTime.Parse("2020-03-23T06:59:29.777Z").ToUniversalTime(),
        Emails = new List<LmsEmail>() {
            new LmsEmail() {},
        },
        FirstName = "Marcella",
        Id = "b92c31f3-40b9-4929-af41-1070df0ba3d6",
        ImageUrl = "https://cdn.jsdelivr.net/gh/faker-js/assets-person-portrait/male/512/56.jpg",
        LastName = "Murazik",
        Metadata = new List<LmsMetadata>() {},
        Name = "Marcella Murazik",
        Telephones = new List<LmsTelephone>() {
            new LmsTelephone() {
                Telephone = "(899) 827-6400",
                Type = LmsTelephoneType.Work,
            },
            new LmsTelephone() {
                Telephone = "(487) 213-8236",
                Type = LmsTelephoneType.Fax,
            },
            new LmsTelephone() {
                Telephone = "(980) 775-2940",
                Type = LmsTelephoneType.Fax,
            },
        },
        UpdatedAt = System.DateTime.Parse("2022-07-02T08:25:27.159Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `LmsStudent`                                                                                                                                     | [LmsStudent](../../Models/Components/LmsStudent.md)                                                                                              | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateLmsStudentQueryParamFields](../../Models/Requests/CreateLmsStudentQueryParamFields.md)>                                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateLmsStudentResponse](../../Models/Requests/CreateLmsStudentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetLmsStudent

Retrieves a single LmsStudent by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getLmsStudent" method="get" path="/lms/{connection_id}/student/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Student.GetLmsStudentAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Student                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetLmsStudentQueryParamFields](../../Models/Requests/GetLmsStudentQueryParamFields.md)>                                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetLmsStudentResponse](../../Models/Requests/GetLmsStudentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListLmsStudents

Returns a list of LmsStudents. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listLmsStudents" method="get" path="/lms/{connection_id}/student" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListLmsStudentsRequest req = new ListLmsStudentsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Student.ListLmsStudentsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [ListLmsStudentsRequest](../../Models/Requests/ListLmsStudentsRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[ListLmsStudentsResponse](../../Models/Requests/ListLmsStudentsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchLmsStudent

Updates the LmsStudent identified by `id`. Provide the unified LmsStudent fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchLmsStudent" method="patch" path="/lms/{connection_id}/student/{id}" example="lms_student" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchLmsStudentRequest req = new PatchLmsStudentRequest() {
    LmsStudent = new LmsStudent() {
        Address = new PropertyLmsStudentAddress() {
            Address1 = "15033 Corwin Circles",
            City = "New Craigside",
            CountryCode = "US",
            PostalCode = "73966",
            Region = "New Jersey",
            RegionCode = "TX",
        },
        CreatedAt = System.DateTime.Parse("2020-03-23T06:59:29.777Z").ToUniversalTime(),
        Emails = new List<LmsEmail>() {
            new LmsEmail() {},
        },
        FirstName = "Marcella",
        Id = "629a8199-5564-42fb-ae24-3bc366749764",
        ImageUrl = "https://cdn.jsdelivr.net/gh/faker-js/assets-person-portrait/male/512/56.jpg",
        LastName = "Murazik",
        Metadata = new List<LmsMetadata>() {},
        Name = "Marcella Murazik",
        Telephones = new List<LmsTelephone>() {
            new LmsTelephone() {
                Telephone = "(899) 827-6400",
                Type = LmsTelephoneType.Work,
            },
            new LmsTelephone() {
                Telephone = "(487) 213-8236",
                Type = LmsTelephoneType.Fax,
            },
            new LmsTelephone() {
                Telephone = "(980) 775-2940",
                Type = LmsTelephoneType.Fax,
            },
        },
        UpdatedAt = System.DateTime.Parse("2022-07-02T08:25:27.167Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Student.PatchLmsStudentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [PatchLmsStudentRequest](../../Models/Requests/PatchLmsStudentRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[PatchLmsStudentResponse](../../Models/Requests/PatchLmsStudentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveLmsStudent

Deletes the LmsStudent identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeLmsStudent" method="delete" path="/lms/{connection_id}/student/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Student.RemoveLmsStudentAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Student    |

### Response

**[RemoveLmsStudentResponse](../../Models/Requests/RemoveLmsStudentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateLmsStudent

Updates the LmsStudent identified by `id`. Provide the unified LmsStudent fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateLmsStudent" method="put" path="/lms/{connection_id}/student/{id}" example="lms_student" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateLmsStudentRequest req = new UpdateLmsStudentRequest() {
    LmsStudent = new LmsStudent() {
        Address = new PropertyLmsStudentAddress() {
            Address1 = "15033 Corwin Circles",
            City = "New Craigside",
            CountryCode = "US",
            PostalCode = "73966",
            Region = "New Jersey",
            RegionCode = "TX",
        },
        CreatedAt = System.DateTime.Parse("2020-03-23T06:59:29.777Z").ToUniversalTime(),
        Emails = new List<LmsEmail>() {
            new LmsEmail() {},
        },
        FirstName = "Marcella",
        Id = "629a8199-5564-42fb-ae24-3bc366749764",
        ImageUrl = "https://cdn.jsdelivr.net/gh/faker-js/assets-person-portrait/male/512/56.jpg",
        LastName = "Murazik",
        Metadata = new List<LmsMetadata>() {},
        Name = "Marcella Murazik",
        Telephones = new List<LmsTelephone>() {
            new LmsTelephone() {
                Telephone = "(899) 827-6400",
                Type = LmsTelephoneType.Work,
            },
            new LmsTelephone() {
                Telephone = "(487) 213-8236",
                Type = LmsTelephoneType.Fax,
            },
            new LmsTelephone() {
                Telephone = "(980) 775-2940",
                Type = LmsTelephoneType.Fax,
            },
        },
        UpdatedAt = System.DateTime.Parse("2022-07-02T08:25:27.167Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Student.UpdateLmsStudentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [UpdateLmsStudentRequest](../../Models/Requests/UpdateLmsStudentRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[UpdateLmsStudentResponse](../../Models/Requests/UpdateLmsStudentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |