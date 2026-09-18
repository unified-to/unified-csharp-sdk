# Hris

## Overview

### Available Operations

* [CreateHrisAttendance](#createhrisattendance) - Create an attendance
* [CreateHrisBankaccount](#createhrisbankaccount) - Create a bankaccount
* [CreateHrisBenefit](#createhrisbenefit) - Create a benefit
* [CreateHrisCompany](#createhriscompany) - Create a company
* [CreateHrisDeduction](#createhrisdeduction) - Create a deduction
* [CreateHrisDevice](#createhrisdevice) - Create a device
* [CreateHrisDocument](#createhrisdocument) - Create a document
* [CreateHrisEmployee](#createhrisemployee) - Create an employee
* [CreateHrisGroup](#createhrisgroup) - Create a group
* [CreateHrisLocation](#createhrislocation) - Create a location
* [CreateHrisTaxonomy](#createhristaxonomy) - Create a taxonomy
* [CreateHrisTimeoff](#createhristimeoff) - Create a timeoff
* [CreateHrisTimeshift](#createhristimeshift) - Create a timeshift
* [GetHrisAttendance](#gethrisattendance) - Retrieve an attendance
* [GetHrisBankaccount](#gethrisbankaccount) - Retrieve a bankaccount
* [GetHrisBenefit](#gethrisbenefit) - Retrieve a benefit
* [GetHrisCompany](#gethriscompany) - Retrieve a company
* [GetHrisDeduction](#gethrisdeduction) - Retrieve a deduction
* [GetHrisDevice](#gethrisdevice) - Retrieve a device
* [GetHrisDocument](#gethrisdocument) - Retrieve a document
* [GetHrisEmployee](#gethrisemployee) - Retrieve an employee
* [GetHrisGroup](#gethrisgroup) - Retrieve a group
* [GetHrisLocation](#gethrislocation) - Retrieve a location
* [GetHrisPayslip](#gethrispayslip) - Retrieve a payslip
* [GetHrisTaxonomy](#gethristaxonomy) - Retrieve a taxonomy
* [GetHrisTimeoff](#gethristimeoff) - Retrieve a timeoff
* [GetHrisTimeshift](#gethristimeshift) - Retrieve a timeshift
* [ListHrisAttendances](#listhrisattendances) - List all attendances
* [ListHrisBankaccounts](#listhrisbankaccounts) - List all bankaccounts
* [ListHrisBenefits](#listhrisbenefits) - List all benefits
* [ListHrisCompanies](#listhriscompanies) - List all companies
* [ListHrisDeductions](#listhrisdeductions) - List all deductions
* [ListHrisDevices](#listhrisdevices) - List all devices
* [ListHrisDocuments](#listhrisdocuments) - List all documents
* [ListHrisEmployees](#listhrisemployees) - List all employees
* [ListHrisGroups](#listhrisgroups) - List all groups
* [ListHrisLocations](#listhrislocations) - List all locations
* [ListHrisPayslips](#listhrispayslips) - List all payslips
* [ListHrisTaxonomies](#listhristaxonomies) - List all taxonomies
* [ListHrisTimeoffs](#listhristimeoffs) - List all timeoffs
* [ListHrisTimeshifts](#listhristimeshifts) - List all timeshifts
* [PatchHrisAttendance](#patchhrisattendance) - Update an attendance
* [PatchHrisBankaccount](#patchhrisbankaccount) - Update a bankaccount
* [PatchHrisBenefit](#patchhrisbenefit) - Update a benefit
* [PatchHrisCompany](#patchhriscompany) - Update a company
* [PatchHrisDeduction](#patchhrisdeduction) - Update a deduction
* [PatchHrisDevice](#patchhrisdevice) - Update a device
* [PatchHrisDocument](#patchhrisdocument) - Update a document
* [PatchHrisEmployee](#patchhrisemployee) - Update an employee
* [PatchHrisGroup](#patchhrisgroup) - Update a group
* [PatchHrisLocation](#patchhrislocation) - Update a location
* [PatchHrisTimeoff](#patchhristimeoff) - Update a timeoff
* [PatchHrisTimeshift](#patchhristimeshift) - Update a timeshift
* [RemoveHrisAttendance](#removehrisattendance) - Remove an attendance
* [RemoveHrisBankaccount](#removehrisbankaccount) - Remove a bankaccount
* [RemoveHrisBenefit](#removehrisbenefit) - Remove a benefit
* [RemoveHrisCompany](#removehriscompany) - Remove a company
* [RemoveHrisDeduction](#removehrisdeduction) - Remove a deduction
* [RemoveHrisDevice](#removehrisdevice) - Remove a device
* [RemoveHrisDocument](#removehrisdocument) - Remove a document
* [RemoveHrisEmployee](#removehrisemployee) - Remove an employee
* [RemoveHrisGroup](#removehrisgroup) - Remove a group
* [RemoveHrisLocation](#removehrislocation) - Remove a location
* [RemoveHrisTimeoff](#removehristimeoff) - Remove a timeoff
* [RemoveHrisTimeshift](#removehristimeshift) - Remove a timeshift
* [UpdateHrisAttendance](#updatehrisattendance) - Update an attendance
* [UpdateHrisBankaccount](#updatehrisbankaccount) - Update a bankaccount
* [UpdateHrisBenefit](#updatehrisbenefit) - Update a benefit
* [UpdateHrisCompany](#updatehriscompany) - Update a company
* [UpdateHrisDeduction](#updatehrisdeduction) - Update a deduction
* [UpdateHrisDevice](#updatehrisdevice) - Update a device
* [UpdateHrisDocument](#updatehrisdocument) - Update a document
* [UpdateHrisEmployee](#updatehrisemployee) - Update an employee
* [UpdateHrisGroup](#updatehrisgroup) - Update a group
* [UpdateHrisLocation](#updatehrislocation) - Update a location
* [UpdateHrisTimeoff](#updatehristimeoff) - Update a timeoff
* [UpdateHrisTimeshift](#updatehristimeshift) - Update a timeshift

## CreateHrisAttendance

Create an attendance

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createHrisAttendance" method="post" path="/hris/{connection_id}/attendance" example="hris_attendance" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.CreateHrisAttendanceAsync(
    hrisAttendance: new HrisAttendance() {
        Address = new PropertyHrisAttendanceAddress() {
            Address1 = "14108 Allie Flats",
            City = "Kearaborough",
            CountryCode = "US",
            PostalCode = "23844-2344",
            Region = "Tennessee",
            RegionCode = "CA",
        },
        ApprovedAt = System.DateTime.Parse("2021-08-13T10:36:02.699Z").ToUniversalTime(),
        Breaks = new List<HrisAttendanceBreak>() {
            new HrisAttendanceBreak() {
                DurationMinutes = 12D,
                EndAt = System.DateTime.Parse("2023-10-22T16:22:57.211Z").ToUniversalTime(),
                Id = "d60a1001-5a8a-4991-8c21-f4da6036cc87",
                IsPaid = true,
                Name = "Lunch",
                StartAt = System.DateTime.Parse("2023-10-15T20:49:16.476Z").ToUniversalTime(),
            },
        },
        CreatedAt = System.DateTime.Parse("2021-08-10T19:43:18.452Z").ToUniversalTime(),
        Currency = "UGX",
        DeclaredTipsAmount = 161D,
        EmployeeUserId = "<id>",
        EndAt = System.DateTime.Parse("2024-04-06T03:56:34.906Z").ToUniversalTime(),
        HourlyRate = 53D,
        Hours = 10D,
        Id = "e9e33831-f1ad-4fd0-8ca4-1a008527e535",
        JobName = "Global Creative Supervisor",
        NonCashTipsAmount = 54D,
        StartAt = System.DateTime.Parse("2021-11-09T10:26:01.081Z").ToUniversalTime(),
        Status = HrisAttendanceStatus.Closed,
        Timezone = "America/Atikokan",
        UpdatedAt = System.DateTime.Parse("2022-01-17T01:25:06.883Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `HrisAttendance`                                                                                                                                 | [HrisAttendance](../../Models/Components/HrisAttendance.md)                                                                                      | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateHrisAttendanceQueryParamFields](../../Models/Requests/CreateHrisAttendanceQueryParamFields.md)>                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateHrisAttendanceResponse](../../Models/Requests/CreateHrisAttendanceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateHrisBankaccount

Create a bankaccount

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createHrisBankaccount" method="post" path="/hris/{connection_id}/bankaccount" example="hris_bankaccount" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.CreateHrisBankaccountAsync(
    hrisBankaccount: new HrisBankaccount() {
        AccountNumber = "****3777",
        AccountNumberLast4 = "3777",
        AccountType = HrisBankaccountAccountType.Checking,
        BankName = "Huel Group",
        CreatedAt = System.DateTime.Parse("2019-11-16T16:43:45.976Z").ToUniversalTime(),
        Id = "0ba01940-59d2-4fcb-a5b2-8633146c7a07",
        IsPrimary = false,
        Name = "Checking Account",
        RoutingNumber = "448650724",
        UpdatedAt = System.DateTime.Parse("2025-06-04T11:31:37.518Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `HrisBankaccount`                                                                                                                                | [HrisBankaccount](../../Models/Components/HrisBankaccount.md)                                                                                    | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateHrisBankaccountQueryParamFields](../../Models/Requests/CreateHrisBankaccountQueryParamFields.md)>                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateHrisBankaccountResponse](../../Models/Requests/CreateHrisBankaccountResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateHrisBenefit

Create a benefit

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createHrisBenefit" method="post" path="/hris/{connection_id}/benefit" example="hris_benefit" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.CreateHrisBenefitAsync(
    hrisBenefit: new HrisBenefit() {
        CoverageLevel = CoverageLevel.EmployeeSpouse,
        CreatedAt = System.DateTime.Parse("2020-06-11T01:24:05.654Z").ToUniversalTime(),
        Currency = "JOD",
        Description = "Vomito voluptas dolor sed.",
        EmployerContributionAmount = 185006D,
        EmployerContributionMaxAmount = 179093D,
        EmployerContributionType = EmployerContributionType.Percentage,
        Frequency = HrisBenefitFrequency.Hour,
        Id = "56df050c-d73e-477d-a39f-341eca6ae236",
        IsActive = false,
        Name = "Frozen Wooden Ball",
        Tax = Tax.PreTax,
        Type = HrisBenefitType.Garnishment,
        UpdatedAt = System.DateTime.Parse("2023-03-06T11:00:57.658Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `HrisBenefit`                                                                                                                                    | [HrisBenefit](../../Models/Components/HrisBenefit.md)                                                                                            | :heavy_check_mark:                                                                                                                               | Company-wide benefit plans available to employees.                                                                                               |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateHrisBenefitQueryParamFields](../../Models/Requests/CreateHrisBenefitQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateHrisBenefitResponse](../../Models/Requests/CreateHrisBenefitResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateHrisCompany

Create a company

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createHrisCompany" method="post" path="/hris/{connection_id}/company" example="hris_company" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.CreateHrisCompanyAsync(
    hrisCompany: new HrisCompany() {
        Address = new PropertyHrisCompanyAddress() {
            Address1 = "2549 Church Walk",
            City = "Lake Nettiebury",
            CountryCode = "US",
            PostalCode = "32877-4898",
            Region = "Idaho",
            RegionCode = "PA",
        },
        CreatedAt = System.DateTime.Parse("2021-05-02T22:27:38.970Z").ToUniversalTime(),
        Id = "698ffe76-ccdf-460f-8855-4518977a5977",
        LegalName = "Schultz LLC",
        Name = "Gottlieb Group",
        UpdatedAt = System.DateTime.Parse("2026-09-05T21:12:19.808Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `HrisCompany`                                                                                                                                    | [HrisCompany](../../Models/Components/HrisCompany.md)                                                                                            | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateHrisCompanyQueryParamFields](../../Models/Requests/CreateHrisCompanyQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateHrisCompanyResponse](../../Models/Requests/CreateHrisCompanyResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateHrisDeduction

Create a deduction

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createHrisDeduction" method="post" path="/hris/{connection_id}/deduction" example="hris_deduction" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.CreateHrisDeductionAsync(
    hrisDeduction: new HrisDeduction() {
        Amount = 139655D,
        CoverageLevel = HrisDeductionCoverageLevel.EmployeeOnly,
        CreatedAt = System.DateTime.Parse("2020-02-05T01:46:31.384Z").ToUniversalTime(),
        EndAt = System.DateTime.Parse("2026-05-22T22:53:01.272Z").ToUniversalTime(),
        Frequency = HrisDeductionFrequency.Month,
        Id = "53b67e29-3fbf-4518-9dc8-46caa54fd502",
        IsActive = false,
        Notes = "Carmen desidero.",
        StartAt = System.DateTime.Parse("2025-02-18T04:38:44.652Z").ToUniversalTime(),
        Type = HrisDeductionType.Fixed,
        UpdatedAt = System.DateTime.Parse("2024-03-01T23:42:32.713Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `HrisDeduction`                                                                                                                                  | [HrisDeduction](../../Models/Components/HrisDeduction.md)                                                                                        | :heavy_check_mark:                                                                                                                               | Employee-specific deduction/benefit enrolment.                                                                                                   |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateHrisDeductionQueryParamFields](../../Models/Requests/CreateHrisDeductionQueryParamFields.md)>                                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateHrisDeductionResponse](../../Models/Requests/CreateHrisDeductionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateHrisDevice

Create a device

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createHrisDevice" method="post" path="/hris/{connection_id}/device" example="hris_device" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.CreateHrisDeviceAsync(
    hrisDevice: new HrisDevice() {
        AdminUserIds = new List<string>() {},
        AssetTag = "dpho9OuFNG",
        CreatedAt = System.DateTime.Parse("2019-04-04T17:11:40.322Z").ToUniversalTime(),
        HasAntivirus = false,
        HasFirewall = true,
        HasHdEncrypted = true,
        HasPasswordManager = true,
        HasScreenlock = true,
        Id = "bcac94b2-e48a-44d8-85bb-72b920f6ac73",
        IsMissing = false,
        Manufacturer = "Sanford - Hamill",
        Model = "Refined",
        Name = "cross_contamination_if.rar",
        Os = "monitor",
        OsVersion = "1.12.16",
        UpdatedAt = System.DateTime.Parse("2023-05-21T00:56:51.337Z").ToUniversalTime(),
        Version = "2.20.17",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `HrisDevice`                                                                                                                                     | [HrisDevice](../../Models/Components/HrisDevice.md)                                                                                              | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateHrisDeviceQueryParamFields](../../Models/Requests/CreateHrisDeviceQueryParamFields.md)>                                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateHrisDeviceResponse](../../Models/Requests/CreateHrisDeviceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateHrisDocument

Create a document

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createHrisDocument" method="post" path="/hris/{connection_id}/document" example="hris_document" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.CreateHrisDocumentAsync(
    hrisDocument: new HrisDocument() {
        CreatedAt = System.DateTime.Parse("2022-10-27T11:47:26.086Z").ToUniversalTime(),
        DocumentUrl = "https://sore-decision.biz/",
        Filename = "ridge_forager.xsl",
        Id = "8e78f38f-1432-40b1-b0e2-deaf6644714c",
        Type = HrisDocumentType.Policy,
        UpdatedAt = System.DateTime.Parse("2025-09-17T01:55:35.563Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `HrisDocument`                                                                                                                                   | [HrisDocument](../../Models/Components/HrisDocument.md)                                                                                          | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateHrisDocumentQueryParamFields](../../Models/Requests/CreateHrisDocumentQueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateHrisDocumentResponse](../../Models/Requests/CreateHrisDocumentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateHrisEmployee

Create an employee

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createHrisEmployee" method="post" path="/hris/{connection_id}/employee" example="hris_employee" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.CreateHrisEmployeeAsync(
    hrisEmployee: new HrisEmployee() {
        Address = new PropertyHrisEmployeeAddress() {
            Address1 = "52008 Lansdowne Road",
            Address2 = "Apt. 101",
            City = "Connellyberg",
            CountryCode = "US",
            PostalCode = "18978",
            Region = "South Dakota",
            RegionCode = "NM",
        },
        Bio = "sushi devotee, singer",
        Compensation = new List<HrisCompensation>() {
            new HrisCompensation() {
                Amount = 69148D,
                Currency = "CRC",
                Frequency = HrisCompensationFrequency.Quarter,
                Notes = "Tergeo laborum laboriosam tutis.",
                Type = HrisCompensationType.Equity,
            },
        },
        CreatedAt = System.DateTime.Parse("2019-09-16T15:08:53.262Z").ToUniversalTime(),
        Currency = "IDR",
        DateOfBirth = System.DateTime.Parse("2001-04-22").ToUniversalTime(),
        Emails = new List<HrisEmail>() {
            new HrisEmail() {
                Email = "Zetta_Prohaska67@hotmail.com",
                Type = HrisEmailType.Home,
            },
        },
        EmployeeNumber = "YuOt169CGu",
        EmploymentStatus = EmploymentStatus.Active,
        EmploymentType = HrisEmployeeEmploymentType.Volunteer,
        FirstName = "Zetta",
        Gender = HrisEmployeeGender.Intersex,
        HasMfa = true,
        HiredAt = System.DateTime.Parse("2023-05-10T16:15:07.653Z").ToUniversalTime(),
        Id = "1dfdcf05-413d-4fb8-82f1-fe4ed9681c02",
        ImageUrl = "https://loremflickr.com/3684/2116?lock=4686991638584456",
        LanguageLocale = "es",
        LastName = "Prohaska",
        Locations = new List<HrisLocation>() {},
        MaritalStatus = MaritalStatus.Married,
        Metadata = new List<HrisMetadata>() {
            new HrisMetadata() {
                ExtraData = HrisMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = HrisMetadataFormat.Text,
                Id = "1af6cea0-5868-4220-b922-55797633b82d",
                Namespace = "custom",
                Slug = "custom_property",
                Value = HrisMetadataValue.CreateStr(
                    "tenetur"
                ),
            },
        },
        Name = "Zetta Prohaska",
        Pronouns = "she/her",
        Relationships = new List<HrisEmployeerelationship>() {
            new HrisEmployeerelationship() {
                Emails = new List<HrisEmail>() {
                    new HrisEmail() {
                        Email = "Deshaun.Sanford24@yahoo.com",
                    },
                    new HrisEmail() {
                        Email = "Rebeca.Dibbert11@hotmail.com",
                    },
                    new HrisEmail() {
                        Email = "Hester80@gmail.com",
                    },
                },
                Name = "Automotive",
                Type = HrisEmployeerelationshipType.Emergency,
            },
            new HrisEmployeerelationship() {
                Emails = new List<HrisEmail>() {
                    new HrisEmail() {
                        Email = "Benedict_Wisozk83@hotmail.com",
                    },
                    new HrisEmail() {
                        Email = "Princess_Rath43@gmail.com",
                    },
                    new HrisEmail() {
                        Email = "Elmira92@yahoo.com",
                    },
                },
                Name = "Music",
                Type = HrisEmployeerelationshipType.Friend,
            },
            new HrisEmployeerelationship() {
                Emails = new List<HrisEmail>() {
                    new HrisEmail() {
                        Email = "Jane30@gmail.com",
                    },
                },
                Name = "Jewelry",
                Type = HrisEmployeerelationshipType.Sibling,
            },
        },
        Salutation = "Miss",
        SsnSin = "yMRtj0Q3xO",
        StorageQuotaAllocated = 3674489D,
        StorageQuotaAvailable = 7748057D,
        StorageQuotaUsed = 301727D,
        Telephones = new List<HrisTelephone>() {
            new HrisTelephone() {
                Telephone = "(409) 801-3705",
                Type = HrisTelephoneType.Fax,
            },
        },
        TerminationReason = "Communis adnuo damnatio atavus terebro acies canis cogito triumphus creber temptatio defendo cubo amissio paulatim corroboro.",
        TimeoffDaysTotal = 12D,
        TimeoffDaysUsed = 6D,
        Timezone = "Africa/Harare",
        Title = "Investor Paradigm Liaison",
        UpdatedAt = System.DateTime.Parse("2022-02-19T07:02:15.352Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `HrisEmployee`                                                                                                                                   | [HrisEmployee](../../Models/Components/HrisEmployee.md)                                                                                          | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateHrisEmployeeQueryParamFields](../../Models/Requests/CreateHrisEmployeeQueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateHrisEmployeeResponse](../../Models/Requests/CreateHrisEmployeeResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateHrisGroup

Create a group

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createHrisGroup" method="post" path="/hris/{connection_id}/group" example="hris_group" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.CreateHrisGroupAsync(
    hrisGroup: new HrisGroup() {
        CreatedAt = System.DateTime.Parse("2023-11-01T13:13:40.714Z").ToUniversalTime(),
        Description = "Absorbeo casso.",
        Id = "929982e7-4f14-49ea-83cc-de83a6e8059c",
        IsActive = false,
        Name = "Games",
        Type = HrisGroupType.BusinessUnit,
        UpdatedAt = System.DateTime.Parse("2026-04-23T14:25:48.389Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `HrisGroup`                                                                                                                                      | [HrisGroup](../../Models/Components/HrisGroup.md)                                                                                                | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateHrisGroupQueryParamFields](../../Models/Requests/CreateHrisGroupQueryParamFields.md)>                                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateHrisGroupResponse](../../Models/Requests/CreateHrisGroupResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateHrisLocation

Create a location

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createHrisLocation" method="post" path="/hris/{connection_id}/location" example="hris_location" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.CreateHrisLocationAsync(
    hrisLocation: new HrisLocation() {
        Address = new PropertyHrisLocationAddress() {
            Address1 = "2743 Connelly Summit",
            Address2 = "Apt. 350",
            City = "Titusville",
            CountryCode = "US",
            PostalCode = "16154-1095",
            Region = "Oregon",
            RegionCode = "AL",
        },
        CreatedAt = System.DateTime.Parse("2021-07-18T10:32:01.414Z").ToUniversalTime(),
        Currency = "MUR",
        Description = "Acervus caries.",
        ExternalIdentifier = "76a05081-d11e-4359-8f85-19fd2875e804",
        Id = "48338c1d-ca7f-4eb0-bc12-a5468160ffea",
        IsActive = true,
        IsHq = false,
        LanguageLocale = "fr",
        Name = "adhuc",
        Telephones = new List<HrisTelephone>() {
            new HrisTelephone() {
                Telephone = "(710) 550-6997",
                Type = HrisTelephoneType.Fax,
            },
            new HrisTelephone() {
                Telephone = "(208) 555-8542",
                Type = HrisTelephoneType.Home,
            },
            new HrisTelephone() {
                Telephone = "(712) 473-5482",
                Type = HrisTelephoneType.Fax,
            },
        },
        Timezone = "America/Guyana",
        UpdatedAt = System.DateTime.Parse("2023-06-09T00:40:22.393Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `HrisLocation`                                                                                                                                   | [HrisLocation](../../Models/Components/HrisLocation.md)                                                                                          | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateHrisLocationQueryParamFields](../../Models/Requests/CreateHrisLocationQueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateHrisLocationResponse](../../Models/Requests/CreateHrisLocationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateHrisTaxonomy

Create a taxonomy

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createHrisTaxonomy" method="post" path="/hris/{connection_id}/taxonomy" example="hris_taxonomy" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.CreateHrisTaxonomyAsync(
    hrisTaxonomy: new HrisTaxonomy() {
        CreatedAt = System.DateTime.Parse("2022-06-23T02:10:00.789Z").ToUniversalTime(),
        Description = "Apto demonstro audacia adstringo cursim tristis solio careo.",
        Domain = "Electronics",
        Id = "ede085db-5709-4d53-a490-746f3de5be17",
        IsActive = false,
        Name = "International Functionality Architect",
        ParentId = "6524b2a7-6520-4e15-8c4e-1aa6793db837",
        RoleIds = new List<string>() {
            "2b1ef757-eb4c-4207-8af1-929afe49cd65",
        },
        Subcategory = "Bamboo",
        Type = HrisTaxonomyType.Knowledge,
        UpdatedAt = System.DateTime.Parse("2023-05-22T04:57:43.336Z").ToUniversalTime(),
        Url = "https://our-polarisation.name",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `HrisTaxonomy`                                                                                                                                   | [HrisTaxonomy](../../Models/Components/HrisTaxonomy.md)                                                                                          | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateHrisTaxonomyQueryParamFields](../../Models/Requests/CreateHrisTaxonomyQueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateHrisTaxonomyResponse](../../Models/Requests/CreateHrisTaxonomyResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateHrisTimeoff

Create a timeoff

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createHrisTimeoff" method="post" path="/hris/{connection_id}/timeoff" example="hris_timeoff" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.CreateHrisTimeoffAsync(
    hrisTimeoff: new HrisTimeoff() {
        ApprovedAt = System.DateTime.Parse("2022-02-20T21:02:44.024Z").ToUniversalTime(),
        Comments = "Blandior ventus curiositas amplitudo.",
        CreatedAt = System.DateTime.Parse("2021-10-06T18:00:20.615Z").ToUniversalTime(),
        Duration = 4D,
        DurationType = DurationType.Day,
        EndAt = System.DateTime.Parse("2024-12-07T13:51:48.890Z").ToUniversalTime(),
        Id = "f08121ee-1d8f-478a-89f5-5a8d207ad122",
        IsPaid = true,
        OriginalType = "acerbitas ut",
        Reason = "verto",
        StartAt = System.DateTime.Parse("2023-08-23T06:57:16.399Z").ToUniversalTime(),
        Status = HrisTimeoffStatus.Denied,
        Type = HrisTimeoffType.InLieu,
        UpdatedAt = System.DateTime.Parse("2022-07-07T19:35:06.898Z").ToUniversalTime(),
        UserId = "<id>",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `HrisTimeoff`                                                                                                                                    | [HrisTimeoff](../../Models/Components/HrisTimeoff.md)                                                                                            | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateHrisTimeoffQueryParamFields](../../Models/Requests/CreateHrisTimeoffQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateHrisTimeoffResponse](../../Models/Requests/CreateHrisTimeoffResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateHrisTimeshift

Create a timeshift

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createHrisTimeshift" method="post" path="/hris/{connection_id}/timeshift" example="hris_timeshift" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.CreateHrisTimeshiftAsync(
    hrisTimeshift: new HrisTimeshift() {
        ApprovedAt = System.DateTime.Parse("2023-06-05T14:32:23.860Z").ToUniversalTime(),
        Compensation = new List<HrisCompensation>() {
            new HrisCompensation() {
                Amount = 76761D,
                Currency = "JPY",
                Frequency = HrisCompensationFrequency.Hour,
                Notes = "Annus adficio suasoria architecto aggero.",
                Type = HrisCompensationType.Other,
            },
        },
        CreatedAt = System.DateTime.Parse("2019-07-01T23:53:15.738Z").ToUniversalTime(),
        EmployeeUserId = "<id>",
        EndAt = System.DateTime.Parse("2026-08-25T08:29:34.504Z").ToUniversalTime(),
        Hours = 8D,
        Id = "edb7e65d-ee9c-4de9-bf02-4dccb2d29377",
        IsApproved = true,
        StartAt = System.DateTime.Parse("2023-06-24T19:30:14.691Z").ToUniversalTime(),
        UpdatedAt = System.DateTime.Parse("2021-06-22T20:53:37.144Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `HrisTimeshift`                                                                                                                                  | [HrisTimeshift](../../Models/Components/HrisTimeshift.md)                                                                                        | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateHrisTimeshiftQueryParamFields](../../Models/Requests/CreateHrisTimeshiftQueryParamFields.md)>                                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateHrisTimeshiftResponse](../../Models/Requests/CreateHrisTimeshiftResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetHrisAttendance

Retrieve an attendance

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHrisAttendance" method="get" path="/hris/{connection_id}/attendance/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.GetHrisAttendanceAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Attendance                                                                                                                             |
| `Fields`                                                                                                                                         | List<[GetHrisAttendanceQueryParamFields](../../Models/Requests/GetHrisAttendanceQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHrisAttendanceResponse](../../Models/Requests/GetHrisAttendanceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetHrisBankaccount

Retrieve a bankaccount

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHrisBankaccount" method="get" path="/hris/{connection_id}/bankaccount/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.GetHrisBankaccountAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Bankaccount                                                                                                                            |
| `Fields`                                                                                                                                         | List<[GetHrisBankaccountQueryParamFields](../../Models/Requests/GetHrisBankaccountQueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHrisBankaccountResponse](../../Models/Requests/GetHrisBankaccountResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetHrisBenefit

Retrieve a benefit

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHrisBenefit" method="get" path="/hris/{connection_id}/benefit/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.GetHrisBenefitAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Benefit                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetHrisBenefitQueryParamFields](../../Models/Requests/GetHrisBenefitQueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHrisBenefitResponse](../../Models/Requests/GetHrisBenefitResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetHrisCompany

Retrieve a company

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHrisCompany" method="get" path="/hris/{connection_id}/company/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.GetHrisCompanyAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Company                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetHrisCompanyQueryParamFields](../../Models/Requests/GetHrisCompanyQueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHrisCompanyResponse](../../Models/Requests/GetHrisCompanyResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetHrisDeduction

Retrieve a deduction

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHrisDeduction" method="get" path="/hris/{connection_id}/deduction/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.GetHrisDeductionAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Deduction                                                                                                                              |
| `Fields`                                                                                                                                         | List<[GetHrisDeductionQueryParamFields](../../Models/Requests/GetHrisDeductionQueryParamFields.md)>                                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHrisDeductionResponse](../../Models/Requests/GetHrisDeductionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetHrisDevice

Retrieve a device

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHrisDevice" method="get" path="/hris/{connection_id}/device/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.GetHrisDeviceAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Device                                                                                                                                 |
| `Fields`                                                                                                                                         | List<[GetHrisDeviceQueryParamFields](../../Models/Requests/GetHrisDeviceQueryParamFields.md)>                                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHrisDeviceResponse](../../Models/Requests/GetHrisDeviceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetHrisDocument

Retrieve a document

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHrisDocument" method="get" path="/hris/{connection_id}/document/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.GetHrisDocumentAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Document                                                                                                                               |
| `Fields`                                                                                                                                         | List<[GetHrisDocumentQueryParamFields](../../Models/Requests/GetHrisDocumentQueryParamFields.md)>                                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHrisDocumentResponse](../../Models/Requests/GetHrisDocumentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetHrisEmployee

Retrieve an employee

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHrisEmployee" method="get" path="/hris/{connection_id}/employee/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.GetHrisEmployeeAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Employee                                                                                                                               |
| `Fields`                                                                                                                                         | List<[GetHrisEmployeeQueryParamFields](../../Models/Requests/GetHrisEmployeeQueryParamFields.md)>                                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHrisEmployeeResponse](../../Models/Requests/GetHrisEmployeeResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetHrisGroup

Retrieve a group

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHrisGroup" method="get" path="/hris/{connection_id}/group/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.GetHrisGroupAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Group                                                                                                                                  |
| `Fields`                                                                                                                                         | List<[GetHrisGroupQueryParamFields](../../Models/Requests/GetHrisGroupQueryParamFields.md)>                                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHrisGroupResponse](../../Models/Requests/GetHrisGroupResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetHrisLocation

Retrieve a location

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHrisLocation" method="get" path="/hris/{connection_id}/location/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.GetHrisLocationAsync(
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
| `Fields`                                                                                                                                         | List<[GetHrisLocationQueryParamFields](../../Models/Requests/GetHrisLocationQueryParamFields.md)>                                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHrisLocationResponse](../../Models/Requests/GetHrisLocationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetHrisPayslip

Retrieve a payslip

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHrisPayslip" method="get" path="/hris/{connection_id}/payslip/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.GetHrisPayslipAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Payslip                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetHrisPayslipQueryParamFields](../../Models/Requests/GetHrisPayslipQueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHrisPayslipResponse](../../Models/Requests/GetHrisPayslipResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetHrisTaxonomy

Retrieve a taxonomy

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHrisTaxonomy" method="get" path="/hris/{connection_id}/taxonomy/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.GetHrisTaxonomyAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Taxonomy                                                                                                                               |
| `Fields`                                                                                                                                         | List<[GetHrisTaxonomyQueryParamFields](../../Models/Requests/GetHrisTaxonomyQueryParamFields.md)>                                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHrisTaxonomyResponse](../../Models/Requests/GetHrisTaxonomyResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetHrisTimeoff

Retrieve a timeoff

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHrisTimeoff" method="get" path="/hris/{connection_id}/timeoff/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.GetHrisTimeoffAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Timeoff                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetHrisTimeoffQueryParamFields](../../Models/Requests/GetHrisTimeoffQueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHrisTimeoffResponse](../../Models/Requests/GetHrisTimeoffResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetHrisTimeshift

Retrieve a timeshift

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHrisTimeshift" method="get" path="/hris/{connection_id}/timeshift/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.GetHrisTimeshiftAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Timeshift                                                                                                                              |
| `Fields`                                                                                                                                         | List<[GetHrisTimeshiftQueryParamFields](../../Models/Requests/GetHrisTimeshiftQueryParamFields.md)>                                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHrisTimeshiftResponse](../../Models/Requests/GetHrisTimeshiftResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListHrisAttendances

List all attendances

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listHrisAttendances" method="get" path="/hris/{connection_id}/attendance" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHrisAttendancesRequest req = new ListHrisAttendancesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Hris.ListHrisAttendancesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ListHrisAttendancesRequest](../../Models/Requests/ListHrisAttendancesRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[ListHrisAttendancesResponse](../../Models/Requests/ListHrisAttendancesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListHrisBankaccounts

List all bankaccounts

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listHrisBankaccounts" method="get" path="/hris/{connection_id}/bankaccount" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHrisBankaccountsRequest req = new ListHrisBankaccountsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Hris.ListHrisBankaccountsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [ListHrisBankaccountsRequest](../../Models/Requests/ListHrisBankaccountsRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[ListHrisBankaccountsResponse](../../Models/Requests/ListHrisBankaccountsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListHrisBenefits

List all benefits

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listHrisBenefits" method="get" path="/hris/{connection_id}/benefit" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHrisBenefitsRequest req = new ListHrisBenefitsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Hris.ListHrisBenefitsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListHrisBenefitsRequest](../../Models/Requests/ListHrisBenefitsRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[ListHrisBenefitsResponse](../../Models/Requests/ListHrisBenefitsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListHrisCompanies

List all companies

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listHrisCompanies" method="get" path="/hris/{connection_id}/company" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHrisCompaniesRequest req = new ListHrisCompaniesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Hris.ListHrisCompaniesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListHrisCompaniesRequest](../../Models/Requests/ListHrisCompaniesRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[ListHrisCompaniesResponse](../../Models/Requests/ListHrisCompaniesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListHrisDeductions

List all deductions

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listHrisDeductions" method="get" path="/hris/{connection_id}/deduction" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHrisDeductionsRequest req = new ListHrisDeductionsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Hris.ListHrisDeductionsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [ListHrisDeductionsRequest](../../Models/Requests/ListHrisDeductionsRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[ListHrisDeductionsResponse](../../Models/Requests/ListHrisDeductionsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListHrisDevices

List all devices

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listHrisDevices" method="get" path="/hris/{connection_id}/device" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHrisDevicesRequest req = new ListHrisDevicesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Hris.ListHrisDevicesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [ListHrisDevicesRequest](../../Models/Requests/ListHrisDevicesRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[ListHrisDevicesResponse](../../Models/Requests/ListHrisDevicesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListHrisDocuments

List all documents

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listHrisDocuments" method="get" path="/hris/{connection_id}/document" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHrisDocumentsRequest req = new ListHrisDocumentsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Hris.ListHrisDocumentsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListHrisDocumentsRequest](../../Models/Requests/ListHrisDocumentsRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[ListHrisDocumentsResponse](../../Models/Requests/ListHrisDocumentsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListHrisEmployees

List all employees

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listHrisEmployees" method="get" path="/hris/{connection_id}/employee" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHrisEmployeesRequest req = new ListHrisEmployeesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Hris.ListHrisEmployeesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListHrisEmployeesRequest](../../Models/Requests/ListHrisEmployeesRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[ListHrisEmployeesResponse](../../Models/Requests/ListHrisEmployeesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListHrisGroups

List all groups

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listHrisGroups" method="get" path="/hris/{connection_id}/group" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHrisGroupsRequest req = new ListHrisGroupsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Hris.ListHrisGroupsAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [ListHrisGroupsRequest](../../Models/Requests/ListHrisGroupsRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[ListHrisGroupsResponse](../../Models/Requests/ListHrisGroupsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListHrisLocations

List all locations

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listHrisLocations" method="get" path="/hris/{connection_id}/location" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHrisLocationsRequest req = new ListHrisLocationsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Hris.ListHrisLocationsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListHrisLocationsRequest](../../Models/Requests/ListHrisLocationsRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[ListHrisLocationsResponse](../../Models/Requests/ListHrisLocationsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListHrisPayslips

List all payslips

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listHrisPayslips" method="get" path="/hris/{connection_id}/payslip" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHrisPayslipsRequest req = new ListHrisPayslipsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Hris.ListHrisPayslipsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListHrisPayslipsRequest](../../Models/Requests/ListHrisPayslipsRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[ListHrisPayslipsResponse](../../Models/Requests/ListHrisPayslipsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListHrisTaxonomies

List all taxonomies

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listHrisTaxonomies" method="get" path="/hris/{connection_id}/taxonomy" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHrisTaxonomiesRequest req = new ListHrisTaxonomiesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Hris.ListHrisTaxonomiesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [ListHrisTaxonomiesRequest](../../Models/Requests/ListHrisTaxonomiesRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[ListHrisTaxonomiesResponse](../../Models/Requests/ListHrisTaxonomiesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListHrisTimeoffs

List all timeoffs

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listHrisTimeoffs" method="get" path="/hris/{connection_id}/timeoff" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHrisTimeoffsRequest req = new ListHrisTimeoffsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Hris.ListHrisTimeoffsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListHrisTimeoffsRequest](../../Models/Requests/ListHrisTimeoffsRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[ListHrisTimeoffsResponse](../../Models/Requests/ListHrisTimeoffsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListHrisTimeshifts

List all timeshifts

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listHrisTimeshifts" method="get" path="/hris/{connection_id}/timeshift" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHrisTimeshiftsRequest req = new ListHrisTimeshiftsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Hris.ListHrisTimeshiftsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [ListHrisTimeshiftsRequest](../../Models/Requests/ListHrisTimeshiftsRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[ListHrisTimeshiftsResponse](../../Models/Requests/ListHrisTimeshiftsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchHrisAttendance

Update an attendance

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchHrisAttendance" method="patch" path="/hris/{connection_id}/attendance/{id}" example="hris_attendance" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchHrisAttendanceRequest req = new PatchHrisAttendanceRequest() {
    HrisAttendance = new HrisAttendance() {
        Address = new PropertyHrisAttendanceAddress() {
            Address1 = "14108 Allie Flats",
            City = "Kearaborough",
            CountryCode = "US",
            PostalCode = "23844-2344",
            Region = "Tennessee",
            RegionCode = "CA",
        },
        ApprovedAt = System.DateTime.Parse("2021-08-13T10:36:02.699Z").ToUniversalTime(),
        Breaks = new List<HrisAttendanceBreak>() {
            new HrisAttendanceBreak() {
                DurationMinutes = 12D,
                EndAt = System.DateTime.Parse("2023-10-22T16:22:57.221Z").ToUniversalTime(),
                Id = "d60a1001-5a8a-4991-8c21-f4da6036cc87",
                IsPaid = true,
                Name = "Lunch",
                StartAt = System.DateTime.Parse("2023-10-15T20:49:16.485Z").ToUniversalTime(),
            },
        },
        CreatedAt = System.DateTime.Parse("2021-08-10T19:43:18.452Z").ToUniversalTime(),
        Currency = "UGX",
        DeclaredTipsAmount = 161D,
        EmployeeUserId = "<id>",
        EndAt = System.DateTime.Parse("2024-04-06T03:56:34.918Z").ToUniversalTime(),
        HourlyRate = 53D,
        Hours = 10D,
        Id = "34ef1ed7-4863-409e-bd2a-2522d8f43302",
        JobName = "Global Creative Supervisor",
        NonCashTipsAmount = 54D,
        StartAt = System.DateTime.Parse("2021-11-09T10:26:01.082Z").ToUniversalTime(),
        Status = HrisAttendanceStatus.Closed,
        Timezone = "America/Atikokan",
        UpdatedAt = System.DateTime.Parse("2022-01-17T01:25:06.885Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Hris.PatchHrisAttendanceAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [PatchHrisAttendanceRequest](../../Models/Requests/PatchHrisAttendanceRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[PatchHrisAttendanceResponse](../../Models/Requests/PatchHrisAttendanceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchHrisBankaccount

Update a bankaccount

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchHrisBankaccount" method="patch" path="/hris/{connection_id}/bankaccount/{id}" example="hris_bankaccount" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchHrisBankaccountRequest req = new PatchHrisBankaccountRequest() {
    HrisBankaccount = new HrisBankaccount() {
        AccountNumber = "****3777",
        AccountNumberLast4 = "3777",
        AccountType = HrisBankaccountAccountType.Checking,
        BankName = "Huel Group",
        CreatedAt = System.DateTime.Parse("2019-11-16T16:43:45.976Z").ToUniversalTime(),
        Id = "48efbe5b-f668-403e-9979-a07b0ec0a98a",
        IsPrimary = false,
        Name = "Checking Account",
        RoutingNumber = "448650724",
        UpdatedAt = System.DateTime.Parse("2025-06-04T11:31:37.525Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Hris.PatchHrisBankaccountAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [PatchHrisBankaccountRequest](../../Models/Requests/PatchHrisBankaccountRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[PatchHrisBankaccountResponse](../../Models/Requests/PatchHrisBankaccountResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchHrisBenefit

Update a benefit

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchHrisBenefit" method="patch" path="/hris/{connection_id}/benefit/{id}" example="hris_benefit" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchHrisBenefitRequest req = new PatchHrisBenefitRequest() {
    HrisBenefit = new HrisBenefit() {
        CoverageLevel = CoverageLevel.EmployeeSpouse,
        CreatedAt = System.DateTime.Parse("2020-06-11T01:24:05.654Z").ToUniversalTime(),
        Currency = "JOD",
        Description = "Vomito voluptas dolor sed.",
        EmployerContributionAmount = 185006D,
        EmployerContributionMaxAmount = 179093D,
        EmployerContributionType = EmployerContributionType.Percentage,
        Frequency = HrisBenefitFrequency.Hour,
        Id = "c01bd534-fa42-44cf-a806-ff9377fd25be",
        IsActive = false,
        Name = "Frozen Wooden Ball",
        Tax = Tax.PreTax,
        Type = HrisBenefitType.Garnishment,
        UpdatedAt = System.DateTime.Parse("2023-03-06T11:00:57.663Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Hris.PatchHrisBenefitAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [PatchHrisBenefitRequest](../../Models/Requests/PatchHrisBenefitRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[PatchHrisBenefitResponse](../../Models/Requests/PatchHrisBenefitResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchHrisCompany

Update a company

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchHrisCompany" method="patch" path="/hris/{connection_id}/company/{id}" example="hris_company" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchHrisCompanyRequest req = new PatchHrisCompanyRequest() {
    HrisCompany = new HrisCompany() {
        Address = new PropertyHrisCompanyAddress() {
            Address1 = "2549 Church Walk",
            City = "Lake Nettiebury",
            CountryCode = "US",
            PostalCode = "32877-4898",
            Region = "Idaho",
            RegionCode = "PA",
        },
        CreatedAt = System.DateTime.Parse("2021-05-02T22:27:38.970Z").ToUniversalTime(),
        Id = "fa4b8143-5f86-4d31-8b32-f1197757c6cf",
        LegalName = "Schultz LLC",
        Name = "Gottlieb Group",
        UpdatedAt = System.DateTime.Parse("2026-09-05T21:12:19.828Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Hris.PatchHrisCompanyAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [PatchHrisCompanyRequest](../../Models/Requests/PatchHrisCompanyRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[PatchHrisCompanyResponse](../../Models/Requests/PatchHrisCompanyResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchHrisDeduction

Update a deduction

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchHrisDeduction" method="patch" path="/hris/{connection_id}/deduction/{id}" example="hris_deduction" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchHrisDeductionRequest req = new PatchHrisDeductionRequest() {
    HrisDeduction = new HrisDeduction() {
        Amount = 139655D,
        CoverageLevel = HrisDeductionCoverageLevel.EmployeeOnly,
        CreatedAt = System.DateTime.Parse("2020-02-05T01:46:31.384Z").ToUniversalTime(),
        EndAt = System.DateTime.Parse("2026-05-22T22:53:01.279Z").ToUniversalTime(),
        Frequency = HrisDeductionFrequency.Month,
        Id = "97cd633a-aa8b-4099-b8f8-f1467cc7eb2c",
        IsActive = false,
        Notes = "Carmen desidero.",
        StartAt = System.DateTime.Parse("2025-02-18T04:38:44.658Z").ToUniversalTime(),
        Type = HrisDeductionType.Fixed,
        UpdatedAt = System.DateTime.Parse("2024-03-01T23:42:32.717Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Hris.PatchHrisDeductionAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [PatchHrisDeductionRequest](../../Models/Requests/PatchHrisDeductionRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[PatchHrisDeductionResponse](../../Models/Requests/PatchHrisDeductionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchHrisDevice

Update a device

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchHrisDevice" method="patch" path="/hris/{connection_id}/device/{id}" example="hris_device" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchHrisDeviceRequest req = new PatchHrisDeviceRequest() {
    HrisDevice = new HrisDevice() {
        AdminUserIds = new List<string>() {},
        AssetTag = "dpho9OuFNG",
        CreatedAt = System.DateTime.Parse("2019-04-04T17:11:40.322Z").ToUniversalTime(),
        HasAntivirus = false,
        HasFirewall = true,
        HasHdEncrypted = true,
        HasPasswordManager = true,
        HasScreenlock = true,
        Id = "74d52d31-891f-476a-a3b5-8c9f384a35b9",
        IsMissing = false,
        Manufacturer = "Sanford - Hamill",
        Model = "Refined",
        Name = "cross_contamination_if.rar",
        Os = "monitor",
        OsVersion = "1.12.16",
        UpdatedAt = System.DateTime.Parse("2023-05-21T00:56:51.342Z").ToUniversalTime(),
        Version = "2.20.17",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Hris.PatchHrisDeviceAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [PatchHrisDeviceRequest](../../Models/Requests/PatchHrisDeviceRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[PatchHrisDeviceResponse](../../Models/Requests/PatchHrisDeviceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchHrisDocument

Update a document

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchHrisDocument" method="patch" path="/hris/{connection_id}/document/{id}" example="hris_document" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchHrisDocumentRequest req = new PatchHrisDocumentRequest() {
    HrisDocument = new HrisDocument() {
        CreatedAt = System.DateTime.Parse("2022-10-27T11:47:26.086Z").ToUniversalTime(),
        DocumentUrl = "https://sore-decision.biz/",
        Filename = "ridge_forager.xsl",
        Id = "872f8d50-e1c5-40c1-af71-1bf3cbaa734c",
        Type = HrisDocumentType.Policy,
        UpdatedAt = System.DateTime.Parse("2025-09-17T01:55:35.570Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Hris.PatchHrisDocumentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [PatchHrisDocumentRequest](../../Models/Requests/PatchHrisDocumentRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[PatchHrisDocumentResponse](../../Models/Requests/PatchHrisDocumentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchHrisEmployee

Update an employee

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchHrisEmployee" method="patch" path="/hris/{connection_id}/employee/{id}" example="hris_employee" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchHrisEmployeeRequest req = new PatchHrisEmployeeRequest() {
    HrisEmployee = new HrisEmployee() {
        Address = new PropertyHrisEmployeeAddress() {
            Address1 = "52008 Lansdowne Road",
            Address2 = "Apt. 101",
            City = "Connellyberg",
            CountryCode = "US",
            PostalCode = "18978",
            Region = "South Dakota",
            RegionCode = "NM",
        },
        Bio = "sushi devotee, singer",
        Compensation = new List<HrisCompensation>() {
            new HrisCompensation() {
                Amount = 69148D,
                Currency = "CRC",
                Frequency = HrisCompensationFrequency.Quarter,
                Notes = "Tergeo laborum laboriosam tutis.",
                Type = HrisCompensationType.Equity,
            },
        },
        CreatedAt = System.DateTime.Parse("2019-09-16T15:08:53.262Z").ToUniversalTime(),
        Currency = "IDR",
        DateOfBirth = System.DateTime.Parse("2001-04-22").ToUniversalTime(),
        Emails = new List<HrisEmail>() {
            new HrisEmail() {
                Email = "Zetta_Prohaska67@hotmail.com",
                Type = HrisEmailType.Home,
            },
        },
        EmployeeNumber = "YuOt169CGu",
        EmploymentStatus = EmploymentStatus.Active,
        EmploymentType = HrisEmployeeEmploymentType.Volunteer,
        FirstName = "Zetta",
        Gender = HrisEmployeeGender.Intersex,
        HasMfa = true,
        HiredAt = System.DateTime.Parse("2023-05-10T16:15:07.690Z").ToUniversalTime(),
        Id = "f48de0fa-eaf1-4dda-a822-85ff56964d2a",
        ImageUrl = "https://loremflickr.com/3684/2116?lock=4686991638584456",
        LanguageLocale = "es",
        LastName = "Prohaska",
        Locations = new List<HrisLocation>() {},
        MaritalStatus = MaritalStatus.Married,
        Metadata = new List<HrisMetadata>() {
            new HrisMetadata() {
                ExtraData = HrisMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = HrisMetadataFormat.Text,
                Id = "a70413d9-b815-4ba9-8f48-c242e3ecee27",
                Namespace = "custom",
                Slug = "custom_property",
                Value = HrisMetadataValue.CreateStr(
                    "tenetur"
                ),
            },
        },
        Name = "Zetta Prohaska",
        Pronouns = "she/her",
        Relationships = new List<HrisEmployeerelationship>() {
            new HrisEmployeerelationship() {
                Emails = new List<HrisEmail>() {
                    new HrisEmail() {
                        Email = "Deshaun.Sanford24@yahoo.com",
                    },
                    new HrisEmail() {
                        Email = "Rebeca.Dibbert11@hotmail.com",
                    },
                    new HrisEmail() {
                        Email = "Hester80@gmail.com",
                    },
                },
                Name = "Automotive",
                Type = HrisEmployeerelationshipType.Emergency,
            },
            new HrisEmployeerelationship() {
                Emails = new List<HrisEmail>() {
                    new HrisEmail() {
                        Email = "Benedict_Wisozk83@hotmail.com",
                    },
                    new HrisEmail() {
                        Email = "Princess_Rath43@gmail.com",
                    },
                    new HrisEmail() {
                        Email = "Elmira92@yahoo.com",
                    },
                },
                Name = "Music",
                Type = HrisEmployeerelationshipType.Friend,
            },
            new HrisEmployeerelationship() {
                Emails = new List<HrisEmail>() {
                    new HrisEmail() {
                        Email = "Jane30@gmail.com",
                    },
                },
                Name = "Jewelry",
                Type = HrisEmployeerelationshipType.Sibling,
            },
        },
        Salutation = "Miss",
        SsnSin = "yMRtj0Q3xO",
        StorageQuotaAllocated = 3674489D,
        StorageQuotaAvailable = 7748057D,
        StorageQuotaUsed = 301727D,
        Telephones = new List<HrisTelephone>() {
            new HrisTelephone() {
                Telephone = "(409) 801-3705",
                Type = HrisTelephoneType.Fax,
            },
        },
        TerminationReason = "Communis adnuo damnatio atavus terebro acies canis cogito triumphus creber temptatio defendo cubo amissio paulatim corroboro.",
        TimeoffDaysTotal = 12D,
        TimeoffDaysUsed = 6D,
        Timezone = "Africa/Harare",
        Title = "Investor Paradigm Liaison",
        UpdatedAt = System.DateTime.Parse("2022-02-19T07:02:15.376Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Hris.PatchHrisEmployeeAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [PatchHrisEmployeeRequest](../../Models/Requests/PatchHrisEmployeeRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[PatchHrisEmployeeResponse](../../Models/Requests/PatchHrisEmployeeResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchHrisGroup

Update a group

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchHrisGroup" method="patch" path="/hris/{connection_id}/group/{id}" example="hris_group" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchHrisGroupRequest req = new PatchHrisGroupRequest() {
    HrisGroup = new HrisGroup() {
        CreatedAt = System.DateTime.Parse("2023-11-01T13:13:40.714Z").ToUniversalTime(),
        Description = "Absorbeo casso.",
        Id = "e6f510a5-a158-4c0b-ac94-6d68578b4e95",
        IsActive = false,
        Name = "Games",
        Type = HrisGroupType.BusinessUnit,
        UpdatedAt = System.DateTime.Parse("2026-04-23T14:25:48.395Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Hris.PatchHrisGroupAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [PatchHrisGroupRequest](../../Models/Requests/PatchHrisGroupRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[PatchHrisGroupResponse](../../Models/Requests/PatchHrisGroupResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchHrisLocation

Update a location

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchHrisLocation" method="patch" path="/hris/{connection_id}/location/{id}" example="hris_location" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchHrisLocationRequest req = new PatchHrisLocationRequest() {
    HrisLocation = new HrisLocation() {
        Address = new PropertyHrisLocationAddress() {
            Address1 = "2743 Connelly Summit",
            Address2 = "Apt. 350",
            City = "Titusville",
            CountryCode = "US",
            PostalCode = "16154-1095",
            Region = "Oregon",
            RegionCode = "AL",
        },
        CreatedAt = System.DateTime.Parse("2021-07-18T10:32:01.414Z").ToUniversalTime(),
        Currency = "MUR",
        Description = "Acervus caries.",
        ExternalIdentifier = "99f0dbdd-df2b-4d49-9e82-00a607a43d9f",
        Id = "445b1f3e-80ff-43ad-a8af-2ca6e1046fd7",
        IsActive = true,
        IsHq = false,
        LanguageLocale = "fr",
        Name = "adhuc",
        Telephones = new List<HrisTelephone>() {
            new HrisTelephone() {
                Telephone = "(710) 550-6997",
                Type = HrisTelephoneType.Fax,
            },
            new HrisTelephone() {
                Telephone = "(208) 555-8542",
                Type = HrisTelephoneType.Home,
            },
            new HrisTelephone() {
                Telephone = "(712) 473-5482",
                Type = HrisTelephoneType.Fax,
            },
        },
        Timezone = "America/Guyana",
        UpdatedAt = System.DateTime.Parse("2023-06-09T00:40:22.398Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Hris.PatchHrisLocationAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [PatchHrisLocationRequest](../../Models/Requests/PatchHrisLocationRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[PatchHrisLocationResponse](../../Models/Requests/PatchHrisLocationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchHrisTimeoff

Update a timeoff

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchHrisTimeoff" method="patch" path="/hris/{connection_id}/timeoff/{id}" example="hris_timeoff" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchHrisTimeoffRequest req = new PatchHrisTimeoffRequest() {
    HrisTimeoff = new HrisTimeoff() {
        ApprovedAt = System.DateTime.Parse("2022-02-20T21:02:44.025Z").ToUniversalTime(),
        Comments = "Blandior ventus curiositas amplitudo.",
        CreatedAt = System.DateTime.Parse("2021-10-06T18:00:20.615Z").ToUniversalTime(),
        Duration = 4D,
        DurationType = DurationType.Day,
        EndAt = System.DateTime.Parse("2024-12-07T13:51:48.897Z").ToUniversalTime(),
        Id = "f1c287db-49ea-4bb1-92e3-bfac8aaa9194",
        IsPaid = true,
        OriginalType = "acerbitas ut",
        Reason = "verto",
        StartAt = System.DateTime.Parse("2023-08-23T06:57:16.403Z").ToUniversalTime(),
        Status = HrisTimeoffStatus.Denied,
        Type = HrisTimeoffType.InLieu,
        UpdatedAt = System.DateTime.Parse("2022-07-07T19:35:06.900Z").ToUniversalTime(),
        UserId = "<id>",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Hris.PatchHrisTimeoffAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [PatchHrisTimeoffRequest](../../Models/Requests/PatchHrisTimeoffRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[PatchHrisTimeoffResponse](../../Models/Requests/PatchHrisTimeoffResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchHrisTimeshift

Update a timeshift

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchHrisTimeshift" method="patch" path="/hris/{connection_id}/timeshift/{id}" example="hris_timeshift" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchHrisTimeshiftRequest req = new PatchHrisTimeshiftRequest() {
    HrisTimeshift = new HrisTimeshift() {
        ApprovedAt = System.DateTime.Parse("2023-06-05T14:32:23.868Z").ToUniversalTime(),
        Compensation = new List<HrisCompensation>() {
            new HrisCompensation() {
                Amount = 76761D,
                Currency = "JPY",
                Frequency = HrisCompensationFrequency.Hour,
                Notes = "Annus adficio suasoria architecto aggero.",
                Type = HrisCompensationType.Other,
            },
        },
        CreatedAt = System.DateTime.Parse("2019-07-01T23:53:15.738Z").ToUniversalTime(),
        EmployeeUserId = "<id>",
        EndAt = System.DateTime.Parse("2026-08-25T08:29:34.519Z").ToUniversalTime(),
        Hours = 8D,
        Id = "c51bdd14-5147-4def-afb6-882c8f97c0df",
        IsApproved = true,
        StartAt = System.DateTime.Parse("2023-06-24T19:30:14.699Z").ToUniversalTime(),
        UpdatedAt = System.DateTime.Parse("2021-06-22T20:53:37.148Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Hris.PatchHrisTimeshiftAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [PatchHrisTimeshiftRequest](../../Models/Requests/PatchHrisTimeshiftRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[PatchHrisTimeshiftResponse](../../Models/Requests/PatchHrisTimeshiftResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveHrisAttendance

Remove an attendance

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeHrisAttendance" method="delete" path="/hris/{connection_id}/attendance/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.RemoveHrisAttendanceAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Attendance |

### Response

**[RemoveHrisAttendanceResponse](../../Models/Requests/RemoveHrisAttendanceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveHrisBankaccount

Remove a bankaccount

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeHrisBankaccount" method="delete" path="/hris/{connection_id}/bankaccount/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.RemoveHrisBankaccountAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter             | Type                  | Required              | Description           |
| --------------------- | --------------------- | --------------------- | --------------------- |
| `ConnectionId`        | *string*              | :heavy_check_mark:    | ID of the connection  |
| `Id`                  | *string*              | :heavy_check_mark:    | ID of the Bankaccount |

### Response

**[RemoveHrisBankaccountResponse](../../Models/Requests/RemoveHrisBankaccountResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveHrisBenefit

Remove a benefit

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeHrisBenefit" method="delete" path="/hris/{connection_id}/benefit/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.RemoveHrisBenefitAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Benefit    |

### Response

**[RemoveHrisBenefitResponse](../../Models/Requests/RemoveHrisBenefitResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveHrisCompany

Remove a company

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeHrisCompany" method="delete" path="/hris/{connection_id}/company/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.RemoveHrisCompanyAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Company    |

### Response

**[RemoveHrisCompanyResponse](../../Models/Requests/RemoveHrisCompanyResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveHrisDeduction

Remove a deduction

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeHrisDeduction" method="delete" path="/hris/{connection_id}/deduction/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.RemoveHrisDeductionAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Deduction  |

### Response

**[RemoveHrisDeductionResponse](../../Models/Requests/RemoveHrisDeductionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveHrisDevice

Remove a device

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeHrisDevice" method="delete" path="/hris/{connection_id}/device/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.RemoveHrisDeviceAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Device     |

### Response

**[RemoveHrisDeviceResponse](../../Models/Requests/RemoveHrisDeviceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveHrisDocument

Remove a document

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeHrisDocument" method="delete" path="/hris/{connection_id}/document/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.RemoveHrisDocumentAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Document   |

### Response

**[RemoveHrisDocumentResponse](../../Models/Requests/RemoveHrisDocumentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveHrisEmployee

Remove an employee

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeHrisEmployee" method="delete" path="/hris/{connection_id}/employee/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.RemoveHrisEmployeeAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Employee   |

### Response

**[RemoveHrisEmployeeResponse](../../Models/Requests/RemoveHrisEmployeeResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveHrisGroup

Remove a group

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeHrisGroup" method="delete" path="/hris/{connection_id}/group/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.RemoveHrisGroupAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Group      |

### Response

**[RemoveHrisGroupResponse](../../Models/Requests/RemoveHrisGroupResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveHrisLocation

Remove a location

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeHrisLocation" method="delete" path="/hris/{connection_id}/location/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.RemoveHrisLocationAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Location   |

### Response

**[RemoveHrisLocationResponse](../../Models/Requests/RemoveHrisLocationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveHrisTimeoff

Remove a timeoff

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeHrisTimeoff" method="delete" path="/hris/{connection_id}/timeoff/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.RemoveHrisTimeoffAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Timeoff    |

### Response

**[RemoveHrisTimeoffResponse](../../Models/Requests/RemoveHrisTimeoffResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveHrisTimeshift

Remove a timeshift

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeHrisTimeshift" method="delete" path="/hris/{connection_id}/timeshift/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.RemoveHrisTimeshiftAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Timeshift  |

### Response

**[RemoveHrisTimeshiftResponse](../../Models/Requests/RemoveHrisTimeshiftResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateHrisAttendance

Update an attendance

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateHrisAttendance" method="put" path="/hris/{connection_id}/attendance/{id}" example="hris_attendance" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateHrisAttendanceRequest req = new UpdateHrisAttendanceRequest() {
    HrisAttendance = new HrisAttendance() {
        Address = new PropertyHrisAttendanceAddress() {
            Address1 = "14108 Allie Flats",
            City = "Kearaborough",
            CountryCode = "US",
            PostalCode = "23844-2344",
            Region = "Tennessee",
            RegionCode = "CA",
        },
        ApprovedAt = System.DateTime.Parse("2021-08-13T10:36:02.699Z").ToUniversalTime(),
        Breaks = new List<HrisAttendanceBreak>() {
            new HrisAttendanceBreak() {
                DurationMinutes = 12D,
                EndAt = System.DateTime.Parse("2023-10-22T16:22:57.221Z").ToUniversalTime(),
                Id = "d60a1001-5a8a-4991-8c21-f4da6036cc87",
                IsPaid = true,
                Name = "Lunch",
                StartAt = System.DateTime.Parse("2023-10-15T20:49:16.485Z").ToUniversalTime(),
            },
        },
        CreatedAt = System.DateTime.Parse("2021-08-10T19:43:18.452Z").ToUniversalTime(),
        Currency = "UGX",
        DeclaredTipsAmount = 161D,
        EmployeeUserId = "<id>",
        EndAt = System.DateTime.Parse("2024-04-06T03:56:34.918Z").ToUniversalTime(),
        HourlyRate = 53D,
        Hours = 10D,
        Id = "34ef1ed7-4863-409e-bd2a-2522d8f43302",
        JobName = "Global Creative Supervisor",
        NonCashTipsAmount = 54D,
        StartAt = System.DateTime.Parse("2021-11-09T10:26:01.082Z").ToUniversalTime(),
        Status = HrisAttendanceStatus.Closed,
        Timezone = "America/Atikokan",
        UpdatedAt = System.DateTime.Parse("2022-01-17T01:25:06.885Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Hris.UpdateHrisAttendanceAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [UpdateHrisAttendanceRequest](../../Models/Requests/UpdateHrisAttendanceRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[UpdateHrisAttendanceResponse](../../Models/Requests/UpdateHrisAttendanceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateHrisBankaccount

Update a bankaccount

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateHrisBankaccount" method="put" path="/hris/{connection_id}/bankaccount/{id}" example="hris_bankaccount" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateHrisBankaccountRequest req = new UpdateHrisBankaccountRequest() {
    HrisBankaccount = new HrisBankaccount() {
        AccountNumber = "****3777",
        AccountNumberLast4 = "3777",
        AccountType = HrisBankaccountAccountType.Checking,
        BankName = "Huel Group",
        CreatedAt = System.DateTime.Parse("2019-11-16T16:43:45.976Z").ToUniversalTime(),
        Id = "48efbe5b-f668-403e-9979-a07b0ec0a98a",
        IsPrimary = false,
        Name = "Checking Account",
        RoutingNumber = "448650724",
        UpdatedAt = System.DateTime.Parse("2025-06-04T11:31:37.525Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Hris.UpdateHrisBankaccountAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [UpdateHrisBankaccountRequest](../../Models/Requests/UpdateHrisBankaccountRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[UpdateHrisBankaccountResponse](../../Models/Requests/UpdateHrisBankaccountResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateHrisBenefit

Update a benefit

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateHrisBenefit" method="put" path="/hris/{connection_id}/benefit/{id}" example="hris_benefit" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateHrisBenefitRequest req = new UpdateHrisBenefitRequest() {
    HrisBenefit = new HrisBenefit() {
        CoverageLevel = CoverageLevel.EmployeeSpouse,
        CreatedAt = System.DateTime.Parse("2020-06-11T01:24:05.654Z").ToUniversalTime(),
        Currency = "JOD",
        Description = "Vomito voluptas dolor sed.",
        EmployerContributionAmount = 185006D,
        EmployerContributionMaxAmount = 179093D,
        EmployerContributionType = EmployerContributionType.Percentage,
        Frequency = HrisBenefitFrequency.Hour,
        Id = "c01bd534-fa42-44cf-a806-ff9377fd25be",
        IsActive = false,
        Name = "Frozen Wooden Ball",
        Tax = Tax.PreTax,
        Type = HrisBenefitType.Garnishment,
        UpdatedAt = System.DateTime.Parse("2023-03-06T11:00:57.663Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Hris.UpdateHrisBenefitAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [UpdateHrisBenefitRequest](../../Models/Requests/UpdateHrisBenefitRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[UpdateHrisBenefitResponse](../../Models/Requests/UpdateHrisBenefitResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateHrisCompany

Update a company

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateHrisCompany" method="put" path="/hris/{connection_id}/company/{id}" example="hris_company" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateHrisCompanyRequest req = new UpdateHrisCompanyRequest() {
    HrisCompany = new HrisCompany() {
        Address = new PropertyHrisCompanyAddress() {
            Address1 = "2549 Church Walk",
            City = "Lake Nettiebury",
            CountryCode = "US",
            PostalCode = "32877-4898",
            Region = "Idaho",
            RegionCode = "PA",
        },
        CreatedAt = System.DateTime.Parse("2021-05-02T22:27:38.970Z").ToUniversalTime(),
        Id = "fa4b8143-5f86-4d31-8b32-f1197757c6cf",
        LegalName = "Schultz LLC",
        Name = "Gottlieb Group",
        UpdatedAt = System.DateTime.Parse("2026-09-05T21:12:19.828Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Hris.UpdateHrisCompanyAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [UpdateHrisCompanyRequest](../../Models/Requests/UpdateHrisCompanyRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[UpdateHrisCompanyResponse](../../Models/Requests/UpdateHrisCompanyResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateHrisDeduction

Update a deduction

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateHrisDeduction" method="put" path="/hris/{connection_id}/deduction/{id}" example="hris_deduction" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateHrisDeductionRequest req = new UpdateHrisDeductionRequest() {
    HrisDeduction = new HrisDeduction() {
        Amount = 139655D,
        CoverageLevel = HrisDeductionCoverageLevel.EmployeeOnly,
        CreatedAt = System.DateTime.Parse("2020-02-05T01:46:31.384Z").ToUniversalTime(),
        EndAt = System.DateTime.Parse("2026-05-22T22:53:01.279Z").ToUniversalTime(),
        Frequency = HrisDeductionFrequency.Month,
        Id = "97cd633a-aa8b-4099-b8f8-f1467cc7eb2c",
        IsActive = false,
        Notes = "Carmen desidero.",
        StartAt = System.DateTime.Parse("2025-02-18T04:38:44.658Z").ToUniversalTime(),
        Type = HrisDeductionType.Fixed,
        UpdatedAt = System.DateTime.Parse("2024-03-01T23:42:32.717Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Hris.UpdateHrisDeductionAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [UpdateHrisDeductionRequest](../../Models/Requests/UpdateHrisDeductionRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[UpdateHrisDeductionResponse](../../Models/Requests/UpdateHrisDeductionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateHrisDevice

Update a device

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateHrisDevice" method="put" path="/hris/{connection_id}/device/{id}" example="hris_device" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateHrisDeviceRequest req = new UpdateHrisDeviceRequest() {
    HrisDevice = new HrisDevice() {
        AdminUserIds = new List<string>() {},
        AssetTag = "dpho9OuFNG",
        CreatedAt = System.DateTime.Parse("2019-04-04T17:11:40.322Z").ToUniversalTime(),
        HasAntivirus = false,
        HasFirewall = true,
        HasHdEncrypted = true,
        HasPasswordManager = true,
        HasScreenlock = true,
        Id = "74d52d31-891f-476a-a3b5-8c9f384a35b9",
        IsMissing = false,
        Manufacturer = "Sanford - Hamill",
        Model = "Refined",
        Name = "cross_contamination_if.rar",
        Os = "monitor",
        OsVersion = "1.12.16",
        UpdatedAt = System.DateTime.Parse("2023-05-21T00:56:51.342Z").ToUniversalTime(),
        Version = "2.20.17",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Hris.UpdateHrisDeviceAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [UpdateHrisDeviceRequest](../../Models/Requests/UpdateHrisDeviceRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[UpdateHrisDeviceResponse](../../Models/Requests/UpdateHrisDeviceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateHrisDocument

Update a document

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateHrisDocument" method="put" path="/hris/{connection_id}/document/{id}" example="hris_document" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateHrisDocumentRequest req = new UpdateHrisDocumentRequest() {
    HrisDocument = new HrisDocument() {
        CreatedAt = System.DateTime.Parse("2022-10-27T11:47:26.086Z").ToUniversalTime(),
        DocumentUrl = "https://sore-decision.biz/",
        Filename = "ridge_forager.xsl",
        Id = "872f8d50-e1c5-40c1-af71-1bf3cbaa734c",
        Type = HrisDocumentType.Policy,
        UpdatedAt = System.DateTime.Parse("2025-09-17T01:55:35.570Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Hris.UpdateHrisDocumentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [UpdateHrisDocumentRequest](../../Models/Requests/UpdateHrisDocumentRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[UpdateHrisDocumentResponse](../../Models/Requests/UpdateHrisDocumentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateHrisEmployee

Update an employee

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateHrisEmployee" method="put" path="/hris/{connection_id}/employee/{id}" example="hris_employee" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateHrisEmployeeRequest req = new UpdateHrisEmployeeRequest() {
    HrisEmployee = new HrisEmployee() {
        Address = new PropertyHrisEmployeeAddress() {
            Address1 = "52008 Lansdowne Road",
            Address2 = "Apt. 101",
            City = "Connellyberg",
            CountryCode = "US",
            PostalCode = "18978",
            Region = "South Dakota",
            RegionCode = "NM",
        },
        Bio = "sushi devotee, singer",
        Compensation = new List<HrisCompensation>() {
            new HrisCompensation() {
                Amount = 69148D,
                Currency = "CRC",
                Frequency = HrisCompensationFrequency.Quarter,
                Notes = "Tergeo laborum laboriosam tutis.",
                Type = HrisCompensationType.Equity,
            },
        },
        CreatedAt = System.DateTime.Parse("2019-09-16T15:08:53.262Z").ToUniversalTime(),
        Currency = "IDR",
        DateOfBirth = System.DateTime.Parse("2001-04-22").ToUniversalTime(),
        Emails = new List<HrisEmail>() {
            new HrisEmail() {
                Email = "Zetta_Prohaska67@hotmail.com",
                Type = HrisEmailType.Home,
            },
        },
        EmployeeNumber = "YuOt169CGu",
        EmploymentStatus = EmploymentStatus.Active,
        EmploymentType = HrisEmployeeEmploymentType.Volunteer,
        FirstName = "Zetta",
        Gender = HrisEmployeeGender.Intersex,
        HasMfa = true,
        HiredAt = System.DateTime.Parse("2023-05-10T16:15:07.690Z").ToUniversalTime(),
        Id = "f48de0fa-eaf1-4dda-a822-85ff56964d2a",
        ImageUrl = "https://loremflickr.com/3684/2116?lock=4686991638584456",
        LanguageLocale = "es",
        LastName = "Prohaska",
        Locations = new List<HrisLocation>() {},
        MaritalStatus = MaritalStatus.Married,
        Metadata = new List<HrisMetadata>() {
            new HrisMetadata() {
                ExtraData = HrisMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = HrisMetadataFormat.Text,
                Id = "a70413d9-b815-4ba9-8f48-c242e3ecee27",
                Namespace = "custom",
                Slug = "custom_property",
                Value = HrisMetadataValue.CreateStr(
                    "tenetur"
                ),
            },
        },
        Name = "Zetta Prohaska",
        Pronouns = "she/her",
        Relationships = new List<HrisEmployeerelationship>() {
            new HrisEmployeerelationship() {
                Emails = new List<HrisEmail>() {
                    new HrisEmail() {
                        Email = "Deshaun.Sanford24@yahoo.com",
                    },
                    new HrisEmail() {
                        Email = "Rebeca.Dibbert11@hotmail.com",
                    },
                    new HrisEmail() {
                        Email = "Hester80@gmail.com",
                    },
                },
                Name = "Automotive",
                Type = HrisEmployeerelationshipType.Emergency,
            },
            new HrisEmployeerelationship() {
                Emails = new List<HrisEmail>() {
                    new HrisEmail() {
                        Email = "Benedict_Wisozk83@hotmail.com",
                    },
                    new HrisEmail() {
                        Email = "Princess_Rath43@gmail.com",
                    },
                    new HrisEmail() {
                        Email = "Elmira92@yahoo.com",
                    },
                },
                Name = "Music",
                Type = HrisEmployeerelationshipType.Friend,
            },
            new HrisEmployeerelationship() {
                Emails = new List<HrisEmail>() {
                    new HrisEmail() {
                        Email = "Jane30@gmail.com",
                    },
                },
                Name = "Jewelry",
                Type = HrisEmployeerelationshipType.Sibling,
            },
        },
        Salutation = "Miss",
        SsnSin = "yMRtj0Q3xO",
        StorageQuotaAllocated = 3674489D,
        StorageQuotaAvailable = 7748057D,
        StorageQuotaUsed = 301727D,
        Telephones = new List<HrisTelephone>() {
            new HrisTelephone() {
                Telephone = "(409) 801-3705",
                Type = HrisTelephoneType.Fax,
            },
        },
        TerminationReason = "Communis adnuo damnatio atavus terebro acies canis cogito triumphus creber temptatio defendo cubo amissio paulatim corroboro.",
        TimeoffDaysTotal = 12D,
        TimeoffDaysUsed = 6D,
        Timezone = "Africa/Harare",
        Title = "Investor Paradigm Liaison",
        UpdatedAt = System.DateTime.Parse("2022-02-19T07:02:15.376Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Hris.UpdateHrisEmployeeAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [UpdateHrisEmployeeRequest](../../Models/Requests/UpdateHrisEmployeeRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[UpdateHrisEmployeeResponse](../../Models/Requests/UpdateHrisEmployeeResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateHrisGroup

Update a group

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateHrisGroup" method="put" path="/hris/{connection_id}/group/{id}" example="hris_group" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateHrisGroupRequest req = new UpdateHrisGroupRequest() {
    HrisGroup = new HrisGroup() {
        CreatedAt = System.DateTime.Parse("2023-11-01T13:13:40.714Z").ToUniversalTime(),
        Description = "Absorbeo casso.",
        Id = "e6f510a5-a158-4c0b-ac94-6d68578b4e95",
        IsActive = false,
        Name = "Games",
        Type = HrisGroupType.BusinessUnit,
        UpdatedAt = System.DateTime.Parse("2026-04-23T14:25:48.395Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Hris.UpdateHrisGroupAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [UpdateHrisGroupRequest](../../Models/Requests/UpdateHrisGroupRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[UpdateHrisGroupResponse](../../Models/Requests/UpdateHrisGroupResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateHrisLocation

Update a location

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateHrisLocation" method="put" path="/hris/{connection_id}/location/{id}" example="hris_location" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateHrisLocationRequest req = new UpdateHrisLocationRequest() {
    HrisLocation = new HrisLocation() {
        Address = new PropertyHrisLocationAddress() {
            Address1 = "2743 Connelly Summit",
            Address2 = "Apt. 350",
            City = "Titusville",
            CountryCode = "US",
            PostalCode = "16154-1095",
            Region = "Oregon",
            RegionCode = "AL",
        },
        CreatedAt = System.DateTime.Parse("2021-07-18T10:32:01.414Z").ToUniversalTime(),
        Currency = "MUR",
        Description = "Acervus caries.",
        ExternalIdentifier = "99f0dbdd-df2b-4d49-9e82-00a607a43d9f",
        Id = "445b1f3e-80ff-43ad-a8af-2ca6e1046fd7",
        IsActive = true,
        IsHq = false,
        LanguageLocale = "fr",
        Name = "adhuc",
        Telephones = new List<HrisTelephone>() {
            new HrisTelephone() {
                Telephone = "(710) 550-6997",
                Type = HrisTelephoneType.Fax,
            },
            new HrisTelephone() {
                Telephone = "(208) 555-8542",
                Type = HrisTelephoneType.Home,
            },
            new HrisTelephone() {
                Telephone = "(712) 473-5482",
                Type = HrisTelephoneType.Fax,
            },
        },
        Timezone = "America/Guyana",
        UpdatedAt = System.DateTime.Parse("2023-06-09T00:40:22.398Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Hris.UpdateHrisLocationAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [UpdateHrisLocationRequest](../../Models/Requests/UpdateHrisLocationRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[UpdateHrisLocationResponse](../../Models/Requests/UpdateHrisLocationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateHrisTimeoff

Update a timeoff

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateHrisTimeoff" method="put" path="/hris/{connection_id}/timeoff/{id}" example="hris_timeoff" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateHrisTimeoffRequest req = new UpdateHrisTimeoffRequest() {
    HrisTimeoff = new HrisTimeoff() {
        ApprovedAt = System.DateTime.Parse("2022-02-20T21:02:44.025Z").ToUniversalTime(),
        Comments = "Blandior ventus curiositas amplitudo.",
        CreatedAt = System.DateTime.Parse("2021-10-06T18:00:20.615Z").ToUniversalTime(),
        Duration = 4D,
        DurationType = DurationType.Day,
        EndAt = System.DateTime.Parse("2024-12-07T13:51:48.897Z").ToUniversalTime(),
        Id = "f1c287db-49ea-4bb1-92e3-bfac8aaa9194",
        IsPaid = true,
        OriginalType = "acerbitas ut",
        Reason = "verto",
        StartAt = System.DateTime.Parse("2023-08-23T06:57:16.403Z").ToUniversalTime(),
        Status = HrisTimeoffStatus.Denied,
        Type = HrisTimeoffType.InLieu,
        UpdatedAt = System.DateTime.Parse("2022-07-07T19:35:06.900Z").ToUniversalTime(),
        UserId = "<id>",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Hris.UpdateHrisTimeoffAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [UpdateHrisTimeoffRequest](../../Models/Requests/UpdateHrisTimeoffRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[UpdateHrisTimeoffResponse](../../Models/Requests/UpdateHrisTimeoffResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateHrisTimeshift

Update a timeshift

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateHrisTimeshift" method="put" path="/hris/{connection_id}/timeshift/{id}" example="hris_timeshift" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateHrisTimeshiftRequest req = new UpdateHrisTimeshiftRequest() {
    HrisTimeshift = new HrisTimeshift() {
        ApprovedAt = System.DateTime.Parse("2023-06-05T14:32:23.868Z").ToUniversalTime(),
        Compensation = new List<HrisCompensation>() {
            new HrisCompensation() {
                Amount = 76761D,
                Currency = "JPY",
                Frequency = HrisCompensationFrequency.Hour,
                Notes = "Annus adficio suasoria architecto aggero.",
                Type = HrisCompensationType.Other,
            },
        },
        CreatedAt = System.DateTime.Parse("2019-07-01T23:53:15.738Z").ToUniversalTime(),
        EmployeeUserId = "<id>",
        EndAt = System.DateTime.Parse("2026-08-25T08:29:34.519Z").ToUniversalTime(),
        Hours = 8D,
        Id = "c51bdd14-5147-4def-afb6-882c8f97c0df",
        IsApproved = true,
        StartAt = System.DateTime.Parse("2023-06-24T19:30:14.699Z").ToUniversalTime(),
        UpdatedAt = System.DateTime.Parse("2021-06-22T20:53:37.148Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Hris.UpdateHrisTimeshiftAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [UpdateHrisTimeshiftRequest](../../Models/Requests/UpdateHrisTimeshiftRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[UpdateHrisTimeshiftResponse](../../Models/Requests/UpdateHrisTimeshiftResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |