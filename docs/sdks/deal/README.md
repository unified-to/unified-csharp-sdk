# Deal
(*Deal*)

### Available Operations

* [CreateCrmDeal](#createcrmdeal) - Create a deal
* [GetCrmDeal](#getcrmdeal) - Retrieve a deal
* [ListCrmDeals](#listcrmdeals) - List all deals
* [PatchCrmDeal](#patchcrmdeal) - Update a deal
* [RemoveCrmDeal](#removecrmdeal) - Remove a deal
* [UpdateCrmDeal](#updatecrmdeal) - Update a deal

## CreateCrmDeal

Create a deal

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Deal.CreateCrmDealAsync(
    security: new CreateCrmDealSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    crmDeal: new CrmDeal() {});

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `security`                                                                                        | [UnifiedTo.Models.Requests.CreateCrmDealSecurity](../../Models/Requests/CreateCrmDealSecurity.md) | :heavy_check_mark:                                                                                | The security requirements to use for the request.                                                 |
| `ConnectionId`                                                                                    | *string*                                                                                          | :heavy_check_mark:                                                                                | ID of the connection                                                                              |
| `CrmDeal`                                                                                         | [CrmDeal](../../Models/Components/CrmDeal.md)                                                     | :heavy_minus_sign:                                                                                | A deal represents an opportunity with companies and/or contacts                                   |


### Response

**[CreateCrmDealResponse](../../Models/Requests/CreateCrmDealResponse.md)**


## GetCrmDeal

Retrieve a deal

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Deal.GetCrmDealAsync(
    security: new GetCrmDealSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    fields: new List<string>() {
    "<value>",
});

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `security`                                                                                  | [UnifiedTo.Models.Requests.GetCrmDealSecurity](../../Models/Requests/GetCrmDealSecurity.md) | :heavy_check_mark:                                                                          | The security requirements to use for the request.                                           |
| `ConnectionId`                                                                              | *string*                                                                                    | :heavy_check_mark:                                                                          | ID of the connection                                                                        |
| `Id`                                                                                        | *string*                                                                                    | :heavy_check_mark:                                                                          | ID of the Deal                                                                              |
| `Fields`                                                                                    | List<*string*>                                                                              | :heavy_minus_sign:                                                                          | Comma-delimited fields to return                                                            |


### Response

**[GetCrmDealResponse](../../Models/Requests/GetCrmDealResponse.md)**


## ListCrmDeals

List all deals

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListCrmDealsRequest req = new ListCrmDealsRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Deal.ListCrmDealsAsync(
    security: new ListCrmDealsSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [ListCrmDealsRequest](../../Models/Requests/ListCrmDealsRequest.md)                             | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |
| `security`                                                                                      | [UnifiedTo.Models.Requests.ListCrmDealsSecurity](../../Models/Requests/ListCrmDealsSecurity.md) | :heavy_check_mark:                                                                              | The security requirements to use for the request.                                               |


### Response

**[ListCrmDealsResponse](../../Models/Requests/ListCrmDealsResponse.md)**


## PatchCrmDeal

Update a deal

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Deal.PatchCrmDealAsync(
    security: new PatchCrmDealSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    crmDeal: new CrmDeal() {});

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `security`                                                                                      | [UnifiedTo.Models.Requests.PatchCrmDealSecurity](../../Models/Requests/PatchCrmDealSecurity.md) | :heavy_check_mark:                                                                              | The security requirements to use for the request.                                               |
| `ConnectionId`                                                                                  | *string*                                                                                        | :heavy_check_mark:                                                                              | ID of the connection                                                                            |
| `Id`                                                                                            | *string*                                                                                        | :heavy_check_mark:                                                                              | ID of the Deal                                                                                  |
| `CrmDeal`                                                                                       | [CrmDeal](../../Models/Components/CrmDeal.md)                                                   | :heavy_minus_sign:                                                                              | A deal represents an opportunity with companies and/or contacts                                 |


### Response

**[PatchCrmDealResponse](../../Models/Requests/PatchCrmDealResponse.md)**


## RemoveCrmDeal

Remove a deal

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Deal.RemoveCrmDealAsync(
    security: new RemoveCrmDealSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `security`                                                                                        | [UnifiedTo.Models.Requests.RemoveCrmDealSecurity](../../Models/Requests/RemoveCrmDealSecurity.md) | :heavy_check_mark:                                                                                | The security requirements to use for the request.                                                 |
| `ConnectionId`                                                                                    | *string*                                                                                          | :heavy_check_mark:                                                                                | ID of the connection                                                                              |
| `Id`                                                                                              | *string*                                                                                          | :heavy_check_mark:                                                                                | ID of the Deal                                                                                    |


### Response

**[RemoveCrmDealResponse](../../Models/Requests/RemoveCrmDealResponse.md)**


## UpdateCrmDeal

Update a deal

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Deal.UpdateCrmDealAsync(
    security: new UpdateCrmDealSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    crmDeal: new CrmDeal() {});

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `security`                                                                                        | [UnifiedTo.Models.Requests.UpdateCrmDealSecurity](../../Models/Requests/UpdateCrmDealSecurity.md) | :heavy_check_mark:                                                                                | The security requirements to use for the request.                                                 |
| `ConnectionId`                                                                                    | *string*                                                                                          | :heavy_check_mark:                                                                                | ID of the connection                                                                              |
| `Id`                                                                                              | *string*                                                                                          | :heavy_check_mark:                                                                                | ID of the Deal                                                                                    |
| `CrmDeal`                                                                                         | [CrmDeal](../../Models/Components/CrmDeal.md)                                                     | :heavy_minus_sign:                                                                                | A deal represents an opportunity with companies and/or contacts                                   |


### Response

**[UpdateCrmDealResponse](../../Models/Requests/UpdateCrmDealResponse.md)**

