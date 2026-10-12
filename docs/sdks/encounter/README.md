# Encounter

## Overview

### Available Operations

* [GetHealthcareEncounter](#gethealthcareencounter) - Retrieve an encounter
* [ListHealthcareEncounters](#listhealthcareencounters) - List all encounters

## GetHealthcareEncounter

Retrieve an encounter

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHealthcareEncounter" method="get" path="/healthcare/{connection_id}/encounter/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Encounter.GetHealthcareEncounterAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Encounter                                                                                                                              |
| `Fields`                                                                                                                                         | List<[GetHealthcareEncounterQueryParamFields](../../Models/Requests/GetHealthcareEncounterQueryParamFields.md)>                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHealthcareEncounterResponse](../../Models/Requests/GetHealthcareEncounterResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListHealthcareEncounters

List all encounters

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listHealthcareEncounters" method="get" path="/healthcare/{connection_id}/encounter" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHealthcareEncountersRequest req = new ListHealthcareEncountersRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Encounter.ListHealthcareEncountersAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [ListHealthcareEncountersRequest](../../Models/Requests/ListHealthcareEncountersRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[ListHealthcareEncountersResponse](../../Models/Requests/ListHealthcareEncountersResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |