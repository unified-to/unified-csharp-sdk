# Passthrough
(*Passthrough*)

## Overview

### Available Operations

* [CreatePassthroughJson](#createpassthroughjson) - Passthrough POST
* [CreatePassthroughRaw](#createpassthroughraw) - Passthrough POST
* [ListPassthroughs](#listpassthroughs) - Passthrough GET
* [PatchPassthroughJson](#patchpassthroughjson) - Passthrough PUT
* [PatchPassthroughRaw](#patchpassthroughraw) - Passthrough PUT
* [RemovePassthrough](#removepassthrough) - Passthrough DELETE
* [UpdatePassthroughJson](#updatepassthroughjson) - Passthrough PUT
* [UpdatePassthroughRaw](#updatepassthroughraw) - Passthrough PUT

## CreatePassthroughJson

Passthrough POST

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Passthrough.CreatePassthroughJsonAsync(
    connectionId: "<id>",
    path: "/var/log"
);

// handle response
```

### Parameters

| Parameter                    | Type                         | Required                     | Description                  |
| ---------------------------- | ---------------------------- | ---------------------------- | ---------------------------- |
| `ConnectionId`               | *string*                     | :heavy_check_mark:           | ID of the connection         |
| `Path`                       | *string*                     | :heavy_check_mark:           | N/A                          |
| `RequestBody`                | *object*                     | :heavy_minus_sign:           | integration-specific payload |
| `Query`                      | Dictionary<String, *object*> | :heavy_minus_sign:           | N/A                          |

### Response

**[CreatePassthroughJsonResponse](../../Models/Requests/CreatePassthroughJsonResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreatePassthroughRaw

Passthrough POST

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Passthrough.CreatePassthroughRawAsync(
    connectionId: "<id>",
    path: "/var/log"
);

// handle response
```

### Parameters

| Parameter                    | Type                         | Required                     | Description                  |
| ---------------------------- | ---------------------------- | ---------------------------- | ---------------------------- |
| `ConnectionId`               | *string*                     | :heavy_check_mark:           | ID of the connection         |
| `Path`                       | *string*                     | :heavy_check_mark:           | N/A                          |
| `RequestBody`                | *byte[]*                     | :heavy_minus_sign:           | integration-specific payload |
| `Query`                      | Dictionary<String, *object*> | :heavy_minus_sign:           | N/A                          |

### Response

**[CreatePassthroughRawResponse](../../Models/Requests/CreatePassthroughRawResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListPassthroughs

Passthrough GET

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Passthrough.ListPassthroughsAsync(
    connectionId: "<id>",
    path: "/System"
);

// handle response
```

### Parameters

| Parameter                    | Type                         | Required                     | Description                  |
| ---------------------------- | ---------------------------- | ---------------------------- | ---------------------------- |
| `ConnectionId`               | *string*                     | :heavy_check_mark:           | ID of the connection         |
| `Path`                       | *string*                     | :heavy_check_mark:           | N/A                          |
| `Query`                      | Dictionary<String, *object*> | :heavy_minus_sign:           | N/A                          |

### Response

**[ListPassthroughsResponse](../../Models/Requests/ListPassthroughsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchPassthroughJson

Passthrough PUT

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Passthrough.PatchPassthroughJsonAsync(
    connectionId: "<id>",
    path: "/System"
);

// handle response
```

### Parameters

| Parameter                    | Type                         | Required                     | Description                  |
| ---------------------------- | ---------------------------- | ---------------------------- | ---------------------------- |
| `ConnectionId`               | *string*                     | :heavy_check_mark:           | ID of the connection         |
| `Path`                       | *string*                     | :heavy_check_mark:           | N/A                          |
| `RequestBody`                | *object*                     | :heavy_minus_sign:           | integration-specific payload |
| `Query`                      | Dictionary<String, *object*> | :heavy_minus_sign:           | N/A                          |

### Response

**[PatchPassthroughJsonResponse](../../Models/Requests/PatchPassthroughJsonResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchPassthroughRaw

Passthrough PUT

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Passthrough.PatchPassthroughRawAsync(
    connectionId: "<id>",
    path: "/System"
);

// handle response
```

### Parameters

| Parameter                    | Type                         | Required                     | Description                  |
| ---------------------------- | ---------------------------- | ---------------------------- | ---------------------------- |
| `ConnectionId`               | *string*                     | :heavy_check_mark:           | ID of the connection         |
| `Path`                       | *string*                     | :heavy_check_mark:           | N/A                          |
| `RequestBody`                | *byte[]*                     | :heavy_minus_sign:           | integration-specific payload |
| `Query`                      | Dictionary<String, *object*> | :heavy_minus_sign:           | N/A                          |

### Response

**[PatchPassthroughRawResponse](../../Models/Requests/PatchPassthroughRawResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemovePassthrough

Passthrough DELETE

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Passthrough.RemovePassthroughAsync(
    connectionId: "<id>",
    path: "/bin"
);

// handle response
```

### Parameters

| Parameter                    | Type                         | Required                     | Description                  |
| ---------------------------- | ---------------------------- | ---------------------------- | ---------------------------- |
| `ConnectionId`               | *string*                     | :heavy_check_mark:           | ID of the connection         |
| `Path`                       | *string*                     | :heavy_check_mark:           | N/A                          |
| `Query`                      | Dictionary<String, *object*> | :heavy_minus_sign:           | N/A                          |

### Response

**[RemovePassthroughResponse](../../Models/Requests/RemovePassthroughResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdatePassthroughJson

Passthrough PUT

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Passthrough.UpdatePassthroughJsonAsync(
    connectionId: "<id>",
    path: "/var/tmp"
);

// handle response
```

### Parameters

| Parameter                    | Type                         | Required                     | Description                  |
| ---------------------------- | ---------------------------- | ---------------------------- | ---------------------------- |
| `ConnectionId`               | *string*                     | :heavy_check_mark:           | ID of the connection         |
| `Path`                       | *string*                     | :heavy_check_mark:           | N/A                          |
| `RequestBody`                | *object*                     | :heavy_minus_sign:           | integration-specific payload |
| `Query`                      | Dictionary<String, *object*> | :heavy_minus_sign:           | N/A                          |

### Response

**[UpdatePassthroughJsonResponse](../../Models/Requests/UpdatePassthroughJsonResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdatePassthroughRaw

Passthrough PUT

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Passthrough.UpdatePassthroughRawAsync(
    connectionId: "<id>",
    path: "/var/tmp"
);

// handle response
```

### Parameters

| Parameter                    | Type                         | Required                     | Description                  |
| ---------------------------- | ---------------------------- | ---------------------------- | ---------------------------- |
| `ConnectionId`               | *string*                     | :heavy_check_mark:           | ID of the connection         |
| `Path`                       | *string*                     | :heavy_check_mark:           | N/A                          |
| `RequestBody`                | *byte[]*                     | :heavy_minus_sign:           | integration-specific payload |
| `Query`                      | Dictionary<String, *object*> | :heavy_minus_sign:           | N/A                          |

### Response

**[UpdatePassthroughRawResponse](../../Models/Requests/UpdatePassthroughRawResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |