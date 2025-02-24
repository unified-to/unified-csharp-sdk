# UpdateAccountingAccountRequest


## Fields

| Field                                                             | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `AccountingAccount`                                               | [AccountingAccount](../../Models/Components/AccountingAccount.md) | :heavy_check_mark:                                                | Chart of accounts                                                 |
| `ConnectionId`                                                    | *string*                                                          | :heavy_check_mark:                                                | ID of the connection                                              |
| `Id`                                                              | *string*                                                          | :heavy_check_mark:                                                | ID of the Account                                                 |
| `Fields`                                                          | List<*string*>                                                    | :heavy_minus_sign:                                                | Comma-delimited fields to return                                  |