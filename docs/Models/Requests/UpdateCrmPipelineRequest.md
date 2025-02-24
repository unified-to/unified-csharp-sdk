# UpdateCrmPipelineRequest


## Fields

| Field                                                 | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `CrmPipeline`                                         | [CrmPipeline](../../Models/Components/CrmPipeline.md) | :heavy_check_mark:                                    | N/A                                                   |
| `ConnectionId`                                        | *string*                                              | :heavy_check_mark:                                    | ID of the connection                                  |
| `Id`                                                  | *string*                                              | :heavy_check_mark:                                    | ID of the Pipeline                                    |
| `Fields`                                              | List<*string*>                                        | :heavy_minus_sign:                                    | Comma-delimited fields to return                      |