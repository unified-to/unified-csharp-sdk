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
* [CreateHrisEarning](#createhrisearning) - Create an earning
* [CreateHrisEmployee](#createhrisemployee) - Create an employee
* [CreateHrisGroup](#createhrisgroup) - Create a group
* [CreateHrisJob](#createhrisjob) - Create a job
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
* [GetHrisEarning](#gethrisearning) - Retrieve an earning
* [GetHrisEmployee](#gethrisemployee) - Retrieve an employee
* [GetHrisGroup](#gethrisgroup) - Retrieve a group
* [GetHrisJob](#gethrisjob) - Retrieve a job
* [GetHrisLocation](#gethrislocation) - Retrieve a location
* [GetHrisPaycode](#gethrispaycode) - Retrieve a paycode
* [GetHrisPayroll](#gethrispayroll) - Retrieve a payroll
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
* [ListHrisEarnings](#listhrisearnings) - List all earnings
* [ListHrisEmployees](#listhrisemployees) - List all employees
* [ListHrisGroups](#listhrisgroups) - List all groups
* [ListHrisJobs](#listhrisjobs) - List all jobs
* [ListHrisLocations](#listhrislocations) - List all locations
* [ListHrisPaycodes](#listhrispaycodes) - List all paycodes
* [ListHrisPayrolls](#listhrispayrolls) - List all payrolls
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
* [PatchHrisEarning](#patchhrisearning) - Update an earning
* [PatchHrisEmployee](#patchhrisemployee) - Update an employee
* [PatchHrisGroup](#patchhrisgroup) - Update a group
* [PatchHrisJob](#patchhrisjob) - Update a job
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
* [RemoveHrisEarning](#removehrisearning) - Remove an earning
* [RemoveHrisEmployee](#removehrisemployee) - Remove an employee
* [RemoveHrisGroup](#removehrisgroup) - Remove a group
* [RemoveHrisJob](#removehrisjob) - Remove a job
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
* [UpdateHrisEarning](#updatehrisearning) - Update an earning
* [UpdateHrisEmployee](#updatehrisemployee) - Update an employee
* [UpdateHrisGroup](#updatehrisgroup) - Update a group
* [UpdateHrisJob](#updatehrisjob) - Update a job
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
        ApprovedAt = System.DateTime.Parse("2021-09-19T13:30:00.800Z").ToUniversalTime(),
        Breaks = new List<HrisAttendanceBreak>() {
            new HrisAttendanceBreak() {
                DurationMinutes = 51D,
                EndAt = System.DateTime.Parse("2024-02-13T23:13:43.290Z").ToUniversalTime(),
                Id = "39602a29-deaa-4297-98e3-6b3be818b9b8",
                IsPaid = false,
                Name = "Lunch",
                StartAt = System.DateTime.Parse("2023-10-29T10:39:28.011Z").ToUniversalTime(),
            },
        },
        CreatedAt = System.DateTime.Parse("2021-08-10T19:43:18.452Z").ToUniversalTime(),
        Currency = "EUR",
        DeclaredTipsAmount = 54D,
        EmployeeUserId = "<id>",
        EndAt = System.DateTime.Parse("2024-04-22T16:42:47.469Z").ToUniversalTime(),
        HourlyRate = 16D,
        Hours = 10D,
        Id = "dde200c6-8e6e-4b32-ba10-b3d4f0acae49",
        JobName = "Human Accountability Administrator",
        Metadata = new List<HrisMetadata>() {},
        NonCashTipsAmount = 167D,
        StartAt = System.DateTime.Parse("2021-11-10T23:31:23.656Z").ToUniversalTime(),
        Status = HrisAttendanceStatus.Open,
        Timezone = "America/Atikokan",
        UpdatedAt = System.DateTime.Parse("2022-01-19T18:35:50.750Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `HrisAttendance`                                                                                                                                 | [HrisAttendance](../../Models/Components/HrisAttendance.md)                                                                                      | :heavy_check_mark:                                                                                                                               | Also called timesheets                                                                                                                           |
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
using System.Collections.Generic;
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
        CountryCode = "US",
        CreatedAt = System.DateTime.Parse("2019-11-16T16:43:45.976Z").ToUniversalTime(),
        Currency = "USD",
        Id = "d5591bc4-0557-4821-9081-abbc15ea43fa",
        IsPrimary = true,
        Metadata = new List<HrisMetadata>() {},
        Name = "Granville Schumm - Checking",
        Priority = 2D,
        RoutingNumber = "448650724",
        SplitAmount = 98D,
        SplitType = SplitType.Percentage,
        UpdatedAt = System.DateTime.Parse("2025-06-30T06:48:11.285Z").ToUniversalTime(),
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
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.CreateHrisBenefitAsync(
    hrisBenefit: new HrisBenefit() {
        CoverageLevel = CoverageLevel.EmployeeSpouse,
        CreatedAt = System.DateTime.Parse("2020-06-11T01:24:05.654Z").ToUniversalTime(),
        Currency = "GBP",
        Description = "Vomito voluptas dolor sed.",
        EmployerContributionAmount = 185006D,
        EmployerContributionMaxAmount = 179093D,
        EmployerContributionType = EmployerContributionType.Percentage,
        Frequency = HrisBenefitFrequency.Month,
        Id = "2b78bd0f-c9b5-48cc-b206-6b981755117e",
        IsActive = false,
        Metadata = new List<HrisMetadata>() {},
        Name = "Frozen Wooden Ball",
        Tax = Tax.PreTax,
        Type = HrisBenefitType.Other,
        UpdatedAt = System.DateTime.Parse("2023-03-20T07:41:51.705Z").ToUniversalTime(),
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
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.CreateHrisCompanyAsync(
    hrisCompany: new HrisCompany() {
        Address = new PropertyHrisCompanyAddress() {
            Address1 = "675 Lavinia Lights",
            City = "Rocky Mount",
            CountryCode = "US",
            PostalCode = "67325",
            Region = "Kentucky",
            RegionCode = "MO",
        },
        CreatedAt = System.DateTime.Parse("2021-05-02T22:27:38.970Z").ToUniversalTime(),
        Id = "47784d40-7748-4310-b79c-18af4600e7c2",
        LegalName = "Gottlieb Group LLC",
        Metadata = new List<HrisMetadata>() {},
        Name = "Gottlieb Group",
        UpdatedAt = System.DateTime.Parse("2026-10-07T11:32:27.729Z").ToUniversalTime(),
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
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.CreateHrisDeductionAsync(
    hrisDeduction: new HrisDeduction() {
        Amount = 564D,
        CoverageLevel = HrisDeductionCoverageLevel.EmployeeChild,
        CreatedAt = System.DateTime.Parse("2020-02-05T01:46:31.384Z").ToUniversalTime(),
        EmployerAmount = 80510D,
        EmployerType = EmployerType.Percentage,
        Frequency = HrisDeductionFrequency.OneTime,
        GarnishmentType = GarnishmentType.ChildSupport,
        Id = "bcfbe17f-496d-45bd-a172-182bdd098e0a",
        IsActive = true,
        MaxAmount = 21794D,
        Metadata = new List<HrisMetadata>() {},
        Notes = "Carmen desidero.",
        StartAt = System.DateTime.Parse("2025-03-14T09:35:07.259Z").ToUniversalTime(),
        Type = HrisDeductionType.Fixed,
        UpdatedAt = System.DateTime.Parse("2024-03-21T13:08:20.410Z").ToUniversalTime(),
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
        AssetTag = "fJNacaaoWi",
        CreatedAt = System.DateTime.Parse("2019-04-04T17:11:40.322Z").ToUniversalTime(),
        HasAntivirus = true,
        HasFirewall = true,
        HasHdEncrypted = true,
        HasPasswordManager = true,
        HasScreenlock = false,
        Id = "7f24877c-6b79-411b-a3a3-ace66d00ac20",
        IsMissing = false,
        Manufacturer = "Hackett Inc",
        Metadata = new List<HrisMetadata>() {},
        Model = "Fantastic",
        Name = "august-laptop",
        Os = "transmitter",
        OsVersion = "8.4.8",
        UpdatedAt = System.DateTime.Parse("2023-06-07T15:17:12.630Z").ToUniversalTime(),
        Version = "4.15.7",
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
using System.Collections.Generic;
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
        Id = "e78a52b0-b0ef-474d-b28a-a175f51451f3",
        Metadata = new List<HrisMetadata>() {},
        Type = HrisDocumentType.Policy,
        UpdatedAt = System.DateTime.Parse("2025-10-10T16:33:05.270Z").ToUniversalTime(),
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

## CreateHrisEarning

Create an earning

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createHrisEarning" method="post" path="/hris/{connection_id}/earning" example="hris_earning" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.CreateHrisEarningAsync(
    hrisEarning: new HrisEarning() {
        Amount = 4026D,
        CreatedAt = System.DateTime.Parse("2019-01-26T12:44:52.326Z").ToUniversalTime(),
        Currency = "USD",
        Frequency = HrisEarningFrequency.Semimonthly,
        Id = "438f0fb5-a277-4a05-a2e0-9fcabac17e45",
        Metadata = new List<HrisMetadata>() {},
        Notes = "Deporto truculenter vinum beatae.",
        StartAt = System.DateTime.Parse("2022-07-24T22:42:12.542Z").ToUniversalTime(),
        Status = HrisEarningStatus.Ended,
        UpdatedAt = System.DateTime.Parse("2020-02-08T16:39:38.677Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `HrisEarning`                                                                                                                                    | [HrisEarning](../../Models/Components/HrisEarning.md)                                                                                            | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateHrisEarningQueryParamFields](../../Models/Requests/CreateHrisEarningQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateHrisEarningResponse](../../Models/Requests/CreateHrisEarningResponse.md)**

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
            Address1 = "7431 Hintz Parkway",
            Address2 = "Apt. 520",
            City = "Port Rogerview",
            CountryCode = "US",
            PostalCode = "01711",
            Region = "Missouri",
            RegionCode = "TN",
        },
        Bio = "fun advocate  🇱🇻",
        Compensation = new List<HrisCompensation>() {
            new HrisCompensation() {
                Amount = 95000D,
                Currency = "USD",
                Frequency = HrisCompensationFrequency.Year,
                Notes = "Eius.",
                Type = HrisCompensationType.Other,
            },
        },
        CreatedAt = System.DateTime.Parse("2019-09-16T15:08:53.262Z").ToUniversalTime(),
        Currency = "USD",
        DateOfBirth = System.DateTime.Parse("2001-04-22").ToUniversalTime(),
        Emails = new List<HrisEmail>() {
            new HrisEmail() {
                Email = "zetta.prohaska@insidious-stump.net",
                Type = HrisEmailType.Work,
            },
        },
        EmployeeNumber = "uCk3qaL1ei",
        EmploymentStatus = EmploymentStatus.Active,
        EmploymentType = HrisEmployeeEmploymentType.PartTime,
        FirstName = "Zetta",
        FlsaStatus = FlsaStatus.Exempt,
        Gender = HrisEmployeeGender.Male,
        HasMfa = true,
        HiredAt = System.DateTime.Parse("2019-09-16T15:08:53.262Z").ToUniversalTime(),
        Id = "81481fd9-702e-41f3-99ce-39881f2eabca",
        ImageUrl = "https://cdn.jsdelivr.net/gh/faker-js/assets-person-portrait/female/512/85.jpg",
        LanguageLocale = "in",
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
                Id = "abc65a9d-823c-4514-b063-ac9625c9b41e",
                Namespace = "custom",
                Slug = "custom_property",
                Value = HrisMetadataValue.CreateStr(
                    "tutis"
                ),
            },
        },
        Name = "Zetta Prohaska",
        PayFrequency = PayFrequency.Week,
        Pronouns = "she/her",
        Relationships = new List<HrisEmployeerelationship>() {
            new HrisEmployeerelationship() {
                Emails = new List<HrisEmail>() {
                    new HrisEmail() {
                        Email = "keith.prohaska@gmail.com",
                    },
                },
                Name = "Keith Prohaska",
                Type = HrisEmployeerelationshipType.Sibling,
            },
            new HrisEmployeerelationship() {
                Emails = new List<HrisEmail>() {
                    new HrisEmail() {
                        Email = "keely.prohaska@icloud.com",
                    },
                },
                Name = "Keely Prohaska",
                Type = HrisEmployeerelationshipType.Other,
            },
        },
        Salutation = "Ms.",
        SsnSin = "284-82-8167",
        StorageQuotaAllocated = 3653713D,
        StorageQuotaAvailable = 3017275D,
        StorageQuotaUsed = 367449D,
        Telephones = new List<HrisTelephone>() {
            new HrisTelephone() {
                Telephone = "(320) 980-1370",
                Type = HrisTelephoneType.Home,
            },
            new HrisTelephone() {
                Telephone = "(694) 840-0166",
                Type = HrisTelephoneType.Fax,
            },
        },
        TimeoffDaysTotal = 17D,
        TimeoffDaysUsed = 9D,
        Timezone = "Europe/Ljubljana",
        Title = "District Branding Specialist",
        UpdatedAt = System.DateTime.Parse("2020-07-19T00:46:45.046Z").ToUniversalTime(),
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
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.CreateHrisGroupAsync(
    hrisGroup: new HrisGroup() {
        CreatedAt = System.DateTime.Parse("2023-11-01T13:13:40.714Z").ToUniversalTime(),
        Description = "Absorbeo casso.",
        Id = "9141ba1d-1155-46c4-b4cc-6ae2a117f7eb",
        IsActive = false,
        Metadata = new List<HrisMetadata>() {},
        Name = "Games",
        Type = HrisGroupType.Branch,
        UpdatedAt = System.DateTime.Parse("2026-05-20T22:30:33.995Z").ToUniversalTime(),
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

## CreateHrisJob

Create a job

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createHrisJob" method="post" path="/hris/{connection_id}/job" example="hris_job" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.CreateHrisJobAsync(
    hrisJob: new HrisJob() {
        Code = "P-05547",
        CreatedAt = System.DateTime.Parse("2020-10-28T01:13:19.491Z").ToUniversalTime(),
        Description = "Alienus timor depromo bonus vobis creator tabella callide cavus triumphus caveo.",
        EmploymentType = HrisJobEmploymentType.Freelance,
        Id = "8f48608d-59ed-444f-b906-57cc80ff5fbc",
        IsActive = false,
        Metadata = new List<HrisMetadata>() {},
        Name = "Internal Integration Specialist",
        UpdatedAt = System.DateTime.Parse("2023-01-29T18:21:35.120Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `HrisJob`                                                                                                                                        | [HrisJob](../../Models/Components/HrisJob.md)                                                                                                    | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateHrisJobQueryParamFields](../../Models/Requests/CreateHrisJobQueryParamFields.md)>                                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateHrisJobResponse](../../Models/Requests/CreateHrisJobResponse.md)**

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
            Address1 = "4418 Daniella Mall",
            Address2 = "Apt. 997",
            City = "Burke",
            CountryCode = "US",
            PostalCode = "54109",
            Region = "Ohio",
            RegionCode = "OR",
        },
        CreatedAt = System.DateTime.Parse("2021-07-18T10:32:01.414Z").ToUniversalTime(),
        Currency = "MNT",
        Description = "Commemoro acervus.",
        Id = "c9667c3e-8512-4e4f-aeaa-8ba2e9206411",
        IsActive = false,
        IsHq = true,
        LanguageLocale = "it",
        Metadata = new List<HrisMetadata>() {},
        Name = "North Kimberlyland Office",
        Telephones = new List<HrisTelephone>() {
            new HrisTelephone() {
                Telephone = "(371) 245-0699",
                Type = HrisTelephoneType.Fax,
            },
            new HrisTelephone() {
                Telephone = "(700) 845-5854",
                Type = HrisTelephoneType.Fax,
            },
            new HrisTelephone() {
                Telephone = "(461) 437-3548",
                Type = HrisTelephoneType.Home,
            },
        },
        Timezone = "Asia/Jerusalem",
        UpdatedAt = System.DateTime.Parse("2023-06-20T15:50:32.115Z").ToUniversalTime(),
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
        AlternativeNames = new List<string>() {
            "Facilitator",
            "National",
        },
        CreatedAt = System.DateTime.Parse("2022-06-23T02:10:00.789Z").ToUniversalTime(),
        Description = "Uterque vespillo adnuo ea commodo turbo suscipio condico.",
        Domain = "Health",
        Id = "30babc47-15c6-4230-81ba-799d531e0d89",
        IsActive = false,
        Metadata = new List<HrisMetadata>() {},
        Name = "International Functionality Architect",
        Subcategory = "Marble",
        Type = HrisTaxonomyType.Knowledge,
        UpdatedAt = System.DateTime.Parse("2023-05-29T01:10:20.439Z").ToUniversalTime(),
        Url = "https://fixed-membership.biz/",
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
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.CreateHrisTimeoffAsync(
    hrisTimeoff: new HrisTimeoff() {
        ApprovedAt = System.DateTime.Parse("2022-02-23T06:56:31.747Z").ToUniversalTime(),
        Comments = "Blandior ventus curiositas amplitudo.",
        CreatedAt = System.DateTime.Parse("2021-10-06T18:00:20.615Z").ToUniversalTime(),
        Duration = 4D,
        DurationType = DurationType.Day,
        EndAt = System.DateTime.Parse("2024-12-27T22:42:46.021Z").ToUniversalTime(),
        Id = "ae646603-aa50-43c8-80b1-711d7ac46661",
        IsPaid = true,
        Metadata = new List<HrisMetadata>() {},
        OriginalType = "acerbitas ut",
        Reason = "verto",
        StartAt = System.DateTime.Parse("2023-09-04T08:23:52.492Z").ToUniversalTime(),
        Status = HrisTimeoffStatus.Denied,
        Type = HrisTimeoffType.InLieu,
        UpdatedAt = System.DateTime.Parse("2022-07-12T15:17:57.340Z").ToUniversalTime(),
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
        ApprovedAt = System.DateTime.Parse("2022-07-17T13:45:19.950Z").ToUniversalTime(),
        Compensation = new List<HrisCompensation>() {
            new HrisCompensation() {
                Amount = 76761D,
                Currency = "GBP",
                Frequency = HrisCompensationFrequency.Semimonthly,
                Notes = "Vehemens annus adficio.",
                Type = HrisCompensationType.Commission,
            },
        },
        CreatedAt = System.DateTime.Parse("2019-07-01T23:53:15.738Z").ToUniversalTime(),
        EmployeeUserId = "<id>",
        EndAt = System.DateTime.Parse("2026-09-25T20:41:12.567Z").ToUniversalTime(),
        Hours = 6D,
        Id = "b611fc3a-b5cb-4c40-a191-6ea3ea726b02",
        IsApproved = false,
        Metadata = new List<HrisMetadata>() {},
        StartAt = System.DateTime.Parse("2023-07-12T08:29:55.212Z").ToUniversalTime(),
        UpdatedAt = System.DateTime.Parse("2021-07-01T13:56:00.141Z").ToUniversalTime(),
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

## GetHrisEarning

Retrieve an earning

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHrisEarning" method="get" path="/hris/{connection_id}/earning/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.GetHrisEarningAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Earning                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetHrisEarningQueryParamFields](../../Models/Requests/GetHrisEarningQueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHrisEarningResponse](../../Models/Requests/GetHrisEarningResponse.md)**

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

## GetHrisJob

Retrieve a job

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHrisJob" method="get" path="/hris/{connection_id}/job/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.GetHrisJobAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Job                                                                                                                                    |
| `Fields`                                                                                                                                         | List<[GetHrisJobQueryParamFields](../../Models/Requests/GetHrisJobQueryParamFields.md)>                                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHrisJobResponse](../../Models/Requests/GetHrisJobResponse.md)**

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

## GetHrisPaycode

Retrieve a paycode

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHrisPaycode" method="get" path="/hris/{connection_id}/paycode/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.GetHrisPaycodeAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Paycode                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetHrisPaycodeQueryParamFields](../../Models/Requests/GetHrisPaycodeQueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHrisPaycodeResponse](../../Models/Requests/GetHrisPaycodeResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetHrisPayroll

Retrieve a payroll

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHrisPayroll" method="get" path="/hris/{connection_id}/payroll/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.GetHrisPayrollAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Payroll                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetHrisPayrollQueryParamFields](../../Models/Requests/GetHrisPayrollQueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHrisPayrollResponse](../../Models/Requests/GetHrisPayrollResponse.md)**

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

## ListHrisEarnings

List all earnings

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listHrisEarnings" method="get" path="/hris/{connection_id}/earning" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHrisEarningsRequest req = new ListHrisEarningsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Hris.ListHrisEarningsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListHrisEarningsRequest](../../Models/Requests/ListHrisEarningsRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[ListHrisEarningsResponse](../../Models/Requests/ListHrisEarningsResponse.md)**

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

## ListHrisJobs

List all jobs

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listHrisJobs" method="get" path="/hris/{connection_id}/job" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHrisJobsRequest req = new ListHrisJobsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Hris.ListHrisJobsAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [ListHrisJobsRequest](../../Models/Requests/ListHrisJobsRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[ListHrisJobsResponse](../../Models/Requests/ListHrisJobsResponse.md)**

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

## ListHrisPaycodes

List all paycodes

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listHrisPaycodes" method="get" path="/hris/{connection_id}/paycode" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHrisPaycodesRequest req = new ListHrisPaycodesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Hris.ListHrisPaycodesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListHrisPaycodesRequest](../../Models/Requests/ListHrisPaycodesRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[ListHrisPaycodesResponse](../../Models/Requests/ListHrisPaycodesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListHrisPayrolls

List all payrolls

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listHrisPayrolls" method="get" path="/hris/{connection_id}/payroll" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHrisPayrollsRequest req = new ListHrisPayrollsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Hris.ListHrisPayrollsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListHrisPayrollsRequest](../../Models/Requests/ListHrisPayrollsRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[ListHrisPayrollsResponse](../../Models/Requests/ListHrisPayrollsResponse.md)**

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
        ApprovedAt = System.DateTime.Parse("2021-09-19T13:30:00.800Z").ToUniversalTime(),
        Breaks = new List<HrisAttendanceBreak>() {
            new HrisAttendanceBreak() {
                DurationMinutes = 51D,
                EndAt = System.DateTime.Parse("2024-02-13T23:13:43.301Z").ToUniversalTime(),
                Id = "4e91765c-ab0d-46cf-8ad2-a8de27909ce5",
                IsPaid = false,
                Name = "Lunch",
                StartAt = System.DateTime.Parse("2023-10-29T10:39:28.021Z").ToUniversalTime(),
            },
        },
        CreatedAt = System.DateTime.Parse("2021-08-10T19:43:18.452Z").ToUniversalTime(),
        Currency = "EUR",
        DeclaredTipsAmount = 54D,
        EmployeeUserId = "<id>",
        EndAt = System.DateTime.Parse("2024-04-22T16:42:47.481Z").ToUniversalTime(),
        HourlyRate = 16D,
        Hours = 10D,
        Id = "764bc9f8-af37-417d-acd8-49db7c2b0efe",
        JobName = "Human Accountability Administrator",
        Metadata = new List<HrisMetadata>() {},
        NonCashTipsAmount = 167D,
        StartAt = System.DateTime.Parse("2021-11-10T23:31:23.657Z").ToUniversalTime(),
        Status = HrisAttendanceStatus.Open,
        Timezone = "America/Atikokan",
        UpdatedAt = System.DateTime.Parse("2022-01-19T18:35:50.752Z").ToUniversalTime(),
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
using System.Collections.Generic;
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
        CountryCode = "US",
        CreatedAt = System.DateTime.Parse("2019-11-16T16:43:45.976Z").ToUniversalTime(),
        Currency = "USD",
        Id = "aa03b113-36b3-45b9-871f-a3957ae90678",
        IsPrimary = true,
        Metadata = new List<HrisMetadata>() {},
        Name = "Granville Schumm - Checking",
        Priority = 2D,
        RoutingNumber = "448650724",
        SplitAmount = 98D,
        SplitType = SplitType.Percentage,
        UpdatedAt = System.DateTime.Parse("2025-06-30T06:48:11.300Z").ToUniversalTime(),
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
using System.Collections.Generic;
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
        Currency = "GBP",
        Description = "Vomito voluptas dolor sed.",
        EmployerContributionAmount = 185006D,
        EmployerContributionMaxAmount = 179093D,
        EmployerContributionType = EmployerContributionType.Percentage,
        Frequency = HrisBenefitFrequency.Month,
        Id = "1b213160-acda-43a2-aa6e-7c9a80a476b7",
        IsActive = false,
        Metadata = new List<HrisMetadata>() {},
        Name = "Frozen Wooden Ball",
        Tax = Tax.PreTax,
        Type = HrisBenefitType.Other,
        UpdatedAt = System.DateTime.Parse("2023-03-20T07:41:51.712Z").ToUniversalTime(),
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
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchHrisCompanyRequest req = new PatchHrisCompanyRequest() {
    HrisCompany = new HrisCompany() {
        Address = new PropertyHrisCompanyAddress() {
            Address1 = "675 Lavinia Lights",
            City = "Rocky Mount",
            CountryCode = "US",
            PostalCode = "67325",
            Region = "Kentucky",
            RegionCode = "MO",
        },
        CreatedAt = System.DateTime.Parse("2021-05-02T22:27:38.970Z").ToUniversalTime(),
        Id = "0a42fa0f-6e39-4aa0-8793-a2e9ba9a37f0",
        LegalName = "Gottlieb Group LLC",
        Metadata = new List<HrisMetadata>() {},
        Name = "Gottlieb Group",
        UpdatedAt = System.DateTime.Parse("2026-10-07T11:32:27.746Z").ToUniversalTime(),
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
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchHrisDeductionRequest req = new PatchHrisDeductionRequest() {
    HrisDeduction = new HrisDeduction() {
        Amount = 564D,
        CoverageLevel = HrisDeductionCoverageLevel.EmployeeChild,
        CreatedAt = System.DateTime.Parse("2020-02-05T01:46:31.384Z").ToUniversalTime(),
        EmployerAmount = 80510D,
        EmployerType = EmployerType.Percentage,
        Frequency = HrisDeductionFrequency.OneTime,
        GarnishmentType = GarnishmentType.ChildSupport,
        Id = "162562d9-52ee-48e3-9fe6-c308f36aa54a",
        IsActive = true,
        MaxAmount = 21794D,
        Metadata = new List<HrisMetadata>() {},
        Notes = "Carmen desidero.",
        StartAt = System.DateTime.Parse("2025-03-14T09:35:07.270Z").ToUniversalTime(),
        Type = HrisDeductionType.Fixed,
        UpdatedAt = System.DateTime.Parse("2024-03-21T13:08:20.418Z").ToUniversalTime(),
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
        AssetTag = "fJNacaaoWi",
        CreatedAt = System.DateTime.Parse("2019-04-04T17:11:40.322Z").ToUniversalTime(),
        HasAntivirus = true,
        HasFirewall = true,
        HasHdEncrypted = true,
        HasPasswordManager = true,
        HasScreenlock = false,
        Id = "01e2646a-508e-4079-afad-1db4ea16da1d",
        IsMissing = false,
        Manufacturer = "Hackett Inc",
        Metadata = new List<HrisMetadata>() {},
        Model = "Fantastic",
        Name = "august-laptop",
        Os = "transmitter",
        OsVersion = "8.4.8",
        UpdatedAt = System.DateTime.Parse("2023-06-07T15:17:12.641Z").ToUniversalTime(),
        Version = "4.15.7",
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
using System.Collections.Generic;
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
        Id = "280e0bfa-2cc9-43e0-b278-6301912522d1",
        Metadata = new List<HrisMetadata>() {},
        Type = HrisDocumentType.Policy,
        UpdatedAt = System.DateTime.Parse("2025-10-10T16:33:05.278Z").ToUniversalTime(),
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

## PatchHrisEarning

Update an earning

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchHrisEarning" method="patch" path="/hris/{connection_id}/earning/{id}" example="hris_earning" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchHrisEarningRequest req = new PatchHrisEarningRequest() {
    HrisEarning = new HrisEarning() {
        Amount = 4026D,
        CreatedAt = System.DateTime.Parse("2019-01-26T12:44:52.326Z").ToUniversalTime(),
        Currency = "USD",
        Frequency = HrisEarningFrequency.Semimonthly,
        Id = "54ccbae7-3570-4d1f-9c26-82e80ac02a61",
        Metadata = new List<HrisMetadata>() {},
        Notes = "Deporto truculenter vinum beatae.",
        StartAt = System.DateTime.Parse("2022-07-24T22:42:12.553Z").ToUniversalTime(),
        Status = HrisEarningStatus.Ended,
        UpdatedAt = System.DateTime.Parse("2020-02-08T16:39:38.680Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Hris.PatchHrisEarningAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [PatchHrisEarningRequest](../../Models/Requests/PatchHrisEarningRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[PatchHrisEarningResponse](../../Models/Requests/PatchHrisEarningResponse.md)**

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
            Address1 = "7431 Hintz Parkway",
            Address2 = "Apt. 520",
            City = "Port Rogerview",
            CountryCode = "US",
            PostalCode = "01711",
            Region = "Missouri",
            RegionCode = "TN",
        },
        Bio = "fun advocate  🇱🇻",
        Compensation = new List<HrisCompensation>() {
            new HrisCompensation() {
                Amount = 95000D,
                Currency = "USD",
                Frequency = HrisCompensationFrequency.Year,
                Notes = "Eius.",
                Type = HrisCompensationType.Other,
            },
        },
        CreatedAt = System.DateTime.Parse("2019-09-16T15:08:53.262Z").ToUniversalTime(),
        Currency = "USD",
        DateOfBirth = System.DateTime.Parse("2001-04-22").ToUniversalTime(),
        Emails = new List<HrisEmail>() {
            new HrisEmail() {
                Email = "zetta.prohaska@insidious-stump.net",
                Type = HrisEmailType.Work,
            },
        },
        EmployeeNumber = "uCk3qaL1ei",
        EmploymentStatus = EmploymentStatus.Active,
        EmploymentType = HrisEmployeeEmploymentType.PartTime,
        FirstName = "Zetta",
        FlsaStatus = FlsaStatus.Exempt,
        Gender = HrisEmployeeGender.Male,
        HasMfa = true,
        HiredAt = System.DateTime.Parse("2019-09-16T15:08:53.262Z").ToUniversalTime(),
        Id = "52e2d3bd-02a1-4614-99a7-1d26c3d7a743",
        ImageUrl = "https://cdn.jsdelivr.net/gh/faker-js/assets-person-portrait/female/512/85.jpg",
        LanguageLocale = "in",
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
                Id = "c72de71d-aa92-41ef-938a-5cfa4a92586d",
                Namespace = "custom",
                Slug = "custom_property",
                Value = HrisMetadataValue.CreateStr(
                    "tutis"
                ),
            },
        },
        Name = "Zetta Prohaska",
        PayFrequency = PayFrequency.Week,
        Pronouns = "she/her",
        Relationships = new List<HrisEmployeerelationship>() {
            new HrisEmployeerelationship() {
                Emails = new List<HrisEmail>() {
                    new HrisEmail() {
                        Email = "keith.prohaska@gmail.com",
                    },
                },
                Name = "Keith Prohaska",
                Type = HrisEmployeerelationshipType.Sibling,
            },
            new HrisEmployeerelationship() {
                Emails = new List<HrisEmail>() {
                    new HrisEmail() {
                        Email = "keely.prohaska@icloud.com",
                    },
                },
                Name = "Keely Prohaska",
                Type = HrisEmployeerelationshipType.Other,
            },
        },
        Salutation = "Ms.",
        SsnSin = "284-82-8167",
        StorageQuotaAllocated = 3653713D,
        StorageQuotaAvailable = 3017275D,
        StorageQuotaUsed = 367449D,
        Telephones = new List<HrisTelephone>() {
            new HrisTelephone() {
                Telephone = "(320) 980-1370",
                Type = HrisTelephoneType.Home,
            },
            new HrisTelephone() {
                Telephone = "(694) 840-0166",
                Type = HrisTelephoneType.Fax,
            },
        },
        TimeoffDaysTotal = 17D,
        TimeoffDaysUsed = 9D,
        Timezone = "Europe/Ljubljana",
        Title = "District Branding Specialist",
        UpdatedAt = System.DateTime.Parse("2020-07-19T00:46:45.055Z").ToUniversalTime(),
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
using System.Collections.Generic;
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
        Id = "198fa14a-90e2-4cb1-86b0-72a0bc757ec4",
        IsActive = false,
        Metadata = new List<HrisMetadata>() {},
        Name = "Games",
        Type = HrisGroupType.Branch,
        UpdatedAt = System.DateTime.Parse("2026-05-20T22:30:34.006Z").ToUniversalTime(),
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

## PatchHrisJob

Update a job

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchHrisJob" method="patch" path="/hris/{connection_id}/job/{id}" example="hris_job" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchHrisJobRequest req = new PatchHrisJobRequest() {
    HrisJob = new HrisJob() {
        Code = "P-05547",
        CreatedAt = System.DateTime.Parse("2020-10-28T01:13:19.491Z").ToUniversalTime(),
        Description = "Alienus timor depromo bonus vobis creator tabella callide cavus triumphus caveo.",
        EmploymentType = HrisJobEmploymentType.Freelance,
        Id = "4fcbf9ed-afc0-46ee-aee8-ed4f2f5787c6",
        IsActive = false,
        Metadata = new List<HrisMetadata>() {},
        Name = "Internal Integration Specialist",
        UpdatedAt = System.DateTime.Parse("2023-01-29T18:21:35.186Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Hris.PatchHrisJobAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [PatchHrisJobRequest](../../Models/Requests/PatchHrisJobRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[PatchHrisJobResponse](../../Models/Requests/PatchHrisJobResponse.md)**

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
            Address1 = "4418 Daniella Mall",
            Address2 = "Apt. 997",
            City = "Burke",
            CountryCode = "US",
            PostalCode = "54109",
            Region = "Ohio",
            RegionCode = "OR",
        },
        CreatedAt = System.DateTime.Parse("2021-07-18T10:32:01.414Z").ToUniversalTime(),
        Currency = "MNT",
        Description = "Commemoro acervus.",
        Id = "52221078-bcf4-4d42-bd71-57b73ad30ff3",
        IsActive = false,
        IsHq = true,
        LanguageLocale = "it",
        Metadata = new List<HrisMetadata>() {},
        Name = "North Kimberlyland Office",
        Telephones = new List<HrisTelephone>() {
            new HrisTelephone() {
                Telephone = "(371) 245-0699",
                Type = HrisTelephoneType.Fax,
            },
            new HrisTelephone() {
                Telephone = "(700) 845-5854",
                Type = HrisTelephoneType.Fax,
            },
            new HrisTelephone() {
                Telephone = "(461) 437-3548",
                Type = HrisTelephoneType.Home,
            },
        },
        Timezone = "Asia/Jerusalem",
        UpdatedAt = System.DateTime.Parse("2023-06-20T15:50:32.123Z").ToUniversalTime(),
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
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchHrisTimeoffRequest req = new PatchHrisTimeoffRequest() {
    HrisTimeoff = new HrisTimeoff() {
        ApprovedAt = System.DateTime.Parse("2022-02-23T06:56:31.748Z").ToUniversalTime(),
        Comments = "Blandior ventus curiositas amplitudo.",
        CreatedAt = System.DateTime.Parse("2021-10-06T18:00:20.615Z").ToUniversalTime(),
        Duration = 4D,
        DurationType = DurationType.Day,
        EndAt = System.DateTime.Parse("2024-12-27T22:42:46.031Z").ToUniversalTime(),
        Id = "6ea366a3-ca7a-444e-ab8a-9892b84c39d4",
        IsPaid = true,
        Metadata = new List<HrisMetadata>() {},
        OriginalType = "acerbitas ut",
        Reason = "verto",
        StartAt = System.DateTime.Parse("2023-09-04T08:23:52.498Z").ToUniversalTime(),
        Status = HrisTimeoffStatus.Denied,
        Type = HrisTimeoffType.InLieu,
        UpdatedAt = System.DateTime.Parse("2022-07-12T15:17:57.342Z").ToUniversalTime(),
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
        ApprovedAt = System.DateTime.Parse("2022-07-17T13:45:19.956Z").ToUniversalTime(),
        Compensation = new List<HrisCompensation>() {
            new HrisCompensation() {
                Amount = 76761D,
                Currency = "GBP",
                Frequency = HrisCompensationFrequency.Semimonthly,
                Notes = "Vehemens annus adficio.",
                Type = HrisCompensationType.Commission,
            },
        },
        CreatedAt = System.DateTime.Parse("2019-07-01T23:53:15.738Z").ToUniversalTime(),
        EmployeeUserId = "<id>",
        EndAt = System.DateTime.Parse("2026-09-25T20:41:12.582Z").ToUniversalTime(),
        Hours = 6D,
        Id = "11c7b377-3a28-4b8e-9a51-01e059ec3bad",
        IsApproved = false,
        Metadata = new List<HrisMetadata>() {},
        StartAt = System.DateTime.Parse("2023-07-12T08:29:55.220Z").ToUniversalTime(),
        UpdatedAt = System.DateTime.Parse("2021-07-01T13:56:00.145Z").ToUniversalTime(),
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

## RemoveHrisEarning

Remove an earning

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeHrisEarning" method="delete" path="/hris/{connection_id}/earning/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.RemoveHrisEarningAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Earning    |

### Response

**[RemoveHrisEarningResponse](../../Models/Requests/RemoveHrisEarningResponse.md)**

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

## RemoveHrisJob

Remove a job

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeHrisJob" method="delete" path="/hris/{connection_id}/job/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Hris.RemoveHrisJobAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Job        |

### Response

**[RemoveHrisJobResponse](../../Models/Requests/RemoveHrisJobResponse.md)**

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
        ApprovedAt = System.DateTime.Parse("2021-09-19T13:30:00.800Z").ToUniversalTime(),
        Breaks = new List<HrisAttendanceBreak>() {
            new HrisAttendanceBreak() {
                DurationMinutes = 51D,
                EndAt = System.DateTime.Parse("2024-02-13T23:13:43.301Z").ToUniversalTime(),
                Id = "4e91765c-ab0d-46cf-8ad2-a8de27909ce5",
                IsPaid = false,
                Name = "Lunch",
                StartAt = System.DateTime.Parse("2023-10-29T10:39:28.021Z").ToUniversalTime(),
            },
        },
        CreatedAt = System.DateTime.Parse("2021-08-10T19:43:18.452Z").ToUniversalTime(),
        Currency = "EUR",
        DeclaredTipsAmount = 54D,
        EmployeeUserId = "<id>",
        EndAt = System.DateTime.Parse("2024-04-22T16:42:47.481Z").ToUniversalTime(),
        HourlyRate = 16D,
        Hours = 10D,
        Id = "764bc9f8-af37-417d-acd8-49db7c2b0efe",
        JobName = "Human Accountability Administrator",
        Metadata = new List<HrisMetadata>() {},
        NonCashTipsAmount = 167D,
        StartAt = System.DateTime.Parse("2021-11-10T23:31:23.657Z").ToUniversalTime(),
        Status = HrisAttendanceStatus.Open,
        Timezone = "America/Atikokan",
        UpdatedAt = System.DateTime.Parse("2022-01-19T18:35:50.752Z").ToUniversalTime(),
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
using System.Collections.Generic;
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
        CountryCode = "US",
        CreatedAt = System.DateTime.Parse("2019-11-16T16:43:45.976Z").ToUniversalTime(),
        Currency = "USD",
        Id = "aa03b113-36b3-45b9-871f-a3957ae90678",
        IsPrimary = true,
        Metadata = new List<HrisMetadata>() {},
        Name = "Granville Schumm - Checking",
        Priority = 2D,
        RoutingNumber = "448650724",
        SplitAmount = 98D,
        SplitType = SplitType.Percentage,
        UpdatedAt = System.DateTime.Parse("2025-06-30T06:48:11.300Z").ToUniversalTime(),
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
using System.Collections.Generic;
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
        Currency = "GBP",
        Description = "Vomito voluptas dolor sed.",
        EmployerContributionAmount = 185006D,
        EmployerContributionMaxAmount = 179093D,
        EmployerContributionType = EmployerContributionType.Percentage,
        Frequency = HrisBenefitFrequency.Month,
        Id = "1b213160-acda-43a2-aa6e-7c9a80a476b7",
        IsActive = false,
        Metadata = new List<HrisMetadata>() {},
        Name = "Frozen Wooden Ball",
        Tax = Tax.PreTax,
        Type = HrisBenefitType.Other,
        UpdatedAt = System.DateTime.Parse("2023-03-20T07:41:51.712Z").ToUniversalTime(),
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
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateHrisCompanyRequest req = new UpdateHrisCompanyRequest() {
    HrisCompany = new HrisCompany() {
        Address = new PropertyHrisCompanyAddress() {
            Address1 = "675 Lavinia Lights",
            City = "Rocky Mount",
            CountryCode = "US",
            PostalCode = "67325",
            Region = "Kentucky",
            RegionCode = "MO",
        },
        CreatedAt = System.DateTime.Parse("2021-05-02T22:27:38.970Z").ToUniversalTime(),
        Id = "0a42fa0f-6e39-4aa0-8793-a2e9ba9a37f0",
        LegalName = "Gottlieb Group LLC",
        Metadata = new List<HrisMetadata>() {},
        Name = "Gottlieb Group",
        UpdatedAt = System.DateTime.Parse("2026-10-07T11:32:27.746Z").ToUniversalTime(),
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
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateHrisDeductionRequest req = new UpdateHrisDeductionRequest() {
    HrisDeduction = new HrisDeduction() {
        Amount = 564D,
        CoverageLevel = HrisDeductionCoverageLevel.EmployeeChild,
        CreatedAt = System.DateTime.Parse("2020-02-05T01:46:31.384Z").ToUniversalTime(),
        EmployerAmount = 80510D,
        EmployerType = EmployerType.Percentage,
        Frequency = HrisDeductionFrequency.OneTime,
        GarnishmentType = GarnishmentType.ChildSupport,
        Id = "162562d9-52ee-48e3-9fe6-c308f36aa54a",
        IsActive = true,
        MaxAmount = 21794D,
        Metadata = new List<HrisMetadata>() {},
        Notes = "Carmen desidero.",
        StartAt = System.DateTime.Parse("2025-03-14T09:35:07.270Z").ToUniversalTime(),
        Type = HrisDeductionType.Fixed,
        UpdatedAt = System.DateTime.Parse("2024-03-21T13:08:20.418Z").ToUniversalTime(),
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
        AssetTag = "fJNacaaoWi",
        CreatedAt = System.DateTime.Parse("2019-04-04T17:11:40.322Z").ToUniversalTime(),
        HasAntivirus = true,
        HasFirewall = true,
        HasHdEncrypted = true,
        HasPasswordManager = true,
        HasScreenlock = false,
        Id = "01e2646a-508e-4079-afad-1db4ea16da1d",
        IsMissing = false,
        Manufacturer = "Hackett Inc",
        Metadata = new List<HrisMetadata>() {},
        Model = "Fantastic",
        Name = "august-laptop",
        Os = "transmitter",
        OsVersion = "8.4.8",
        UpdatedAt = System.DateTime.Parse("2023-06-07T15:17:12.641Z").ToUniversalTime(),
        Version = "4.15.7",
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
using System.Collections.Generic;
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
        Id = "280e0bfa-2cc9-43e0-b278-6301912522d1",
        Metadata = new List<HrisMetadata>() {},
        Type = HrisDocumentType.Policy,
        UpdatedAt = System.DateTime.Parse("2025-10-10T16:33:05.278Z").ToUniversalTime(),
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

## UpdateHrisEarning

Update an earning

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateHrisEarning" method="put" path="/hris/{connection_id}/earning/{id}" example="hris_earning" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateHrisEarningRequest req = new UpdateHrisEarningRequest() {
    HrisEarning = new HrisEarning() {
        Amount = 4026D,
        CreatedAt = System.DateTime.Parse("2019-01-26T12:44:52.326Z").ToUniversalTime(),
        Currency = "USD",
        Frequency = HrisEarningFrequency.Semimonthly,
        Id = "54ccbae7-3570-4d1f-9c26-82e80ac02a61",
        Metadata = new List<HrisMetadata>() {},
        Notes = "Deporto truculenter vinum beatae.",
        StartAt = System.DateTime.Parse("2022-07-24T22:42:12.553Z").ToUniversalTime(),
        Status = HrisEarningStatus.Ended,
        UpdatedAt = System.DateTime.Parse("2020-02-08T16:39:38.680Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Hris.UpdateHrisEarningAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [UpdateHrisEarningRequest](../../Models/Requests/UpdateHrisEarningRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[UpdateHrisEarningResponse](../../Models/Requests/UpdateHrisEarningResponse.md)**

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
            Address1 = "7431 Hintz Parkway",
            Address2 = "Apt. 520",
            City = "Port Rogerview",
            CountryCode = "US",
            PostalCode = "01711",
            Region = "Missouri",
            RegionCode = "TN",
        },
        Bio = "fun advocate  🇱🇻",
        Compensation = new List<HrisCompensation>() {
            new HrisCompensation() {
                Amount = 95000D,
                Currency = "USD",
                Frequency = HrisCompensationFrequency.Year,
                Notes = "Eius.",
                Type = HrisCompensationType.Other,
            },
        },
        CreatedAt = System.DateTime.Parse("2019-09-16T15:08:53.262Z").ToUniversalTime(),
        Currency = "USD",
        DateOfBirth = System.DateTime.Parse("2001-04-22").ToUniversalTime(),
        Emails = new List<HrisEmail>() {
            new HrisEmail() {
                Email = "zetta.prohaska@insidious-stump.net",
                Type = HrisEmailType.Work,
            },
        },
        EmployeeNumber = "uCk3qaL1ei",
        EmploymentStatus = EmploymentStatus.Active,
        EmploymentType = HrisEmployeeEmploymentType.PartTime,
        FirstName = "Zetta",
        FlsaStatus = FlsaStatus.Exempt,
        Gender = HrisEmployeeGender.Male,
        HasMfa = true,
        HiredAt = System.DateTime.Parse("2019-09-16T15:08:53.262Z").ToUniversalTime(),
        Id = "52e2d3bd-02a1-4614-99a7-1d26c3d7a743",
        ImageUrl = "https://cdn.jsdelivr.net/gh/faker-js/assets-person-portrait/female/512/85.jpg",
        LanguageLocale = "in",
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
                Id = "c72de71d-aa92-41ef-938a-5cfa4a92586d",
                Namespace = "custom",
                Slug = "custom_property",
                Value = HrisMetadataValue.CreateStr(
                    "tutis"
                ),
            },
        },
        Name = "Zetta Prohaska",
        PayFrequency = PayFrequency.Week,
        Pronouns = "she/her",
        Relationships = new List<HrisEmployeerelationship>() {
            new HrisEmployeerelationship() {
                Emails = new List<HrisEmail>() {
                    new HrisEmail() {
                        Email = "keith.prohaska@gmail.com",
                    },
                },
                Name = "Keith Prohaska",
                Type = HrisEmployeerelationshipType.Sibling,
            },
            new HrisEmployeerelationship() {
                Emails = new List<HrisEmail>() {
                    new HrisEmail() {
                        Email = "keely.prohaska@icloud.com",
                    },
                },
                Name = "Keely Prohaska",
                Type = HrisEmployeerelationshipType.Other,
            },
        },
        Salutation = "Ms.",
        SsnSin = "284-82-8167",
        StorageQuotaAllocated = 3653713D,
        StorageQuotaAvailable = 3017275D,
        StorageQuotaUsed = 367449D,
        Telephones = new List<HrisTelephone>() {
            new HrisTelephone() {
                Telephone = "(320) 980-1370",
                Type = HrisTelephoneType.Home,
            },
            new HrisTelephone() {
                Telephone = "(694) 840-0166",
                Type = HrisTelephoneType.Fax,
            },
        },
        TimeoffDaysTotal = 17D,
        TimeoffDaysUsed = 9D,
        Timezone = "Europe/Ljubljana",
        Title = "District Branding Specialist",
        UpdatedAt = System.DateTime.Parse("2020-07-19T00:46:45.055Z").ToUniversalTime(),
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
using System.Collections.Generic;
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
        Id = "198fa14a-90e2-4cb1-86b0-72a0bc757ec4",
        IsActive = false,
        Metadata = new List<HrisMetadata>() {},
        Name = "Games",
        Type = HrisGroupType.Branch,
        UpdatedAt = System.DateTime.Parse("2026-05-20T22:30:34.006Z").ToUniversalTime(),
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

## UpdateHrisJob

Update a job

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateHrisJob" method="put" path="/hris/{connection_id}/job/{id}" example="hris_job" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateHrisJobRequest req = new UpdateHrisJobRequest() {
    HrisJob = new HrisJob() {
        Code = "P-05547",
        CreatedAt = System.DateTime.Parse("2020-10-28T01:13:19.491Z").ToUniversalTime(),
        Description = "Alienus timor depromo bonus vobis creator tabella callide cavus triumphus caveo.",
        EmploymentType = HrisJobEmploymentType.Freelance,
        Id = "4fcbf9ed-afc0-46ee-aee8-ed4f2f5787c6",
        IsActive = false,
        Metadata = new List<HrisMetadata>() {},
        Name = "Internal Integration Specialist",
        UpdatedAt = System.DateTime.Parse("2023-01-29T18:21:35.186Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Hris.UpdateHrisJobAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [UpdateHrisJobRequest](../../Models/Requests/UpdateHrisJobRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[UpdateHrisJobResponse](../../Models/Requests/UpdateHrisJobResponse.md)**

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
            Address1 = "4418 Daniella Mall",
            Address2 = "Apt. 997",
            City = "Burke",
            CountryCode = "US",
            PostalCode = "54109",
            Region = "Ohio",
            RegionCode = "OR",
        },
        CreatedAt = System.DateTime.Parse("2021-07-18T10:32:01.414Z").ToUniversalTime(),
        Currency = "MNT",
        Description = "Commemoro acervus.",
        Id = "52221078-bcf4-4d42-bd71-57b73ad30ff3",
        IsActive = false,
        IsHq = true,
        LanguageLocale = "it",
        Metadata = new List<HrisMetadata>() {},
        Name = "North Kimberlyland Office",
        Telephones = new List<HrisTelephone>() {
            new HrisTelephone() {
                Telephone = "(371) 245-0699",
                Type = HrisTelephoneType.Fax,
            },
            new HrisTelephone() {
                Telephone = "(700) 845-5854",
                Type = HrisTelephoneType.Fax,
            },
            new HrisTelephone() {
                Telephone = "(461) 437-3548",
                Type = HrisTelephoneType.Home,
            },
        },
        Timezone = "Asia/Jerusalem",
        UpdatedAt = System.DateTime.Parse("2023-06-20T15:50:32.123Z").ToUniversalTime(),
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
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateHrisTimeoffRequest req = new UpdateHrisTimeoffRequest() {
    HrisTimeoff = new HrisTimeoff() {
        ApprovedAt = System.DateTime.Parse("2022-02-23T06:56:31.748Z").ToUniversalTime(),
        Comments = "Blandior ventus curiositas amplitudo.",
        CreatedAt = System.DateTime.Parse("2021-10-06T18:00:20.615Z").ToUniversalTime(),
        Duration = 4D,
        DurationType = DurationType.Day,
        EndAt = System.DateTime.Parse("2024-12-27T22:42:46.031Z").ToUniversalTime(),
        Id = "6ea366a3-ca7a-444e-ab8a-9892b84c39d4",
        IsPaid = true,
        Metadata = new List<HrisMetadata>() {},
        OriginalType = "acerbitas ut",
        Reason = "verto",
        StartAt = System.DateTime.Parse("2023-09-04T08:23:52.498Z").ToUniversalTime(),
        Status = HrisTimeoffStatus.Denied,
        Type = HrisTimeoffType.InLieu,
        UpdatedAt = System.DateTime.Parse("2022-07-12T15:17:57.342Z").ToUniversalTime(),
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
        ApprovedAt = System.DateTime.Parse("2022-07-17T13:45:19.956Z").ToUniversalTime(),
        Compensation = new List<HrisCompensation>() {
            new HrisCompensation() {
                Amount = 76761D,
                Currency = "GBP",
                Frequency = HrisCompensationFrequency.Semimonthly,
                Notes = "Vehemens annus adficio.",
                Type = HrisCompensationType.Commission,
            },
        },
        CreatedAt = System.DateTime.Parse("2019-07-01T23:53:15.738Z").ToUniversalTime(),
        EmployeeUserId = "<id>",
        EndAt = System.DateTime.Parse("2026-09-25T20:41:12.582Z").ToUniversalTime(),
        Hours = 6D,
        Id = "11c7b377-3a28-4b8e-9a51-01e059ec3bad",
        IsApproved = false,
        Metadata = new List<HrisMetadata>() {},
        StartAt = System.DateTime.Parse("2023-07-12T08:29:55.220Z").ToUniversalTime(),
        UpdatedAt = System.DateTime.Parse("2021-07-01T13:56:00.145Z").ToUniversalTime(),
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