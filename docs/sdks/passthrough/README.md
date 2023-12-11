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
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Passthrough.CreatePassthroughAsync(ConnectionId: "string", Path: "string", Undefined: new Undefined() {});

// handle response
```

### Parameters

| Parameter                                         | Type                                              | Required                                          | Description                                       |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| `ConnectionId`                                    | *string*                                          | :heavy_check_mark:                                | ID of the connection                              |
| `Path`                                            | *string*                                          | :heavy_check_mark:                                | N/A                                               |
| `Undefined`                                       | [Undefined](../../Models/Components/Undefined.md) | :heavy_minus_sign:                                | integration-specific payload                      |


### Response

**[CreatePassthroughResponse](../../Models/Requests/CreatePassthroughResponse.md)**


## ListPassthroughs

Passthrough GET

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Passthrough.ListPassthroughsAsync(ConnectionId: "string", Path: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Path`               | *string*             | :heavy_check_mark:   | N/A                  |


### Response

**[ListPassthroughsResponse](../../Models/Requests/ListPassthroughsResponse.md)**


## PatchPassthrough

Passthrough PUT

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Passthrough.PatchPassthroughAsync(ConnectionId: "string", Path: "string", Undefined: new Undefined() {});

// handle response
```

### Parameters

| Parameter                                         | Type                                              | Required                                          | Description                                       |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| `ConnectionId`                                    | *string*                                          | :heavy_check_mark:                                | ID of the connection                              |
| `Path`                                            | *string*                                          | :heavy_check_mark:                                | N/A                                               |
| `Undefined`                                       | [Undefined](../../Models/Components/Undefined.md) | :heavy_minus_sign:                                | integration-specific payload                      |


### Response

**[PatchPassthroughResponse](../../Models/Requests/PatchPassthroughResponse.md)**


## RemovePassthrough

Passthrough DELETE

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Passthrough.RemovePassthroughAsync(ConnectionId: "string", Path: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Path`               | *string*             | :heavy_check_mark:   | N/A                  |


### Response

**[RemovePassthroughResponse](../../Models/Requests/RemovePassthroughResponse.md)**


## UpdatePassthrough

Passthrough PUT

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Passthrough.UpdatePassthroughAsync(ConnectionId: "string", Path: "string", Undefined: new Undefined() {});

// handle response
```

### Parameters

| Parameter                                         | Type                                              | Required                                          | Description                                       |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| `ConnectionId`                                    | *string*                                          | :heavy_check_mark:                                | ID of the connection                              |
| `Path`                                            | *string*                                          | :heavy_check_mark:                                | N/A                                               |
| `Undefined`                                       | [Undefined](../../Models/Components/Undefined.md) | :heavy_minus_sign:                                | integration-specific payload                      |


### Response

**[UpdatePassthroughResponse](../../Models/Requests/UpdatePassthroughResponse.md)**

