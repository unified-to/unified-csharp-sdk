# UpdateRepoCommitRequest


## Fields

| Field                                               | Type                                                | Required                                            | Description                                         |
| --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- |
| `RepoCommit`                                        | [RepoCommit](../../Models/Components/RepoCommit.md) | :heavy_check_mark:                                  | N/A                                                 |
| `ConnectionId`                                      | *string*                                            | :heavy_check_mark:                                  | ID of the connection                                |
| `Id`                                                | *string*                                            | :heavy_check_mark:                                  | ID of the Commit                                    |
| `Fields`                                            | List<*string*>                                      | :heavy_minus_sign:                                  | Comma-delimited fields to return                    |