# Legal

## Overview

### Available Operations

* [CreateLegalExpense](#createlegalexpense) - Create an expense
* [CreateLegalMatter](#createlegalmatter) - Create a matter
* [CreateLegalPracticearea](#createlegalpracticearea) - Create a practicearea
* [CreateLegalTimeentry](#createlegaltimeentry) - Create a timeentry
* [GetLegalExpense](#getlegalexpense) - Retrieve an expense
* [GetLegalMatter](#getlegalmatter) - Retrieve a matter
* [GetLegalPracticearea](#getlegalpracticearea) - Retrieve a practicearea
* [GetLegalTimeentry](#getlegaltimeentry) - Retrieve a timeentry
* [ListLegalExpenses](#listlegalexpenses) - List all expenses
* [ListLegalMatters](#listlegalmatters) - List all matters
* [ListLegalPracticeareas](#listlegalpracticeareas) - List all practiceareas
* [ListLegalTimeentries](#listlegaltimeentries) - List all timeentries
* [PatchLegalExpense](#patchlegalexpense) - Update an expense
* [PatchLegalMatter](#patchlegalmatter) - Update a matter
* [PatchLegalPracticearea](#patchlegalpracticearea) - Update a practicearea
* [PatchLegalTimeentry](#patchlegaltimeentry) - Update a timeentry
* [RemoveLegalExpense](#removelegalexpense) - Remove an expense
* [RemoveLegalMatter](#removelegalmatter) - Remove a matter
* [RemoveLegalPracticearea](#removelegalpracticearea) - Remove a practicearea
* [RemoveLegalTimeentry](#removelegaltimeentry) - Remove a timeentry
* [UpdateLegalExpense](#updatelegalexpense) - Update an expense
* [UpdateLegalMatter](#updatelegalmatter) - Update a matter
* [UpdateLegalPracticearea](#updatelegalpracticearea) - Update a practicearea
* [UpdateLegalTimeentry](#updatelegaltimeentry) - Update a timeentry

## CreateLegalExpense

Creates a LegalExpense. Provide the unified LegalExpense fields in the request body; they are mapped to the provider's API. Returns the created LegalExpense.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createLegalExpense" method="post" path="/legal/{connection_id}/expense" example="legal_expense" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Legal.CreateLegalExpenseAsync(
    legalExpense: new LegalExpense() {
        Category = "Kids",
        CreatedAt = System.DateTime.Parse("2020-11-08T00:41:42.356Z").ToUniversalTime(),
        Currency = "MVR",
        Description = "Temporibus agnitio sui.",
        Id = "4a4cdd79-bfce-426b-8526-79bde8c19ce6",
        IncurredAt = System.DateTime.Parse("2020-11-08T00:41:42.356Z").ToUniversalTime(),
        IsBilled = false,
        Metadata = new List<LegalMetadata>() {},
        PriceAmount = 100D,
        Quantity = 3D,
        TotalAmount = 300D,
        Type = LegalExpenseType.Other,
        UpdatedAt = System.DateTime.Parse("2024-04-03T23:26:15.338Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `LegalExpense`                                                                                                                                   | [LegalExpense](../../Models/Components/LegalExpense.md)                                                                                          | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateLegalExpenseQueryParamFields](../../Models/Requests/CreateLegalExpenseQueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateLegalExpenseResponse](../../Models/Requests/CreateLegalExpenseResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateLegalMatter

Creates a LegalMatter. Provide the unified LegalMatter fields in the request body; they are mapped to the provider's API. Returns the created LegalMatter.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createLegalMatter" method="post" path="/legal/{connection_id}/matter" example="legal_matter" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Legal.CreateLegalMatterAsync(
    legalMatter: new LegalMatter() {
        BillingMethod = BillingMethod.Other,
        ClientReference = "qSrjIBAD",
        CompanyIds = new List<string>() {},
        ContactIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2023-05-28T04:10:42.375Z").ToUniversalTime(),
        Currency = "BOB",
        Description = "Speciosus cresco aut cotidie temeritas arma.",
        Id = "b5631ef3-471f-423e-957f-ff877183021d",
        Metadata = new List<LegalMetadata>() {},
        Name = "Walter v. Franecki - Spinka",
        Number = "2023-3062",
        OpenedAt = System.DateTime.Parse("2023-07-05T11:28:51.435Z").ToUniversalTime(),
        Parties = new List<LegalParty>() {
            new LegalParty() {
                Description = "Urban Walter",
                Role = LegalPartyRole.Expert,
            },
        },
        Stage = "currus",
        Status = LegalMatterStatus.Open,
        StatuteOfLimitationsAt = System.DateTime.Parse("2027-07-05T21:43:16.816Z").ToUniversalTime(),
        UpdatedAt = System.DateTime.Parse("2023-07-17T16:54:31.440Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `LegalMatter`                                                                                                                                    | [LegalMatter](../../Models/Components/LegalMatter.md)                                                                                            | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateLegalMatterQueryParamFields](../../Models/Requests/CreateLegalMatterQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateLegalMatterResponse](../../Models/Requests/CreateLegalMatterResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateLegalPracticearea

Creates a LegalPracticearea. Provide the unified LegalPracticearea fields in the request body; they are mapped to the provider's API. Returns the created LegalPracticearea.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createLegalPracticearea" method="post" path="/legal/{connection_id}/practicearea" example="legal_practicearea" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Legal.CreateLegalPracticeareaAsync(
    legalPracticearea: new LegalPracticearea() {
        Code = "QCA",
        CreatedAt = System.DateTime.Parse("2023-01-28T21:00:26.264Z").ToUniversalTime(),
        Id = "2a74e704-a805-4e17-9d66-a579e9499823",
        Metadata = new List<LegalMetadata>() {},
        Name = "witty Law",
        Type = LegalPracticeareaType.Education,
        UpdatedAt = System.DateTime.Parse("2025-09-01T13:45:17.422Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `LegalPracticearea`                                                                                                                              | [LegalPracticearea](../../Models/Components/LegalPracticearea.md)                                                                                | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateLegalPracticeareaQueryParamFields](../../Models/Requests/CreateLegalPracticeareaQueryParamFields.md)>                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateLegalPracticeareaResponse](../../Models/Requests/CreateLegalPracticeareaResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateLegalTimeentry

Creates a LegalTimeentry. Provide the unified LegalTimeentry fields in the request body; they are mapped to the provider's API. Returns the created LegalTimeentry.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createLegalTimeentry" method="post" path="/legal/{connection_id}/timeentry" example="legal_timeentry" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Legal.CreateLegalTimeentryAsync(
    legalTimeentry: new LegalTimeentry() {
        BillableMinutes = 390D,
        CreatedAt = System.DateTime.Parse("2022-05-06T03:26:03.756Z").ToUniversalTime(),
        Currency = "ZAR",
        Description = "Ea derideo adulatio torrens.",
        Id = "a43678ce-d166-46d1-a9f2-aa75b7364e14",
        IsBillable = true,
        Metadata = new List<LegalMetadata>() {},
        Minutes = 390D,
        RateAmount = 637D,
        TotalAmount = 4140.5D,
        UpdatedAt = System.DateTime.Parse("2022-06-30T07:30:26.605Z").ToUniversalTime(),
        WorkedAt = System.DateTime.Parse("2022-05-06T03:26:03.756Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `LegalTimeentry`                                                                                                                                 | [LegalTimeentry](../../Models/Components/LegalTimeentry.md)                                                                                      | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateLegalTimeentryQueryParamFields](../../Models/Requests/CreateLegalTimeentryQueryParamFields.md)>                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateLegalTimeentryResponse](../../Models/Requests/CreateLegalTimeentryResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetLegalExpense

Retrieves a single LegalExpense by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getLegalExpense" method="get" path="/legal/{connection_id}/expense/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Legal.GetLegalExpenseAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Expense                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetLegalExpenseQueryParamFields](../../Models/Requests/GetLegalExpenseQueryParamFields.md)>                                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetLegalExpenseResponse](../../Models/Requests/GetLegalExpenseResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetLegalMatter

Retrieves a single LegalMatter by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getLegalMatter" method="get" path="/legal/{connection_id}/matter/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Legal.GetLegalMatterAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Matter                                                                                                                                 |
| `Fields`                                                                                                                                         | List<[GetLegalMatterQueryParamFields](../../Models/Requests/GetLegalMatterQueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetLegalMatterResponse](../../Models/Requests/GetLegalMatterResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetLegalPracticearea

Retrieves a single LegalPracticearea by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getLegalPracticearea" method="get" path="/legal/{connection_id}/practicearea/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Legal.GetLegalPracticeareaAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Practicearea                                                                                                                           |
| `Fields`                                                                                                                                         | List<[GetLegalPracticeareaQueryParamFields](../../Models/Requests/GetLegalPracticeareaQueryParamFields.md)>                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetLegalPracticeareaResponse](../../Models/Requests/GetLegalPracticeareaResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetLegalTimeentry

Retrieves a single LegalTimeentry by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getLegalTimeentry" method="get" path="/legal/{connection_id}/timeentry/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Legal.GetLegalTimeentryAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Timeentry                                                                                                                              |
| `Fields`                                                                                                                                         | List<[GetLegalTimeentryQueryParamFields](../../Models/Requests/GetLegalTimeentryQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetLegalTimeentryResponse](../../Models/Requests/GetLegalTimeentryResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListLegalExpenses

Returns a list of LegalExpenses. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listLegalExpenses" method="get" path="/legal/{connection_id}/expense" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListLegalExpensesRequest req = new ListLegalExpensesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Legal.ListLegalExpensesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListLegalExpensesRequest](../../Models/Requests/ListLegalExpensesRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[ListLegalExpensesResponse](../../Models/Requests/ListLegalExpensesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListLegalMatters

Returns a list of LegalMatters. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listLegalMatters" method="get" path="/legal/{connection_id}/matter" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListLegalMattersRequest req = new ListLegalMattersRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Legal.ListLegalMattersAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListLegalMattersRequest](../../Models/Requests/ListLegalMattersRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[ListLegalMattersResponse](../../Models/Requests/ListLegalMattersResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListLegalPracticeareas

Returns a list of LegalPracticeareas. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listLegalPracticeareas" method="get" path="/legal/{connection_id}/practicearea" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListLegalPracticeareasRequest req = new ListLegalPracticeareasRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Legal.ListLegalPracticeareasAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [ListLegalPracticeareasRequest](../../Models/Requests/ListLegalPracticeareasRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[ListLegalPracticeareasResponse](../../Models/Requests/ListLegalPracticeareasResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListLegalTimeentries

Returns a list of LegalTimeentries. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listLegalTimeentries" method="get" path="/legal/{connection_id}/timeentry" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListLegalTimeentriesRequest req = new ListLegalTimeentriesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Legal.ListLegalTimeentriesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [ListLegalTimeentriesRequest](../../Models/Requests/ListLegalTimeentriesRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[ListLegalTimeentriesResponse](../../Models/Requests/ListLegalTimeentriesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchLegalExpense

Updates the LegalExpense identified by `id`. Provide the unified LegalExpense fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchLegalExpense" method="patch" path="/legal/{connection_id}/expense/{id}" example="legal_expense" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchLegalExpenseRequest req = new PatchLegalExpenseRequest() {
    LegalExpense = new LegalExpense() {
        Category = "Kids",
        CreatedAt = System.DateTime.Parse("2020-11-08T00:41:42.356Z").ToUniversalTime(),
        Currency = "MVR",
        Description = "Temporibus agnitio sui.",
        Id = "373a0e19-2a20-4659-9c3c-3ee8c3f1915e",
        IncurredAt = System.DateTime.Parse("2020-11-08T00:41:42.356Z").ToUniversalTime(),
        IsBilled = false,
        Metadata = new List<LegalMetadata>() {},
        PriceAmount = 100D,
        Quantity = 3D,
        TotalAmount = 300D,
        Type = LegalExpenseType.Other,
        UpdatedAt = System.DateTime.Parse("2024-04-03T23:26:15.353Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Legal.PatchLegalExpenseAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [PatchLegalExpenseRequest](../../Models/Requests/PatchLegalExpenseRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[PatchLegalExpenseResponse](../../Models/Requests/PatchLegalExpenseResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchLegalMatter

Updates the LegalMatter identified by `id`. Provide the unified LegalMatter fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchLegalMatter" method="patch" path="/legal/{connection_id}/matter/{id}" example="legal_matter" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchLegalMatterRequest req = new PatchLegalMatterRequest() {
    LegalMatter = new LegalMatter() {
        BillingMethod = BillingMethod.Other,
        ClientReference = "qSrjIBAD",
        CompanyIds = new List<string>() {},
        ContactIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2023-05-28T04:10:42.375Z").ToUniversalTime(),
        Currency = "BOB",
        Description = "Speciosus cresco aut cotidie temeritas arma.",
        Id = "fdcb03ee-6d6d-4c7e-80d2-16cdf05f8b9f",
        Metadata = new List<LegalMetadata>() {},
        Name = "Walter v. Franecki - Spinka",
        Number = "2023-3062",
        OpenedAt = System.DateTime.Parse("2023-07-05T11:28:51.435Z").ToUniversalTime(),
        Parties = new List<LegalParty>() {
            new LegalParty() {
                Description = "Urban Walter",
                Role = LegalPartyRole.Expert,
            },
        },
        Stage = "currus",
        Status = LegalMatterStatus.Open,
        StatuteOfLimitationsAt = System.DateTime.Parse("2027-07-05T21:43:16.844Z").ToUniversalTime(),
        UpdatedAt = System.DateTime.Parse("2023-07-17T16:54:31.441Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Legal.PatchLegalMatterAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [PatchLegalMatterRequest](../../Models/Requests/PatchLegalMatterRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[PatchLegalMatterResponse](../../Models/Requests/PatchLegalMatterResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchLegalPracticearea

Updates the LegalPracticearea identified by `id`. Provide the unified LegalPracticearea fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchLegalPracticearea" method="patch" path="/legal/{connection_id}/practicearea/{id}" example="legal_practicearea" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchLegalPracticeareaRequest req = new PatchLegalPracticeareaRequest() {
    LegalPracticearea = new LegalPracticearea() {
        Code = "QCA",
        CreatedAt = System.DateTime.Parse("2023-01-28T21:00:26.264Z").ToUniversalTime(),
        Id = "76d118c6-c14b-4385-a15b-c6dedb216258",
        Metadata = new List<LegalMetadata>() {},
        Name = "witty Law",
        Type = LegalPracticeareaType.Education,
        UpdatedAt = System.DateTime.Parse("2025-09-01T13:45:17.437Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Legal.PatchLegalPracticeareaAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [PatchLegalPracticeareaRequest](../../Models/Requests/PatchLegalPracticeareaRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[PatchLegalPracticeareaResponse](../../Models/Requests/PatchLegalPracticeareaResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchLegalTimeentry

Updates the LegalTimeentry identified by `id`. Provide the unified LegalTimeentry fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchLegalTimeentry" method="patch" path="/legal/{connection_id}/timeentry/{id}" example="legal_timeentry" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchLegalTimeentryRequest req = new PatchLegalTimeentryRequest() {
    LegalTimeentry = new LegalTimeentry() {
        BillableMinutes = 390D,
        CreatedAt = System.DateTime.Parse("2022-05-06T03:26:03.756Z").ToUniversalTime(),
        Currency = "ZAR",
        Description = "Ea derideo adulatio torrens.",
        Id = "43f1b863-23f2-473c-be13-faaec4490600",
        IsBillable = true,
        Metadata = new List<LegalMetadata>() {},
        Minutes = 390D,
        RateAmount = 637D,
        TotalAmount = 4140.5D,
        UpdatedAt = System.DateTime.Parse("2022-06-30T07:30:26.606Z").ToUniversalTime(),
        WorkedAt = System.DateTime.Parse("2022-05-06T03:26:03.756Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Legal.PatchLegalTimeentryAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [PatchLegalTimeentryRequest](../../Models/Requests/PatchLegalTimeentryRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[PatchLegalTimeentryResponse](../../Models/Requests/PatchLegalTimeentryResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveLegalExpense

Deletes the LegalExpense identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeLegalExpense" method="delete" path="/legal/{connection_id}/expense/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Legal.RemoveLegalExpenseAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Expense    |

### Response

**[RemoveLegalExpenseResponse](../../Models/Requests/RemoveLegalExpenseResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveLegalMatter

Deletes the LegalMatter identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeLegalMatter" method="delete" path="/legal/{connection_id}/matter/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Legal.RemoveLegalMatterAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Matter     |

### Response

**[RemoveLegalMatterResponse](../../Models/Requests/RemoveLegalMatterResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveLegalPracticearea

Deletes the LegalPracticearea identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeLegalPracticearea" method="delete" path="/legal/{connection_id}/practicearea/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Legal.RemoveLegalPracticeareaAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter              | Type                   | Required               | Description            |
| ---------------------- | ---------------------- | ---------------------- | ---------------------- |
| `ConnectionId`         | *string*               | :heavy_check_mark:     | ID of the connection   |
| `Id`                   | *string*               | :heavy_check_mark:     | ID of the Practicearea |

### Response

**[RemoveLegalPracticeareaResponse](../../Models/Requests/RemoveLegalPracticeareaResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveLegalTimeentry

Deletes the LegalTimeentry identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeLegalTimeentry" method="delete" path="/legal/{connection_id}/timeentry/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Legal.RemoveLegalTimeentryAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Timeentry  |

### Response

**[RemoveLegalTimeentryResponse](../../Models/Requests/RemoveLegalTimeentryResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateLegalExpense

Updates the LegalExpense identified by `id`. Provide the unified LegalExpense fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateLegalExpense" method="put" path="/legal/{connection_id}/expense/{id}" example="legal_expense" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateLegalExpenseRequest req = new UpdateLegalExpenseRequest() {
    LegalExpense = new LegalExpense() {
        Category = "Kids",
        CreatedAt = System.DateTime.Parse("2020-11-08T00:41:42.356Z").ToUniversalTime(),
        Currency = "MVR",
        Description = "Temporibus agnitio sui.",
        Id = "373a0e19-2a20-4659-9c3c-3ee8c3f1915e",
        IncurredAt = System.DateTime.Parse("2020-11-08T00:41:42.356Z").ToUniversalTime(),
        IsBilled = false,
        Metadata = new List<LegalMetadata>() {},
        PriceAmount = 100D,
        Quantity = 3D,
        TotalAmount = 300D,
        Type = LegalExpenseType.Other,
        UpdatedAt = System.DateTime.Parse("2024-04-03T23:26:15.353Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Legal.UpdateLegalExpenseAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [UpdateLegalExpenseRequest](../../Models/Requests/UpdateLegalExpenseRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[UpdateLegalExpenseResponse](../../Models/Requests/UpdateLegalExpenseResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateLegalMatter

Updates the LegalMatter identified by `id`. Provide the unified LegalMatter fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateLegalMatter" method="put" path="/legal/{connection_id}/matter/{id}" example="legal_matter" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateLegalMatterRequest req = new UpdateLegalMatterRequest() {
    LegalMatter = new LegalMatter() {
        BillingMethod = BillingMethod.Other,
        ClientReference = "qSrjIBAD",
        CompanyIds = new List<string>() {},
        ContactIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2023-05-28T04:10:42.375Z").ToUniversalTime(),
        Currency = "BOB",
        Description = "Speciosus cresco aut cotidie temeritas arma.",
        Id = "fdcb03ee-6d6d-4c7e-80d2-16cdf05f8b9f",
        Metadata = new List<LegalMetadata>() {},
        Name = "Walter v. Franecki - Spinka",
        Number = "2023-3062",
        OpenedAt = System.DateTime.Parse("2023-07-05T11:28:51.435Z").ToUniversalTime(),
        Parties = new List<LegalParty>() {
            new LegalParty() {
                Description = "Urban Walter",
                Role = LegalPartyRole.Expert,
            },
        },
        Stage = "currus",
        Status = LegalMatterStatus.Open,
        StatuteOfLimitationsAt = System.DateTime.Parse("2027-07-05T21:43:16.844Z").ToUniversalTime(),
        UpdatedAt = System.DateTime.Parse("2023-07-17T16:54:31.441Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Legal.UpdateLegalMatterAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [UpdateLegalMatterRequest](../../Models/Requests/UpdateLegalMatterRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[UpdateLegalMatterResponse](../../Models/Requests/UpdateLegalMatterResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateLegalPracticearea

Updates the LegalPracticearea identified by `id`. Provide the unified LegalPracticearea fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateLegalPracticearea" method="put" path="/legal/{connection_id}/practicearea/{id}" example="legal_practicearea" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateLegalPracticeareaRequest req = new UpdateLegalPracticeareaRequest() {
    LegalPracticearea = new LegalPracticearea() {
        Code = "QCA",
        CreatedAt = System.DateTime.Parse("2023-01-28T21:00:26.264Z").ToUniversalTime(),
        Id = "76d118c6-c14b-4385-a15b-c6dedb216258",
        Metadata = new List<LegalMetadata>() {},
        Name = "witty Law",
        Type = LegalPracticeareaType.Education,
        UpdatedAt = System.DateTime.Parse("2025-09-01T13:45:17.437Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Legal.UpdateLegalPracticeareaAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [UpdateLegalPracticeareaRequest](../../Models/Requests/UpdateLegalPracticeareaRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[UpdateLegalPracticeareaResponse](../../Models/Requests/UpdateLegalPracticeareaResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateLegalTimeentry

Updates the LegalTimeentry identified by `id`. Provide the unified LegalTimeentry fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateLegalTimeentry" method="put" path="/legal/{connection_id}/timeentry/{id}" example="legal_timeentry" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateLegalTimeentryRequest req = new UpdateLegalTimeentryRequest() {
    LegalTimeentry = new LegalTimeentry() {
        BillableMinutes = 390D,
        CreatedAt = System.DateTime.Parse("2022-05-06T03:26:03.756Z").ToUniversalTime(),
        Currency = "ZAR",
        Description = "Ea derideo adulatio torrens.",
        Id = "43f1b863-23f2-473c-be13-faaec4490600",
        IsBillable = true,
        Metadata = new List<LegalMetadata>() {},
        Minutes = 390D,
        RateAmount = 637D,
        TotalAmount = 4140.5D,
        UpdatedAt = System.DateTime.Parse("2022-06-30T07:30:26.606Z").ToUniversalTime(),
        WorkedAt = System.DateTime.Parse("2022-05-06T03:26:03.756Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Legal.UpdateLegalTimeentryAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [UpdateLegalTimeentryRequest](../../Models/Requests/UpdateLegalTimeentryRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[UpdateLegalTimeentryResponse](../../Models/Requests/UpdateLegalTimeentryResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |