# Allergy

## Overview

### Available Operations

* [GetHealthcareAllergy](#gethealthcareallergy) - Retrieve an allergy
* [ListHealthcareAllergies](#listhealthcareallergies) - List all allergies

## GetHealthcareAllergy

Retrieve an allergy

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHealthcareAllergy" method="get" path="/healthcare/{connection_id}/allergy/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Allergy.GetHealthcareAllergyAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Allergy                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetHealthcareAllergyQueryParamFields](../../Models/Requests/GetHealthcareAllergyQueryParamFields.md)>                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHealthcareAllergyResponse](../../Models/Requests/GetHealthcareAllergyResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListHealthcareAllergies

List all allergies

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listHealthcareAllergies" method="get" path="/healthcare/{connection_id}/allergy" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHealthcareAllergiesRequest req = new ListHealthcareAllergiesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Allergy.ListHealthcareAllergiesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [ListHealthcareAllergiesRequest](../../Models/Requests/ListHealthcareAllergiesRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[ListHealthcareAllergiesResponse](../../Models/Requests/ListHealthcareAllergiesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |