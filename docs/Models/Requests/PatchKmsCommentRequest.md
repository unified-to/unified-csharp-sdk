# PatchKmsCommentRequest


## Fields

| Field                                               | Type                                                | Required                                            | Description                                         |
| --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- |
| `KmsComment`                                        | [KmsComment](../../Models/Components/KmsComment.md) | :heavy_check_mark:                                  | N/A                                                 |
| `ConnectionId`                                      | *string*                                            | :heavy_check_mark:                                  | ID of the connection                                |
| `Id`                                                | *string*                                            | :heavy_check_mark:                                  | ID of the Comment                                   |
| `Fields`                                            | List<*string*>                                      | :heavy_minus_sign:                                  | Comma-delimited fields to return                    |