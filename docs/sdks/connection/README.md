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
using UnifiedTo;
using UnifiedTo.Models.Components;
using System.Collections.Generic;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

Models.Components.Connection req = new Models.Components.Connection() {
    Categories = new List<PropertyConnectionCategories>() {
        PropertyConnectionCategories.Commerce,
    },
    IntegrationType = "<value>",
    Permissions = new List<PropertyConnectionPermissions>() {
        PropertyConnectionPermissions.AtsCandidateRead,
    },
};

var res = await sdk.Connection.CreateUnifiedConnectionAsync(
    security: new CreateUnifiedConnectionSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                             | [Models.Components.Connection](../../Models/Components/Connection.md)                                                 | :heavy_check_mark:                                                                                                    | The request object to use for the request.                                                                            |
| `security`                                                                                                            | [UnifiedTo.Models.Requests.CreateUnifiedConnectionSecurity](../../Models/Requests/CreateUnifiedConnectionSecurity.md) | :heavy_check_mark:                                                                                                    | The security requirements to use for the request.                                                                     |


### Response

**[CreateUnifiedConnectionResponse](../../Models/Requests/CreateUnifiedConnectionResponse.md)**


## GetUnifiedConnection

Retrieve connection

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Connection.GetUnifiedConnectionAsync(
    security: new GetUnifiedConnectionSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                                       | Type                                                                                                            | Required                                                                                                        | Description                                                                                                     |
| --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                      | [UnifiedTo.Models.Requests.GetUnifiedConnectionSecurity](../../Models/Requests/GetUnifiedConnectionSecurity.md) | :heavy_check_mark:                                                                                              | The security requirements to use for the request.                                                               |
| `Id`                                                                                                            | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the Connection                                                                                            |


### Response

**[GetUnifiedConnectionResponse](../../Models/Requests/GetUnifiedConnectionResponse.md)**


## ListUnifiedConnections

List all connections

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListUnifiedConnectionsRequest req = new ListUnifiedConnectionsRequest() {};

var res = await sdk.Connection.ListUnifiedConnectionsAsync(
    security: new ListUnifiedConnectionsSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                                           | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                           | [ListUnifiedConnectionsRequest](../../Models/Requests/ListUnifiedConnectionsRequest.md)                             | :heavy_check_mark:                                                                                                  | The request object to use for the request.                                                                          |
| `security`                                                                                                          | [UnifiedTo.Models.Requests.ListUnifiedConnectionsSecurity](../../Models/Requests/ListUnifiedConnectionsSecurity.md) | :heavy_check_mark:                                                                                                  | The security requirements to use for the request.                                                                   |


### Response

**[ListUnifiedConnectionsResponse](../../Models/Requests/ListUnifiedConnectionsResponse.md)**


## PatchUnifiedConnection

Update connection

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Connection.PatchUnifiedConnectionAsync(
    security: new PatchUnifiedConnectionSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    id: "<value>",
    connection: new Models.Components.Connection() {
    Categories = new List<PropertyConnectionCategories>() {
        PropertyConnectionCategories.Ticketing,
    },
    IntegrationType = "<value>",
    Permissions = new List<PropertyConnectionPermissions>() {
        PropertyConnectionPermissions.CrmLeadWrite,
    },
});

// handle response
```

### Parameters

| Parameter                                                                                                           | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                          | [UnifiedTo.Models.Requests.PatchUnifiedConnectionSecurity](../../Models/Requests/PatchUnifiedConnectionSecurity.md) | :heavy_check_mark:                                                                                                  | The security requirements to use for the request.                                                                   |
| `Id`                                                                                                                | *string*                                                                                                            | :heavy_check_mark:                                                                                                  | ID of the Connection                                                                                                |
| `Connection`                                                                                                        | [Models.Components.Connection](../../Models/Components/Connection.md)                                               | :heavy_minus_sign:                                                                                                  | A connection represents a specific authentication of an integration.                                                |


### Response

**[PatchUnifiedConnectionResponse](../../Models/Requests/PatchUnifiedConnectionResponse.md)**


## RemoveUnifiedConnection

Remove connection

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Connection.RemoveUnifiedConnectionAsync(
    security: new RemoveUnifiedConnectionSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                            | [UnifiedTo.Models.Requests.RemoveUnifiedConnectionSecurity](../../Models/Requests/RemoveUnifiedConnectionSecurity.md) | :heavy_check_mark:                                                                                                    | The security requirements to use for the request.                                                                     |
| `Id`                                                                                                                  | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the Connection                                                                                                  |


### Response

**[RemoveUnifiedConnectionResponse](../../Models/Requests/RemoveUnifiedConnectionResponse.md)**


## UpdateUnifiedConnection

Update connection

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Connection.UpdateUnifiedConnectionAsync(
    security: new UpdateUnifiedConnectionSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    id: "<value>",
    connection: new Models.Components.Connection() {
    Categories = new List<PropertyConnectionCategories>() {
        PropertyConnectionCategories.Accounting,
    },
    IntegrationType = "<value>",
    Permissions = new List<PropertyConnectionPermissions>() {
        PropertyConnectionPermissions.AtsCompanyRead,
    },
});

// handle response
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                            | [UnifiedTo.Models.Requests.UpdateUnifiedConnectionSecurity](../../Models/Requests/UpdateUnifiedConnectionSecurity.md) | :heavy_check_mark:                                                                                                    | The security requirements to use for the request.                                                                     |
| `Id`                                                                                                                  | *string*                                                                                                              | :heavy_check_mark:                                                                                                    | ID of the Connection                                                                                                  |
| `Connection`                                                                                                          | [Models.Components.Connection](../../Models/Components/Connection.md)                                                 | :heavy_minus_sign:                                                                                                    | A connection represents a specific authentication of an integration.                                                  |


### Response

**[UpdateUnifiedConnectionResponse](../../Models/Requests/UpdateUnifiedConnectionResponse.md)**

