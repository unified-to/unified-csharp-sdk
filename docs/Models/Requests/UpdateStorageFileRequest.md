# UpdateStorageFileRequest


## Fields

| Field                                                 | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `StorageFile`                                         | [StorageFile](../../Models/Components/StorageFile.md) | :heavy_check_mark:                                    | N/A                                                   |
| `ConnectionId`                                        | *string*                                              | :heavy_check_mark:                                    | ID of the connection                                  |
| `Id`                                                  | *string*                                              | :heavy_check_mark:                                    | ID of the File                                        |
| `Fields`                                              | List<*string*>                                        | :heavy_minus_sign:                                    | Comma-delimited fields to return                      |