<!-- Start SDK Example Usage [usage] -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Accounting.CreateAccountingAccountAsync(
    connectionId: "string",
    accountingAccount: new AccountingAccount() {
    Name = "string",
});

// handle response
```
<!-- End SDK Example Usage [usage] -->