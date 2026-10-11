# Prompt

## Overview

### Available Operations

* [CreateGenaiPrompt](#creategenaiprompt) - Create a prompt

## CreateGenaiPrompt

Create a prompt

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createGenaiPrompt" method="post" path="/genai/{connection_id}/prompt" example="genai_prompt" -->
```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Prompt.CreateGenaiPromptAsync(
    genaiPrompt: new GenaiPrompt() {
        Answers = new List<GenaiAnswer>() {
            new GenaiAnswer() {
                Confidence = 0.5384309098590165D,
                Id = "TeZpueFB",
                Probabilities = new List<GenaiAnswerProbability>() {
                    new GenaiAnswerProbability() {
                        Option = "veniam",
                        Probability = 0.05683182482607663D,
                    },
                    new GenaiAnswerProbability() {
                        Option = "comes",
                        Probability = 0.1404057613108307D,
                    },
                },
                Score = 0.05974147981032729D,
                Type = GenaiAnswerType.Choice,
                Value = "summisse",
            },
        },
        MaxTokens = 0.4677782787475735D,
        McpAuthorizationToken = "f45a6e93-7bed-49b4-a5c8-37a2ed2d58f4",
        McpDeferredTools = new List<string>() {},
        McpUrl = "https://unsung-dusk.info/",
        Messages = new List<GenaiContent>() {
            new GenaiContent() {
                Content = "Aegre repudiandae verecundia facere statua.",
                Images = new List<string>() {},
                Role = Role.Assistant,
            },
            new GenaiContent() {
                Content = "Speciosus xiphias soleo trepide crinis.",
                Images = new List<string>() {},
                Role = Role.System,
            },
        },
        Questions = new List<GenaiQuestion>() {
            new GenaiQuestion() {
                Id = "KtvbYiEq",
                Instructions = "Admiratio cura contabesco subvenio venustas architecto vacuus summopere.",
                Options = new List<string>() {
                    "vulnero",
                    "quasi",
                    "tolero",
                },
                Type = GenaiQuestionType.Boolean,
            },
            new GenaiQuestion() {
                Id = "oV6IURtv",
                Instructions = "Celer deleniti ventus ipsam tendo odit.",
                Options = new List<string>() {
                    "nulla",
                    "aspicio",
                    "tero",
                },
                Type = GenaiQuestionType.Choice,
            },
            new GenaiQuestion() {
                Id = "60dBZk2K",
                Instructions = "Decretum vesica amet repudiandae.",
                Options = new List<string>() {
                    "ducimus",
                    "civis",
                    "alter",
                },
                Type = GenaiQuestionType.Boolean,
            },
        },
        Responses = new List<string>() {
            "Balbus vobis circumvenio una.",
        },
        Temperature = 0D,
        TokensUsed = 975D,
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `GenaiPrompt`                                                                                                                                    | [GenaiPrompt](../../Models/Components/GenaiPrompt.md)                                                                                            | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateGenaiPromptQueryParamFields](../../Models/Requests/CreateGenaiPromptQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateGenaiPromptResponse](../../Models/Requests/CreateGenaiPromptResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |