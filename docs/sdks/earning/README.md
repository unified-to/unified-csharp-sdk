# Earning

## Overview

### Available Operations

* [CreateHrisEarning](#createhrisearning) - Create an earning
* [GetHrisEarning](#gethrisearning) - Retrieve an earning
* [ListHrisEarnings](#listhrisearnings) - List all earnings
* [PatchHrisEarning](#patchhrisearning) - Update an earning
* [RemoveHrisEarning](#removehrisearning) - Remove an earning
* [UpdateHrisEarning](#updatehrisearning) - Update an earning

## CreateHrisEarning

Create an earning

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createHrisEarning" method="post" path="/hris/{connection_id}/earning" example="hris_earning" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Earning.CreateHrisEarningAsync(
    hrisEarning: new HrisEarning() {
        Amount = 4026D,
        CreatedAt = System.DateTime.Parse("2019-01-26T12:44:52.326Z").ToUniversalTime(),
        Currency = "PKR",
        Frequency = HrisEarningFrequency.Biweekly,
        Id = "4b96d4b2-b271-4a33-89a4-d98ad9037cfe",
        Notes = "Truculenter vinum beatae.",
        StartAt = System.DateTime.Parse("2022-07-23T05:50:28.600Z").ToUniversalTime(),
        Status = HrisEarningStatus.Processed,
        UpdatedAt = System.DateTime.Parse("2020-02-08T04:32:42.065Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `HrisEarning`                                                                                                                                    | [HrisEarning](../../Models/Components/HrisEarning.md)                                                                                            | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateHrisEarningQueryParamFields](../../Models/Requests/CreateHrisEarningQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateHrisEarningResponse](../../Models/Requests/CreateHrisEarningResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetHrisEarning

Retrieve an earning

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHrisEarning" method="get" path="/hris/{connection_id}/earning/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Earning.GetHrisEarningAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Earning                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetHrisEarningQueryParamFields](../../Models/Requests/GetHrisEarningQueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHrisEarningResponse](../../Models/Requests/GetHrisEarningResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListHrisEarnings

List all earnings

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listHrisEarnings" method="get" path="/hris/{connection_id}/earning" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHrisEarningsRequest req = new ListHrisEarningsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Earning.ListHrisEarningsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListHrisEarningsRequest](../../Models/Requests/ListHrisEarningsRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[ListHrisEarningsResponse](../../Models/Requests/ListHrisEarningsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchHrisEarning

Update an earning

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchHrisEarning" method="patch" path="/hris/{connection_id}/earning/{id}" example="hris_earning" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchHrisEarningRequest req = new PatchHrisEarningRequest() {
    HrisEarning = new HrisEarning() {
        Amount = 4026D,
        CreatedAt = System.DateTime.Parse("2019-01-26T12:44:52.326Z").ToUniversalTime(),
        Currency = "PKR",
        Frequency = HrisEarningFrequency.Biweekly,
        Id = "72b97916-3a1f-4c2f-98a9-236b2b0f52fd",
        Notes = "Truculenter vinum beatae.",
        StartAt = System.DateTime.Parse("2022-07-23T05:50:28.605Z").ToUniversalTime(),
        Status = HrisEarningStatus.Processed,
        UpdatedAt = System.DateTime.Parse("2020-02-08T04:32:42.066Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Earning.PatchHrisEarningAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [PatchHrisEarningRequest](../../Models/Requests/PatchHrisEarningRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[PatchHrisEarningResponse](../../Models/Requests/PatchHrisEarningResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveHrisEarning

Remove an earning

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeHrisEarning" method="delete" path="/hris/{connection_id}/earning/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Earning.RemoveHrisEarningAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Earning    |

### Response

**[RemoveHrisEarningResponse](../../Models/Requests/RemoveHrisEarningResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateHrisEarning

Update an earning

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateHrisEarning" method="put" path="/hris/{connection_id}/earning/{id}" example="hris_earning" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateHrisEarningRequest req = new UpdateHrisEarningRequest() {
    HrisEarning = new HrisEarning() {
        Amount = 4026D,
        CreatedAt = System.DateTime.Parse("2019-01-26T12:44:52.326Z").ToUniversalTime(),
        Currency = "PKR",
        Frequency = HrisEarningFrequency.Biweekly,
        Id = "72b97916-3a1f-4c2f-98a9-236b2b0f52fd",
        Notes = "Truculenter vinum beatae.",
        StartAt = System.DateTime.Parse("2022-07-23T05:50:28.605Z").ToUniversalTime(),
        Status = HrisEarningStatus.Processed,
        UpdatedAt = System.DateTime.Parse("2020-02-08T04:32:42.066Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Earning.UpdateHrisEarningAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [UpdateHrisEarningRequest](../../Models/Requests/UpdateHrisEarningRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[UpdateHrisEarningResponse](../../Models/Requests/UpdateHrisEarningResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |