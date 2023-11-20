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
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "",
    }
);

var res = await sdk.Deal.CreateCrmDealAsync("string", new CrmDeal() {
    Raw = new PropertyCrmDealRaw() {},
    Tags = new List<string>() {
        "string",
    },
});

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `ConnectionId`                                                  | *string*                                                        | :heavy_check_mark:                                              | ID of the connection                                            |
| `CrmDeal`                                                       | [CrmDeal](../../Models/Components/CrmDeal.md)                   | :heavy_minus_sign:                                              | A deal represents an opportunity with companies and/or contacts |


### Response

**[CreateCrmDealResponse](../../Models/Requests/CreateCrmDealResponse.md)**


## GetCrmDeal

Retrieve a deal

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "",
    }
);

var res = await sdk.Deal.GetCrmDealAsync("string", "string", new List<string>() {
    "string",
});

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Deal                   |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetCrmDealResponse](../../Models/Requests/GetCrmDealResponse.md)**


## ListCrmDeals

List all deals

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "",
    }
);

var res = await sdk.Deal.ListCrmDealsAsync(new ListCrmDealsRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
});

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [ListCrmDealsRequest](../../Models/Requests/ListCrmDealsRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |


### Response

**[ListCrmDealsResponse](../../Models/Requests/ListCrmDealsResponse.md)**


## PatchCrmDeal

Update a deal

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "",
    }
);

var res = await sdk.Deal.PatchCrmDealAsync("string", "string", new CrmDeal() {
    Raw = new PropertyCrmDealRaw() {},
    Tags = new List<string>() {
        "string",
    },
});

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `ConnectionId`                                                  | *string*                                                        | :heavy_check_mark:                                              | ID of the connection                                            |
| `Id`                                                            | *string*                                                        | :heavy_check_mark:                                              | ID of the Deal                                                  |
| `CrmDeal`                                                       | [CrmDeal](../../Models/Components/CrmDeal.md)                   | :heavy_minus_sign:                                              | A deal represents an opportunity with companies and/or contacts |


### Response

**[PatchCrmDealResponse](../../Models/Requests/PatchCrmDealResponse.md)**


## RemoveCrmDeal

Remove a deal

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "",
    }
);

var res = await sdk.Deal.RemoveCrmDealAsync("string", "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Deal       |


### Response

**[RemoveCrmDealResponse](../../Models/Requests/RemoveCrmDealResponse.md)**


## UpdateCrmDeal

Update a deal

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "",
    }
);

var res = await sdk.Deal.UpdateCrmDealAsync("string", "string", new CrmDeal() {
    Raw = new PropertyCrmDealRaw() {},
    Tags = new List<string>() {
        "string",
    },
});

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `ConnectionId`                                                  | *string*                                                        | :heavy_check_mark:                                              | ID of the connection                                            |
| `Id`                                                            | *string*                                                        | :heavy_check_mark:                                              | ID of the Deal                                                  |
| `CrmDeal`                                                       | [CrmDeal](../../Models/Components/CrmDeal.md)                   | :heavy_minus_sign:                                              | A deal represents an opportunity with companies and/or contacts |


### Response

**[UpdateCrmDealResponse](../../Models/Requests/UpdateCrmDealResponse.md)**

