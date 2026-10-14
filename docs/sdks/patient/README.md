# Patient

## Overview

### Available Operations

* [CreateHealthcarePatient](#createhealthcarepatient) - Create a patient
* [GetHealthcarePatient](#gethealthcarepatient) - Retrieve a patient
* [ListHealthcarePatients](#listhealthcarepatients) - List all patients
* [PatchHealthcarePatient](#patchhealthcarepatient) - Update a patient
* [UpdateHealthcarePatient](#updatehealthcarepatient) - Update a patient

## CreateHealthcarePatient

Create a patient

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

var res = await sdk.Patient.CreateHealthcarePatientAsync(
    healthcarePatient: new HealthcarePatient() {
        Address = new PropertyHealthcarePatientAddress() {
            Address1 = "3645 Zoila Isle",
            Address2 = "Suite 613",
            City = "Jacintostead",
            Country = "US",
            PostalCode = "31579",
            Region = "Minnesota",
        },
        Birthdate = "2025-02-04",
        CreatedAt = System.DateTime.Parse("2021-06-05T21:08:04.917Z").ToUniversalTime(),
        Emails = new List<HealthcareEmail>() {
            new HealthcareEmail() {
                Email = "alejandrin.parker@yahoo.com",
                Type = HealthcareEmailType.Home,
            },
        },
        FirstName = "Alejandrin",
        Gender = HealthcarePatientGender.Female,
        Id = "39d60942-7ba4-48d5-9cab-195540eda24d",
        Identifiers = new List<HealthcareIdentifier>() {
            new HealthcareIdentifier() {
                Type = HealthcareIdentifierType.Mrn,
                Value = "92636004",
            },
        },
        IsActive = true,
        IsDeceased = false,
        Language = "en",
        LastName = "Parker",
        Metadata = new List<HealthcareMetadata>() {},
        Name = "Alejandrin Parker",
        PractitionerIds = new List<string>() {},
        Telephones = new List<HealthcareTelephone>() {
            new HealthcareTelephone() {
                Telephone = "659.223.0829 x590",
                Type = HealthcareTelephoneType.Mobile,
            },
        },
        UpdatedAt = System.DateTime.Parse("2026-06-16T03:41:04.400Z").ToUniversalTime(),
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

## GetHealthcarePatient

Retrieve a patient

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHealthcarePatient" method="get" path="/healthcare/{connection_id}/patient/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Patient.GetHealthcarePatientAsync(
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

## ListHealthcarePatients

List all patients

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

var res = await sdk.Patient.ListHealthcarePatientsAsync(req);

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

## PatchHealthcarePatient

Update a patient

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
            Address1 = "3645 Zoila Isle",
            Address2 = "Suite 613",
            City = "Jacintostead",
            Country = "US",
            PostalCode = "31579",
            Region = "Minnesota",
        },
        Birthdate = "2025-02-04",
        CreatedAt = System.DateTime.Parse("2021-06-05T21:08:04.917Z").ToUniversalTime(),
        Emails = new List<HealthcareEmail>() {
            new HealthcareEmail() {
                Email = "alejandrin.parker@yahoo.com",
                Type = HealthcareEmailType.Home,
            },
        },
        FirstName = "Alejandrin",
        Gender = HealthcarePatientGender.Female,
        Id = "7ab5f51e-44b9-4951-b740-3f3887335f7d",
        Identifiers = new List<HealthcareIdentifier>() {
            new HealthcareIdentifier() {
                Type = HealthcareIdentifierType.Mrn,
                Value = "92636004",
            },
        },
        IsActive = true,
        IsDeceased = false,
        Language = "en",
        LastName = "Parker",
        Metadata = new List<HealthcareMetadata>() {},
        Name = "Alejandrin Parker",
        PractitionerIds = new List<string>() {},
        Telephones = new List<HealthcareTelephone>() {
            new HealthcareTelephone() {
                Telephone = "659.223.0829 x590",
                Type = HealthcareTelephoneType.Mobile,
            },
        },
        UpdatedAt = System.DateTime.Parse("2026-06-16T03:41:04.419Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Patient.PatchHealthcarePatientAsync(req);

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

## UpdateHealthcarePatient

Update a patient

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
            Address1 = "3645 Zoila Isle",
            Address2 = "Suite 613",
            City = "Jacintostead",
            Country = "US",
            PostalCode = "31579",
            Region = "Minnesota",
        },
        Birthdate = "2025-02-04",
        CreatedAt = System.DateTime.Parse("2021-06-05T21:08:04.917Z").ToUniversalTime(),
        Emails = new List<HealthcareEmail>() {
            new HealthcareEmail() {
                Email = "alejandrin.parker@yahoo.com",
                Type = HealthcareEmailType.Home,
            },
        },
        FirstName = "Alejandrin",
        Gender = HealthcarePatientGender.Female,
        Id = "7ab5f51e-44b9-4951-b740-3f3887335f7d",
        Identifiers = new List<HealthcareIdentifier>() {
            new HealthcareIdentifier() {
                Type = HealthcareIdentifierType.Mrn,
                Value = "92636004",
            },
        },
        IsActive = true,
        IsDeceased = false,
        Language = "en",
        LastName = "Parker",
        Metadata = new List<HealthcareMetadata>() {},
        Name = "Alejandrin Parker",
        PractitionerIds = new List<string>() {},
        Telephones = new List<HealthcareTelephone>() {
            new HealthcareTelephone() {
                Telephone = "659.223.0829 x590",
                Type = HealthcareTelephoneType.Mobile,
            },
        },
        UpdatedAt = System.DateTime.Parse("2026-06-16T03:41:04.419Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Patient.UpdateHealthcarePatientAsync(req);

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