<!-- Start SDK Example Usage [usage] -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Accounting.CreateAccountingAccountAsync(
    connectionId: "<id>",
    accountingAccount: new AccountingAccount() {},
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```
<!-- End SDK Example Usage [usage] -->