# AccountingTransactionLineItem


## Fields

| Field                                                          | Type                                                           | Required                                                       | Description                                                    |
| -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- |
| `AccountId`                                                    | *string*                                                       | :heavy_minus_sign:                                             | (reference to AccountingAccount)                               |
| `CategoryIds`                                                  | List<*string*>                                                 | :heavy_minus_sign:                                             | N/A                                                            |
| `Description`                                                  | *string*                                                       | :heavy_minus_sign:                                             | N/A                                                            |
| `Id`                                                           | *string*                                                       | :heavy_minus_sign:                                             | N/A                                                            |
| `Name`                                                         | *string*                                                       | :heavy_minus_sign:                                             | N/A                                                            |
| `ObjectType`                                                   | *string*                                                       | :heavy_minus_sign:                                             | N/A                                                            |
| `TaxrateId`                                                    | *string*                                                       | :heavy_minus_sign:                                             | ref -> AccountingTaxrate applied to the line                   |
| `TotalAmount`                                                  | *double*                                                       | :heavy_minus_sign:                                             | will be a positive value for a debit and negative for a credit |
| `UnitAmount`                                                   | *double*                                                       | :heavy_minus_sign:                                             | N/A                                                            |
| `UnitQuantity`                                                 | *double*                                                       | :heavy_minus_sign:                                             | N/A                                                            |