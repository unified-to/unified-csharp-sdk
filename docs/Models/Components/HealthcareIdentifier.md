# HealthcareIdentifier


## Fields

| Field                                                                           | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `System`                                                                        | *string*                                                                        | :heavy_minus_sign:                                                              | The namespace/system URI that issued the identifier                             |
| `Type`                                                                          | [HealthcareIdentifierType](../../Models/Components/HealthcareIdentifierType.md) | :heavy_minus_sign:                                                              | The kind of identifier                                                          |
| `Value`                                                                         | *string*                                                                        | :heavy_check_mark:                                                              | The identifier value                                                            |