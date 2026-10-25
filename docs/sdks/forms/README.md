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

Creates a FormsForm. Provide the unified FormsForm fields in the request body; they are mapped to the provider's API. Returns the created FormsForm.

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
        ConfirmationMessage = "Alo crebro vado utique.",
        CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
        Description = "Qui pauper triumphus adipisci comitatus tamen stabilis clementia culpo tolero.",
        Fields = new List<FormField>() {
            new FormField() {
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                Id = "6841c0fe-3648-4c8f-89b9-995a48be2b95",
                IsActive = true,
                IsRequired = true,
                MaxLength = 146D,
                Name = "cornu creta confugo",
                Order = 0D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2025-04-30T17:14:20.231Z").ToUniversalTime(),
            },
            new FormField() {
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                Id = "ffb5a512-7ab3-4e55-8b37-c72e1fe42301",
                IsActive = true,
                IsRequired = false,
                Name = "tracto nostrum desidero",
                Order = 1D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2024-09-03T08:35:37.987Z").ToUniversalTime(),
            },
            new FormField() {
                Choices = new List<string>() {
                    "conor",
                    "patior",
                    "crur",
                    "vinculum",
                    "tredecim",
                },
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                DefaultValue = "somniculosus",
                Id = "7e593237-4ae0-4dda-9b64-7ce68d35323c",
                IsActive = true,
                IsRequired = false,
                Name = "officia supra consequatur",
                Order = 2D,
                Type = FormFieldType.MultipleSelect,
                UpdatedAt = System.DateTime.Parse("2024-02-26T20:50:14.695Z").ToUniversalTime(),
            },
            new FormField() {
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                Description = "Antepono cursim aurum voluptatum placeat audax tripudio amo.",
                Id = "af9e8b2d-8ca6-4de3-9c54-d8a958180a56",
                IsActive = true,
                IsRequired = false,
                Name = "curtus fugiat audentia",
                Order = 3D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2024-11-28T22:02:53.992Z").ToUniversalTime(),
            },
        },
        HasMultipleSubmissions = false,
        HasProgressBar = false,
        HasShuffleQuestions = true,
        Id = "fb4de6fa-0a0a-4cca-b6eb-dac2c12df48f",
        IsActive = false,
        Metadata = new List<FormsMetadata>() {},
        Name = "tandem tracto vivo Form",
        PublishedUrl = "https://massive-blowgun.info",
        ResponseCount = 423D,
        UpdatedAt = System.DateTime.Parse("2024-08-25T23:08:08.858Z").ToUniversalTime(),
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

Retrieves a single FormsForm by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Retrieves a single FormsSubmission by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Returns a list of FormsForms. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Returns a list of FormsSubmissions. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Updates the FormsForm identified by `id`. Provide the unified FormsForm fields to change in the request body.

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
        ConfirmationMessage = "Alo crebro vado utique.",
        CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
        Description = "Qui pauper triumphus adipisci comitatus tamen stabilis clementia culpo tolero.",
        Fields = new List<FormField>() {
            new FormField() {
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                Id = "d63161dc-7ca6-4b23-a4b7-ade6f80fa365",
                IsActive = true,
                IsRequired = true,
                MaxLength = 146D,
                Name = "cornu creta confugo",
                Order = 0D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2025-04-30T17:14:20.242Z").ToUniversalTime(),
            },
            new FormField() {
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                Id = "09bbdbab-b331-46b5-98b0-75847a6a2742",
                IsActive = true,
                IsRequired = false,
                Name = "tracto nostrum desidero",
                Order = 1D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2024-09-03T08:35:37.993Z").ToUniversalTime(),
            },
            new FormField() {
                Choices = new List<string>() {
                    "conor",
                    "patior",
                    "crur",
                    "vinculum",
                    "tredecim",
                },
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                DefaultValue = "somniculosus",
                Id = "7166bfc2-177b-4494-90f7-30d7850dace7",
                IsActive = true,
                IsRequired = false,
                Name = "officia supra consequatur",
                Order = 2D,
                Type = FormFieldType.MultipleSelect,
                UpdatedAt = System.DateTime.Parse("2024-02-26T20:50:14.698Z").ToUniversalTime(),
            },
            new FormField() {
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                Description = "Antepono cursim aurum voluptatum placeat audax tripudio amo.",
                Id = "14b09e8b-59c6-4604-bdc9-e04429b7e75f",
                IsActive = true,
                IsRequired = false,
                Name = "curtus fugiat audentia",
                Order = 3D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2024-11-28T22:02:54.000Z").ToUniversalTime(),
            },
        },
        HasMultipleSubmissions = false,
        HasProgressBar = false,
        HasShuffleQuestions = true,
        Id = "cac44b60-190b-43bb-b0f2-94d1a48e4a70",
        IsActive = false,
        Metadata = new List<FormsMetadata>() {},
        Name = "tandem tracto vivo Form",
        PublishedUrl = "https://massive-blowgun.info",
        ResponseCount = 423D,
        UpdatedAt = System.DateTime.Parse("2024-08-25T23:08:08.864Z").ToUniversalTime(),
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

Deletes the FormsForm identified by `id`.

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

Updates the FormsForm identified by `id`. Provide the unified FormsForm fields to change in the request body.

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
        ConfirmationMessage = "Alo crebro vado utique.",
        CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
        Description = "Qui pauper triumphus adipisci comitatus tamen stabilis clementia culpo tolero.",
        Fields = new List<FormField>() {
            new FormField() {
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                Id = "d63161dc-7ca6-4b23-a4b7-ade6f80fa365",
                IsActive = true,
                IsRequired = true,
                MaxLength = 146D,
                Name = "cornu creta confugo",
                Order = 0D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2025-04-30T17:14:20.242Z").ToUniversalTime(),
            },
            new FormField() {
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                Id = "09bbdbab-b331-46b5-98b0-75847a6a2742",
                IsActive = true,
                IsRequired = false,
                Name = "tracto nostrum desidero",
                Order = 1D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2024-09-03T08:35:37.993Z").ToUniversalTime(),
            },
            new FormField() {
                Choices = new List<string>() {
                    "conor",
                    "patior",
                    "crur",
                    "vinculum",
                    "tredecim",
                },
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                DefaultValue = "somniculosus",
                Id = "7166bfc2-177b-4494-90f7-30d7850dace7",
                IsActive = true,
                IsRequired = false,
                Name = "officia supra consequatur",
                Order = 2D,
                Type = FormFieldType.MultipleSelect,
                UpdatedAt = System.DateTime.Parse("2024-02-26T20:50:14.698Z").ToUniversalTime(),
            },
            new FormField() {
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                Description = "Antepono cursim aurum voluptatum placeat audax tripudio amo.",
                Id = "14b09e8b-59c6-4604-bdc9-e04429b7e75f",
                IsActive = true,
                IsRequired = false,
                Name = "curtus fugiat audentia",
                Order = 3D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2024-11-28T22:02:54.000Z").ToUniversalTime(),
            },
        },
        HasMultipleSubmissions = false,
        HasProgressBar = false,
        HasShuffleQuestions = true,
        Id = "cac44b60-190b-43bb-b0f2-94d1a48e4a70",
        IsActive = false,
        Metadata = new List<FormsMetadata>() {},
        Name = "tandem tracto vivo Form",
        PublishedUrl = "https://massive-blowgun.info",
        ResponseCount = 423D,
        UpdatedAt = System.DateTime.Parse("2024-08-25T23:08:08.864Z").ToUniversalTime(),
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