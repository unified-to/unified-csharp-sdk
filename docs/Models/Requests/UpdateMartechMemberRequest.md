# UpdateMartechMemberRequest


## Fields

| Field                                                         | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `MarketingMember`                                             | [MarketingMember](../../Models/Components/MarketingMember.md) | :heavy_check_mark:                                            | A member represents a person                                  |
| `ConnectionId`                                                | *string*                                                      | :heavy_check_mark:                                            | ID of the connection                                          |
| `Id`                                                          | *string*                                                      | :heavy_check_mark:                                            | ID of the Member                                              |
| `Fields`                                                      | List<*string*>                                                | :heavy_minus_sign:                                            | Comma-delimited fields to return                              |