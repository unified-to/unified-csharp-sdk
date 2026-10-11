# CdpConsent


## Fields

| Field                                                                                 | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `Purpose`                                                                             | *string*                                                                              | :heavy_minus_sign:                                                                    | The consent purpose or objective (eg. marketing, analytics)                           |
| `Status`                                                                              | [CdpConsentStatus](../../Models/Components/CdpConsentStatus.md)                       | :heavy_minus_sign:                                                                    | The consent status for this purpose                                                   |
| `UpdatedAt`                                                                           | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_minus_sign:                                                                    | When the consent status was last updated (ISO-8601 / YYYY-MM-DDTHH:MM:SSZ format)     |