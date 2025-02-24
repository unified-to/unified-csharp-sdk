# PatchAccountingInvoiceRequest


## Fields

| Field                                                             | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `AccountingInvoice`                                               | [AccountingInvoice](../../Models/Components/AccountingInvoice.md) | :heavy_check_mark:                                                | N/A                                                               |
| `ConnectionId`                                                    | *string*                                                          | :heavy_check_mark:                                                | ID of the connection                                              |
| `Id`                                                              | *string*                                                          | :heavy_check_mark:                                                | ID of the Invoice                                                 |
| `Fields`                                                          | List<*string*>                                                    | :heavy_minus_sign:                                                | Comma-delimited fields to return                                  |