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
                Id = "28d351e3-ff74-44a8-8e4e-18efc546f111",
                IsActive = true,
                IsRequired = true,
                MaxLength = 146D,
                Name = "cornu creta confugo",
                Order = 0D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2025-05-01T04:46:41.817Z").ToUniversalTime(),
            },
            new FormField() {
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                Id = "4c980f73-1655-45cc-9545-7ec449eb8e2e",
                IsActive = true,
                IsRequired = false,
                Name = "tracto nostrum desidero",
                Order = 1D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2024-09-03T15:18:40.867Z").ToUniversalTime(),
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
                Id = "59d8e949-e621-476b-b0a5-26868805b7f9",
                IsActive = true,
                IsRequired = false,
                Name = "officia supra consequatur",
                Order = 2D,
                Type = FormFieldType.MultipleSelect,
                UpdatedAt = System.DateTime.Parse("2024-02-26T23:44:15.530Z").ToUniversalTime(),
            },
            new FormField() {
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                Description = "Antepono cursim aurum voluptatum placeat audax tripudio amo.",
                Id = "0215d031-3720-4aa9-8686-c870c03d2629",
                IsActive = true,
                IsRequired = false,
                Name = "curtus fugiat audentia",
                Order = 3D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2024-11-29T06:30:34.357Z").ToUniversalTime(),
            },
        },
        HasMultipleSubmissions = false,
        HasProgressBar = false,
        HasShuffleQuestions = true,
        Id = "264c2f9b-4f36-41bd-9a75-85ada0d5d3ac",
        IsActive = false,
        Metadata = new List<FormsMetadata>() {},
        Name = "tandem tracto vivo Form",
        PublishedUrl = "https://massive-blowgun.info",
        ResponseCount = 423D,
        UpdatedAt = System.DateTime.Parse("2024-08-26T05:41:02.988Z").ToUniversalTime(),
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
                Id = "f8bfd1da-66a1-4213-a64a-8770a9b85bde",
                IsActive = true,
                IsRequired = true,
                MaxLength = 146D,
                Name = "cornu creta confugo",
                Order = 0D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2025-05-01T04:46:41.831Z").ToUniversalTime(),
            },
            new FormField() {
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                Id = "d9f9790c-8f22-4fbf-970b-cd0116a53cd8",
                IsActive = true,
                IsRequired = false,
                Name = "tracto nostrum desidero",
                Order = 1D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2024-09-03T15:18:40.875Z").ToUniversalTime(),
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
                Id = "e4057799-b6a6-4d66-90cd-801f053c8152",
                IsActive = true,
                IsRequired = false,
                Name = "officia supra consequatur",
                Order = 2D,
                Type = FormFieldType.MultipleSelect,
                UpdatedAt = System.DateTime.Parse("2024-02-26T23:44:15.534Z").ToUniversalTime(),
            },
            new FormField() {
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                Description = "Antepono cursim aurum voluptatum placeat audax tripudio amo.",
                Id = "ad8fee2d-3bde-4f15-ae7d-9da4df891374",
                IsActive = true,
                IsRequired = false,
                Name = "curtus fugiat audentia",
                Order = 3D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2024-11-29T06:30:34.367Z").ToUniversalTime(),
            },
        },
        HasMultipleSubmissions = false,
        HasProgressBar = false,
        HasShuffleQuestions = true,
        Id = "15a18a55-b4dc-4422-ac47-dea88389d996",
        IsActive = false,
        Metadata = new List<FormsMetadata>() {},
        Name = "tandem tracto vivo Form",
        PublishedUrl = "https://massive-blowgun.info",
        ResponseCount = 423D,
        UpdatedAt = System.DateTime.Parse("2024-08-26T05:41:02.996Z").ToUniversalTime(),
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
                Id = "f8bfd1da-66a1-4213-a64a-8770a9b85bde",
                IsActive = true,
                IsRequired = true,
                MaxLength = 146D,
                Name = "cornu creta confugo",
                Order = 0D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2025-05-01T04:46:41.831Z").ToUniversalTime(),
            },
            new FormField() {
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                Id = "d9f9790c-8f22-4fbf-970b-cd0116a53cd8",
                IsActive = true,
                IsRequired = false,
                Name = "tracto nostrum desidero",
                Order = 1D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2024-09-03T15:18:40.875Z").ToUniversalTime(),
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
                Id = "e4057799-b6a6-4d66-90cd-801f053c8152",
                IsActive = true,
                IsRequired = false,
                Name = "officia supra consequatur",
                Order = 2D,
                Type = FormFieldType.MultipleSelect,
                UpdatedAt = System.DateTime.Parse("2024-02-26T23:44:15.534Z").ToUniversalTime(),
            },
            new FormField() {
                CreatedAt = System.DateTime.Parse("2023-10-05T21:34:29.094Z").ToUniversalTime(),
                Description = "Antepono cursim aurum voluptatum placeat audax tripudio amo.",
                Id = "ad8fee2d-3bde-4f15-ae7d-9da4df891374",
                IsActive = true,
                IsRequired = false,
                Name = "curtus fugiat audentia",
                Order = 3D,
                Type = FormFieldType.Textarea,
                UpdatedAt = System.DateTime.Parse("2024-11-29T06:30:34.367Z").ToUniversalTime(),
            },
        },
        HasMultipleSubmissions = false,
        HasProgressBar = false,
        HasShuffleQuestions = true,
        Id = "15a18a55-b4dc-4422-ac47-dea88389d996",
        IsActive = false,
        Metadata = new List<FormsMetadata>() {},
        Name = "tandem tracto vivo Form",
        PublishedUrl = "https://massive-blowgun.info",
        ResponseCount = 423D,
        UpdatedAt = System.DateTime.Parse("2024-08-26T05:41:02.996Z").ToUniversalTime(),
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