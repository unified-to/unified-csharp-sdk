# ComputePrice


## Fields

| Field                                                                     | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `Currency`                                                                | *string*                                                                  | :heavy_minus_sign:                                                        | Currency of price_amount (ISO 4217)                                       |
| `Market`                                                                  | [ComputePriceMarket](../../Models/Components/ComputePriceMarket.md)       | :heavy_minus_sign:                                                        | Pricing market                                                            |
| `PriceAmount`                                                             | *double*                                                                  | :heavy_minus_sign:                                                        | List price                                                                |
| `PriceUnit`                                                               | [ComputePricePriceUnit](../../Models/Components/ComputePricePriceUnit.md) | :heavy_minus_sign:                                                        | Unit that price_amount is quoted in                                       |
| `RegionId`                                                                | *string*                                                                  | :heavy_minus_sign:                                                        | Region the price applies to, when it varies by region                     |