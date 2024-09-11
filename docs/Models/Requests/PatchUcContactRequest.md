# PatchUcContactRequest


## Fields

| Field                                                                   | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `ConnectionId`                                                          | *string*                                                                | :heavy_check_mark:                                                      | ID of the connection                                                    |
| `Id`                                                                    | *string*                                                                | :heavy_check_mark:                                                      | ID of the Contact                                                       |
| `UcContact`                                                             | [UcContact](../../Models/Components/UcContact.md)                       | :heavy_minus_sign:                                                      | A contact represents a person that optionally is associated with a call |
| `Fields`                                                                | List<*string*>                                                          | :heavy_minus_sign:                                                      | Comma-delimited fields to return                                        |