# Passthrough
(*Passthrough*)

## Overview

### Available Operations

* [CreatePassthrough2Json](#createpassthrough2json) - Passthrough POST
* [CreatePassthrough2Raw](#createpassthrough2raw) - Passthrough POST
* [ListPassthroughs2](#listpassthroughs2) - Passthrough GET
* [PatchPassthrough2Json](#patchpassthrough2json) - Passthrough PUT
* [PatchPassthrough2Raw](#patchpassthrough2raw) - Passthrough PUT
* [RemovePassthrough2](#removepassthrough2) - Passthrough DELETE
* [UpdatePassthrough2Json](#updatepassthrough2json) - Passthrough PUT
* [UpdatePassthrough2Raw](#updatepassthrough2raw) - Passthrough PUT

## CreatePassthrough2Json

Passthrough POST

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Passthrough.CreatePassthrough2JsonAsync(
    connectionId: "<id>",
    path: "/net"
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

**[CreatePassthrough2JsonResponse](../../Models/Requests/CreatePassthrough2JsonResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreatePassthrough2Raw

Passthrough POST

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Passthrough.CreatePassthrough2RawAsync(
    connectionId: "<id>",
    path: "/net"
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

**[CreatePassthrough2RawResponse](../../Models/Requests/CreatePassthrough2RawResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListPassthroughs2

Passthrough GET

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Passthrough.ListPassthroughs2Async(
    connectionId: "<id>",
    path: "/usr/local/src"
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

**[ListPassthroughs2Response](../../Models/Requests/ListPassthroughs2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchPassthrough2Json

Passthrough PUT

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Passthrough.PatchPassthrough2JsonAsync(
    connectionId: "<id>",
    path: "/usr/X11R6"
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

**[PatchPassthrough2JsonResponse](../../Models/Requests/PatchPassthrough2JsonResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchPassthrough2Raw

Passthrough PUT

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Passthrough.PatchPassthrough2RawAsync(
    connectionId: "<id>",
    path: "/usr/X11R6"
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

**[PatchPassthrough2RawResponse](../../Models/Requests/PatchPassthrough2RawResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemovePassthrough2

Passthrough DELETE

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Passthrough.RemovePassthrough2Async(
    connectionId: "<id>",
    path: "/usr/include"
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

**[RemovePassthrough2Response](../../Models/Requests/RemovePassthrough2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdatePassthrough2Json

Passthrough PUT

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Passthrough.UpdatePassthrough2JsonAsync(
    connectionId: "<id>",
    path: "/home/user/dir"
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

**[UpdatePassthrough2JsonResponse](../../Models/Requests/UpdatePassthrough2JsonResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdatePassthrough2Raw

Passthrough PUT

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Passthrough.UpdatePassthrough2RawAsync(
    connectionId: "<id>",
    path: "/home/user/dir"
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

**[UpdatePassthrough2RawResponse](../../Models/Requests/UpdatePassthrough2RawResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |