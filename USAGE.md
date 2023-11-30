<!-- Start SDK Example Usage [usage] -->
```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "",
    }
);

var res = await sdk.Accounting.CreateAccountingAccountAsync("string", new AccountingAccount() {
    Name = "string",
    Raw = new PropertyAccountingAccountRaw() {},
});

// handle response
```
<!-- End SDK Example Usage [usage] -->