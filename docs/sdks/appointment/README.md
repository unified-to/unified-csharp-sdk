# Appointment

## Overview

### Available Operations

* [CreateHealthcareAppointment](#createhealthcareappointment) - Create an appointment
* [GetHealthcareAppointment](#gethealthcareappointment) - Retrieve an appointment
* [ListHealthcareAppointments](#listhealthcareappointments) - List all appointments
* [PatchHealthcareAppointment](#patchhealthcareappointment) - Update an appointment
* [RemoveHealthcareAppointment](#removehealthcareappointment) - Remove an appointment
* [UpdateHealthcareAppointment](#updatehealthcareappointment) - Update an appointment

## CreateHealthcareAppointment

Creates a HealthcareAppointment. Provide the unified HealthcareAppointment fields in the request body; they are mapped to the provider's API. Returns the created HealthcareAppointment.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createHealthcareAppointment" method="post" path="/healthcare/{connection_id}/appointment" example="healthcare_appointment" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Appointment.CreateHealthcareAppointmentAsync(
    healthcareAppointment: new HealthcareAppointment() {
        CreatedAt = System.DateTime.Parse("2023-04-11T08:16:20.874Z").ToUniversalTime(),
        Description = "clarus aptus cetera",
        EndAt = System.DateTime.Parse("2023-12-12T13:04:41.451Z").ToUniversalTime(),
        Id = "5ec81150-e765-432b-a1a2-4fa790889c84",
        IsVirtual = true,
        MeetingUrl = "https://expensive-slipper.name/",
        Metadata = new List<HealthcareMetadata>() {},
        Notes = "Stabilis triduana colo casus anser ver alo beatus contabesco amiculum.",
        PractitionerIds = new List<string>() {},
        ServiceTypes = new List<HealthcareCode>() {
            new HealthcareCode() {
                Code = "12762740",
                Display = "New patient visit",
                System = "http://snomed.info/sct",
            },
        },
        SlotIds = new List<string>() {},
        StartAt = System.DateTime.Parse("2023-12-12T12:34:41.451Z").ToUniversalTime(),
        Status = HealthcareAppointmentStatus.Booked,
        UpdatedAt = System.DateTime.Parse("2026-09-26T02:53:37.517Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `HealthcareAppointment`                                                                                                                          | [HealthcareAppointment](../../Models/Components/HealthcareAppointment.md)                                                                        | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateHealthcareAppointmentQueryParamFields](../../Models/Requests/CreateHealthcareAppointmentQueryParamFields.md)>                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateHealthcareAppointmentResponse](../../Models/Requests/CreateHealthcareAppointmentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetHealthcareAppointment

Retrieves a single HealthcareAppointment by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHealthcareAppointment" method="get" path="/healthcare/{connection_id}/appointment/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Appointment.GetHealthcareAppointmentAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Appointment                                                                                                                            |
| `Fields`                                                                                                                                         | List<[GetHealthcareAppointmentQueryParamFields](../../Models/Requests/GetHealthcareAppointmentQueryParamFields.md)>                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHealthcareAppointmentResponse](../../Models/Requests/GetHealthcareAppointmentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListHealthcareAppointments

Returns a list of HealthcareAppointments. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listHealthcareAppointments" method="get" path="/healthcare/{connection_id}/appointment" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHealthcareAppointmentsRequest req = new ListHealthcareAppointmentsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Appointment.ListHealthcareAppointmentsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [ListHealthcareAppointmentsRequest](../../Models/Requests/ListHealthcareAppointmentsRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[ListHealthcareAppointmentsResponse](../../Models/Requests/ListHealthcareAppointmentsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchHealthcareAppointment

Updates the HealthcareAppointment identified by `id`. Provide the unified HealthcareAppointment fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchHealthcareAppointment" method="patch" path="/healthcare/{connection_id}/appointment/{id}" example="healthcare_appointment" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchHealthcareAppointmentRequest req = new PatchHealthcareAppointmentRequest() {
    HealthcareAppointment = new HealthcareAppointment() {
        CreatedAt = System.DateTime.Parse("2023-04-11T08:16:20.874Z").ToUniversalTime(),
        Description = "clarus aptus cetera",
        EndAt = System.DateTime.Parse("2023-12-12T13:04:41.451Z").ToUniversalTime(),
        Id = "61f595d9-31a1-4f08-8089-e7765e25ddd5",
        IsVirtual = true,
        MeetingUrl = "https://expensive-slipper.name/",
        Metadata = new List<HealthcareMetadata>() {},
        Notes = "Stabilis triduana colo casus anser ver alo beatus contabesco amiculum.",
        PractitionerIds = new List<string>() {},
        ServiceTypes = new List<HealthcareCode>() {
            new HealthcareCode() {
                Code = "12762740",
                Display = "New patient visit",
                System = "http://snomed.info/sct",
            },
        },
        SlotIds = new List<string>() {},
        StartAt = System.DateTime.Parse("2023-12-12T12:34:41.451Z").ToUniversalTime(),
        Status = HealthcareAppointmentStatus.Booked,
        UpdatedAt = System.DateTime.Parse("2026-09-26T02:53:37.533Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Appointment.PatchHealthcareAppointmentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [PatchHealthcareAppointmentRequest](../../Models/Requests/PatchHealthcareAppointmentRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[PatchHealthcareAppointmentResponse](../../Models/Requests/PatchHealthcareAppointmentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveHealthcareAppointment

Deletes the HealthcareAppointment identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeHealthcareAppointment" method="delete" path="/healthcare/{connection_id}/appointment/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Appointment.RemoveHealthcareAppointmentAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter             | Type                  | Required              | Description           |
| --------------------- | --------------------- | --------------------- | --------------------- |
| `ConnectionId`        | *string*              | :heavy_check_mark:    | ID of the connection  |
| `Id`                  | *string*              | :heavy_check_mark:    | ID of the Appointment |

### Response

**[RemoveHealthcareAppointmentResponse](../../Models/Requests/RemoveHealthcareAppointmentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateHealthcareAppointment

Updates the HealthcareAppointment identified by `id`. Provide the unified HealthcareAppointment fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateHealthcareAppointment" method="put" path="/healthcare/{connection_id}/appointment/{id}" example="healthcare_appointment" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateHealthcareAppointmentRequest req = new UpdateHealthcareAppointmentRequest() {
    HealthcareAppointment = new HealthcareAppointment() {
        CreatedAt = System.DateTime.Parse("2023-04-11T08:16:20.874Z").ToUniversalTime(),
        Description = "clarus aptus cetera",
        EndAt = System.DateTime.Parse("2023-12-12T13:04:41.451Z").ToUniversalTime(),
        Id = "61f595d9-31a1-4f08-8089-e7765e25ddd5",
        IsVirtual = true,
        MeetingUrl = "https://expensive-slipper.name/",
        Metadata = new List<HealthcareMetadata>() {},
        Notes = "Stabilis triduana colo casus anser ver alo beatus contabesco amiculum.",
        PractitionerIds = new List<string>() {},
        ServiceTypes = new List<HealthcareCode>() {
            new HealthcareCode() {
                Code = "12762740",
                Display = "New patient visit",
                System = "http://snomed.info/sct",
            },
        },
        SlotIds = new List<string>() {},
        StartAt = System.DateTime.Parse("2023-12-12T12:34:41.451Z").ToUniversalTime(),
        Status = HealthcareAppointmentStatus.Booked,
        UpdatedAt = System.DateTime.Parse("2026-09-26T02:53:37.533Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Appointment.UpdateHealthcareAppointmentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [UpdateHealthcareAppointmentRequest](../../Models/Requests/UpdateHealthcareAppointmentRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[UpdateHealthcareAppointmentResponse](../../Models/Requests/UpdateHealthcareAppointmentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |