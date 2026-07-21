# EventType

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = EventType.PageView;

// Open enum: use .Of() to create instances from custom string values
var custom = EventType.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `PageView`      | PAGE_VIEW       |
| `ScreenView`    | SCREEN_VIEW     |
| `Click`         | CLICK           |
| `FormSubmit`    | FORM_SUBMIT     |
| `Purchase`      | PURCHASE        |
| `SignUp`        | SIGN_UP         |
| `Login`         | LOGIN           |
| `Logout`        | LOGOUT          |
| `Search`        | SEARCH          |
| `VideoPlay`     | VIDEO_PLAY      |
| `VideoComplete` | VIDEO_COMPLETE  |
| `FileDownload`  | FILE_DOWNLOAD   |
| `Scroll`        | SCROLL          |
| `SessionStart`  | SESSION_START   |
| `FirstVisit`    | FIRST_VISIT     |
| `Custom`        | CUSTOM          |