# Matter

## Overview

### Available Operations

* [CreateLegalMatter](#createlegalmatter) - Create a matter
* [GetLegalMatter](#getlegalmatter) - Retrieve a matter
* [ListLegalMatters](#listlegalmatters) - List all matters
* [PatchLegalMatter](#patchlegalmatter) - Update a matter
* [RemoveLegalMatter](#removelegalmatter) - Remove a matter
* [UpdateLegalMatter](#updatelegalmatter) - Update a matter

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

var res = await sdk.Matter.CreateLegalMatterAsync(
    legalMatter: new LegalMatter() {
        BillingMethod = BillingMethod.Other,
        ClientReference = "qSrjIBAD",
        CompanyIds = new List<string>() {},
        ContactIds = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2023-05-28T04:10:42.375Z").ToUniversalTime(),
        Currency = "BOB",
        Description = "Speciosus cresco aut cotidie temeritas arma.",
        Id = "dc3b7015-bcb4-4792-9e7c-4bd989baec48",
        Metadata = new List<LegalMetadata>() {},
        Name = "Walter v. Franecki - Spinka",
        Number = "2023-3062",
        OpenedAt = System.DateTime.Parse("2023-07-05T03:23:17.171Z").ToUniversalTime(),
        Parties = new List<LegalParty>() {
            new LegalParty() {
                Description = "Urban Walter",
                Role = LegalPartyRole.Expert,
            },
        },
        Stage = "currus",
        Status = LegalMatterStatus.Open,
        StatuteOfLimitationsAt = System.DateTime.Parse("2027-06-24T21:52:12.709Z").ToUniversalTime(),
        UpdatedAt = System.DateTime.Parse("2023-07-17T06:13:57.950Z").ToUniversalTime(),
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

var res = await sdk.Matter.GetLegalMatterAsync(
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

var res = await sdk.Matter.ListLegalMattersAsync(req);

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
        Id = "1e511922-2ff3-4b52-af4f-9bcd4c76ba34",
        Metadata = new List<LegalMetadata>() {},
        Name = "Walter v. Franecki - Spinka",
        Number = "2023-3062",
        OpenedAt = System.DateTime.Parse("2023-07-05T03:23:17.171Z").ToUniversalTime(),
        Parties = new List<LegalParty>() {
            new LegalParty() {
                Description = "Urban Walter",
                Role = LegalPartyRole.Expert,
            },
        },
        Stage = "currus",
        Status = LegalMatterStatus.Open,
        StatuteOfLimitationsAt = System.DateTime.Parse("2027-06-24T21:52:12.739Z").ToUniversalTime(),
        UpdatedAt = System.DateTime.Parse("2023-07-17T06:13:57.950Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Matter.PatchLegalMatterAsync(req);

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

var res = await sdk.Matter.RemoveLegalMatterAsync(
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
        Id = "1e511922-2ff3-4b52-af4f-9bcd4c76ba34",
        Metadata = new List<LegalMetadata>() {},
        Name = "Walter v. Franecki - Spinka",
        Number = "2023-3062",
        OpenedAt = System.DateTime.Parse("2023-07-05T03:23:17.171Z").ToUniversalTime(),
        Parties = new List<LegalParty>() {
            new LegalParty() {
                Description = "Urban Walter",
                Role = LegalPartyRole.Expert,
            },
        },
        Stage = "currus",
        Status = LegalMatterStatus.Open,
        StatuteOfLimitationsAt = System.DateTime.Parse("2027-06-24T21:52:12.739Z").ToUniversalTime(),
        UpdatedAt = System.DateTime.Parse("2023-07-17T06:13:57.950Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Matter.UpdateLegalMatterAsync(req);

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