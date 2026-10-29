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
        Id = "10d91247-ded1-4d1d-9568-80e29a471e72",
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
        UpdatedAt = System.DateTime.Parse("2023-08-08T20:25:09.921Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```
<!-- End SDK Example Usage [usage] -->