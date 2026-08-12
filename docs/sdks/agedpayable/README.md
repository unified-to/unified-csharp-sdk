# Agedpayable

## Overview

### Available Operations

* [GetAccountingAgedpayable](#getaccountingagedpayable) - Retrieve an agedpayable
* [ListAccountingAgedpayables](#listaccountingagedpayables) - List all agedpayables

## GetAccountingAgedpayable

Retrieve an agedpayable

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAccountingAgedpayable" method="get" path="/accounting/{connection_id}/agedpayable/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Agedpayable.GetAccountingAgedpayableAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Agedpayable                                                                                                                            |
| `Fields`                                                                                                                                         | List<[GetAccountingAgedpayableQueryParamFields](../../Models/Requests/GetAccountingAgedpayableQueryParamFields.md)>                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAccountingAgedpayableResponse](../../Models/Requests/GetAccountingAgedpayableResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAccountingAgedpayables

List all agedpayables

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAccountingAgedpayables" method="get" path="/accounting/{connection_id}/agedpayable" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAccountingAgedpayablesRequest req = new ListAccountingAgedpayablesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Agedpayable.ListAccountingAgedpayablesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [ListAccountingAgedpayablesRequest](../../Models/Requests/ListAccountingAgedpayablesRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[ListAccountingAgedpayablesResponse](../../Models/Requests/ListAccountingAgedpayablesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |