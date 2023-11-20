<!-- Start SDK Example Usage -->
```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "",
    }
);

var res = await sdk.Accounting.CreateAccountingCustomerAsync("string", new AccountingCustomer() {
    BillingAddress = new PropertyAccountingCustomerBillingAddress() {},
    Emails = new List<AccountingEmail>() {
        new AccountingEmail() {
            Email = "Kevon_Schultz42@gmail.com",
        },
    },
    Raw = new PropertyAccountingCustomerRaw() {},
    ShippingAddress = new PropertyAccountingCustomerShippingAddress() {},
    Telephones = new List<AccountingTelephone>() {
        new AccountingTelephone() {
            Telephone = "string",
        },
    },
});

// handle response
```
<!-- End SDK Example Usage -->