# UpdateCrmLeadRequest


## Fields

| Field                                         | Type                                          | Required                                      | Description                                   |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| `CrmLead`                                     | [CrmLead](../../Models/Components/CrmLead.md) | :heavy_check_mark:                            | N/A                                           |
| `ConnectionId`                                | *string*                                      | :heavy_check_mark:                            | ID of the connection                          |
| `Id`                                          | *string*                                      | :heavy_check_mark:                            | ID of the Lead                                |
| `Fields`                                      | List<*string*>                                | :heavy_minus_sign:                            | Comma-delimited fields to return              |