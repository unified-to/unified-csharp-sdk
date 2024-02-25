# Apicall
(*Apicall*)

### Available Operations

* [GetUnifiedApicall](#getunifiedapicall) - Retrieve specific API Call by its ID
* [ListUnifiedApicalls](#listunifiedapicalls) - Returns API Calls

## GetUnifiedApicall

Retrieve specific API Call by its ID

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Apicall.GetUnifiedApicallAsync(
    security: new GetUnifiedApicallSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                | [UnifiedTo.Models.Requests.GetUnifiedApicallSecurity](../../Models/Requests/GetUnifiedApicallSecurity.md) | :heavy_check_mark:                                                                                        | The security requirements to use for the request.                                                         |
| `Id`                                                                                                      | *string*                                                                                                  | :heavy_check_mark:                                                                                        | ID of the Apicall                                                                                         |


### Response

**[GetUnifiedApicallResponse](../../Models/Requests/GetUnifiedApicallResponse.md)**


## ListUnifiedApicalls

Returns API Calls

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

ListUnifiedApicallsRequest req = new ListUnifiedApicallsRequest() {};

var res = await sdk.Apicall.ListUnifiedApicallsAsync(
    security: new ListUnifiedApicallsSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                                     | Type                                                                                                          | Required                                                                                                      | Description                                                                                                   |
| ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                     | [ListUnifiedApicallsRequest](../../Models/Requests/ListUnifiedApicallsRequest.md)                             | :heavy_check_mark:                                                                                            | The request object to use for the request.                                                                    |
| `security`                                                                                                    | [UnifiedTo.Models.Requests.ListUnifiedApicallsSecurity](../../Models/Requests/ListUnifiedApicallsSecurity.md) | :heavy_check_mark:                                                                                            | The security requirements to use for the request.                                                             |


### Response

**[ListUnifiedApicallsResponse](../../Models/Requests/ListUnifiedApicallsResponse.md)**

