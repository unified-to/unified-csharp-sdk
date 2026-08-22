# Event

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = Event.UserCreated;

// Open enum: use .Of() to create instances from custom string values
var custom = Event.Of("custom_value");
```


## Values

| Name                      | Value                     |
| ------------------------- | ------------------------- |
| `UserCreated`             | USER_CREATED              |
| `UserDeleted`             | USER_DELETED              |
| `ConnectionHealthy`       | CONNECTION_HEALTHY        |
| `ConnectionUnhealthy`     | CONNECTION_UNHEALTHY      |
| `ConnectionCreated`       | CONNECTION_CREATED        |
| `ConnectionUpdated`       | CONNECTION_UPDATED        |
| `ConnectionDeleted`       | CONNECTION_DELETED        |
| `ConnectionPaused`        | CONNECTION_PAUSED         |
| `ConnectionUnpaused`      | CONNECTION_UNPAUSED       |
| `IntegrationActivated`    | INTEGRATION_ACTIVATED     |
| `IntegrationDeactivated`  | INTEGRATION_DEACTIVATED   |
| `IntegrationUpdated`      | INTEGRATION_UPDATED       |
| `WorkspaceUpdated`        | WORKSPACE_UPDATED         |
| `WorkspaceOverLimit`      | WORKSPACE_OVER_LIMIT      |
| `Workspace80PercentLimit` | WORKSPACE_80PERCENT_LIMIT |
| `WebhookCreated`          | WEBHOOK_CREATED           |
| `WebhookDeleted`          | WEBHOOK_DELETED           |
| `WebhookUnhealthy`        | WEBHOOK_UNHEALTHY         |
| `WebhookPaused`           | WEBHOOK_PAUSED            |
| `WebhookUnpaused`         | WEBHOOK_UNPAUSED          |