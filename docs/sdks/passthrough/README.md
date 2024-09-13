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
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Passthrough.CreatePassthroughJsonAsync(
    connectionId: "<value>",
    path: "/opt/lib",
    requestBody: "<value>"
);

// handle response
```

### Parameters

| Parameter                    | Type                         | Required                     | Description                  |
| ---------------------------- | ---------------------------- | ---------------------------- | ---------------------------- |
| `ConnectionId`               | *string*                     | :heavy_check_mark:           | ID of the connection         |
| `Path`                       | *string*                     | :heavy_check_mark:           | N/A                          |
| `RequestBody`                | *object*                     | :heavy_minus_sign:           | integration-specific payload |

### Response

**[CreatePassthroughJsonResponse](../../Models/Requests/CreatePassthroughJsonResponse.md)**

### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |


## CreatePassthroughRaw

Passthrough POST

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Passthrough.CreatePassthroughRawAsync(
    connectionId: "<value>",
    path: "/etc/namedb",
    requestBody: System.Text.Encoding.UTF8.GetBytes("0x34ABa9b31D")
);

// handle response
```

### Parameters

| Parameter                    | Type                         | Required                     | Description                  |
| ---------------------------- | ---------------------------- | ---------------------------- | ---------------------------- |
| `ConnectionId`               | *string*                     | :heavy_check_mark:           | ID of the connection         |
| `Path`                       | *string*                     | :heavy_check_mark:           | N/A                          |
| `RequestBody`                | *byte[]*                     | :heavy_minus_sign:           | integration-specific payload |

### Response

**[CreatePassthroughRawResponse](../../Models/Requests/CreatePassthroughRawResponse.md)**

### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |


## ListPassthroughs

Passthrough GET

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Passthrough.ListPassthroughsAsync(
    connectionId: "<value>",
    path: "/selinux"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Path`               | *string*             | :heavy_check_mark:   | N/A                  |

### Response

**[ListPassthroughsResponse](../../Models/Requests/ListPassthroughsResponse.md)**

### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |


## PatchPassthroughJson

Passthrough PUT

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Passthrough.PatchPassthroughJsonAsync(
    connectionId: "<value>",
    path: "/home/user",
    requestBody: "<value>"
);

// handle response
```

### Parameters

| Parameter                    | Type                         | Required                     | Description                  |
| ---------------------------- | ---------------------------- | ---------------------------- | ---------------------------- |
| `ConnectionId`               | *string*                     | :heavy_check_mark:           | ID of the connection         |
| `Path`                       | *string*                     | :heavy_check_mark:           | N/A                          |
| `RequestBody`                | *object*                     | :heavy_minus_sign:           | integration-specific payload |

### Response

**[PatchPassthroughJsonResponse](../../Models/Requests/PatchPassthroughJsonResponse.md)**

### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |


## PatchPassthroughRaw

Passthrough PUT

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Passthrough.PatchPassthroughRawAsync(
    connectionId: "<value>",
    path: "/etc/mail",
    requestBody: System.Text.Encoding.UTF8.GetBytes("0x7CEb8f75C6")
);

// handle response
```

### Parameters

| Parameter                    | Type                         | Required                     | Description                  |
| ---------------------------- | ---------------------------- | ---------------------------- | ---------------------------- |
| `ConnectionId`               | *string*                     | :heavy_check_mark:           | ID of the connection         |
| `Path`                       | *string*                     | :heavy_check_mark:           | N/A                          |
| `RequestBody`                | *byte[]*                     | :heavy_minus_sign:           | integration-specific payload |

### Response

**[PatchPassthroughRawResponse](../../Models/Requests/PatchPassthroughRawResponse.md)**

### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |


## RemovePassthrough

Passthrough DELETE

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Passthrough.RemovePassthroughAsync(
    connectionId: "<value>",
    path: "/Applications"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Path`               | *string*             | :heavy_check_mark:   | N/A                  |

### Response

**[RemovePassthroughResponse](../../Models/Requests/RemovePassthroughResponse.md)**

### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |


## UpdatePassthroughJson

Passthrough PUT

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Passthrough.UpdatePassthroughJsonAsync(
    connectionId: "<value>",
    path: "/etc/namedb",
    requestBody: "<value>"
);

// handle response
```

### Parameters

| Parameter                    | Type                         | Required                     | Description                  |
| ---------------------------- | ---------------------------- | ---------------------------- | ---------------------------- |
| `ConnectionId`               | *string*                     | :heavy_check_mark:           | ID of the connection         |
| `Path`                       | *string*                     | :heavy_check_mark:           | N/A                          |
| `RequestBody`                | *object*                     | :heavy_minus_sign:           | integration-specific payload |

### Response

**[UpdatePassthroughJsonResponse](../../Models/Requests/UpdatePassthroughJsonResponse.md)**

### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |


## UpdatePassthroughRaw

Passthrough PUT

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Passthrough.UpdatePassthroughRawAsync(
    connectionId: "<value>",
    path: "/System",
    requestBody: System.Text.Encoding.UTF8.GetBytes("0x5587B3b9f8")
);

// handle response
```

### Parameters

| Parameter                    | Type                         | Required                     | Description                  |
| ---------------------------- | ---------------------------- | ---------------------------- | ---------------------------- |
| `ConnectionId`               | *string*                     | :heavy_check_mark:           | ID of the connection         |
| `Path`                       | *string*                     | :heavy_check_mark:           | N/A                          |
| `RequestBody`                | *byte[]*                     | :heavy_minus_sign:           | integration-specific payload |

### Response

**[UpdatePassthroughRawResponse](../../Models/Requests/UpdatePassthroughRawResponse.md)**

### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |
