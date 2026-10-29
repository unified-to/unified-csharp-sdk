# Table

## Overview

### Available Operations

* [CreateDatastoreTable](#createdatastoretable) - Create a table
* [GetDatastoreTable](#getdatastoretable) - Retrieve a table
* [ListDatastoreTables](#listdatastoretables) - List all tables
* [PatchDatastoreTable](#patchdatastoretable) - Update a table
* [RemoveDatastoreTable](#removedatastoretable) - Remove a table
* [UpdateDatastoreTable](#updatedatastoretable) - Update a table

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

var res = await sdk.Table.CreateDatastoreTableAsync(
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

var res = await sdk.Table.GetDatastoreTableAsync(
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

var res = await sdk.Table.ListDatastoreTablesAsync(req);

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

var res = await sdk.Table.PatchDatastoreTableAsync(req);

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

var res = await sdk.Table.RemoveDatastoreTableAsync(
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

var res = await sdk.Table.UpdateDatastoreTableAsync(req);

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