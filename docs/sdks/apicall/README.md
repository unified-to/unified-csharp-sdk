# Apicall
(*Apicall*)

## Overview

### Available Operations

* [GetUnifiedApicall](#getunifiedapicall) - Retrieve specific API Call by its ID
* [ListUnifiedApicalls](#listunifiedapicalls) - Returns API Calls

## GetUnifiedApicall

Retrieve specific API Call by its ID

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Apicall.GetUnifiedApicallAsync(id: "<id>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Id`               | *string*           | :heavy_check_mark: | ID of the Apicall  |

### Response

**[GetUnifiedApicallResponse](../../Models/Requests/GetUnifiedApicallResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListUnifiedApicalls

Returns API Calls

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListUnifiedApicallsRequest req = ;

var res = await sdk.Apicall.ListUnifiedApicallsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ListUnifiedApicallsRequest](../../Models/Requests/ListUnifiedApicallsRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[ListUnifiedApicallsResponse](../../Models/Requests/ListUnifiedApicallsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |