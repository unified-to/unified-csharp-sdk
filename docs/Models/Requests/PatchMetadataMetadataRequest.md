# PatchMetadataMetadataRequest


## Fields

| Field                                                           | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `MetadataMetadata`                                              | [MetadataMetadata](../../Models/Components/MetadataMetadata.md) | :heavy_check_mark:                                              | N/A                                                             |
| `ConnectionId`                                                  | *string*                                                        | :heavy_check_mark:                                              | ID of the connection                                            |
| `Id`                                                            | *string*                                                        | :heavy_check_mark:                                              | ID of the Metadata                                              |
| `Fields`                                                        | List<*string*>                                                  | :heavy_minus_sign:                                              | Comma-delimited fields to return                                |