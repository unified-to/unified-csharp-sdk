# Patient

## Overview

### Available Operations

* [CreateHealthcarePatient](#createhealthcarepatient) - Create a patient
* [GetHealthcarePatient](#gethealthcarepatient) - Retrieve a patient
* [ListHealthcarePatients](#listhealthcarepatients) - List all patients
* [PatchHealthcarePatient](#patchhealthcarepatient) - Update a patient
* [UpdateHealthcarePatient](#updatehealthcarepatient) - Update a patient

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

var res = await sdk.Patient.CreateHealthcarePatientAsync(
    healthcarePatient: new HealthcarePatient() {
        Address = new PropertyHealthcarePatientAddress() {
            Address1 = "162 Kirlin Mall",
            City = "Dickinsonborough",
            Country = "US",
            PostalCode = "54031",
            Region = "Nebraska",
        },
        Birthdate = "2025-02-16",
        Contacts = new List<HealthcarePatientContact>() {
            new HealthcarePatientContact() {
                Emails = new List<HealthcareEmail>() {},
                Name = "Antonia Lebsack",
                Relationship = "Spouse",
                Telephones = new List<HealthcareTelephone>() {
                    new HealthcareTelephone() {
                        Telephone = "(695) 328-7029 x4412",
                        Type = HealthcareTelephoneType.Mobile,
                    },
                },
            },
        },
        CreatedAt = System.DateTime.Parse("2021-06-05T21:08:04.917Z").ToUniversalTime(),
        Emails = new List<HealthcareEmail>() {
            new HealthcareEmail() {
                Email = "alejandrin.parker@icloud.com",
                Type = HealthcareEmailType.Home,
            },
        },
        FirstName = "Alejandrin",
        Gender = HealthcarePatientGender.Female,
        Id = "c6cdd7e2-3430-4164-b27a-2a0bde1a9d02",
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
        UpdatedAt = System.DateTime.Parse("2026-06-26T13:57:53.254Z").ToUniversalTime(),
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

Retrieves a single HealthcarePatient by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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
        Birthdate = "2025-02-16",
        Contacts = new List<HealthcarePatientContact>() {
            new HealthcarePatientContact() {
                Emails = new List<HealthcareEmail>() {},
                Name = "Antonia Lebsack",
                Relationship = "Spouse",
                Telephones = new List<HealthcareTelephone>() {
                    new HealthcareTelephone() {
                        Telephone = "(695) 328-7029 x4412",
                        Type = HealthcareTelephoneType.Mobile,
                    },
                },
            },
        },
        CreatedAt = System.DateTime.Parse("2021-06-05T21:08:04.917Z").ToUniversalTime(),
        Emails = new List<HealthcareEmail>() {
            new HealthcareEmail() {
                Email = "alejandrin.parker@icloud.com",
                Type = HealthcareEmailType.Home,
            },
        },
        FirstName = "Alejandrin",
        Gender = HealthcarePatientGender.Female,
        Id = "868ec4c0-db6a-4f0b-a4f4-e518a64b51ea",
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
        UpdatedAt = System.DateTime.Parse("2026-06-26T13:57:53.287Z").ToUniversalTime(),
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
        Birthdate = "2025-02-16",
        Contacts = new List<HealthcarePatientContact>() {
            new HealthcarePatientContact() {
                Emails = new List<HealthcareEmail>() {},
                Name = "Antonia Lebsack",
                Relationship = "Spouse",
                Telephones = new List<HealthcareTelephone>() {
                    new HealthcareTelephone() {
                        Telephone = "(695) 328-7029 x4412",
                        Type = HealthcareTelephoneType.Mobile,
                    },
                },
            },
        },
        CreatedAt = System.DateTime.Parse("2021-06-05T21:08:04.917Z").ToUniversalTime(),
        Emails = new List<HealthcareEmail>() {
            new HealthcareEmail() {
                Email = "alejandrin.parker@icloud.com",
                Type = HealthcareEmailType.Home,
            },
        },
        FirstName = "Alejandrin",
        Gender = HealthcarePatientGender.Female,
        Id = "868ec4c0-db6a-4f0b-a4f4-e518a64b51ea",
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
        UpdatedAt = System.DateTime.Parse("2026-06-26T13:57:53.287Z").ToUniversalTime(),
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