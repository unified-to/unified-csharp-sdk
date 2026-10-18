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
        Currency = "BOB",
        CustomerDefinedCode = "quo",
        Description = "Spoliatio comedo vilitas harum cupiditate.",
        Id = "72bfc113-a553-4cf9-b69e-8f94412e0926",
        IsPayable = true,
        Name = "Electronic Aluminum Tuna",
        Status = Status.Archived,
        Taxonomy = new List<AccountingAccountTaxonomy>() {
            new AccountingAccountTaxonomy() {
                OriginalType = "vesper",
                Type = AccountingAccountTaxonomyType.Subgroup,
                Value = "iste",
            },
            new AccountingAccountTaxonomy() {
                OriginalType = "adamo",
                Type = AccountingAccountTaxonomyType.Subgroup,
                Value = "peccatus",
            },
        },
        Type = UnifiedTo.Models.Components.Type.Bank,
        UpdatedAt = System.DateTime.Parse("2023-01-06T17:06:24.316Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```
<!-- End SDK Example Usage [usage] -->