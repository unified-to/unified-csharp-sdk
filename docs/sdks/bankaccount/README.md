# Bankaccount
(*Bankaccount*)

## Overview

### Available Operations

* [CreateHrisBankaccount](#createhrisbankaccount) - Create a bankaccount
* [GetHrisBankaccount](#gethrisbankaccount) - Retrieve a bankaccount
* [ListHrisBankaccounts](#listhrisbankaccounts) - List all bankaccounts
* [PatchHrisBankaccount](#patchhrisbankaccount) - Update a bankaccount
* [RemoveHrisBankaccount](#removehrisbankaccount) - Remove a bankaccount
* [UpdateHrisBankaccount](#updatehrisbankaccount) - Update a bankaccount

## CreateHrisBankaccount

Create a bankaccount

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Bankaccount.CreateHrisBankaccountAsync(
    hrisBankaccount: new HrisBankaccount() {},
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `HrisBankaccount`                                                                                                                                | [HrisBankaccount](../../Models/Components/HrisBankaccount.md)                                                                                    | :heavy_check_mark:                                                                                                                               | Employee payroll bank account for direct deposit.                                                                                                |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateHrisBankaccountQueryParamFields](../../Models/Requests/CreateHrisBankaccountQueryParamFields.md)>                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateHrisBankaccountResponse](../../Models/Requests/CreateHrisBankaccountResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetHrisBankaccount

Retrieve a bankaccount

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Bankaccount.GetHrisBankaccountAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Bankaccount                                                                                                                            |
| `Fields`                                                                                                                                         | List<[GetHrisBankaccountQueryParamFields](../../Models/Requests/GetHrisBankaccountQueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHrisBankaccountResponse](../../Models/Requests/GetHrisBankaccountResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListHrisBankaccounts

List all bankaccounts

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHrisBankaccountsRequest req = new ListHrisBankaccountsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Bankaccount.ListHrisBankaccountsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [ListHrisBankaccountsRequest](../../Models/Requests/ListHrisBankaccountsRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[ListHrisBankaccountsResponse](../../Models/Requests/ListHrisBankaccountsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchHrisBankaccount

Update a bankaccount

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchHrisBankaccountRequest req = new PatchHrisBankaccountRequest() {
    HrisBankaccount = new HrisBankaccount() {},
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Bankaccount.PatchHrisBankaccountAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [PatchHrisBankaccountRequest](../../Models/Requests/PatchHrisBankaccountRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[PatchHrisBankaccountResponse](../../Models/Requests/PatchHrisBankaccountResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveHrisBankaccount

Remove a bankaccount

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Bankaccount.RemoveHrisBankaccountAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter             | Type                  | Required              | Description           |
| --------------------- | --------------------- | --------------------- | --------------------- |
| `ConnectionId`        | *string*              | :heavy_check_mark:    | ID of the connection  |
| `Id`                  | *string*              | :heavy_check_mark:    | ID of the Bankaccount |

### Response

**[RemoveHrisBankaccountResponse](../../Models/Requests/RemoveHrisBankaccountResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateHrisBankaccount

Update a bankaccount

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateHrisBankaccountRequest req = new UpdateHrisBankaccountRequest() {
    HrisBankaccount = new HrisBankaccount() {},
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Bankaccount.UpdateHrisBankaccountAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [UpdateHrisBankaccountRequest](../../Models/Requests/UpdateHrisBankaccountRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[UpdateHrisBankaccountResponse](../../Models/Requests/UpdateHrisBankaccountResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |