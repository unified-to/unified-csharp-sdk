# Practitioner

## Overview

### Available Operations

* [GetHealthcarePractitioner](#gethealthcarepractitioner) - Retrieve a practitioner
* [ListHealthcarePractitioners](#listhealthcarepractitioners) - List all practitioners

## GetHealthcarePractitioner

Retrieve a practitioner

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHealthcarePractitioner" method="get" path="/healthcare/{connection_id}/practitioner/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Practitioner.GetHealthcarePractitionerAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Practitioner                                                                                                                           |
| `Fields`                                                                                                                                         | List<[GetHealthcarePractitionerQueryParamFields](../../Models/Requests/GetHealthcarePractitionerQueryParamFields.md)>                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHealthcarePractitionerResponse](../../Models/Requests/GetHealthcarePractitionerResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListHealthcarePractitioners

List all practitioners

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listHealthcarePractitioners" method="get" path="/healthcare/{connection_id}/practitioner" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHealthcarePractitionersRequest req = new ListHealthcarePractitionersRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Practitioner.ListHealthcarePractitionersAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [ListHealthcarePractitionersRequest](../../Models/Requests/ListHealthcarePractitionersRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[ListHealthcarePractitionersResponse](../../Models/Requests/ListHealthcarePractitionersResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |