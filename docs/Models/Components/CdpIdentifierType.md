# CdpIdentifierType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = CdpIdentifierType.Email;

// Open enum: use .Of() to create instances from custom string values
var custom = CdpIdentifierType.Of("custom_value");
```


## Values

| Name          | Value         |
| ------------- | ------------- |
| `Email`       | EMAIL         |
| `UserId`      | USER_ID       |
| `AnonymousId` | ANONYMOUS_ID  |
| `DeviceId`    | DEVICE_ID     |
| `Phone`       | PHONE         |
| `CrmId`       | CRM_ID        |
| `LoyaltyId`   | LOYALTY_ID    |
| `Other`       | OTHER         |