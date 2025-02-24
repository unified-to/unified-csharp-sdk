# PatchMartechListRequest


## Fields

| Field                                                     | Type                                                      | Required                                                  | Description                                               |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| `MarketingList`                                           | [MarketingList](../../Models/Components/MarketingList.md) | :heavy_check_mark:                                        | Mailing List                                              |
| `ConnectionId`                                            | *string*                                                  | :heavy_check_mark:                                        | ID of the connection                                      |
| `Id`                                                      | *string*                                                  | :heavy_check_mark:                                        | ID of the List                                            |
| `Fields`                                                  | List<*string*>                                            | :heavy_minus_sign:                                        | Comma-delimited fields to return                          |