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

var res = await sdk.Form.CreateFormsFormAsync(
    formsForm: new FormsForm() {
        ConfirmationMessage = "Alo crebro vado utique.",
        CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
        Description = "Qui pauper triumphus adipisci comitatus tamen stabilis clementia culpo tolero.",
        Fields = new List<FormField>() {
            new FormField() {
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                Id = "d90d8092-a058-40fa-8c38-c0d0c0f1bfde",
                IsActive = true,
                IsRequired = true,
                MaxLength = 146D,
                Name = "cornu creta confugo",
                Order = 0D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2025-04-28T01:16:19.073Z").ToUniversalTime(),
            },
            new FormField() {
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                Id = "5b3ac817-6b3d-4e44-a7eb-c8776a4f2f46",
                IsActive = true,
                IsRequired = false,
                Name = "tracto nostrum desidero",
                Order = 1D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2024-09-01T19:21:22.886Z").ToUniversalTime(),
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
                Id = "351d47cd-55d8-40d6-ad69-cb796fec78c7",
                IsActive = true,
                IsRequired = false,
                Name = "officia supra consequatur",
                Order = 2D,
                Type = FormFieldType.MultipleSelect,
                UpdatedAt = System.DateTime.Parse("2024-02-26T04:45:37.090Z").ToUniversalTime(),
            },
            new FormField() {
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                Description = "Antepono cursim aurum voluptatum placeat audax tripudio amo.",
                Id = "d49dc7b9-5fc1-4f28-8adf-ac66d8ac3fcf",
                IsActive = true,
                IsRequired = false,
                Name = "curtus fugiat audentia",
                Order = 3D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2024-11-26T23:08:40.354Z").ToUniversalTime(),
            },
        },
        HasMultipleSubmissions = false,
        HasProgressBar = false,
        HasShuffleQuestions = true,
        Id = "7b8c87dc-73ab-4bed-9d21-1cb9f00012b2",
        IsActive = false,
        Metadata = new List<FormsMetadata>() {},
        Name = "tandem tracto vivo Form",
        PublishedUrl = "https://massive-blowgun.info",
        ResponseCount = 423D,
        UpdatedAt = System.DateTime.Parse("2024-08-24T10:50:08.295Z").ToUniversalTime(),
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
        ConfirmationMessage = "Alo crebro vado utique.",
        CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
        Description = "Qui pauper triumphus adipisci comitatus tamen stabilis clementia culpo tolero.",
        Fields = new List<FormField>() {
            new FormField() {
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                Id = "884e99ef-25f1-4b9f-b4ae-b41d81a12f0b",
                IsActive = true,
                IsRequired = true,
                MaxLength = 146D,
                Name = "cornu creta confugo",
                Order = 0D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2025-04-28T01:16:19.082Z").ToUniversalTime(),
            },
            new FormField() {
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                Id = "2628ae7d-1fef-4b07-8540-6825583b3f34",
                IsActive = true,
                IsRequired = false,
                Name = "tracto nostrum desidero",
                Order = 1D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2024-09-01T19:21:22.891Z").ToUniversalTime(),
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
                Id = "67495728-61b6-4d14-ae22-1ae684cd22f3",
                IsActive = true,
                IsRequired = false,
                Name = "officia supra consequatur",
                Order = 2D,
                Type = FormFieldType.MultipleSelect,
                UpdatedAt = System.DateTime.Parse("2024-02-26T04:45:37.092Z").ToUniversalTime(),
            },
            new FormField() {
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                Description = "Antepono cursim aurum voluptatum placeat audax tripudio amo.",
                Id = "f8d376cc-fcaf-4cae-a3d1-448dd2e54e17",
                IsActive = true,
                IsRequired = false,
                Name = "curtus fugiat audentia",
                Order = 3D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2024-11-26T23:08:40.360Z").ToUniversalTime(),
            },
        },
        HasMultipleSubmissions = false,
        HasProgressBar = false,
        HasShuffleQuestions = true,
        Id = "e49c3839-b7f9-467b-8570-3f70ee3b1754",
        IsActive = false,
        Metadata = new List<FormsMetadata>() {},
        Name = "tandem tracto vivo Form",
        PublishedUrl = "https://massive-blowgun.info",
        ResponseCount = 423D,
        UpdatedAt = System.DateTime.Parse("2024-08-24T10:50:08.299Z").ToUniversalTime(),
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

Remove a form

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
        ConfirmationMessage = "Alo crebro vado utique.",
        CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
        Description = "Qui pauper triumphus adipisci comitatus tamen stabilis clementia culpo tolero.",
        Fields = new List<FormField>() {
            new FormField() {
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                Id = "884e99ef-25f1-4b9f-b4ae-b41d81a12f0b",
                IsActive = true,
                IsRequired = true,
                MaxLength = 146D,
                Name = "cornu creta confugo",
                Order = 0D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2025-04-28T01:16:19.082Z").ToUniversalTime(),
            },
            new FormField() {
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                Id = "2628ae7d-1fef-4b07-8540-6825583b3f34",
                IsActive = true,
                IsRequired = false,
                Name = "tracto nostrum desidero",
                Order = 1D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2024-09-01T19:21:22.891Z").ToUniversalTime(),
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
                Id = "67495728-61b6-4d14-ae22-1ae684cd22f3",
                IsActive = true,
                IsRequired = false,
                Name = "officia supra consequatur",
                Order = 2D,
                Type = FormFieldType.MultipleSelect,
                UpdatedAt = System.DateTime.Parse("2024-02-26T04:45:37.092Z").ToUniversalTime(),
            },
            new FormField() {
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                Description = "Antepono cursim aurum voluptatum placeat audax tripudio amo.",
                Id = "f8d376cc-fcaf-4cae-a3d1-448dd2e54e17",
                IsActive = true,
                IsRequired = false,
                Name = "curtus fugiat audentia",
                Order = 3D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2024-11-26T23:08:40.360Z").ToUniversalTime(),
            },
        },
        HasMultipleSubmissions = false,
        HasProgressBar = false,
        HasShuffleQuestions = true,
        Id = "e49c3839-b7f9-467b-8570-3f70ee3b1754",
        IsActive = false,
        Metadata = new List<FormsMetadata>() {},
        Name = "tandem tracto vivo Form",
        PublishedUrl = "https://massive-blowgun.info",
        ResponseCount = 423D,
        UpdatedAt = System.DateTime.Parse("2024-08-24T10:50:08.299Z").ToUniversalTime(),
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