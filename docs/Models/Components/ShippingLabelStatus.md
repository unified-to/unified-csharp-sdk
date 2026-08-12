# ShippingLabelStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = ShippingLabelStatus.Pending;

// Open enum: use .Of() to create instances from custom string values
var custom = ShippingLabelStatus.Of("custom_value");
```


## Values

| Name                | Value               |
| ------------------- | ------------------- |
| `Pending`           | PENDING             |
| `Processing`        | PROCESSING          |
| `InTransit`         | IN_TRANSIT          |
| `Delivered`         | DELIVERED           |
| `Exception`         | EXCEPTION           |
| `Cancelled`         | CANCELLED           |
| `LabelCreated`      | LABEL_CREATED       |
| `PickedUp`          | PICKED_UP           |
| `OutForDelivery`    | OUT_FOR_DELIVERY    |
| `DeliveryAttempted` | DELIVERY_ATTEMPTED  |
| `ReturnedToSender`  | RETURNED_TO_SENDER  |
| `HeldAtLocation`    | HELD_AT_LOCATION    |
| `CustomsClearance`  | CUSTOMS_CLEARANCE   |
| `ExceptionResolved` | EXCEPTION_RESOLVED  |