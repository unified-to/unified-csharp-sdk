# TenderType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = TenderType.Card;

// Open enum: use .Of() to create instances from custom string values
var custom = TenderType.Of("custom_value");
```


## Values

| Name              | Value             |
| ----------------- | ----------------- |
| `Card`            | CARD              |
| `Cash`            | CASH              |
| `GiftCard`        | GIFT_CARD         |
| `BankTransfer`    | BANK_TRANSFER     |
| `Wallet`          | WALLET            |
| `Check`           | CHECK             |
| `StoreCredit`     | STORE_CREDIT      |
| `BuyNowPayLater`  | BUY_NOW_PAY_LATER |
| `External`        | EXTERNAL          |
| `Other`           | OTHER             |