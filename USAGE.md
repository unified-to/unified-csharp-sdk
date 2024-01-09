<!-- Start SDK Example Usage [usage] -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Accounting.CreateAccountingAccountAsync(ConnectionId: "string", AccountingAccount: new AccountingAccount() {
    Name = "string",
    Raw = new PropertyAccountingAccountRaw() {},
});

// handle response
```
<!-- End SDK Example Usage [usage] -->