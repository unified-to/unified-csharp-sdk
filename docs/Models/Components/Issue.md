# Issue


## Fields

| Field                                                 | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `CreatedAt`                                           | *string*                                              | :heavy_minus_sign:                                    | (ISO-8601 / YYYY-MM-DDTHH:MM:SSZ format)              |
| `CustomerNote`                                        | *string*                                              | :heavy_minus_sign:                                    | N/A                                                   |
| `Id`                                                  | *string*                                              | :heavy_minus_sign:                                    | N/A                                                   |
| `Importance`                                          | *double*                                              | :heavy_minus_sign:                                    | 1-5, 1 is lowest                                      |
| `ResolutionTime`                                      | *double*                                              | :heavy_minus_sign:                                    | N/A                                                   |
| `Size`                                                | *double*                                              | :heavy_minus_sign:                                    | 1-5, 1 is lowest                                      |
| `Status`                                              | [IssueStatus](../../Models/Components/IssueStatus.md) | :heavy_check_mark:                                    | N/A                                                   |
| `TicketRef`                                           | *string*                                              | :heavy_check_mark:                                    | N/A                                                   |
| `Title`                                               | *string*                                              | :heavy_check_mark:                                    | N/A                                                   |
| `Type`                                                | List<*string*>                                        | :heavy_minus_sign:                                    | N/A                                                   |
| `UpdatedAt`                                           | *string*                                              | :heavy_minus_sign:                                    | (ISO-8601 / YYYY-MM-DDTHH:MM:SSZ format)              |
| `Url`                                                 | *string*                                              | :heavy_minus_sign:                                    | N/A                                                   |
| `WorkspaceId`                                         | *string*                                              | :heavy_check_mark:                                    | (reference to KmsSpace)                               |