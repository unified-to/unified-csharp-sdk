# ListLmsInstructorsRequest


## Fields

| Field                                                                                 | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `ClassId`                                                                             | *string*                                                                              | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `CompanyId`                                                                           | *string*                                                                              | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `ConnectionId`                                                                        | *string*                                                                              | :heavy_check_mark:                                                                    | ID of the connection                                                                  |
| `CourseId`                                                                            | *string*                                                                              | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `Fields`                                                                              | List<*string*>                                                                        | :heavy_minus_sign:                                                                    | Comma-delimited fields to return                                                      |
| `Limit`                                                                               | *double*                                                                              | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `LocationId`                                                                          | *string*                                                                              | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `Offset`                                                                              | *double*                                                                              | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `Order`                                                                               | *string*                                                                              | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `Query`                                                                               | *string*                                                                              | :heavy_minus_sign:                                                                    | Query string to search. eg. email address or name                                     |
| `SessionId`                                                                           | *string*                                                                              | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `Sort`                                                                                | *string*                                                                              | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `UpdatedGte`                                                                          | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_minus_sign:                                                                    | Return only results whose updated date is equal or greater to this value              |