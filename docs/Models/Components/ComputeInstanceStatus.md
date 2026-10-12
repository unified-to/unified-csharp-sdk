# ComputeInstanceStatus

Normalized lifecycle status; set on update to start, stop, pause, resume, restart or terminate

## Example Usage

```csharp
using UnifiedTo.Models.Components;

var value = ComputeInstanceStatus.Provisioning;

// Open enum: use .Of() to create instances from custom string values
var custom = ComputeInstanceStatus.Of("custom_value");
```


## Values

| Name           | Value          |
| -------------- | -------------- |
| `Provisioning` | PROVISIONING   |
| `Starting`     | STARTING       |
| `Running`      | RUNNING        |
| `Stopping`     | STOPPING       |
| `Stopped`      | STOPPED        |
| `Pausing`      | PAUSING        |
| `Paused`       | PAUSED         |
| `Resuming`     | RESUMING       |
| `Restarting`   | RESTARTING     |
| `Terminating`  | TERMINATING    |
| `Terminated`   | TERMINATED     |
| `Preempted`    | PREEMPTED      |
| `Error`        | ERROR          |
| `Other`        | OTHER          |