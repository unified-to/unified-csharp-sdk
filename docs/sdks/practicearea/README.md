# Practicearea

## Overview

### Available Operations

* [CreateLegalPracticearea](#createlegalpracticearea) - Create a practicearea
* [GetLegalPracticearea](#getlegalpracticearea) - Retrieve a practicearea
* [ListLegalPracticeareas](#listlegalpracticeareas) - List all practiceareas
* [PatchLegalPracticearea](#patchlegalpracticearea) - Update a practicearea
* [RemoveLegalPracticearea](#removelegalpracticearea) - Remove a practicearea
* [UpdateLegalPracticearea](#updatelegalpracticearea) - Update a practicearea

## CreateLegalPracticearea

Create a practicearea

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createLegalPracticearea" method="post" path="/legal/{connection_id}/practicearea" example="legal_practicearea" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Practicearea.CreateLegalPracticeareaAsync(
    legalPracticearea: new LegalPracticearea() {
        Code = "QCA",
        CreatedAt = System.DateTime.Parse("2023-01-28T21:00:26.264Z").ToUniversalTime(),
        Id = "2f90a5f0-c690-4eb0-959c-d0b3fc3af259",
        Metadata = new List<LegalMetadata>() {},
        Name = "witty Law",
        Type = LegalPracticeareaType.Education,
        UpdatedAt = System.DateTime.Parse("2025-08-26T06:41:53.786Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `LegalPracticearea`                                                                                                                              | [LegalPracticearea](../../Models/Components/LegalPracticearea.md)                                                                                | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateLegalPracticeareaQueryParamFields](../../Models/Requests/CreateLegalPracticeareaQueryParamFields.md)>                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateLegalPracticeareaResponse](../../Models/Requests/CreateLegalPracticeareaResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetLegalPracticearea

Retrieve a practicearea

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getLegalPracticearea" method="get" path="/legal/{connection_id}/practicearea/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Practicearea.GetLegalPracticeareaAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Practicearea                                                                                                                           |
| `Fields`                                                                                                                                         | List<[GetLegalPracticeareaQueryParamFields](../../Models/Requests/GetLegalPracticeareaQueryParamFields.md)>                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetLegalPracticeareaResponse](../../Models/Requests/GetLegalPracticeareaResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListLegalPracticeareas

List all practiceareas

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listLegalPracticeareas" method="get" path="/legal/{connection_id}/practicearea" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListLegalPracticeareasRequest req = new ListLegalPracticeareasRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Practicearea.ListLegalPracticeareasAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [ListLegalPracticeareasRequest](../../Models/Requests/ListLegalPracticeareasRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[ListLegalPracticeareasResponse](../../Models/Requests/ListLegalPracticeareasResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchLegalPracticearea

Update a practicearea

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchLegalPracticearea" method="patch" path="/legal/{connection_id}/practicearea/{id}" example="legal_practicearea" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchLegalPracticeareaRequest req = new PatchLegalPracticeareaRequest() {
    LegalPracticearea = new LegalPracticearea() {
        Code = "QCA",
        CreatedAt = System.DateTime.Parse("2023-01-28T21:00:26.264Z").ToUniversalTime(),
        Id = "be840ed5-6eea-4f50-961b-c98fcc31ce35",
        Metadata = new List<LegalMetadata>() {},
        Name = "witty Law",
        Type = LegalPracticeareaType.Education,
        UpdatedAt = System.DateTime.Parse("2025-08-26T06:41:53.801Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Practicearea.PatchLegalPracticeareaAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [PatchLegalPracticeareaRequest](../../Models/Requests/PatchLegalPracticeareaRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[PatchLegalPracticeareaResponse](../../Models/Requests/PatchLegalPracticeareaResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveLegalPracticearea

Remove a practicearea

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeLegalPracticearea" method="delete" path="/legal/{connection_id}/practicearea/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Practicearea.RemoveLegalPracticeareaAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter              | Type                   | Required               | Description            |
| ---------------------- | ---------------------- | ---------------------- | ---------------------- |
| `ConnectionId`         | *string*               | :heavy_check_mark:     | ID of the connection   |
| `Id`                   | *string*               | :heavy_check_mark:     | ID of the Practicearea |

### Response

**[RemoveLegalPracticeareaResponse](../../Models/Requests/RemoveLegalPracticeareaResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateLegalPracticearea

Update a practicearea

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateLegalPracticearea" method="put" path="/legal/{connection_id}/practicearea/{id}" example="legal_practicearea" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateLegalPracticeareaRequest req = new UpdateLegalPracticeareaRequest() {
    LegalPracticearea = new LegalPracticearea() {
        Code = "QCA",
        CreatedAt = System.DateTime.Parse("2023-01-28T21:00:26.264Z").ToUniversalTime(),
        Id = "be840ed5-6eea-4f50-961b-c98fcc31ce35",
        Metadata = new List<LegalMetadata>() {},
        Name = "witty Law",
        Type = LegalPracticeareaType.Education,
        UpdatedAt = System.DateTime.Parse("2025-08-26T06:41:53.801Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Practicearea.UpdateLegalPracticeareaAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [UpdateLegalPracticeareaRequest](../../Models/Requests/UpdateLegalPracticeareaRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[UpdateLegalPracticeareaResponse](../../Models/Requests/UpdateLegalPracticeareaResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |