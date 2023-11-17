# Webhook

A webhook is used to POST new/updated information to your server.


## Fields

| Field                                                                                 | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `CheckedAt`                                                                           | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `ConnectionId`                                                                        | *string*                                                                              | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `CreatedAt`                                                                           | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `Environment`                                                                         | *string*                                                                              | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `Events`                                                                              | List<[PropertyWebhookEvents](../../Models/Components/PropertyWebhookEvents.md)>       | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `HookUrl`                                                                             | *string*                                                                              | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `Id`                                                                                  | *string*                                                                              | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `IncludeRaw`                                                                          | *bool*                                                                                | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `IntegrationType`                                                                     | *string*                                                                              | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `Interval`                                                                            | *double*                                                                              | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `ObjectType`                                                                          | [ObjectType](../../Models/Components/ObjectType.md)                                   | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `Subscriptions`                                                                       | List<*string*>                                                                        | :heavy_minus_sign:                                                                    | integration-specific subscriptions IDs                                                |
| `UpdatedAt`                                                                           | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `WorkspaceId`                                                                         | *string*                                                                              | :heavy_check_mark:                                                                    | N/A                                                                                   |