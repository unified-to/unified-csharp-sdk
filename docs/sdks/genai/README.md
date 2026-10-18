# Genai

## Overview

### Available Operations

* [CreateGenaiAgent](#creategenaiagent) - Create an agent
* [CreateGenaiEmbedding](#creategenaiembedding) - Create an embedding
* [CreateGenaiOrganization](#creategenaiorganization) - Create an organization
* [CreateGenaiPrompt](#creategenaiprompt) - Create a prompt
* [CreateGenaiTask](#creategenaitask) - Create a task
* [GetGenaiAgent](#getgenaiagent) - Retrieve an agent
* [GetGenaiModel](#getgenaimodel) - Retrieve a model
* [GetGenaiOrganization](#getgenaiorganization) - Retrieve an organization
* [GetGenaiSkill](#getgenaiskill) - Retrieve a skill
* [GetGenaiTask](#getgenaitask) - Retrieve a task
* [ListGenaiAgents](#listgenaiagents) - List all agents
* [ListGenaiModels](#listgenaimodels) - List all models
* [ListGenaiOrganizations](#listgenaiorganizations) - List all organizations
* [ListGenaiSkills](#listgenaiskills) - List all skills
* [ListGenaiTasks](#listgenaitasks) - List all tasks
* [PatchGenaiAgent](#patchgenaiagent) - Update an agent
* [PatchGenaiOrganization](#patchgenaiorganization) - Update an organization
* [PatchGenaiTask](#patchgenaitask) - Update a task
* [RemoveGenaiAgent](#removegenaiagent) - Remove an agent
* [RemoveGenaiOrganization](#removegenaiorganization) - Remove an organization
* [RemoveGenaiSkill](#removegenaiskill) - Remove a skill
* [RemoveGenaiTask](#removegenaitask) - Remove a task
* [UpdateGenaiAgent](#updategenaiagent) - Update an agent
* [UpdateGenaiOrganization](#updategenaiorganization) - Update an organization
* [UpdateGenaiTask](#updategenaitask) - Update a task

## CreateGenaiAgent

Create an agent

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createGenaiAgent" method="post" path="/genai/{connection_id}/agent" example="genai_agent" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Genai.CreateGenaiAgentAsync(
    genaiAgent: new GenaiAgent() {
        CreatedAt = System.DateTime.Parse("2020-12-18T02:23:33.723Z").ToUniversalTime(),
        Description = "Assentator tero sequi.",
        Id = "4b4fa325-d18c-4621-bec8-6e141dfa918c",
        Instructions = "Delicate tabella addo vita ver auctus corrumpo. Conscendo auctus maiores astrum sulum aufero bis stella. Non varius sto solus admitto vado suggero theatrum.",
        IsActive = false,
        Name = "daughter with",
        UpdatedAt = System.DateTime.Parse("2025-10-12T23:25:14.190Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `GenaiAgent`                                                                                                                                     | [GenaiAgent](../../Models/Components/GenaiAgent.md)                                                                                              | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateGenaiAgentQueryParamFields](../../Models/Requests/CreateGenaiAgentQueryParamFields.md)>                                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateGenaiAgentResponse](../../Models/Requests/CreateGenaiAgentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateGenaiEmbedding

Create an embedding

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createGenaiEmbedding" method="post" path="/genai/{connection_id}/embedding" example="genai_embedding" -->
```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Genai.CreateGenaiEmbeddingAsync(
    genaiEmbedding: new GenaiEmbedding() {
        Content = new List<GenaiEmbeddingContent>() {
            new GenaiEmbeddingContent() {
                Text = "Utrimque temptatio pecco demulceo.",
            },
        },
        Dimension = 423D,
        Embeddings = "Est.",
        EncondingFormat = EncondingFormat.Float,
        Id = "e074292d-1843-4b5d-ac80-a2aed8cab54b",
        MaxTokens = 223D,
        TokensUsed = 836D,
        Type = "classification",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `GenaiEmbedding`                                                                                                                                 | [GenaiEmbedding](../../Models/Components/GenaiEmbedding.md)                                                                                      | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateGenaiEmbeddingQueryParamFields](../../Models/Requests/CreateGenaiEmbeddingQueryParamFields.md)>                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateGenaiEmbeddingResponse](../../Models/Requests/CreateGenaiEmbeddingResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateGenaiOrganization

Create an organization

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createGenaiOrganization" method="post" path="/genai/{connection_id}/organization" example="genai_organization" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Genai.CreateGenaiOrganizationAsync(
    genaiOrganization: new GenaiOrganization() {
        CreatedAt = System.DateTime.Parse("2020-10-27T16:03:47.122Z").ToUniversalTime(),
        Description = "Voluptates abeo subseco.",
        Id = "7ca2cf2c-a443-4a10-8164-8c9dfd5d49a3",
        IsActive = false,
        Name = "officially about",
        UpdatedAt = System.DateTime.Parse("2023-01-25T07:38:27.459Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `GenaiOrganization`                                                                                                                              | [GenaiOrganization](../../Models/Components/GenaiOrganization.md)                                                                                | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateGenaiOrganizationQueryParamFields](../../Models/Requests/CreateGenaiOrganizationQueryParamFields.md)>                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateGenaiOrganizationResponse](../../Models/Requests/CreateGenaiOrganizationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

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

var res = await sdk.Genai.CreateGenaiPromptAsync(
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

## CreateGenaiTask

Create a task

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createGenaiTask" method="post" path="/genai/{connection_id}/task" example="genai_task" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Genai.CreateGenaiTaskAsync(
    genaiTask: new GenaiTask() {
        CompletedAt = System.DateTime.Parse("2025-09-28T19:27:29.018Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2020-10-25T20:19:33.247Z").ToUniversalTime(),
        FilesChanged = 19D,
        Id = "13736156-7047-4d07-a6ed-bd6612ebcf00",
        Instructions = "Benigne canonicus officiis solvo adsidue deleo angustus.",
        LinesAdded = 244D,
        LinesDeleted = 118D,
        Messages = new List<GenaiContent>() {
            new GenaiContent() {
                Content = "Stultus esse cursim stabilis tenetur amet contigo tristis.",
                Images = new List<string>() {},
                Role = Role.Assistant,
            },
        },
        Name = "connect multi-byte port",
        PullrequestUrl = "https://github.com/berenice.satterfield/joshingly-ignorance/pull/383",
        RepoUrl = "https://github.com/berenice.satterfield/joshingly-ignorance",
        SourceBranchIdentifier = "main",
        StartedAt = System.DateTime.Parse("2024-05-19T15:38:54.760Z").ToUniversalTime(),
        Status = GenaiTaskStatus.Blocked,
        Summary = "Cur aeternus cogito vesper.",
        TargetBranchIdentifier = "agent/joshingly-ignorance",
        TokensUsed = 2165D,
        UpdatedAt = System.DateTime.Parse("2023-02-25T03:11:57.878Z").ToUniversalTime(),
        WebUrl = "https://inexperienced-adrenalin.biz/",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `GenaiTask`                                                                                                                                      | [GenaiTask](../../Models/Components/GenaiTask.md)                                                                                                | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateGenaiTaskQueryParamFields](../../Models/Requests/CreateGenaiTaskQueryParamFields.md)>                                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateGenaiTaskResponse](../../Models/Requests/CreateGenaiTaskResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetGenaiAgent

Retrieve an agent

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getGenaiAgent" method="get" path="/genai/{connection_id}/agent/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Genai.GetGenaiAgentAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Agent                                                                                                                                  |
| `Fields`                                                                                                                                         | List<[GetGenaiAgentQueryParamFields](../../Models/Requests/GetGenaiAgentQueryParamFields.md)>                                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetGenaiAgentResponse](../../Models/Requests/GetGenaiAgentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetGenaiModel

Retrieve a model

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getGenaiModel" method="get" path="/genai/{connection_id}/model/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Genai.GetGenaiModelAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Model                                                                                                                                  |
| `Fields`                                                                                                                                         | List<[GetGenaiModelQueryParamFields](../../Models/Requests/GetGenaiModelQueryParamFields.md)>                                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetGenaiModelResponse](../../Models/Requests/GetGenaiModelResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetGenaiOrganization

Retrieve an organization

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getGenaiOrganization" method="get" path="/genai/{connection_id}/organization/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Genai.GetGenaiOrganizationAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Organization                                                                                                                           |
| `Fields`                                                                                                                                         | List<[GetGenaiOrganizationQueryParamFields](../../Models/Requests/GetGenaiOrganizationQueryParamFields.md)>                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetGenaiOrganizationResponse](../../Models/Requests/GetGenaiOrganizationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetGenaiSkill

Retrieve a skill

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getGenaiSkill" method="get" path="/genai/{connection_id}/skill/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Genai.GetGenaiSkillAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Skill                                                                                                                                  |
| `Fields`                                                                                                                                         | List<[GetGenaiSkillQueryParamFields](../../Models/Requests/GetGenaiSkillQueryParamFields.md)>                                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetGenaiSkillResponse](../../Models/Requests/GetGenaiSkillResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetGenaiTask

Retrieve a task

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getGenaiTask" method="get" path="/genai/{connection_id}/task/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Genai.GetGenaiTaskAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Task                                                                                                                                   |
| `Fields`                                                                                                                                         | List<[GetGenaiTaskQueryParamFields](../../Models/Requests/GetGenaiTaskQueryParamFields.md)>                                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetGenaiTaskResponse](../../Models/Requests/GetGenaiTaskResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListGenaiAgents

List all agents

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listGenaiAgents" method="get" path="/genai/{connection_id}/agent" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListGenaiAgentsRequest req = new ListGenaiAgentsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Genai.ListGenaiAgentsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [ListGenaiAgentsRequest](../../Models/Requests/ListGenaiAgentsRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[ListGenaiAgentsResponse](../../Models/Requests/ListGenaiAgentsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListGenaiModels

List all models

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listGenaiModels" method="get" path="/genai/{connection_id}/model" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListGenaiModelsRequest req = new ListGenaiModelsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Genai.ListGenaiModelsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [ListGenaiModelsRequest](../../Models/Requests/ListGenaiModelsRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[ListGenaiModelsResponse](../../Models/Requests/ListGenaiModelsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListGenaiOrganizations

List all organizations

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listGenaiOrganizations" method="get" path="/genai/{connection_id}/organization" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListGenaiOrganizationsRequest req = new ListGenaiOrganizationsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Genai.ListGenaiOrganizationsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [ListGenaiOrganizationsRequest](../../Models/Requests/ListGenaiOrganizationsRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[ListGenaiOrganizationsResponse](../../Models/Requests/ListGenaiOrganizationsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListGenaiSkills

List all skills

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listGenaiSkills" method="get" path="/genai/{connection_id}/skill" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListGenaiSkillsRequest req = new ListGenaiSkillsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Genai.ListGenaiSkillsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [ListGenaiSkillsRequest](../../Models/Requests/ListGenaiSkillsRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[ListGenaiSkillsResponse](../../Models/Requests/ListGenaiSkillsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListGenaiTasks

List all tasks

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listGenaiTasks" method="get" path="/genai/{connection_id}/task" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListGenaiTasksRequest req = new ListGenaiTasksRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Genai.ListGenaiTasksAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [ListGenaiTasksRequest](../../Models/Requests/ListGenaiTasksRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[ListGenaiTasksResponse](../../Models/Requests/ListGenaiTasksResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchGenaiAgent

Update an agent

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchGenaiAgent" method="patch" path="/genai/{connection_id}/agent/{id}" example="genai_agent" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchGenaiAgentRequest req = new PatchGenaiAgentRequest() {
    GenaiAgent = new GenaiAgent() {
        CreatedAt = System.DateTime.Parse("2020-12-18T02:23:33.723Z").ToUniversalTime(),
        Description = "Assentator tero sequi.",
        Id = "4fdb128a-a8fc-4643-b45e-55c89377acc6",
        Instructions = "Delicate tabella addo vita ver auctus corrumpo. Conscendo auctus maiores astrum sulum aufero bis stella. Non varius sto solus admitto vado suggero theatrum.",
        IsActive = false,
        Name = "daughter with",
        UpdatedAt = System.DateTime.Parse("2025-10-12T23:25:14.197Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Genai.PatchGenaiAgentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [PatchGenaiAgentRequest](../../Models/Requests/PatchGenaiAgentRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[PatchGenaiAgentResponse](../../Models/Requests/PatchGenaiAgentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchGenaiOrganization

Update an organization

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchGenaiOrganization" method="patch" path="/genai/{connection_id}/organization/{id}" example="genai_organization" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchGenaiOrganizationRequest req = new PatchGenaiOrganizationRequest() {
    GenaiOrganization = new GenaiOrganization() {
        CreatedAt = System.DateTime.Parse("2020-10-27T16:03:47.122Z").ToUniversalTime(),
        Description = "Voluptates abeo subseco.",
        Id = "1871a986-39d1-4033-986f-1fd96d7a5662",
        IsActive = false,
        Name = "officially about",
        UpdatedAt = System.DateTime.Parse("2023-01-25T07:38:27.461Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Genai.PatchGenaiOrganizationAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [PatchGenaiOrganizationRequest](../../Models/Requests/PatchGenaiOrganizationRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[PatchGenaiOrganizationResponse](../../Models/Requests/PatchGenaiOrganizationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchGenaiTask

Update a task

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchGenaiTask" method="patch" path="/genai/{connection_id}/task/{id}" example="genai_task" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchGenaiTaskRequest req = new PatchGenaiTaskRequest() {
    GenaiTask = new GenaiTask() {
        CompletedAt = System.DateTime.Parse("2025-09-28T19:27:29.047Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2020-10-25T20:19:33.247Z").ToUniversalTime(),
        FilesChanged = 19D,
        Id = "ca4cb66c-ceac-46a7-94c9-738e1b431c71",
        Instructions = "Benigne canonicus officiis solvo adsidue deleo angustus.",
        LinesAdded = 244D,
        LinesDeleted = 118D,
        Messages = new List<GenaiContent>() {
            new GenaiContent() {
                Content = "Stultus esse cursim stabilis tenetur amet contigo tristis.",
                Images = new List<string>() {},
                Role = Role.Assistant,
            },
        },
        Name = "connect multi-byte port",
        PullrequestUrl = "https://github.com/berenice.satterfield/joshingly-ignorance/pull/383",
        RepoUrl = "https://github.com/berenice.satterfield/joshingly-ignorance",
        SourceBranchIdentifier = "main",
        StartedAt = System.DateTime.Parse("2024-05-19T15:38:54.781Z").ToUniversalTime(),
        Status = GenaiTaskStatus.Blocked,
        Summary = "Cur aeternus cogito vesper.",
        TargetBranchIdentifier = "agent/joshingly-ignorance",
        TokensUsed = 2165D,
        UpdatedAt = System.DateTime.Parse("2023-02-25T03:11:57.892Z").ToUniversalTime(),
        WebUrl = "https://inexperienced-adrenalin.biz/",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Genai.PatchGenaiTaskAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [PatchGenaiTaskRequest](../../Models/Requests/PatchGenaiTaskRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[PatchGenaiTaskResponse](../../Models/Requests/PatchGenaiTaskResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveGenaiAgent

Remove an agent

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeGenaiAgent" method="delete" path="/genai/{connection_id}/agent/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Genai.RemoveGenaiAgentAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Agent      |

### Response

**[RemoveGenaiAgentResponse](../../Models/Requests/RemoveGenaiAgentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveGenaiOrganization

Remove an organization

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeGenaiOrganization" method="delete" path="/genai/{connection_id}/organization/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Genai.RemoveGenaiOrganizationAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter              | Type                   | Required               | Description            |
| ---------------------- | ---------------------- | ---------------------- | ---------------------- |
| `ConnectionId`         | *string*               | :heavy_check_mark:     | ID of the connection   |
| `Id`                   | *string*               | :heavy_check_mark:     | ID of the Organization |

### Response

**[RemoveGenaiOrganizationResponse](../../Models/Requests/RemoveGenaiOrganizationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveGenaiSkill

Remove a skill

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeGenaiSkill" method="delete" path="/genai/{connection_id}/skill/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Genai.RemoveGenaiSkillAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Skill      |

### Response

**[RemoveGenaiSkillResponse](../../Models/Requests/RemoveGenaiSkillResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveGenaiTask

Remove a task

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeGenaiTask" method="delete" path="/genai/{connection_id}/task/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Genai.RemoveGenaiTaskAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Task       |

### Response

**[RemoveGenaiTaskResponse](../../Models/Requests/RemoveGenaiTaskResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateGenaiAgent

Update an agent

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateGenaiAgent" method="put" path="/genai/{connection_id}/agent/{id}" example="genai_agent" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateGenaiAgentRequest req = new UpdateGenaiAgentRequest() {
    GenaiAgent = new GenaiAgent() {
        CreatedAt = System.DateTime.Parse("2020-12-18T02:23:33.723Z").ToUniversalTime(),
        Description = "Assentator tero sequi.",
        Id = "4fdb128a-a8fc-4643-b45e-55c89377acc6",
        Instructions = "Delicate tabella addo vita ver auctus corrumpo. Conscendo auctus maiores astrum sulum aufero bis stella. Non varius sto solus admitto vado suggero theatrum.",
        IsActive = false,
        Name = "daughter with",
        UpdatedAt = System.DateTime.Parse("2025-10-12T23:25:14.197Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Genai.UpdateGenaiAgentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [UpdateGenaiAgentRequest](../../Models/Requests/UpdateGenaiAgentRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[UpdateGenaiAgentResponse](../../Models/Requests/UpdateGenaiAgentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateGenaiOrganization

Update an organization

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateGenaiOrganization" method="put" path="/genai/{connection_id}/organization/{id}" example="genai_organization" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateGenaiOrganizationRequest req = new UpdateGenaiOrganizationRequest() {
    GenaiOrganization = new GenaiOrganization() {
        CreatedAt = System.DateTime.Parse("2020-10-27T16:03:47.122Z").ToUniversalTime(),
        Description = "Voluptates abeo subseco.",
        Id = "1871a986-39d1-4033-986f-1fd96d7a5662",
        IsActive = false,
        Name = "officially about",
        UpdatedAt = System.DateTime.Parse("2023-01-25T07:38:27.461Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Genai.UpdateGenaiOrganizationAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [UpdateGenaiOrganizationRequest](../../Models/Requests/UpdateGenaiOrganizationRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[UpdateGenaiOrganizationResponse](../../Models/Requests/UpdateGenaiOrganizationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateGenaiTask

Update a task

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateGenaiTask" method="put" path="/genai/{connection_id}/task/{id}" example="genai_task" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateGenaiTaskRequest req = new UpdateGenaiTaskRequest() {
    GenaiTask = new GenaiTask() {
        CompletedAt = System.DateTime.Parse("2025-09-28T19:27:29.047Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2020-10-25T20:19:33.247Z").ToUniversalTime(),
        FilesChanged = 19D,
        Id = "ca4cb66c-ceac-46a7-94c9-738e1b431c71",
        Instructions = "Benigne canonicus officiis solvo adsidue deleo angustus.",
        LinesAdded = 244D,
        LinesDeleted = 118D,
        Messages = new List<GenaiContent>() {
            new GenaiContent() {
                Content = "Stultus esse cursim stabilis tenetur amet contigo tristis.",
                Images = new List<string>() {},
                Role = Role.Assistant,
            },
        },
        Name = "connect multi-byte port",
        PullrequestUrl = "https://github.com/berenice.satterfield/joshingly-ignorance/pull/383",
        RepoUrl = "https://github.com/berenice.satterfield/joshingly-ignorance",
        SourceBranchIdentifier = "main",
        StartedAt = System.DateTime.Parse("2024-05-19T15:38:54.781Z").ToUniversalTime(),
        Status = GenaiTaskStatus.Blocked,
        Summary = "Cur aeternus cogito vesper.",
        TargetBranchIdentifier = "agent/joshingly-ignorance",
        TokensUsed = 2165D,
        UpdatedAt = System.DateTime.Parse("2023-02-25T03:11:57.892Z").ToUniversalTime(),
        WebUrl = "https://inexperienced-adrenalin.biz/",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Genai.UpdateGenaiTaskAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [UpdateGenaiTaskRequest](../../Models/Requests/UpdateGenaiTaskRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[UpdateGenaiTaskResponse](../../Models/Requests/UpdateGenaiTaskResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |