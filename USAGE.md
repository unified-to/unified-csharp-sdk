<!-- Start SDK Example Usage [usage] -->
```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;

var sdk = new UnifiedTo(
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