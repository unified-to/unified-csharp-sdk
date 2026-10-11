# PropertyCrmEventTask

The task object, when type = task


## Fields

| Field                                                                                 | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `Description`                                                                         | *string*                                                                              | :heavy_minus_sign:                                                                    | The event task's descriptionnote                                                      |
| `DueAt`                                                                               | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_minus_sign:                                                                    | (ISO-8601 / YYYY-MM-DDTHH:MM:SSZ format)                                              |
| `Name`                                                                                | *string*                                                                              | :heavy_minus_sign:                                                                    | The event task's nametitle/subject                                                    |
| `Priority`                                                                            | [Priority](../../Models/Components/Priority.md)                                       | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `Status`                                                                              | [PropertyCrmEventTaskStatus](../../Models/Components/PropertyCrmEventTaskStatus.md)   | :heavy_minus_sign:                                                                    | The event task's status                                                               |