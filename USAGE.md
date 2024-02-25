<!-- Start SDK Example Usage [usage] -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Accounting.CreateAccountingAccountAsync(
    security: new CreateAccountingAccountSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    accountingAccount: new AccountingAccount() {
    Name = "<value>",
});

// handle response
```
<!-- End SDK Example Usage [usage] -->