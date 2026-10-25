# Timeentry

## Overview

### Available Operations

* [CreateLegalTimeentry](#createlegaltimeentry) - Create a timeentry
* [GetLegalTimeentry](#getlegaltimeentry) - Retrieve a timeentry
* [ListLegalTimeentries](#listlegaltimeentries) - List all timeentries
* [PatchLegalTimeentry](#patchlegaltimeentry) - Update a timeentry
* [RemoveLegalTimeentry](#removelegaltimeentry) - Remove a timeentry
* [UpdateLegalTimeentry](#updatelegaltimeentry) - Update a timeentry

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

var res = await sdk.Timeentry.CreateLegalTimeentryAsync(
    legalTimeentry: new LegalTimeentry() {
        BillableMinutes = 390D,
        CreatedAt = System.DateTime.Parse("2022-05-06T03:26:03.756Z").ToUniversalTime(),
        Currency = "ZAR",
        Description = "Ea derideo adulatio torrens.",
        Id = "7d9e9e41-7745-4f7a-8baf-1451551281d4",
        IsBillable = true,
        Metadata = new List<LegalMetadata>() {},
        Minutes = 390D,
        RateAmount = 637D,
        TotalAmount = 4140.5D,
        UpdatedAt = System.DateTime.Parse("2022-06-30T05:02:41.261Z").ToUniversalTime(),
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

var res = await sdk.Timeentry.GetLegalTimeentryAsync(
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

var res = await sdk.Timeentry.ListLegalTimeentriesAsync(req);

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
        Id = "72d6876e-6d35-43c9-929a-e49874bbb49d",
        IsBillable = true,
        Metadata = new List<LegalMetadata>() {},
        Minutes = 390D,
        RateAmount = 637D,
        TotalAmount = 4140.5D,
        UpdatedAt = System.DateTime.Parse("2022-06-30T05:02:41.261Z").ToUniversalTime(),
        WorkedAt = System.DateTime.Parse("2022-05-06T03:26:03.756Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Timeentry.PatchLegalTimeentryAsync(req);

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

var res = await sdk.Timeentry.RemoveLegalTimeentryAsync(
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
        Id = "72d6876e-6d35-43c9-929a-e49874bbb49d",
        IsBillable = true,
        Metadata = new List<LegalMetadata>() {},
        Minutes = 390D,
        RateAmount = 637D,
        TotalAmount = 4140.5D,
        UpdatedAt = System.DateTime.Parse("2022-06-30T05:02:41.261Z").ToUniversalTime(),
        WorkedAt = System.DateTime.Parse("2022-05-06T03:26:03.756Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Timeentry.UpdateLegalTimeentryAsync(req);

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