# AtsApplicationStatus

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = AtsApplicationStatus.New;

// Open enum: use .Of() to create instances from custom string values
var custom = AtsApplicationStatus.Of("custom_value");
```


## Values

| Name              | Value             |
| ----------------- | ----------------- |
| `New`             | NEW               |
| `Reviewing`       | REVIEWING         |
| `Screening`       | SCREENING         |
| `Submitted`       | SUBMITTED         |
| `FirstInterview`  | FIRST_INTERVIEW   |
| `SecondInterview` | SECOND_INTERVIEW  |
| `ThirdInterview`  | THIRD_INTERVIEW   |
| `BackgroundCheck` | BACKGROUND_CHECK  |
| `Offered`         | OFFERED           |
| `Accepted`        | ACCEPTED          |
| `Hired`           | HIRED             |
| `Rejected`        | REJECTED          |
| `Declined`        | DECLINED          |
| `Withdrawn`       | WITHDRAWN         |