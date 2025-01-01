# PatchPaymentSubscriptionRequest


## Fields

| Field                                                                 | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `ConnectionId`                                                        | *string*                                                              | :heavy_check_mark:                                                    | ID of the connection                                                  |
| `Id`                                                                  | *string*                                                              | :heavy_check_mark:                                                    | ID of the Subscription                                                |
| `PaymentSubscription`                                                 | [PaymentSubscription](../../Models/Components/PaymentSubscription.md) | :heavy_minus_sign:                                                    | N/A                                                                   |
| `Fields`                                                              | List<*string*>                                                        | :heavy_minus_sign:                                                    | Comma-delimited fields to return                                      |