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

Create an expense

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
        Id = "a3ef8abf-1870-4d60-861d-6aa48dd8ea4d",
        IncurredAt = System.DateTime.Parse("2020-11-08T00:41:42.356Z").ToUniversalTime(),
        IsBilled = false,
        Metadata = new List<LegalMetadata>() {},
        PriceAmount = 100D,
        Quantity = 3D,
        TotalAmount = 300D,
        Type = LegalExpenseType.Other,
        UpdatedAt = System.DateTime.Parse("2024-03-25T18:38:13.648Z").ToUniversalTime(),
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

Create a matter

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
        Id = "628b3058-3c9b-4db6-b454-8075ff8df3d4",
        Metadata = new List<LegalMetadata>() {},
        Name = "Walter v. Franecki - Spinka",
        Number = "2023-3062",
        OpenedAt = System.DateTime.Parse("2023-07-04T23:36:10.761Z").ToUniversalTime(),
        Parties = new List<LegalParty>() {
            new LegalParty() {
                Description = "Urban Walter",
                Role = LegalPartyRole.Expert,
            },
        },
        Stage = "currus",
        Status = LegalMatterStatus.Open,
        StatuteOfLimitationsAt = System.DateTime.Parse("2027-06-19T18:27:51.031Z").ToUniversalTime(),
        UpdatedAt = System.DateTime.Parse("2023-07-17T01:14:22.191Z").ToUniversalTime(),
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

Create a practicearea

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
        Id = "ad7226cf-494f-44e1-8c0e-8d4825876143",
        Metadata = new List<LegalMetadata>() {},
        Name = "witty Law",
        Type = LegalPracticeareaType.Education,
        UpdatedAt = System.DateTime.Parse("2025-08-21T09:47:13.242Z").ToUniversalTime(),
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

Create a timeentry

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
        Id = "ee81f4c5-dbb1-45a6-afb2-8340e3ec0b68",
        IsBillable = true,
        Metadata = new List<LegalMetadata>() {},
        Minutes = 390D,
        RateAmount = 637D,
        TotalAmount = 4140.5D,
        UpdatedAt = System.DateTime.Parse("2022-06-29T18:26:49.568Z").ToUniversalTime(),
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

Retrieve an expense

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

Retrieve a matter

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

Retrieve a practicearea

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

Retrieve a timeentry

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

List all expenses

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

List all matters

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

List all practiceareas

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

List all timeentries

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

Update an expense

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
        Id = "6ee14eb0-054a-4b7c-b3c6-0edfbaf1a550",
        IncurredAt = System.DateTime.Parse("2020-11-08T00:41:42.356Z").ToUniversalTime(),
        IsBilled = false,
        Metadata = new List<LegalMetadata>() {},
        PriceAmount = 100D,
        Quantity = 3D,
        TotalAmount = 300D,
        Type = LegalExpenseType.Other,
        UpdatedAt = System.DateTime.Parse("2024-03-25T18:38:13.658Z").ToUniversalTime(),
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

Update a matter

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
        Id = "9bc6add8-1af0-46b5-8f4a-1ac56a3c2b28",
        Metadata = new List<LegalMetadata>() {},
        Name = "Walter v. Franecki - Spinka",
        Number = "2023-3062",
        OpenedAt = System.DateTime.Parse("2023-07-04T23:36:10.762Z").ToUniversalTime(),
        Parties = new List<LegalParty>() {
            new LegalParty() {
                Description = "Urban Walter",
                Role = LegalPartyRole.Expert,
            },
        },
        Stage = "currus",
        Status = LegalMatterStatus.Open,
        StatuteOfLimitationsAt = System.DateTime.Parse("2027-06-19T18:27:51.058Z").ToUniversalTime(),
        UpdatedAt = System.DateTime.Parse("2023-07-17T01:14:22.193Z").ToUniversalTime(),
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

Update a practicearea

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
        Id = "47f4aa40-dbc4-42d9-b868-973e28198863",
        Metadata = new List<LegalMetadata>() {},
        Name = "witty Law",
        Type = LegalPracticeareaType.Education,
        UpdatedAt = System.DateTime.Parse("2025-08-21T09:47:13.256Z").ToUniversalTime(),
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

Update a timeentry

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
        Id = "35a99b2b-fcdc-4da2-9791-64e524cf4317",
        IsBillable = true,
        Metadata = new List<LegalMetadata>() {},
        Minutes = 390D,
        RateAmount = 637D,
        TotalAmount = 4140.5D,
        UpdatedAt = System.DateTime.Parse("2022-06-29T18:26:49.569Z").ToUniversalTime(),
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

Remove an expense

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

Remove a matter

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

Remove a practicearea

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

Remove a timeentry

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

Update an expense

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
        Id = "6ee14eb0-054a-4b7c-b3c6-0edfbaf1a550",
        IncurredAt = System.DateTime.Parse("2020-11-08T00:41:42.356Z").ToUniversalTime(),
        IsBilled = false,
        Metadata = new List<LegalMetadata>() {},
        PriceAmount = 100D,
        Quantity = 3D,
        TotalAmount = 300D,
        Type = LegalExpenseType.Other,
        UpdatedAt = System.DateTime.Parse("2024-03-25T18:38:13.658Z").ToUniversalTime(),
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

Update a matter

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
        Id = "9bc6add8-1af0-46b5-8f4a-1ac56a3c2b28",
        Metadata = new List<LegalMetadata>() {},
        Name = "Walter v. Franecki - Spinka",
        Number = "2023-3062",
        OpenedAt = System.DateTime.Parse("2023-07-04T23:36:10.762Z").ToUniversalTime(),
        Parties = new List<LegalParty>() {
            new LegalParty() {
                Description = "Urban Walter",
                Role = LegalPartyRole.Expert,
            },
        },
        Stage = "currus",
        Status = LegalMatterStatus.Open,
        StatuteOfLimitationsAt = System.DateTime.Parse("2027-06-19T18:27:51.058Z").ToUniversalTime(),
        UpdatedAt = System.DateTime.Parse("2023-07-17T01:14:22.193Z").ToUniversalTime(),
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

Update a practicearea

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
        Id = "47f4aa40-dbc4-42d9-b868-973e28198863",
        Metadata = new List<LegalMetadata>() {},
        Name = "witty Law",
        Type = LegalPracticeareaType.Education,
        UpdatedAt = System.DateTime.Parse("2025-08-21T09:47:13.256Z").ToUniversalTime(),
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

Update a timeentry

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
        Id = "35a99b2b-fcdc-4da2-9791-64e524cf4317",
        IsBillable = true,
        Metadata = new List<LegalMetadata>() {},
        Minutes = 390D,
        RateAmount = 637D,
        TotalAmount = 4140.5D,
        UpdatedAt = System.DateTime.Parse("2022-06-29T18:26:49.569Z").ToUniversalTime(),
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