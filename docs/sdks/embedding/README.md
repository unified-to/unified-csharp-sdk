# Embedding

## Overview

### Available Operations

* [CreateGenaiEmbedding](#creategenaiembedding) - Create an embedding

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

var res = await sdk.Embedding.CreateGenaiEmbeddingAsync(
    genaiEmbedding: new GenaiEmbedding() {
        Content = new List<GenaiEmbeddingContent>() {
            new GenaiEmbeddingContent() {
                Text = "Utrimque temptatio pecco demulceo.",
            },
        },
        Dimension = 423D,
        Embeddings = "Est.",
        EncondingFormat = EncondingFormat.Float,
        Id = "a0e27dcd-324c-40b3-874e-48cf9d3157d1",
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