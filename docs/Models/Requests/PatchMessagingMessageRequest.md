# PatchMessagingMessageRequest


## Fields

| Field                                                           | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `MessagingMessage`                                              | [MessagingMessage](../../Models/Components/MessagingMessage.md) | :heavy_check_mark:                                              | N/A                                                             |
| `ConnectionId`                                                  | *string*                                                        | :heavy_check_mark:                                              | ID of the connection                                            |
| `Id`                                                            | *string*                                                        | :heavy_check_mark:                                              | ID of the Message                                               |
| `Fields`                                                        | List<*string*>                                                  | :heavy_minus_sign:                                              | Comma-delimited fields to return                                |