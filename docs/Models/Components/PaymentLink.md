# PaymentLink


## Fields

| Field                                                                                 | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `Amount`                                                                              | *double*                                                                              | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `ContactId`                                                                           | *string*                                                                              | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `CreatedAt`                                                                           | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `Currency`                                                                            | *string*                                                                              | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `Id`                                                                                  | *string*                                                                              | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `IsActive`                                                                            | *bool*                                                                                | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `Lineitems`                                                                           | List<[PaymentLinkLineitem](../../Models/Components/PaymentLinkLineitem.md)>           | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `PaymentId`                                                                           | *string*                                                                              | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `Raw`                                                                                 | Dictionary<String, *object*>                                                          | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `UpdatedAt`                                                                           | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `Url`                                                                                 | *string*                                                                              | :heavy_minus_sign:                                                                    | N/A                                                                                   |