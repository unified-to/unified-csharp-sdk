# UnifiedTo


<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Accounting.CreateAccountingAccountAsync(
    accountingAccount: new AccountingAccount() {},
    connectionId: "<id>",
    fields: new List<string>() {
        "<value>",
    },
    raw: "<value>"
);

// handle response
```
<!-- End SDK Example Usage [usage] -->

<!-- Start Authentication [security] -->
## Authentication

### Per-Client Security Schemes

This SDK supports the following security scheme globally:

| Name  | Type   | Scheme  |
| ----- | ------ | ------- |
| `Jwt` | apiKey | API key |

You can set the security parameters through the `security` optional parameter when initializing the SDK client instance. For example:
```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Accounting.CreateAccountingAccountAsync(
    accountingAccount: new AccountingAccount() {},
    connectionId: "<id>",
    fields: new List<string>() {
        "<value>",
    },
    raw: "<value>"
);

// handle response
```
<!-- End Authentication [security] -->

<!-- Start Error Handling [errors] -->
## Error Handling

Handling errors in this SDK should largely match your expectations. All operations return a response object or throw an exception.

By default, an API error will raise a `UnifiedTo.Models.Errors.SDKException` exception, which has the following properties:

| Property      | Type                  | Description           |
|---------------|-----------------------|-----------------------|
| `Message`     | *string*              | The error message     |
| `StatusCode`  | *int*                 | The HTTP status code  |
| `RawResponse` | *HttpResponseMessage* | The raw HTTP response |
| `Body`        | *string*              | The response content  |

When custom error responses are specified for an operation, the SDK may also throw their associated exceptions. You can refer to respective *Errors* tables in SDK docs for more details on possible exception types for each operation. For example, the `CreateAccountingAccountAsync` method throws the following exceptions:

| Error Type                           | Status Code | Content Type |
| ------------------------------------ | ----------- | ------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX    | \*/\*        |

### Example

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Errors;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

try
{
    var res = await sdk.Accounting.CreateAccountingAccountAsync(
        accountingAccount: new AccountingAccount() {},
        connectionId: "<id>",
        fields: new List<string>() {
            "<value>",
        },
        raw: "<value>"
    );

    // handle response
}
catch (Exception ex)
{
    if (ex is UnifiedTo.Models.Errors.SDKException)
    {
        // Handle default exception
        throw;
    }
}
```
<!-- End Error Handling [errors] -->

<!-- Start Server Selection [server] -->
## Server Selection

### Select Server by Index

You can override the default server globally by passing a server index to the `serverIndex: int` optional parameter when initializing the SDK client instance. The selected server will then be used as the default on the operations that use it. This table lists the indexes associated with the available servers:

| #   | Server                      | Description                |
| --- | --------------------------- | -------------------------- |
| 0   | `https://api.unified.to`    | North American data region |
| 1   | `https://api-eu.unified.to` | European data region       |
| 2   | `https://api-au.unified.to` | Australian data region     |

#### Example

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(
    serverIndex: 2,
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    }
);

var res = await sdk.Accounting.CreateAccountingAccountAsync(
    accountingAccount: new AccountingAccount() {},
    connectionId: "<id>",
    fields: new List<string>() {
        "<value>",
    },
    raw: "<value>"
);

// handle response
```

### Override Server URL Per-Client

The default server can also be overridden globally by passing a URL to the `serverUrl: string` optional parameter when initializing the SDK client instance. For example:
```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(
    serverUrl: "https://api-au.unified.to",
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    }
);

var res = await sdk.Accounting.CreateAccountingAccountAsync(
    accountingAccount: new AccountingAccount() {},
    connectionId: "<id>",
    fields: new List<string>() {
        "<value>",
    },
    raw: "<value>"
);

// handle response
```
<!-- End Server Selection [server] -->

<!-- Placeholder for Future Speakeasy SDK Sections -->