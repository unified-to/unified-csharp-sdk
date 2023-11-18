# CreateUnifiedWebhookRequest


## Fields

| Field                                           | Type                                            | Required                                        | Description                                     |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| `ConnectionId`                                  | *string*                                        | :heavy_check_mark:                              | ID of the connection                            |
| `Object`                                        | *string*                                        | :heavy_check_mark:                              | The object to subscribe to                      |
| `Webhook`                                       | [Webhook](../../Models/Components/Webhook.md)   | :heavy_minus_sign:                              | N/A                                             |
| `Events`                                        | List<[Events](../../Models/Requests/Events.md)> | :heavy_minus_sign:                              | Which events to subscribe to.                   |