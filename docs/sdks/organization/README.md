# Organization

## Overview

### Available Operations

* [CreateAdsOrganization](#createadsorganization) - Create an organization
* [CreateRepoOrganization](#createrepoorganization) - Create an organization
* [GetAccountingOrganization](#getaccountingorganization) - Retrieve an organization
* [GetAdsOrganization](#getadsorganization) - Retrieve an organization
* [GetRepoOrganization](#getrepoorganization) - Retrieve an organization
* [ListAccountingOrganizations](#listaccountingorganizations) - List all organizations
* [ListAdsOrganizations](#listadsorganizations) - List all organizations
* [ListRepoOrganizations](#listrepoorganizations) - List all organizations
* [PatchAdsOrganization](#patchadsorganization) - Update an organization
* [PatchRepoOrganization](#patchrepoorganization) - Update an organization
* [RemoveAdsOrganization](#removeadsorganization) - Remove an organization
* [RemoveRepoOrganization](#removerepoorganization) - Remove an organization
* [UpdateAdsOrganization](#updateadsorganization) - Update an organization
* [UpdateRepoOrganization](#updaterepoorganization) - Update an organization

## CreateAdsOrganization

Create an organization

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAdsOrganization" method="post" path="/ads/{connection_id}/organization" example="ads_organization" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Organization.CreateAdsOrganizationAsync(
    adsOrganization: new AdsOrganization() {
        AccountNumber = "LQUJx8zQBW",
        CreatedAt = System.DateTime.Parse("2020-07-23T21:47:11.440Z").ToUniversalTime(),
        Currency = "USD",
        Id = "0ca7207a-a860-45e9-87da-94e04e0f06a4",
        Managers = new List<AdsManager>() {
            new AdsManager() {
                Id = "e4fd87df-9f8b-4fa0-a77b-b7d18669e350",
                Name = "Parker, Leannon and Gibson",
            },
        },
        Name = "Ankunding Inc",
        Status = AdsOrganizationStatus.Processing,
        Timezone = "Europe/Chisinau",
        UpdatedAt = System.DateTime.Parse("2026-02-27T02:32:02.767Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AdsOrganization`                                                                                                                                | [AdsOrganization](../../Models/Components/AdsOrganization.md)                                                                                    | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateAdsOrganizationQueryParamFields](../../Models/Requests/CreateAdsOrganizationQueryParamFields.md)>                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateAdsOrganizationResponse](../../Models/Requests/CreateAdsOrganizationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateRepoOrganization

Create an organization

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createRepoOrganization" method="post" path="/repo/{connection_id}/organization" example="repo_organization" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Organization.CreateRepoOrganizationAsync(
    repoOrganization: new RepoOrganization() {
        AvatarUrl = "https://picsum.photos/seed/fGl6Lb/3157/3173",
        CreatedAt = System.DateTime.Parse("2022-07-07T00:18:40.748Z").ToUniversalTime(),
        Description = "Trepide defendo supra testimonium ager.",
        Id = "94512032-1bb0-446e-b197-d5b971050f38",
        Name = "Denesik - Lemke",
        UpdatedAt = System.DateTime.Parse("2023-08-12T23:35:02.193Z").ToUniversalTime(),
        WebUrl = "https://turbulent-overheard.biz",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `RepoOrganization`                                                                                                                               | [RepoOrganization](../../Models/Components/RepoOrganization.md)                                                                                  | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateRepoOrganizationQueryParamFields](../../Models/Requests/CreateRepoOrganizationQueryParamFields.md)>                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateRepoOrganizationResponse](../../Models/Requests/CreateRepoOrganizationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAccountingOrganization

Retrieve an organization

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAccountingOrganization" method="get" path="/accounting/{connection_id}/organization/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Organization.GetAccountingOrganizationAsync(
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
| `Fields`                                                                                                                                         | List<[GetAccountingOrganizationQueryParamFields](../../Models/Requests/GetAccountingOrganizationQueryParamFields.md)>                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAccountingOrganizationResponse](../../Models/Requests/GetAccountingOrganizationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetAdsOrganization

Retrieve an organization

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAdsOrganization" method="get" path="/ads/{connection_id}/organization/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Organization.GetAdsOrganizationAsync(
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
| `Fields`                                                                                                                                         | List<[GetAdsOrganizationQueryParamFields](../../Models/Requests/GetAdsOrganizationQueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetAdsOrganizationResponse](../../Models/Requests/GetAdsOrganizationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetRepoOrganization

Retrieve an organization

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getRepoOrganization" method="get" path="/repo/{connection_id}/organization/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Organization.GetRepoOrganizationAsync(
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
| `Fields`                                                                                                                                         | List<[GetRepoOrganizationQueryParamFields](../../Models/Requests/GetRepoOrganizationQueryParamFields.md)>                                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetRepoOrganizationResponse](../../Models/Requests/GetRepoOrganizationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAccountingOrganizations

List all organizations

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAccountingOrganizations" method="get" path="/accounting/{connection_id}/organization" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAccountingOrganizationsRequest req = new ListAccountingOrganizationsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Organization.ListAccountingOrganizationsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [ListAccountingOrganizationsRequest](../../Models/Requests/ListAccountingOrganizationsRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[ListAccountingOrganizationsResponse](../../Models/Requests/ListAccountingOrganizationsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListAdsOrganizations

List all organizations

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAdsOrganizations" method="get" path="/ads/{connection_id}/organization" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListAdsOrganizationsRequest req = new ListAdsOrganizationsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Organization.ListAdsOrganizationsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [ListAdsOrganizationsRequest](../../Models/Requests/ListAdsOrganizationsRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[ListAdsOrganizationsResponse](../../Models/Requests/ListAdsOrganizationsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListRepoOrganizations

List all organizations

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listRepoOrganizations" method="get" path="/repo/{connection_id}/organization" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListRepoOrganizationsRequest req = new ListRepoOrganizationsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Organization.ListRepoOrganizationsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [ListRepoOrganizationsRequest](../../Models/Requests/ListRepoOrganizationsRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[ListRepoOrganizationsResponse](../../Models/Requests/ListRepoOrganizationsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchAdsOrganization

Update an organization

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchAdsOrganization" method="patch" path="/ads/{connection_id}/organization/{id}" example="ads_organization" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchAdsOrganizationRequest req = new PatchAdsOrganizationRequest() {
    AdsOrganization = new AdsOrganization() {
        AccountNumber = "LQUJx8zQBW",
        CreatedAt = System.DateTime.Parse("2020-07-23T21:47:11.440Z").ToUniversalTime(),
        Currency = "USD",
        Id = "6d20a695-fa80-4f8e-8b00-e3d1dd334cac",
        Managers = new List<AdsManager>() {
            new AdsManager() {
                Id = "e4fd87df-9f8b-4fa0-a77b-b7d18669e350",
                Name = "Parker, Leannon and Gibson",
            },
        },
        Name = "Ankunding Inc",
        Status = AdsOrganizationStatus.Processing,
        Timezone = "Europe/Chisinau",
        UpdatedAt = System.DateTime.Parse("2026-02-27T02:32:02.778Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Organization.PatchAdsOrganizationAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [PatchAdsOrganizationRequest](../../Models/Requests/PatchAdsOrganizationRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[PatchAdsOrganizationResponse](../../Models/Requests/PatchAdsOrganizationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchRepoOrganization

Update an organization

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchRepoOrganization" method="patch" path="/repo/{connection_id}/organization/{id}" example="repo_organization" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchRepoOrganizationRequest req = new PatchRepoOrganizationRequest() {
    RepoOrganization = new RepoOrganization() {
        AvatarUrl = "https://picsum.photos/seed/fGl6Lb/3157/3173",
        CreatedAt = System.DateTime.Parse("2022-07-07T00:18:40.748Z").ToUniversalTime(),
        Description = "Trepide defendo supra testimonium ager.",
        Id = "9e3a01c3-1824-44f1-b5d3-55744e673e8a",
        Name = "Denesik - Lemke",
        UpdatedAt = System.DateTime.Parse("2023-08-12T23:35:02.195Z").ToUniversalTime(),
        WebUrl = "https://turbulent-overheard.biz",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Organization.PatchRepoOrganizationAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [PatchRepoOrganizationRequest](../../Models/Requests/PatchRepoOrganizationRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[PatchRepoOrganizationResponse](../../Models/Requests/PatchRepoOrganizationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveAdsOrganization

Remove an organization

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeAdsOrganization" method="delete" path="/ads/{connection_id}/organization/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Organization.RemoveAdsOrganizationAsync(
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

**[RemoveAdsOrganizationResponse](../../Models/Requests/RemoveAdsOrganizationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveRepoOrganization

Remove an organization

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeRepoOrganization" method="delete" path="/repo/{connection_id}/organization/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Organization.RemoveRepoOrganizationAsync(
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

**[RemoveRepoOrganizationResponse](../../Models/Requests/RemoveRepoOrganizationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateAdsOrganization

Update an organization

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateAdsOrganization" method="put" path="/ads/{connection_id}/organization/{id}" example="ads_organization" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateAdsOrganizationRequest req = new UpdateAdsOrganizationRequest() {
    AdsOrganization = new AdsOrganization() {
        AccountNumber = "LQUJx8zQBW",
        CreatedAt = System.DateTime.Parse("2020-07-23T21:47:11.440Z").ToUniversalTime(),
        Currency = "USD",
        Id = "6d20a695-fa80-4f8e-8b00-e3d1dd334cac",
        Managers = new List<AdsManager>() {
            new AdsManager() {
                Id = "e4fd87df-9f8b-4fa0-a77b-b7d18669e350",
                Name = "Parker, Leannon and Gibson",
            },
        },
        Name = "Ankunding Inc",
        Status = AdsOrganizationStatus.Processing,
        Timezone = "Europe/Chisinau",
        UpdatedAt = System.DateTime.Parse("2026-02-27T02:32:02.778Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Organization.UpdateAdsOrganizationAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [UpdateAdsOrganizationRequest](../../Models/Requests/UpdateAdsOrganizationRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[UpdateAdsOrganizationResponse](../../Models/Requests/UpdateAdsOrganizationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateRepoOrganization

Update an organization

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateRepoOrganization" method="put" path="/repo/{connection_id}/organization/{id}" example="repo_organization" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateRepoOrganizationRequest req = new UpdateRepoOrganizationRequest() {
    RepoOrganization = new RepoOrganization() {
        AvatarUrl = "https://picsum.photos/seed/fGl6Lb/3157/3173",
        CreatedAt = System.DateTime.Parse("2022-07-07T00:18:40.748Z").ToUniversalTime(),
        Description = "Trepide defendo supra testimonium ager.",
        Id = "9e3a01c3-1824-44f1-b5d3-55744e673e8a",
        Name = "Denesik - Lemke",
        UpdatedAt = System.DateTime.Parse("2023-08-12T23:35:02.195Z").ToUniversalTime(),
        WebUrl = "https://turbulent-overheard.biz",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Organization.UpdateRepoOrganizationAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [UpdateRepoOrganizationRequest](../../Models/Requests/UpdateRepoOrganizationRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[UpdateRepoOrganizationResponse](../../Models/Requests/UpdateRepoOrganizationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |