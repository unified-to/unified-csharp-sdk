# Immunization

## Overview

### Available Operations

* [GetHealthcareImmunization](#gethealthcareimmunization) - Retrieve an immunization
* [ListHealthcareImmunizations](#listhealthcareimmunizations) - List all immunizations

## GetHealthcareImmunization

Retrieve an immunization

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHealthcareImmunization" method="get" path="/healthcare/{connection_id}/immunization/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Immunization.GetHealthcareImmunizationAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Immunization                                                                                                                           |
| `Fields`                                                                                                                                         | List<[GetHealthcareImmunizationQueryParamFields](../../Models/Requests/GetHealthcareImmunizationQueryParamFields.md)>                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHealthcareImmunizationResponse](../../Models/Requests/GetHealthcareImmunizationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListHealthcareImmunizations

List all immunizations

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listHealthcareImmunizations" method="get" path="/healthcare/{connection_id}/immunization" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHealthcareImmunizationsRequest req = new ListHealthcareImmunizationsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Immunization.ListHealthcareImmunizationsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [ListHealthcareImmunizationsRequest](../../Models/Requests/ListHealthcareImmunizationsRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[ListHealthcareImmunizationsResponse](../../Models/Requests/ListHealthcareImmunizationsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |