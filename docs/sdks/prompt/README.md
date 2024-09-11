# Prompt
(*Prompt*)

## Overview

### Available Operations

* [CreateGenaiPrompt](#creategenaiprompt) - Create a prompt

## CreateGenaiPrompt

Create a prompt

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Prompt.CreateGenaiPromptAsync(
    connectionId: "<value>",
    genaiPrompt: new GenaiPrompt() {},
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                             | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `ConnectionId`                                        | *string*                                              | :heavy_check_mark:                                    | ID of the connection                                  |
| `GenaiPrompt`                                         | [GenaiPrompt](../../Models/Components/GenaiPrompt.md) | :heavy_minus_sign:                                    | N/A                                                   |
| `Fields`                                              | List<*string*>                                        | :heavy_minus_sign:                                    | Comma-delimited fields to return                      |

### Response

**[CreateGenaiPromptResponse](../../Models/Requests/CreateGenaiPromptResponse.md)**

### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |
