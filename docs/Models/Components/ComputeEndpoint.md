# ComputeEndpoint


## Fields

| Field                                           | Type                                            | Required                                        | Description                                     |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| `IsAuthRequired`                                | *bool*                                          | :heavy_minus_sign:                              | Whether the URL requires a vendor access token  |
| `Port`                                          | *double*                                        | :heavy_minus_sign:                              | The port inside the instance                    |
| `Protocol`                                      | [Protocol](../../Models/Components/Protocol.md) | :heavy_minus_sign:                              | The protocol served on this port                |
| `Url`                                           | *string*                                        | :heavy_minus_sign:                              | Public or proxied URL for this port             |