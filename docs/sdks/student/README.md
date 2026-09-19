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

Create a student

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
            Address1 = "94082 Kassandra Camp",
            Address2 = "Apt. 461",
            City = "New Ibrahimmouth",
            CountryCode = "US",
            PostalCode = "52851",
            Region = "Tennessee",
            RegionCode = "NV",
        },
        CreatedAt = System.DateTime.Parse("2020-03-23T06:59:29.777Z").ToUniversalTime(),
        Emails = new List<LmsEmail>() {
            new LmsEmail() {},
            new LmsEmail() {},
        },
        FirstName = "Marcella",
        Id = "b7f5a3c4-bf6d-4484-ae31-ad0833919095",
        ImageUrl = "https://avatars.githubusercontent.com/u/36301374",
        LastName = "Murazik",
        Name = "Marcella Murazik",
        Telephones = new List<LmsTelephone>() {
            new LmsTelephone() {
                Telephone = "(482) 469-8067",
                Type = LmsTelephoneType.Fax,
            },
        },
        UpdatedAt = System.DateTime.Parse("2022-06-19T22:08:54.214Z").ToUniversalTime(),
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

Retrieve a student

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

List all students

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

Update a student

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
            Address1 = "94082 Kassandra Camp",
            Address2 = "Apt. 461",
            City = "New Ibrahimmouth",
            CountryCode = "US",
            PostalCode = "52851",
            Region = "Tennessee",
            RegionCode = "NV",
        },
        CreatedAt = System.DateTime.Parse("2020-03-23T06:59:29.777Z").ToUniversalTime(),
        Emails = new List<LmsEmail>() {
            new LmsEmail() {},
            new LmsEmail() {},
        },
        FirstName = "Marcella",
        Id = "730592b6-a177-4ddc-81c7-a9524ce50d33",
        ImageUrl = "https://avatars.githubusercontent.com/u/36301374",
        LastName = "Murazik",
        Name = "Marcella Murazik",
        Telephones = new List<LmsTelephone>() {
            new LmsTelephone() {
                Telephone = "(482) 469-8067",
                Type = LmsTelephoneType.Fax,
            },
        },
        UpdatedAt = System.DateTime.Parse("2022-06-19T22:08:54.218Z").ToUniversalTime(),
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

Remove a student

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

Update a student

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
            Address1 = "94082 Kassandra Camp",
            Address2 = "Apt. 461",
            City = "New Ibrahimmouth",
            CountryCode = "US",
            PostalCode = "52851",
            Region = "Tennessee",
            RegionCode = "NV",
        },
        CreatedAt = System.DateTime.Parse("2020-03-23T06:59:29.777Z").ToUniversalTime(),
        Emails = new List<LmsEmail>() {
            new LmsEmail() {},
            new LmsEmail() {},
        },
        FirstName = "Marcella",
        Id = "730592b6-a177-4ddc-81c7-a9524ce50d33",
        ImageUrl = "https://avatars.githubusercontent.com/u/36301374",
        LastName = "Murazik",
        Name = "Marcella Murazik",
        Telephones = new List<LmsTelephone>() {
            new LmsTelephone() {
                Telephone = "(482) 469-8067",
                Type = LmsTelephoneType.Fax,
            },
        },
        UpdatedAt = System.DateTime.Parse("2022-06-19T22:08:54.218Z").ToUniversalTime(),
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