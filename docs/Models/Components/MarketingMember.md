# MarketingMember

A member represents a person


## Fields

| Field                                                                                 | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `CreatedAt`                                                                           | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `Emails`                                                                              | List<[MarketingEmail](../../Models/Components/MarketingEmail.md)>                     | :heavy_minus_sign:                                                                    | An array of email addresses for this member                                           |
| `Id`                                                                                  | *string*                                                                              | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `ListIds`                                                                             | List<*string*>                                                                        | :heavy_minus_sign:                                                                    | An array of list IDs associated with this member                                      |
| `Name`                                                                                | *string*                                                                              | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `Raw`                                                                                 | [PropertyMarketingMemberRaw](../../Models/Components/PropertyMarketingMemberRaw.md)   | :heavy_minus_sign:                                                                    | The raw data returned by the integration for this member                              |
| `Tags`                                                                                | List<*string*>                                                                        | :heavy_minus_sign:                                                                    | An array of tags associated with this member                                          |
| `UpdatedAt`                                                                           | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_minus_sign:                                                                    | N/A                                                                                   |