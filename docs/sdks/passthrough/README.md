# Passthrough
(*Passthrough*)

### Available Operations

* [CreatePassthrough](#createpassthrough) - Passthrough POST
* [ListPassthroughs](#listpassthroughs) - Passthrough GET
* [PatchPassthrough](#patchpassthrough) - Passthrough PUT
* [RemovePassthrough](#removepassthrough) - Passthrough DELETE
* [UpdatePassthrough](#updatepassthrough) - Passthrough PUT

## CreatePassthrough

Passthrough POST

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Passthrough.CreatePassthroughAsync(
    security: new CreatePassthroughSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    path: "<value>",
    requestBody: new Dictionary<string, object>() {
    { "key", "<value>" },
});

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                | [UnifiedTo.Models.Requests.CreatePassthroughSecurity](../../Models/Requests/CreatePassthroughSecurity.md) | :heavy_check_mark:                                                                                        | The security requirements to use for the request.                                                         |
| `ConnectionId`                                                                                            | *string*                                                                                                  | :heavy_check_mark:                                                                                        | ID of the connection                                                                                      |
| `Path`                                                                                                    | *string*                                                                                                  | :heavy_check_mark:                                                                                        | N/A                                                                                                       |
| `RequestBody`                                                                                             | Dictionary<String, *object*>                                                                              | :heavy_minus_sign:                                                                                        | integration-specific payload                                                                              |


### Response

**[CreatePassthroughResponse](../../Models/Requests/CreatePassthroughResponse.md)**


## ListPassthroughs

Passthrough GET

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Passthrough.ListPassthroughsAsync(
    security: new ListPassthroughsSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    path: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `security`                                                                                              | [UnifiedTo.Models.Requests.ListPassthroughsSecurity](../../Models/Requests/ListPassthroughsSecurity.md) | :heavy_check_mark:                                                                                      | The security requirements to use for the request.                                                       |
| `ConnectionId`                                                                                          | *string*                                                                                                | :heavy_check_mark:                                                                                      | ID of the connection                                                                                    |
| `Path`                                                                                                  | *string*                                                                                                | :heavy_check_mark:                                                                                      | N/A                                                                                                     |


### Response

**[ListPassthroughsResponse](../../Models/Requests/ListPassthroughsResponse.md)**


## PatchPassthrough

Passthrough PUT

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Passthrough.PatchPassthroughAsync(
    security: new PatchPassthroughSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    path: "<value>",
    requestBody: new Dictionary<string, object>() {
    { "key", "<value>" },
});

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `security`                                                                                              | [UnifiedTo.Models.Requests.PatchPassthroughSecurity](../../Models/Requests/PatchPassthroughSecurity.md) | :heavy_check_mark:                                                                                      | The security requirements to use for the request.                                                       |
| `ConnectionId`                                                                                          | *string*                                                                                                | :heavy_check_mark:                                                                                      | ID of the connection                                                                                    |
| `Path`                                                                                                  | *string*                                                                                                | :heavy_check_mark:                                                                                      | N/A                                                                                                     |
| `RequestBody`                                                                                           | Dictionary<String, *object*>                                                                            | :heavy_minus_sign:                                                                                      | integration-specific payload                                                                            |


### Response

**[PatchPassthroughResponse](../../Models/Requests/PatchPassthroughResponse.md)**


## RemovePassthrough

Passthrough DELETE

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Passthrough.RemovePassthroughAsync(
    security: new RemovePassthroughSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    path: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                | [UnifiedTo.Models.Requests.RemovePassthroughSecurity](../../Models/Requests/RemovePassthroughSecurity.md) | :heavy_check_mark:                                                                                        | The security requirements to use for the request.                                                         |
| `ConnectionId`                                                                                            | *string*                                                                                                  | :heavy_check_mark:                                                                                        | ID of the connection                                                                                      |
| `Path`                                                                                                    | *string*                                                                                                  | :heavy_check_mark:                                                                                        | N/A                                                                                                       |


### Response

**[RemovePassthroughResponse](../../Models/Requests/RemovePassthroughResponse.md)**


## UpdatePassthrough

Passthrough PUT

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Passthrough.UpdatePassthroughAsync(
    security: new UpdatePassthroughSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    path: "<value>",
    requestBody: new Dictionary<string, object>() {
    { "key", "<value>" },
});

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                | [UnifiedTo.Models.Requests.UpdatePassthroughSecurity](../../Models/Requests/UpdatePassthroughSecurity.md) | :heavy_check_mark:                                                                                        | The security requirements to use for the request.                                                         |
| `ConnectionId`                                                                                            | *string*                                                                                                  | :heavy_check_mark:                                                                                        | ID of the connection                                                                                      |
| `Path`                                                                                                    | *string*                                                                                                  | :heavy_check_mark:                                                                                        | N/A                                                                                                       |
| `RequestBody`                                                                                             | Dictionary<String, *object*>                                                                              | :heavy_minus_sign:                                                                                        | integration-specific payload                                                                              |


### Response

**[UpdatePassthroughResponse](../../Models/Requests/UpdatePassthroughResponse.md)**

