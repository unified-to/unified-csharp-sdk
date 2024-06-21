# UnifiedTo

<div align="left">
    <a href="https://speakeasyapi.dev/"><img src="https://custom-icon-badges.demolab.com/badge/-Built%20By%20Speakeasy-212015?style=for-the-badge&logoColor=FBE331&logo=speakeasy&labelColor=545454" /></a>
    <a href="https://opensource.org/licenses/MIT">
        <img src="https://img.shields.io/badge/License-MIT-blue.svg" style="width: 100px; height: 28px;" />
    </a>
</div>


<!-- Start Installation [installation] -->
## Installation

```bash
dotnet add package UnifiedTo
```
<!-- End Installation [installation] -->

<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Accounting.CreateAccountingAccountAsync(
    connectionId: "<value>",
    accountingAccount: new AccountingAccount() {});

// handle response
```
<!-- End SDK Example Usage [usage] -->

<!-- Start Available Resources and Operations [operations] -->
## Available Resources and Operations

- [UnifiedToSDK](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/unifiedto/README.md#available-operations)
- [Accounting](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/accounting/README.md#available-operations)
- [Account](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/account/README.md#available-operations)
- [Contact](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/contact/README.md#available-operations)
- [Invoice](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/invoice/README.md#available-operations)
- [Journal](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/journal/README.md#available-operations)
- [Organization](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/organization/README.md#available-operations)
- [Taxrate](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/taxrate/README.md#available-operations)
- [Transaction](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/transaction/README.md#available-operations)
- [Ats](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/ats/README.md#available-operations)
- [Activity](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/activity/README.md#available-operations)
- [Application](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/application/README.md#available-operations)
- [Applicationstatus](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/applicationstatus/README.md#available-operations)
- [Candidate](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/candidate/README.md#available-operations)
- [Company](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/company/README.md#available-operations)
- [Document](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/document/README.md#available-operations)
- [Interview](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/interview/README.md#available-operations)
- [Job](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/job/README.md#available-operations)
- [Scorecard](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/scorecard/README.md#available-operations)
- [Commerce](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/commerce/README.md#available-operations)
- [Collection](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/collection/README.md#available-operations)
- [Inventory](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/inventory/README.md#available-operations)
- [Item](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/item/README.md#available-operations)
- [Location](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/location/README.md#available-operations)
- [Crm](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/crm/README.md#available-operations)
- [Deal](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/deal/README.md#available-operations)
- [Event](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/event/README.md#available-operations)
- [Lead](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/lead/README.md#available-operations)
- [Pipeline](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/pipeline/README.md#available-operations)
- [Enrich](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/enrich/README.md#available-operations)
- [Person](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/person/README.md#available-operations)
- [Genai](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/genai/README.md#available-operations)
- [Model](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/model/README.md#available-operations)
- [Prompt](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/prompt/README.md#available-operations)
- [Hris](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/hris/README.md#available-operations)
- [Employee](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/employee/README.md#available-operations)
- [Group](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/group/README.md#available-operations)
- [Payslip](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/payslip/README.md#available-operations)
- [Timeoff](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/timeoff/README.md#available-operations)
- [Kms](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/kms/README.md#available-operations)
- [Page](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/page/README.md#available-operations)
- [Space](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/space/README.md#available-operations)
- [Martech](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/martech/README.md#available-operations)
- [List](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/list/README.md#available-operations)
- [Member](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/member/README.md#available-operations)
- [Messaging](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/messaging/README.md#available-operations)
- [Channel](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/channel/README.md#available-operations)
- [Message](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/message/README.md#available-operations)
- [Passthrough](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/passthrough/README.md#available-operations)
- [Payment](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/payment/README.md#available-operations)
- [Link](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/link/README.md#available-operations)
- [Payout](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/payout/README.md#available-operations)
- [Refund](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/refund/README.md#available-operations)
- [Storage](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/storage/README.md#available-operations)
- [File](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/file/README.md#available-operations)
- [Task](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/task/README.md#available-operations)
- [Project](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/project/README.md#available-operations)
- [Ticketing](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/ticketing/README.md#available-operations)
- [Customer](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/customer/README.md#available-operations)
- [Note](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/note/README.md#available-operations)
- [Ticket](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/ticket/README.md#available-operations)
- [Uc](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/uc/README.md#available-operations)
- [Call](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/call/README.md#available-operations)
- [Unified](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/unified/README.md#available-operations)
- [Apicall](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/apicall/README.md#available-operations)
- [Connection](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/connection/README.md#available-operations)
- [Integration](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/integration/README.md#available-operations)
- [Auth](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/auth/README.md#available-operations)
- [Login](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/login/README.md#available-operations)
- [Issue](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/issue/README.md#available-operations)
- [Webhook](https:/github.com/unified-to/unified-csharp-sdk/blob/main/github/workspace/repo/docs/sdks/webhook/README.md#available-operations)
<!-- End Available Resources and Operations [operations] -->

<!-- Start Error Handling [errors] -->
## Error Handling

Handling errors in this SDK should largely match your expectations.  All operations return a response object or thow an exception.  If Error objects are specified in your OpenAPI Spec, the SDK will raise the appropriate type.

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

### Example

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using System;
using UnifiedTo.Models.Errors;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

try
{
    var res = await sdk.Accounting.CreateAccountingAccountAsync(
    connectionId: "<value>",
    accountingAccount: new AccountingAccount() {});
    // handle response
}
catch (Exception ex)
{
    }
    else if (ex is UnifiedTo.Models.Errors.SDKException)
    {
        // handle exception
    }
}

```
<!-- End Error Handling [errors] -->

<!-- Start Server Selection [server] -->
## Server Selection

### Select Server by Index

You can override the default server globally by passing a server index to the `serverIndex: number` optional parameter when initializing the SDK client instance. The selected server will then be used as the default on the operations that use it. This table lists the indexes associated with the available servers:

| # | Server | Variables |
| - | ------ | --------- |
| 0 | `https://api.unified.to` | None |
| 1 | `https://api-eu.unified.to` | None |




### Override Server URL Per-Client

The default server can also be overridden globally by passing a URL to the `serverUrl: str` optional parameter when initializing the SDK client instance. For example:
<!-- End Server Selection [server] -->

<!-- Start Authentication [security] -->
## Authentication

### Per-Client Security Schemes

This SDK supports the following security scheme globally:

| Name    | Type    | Scheme  |
| ------- | ------- | ------- |
| `Jwt`   | apiKey  | API key |

You can set the security parameters through the `security` optional parameter when initializing the SDK client instance. For example:
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Accounting.CreateAccountingAccountAsync(
    connectionId: "<value>",
    accountingAccount: new AccountingAccount() {});

// handle response
```
<!-- End Authentication [security] -->

<!-- Placeholder for Future Speakeasy SDK Sections -->