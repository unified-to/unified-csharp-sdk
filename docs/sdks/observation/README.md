# Observation

## Overview

### Available Operations

* [CreateHealthcareObservation](#createhealthcareobservation) - Create an observation
* [GetHealthcareObservation](#gethealthcareobservation) - Retrieve an observation
* [ListHealthcareObservations](#listhealthcareobservations) - List all observations

## CreateHealthcareObservation

Create an observation

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createHealthcareObservation" method="post" path="/healthcare/{connection_id}/observation" example="healthcare_observation" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Observation.CreateHealthcareObservationAsync(
    healthcareObservation: new HealthcareObservation() {
        Codes = new List<HealthcareCode>() {
            new HealthcareCode() {
                Code = "85354-9",
                Display = "Blood pressure panel",
                System = "http://loinc.org",
            },
        },
        Components = new List<HealthcareObservationComponent>() {
            new HealthcareObservationComponent() {
                Codes = new List<HealthcareCode>() {
                    new HealthcareCode() {
                        Code = "8480-6",
                        System = "http://loinc.org",
                    },
                },
                Name = "Systolic blood pressure",
                ValueNumber = 103D,
                ValueUnit = "mm[Hg]",
            },
            new HealthcareObservationComponent() {
                Codes = new List<HealthcareCode>() {
                    new HealthcareCode() {
                        Code = "8462-4",
                        System = "http://loinc.org",
                    },
                },
                Name = "Diastolic blood pressure",
                ValueNumber = 60D,
                ValueUnit = "mm[Hg]",
            },
        },
        CreatedAt = System.DateTime.Parse("2022-12-06T21:34:04.293Z").ToUniversalTime(),
        Id = "59d803ef-1d7a-4691-ac4f-1d4375a964b7",
        Interpretation = Interpretation.CriticalHigh,
        IssuedAt = System.DateTime.Parse("2025-05-08T22:43:32.759Z").ToUniversalTime(),
        Metadata = new List<HealthcareMetadata>() {},
        Name = "Blood pressure panel",
        ObservedAt = System.DateTime.Parse("2025-01-17T23:44:25.289Z").ToUniversalTime(),
        Status = HealthcareObservationStatus.Corrected,
        Type = HealthcareObservationType.VitalSigns,
        UpdatedAt = System.DateTime.Parse("2026-03-20T21:17:10.124Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `HealthcareObservation`                                                                                                                          | [HealthcareObservation](../../Models/Components/HealthcareObservation.md)                                                                        | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateHealthcareObservationQueryParamFields](../../Models/Requests/CreateHealthcareObservationQueryParamFields.md)>                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateHealthcareObservationResponse](../../Models/Requests/CreateHealthcareObservationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetHealthcareObservation

Retrieve an observation

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHealthcareObservation" method="get" path="/healthcare/{connection_id}/observation/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Observation.GetHealthcareObservationAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Observation                                                                                                                            |
| `Fields`                                                                                                                                         | List<[GetHealthcareObservationQueryParamFields](../../Models/Requests/GetHealthcareObservationQueryParamFields.md)>                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHealthcareObservationResponse](../../Models/Requests/GetHealthcareObservationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListHealthcareObservations

List all observations

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listHealthcareObservations" method="get" path="/healthcare/{connection_id}/observation" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHealthcareObservationsRequest req = new ListHealthcareObservationsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Observation.ListHealthcareObservationsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [ListHealthcareObservationsRequest](../../Models/Requests/ListHealthcareObservationsRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[ListHealthcareObservationsResponse](../../Models/Requests/ListHealthcareObservationsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |