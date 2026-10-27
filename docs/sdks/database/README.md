# Database

## Overview

### Available Operations

* [CreateDatastoreDatabase](#createdatastoredatabase) - Create a database
* [GetDatastoreDatabase](#getdatastoredatabase) - Retrieve a database
* [ListDatastoreDatabases](#listdatastoredatabases) - List all databases
* [PatchDatastoreDatabase](#patchdatastoredatabase) - Update a database
* [RemoveDatastoreDatabase](#removedatastoredatabase) - Remove a database
* [UpdateDatastoreDatabase](#updatedatastoredatabase) - Update a database

## CreateDatastoreDatabase

Creates a DatastoreDatabase. Provide the unified DatastoreDatabase fields in the request body; they are mapped to the provider's API. Returns the created DatastoreDatabase.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createDatastoreDatabase" method="post" path="/datastore/{connection_id}/database" example="datastore_database" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Database.CreateDatastoreDatabaseAsync(
    datastoreDatabase: new DatastoreDatabase() {
        CreatedAt = System.DateTime.Parse("2019-03-05T14:31:00.223Z").ToUniversalTime(),
        Description = "Substantia tantillus coniuratio repellat coerceo amet vito vorago.",
        Id = "fb3b34eb-9e4a-4299-a774-bd213c2cd1cc",
        IsActive = true,
        Metadata = new List<DatastoreMetadata>() {},
        Name = "Rau - O'Reilly",
        Password = "iYLhYwOHm0NLDvI",
        Region = "France",
        UpdatedAt = System.DateTime.Parse("2023-07-04T05:40:28.177Z").ToUniversalTime(),
        WebUrl = "https://optimal-signature.name",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `DatastoreDatabase`                                                                                                                              | [DatastoreDatabase](../../Models/Components/DatastoreDatabase.md)                                                                                | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateDatastoreDatabaseQueryParamFields](../../Models/Requests/CreateDatastoreDatabaseQueryParamFields.md)>                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateDatastoreDatabaseResponse](../../Models/Requests/CreateDatastoreDatabaseResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetDatastoreDatabase

Retrieves a single DatastoreDatabase by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getDatastoreDatabase" method="get" path="/datastore/{connection_id}/database/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Database.GetDatastoreDatabaseAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Database                                                                                                                               |
| `Fields`                                                                                                                                         | List<[GetDatastoreDatabaseQueryParamFields](../../Models/Requests/GetDatastoreDatabaseQueryParamFields.md)>                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetDatastoreDatabaseResponse](../../Models/Requests/GetDatastoreDatabaseResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListDatastoreDatabases

Returns a list of DatastoreDatabases. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listDatastoreDatabases" method="get" path="/datastore/{connection_id}/database" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListDatastoreDatabasesRequest req = new ListDatastoreDatabasesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Database.ListDatastoreDatabasesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [ListDatastoreDatabasesRequest](../../Models/Requests/ListDatastoreDatabasesRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[ListDatastoreDatabasesResponse](../../Models/Requests/ListDatastoreDatabasesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchDatastoreDatabase

Updates the DatastoreDatabase identified by `id`. Provide the unified DatastoreDatabase fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchDatastoreDatabase" method="patch" path="/datastore/{connection_id}/database/{id}" example="datastore_database" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchDatastoreDatabaseRequest req = new PatchDatastoreDatabaseRequest() {
    DatastoreDatabase = new DatastoreDatabase() {
        CreatedAt = System.DateTime.Parse("2019-03-05T14:31:00.223Z").ToUniversalTime(),
        Description = "Substantia tantillus coniuratio repellat coerceo amet vito vorago.",
        Id = "4bea23f2-928c-4969-8b4a-edbc0395e061",
        IsActive = true,
        Metadata = new List<DatastoreMetadata>() {},
        Name = "Rau - O'Reilly",
        Password = "iYLhYwOHm0NLDvI",
        Region = "France",
        UpdatedAt = System.DateTime.Parse("2023-07-04T05:40:28.188Z").ToUniversalTime(),
        WebUrl = "https://optimal-signature.name",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Database.PatchDatastoreDatabaseAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [PatchDatastoreDatabaseRequest](../../Models/Requests/PatchDatastoreDatabaseRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[PatchDatastoreDatabaseResponse](../../Models/Requests/PatchDatastoreDatabaseResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveDatastoreDatabase

Deletes the DatastoreDatabase identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeDatastoreDatabase" method="delete" path="/datastore/{connection_id}/database/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Database.RemoveDatastoreDatabaseAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Database   |

### Response

**[RemoveDatastoreDatabaseResponse](../../Models/Requests/RemoveDatastoreDatabaseResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateDatastoreDatabase

Updates the DatastoreDatabase identified by `id`. Provide the unified DatastoreDatabase fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateDatastoreDatabase" method="put" path="/datastore/{connection_id}/database/{id}" example="datastore_database" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateDatastoreDatabaseRequest req = new UpdateDatastoreDatabaseRequest() {
    DatastoreDatabase = new DatastoreDatabase() {
        CreatedAt = System.DateTime.Parse("2019-03-05T14:31:00.223Z").ToUniversalTime(),
        Description = "Substantia tantillus coniuratio repellat coerceo amet vito vorago.",
        Id = "4bea23f2-928c-4969-8b4a-edbc0395e061",
        IsActive = true,
        Metadata = new List<DatastoreMetadata>() {},
        Name = "Rau - O'Reilly",
        Password = "iYLhYwOHm0NLDvI",
        Region = "France",
        UpdatedAt = System.DateTime.Parse("2023-07-04T05:40:28.188Z").ToUniversalTime(),
        WebUrl = "https://optimal-signature.name",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Database.UpdateDatastoreDatabaseAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [UpdateDatastoreDatabaseRequest](../../Models/Requests/UpdateDatastoreDatabaseRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[UpdateDatastoreDatabaseResponse](../../Models/Requests/UpdateDatastoreDatabaseResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |