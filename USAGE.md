<!-- Start SDK Example Usage [usage] -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Accounting.CreateAccountingAccountAsync(
    accountingAccount: new AccountingAccount() {
        Balance = 12092D,
        CreatedAt = System.DateTime.Parse("2022-07-03T17:57:07.391Z").ToUniversalTime(),
        Currency = "CAD",
        CustomerDefinedCode = "6170",
        Description = "Voluptatibus valde spoliatio.",
        Id = "14ce1ea3-4081-4435-808e-073e20cc3a64",
        IsPayable = false,
        Metadata = new List<AccountingMetadata>() {},
        Name = "Auto Loan Account",
        Status = Status.Archived,
        Taxonomy = new List<AccountingAccountTaxonomy>() {
            new AccountingAccountTaxonomy() {
                OriginalType = "vilitas",
                Type = AccountingAccountTaxonomyType.Subgroup,
                Value = "comedo",
            },
        },
        Type = UnifiedTo.Models.Components.Type.AccountsReceivable,
        UpdatedAt = System.DateTime.Parse("2023-08-06T14:18:17.172Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```
<!-- End SDK Example Usage [usage] -->