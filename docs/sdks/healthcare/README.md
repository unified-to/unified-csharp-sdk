# Healthcare

## Overview

### Available Operations

* [CreateHealthcareAppointment](#createhealthcareappointment) - Create an appointment
* [CreateHealthcareObservation](#createhealthcareobservation) - Create an observation
* [CreateHealthcarePatient](#createhealthcarepatient) - Create a patient
* [GetHealthcareAllergy](#gethealthcareallergy) - Retrieve an allergy
* [GetHealthcareAppointment](#gethealthcareappointment) - Retrieve an appointment
* [GetHealthcareCondition](#gethealthcarecondition) - Retrieve a condition
* [GetHealthcareEncounter](#gethealthcareencounter) - Retrieve an encounter
* [GetHealthcareImmunization](#gethealthcareimmunization) - Retrieve an immunization
* [GetHealthcareLocation](#gethealthcarelocation) - Retrieve a location
* [GetHealthcareMedication](#gethealthcaremedication) - Retrieve a medication
* [GetHealthcareObservation](#gethealthcareobservation) - Retrieve an observation
* [GetHealthcarePatient](#gethealthcarepatient) - Retrieve a patient
* [GetHealthcarePractitioner](#gethealthcarepractitioner) - Retrieve a practitioner
* [GetHealthcareSlot](#gethealthcareslot) - Retrieve a slot
* [ListHealthcareAllergies](#listhealthcareallergies) - List all allergies
* [ListHealthcareAppointments](#listhealthcareappointments) - List all appointments
* [ListHealthcareConditions](#listhealthcareconditions) - List all conditions
* [ListHealthcareEncounters](#listhealthcareencounters) - List all encounters
* [ListHealthcareImmunizations](#listhealthcareimmunizations) - List all immunizations
* [ListHealthcareLocations](#listhealthcarelocations) - List all locations
* [ListHealthcareMedications](#listhealthcaremedications) - List all medications
* [ListHealthcareObservations](#listhealthcareobservations) - List all observations
* [ListHealthcarePatients](#listhealthcarepatients) - List all patients
* [ListHealthcarePractitioners](#listhealthcarepractitioners) - List all practitioners
* [ListHealthcareSlots](#listhealthcareslots) - List all slots
* [PatchHealthcareAppointment](#patchhealthcareappointment) - Update an appointment
* [PatchHealthcarePatient](#patchhealthcarepatient) - Update a patient
* [RemoveHealthcareAppointment](#removehealthcareappointment) - Remove an appointment
* [UpdateHealthcareAppointment](#updatehealthcareappointment) - Update an appointment
* [UpdateHealthcarePatient](#updatehealthcarepatient) - Update a patient

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

var res = await sdk.Healthcare.CreateHealthcareAppointmentAsync(
    healthcareAppointment: new HealthcareAppointment() {
        CreatedAt = System.DateTime.Parse("2023-04-11T08:16:20.874Z").ToUniversalTime(),
        Description = "clarus aptus cetera",
        EndAt = System.DateTime.Parse("2023-12-12T13:04:41.451Z").ToUniversalTime(),
        Id = "83e88fd4-9492-4578-850c-5f2fdcde1d09",
        Metadata = new List<HealthcareMetadata>() {},
        PractitionerIds = new List<string>() {},
        Reasons = new List<HealthcareCode>() {
            new HealthcareCode() {
                Code = "12762740",
                Display = "cubicularis caput",
                System = "http://snomed.info/sct",
            },
        },
        ServiceTypes = new List<HealthcareCode>() {
            new HealthcareCode() {
                Code = "61128108",
                Display = "Annual physical",
                System = "http://snomed.info/sct",
            },
        },
        SlotIds = new List<string>() {},
        StartAt = System.DateTime.Parse("2023-12-12T12:34:41.451Z").ToUniversalTime(),
        Status = HealthcareAppointmentStatus.Booked,
        UpdatedAt = System.DateTime.Parse("2025-11-20T02:52:52.612Z").ToUniversalTime(),
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

## CreateHealthcareObservation

Creates a HealthcareObservation. Provide the unified HealthcareObservation fields in the request body; they are mapped to the provider's API. Returns the created HealthcareObservation.

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

var res = await sdk.Healthcare.CreateHealthcareObservationAsync(
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
        Id = "4ad9d295-6fc1-4991-901a-3c43fbd9beb5",
        Interpretation = Interpretation.CriticalHigh,
        IssuedAt = System.DateTime.Parse("2025-05-12T00:13:03.761Z").ToUniversalTime(),
        Metadata = new List<HealthcareMetadata>() {},
        Name = "Blood pressure panel",
        ObservedAt = System.DateTime.Parse("2025-01-20T16:00:29.736Z").ToUniversalTime(),
        Status = HealthcareObservationStatus.Corrected,
        Type = HealthcareObservationType.VitalSigns,
        UpdatedAt = System.DateTime.Parse("2026-03-25T01:02:33.168Z").ToUniversalTime(),
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

## CreateHealthcarePatient

Creates a HealthcarePatient. Provide the unified HealthcarePatient fields in the request body; they are mapped to the provider's API. Returns the created HealthcarePatient.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createHealthcarePatient" method="post" path="/healthcare/{connection_id}/patient" example="healthcare_patient" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Healthcare.CreateHealthcarePatientAsync(
    healthcarePatient: new HealthcarePatient() {
        Address = new PropertyHealthcarePatientAddress() {
            Address1 = "162 Kirlin Mall",
            City = "Dickinsonborough",
            Country = "US",
            PostalCode = "54031",
            Region = "Nebraska",
        },
        Birthdate = "2025-02-13",
        CreatedAt = System.DateTime.Parse("2021-06-05T21:08:04.917Z").ToUniversalTime(),
        Emails = new List<HealthcareEmail>() {
            new HealthcareEmail() {
                Email = "alejandrin.parker@icloud.com",
                Type = HealthcareEmailType.Home,
            },
        },
        FirstName = "Alejandrin",
        Gender = HealthcarePatientGender.Female,
        Id = "e8c4bcd2-fab7-4d75-acd9-e4b34ccf7487",
        Identifiers = new List<HealthcareIdentifier>() {
            new HealthcareIdentifier() {
                Type = HealthcareIdentifierType.Mrn,
                Value = "57992636",
            },
        },
        IsActive = true,
        IsDeceased = false,
        Language = "zh",
        LastName = "Parker",
        Metadata = new List<HealthcareMetadata>() {},
        Name = "Alejandrin Parker",
        PractitionerIds = new List<string>() {},
        Telephones = new List<HealthcareTelephone>() {
            new HealthcareTelephone() {
                Telephone = "1-219-555-9023 x08295",
                Type = HealthcareTelephoneType.Mobile,
            },
        },
        UpdatedAt = System.DateTime.Parse("2026-06-23T16:51:45.202Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `HealthcarePatient`                                                                                                                              | [HealthcarePatient](../../Models/Components/HealthcarePatient.md)                                                                                | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateHealthcarePatientQueryParamFields](../../Models/Requests/CreateHealthcarePatientQueryParamFields.md)>                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateHealthcarePatientResponse](../../Models/Requests/CreateHealthcarePatientResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetHealthcareAllergy

Retrieves a single HealthcareAllergy by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHealthcareAllergy" method="get" path="/healthcare/{connection_id}/allergy/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Healthcare.GetHealthcareAllergyAsync(
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

var res = await sdk.Healthcare.GetHealthcareAppointmentAsync(
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

## GetHealthcareCondition

Retrieves a single HealthcareCondition by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHealthcareCondition" method="get" path="/healthcare/{connection_id}/condition/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Healthcare.GetHealthcareConditionAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Condition                                                                                                                              |
| `Fields`                                                                                                                                         | List<[GetHealthcareConditionQueryParamFields](../../Models/Requests/GetHealthcareConditionQueryParamFields.md)>                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHealthcareConditionResponse](../../Models/Requests/GetHealthcareConditionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetHealthcareEncounter

Retrieves a single HealthcareEncounter by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHealthcareEncounter" method="get" path="/healthcare/{connection_id}/encounter/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Healthcare.GetHealthcareEncounterAsync(
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

## GetHealthcareImmunization

Retrieves a single HealthcareImmunization by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHealthcareImmunization" method="get" path="/healthcare/{connection_id}/immunization/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Healthcare.GetHealthcareImmunizationAsync(
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

## GetHealthcareLocation

Retrieves a single HealthcareLocation by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHealthcareLocation" method="get" path="/healthcare/{connection_id}/location/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Healthcare.GetHealthcareLocationAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Location                                                                                                                               |
| `Fields`                                                                                                                                         | List<[GetHealthcareLocationQueryParamFields](../../Models/Requests/GetHealthcareLocationQueryParamFields.md)>                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHealthcareLocationResponse](../../Models/Requests/GetHealthcareLocationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetHealthcareMedication

Retrieves a single HealthcareMedication by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHealthcareMedication" method="get" path="/healthcare/{connection_id}/medication/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Healthcare.GetHealthcareMedicationAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Medication                                                                                                                             |
| `Fields`                                                                                                                                         | List<[GetHealthcareMedicationQueryParamFields](../../Models/Requests/GetHealthcareMedicationQueryParamFields.md)>                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHealthcareMedicationResponse](../../Models/Requests/GetHealthcareMedicationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetHealthcareObservation

Retrieves a single HealthcareObservation by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHealthcareObservation" method="get" path="/healthcare/{connection_id}/observation/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Healthcare.GetHealthcareObservationAsync(
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

## GetHealthcarePatient

Retrieves a single HealthcarePatient by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHealthcarePatient" method="get" path="/healthcare/{connection_id}/patient/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Healthcare.GetHealthcarePatientAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Patient                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetHealthcarePatientQueryParamFields](../../Models/Requests/GetHealthcarePatientQueryParamFields.md)>                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHealthcarePatientResponse](../../Models/Requests/GetHealthcarePatientResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetHealthcarePractitioner

Retrieves a single HealthcarePractitioner by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHealthcarePractitioner" method="get" path="/healthcare/{connection_id}/practitioner/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Healthcare.GetHealthcarePractitionerAsync(
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

## GetHealthcareSlot

Retrieves a single HealthcareSlot by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHealthcareSlot" method="get" path="/healthcare/{connection_id}/slot/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Healthcare.GetHealthcareSlotAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Slot                                                                                                                                   |
| `Fields`                                                                                                                                         | List<[GetHealthcareSlotQueryParamFields](../../Models/Requests/GetHealthcareSlotQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHealthcareSlotResponse](../../Models/Requests/GetHealthcareSlotResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListHealthcareAllergies

Returns a list of HealthcareAllergies. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

var res = await sdk.Healthcare.ListHealthcareAllergiesAsync(req);

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

var res = await sdk.Healthcare.ListHealthcareAppointmentsAsync(req);

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

## ListHealthcareConditions

Returns a list of HealthcareConditions. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listHealthcareConditions" method="get" path="/healthcare/{connection_id}/condition" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHealthcareConditionsRequest req = new ListHealthcareConditionsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Healthcare.ListHealthcareConditionsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [ListHealthcareConditionsRequest](../../Models/Requests/ListHealthcareConditionsRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[ListHealthcareConditionsResponse](../../Models/Requests/ListHealthcareConditionsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListHealthcareEncounters

Returns a list of HealthcareEncounters. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

var res = await sdk.Healthcare.ListHealthcareEncountersAsync(req);

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

## ListHealthcareImmunizations

Returns a list of HealthcareImmunizations. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

var res = await sdk.Healthcare.ListHealthcareImmunizationsAsync(req);

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

## ListHealthcareLocations

Returns a list of HealthcareLocations. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listHealthcareLocations" method="get" path="/healthcare/{connection_id}/location" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHealthcareLocationsRequest req = new ListHealthcareLocationsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Healthcare.ListHealthcareLocationsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [ListHealthcareLocationsRequest](../../Models/Requests/ListHealthcareLocationsRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[ListHealthcareLocationsResponse](../../Models/Requests/ListHealthcareLocationsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListHealthcareMedications

Returns a list of HealthcareMedications. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listHealthcareMedications" method="get" path="/healthcare/{connection_id}/medication" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHealthcareMedicationsRequest req = new ListHealthcareMedicationsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Healthcare.ListHealthcareMedicationsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [ListHealthcareMedicationsRequest](../../Models/Requests/ListHealthcareMedicationsRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[ListHealthcareMedicationsResponse](../../Models/Requests/ListHealthcareMedicationsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListHealthcareObservations

Returns a list of HealthcareObservations. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

var res = await sdk.Healthcare.ListHealthcareObservationsAsync(req);

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

## ListHealthcarePatients

Returns a list of HealthcarePatients. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listHealthcarePatients" method="get" path="/healthcare/{connection_id}/patient" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHealthcarePatientsRequest req = new ListHealthcarePatientsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Healthcare.ListHealthcarePatientsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [ListHealthcarePatientsRequest](../../Models/Requests/ListHealthcarePatientsRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[ListHealthcarePatientsResponse](../../Models/Requests/ListHealthcarePatientsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListHealthcarePractitioners

Returns a list of HealthcarePractitioners. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

var res = await sdk.Healthcare.ListHealthcarePractitionersAsync(req);

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

## ListHealthcareSlots

Returns a list of HealthcareSlots. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listHealthcareSlots" method="get" path="/healthcare/{connection_id}/slot" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHealthcareSlotsRequest req = new ListHealthcareSlotsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Healthcare.ListHealthcareSlotsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ListHealthcareSlotsRequest](../../Models/Requests/ListHealthcareSlotsRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[ListHealthcareSlotsResponse](../../Models/Requests/ListHealthcareSlotsResponse.md)**

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
        Id = "3b59b099-9d5c-4587-bc8b-a82902904104",
        Metadata = new List<HealthcareMetadata>() {},
        PractitionerIds = new List<string>() {},
        Reasons = new List<HealthcareCode>() {
            new HealthcareCode() {
                Code = "12762740",
                Display = "cubicularis caput",
                System = "http://snomed.info/sct",
            },
        },
        ServiceTypes = new List<HealthcareCode>() {
            new HealthcareCode() {
                Code = "61128108",
                Display = "Annual physical",
                System = "http://snomed.info/sct",
            },
        },
        SlotIds = new List<string>() {},
        StartAt = System.DateTime.Parse("2023-12-12T12:34:41.451Z").ToUniversalTime(),
        Status = HealthcareAppointmentStatus.Booked,
        UpdatedAt = System.DateTime.Parse("2025-11-20T02:52:52.623Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Healthcare.PatchHealthcareAppointmentAsync(req);

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

## PatchHealthcarePatient

Updates the HealthcarePatient identified by `id`. Provide the unified HealthcarePatient fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchHealthcarePatient" method="patch" path="/healthcare/{connection_id}/patient/{id}" example="healthcare_patient" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchHealthcarePatientRequest req = new PatchHealthcarePatientRequest() {
    HealthcarePatient = new HealthcarePatient() {
        Address = new PropertyHealthcarePatientAddress() {
            Address1 = "162 Kirlin Mall",
            City = "Dickinsonborough",
            Country = "US",
            PostalCode = "54031",
            Region = "Nebraska",
        },
        Birthdate = "2025-02-13",
        CreatedAt = System.DateTime.Parse("2021-06-05T21:08:04.917Z").ToUniversalTime(),
        Emails = new List<HealthcareEmail>() {
            new HealthcareEmail() {
                Email = "alejandrin.parker@icloud.com",
                Type = HealthcareEmailType.Home,
            },
        },
        FirstName = "Alejandrin",
        Gender = HealthcarePatientGender.Female,
        Id = "67861186-3393-43ad-a0a3-0deafe6d9390",
        Identifiers = new List<HealthcareIdentifier>() {
            new HealthcareIdentifier() {
                Type = HealthcareIdentifierType.Mrn,
                Value = "57992636",
            },
        },
        IsActive = true,
        IsDeceased = false,
        Language = "zh",
        LastName = "Parker",
        Metadata = new List<HealthcareMetadata>() {},
        Name = "Alejandrin Parker",
        PractitionerIds = new List<string>() {},
        Telephones = new List<HealthcareTelephone>() {
            new HealthcareTelephone() {
                Telephone = "1-219-555-9023 x08295",
                Type = HealthcareTelephoneType.Mobile,
            },
        },
        UpdatedAt = System.DateTime.Parse("2026-06-23T16:51:45.219Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Healthcare.PatchHealthcarePatientAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [PatchHealthcarePatientRequest](../../Models/Requests/PatchHealthcarePatientRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[PatchHealthcarePatientResponse](../../Models/Requests/PatchHealthcarePatientResponse.md)**

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

var res = await sdk.Healthcare.RemoveHealthcareAppointmentAsync(
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
        Id = "3b59b099-9d5c-4587-bc8b-a82902904104",
        Metadata = new List<HealthcareMetadata>() {},
        PractitionerIds = new List<string>() {},
        Reasons = new List<HealthcareCode>() {
            new HealthcareCode() {
                Code = "12762740",
                Display = "cubicularis caput",
                System = "http://snomed.info/sct",
            },
        },
        ServiceTypes = new List<HealthcareCode>() {
            new HealthcareCode() {
                Code = "61128108",
                Display = "Annual physical",
                System = "http://snomed.info/sct",
            },
        },
        SlotIds = new List<string>() {},
        StartAt = System.DateTime.Parse("2023-12-12T12:34:41.451Z").ToUniversalTime(),
        Status = HealthcareAppointmentStatus.Booked,
        UpdatedAt = System.DateTime.Parse("2025-11-20T02:52:52.623Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Healthcare.UpdateHealthcareAppointmentAsync(req);

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

## UpdateHealthcarePatient

Updates the HealthcarePatient identified by `id`. Provide the unified HealthcarePatient fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateHealthcarePatient" method="put" path="/healthcare/{connection_id}/patient/{id}" example="healthcare_patient" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateHealthcarePatientRequest req = new UpdateHealthcarePatientRequest() {
    HealthcarePatient = new HealthcarePatient() {
        Address = new PropertyHealthcarePatientAddress() {
            Address1 = "162 Kirlin Mall",
            City = "Dickinsonborough",
            Country = "US",
            PostalCode = "54031",
            Region = "Nebraska",
        },
        Birthdate = "2025-02-13",
        CreatedAt = System.DateTime.Parse("2021-06-05T21:08:04.917Z").ToUniversalTime(),
        Emails = new List<HealthcareEmail>() {
            new HealthcareEmail() {
                Email = "alejandrin.parker@icloud.com",
                Type = HealthcareEmailType.Home,
            },
        },
        FirstName = "Alejandrin",
        Gender = HealthcarePatientGender.Female,
        Id = "67861186-3393-43ad-a0a3-0deafe6d9390",
        Identifiers = new List<HealthcareIdentifier>() {
            new HealthcareIdentifier() {
                Type = HealthcareIdentifierType.Mrn,
                Value = "57992636",
            },
        },
        IsActive = true,
        IsDeceased = false,
        Language = "zh",
        LastName = "Parker",
        Metadata = new List<HealthcareMetadata>() {},
        Name = "Alejandrin Parker",
        PractitionerIds = new List<string>() {},
        Telephones = new List<HealthcareTelephone>() {
            new HealthcareTelephone() {
                Telephone = "1-219-555-9023 x08295",
                Type = HealthcareTelephoneType.Mobile,
            },
        },
        UpdatedAt = System.DateTime.Parse("2026-06-23T16:51:45.219Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Healthcare.UpdateHealthcarePatientAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [UpdateHealthcarePatientRequest](../../Models/Requests/UpdateHealthcarePatientRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[UpdateHealthcarePatientResponse](../../Models/Requests/UpdateHealthcarePatientResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |