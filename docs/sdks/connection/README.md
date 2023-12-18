# Connection
(*Connection*)

### Available Operations

* [CreateUnifiedConnection](#createunifiedconnection) - Create connection
* [GetUnifiedConnection](#getunifiedconnection) - Retrieve connection
* [ListUnifiedConnections](#listunifiedconnections) - List all connections
* [PatchUnifiedConnection](#patchunifiedconnection) - Update connection
* [RemoveUnifiedConnection](#removeunifiedconnection) - Remove connection
* [UpdateUnifiedConnection](#updateunifiedconnection) - Update connection

## CreateUnifiedConnection

Create connection

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

Models.Components.Connection req = new Models.Components.Connection() {
    Auth = new PropertyConnectionAuth() {
        Emails = new List<string>() {
            "string",
        },
        Meta = new PropertyPropertyConnectionAuthMeta() {},
        OtherAuthInfo = new List<string>() {
            "string",
        },
    },
    Categories = new List<PropertyConnectionCategories>() {
        PropertyConnectionCategories.Accounting,
    },
    CursorsCache = new List<Undefined>() {
        new Undefined() {},
    },
    IntegrationType = "string",
    Permissions = new List<PropertyConnectionPermissions>() {
        PropertyConnectionPermissions.AtsJobWrite,
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


## GetUnifiedConnection

Retrieve connection

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Connection.GetUnifiedConnectionAsync(Id: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Connection |


### Response

**[GetUnifiedConnectionResponse](../../Models/Requests/GetUnifiedConnectionResponse.md)**


## ListUnifiedConnections

List all connections

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListUnifiedConnectionsRequest req = new ListUnifiedConnectionsRequest() {
    Categories = new List<Categories>() {
        Categories.Enrich,
    },
};

var res = await sdk.Connection.ListUnifiedConnectionsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [ListUnifiedConnectionsRequest](../../Models/Requests/ListUnifiedConnectionsRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |


### Response

**[ListUnifiedConnectionsResponse](../../Models/Requests/ListUnifiedConnectionsResponse.md)**


## PatchUnifiedConnection

Update connection

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Connection.PatchUnifiedConnectionAsync(Id: "string", Connection: new Models.Components.Connection() {
    Auth = new PropertyConnectionAuth() {
        Emails = new List<string>() {
            "string",
        },
        Meta = new PropertyPropertyConnectionAuthMeta() {},
        OtherAuthInfo = new List<string>() {
            "string",
        },
    },
    Categories = new List<PropertyConnectionCategories>() {
        PropertyConnectionCategories.Martech,
    },
    CursorsCache = new List<Undefined>() {
        new Undefined() {},
    },
    IntegrationType = "string",
    Permissions = new List<PropertyConnectionPermissions>() {
        PropertyConnectionPermissions.CrmPipelineWrite,
    },
});

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `Id`                                                                  | *string*                                                              | :heavy_check_mark:                                                    | ID of the Connection                                                  |
| `Connection`                                                          | [Models.Components.Connection](../../Models/Components/Connection.md) | :heavy_minus_sign:                                                    | A connection represents a specific authentication of an integration.  |


### Response

**[PatchUnifiedConnectionResponse](../../Models/Requests/PatchUnifiedConnectionResponse.md)**


## RemoveUnifiedConnection

Remove connection

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Connection.RemoveUnifiedConnectionAsync(Id: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Connection |


### Response

**[RemoveUnifiedConnectionResponse](../../Models/Requests/RemoveUnifiedConnectionResponse.md)**


## UpdateUnifiedConnection

Update connection

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Connection.UpdateUnifiedConnectionAsync(Id: "string", Connection: new Models.Components.Connection() {
    Auth = new PropertyConnectionAuth() {
        Emails = new List<string>() {
            "string",
        },
        Meta = new PropertyPropertyConnectionAuthMeta() {},
        OtherAuthInfo = new List<string>() {
            "string",
        },
    },
    Categories = new List<PropertyConnectionCategories>() {
        PropertyConnectionCategories.Ticketing,
    },
    CursorsCache = new List<Undefined>() {
        new Undefined() {},
    },
    IntegrationType = "string",
    Permissions = new List<PropertyConnectionPermissions>() {
        PropertyConnectionPermissions.CrmContactRead,
    },
});

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `Id`                                                                  | *string*                                                              | :heavy_check_mark:                                                    | ID of the Connection                                                  |
| `Connection`                                                          | [Models.Components.Connection](../../Models/Components/Connection.md) | :heavy_minus_sign:                                                    | A connection represents a specific authentication of an integration.  |


### Response

**[UpdateUnifiedConnectionResponse](../../Models/Requests/UpdateUnifiedConnectionResponse.md)**

