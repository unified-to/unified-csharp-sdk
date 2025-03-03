# Connection
(*Connection*)

## Overview

### Available Operations

* [CreateUnifiedConnection](#createunifiedconnection) - Create connection
* [GetUnifiedConnection](#getunifiedconnection) - Retrieve connection
* [ListUnifiedConnections](#listunifiedconnections) - List all connections
* [PatchUnifiedConnection](#patchunifiedconnection) - Update connection
* [RemoveUnifiedConnection](#removeunifiedconnection) - Remove connection
* [UpdateUnifiedConnection](#updateunifiedconnection) - Update connection

## CreateUnifiedConnection

Used only to import existing customer credentials; use "Create connection indirectly" instead

### Example Usage

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

Models.Components.Connection req = new Models.Components.Connection() {
    Categories = new List<PropertyConnectionCategories>() {
        PropertyConnectionCategories.Metadata,
    },
    IntegrationType = "<value>",
    Permissions = new List<PropertyConnectionPermissions>() {
        PropertyConnectionPermissions.MartechListRead,
    },
};

var res = await sdk.Connection.CreateUnifiedConnectionAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [Models.Components.Connection](../../Models/Components/Connection.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[CreateUnifiedConnectionResponse](../../Models/Requests/CreateUnifiedConnectionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetUnifiedConnection

Retrieve connection

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Connection.GetUnifiedConnectionAsync(id: "<id>");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Connection |

### Response

**[GetUnifiedConnectionResponse](../../Models/Requests/GetUnifiedConnectionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListUnifiedConnections

List all connections

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListUnifiedConnectionsRequest req = new ListUnifiedConnectionsRequest() {};

var res = await sdk.Connection.ListUnifiedConnectionsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [ListUnifiedConnectionsRequest](../../Models/Requests/ListUnifiedConnectionsRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[ListUnifiedConnectionsResponse](../../Models/Requests/ListUnifiedConnectionsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchUnifiedConnection

Update connection

### Example Usage

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Connection.PatchUnifiedConnectionAsync(
    connection: new Models.Components.Connection() {
        Categories = new List<PropertyConnectionCategories>() {
            PropertyConnectionCategories.Messaging,
        },
        IntegrationType = "<value>",
        Permissions = new List<PropertyConnectionPermissions>() {
            PropertyConnectionPermissions.CalendarRecordingWrite,
        },
    },
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `Connection`                                                          | [Models.Components.Connection](../../Models/Components/Connection.md) | :heavy_check_mark:                                                    | A connection represents a specific authentication of an integration.  |
| `Id`                                                                  | *string*                                                              | :heavy_check_mark:                                                    | ID of the Connection                                                  |

### Response

**[PatchUnifiedConnectionResponse](../../Models/Requests/PatchUnifiedConnectionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveUnifiedConnection

Remove connection

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Connection.RemoveUnifiedConnectionAsync(id: "<id>");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Connection |

### Response

**[RemoveUnifiedConnectionResponse](../../Models/Requests/RemoveUnifiedConnectionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateUnifiedConnection

Update connection

### Example Usage

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Connection.UpdateUnifiedConnectionAsync(
    connection: new Models.Components.Connection() {
        Categories = new List<PropertyConnectionCategories>() {
            PropertyConnectionCategories.Scim,
        },
        IntegrationType = "<value>",
        Permissions = new List<PropertyConnectionPermissions>() {
            PropertyConnectionPermissions.CalendarLinkWrite,
        },
    },
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `Connection`                                                          | [Models.Components.Connection](../../Models/Components/Connection.md) | :heavy_check_mark:                                                    | A connection represents a specific authentication of an integration.  |
| `Id`                                                                  | *string*                                                              | :heavy_check_mark:                                                    | ID of the Connection                                                  |

### Response

**[UpdateUnifiedConnectionResponse](../../Models/Requests/UpdateUnifiedConnectionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |