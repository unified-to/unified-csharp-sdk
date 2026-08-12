<!-- Start SDK Example Usage [usage] -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Accounting.CreateAccountingAccountAsync(
    accountingAccount: new AccountingAccount() {},
    connectionId: "<id>"
);

// handle response
```
<!-- End SDK Example Usage [usage] -->