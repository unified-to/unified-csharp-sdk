# AccountingFee


## Fields

| Field                                                                    | Type                                                                     | Required                                                                 | Description                                                              |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `Amount`                                                                 | *double*                                                                 | :heavy_check_mark:                                                       | N/A                                                                      |
| `Currency`                                                               | *string*                                                                 | :heavy_minus_sign:                                                       | ISO 4217 currency code, e.g. USD                                         |
| `OriginalType`                                                           | *string*                                                                 | :heavy_minus_sign:                                                       | The provider's original fee label, e.g. "VAT" or a shipping carrier name |
| `Type`                                                                   | [AccountingFeeType](../../Models/Components/AccountingFeeType.md)        | :heavy_check_mark:                                                       | Unified fee category                                                     |