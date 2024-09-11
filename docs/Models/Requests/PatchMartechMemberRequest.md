# PatchMartechMemberRequest


## Fields

| Field                                                         | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `ConnectionId`                                                | *string*                                                      | :heavy_check_mark:                                            | ID of the connection                                          |
| `Id`                                                          | *string*                                                      | :heavy_check_mark:                                            | ID of the Member                                              |
| `MarketingMember`                                             | [MarketingMember](../../Models/Components/MarketingMember.md) | :heavy_minus_sign:                                            | A member represents a person                                  |
| `Fields`                                                      | List<*string*>                                                | :heavy_minus_sign:                                            | Comma-delimited fields to return                              |