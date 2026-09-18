# Forms

## Overview

### Available Operations

* [CreateFormsForm](#createformsform) - Create a form
* [GetFormsForm](#getformsform) - Retrieve a form
* [GetFormsSubmission](#getformssubmission) - Retrieve a submission
* [ListFormsForms](#listformsforms) - List all forms
* [ListFormsSubmissions](#listformssubmissions) - List all submissions
* [PatchFormsForm](#patchformsform) - Update a form
* [RemoveFormsForm](#removeformsform) - Remove a form
* [UpdateFormsForm](#updateformsform) - Update a form

## CreateFormsForm

Create a form

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createFormsForm" method="post" path="/forms/{connection_id}/form" example="forms_form" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Forms.CreateFormsFormAsync(
    formsForm: new FormsForm() {
        ConfirmationMessage = "Cultura temeritas aptus celebrer volo pecus culpa annus aurum.",
        CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
        Description = "Sodalitas cupiditas terebro conduco.",
        Fields = new List<FormField>() {
            new FormField() {
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                Id = "565f27cf-2cf7-4c30-ad97-4340d859b584",
                IsActive = true,
                IsRequired = true,
                MaxLength = 146D,
                Name = "vulgivagus audio accendo",
                Order = 0D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2025-04-11T17:17:35.689Z").ToUniversalTime(),
            },
            new FormField() {
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                Id = "82b263f9-2d16-4cdf-8e99-d05ba46ce817",
                IsActive = true,
                IsRequired = false,
                Name = "alo crebro vado",
                Order = 1D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2024-08-23T07:10:16.251Z").ToUniversalTime(),
            },
            new FormField() {
                Choices = new List<string>() {
                    "vallum",
                    "vae",
                    "nesciunt",
                    "commodi",
                    "appositus",
                },
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                DefaultValue = "cattus",
                Id = "d7c963e5-2d3d-4436-a57d-a6e337d9d170",
                IsActive = true,
                IsRequired = false,
                Name = "casso tenus nesciunt",
                Order = 2D,
                Type = FormFieldType.MultipleSelect,
                UpdatedAt = System.DateTime.Parse("2024-02-22T02:14:33.063Z").ToUniversalTime(),
            },
            new FormField() {
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                Description = "Sequi antea delectatio.",
                Id = "e45efb8f-439b-40f6-8370-99c8ec66b065",
                IsActive = true,
                IsRequired = false,
                Name = "comburo utique ipsa",
                Order = 3D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2024-11-14T23:43:34.255Z").ToUniversalTime(),
            },
        },
        HasMultipleSubmissions = false,
        HasProgressBar = false,
        HasShuffleQuestions = true,
        Id = "d0766382-50db-4bb3-a245-eaefe22f656b",
        IsActive = false,
        Name = "voluptatibus omnis audax Form",
        PublishedUrl = "https://impartial-institute.org/",
        ResponseCount = 423D,
        UpdatedAt = System.DateTime.Parse("2024-08-15T04:23:40.243Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `FormsForm`                                                                                                                                      | [FormsForm](../../Models/Components/FormsForm.md)                                                                                                | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateFormsFormQueryParamFields](../../Models/Requests/CreateFormsFormQueryParamFields.md)>                                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateFormsFormResponse](../../Models/Requests/CreateFormsFormResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetFormsForm

Retrieve a form

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getFormsForm" method="get" path="/forms/{connection_id}/form/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Forms.GetFormsFormAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Form                                                                                                                                   |
| `Fields`                                                                                                                                         | List<[GetFormsFormQueryParamFields](../../Models/Requests/GetFormsFormQueryParamFields.md)>                                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetFormsFormResponse](../../Models/Requests/GetFormsFormResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetFormsSubmission

Retrieve a submission

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getFormsSubmission" method="get" path="/forms/{connection_id}/submission/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Forms.GetFormsSubmissionAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Submission                                                                                                                             |
| `Fields`                                                                                                                                         | List<[GetFormsSubmissionQueryParamFields](../../Models/Requests/GetFormsSubmissionQueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetFormsSubmissionResponse](../../Models/Requests/GetFormsSubmissionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListFormsForms

List all forms

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listFormsForms" method="get" path="/forms/{connection_id}/form" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListFormsFormsRequest req = new ListFormsFormsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Forms.ListFormsFormsAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [ListFormsFormsRequest](../../Models/Requests/ListFormsFormsRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[ListFormsFormsResponse](../../Models/Requests/ListFormsFormsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListFormsSubmissions

List all submissions

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listFormsSubmissions" method="get" path="/forms/{connection_id}/submission" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListFormsSubmissionsRequest req = new ListFormsSubmissionsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Forms.ListFormsSubmissionsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [ListFormsSubmissionsRequest](../../Models/Requests/ListFormsSubmissionsRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[ListFormsSubmissionsResponse](../../Models/Requests/ListFormsSubmissionsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchFormsForm

Update a form

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchFormsForm" method="patch" path="/forms/{connection_id}/form/{id}" example="forms_form" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchFormsFormRequest req = new PatchFormsFormRequest() {
    FormsForm = new FormsForm() {
        ConfirmationMessage = "Cultura temeritas aptus celebrer volo pecus culpa annus aurum.",
        CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
        Description = "Sodalitas cupiditas terebro conduco.",
        Fields = new List<FormField>() {
            new FormField() {
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                Id = "565f27cf-2cf7-4c30-ad97-4340d859b584",
                IsActive = true,
                IsRequired = true,
                MaxLength = 146D,
                Name = "vulgivagus audio accendo",
                Order = 0D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2025-04-11T17:17:35.699Z").ToUniversalTime(),
            },
            new FormField() {
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                Id = "82b263f9-2d16-4cdf-8e99-d05ba46ce817",
                IsActive = true,
                IsRequired = false,
                Name = "alo crebro vado",
                Order = 1D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2024-08-23T07:10:16.257Z").ToUniversalTime(),
            },
            new FormField() {
                Choices = new List<string>() {
                    "vallum",
                    "vae",
                    "nesciunt",
                    "commodi",
                    "appositus",
                },
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                DefaultValue = "cattus",
                Id = "d7c963e5-2d3d-4436-a57d-a6e337d9d170",
                IsActive = true,
                IsRequired = false,
                Name = "casso tenus nesciunt",
                Order = 2D,
                Type = FormFieldType.MultipleSelect,
                UpdatedAt = System.DateTime.Parse("2024-02-22T02:14:33.065Z").ToUniversalTime(),
            },
            new FormField() {
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                Description = "Sequi antea delectatio.",
                Id = "e45efb8f-439b-40f6-8370-99c8ec66b065",
                IsActive = true,
                IsRequired = false,
                Name = "comburo utique ipsa",
                Order = 3D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2024-11-14T23:43:34.262Z").ToUniversalTime(),
            },
        },
        HasMultipleSubmissions = false,
        HasProgressBar = false,
        HasShuffleQuestions = true,
        Id = "5938349a-6b1c-42b1-9d6c-d5641aa72d7a",
        IsActive = false,
        Name = "voluptatibus omnis audax Form",
        PublishedUrl = "https://impartial-institute.org/",
        ResponseCount = 423D,
        UpdatedAt = System.DateTime.Parse("2024-08-15T04:23:40.249Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Forms.PatchFormsFormAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [PatchFormsFormRequest](../../Models/Requests/PatchFormsFormRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[PatchFormsFormResponse](../../Models/Requests/PatchFormsFormResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveFormsForm

Remove a form

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeFormsForm" method="delete" path="/forms/{connection_id}/form/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Forms.RemoveFormsFormAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Form       |

### Response

**[RemoveFormsFormResponse](../../Models/Requests/RemoveFormsFormResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateFormsForm

Update a form

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateFormsForm" method="put" path="/forms/{connection_id}/form/{id}" example="forms_form" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateFormsFormRequest req = new UpdateFormsFormRequest() {
    FormsForm = new FormsForm() {
        ConfirmationMessage = "Cultura temeritas aptus celebrer volo pecus culpa annus aurum.",
        CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
        Description = "Sodalitas cupiditas terebro conduco.",
        Fields = new List<FormField>() {
            new FormField() {
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                Id = "565f27cf-2cf7-4c30-ad97-4340d859b584",
                IsActive = true,
                IsRequired = true,
                MaxLength = 146D,
                Name = "vulgivagus audio accendo",
                Order = 0D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2025-04-11T17:17:35.699Z").ToUniversalTime(),
            },
            new FormField() {
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                Id = "82b263f9-2d16-4cdf-8e99-d05ba46ce817",
                IsActive = true,
                IsRequired = false,
                Name = "alo crebro vado",
                Order = 1D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2024-08-23T07:10:16.257Z").ToUniversalTime(),
            },
            new FormField() {
                Choices = new List<string>() {
                    "vallum",
                    "vae",
                    "nesciunt",
                    "commodi",
                    "appositus",
                },
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                DefaultValue = "cattus",
                Id = "d7c963e5-2d3d-4436-a57d-a6e337d9d170",
                IsActive = true,
                IsRequired = false,
                Name = "casso tenus nesciunt",
                Order = 2D,
                Type = FormFieldType.MultipleSelect,
                UpdatedAt = System.DateTime.Parse("2024-02-22T02:14:33.065Z").ToUniversalTime(),
            },
            new FormField() {
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                Description = "Sequi antea delectatio.",
                Id = "e45efb8f-439b-40f6-8370-99c8ec66b065",
                IsActive = true,
                IsRequired = false,
                Name = "comburo utique ipsa",
                Order = 3D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2024-11-14T23:43:34.262Z").ToUniversalTime(),
            },
        },
        HasMultipleSubmissions = false,
        HasProgressBar = false,
        HasShuffleQuestions = true,
        Id = "5938349a-6b1c-42b1-9d6c-d5641aa72d7a",
        IsActive = false,
        Name = "voluptatibus omnis audax Form",
        PublishedUrl = "https://impartial-institute.org/",
        ResponseCount = 423D,
        UpdatedAt = System.DateTime.Parse("2024-08-15T04:23:40.249Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Forms.UpdateFormsFormAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [UpdateFormsFormRequest](../../Models/Requests/UpdateFormsFormRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[UpdateFormsFormResponse](../../Models/Requests/UpdateFormsFormResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |