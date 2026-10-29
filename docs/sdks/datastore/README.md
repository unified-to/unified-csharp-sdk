# Datastore

## Overview

### Available Operations

* [CreateDatastoreDatabase](#createdatastoredatabase) - Create a database
* [CreateDatastoreQuery](#createdatastorequery) - Create a query
* [CreateDatastoreRecord](#createdatastorerecord) - Create a record
* [CreateDatastoreTable](#createdatastoretable) - Create a table
* [GetDatastoreDatabase](#getdatastoredatabase) - Retrieve a database
* [GetDatastoreRecord](#getdatastorerecord) - Retrieve a record
* [GetDatastoreTable](#getdatastoretable) - Retrieve a table
* [ListDatastoreDatabases](#listdatastoredatabases) - List all databases
* [ListDatastoreRecords](#listdatastorerecords) - List all records
* [ListDatastoreTables](#listdatastoretables) - List all tables
* [PatchDatastoreDatabase](#patchdatastoredatabase) - Update a database
* [PatchDatastoreRecord](#patchdatastorerecord) - Update a record
* [PatchDatastoreTable](#patchdatastoretable) - Update a table
* [RemoveDatastoreDatabase](#removedatastoredatabase) - Remove a database
* [RemoveDatastoreRecord](#removedatastorerecord) - Remove a record
* [RemoveDatastoreTable](#removedatastoretable) - Remove a table
* [UpdateDatastoreDatabase](#updatedatastoredatabase) - Update a database
* [UpdateDatastoreRecord](#updatedatastorerecord) - Update a record
* [UpdateDatastoreTable](#updatedatastoretable) - Update a table

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

var res = await sdk.Datastore.CreateDatastoreDatabaseAsync(
    datastoreDatabase: new DatastoreDatabase() {
        CreatedAt = System.DateTime.Parse("2019-03-05T14:31:00.223Z").ToUniversalTime(),
        Description = "Substantia tantillus coniuratio repellat coerceo amet vito vorago.",
        Id = "28620b4e-b554-49d2-900f-699f80df170b",
        IsActive = true,
        Metadata = new List<DatastoreMetadata>() {},
        Name = "Rau - O'Reilly",
        Password = "iYLhYwOHm0NLDvI",
        Region = "France",
        UpdatedAt = System.DateTime.Parse("2023-07-05T03:57:09.511Z").ToUniversalTime(),
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

## CreateDatastoreQuery

Creates a DatastoreQuery. Provide the unified DatastoreQuery fields in the request body; they are mapped to the provider's API. Returns the created DatastoreQuery.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createDatastoreQuery" method="post" path="/datastore/{connection_id}/query" example="datastore_query" -->
```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Datastore.CreateDatastoreQueryAsync(
    datastoreQuery: new DatastoreQuery() {
        Metadata = new List<DatastoreMetadata>() {},
        Query = new PropertyDatastoreQueryQuery() {
            Filter = new PropertyDatastoreQueryQueryFilter() {
                Type = PropertyDatastoreQueryQueryFilterType.Or,
            },
            Select = new List<string>() {
                "*",
            },
            Sql = "",
        },
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `DatastoreQuery`                                                                                                                                 | [DatastoreQuery](../../Models/Components/DatastoreQuery.md)                                                                                      | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateDatastoreQueryQueryParamFields](../../Models/Requests/CreateDatastoreQueryQueryParamFields.md)>                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateDatastoreQueryResponse](../../Models/Requests/CreateDatastoreQueryResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateDatastoreRecord

Creates a DatastoreRecord. Provide the unified DatastoreRecord fields in the request body; they are mapped to the provider's API. Returns the created DatastoreRecord.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createDatastoreRecord" method="post" path="/datastore/{connection_id}/record" example="datastore_record" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Datastore.CreateDatastoreRecordAsync(
    datastoreRecord: new DatastoreRecord() {
        CreatedAt = System.DateTime.Parse("2022-07-10T04:42:03.076Z").ToUniversalTime(),
        Fields = new Dictionary<string, DatastoreFieldValue>() {

        },
        Id = "40512bfb-a1a5-4019-b7d8-0cb0d317a51f",
        Metadata = new List<DatastoreMetadata>() {},
        RowNumber = 33D,
        UpdatedAt = System.DateTime.Parse("2025-03-09T21:05:45.822Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `DatastoreRecord`                                                                                                                                | [DatastoreRecord](../../Models/Components/DatastoreRecord.md)                                                                                    | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateDatastoreRecordQueryParamFields](../../Models/Requests/CreateDatastoreRecordQueryParamFields.md)>                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateDatastoreRecordResponse](../../Models/Requests/CreateDatastoreRecordResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateDatastoreTable

Creates a DatastoreTable. Provide the unified DatastoreTable fields in the request body; they are mapped to the provider's API. Returns the created DatastoreTable.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createDatastoreTable" method="post" path="/datastore/{connection_id}/table" example="datastore_table" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Datastore.CreateDatastoreTableAsync(
    datastoreTable: new DatastoreTable() {
        CreatedAt = System.DateTime.Parse("2022-05-22T04:49:00.762Z").ToUniversalTime(),
        Description = "Quasi adhuc paulatim ducimus carpo vomito magni tantum tubineus corona.",
        Fields = new List<DatastoreField>() {
            new DatastoreField() {
                Description = "Antea soluta itaque clamo despecto basium accendo.",
                Id = "7af63e36-97e5-49ce-95f9-cad41c41dfc4",
                IsIndexed = true,
                IsUnique = true,
                Name = "Ferry LLC",
                OriginalType = "conservo",
                Scale = 64D,
                Type = DatastoreFieldType.SingleSelect,
            },
            new DatastoreField() {
                Description = "Nulla cattus aequus sumo neque alter cauda subseco.",
                Id = "759598a5-cd56-46ad-be9c-bdb80ac66f00",
                IsNullable = true,
                IsUnique = true,
                Name = "Hand - Nader",
                OriginalType = "conservo",
                Precision = 57D,
                Type = DatastoreFieldType.SingleSelect,
            },
            new DatastoreField() {
                Description = "Utilis callide adhuc verumtamen doloremque ceno sui sint.",
                Id = "e0f864bd-863e-4b51-8231-4efcee34749b",
                IsIndexed = true,
                IsNullable = true,
                IsUnique = true,
                MaxLength = 62D,
                Name = "Toy - Kiehn",
                OriginalType = "sursum",
                Precision = 47D,
                Type = DatastoreFieldType.Number,
            },
            new DatastoreField() {
                Description = "Audax articulus triumphus tametsi cura tenetur colligo arcesso bestia.",
                Id = "2eabefed-e95d-4da5-aa7b-954f340f10e2",
                Name = "Gislason, Gorczany and Hegmann",
                OriginalType = "tego",
                Precision = 94D,
                Scale = 24D,
                Type = DatastoreFieldType.Relation,
            },
            new DatastoreField() {
                Description = "Communis coma cura audio aduro acer canis expedita.",
                Id = "6f478c9a-2abf-4bfa-ba59-b015af1bd52b",
                IsIndexed = true,
                IsPrimaryKey = true,
                IsRequired = true,
                Name = "Graham, Steuber and Kshlerin",
                OriginalType = "defessus",
                Scale = 68D,
                Type = DatastoreFieldType.Email,
            },
        },
        Id = "fc52183e-4b8b-43da-aec1-aac45ed7fc13",
        Metadata = new List<DatastoreMetadata>() {},
        Name = "Rogahn, Lowe and Heller",
        Relationships = new List<DatastoreRelationship>() {
            new DatastoreRelationship() {
                Field = "Macejkovic - Shields",
                Name = "Hyatt, Ryan and Nienow",
                TableId = "fc52183e-4b8b-43da-aec1-aac45ed7fc13",
                Type = DatastoreRelationshipType.Many,
            },
        },
        UpdatedAt = System.DateTime.Parse("2022-08-13T05:51:10.458Z").ToUniversalTime(),
        WebUrl = "https://nervous-deck.com",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `DatastoreTable`                                                                                                                                 | [DatastoreTable](../../Models/Components/DatastoreTable.md)                                                                                      | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateDatastoreTableQueryParamFields](../../Models/Requests/CreateDatastoreTableQueryParamFields.md)>                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateDatastoreTableResponse](../../Models/Requests/CreateDatastoreTableResponse.md)**

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

var res = await sdk.Datastore.GetDatastoreDatabaseAsync(
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

## GetDatastoreRecord

Retrieves a single DatastoreRecord by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getDatastoreRecord" method="get" path="/datastore/{connection_id}/record/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Datastore.GetDatastoreRecordAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Record                                                                                                                                 |
| `Fields`                                                                                                                                         | List<[GetDatastoreRecordQueryParamFields](../../Models/Requests/GetDatastoreRecordQueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetDatastoreRecordResponse](../../Models/Requests/GetDatastoreRecordResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetDatastoreTable

Retrieves a single DatastoreTable by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getDatastoreTable" method="get" path="/datastore/{connection_id}/table/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Datastore.GetDatastoreTableAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Table                                                                                                                                  |
| `Fields`                                                                                                                                         | List<[GetDatastoreTableQueryParamFields](../../Models/Requests/GetDatastoreTableQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetDatastoreTableResponse](../../Models/Requests/GetDatastoreTableResponse.md)**

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

var res = await sdk.Datastore.ListDatastoreDatabasesAsync(req);

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

## ListDatastoreRecords

Returns a list of DatastoreRecords. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listDatastoreRecords" method="get" path="/datastore/{connection_id}/record" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListDatastoreRecordsRequest req = new ListDatastoreRecordsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Datastore.ListDatastoreRecordsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [ListDatastoreRecordsRequest](../../Models/Requests/ListDatastoreRecordsRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[ListDatastoreRecordsResponse](../../Models/Requests/ListDatastoreRecordsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListDatastoreTables

Returns a list of DatastoreTables. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listDatastoreTables" method="get" path="/datastore/{connection_id}/table" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListDatastoreTablesRequest req = new ListDatastoreTablesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Datastore.ListDatastoreTablesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ListDatastoreTablesRequest](../../Models/Requests/ListDatastoreTablesRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[ListDatastoreTablesResponse](../../Models/Requests/ListDatastoreTablesResponse.md)**

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
        Id = "558bcd2c-195a-44e1-9f99-72fc15b09ea5",
        IsActive = true,
        Metadata = new List<DatastoreMetadata>() {},
        Name = "Rau - O'Reilly",
        Password = "iYLhYwOHm0NLDvI",
        Region = "France",
        UpdatedAt = System.DateTime.Parse("2023-07-05T03:57:09.519Z").ToUniversalTime(),
        WebUrl = "https://optimal-signature.name",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Datastore.PatchDatastoreDatabaseAsync(req);

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

## PatchDatastoreRecord

Updates the DatastoreRecord identified by `id`. Provide the unified DatastoreRecord fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchDatastoreRecord" method="patch" path="/datastore/{connection_id}/record/{id}" example="datastore_record" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchDatastoreRecordRequest req = new PatchDatastoreRecordRequest() {
    DatastoreRecord = new DatastoreRecord() {
        CreatedAt = System.DateTime.Parse("2022-07-10T04:42:03.076Z").ToUniversalTime(),
        Fields = new Dictionary<string, DatastoreFieldValue>() {

        },
        Id = "17d9b4d9-0ec4-47fd-a943-2caf51147698",
        Metadata = new List<DatastoreMetadata>() {},
        RowNumber = 33D,
        UpdatedAt = System.DateTime.Parse("2025-03-09T21:05:45.832Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Datastore.PatchDatastoreRecordAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [PatchDatastoreRecordRequest](../../Models/Requests/PatchDatastoreRecordRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[PatchDatastoreRecordResponse](../../Models/Requests/PatchDatastoreRecordResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchDatastoreTable

Updates the DatastoreTable identified by `id`. Provide the unified DatastoreTable fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchDatastoreTable" method="patch" path="/datastore/{connection_id}/table/{id}" example="datastore_table" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchDatastoreTableRequest req = new PatchDatastoreTableRequest() {
    DatastoreTable = new DatastoreTable() {
        CreatedAt = System.DateTime.Parse("2022-05-22T04:49:00.762Z").ToUniversalTime(),
        Description = "Quasi adhuc paulatim ducimus carpo vomito magni tantum tubineus corona.",
        Fields = new List<DatastoreField>() {
            new DatastoreField() {
                Description = "Antea soluta itaque clamo despecto basium accendo.",
                Id = "2d0d8cd7-67b6-4b37-99e5-ca1d46fb773d",
                IsIndexed = true,
                IsUnique = true,
                Name = "Ferry LLC",
                OriginalType = "conservo",
                Scale = 64D,
                Type = DatastoreFieldType.SingleSelect,
            },
            new DatastoreField() {
                Description = "Nulla cattus aequus sumo neque alter cauda subseco.",
                Id = "39288ca3-bc2b-4a95-8cc9-30fba2207c46",
                IsNullable = true,
                IsUnique = true,
                Name = "Hand - Nader",
                OriginalType = "conservo",
                Precision = 57D,
                Type = DatastoreFieldType.SingleSelect,
            },
            new DatastoreField() {
                Description = "Utilis callide adhuc verumtamen doloremque ceno sui sint.",
                Id = "4283ef2e-2109-483e-a6b6-f92920b2610f",
                IsIndexed = true,
                IsNullable = true,
                IsUnique = true,
                MaxLength = 62D,
                Name = "Toy - Kiehn",
                OriginalType = "sursum",
                Precision = 47D,
                Type = DatastoreFieldType.Number,
            },
            new DatastoreField() {
                Description = "Audax articulus triumphus tametsi cura tenetur colligo arcesso bestia.",
                Id = "858ee55d-cc04-4813-a2ec-7b18d298a720",
                Name = "Gislason, Gorczany and Hegmann",
                OriginalType = "tego",
                Precision = 94D,
                Scale = 24D,
                Type = DatastoreFieldType.Relation,
            },
            new DatastoreField() {
                Description = "Communis coma cura audio aduro acer canis expedita.",
                Id = "25f05289-8522-457c-b967-26a180d51fd2",
                IsIndexed = true,
                IsPrimaryKey = true,
                IsRequired = true,
                Name = "Graham, Steuber and Kshlerin",
                OriginalType = "defessus",
                Scale = 68D,
                Type = DatastoreFieldType.Email,
            },
        },
        Id = "a3ed0b49-d7d5-46f1-bc7b-d4acb41958f7",
        Metadata = new List<DatastoreMetadata>() {},
        Name = "Rogahn, Lowe and Heller",
        Relationships = new List<DatastoreRelationship>() {
            new DatastoreRelationship() {
                Field = "Macejkovic - Shields",
                Name = "Hyatt, Ryan and Nienow",
                TableId = "a3ed0b49-d7d5-46f1-bc7b-d4acb41958f7",
                Type = DatastoreRelationshipType.Many,
            },
        },
        UpdatedAt = System.DateTime.Parse("2022-08-13T05:51:10.460Z").ToUniversalTime(),
        WebUrl = "https://nervous-deck.com",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Datastore.PatchDatastoreTableAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [PatchDatastoreTableRequest](../../Models/Requests/PatchDatastoreTableRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[PatchDatastoreTableResponse](../../Models/Requests/PatchDatastoreTableResponse.md)**

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

var res = await sdk.Datastore.RemoveDatastoreDatabaseAsync(
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

## RemoveDatastoreRecord

Deletes the DatastoreRecord identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeDatastoreRecord" method="delete" path="/datastore/{connection_id}/record/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Datastore.RemoveDatastoreRecordAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Record     |

### Response

**[RemoveDatastoreRecordResponse](../../Models/Requests/RemoveDatastoreRecordResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveDatastoreTable

Deletes the DatastoreTable identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeDatastoreTable" method="delete" path="/datastore/{connection_id}/table/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Datastore.RemoveDatastoreTableAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Table      |

### Response

**[RemoveDatastoreTableResponse](../../Models/Requests/RemoveDatastoreTableResponse.md)**

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
        Id = "558bcd2c-195a-44e1-9f99-72fc15b09ea5",
        IsActive = true,
        Metadata = new List<DatastoreMetadata>() {},
        Name = "Rau - O'Reilly",
        Password = "iYLhYwOHm0NLDvI",
        Region = "France",
        UpdatedAt = System.DateTime.Parse("2023-07-05T03:57:09.519Z").ToUniversalTime(),
        WebUrl = "https://optimal-signature.name",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Datastore.UpdateDatastoreDatabaseAsync(req);

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

## UpdateDatastoreRecord

Updates the DatastoreRecord identified by `id`. Provide the unified DatastoreRecord fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateDatastoreRecord" method="put" path="/datastore/{connection_id}/record/{id}" example="datastore_record" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateDatastoreRecordRequest req = new UpdateDatastoreRecordRequest() {
    DatastoreRecord = new DatastoreRecord() {
        CreatedAt = System.DateTime.Parse("2022-07-10T04:42:03.076Z").ToUniversalTime(),
        Fields = new Dictionary<string, DatastoreFieldValue>() {

        },
        Id = "17d9b4d9-0ec4-47fd-a943-2caf51147698",
        Metadata = new List<DatastoreMetadata>() {},
        RowNumber = 33D,
        UpdatedAt = System.DateTime.Parse("2025-03-09T21:05:45.832Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Datastore.UpdateDatastoreRecordAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [UpdateDatastoreRecordRequest](../../Models/Requests/UpdateDatastoreRecordRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[UpdateDatastoreRecordResponse](../../Models/Requests/UpdateDatastoreRecordResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateDatastoreTable

Updates the DatastoreTable identified by `id`. Provide the unified DatastoreTable fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateDatastoreTable" method="put" path="/datastore/{connection_id}/table/{id}" example="datastore_table" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateDatastoreTableRequest req = new UpdateDatastoreTableRequest() {
    DatastoreTable = new DatastoreTable() {
        CreatedAt = System.DateTime.Parse("2022-05-22T04:49:00.762Z").ToUniversalTime(),
        Description = "Quasi adhuc paulatim ducimus carpo vomito magni tantum tubineus corona.",
        Fields = new List<DatastoreField>() {
            new DatastoreField() {
                Description = "Antea soluta itaque clamo despecto basium accendo.",
                Id = "2d0d8cd7-67b6-4b37-99e5-ca1d46fb773d",
                IsIndexed = true,
                IsUnique = true,
                Name = "Ferry LLC",
                OriginalType = "conservo",
                Scale = 64D,
                Type = DatastoreFieldType.SingleSelect,
            },
            new DatastoreField() {
                Description = "Nulla cattus aequus sumo neque alter cauda subseco.",
                Id = "39288ca3-bc2b-4a95-8cc9-30fba2207c46",
                IsNullable = true,
                IsUnique = true,
                Name = "Hand - Nader",
                OriginalType = "conservo",
                Precision = 57D,
                Type = DatastoreFieldType.SingleSelect,
            },
            new DatastoreField() {
                Description = "Utilis callide adhuc verumtamen doloremque ceno sui sint.",
                Id = "4283ef2e-2109-483e-a6b6-f92920b2610f",
                IsIndexed = true,
                IsNullable = true,
                IsUnique = true,
                MaxLength = 62D,
                Name = "Toy - Kiehn",
                OriginalType = "sursum",
                Precision = 47D,
                Type = DatastoreFieldType.Number,
            },
            new DatastoreField() {
                Description = "Audax articulus triumphus tametsi cura tenetur colligo arcesso bestia.",
                Id = "858ee55d-cc04-4813-a2ec-7b18d298a720",
                Name = "Gislason, Gorczany and Hegmann",
                OriginalType = "tego",
                Precision = 94D,
                Scale = 24D,
                Type = DatastoreFieldType.Relation,
            },
            new DatastoreField() {
                Description = "Communis coma cura audio aduro acer canis expedita.",
                Id = "25f05289-8522-457c-b967-26a180d51fd2",
                IsIndexed = true,
                IsPrimaryKey = true,
                IsRequired = true,
                Name = "Graham, Steuber and Kshlerin",
                OriginalType = "defessus",
                Scale = 68D,
                Type = DatastoreFieldType.Email,
            },
        },
        Id = "a3ed0b49-d7d5-46f1-bc7b-d4acb41958f7",
        Metadata = new List<DatastoreMetadata>() {},
        Name = "Rogahn, Lowe and Heller",
        Relationships = new List<DatastoreRelationship>() {
            new DatastoreRelationship() {
                Field = "Macejkovic - Shields",
                Name = "Hyatt, Ryan and Nienow",
                TableId = "a3ed0b49-d7d5-46f1-bc7b-d4acb41958f7",
                Type = DatastoreRelationshipType.Many,
            },
        },
        UpdatedAt = System.DateTime.Parse("2022-08-13T05:51:10.460Z").ToUniversalTime(),
        WebUrl = "https://nervous-deck.com",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Datastore.UpdateDatastoreTableAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [UpdateDatastoreTableRequest](../../Models/Requests/UpdateDatastoreTableRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[UpdateDatastoreTableResponse](../../Models/Requests/UpdateDatastoreTableResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |