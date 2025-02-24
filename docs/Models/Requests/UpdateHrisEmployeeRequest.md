# UpdateHrisEmployeeRequest


## Fields

| Field                                                   | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `HrisEmployee`                                          | [HrisEmployee](../../Models/Components/HrisEmployee.md) | :heavy_check_mark:                                      | N/A                                                     |
| `ConnectionId`                                          | *string*                                                | :heavy_check_mark:                                      | ID of the connection                                    |
| `Id`                                                    | *string*                                                | :heavy_check_mark:                                      | ID of the Employee                                      |
| `Fields`                                                | List<*string*>                                          | :heavy_minus_sign:                                      | Comma-delimited fields to return                        |