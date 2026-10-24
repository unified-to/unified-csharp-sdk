# Form

## Overview

### Available Operations

* [CreateFormsForm](#createformsform) - Create a form
* [GetFormsForm](#getformsform) - Retrieve a form
* [ListFormsForms](#listformsforms) - List all forms
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

var res = await sdk.Form.CreateFormsFormAsync(
    formsForm: new FormsForm() {
        ConfirmationMessage = "Alo crebro vado utique.",
        CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
        Description = "Qui pauper triumphus adipisci comitatus tamen stabilis clementia culpo tolero.",
        Fields = new List<FormField>() {
            new FormField() {
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                Id = "71130d3c-a5ae-482f-9690-4780ef4f4c00",
                IsActive = true,
                IsRequired = true,
                MaxLength = 146D,
                Name = "cornu creta confugo",
                Order = 0D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2025-04-30T03:19:27.419Z").ToUniversalTime(),
            },
            new FormField() {
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                Id = "68f8fa4e-c9e1-4886-aac9-91630874ed4c",
                IsActive = true,
                IsRequired = false,
                Name = "tracto nostrum desidero",
                Order = 1D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2024-09-03T00:29:37.126Z").ToUniversalTime(),
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
                Id = "5132f4ef-739a-4664-8670-fc7562652896",
                IsActive = true,
                IsRequired = false,
                Name = "officia supra consequatur",
                Order = 2D,
                Type = FormFieldType.MultipleSelect,
                UpdatedAt = System.DateTime.Parse("2024-02-26T17:20:24.642Z").ToUniversalTime(),
            },
            new FormField() {
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                Description = "Antepono cursim aurum voluptatum placeat audax tripudio amo.",
                Id = "34ee1f9a-0148-4ac4-b44a-691a7ed7abd9",
                IsActive = true,
                IsRequired = false,
                Name = "curtus fugiat audentia",
                Order = 3D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2024-11-28T11:50:43.443Z").ToUniversalTime(),
            },
        },
        HasMultipleSubmissions = false,
        HasProgressBar = false,
        HasShuffleQuestions = true,
        Id = "52c64307-c2e6-42c3-95da-9525b3b4f435",
        IsActive = false,
        Metadata = new List<FormsMetadata>() {},
        Name = "tandem tracto vivo Form",
        PublishedUrl = "https://massive-blowgun.info",
        ResponseCount = 423D,
        UpdatedAt = System.DateTime.Parse("2024-08-25T15:14:22.057Z").ToUniversalTime(),
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

var res = await sdk.Form.GetFormsFormAsync(
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

var res = await sdk.Form.ListFormsFormsAsync(req);

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
                Id = "cdb4d01c-1d46-46da-a595-6b4e45d83804",
                IsActive = true,
                IsRequired = true,
                MaxLength = 146D,
                Name = "cornu creta confugo",
                Order = 0D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2025-04-30T03:19:27.433Z").ToUniversalTime(),
            },
            new FormField() {
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                Id = "b4f1a7dd-6554-42bd-b3bb-a4376d6209c4",
                IsActive = true,
                IsRequired = false,
                Name = "tracto nostrum desidero",
                Order = 1D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2024-09-03T00:29:37.134Z").ToUniversalTime(),
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
                Id = "48c8cf0f-461d-42e3-9c23-6f71988a7c1f",
                IsActive = true,
                IsRequired = false,
                Name = "officia supra consequatur",
                Order = 2D,
                Type = FormFieldType.MultipleSelect,
                UpdatedAt = System.DateTime.Parse("2024-02-26T17:20:24.646Z").ToUniversalTime(),
            },
            new FormField() {
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                Description = "Antepono cursim aurum voluptatum placeat audax tripudio amo.",
                Id = "3d4a94f4-2d97-489a-9dd0-db31508be953",
                IsActive = true,
                IsRequired = false,
                Name = "curtus fugiat audentia",
                Order = 3D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2024-11-28T11:50:43.453Z").ToUniversalTime(),
            },
        },
        HasMultipleSubmissions = false,
        HasProgressBar = false,
        HasShuffleQuestions = true,
        Id = "9ecfc2ed-ff63-4dc1-98b7-0035e51e891b",
        IsActive = false,
        Metadata = new List<FormsMetadata>() {},
        Name = "tandem tracto vivo Form",
        PublishedUrl = "https://massive-blowgun.info",
        ResponseCount = 423D,
        UpdatedAt = System.DateTime.Parse("2024-08-25T15:14:22.064Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Form.PatchFormsFormAsync(req);

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

var res = await sdk.Form.RemoveFormsFormAsync(
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
                Id = "cdb4d01c-1d46-46da-a595-6b4e45d83804",
                IsActive = true,
                IsRequired = true,
                MaxLength = 146D,
                Name = "cornu creta confugo",
                Order = 0D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2025-04-30T03:19:27.433Z").ToUniversalTime(),
            },
            new FormField() {
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                Id = "b4f1a7dd-6554-42bd-b3bb-a4376d6209c4",
                IsActive = true,
                IsRequired = false,
                Name = "tracto nostrum desidero",
                Order = 1D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2024-09-03T00:29:37.134Z").ToUniversalTime(),
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
                Id = "48c8cf0f-461d-42e3-9c23-6f71988a7c1f",
                IsActive = true,
                IsRequired = false,
                Name = "officia supra consequatur",
                Order = 2D,
                Type = FormFieldType.MultipleSelect,
                UpdatedAt = System.DateTime.Parse("2024-02-26T17:20:24.646Z").ToUniversalTime(),
            },
            new FormField() {
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                Description = "Antepono cursim aurum voluptatum placeat audax tripudio amo.",
                Id = "3d4a94f4-2d97-489a-9dd0-db31508be953",
                IsActive = true,
                IsRequired = false,
                Name = "curtus fugiat audentia",
                Order = 3D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2024-11-28T11:50:43.453Z").ToUniversalTime(),
            },
        },
        HasMultipleSubmissions = false,
        HasProgressBar = false,
        HasShuffleQuestions = true,
        Id = "9ecfc2ed-ff63-4dc1-98b7-0035e51e891b",
        IsActive = false,
        Metadata = new List<FormsMetadata>() {},
        Name = "tandem tracto vivo Form",
        PublishedUrl = "https://massive-blowgun.info",
        ResponseCount = 423D,
        UpdatedAt = System.DateTime.Parse("2024-08-25T15:14:22.064Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Form.UpdateFormsFormAsync(req);

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