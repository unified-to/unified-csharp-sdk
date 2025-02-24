# UpdatePaymentPaymentRequest


## Fields

| Field                                                       | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `PaymentPayment`                                            | [PaymentPayment](../../Models/Components/PaymentPayment.md) | :heavy_check_mark:                                          | N/A                                                         |
| `ConnectionId`                                              | *string*                                                    | :heavy_check_mark:                                          | ID of the connection                                        |
| `Id`                                                        | *string*                                                    | :heavy_check_mark:                                          | ID of the Payment                                           |
| `Fields`                                                    | List<*string*>                                              | :heavy_minus_sign:                                          | Comma-delimited fields to return                            |