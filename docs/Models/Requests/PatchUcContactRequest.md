# PatchUcContactRequest


## Fields

| Field                                                                   | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `UcContact`                                                             | [UcContact](../../Models/Components/UcContact.md)                       | :heavy_check_mark:                                                      | A contact represents a person that optionally is associated with a call |
| `ConnectionId`                                                          | *string*                                                                | :heavy_check_mark:                                                      | ID of the connection                                                    |
| `Id`                                                                    | *string*                                                                | :heavy_check_mark:                                                      | ID of the Contact                                                       |
| `Fields`                                                                | List<*string*>                                                          | :heavy_minus_sign:                                                      | Comma-delimited fields to return                                        |