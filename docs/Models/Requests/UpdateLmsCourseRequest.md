# UpdateLmsCourseRequest


## Fields

| Field                                             | Type                                              | Required                                          | Description                                       |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| `LmsCourse`                                       | [LmsCourse](../../Models/Components/LmsCourse.md) | :heavy_check_mark:                                | N/A                                               |
| `ConnectionId`                                    | *string*                                          | :heavy_check_mark:                                | ID of the connection                              |
| `Id`                                              | *string*                                          | :heavy_check_mark:                                | ID of the Course                                  |
| `Fields`                                          | List<*string*>                                    | :heavy_minus_sign:                                | Comma-delimited fields to return                  |