# PatchAccountingOrderRequest


## Fields

| Field                                                         | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `AccountingOrder`                                             | [AccountingOrder](../../Models/Components/AccountingOrder.md) | :heavy_check_mark:                                            | N/A                                                           |
| `ConnectionId`                                                | *string*                                                      | :heavy_check_mark:                                            | ID of the connection                                          |
| `Id`                                                          | *string*                                                      | :heavy_check_mark:                                            | ID of the Order                                               |
| `Fields`                                                      | List<*string*>                                                | :heavy_minus_sign:                                            | Comma-delimited fields to return                              |