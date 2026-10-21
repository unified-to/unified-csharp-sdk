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

Create a table

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
                Id = "9e681315-9da1-4a37-9988-12c56e57f8e0",
                IsIndexed = true,
                IsUnique = true,
                Name = "Ferry LLC",
                OriginalType = "conservo",
                Scale = 64D,
                Type = DatastoreFieldType.SingleSelect,
            },
            new DatastoreField() {
                Description = "Nulla cattus aequus sumo neque alter cauda subseco.",
                Id = "4e000c4b-c0e0-4fd8-b140-fc67c14d163c",
                IsNullable = true,
                IsUnique = true,
                Name = "Hand - Nader",
                OriginalType = "conservo",
                Precision = 57D,
                Type = DatastoreFieldType.SingleSelect,
            },
            new DatastoreField() {
                Description = "Utilis callide adhuc verumtamen doloremque ceno sui sint.",
                Id = "20586dcb-8adc-4bb8-859b-9f0b2dca5328",
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
                Id = "150617b5-17d9-4c7c-b287-7cd1b380a41f",
                Name = "Gislason, Gorczany and Hegmann",
                OriginalType = "tego",
                Precision = 94D,
                Scale = 24D,
                Type = DatastoreFieldType.Relation,
            },
            new DatastoreField() {
                Description = "Communis coma cura audio aduro acer canis expedita.",
                Id = "ea25f62d-b439-400f-aea7-8c45c7512f88",
                IsIndexed = true,
                IsPrimaryKey = true,
                IsRequired = true,
                Name = "Graham, Steuber and Kshlerin",
                OriginalType = "defessus",
                Scale = 68D,
                Type = DatastoreFieldType.Email,
            },
        },
        Id = "71a619db-8149-460f-b0d6-eb3368e10780",
        Metadata = new List<DatastoreMetadata>() {},
        Name = "Rogahn, Lowe and Heller",
        Relationships = new List<DatastoreRelationship>() {
            new DatastoreRelationship() {
                Field = "Macejkovic - Shields",
                Name = "Hyatt, Ryan and Nienow",
                TableId = "71a619db-8149-460f-b0d6-eb3368e10780",
                Type = DatastoreRelationshipType.Many,
            },
        },
        UpdatedAt = System.DateTime.Parse("2022-08-12T20:26:40.276Z").ToUniversalTime(),
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

Retrieve a table

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

List all tables

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

Update a table

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
                Id = "e7fec63c-a963-43d1-b665-d2c04fd00b71",
                IsIndexed = true,
                IsUnique = true,
                Name = "Ferry LLC",
                OriginalType = "conservo",
                Scale = 64D,
                Type = DatastoreFieldType.SingleSelect,
            },
            new DatastoreField() {
                Description = "Nulla cattus aequus sumo neque alter cauda subseco.",
                Id = "e34ed5ff-4a64-407d-86df-2acbe8418302",
                IsNullable = true,
                IsUnique = true,
                Name = "Hand - Nader",
                OriginalType = "conservo",
                Precision = 57D,
                Type = DatastoreFieldType.SingleSelect,
            },
            new DatastoreField() {
                Description = "Utilis callide adhuc verumtamen doloremque ceno sui sint.",
                Id = "5dd44e8c-c43f-4ce1-b678-e713ce4ed2be",
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
                Id = "720e768e-abd8-4de9-a0a6-e130ad46acbf",
                Name = "Gislason, Gorczany and Hegmann",
                OriginalType = "tego",
                Precision = 94D,
                Scale = 24D,
                Type = DatastoreFieldType.Relation,
            },
            new DatastoreField() {
                Description = "Communis coma cura audio aduro acer canis expedita.",
                Id = "9ff186e7-9367-4c88-bcc5-9714ee8faa6a",
                IsIndexed = true,
                IsPrimaryKey = true,
                IsRequired = true,
                Name = "Graham, Steuber and Kshlerin",
                OriginalType = "defessus",
                Scale = 68D,
                Type = DatastoreFieldType.Email,
            },
        },
        Id = "a1195e8b-4c5b-4ac7-b382-06759043a08b",
        Metadata = new List<DatastoreMetadata>() {},
        Name = "Rogahn, Lowe and Heller",
        Relationships = new List<DatastoreRelationship>() {
            new DatastoreRelationship() {
                Field = "Macejkovic - Shields",
                Name = "Hyatt, Ryan and Nienow",
                TableId = "a1195e8b-4c5b-4ac7-b382-06759043a08b",
                Type = DatastoreRelationshipType.Many,
            },
        },
        UpdatedAt = System.DateTime.Parse("2022-08-12T20:26:40.277Z").ToUniversalTime(),
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

Remove a table

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

Update a table

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
                Id = "e7fec63c-a963-43d1-b665-d2c04fd00b71",
                IsIndexed = true,
                IsUnique = true,
                Name = "Ferry LLC",
                OriginalType = "conservo",
                Scale = 64D,
                Type = DatastoreFieldType.SingleSelect,
            },
            new DatastoreField() {
                Description = "Nulla cattus aequus sumo neque alter cauda subseco.",
                Id = "e34ed5ff-4a64-407d-86df-2acbe8418302",
                IsNullable = true,
                IsUnique = true,
                Name = "Hand - Nader",
                OriginalType = "conservo",
                Precision = 57D,
                Type = DatastoreFieldType.SingleSelect,
            },
            new DatastoreField() {
                Description = "Utilis callide adhuc verumtamen doloremque ceno sui sint.",
                Id = "5dd44e8c-c43f-4ce1-b678-e713ce4ed2be",
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
                Id = "720e768e-abd8-4de9-a0a6-e130ad46acbf",
                Name = "Gislason, Gorczany and Hegmann",
                OriginalType = "tego",
                Precision = 94D,
                Scale = 24D,
                Type = DatastoreFieldType.Relation,
            },
            new DatastoreField() {
                Description = "Communis coma cura audio aduro acer canis expedita.",
                Id = "9ff186e7-9367-4c88-bcc5-9714ee8faa6a",
                IsIndexed = true,
                IsPrimaryKey = true,
                IsRequired = true,
                Name = "Graham, Steuber and Kshlerin",
                OriginalType = "defessus",
                Scale = 68D,
                Type = DatastoreFieldType.Email,
            },
        },
        Id = "a1195e8b-4c5b-4ac7-b382-06759043a08b",
        Metadata = new List<DatastoreMetadata>() {},
        Name = "Rogahn, Lowe and Heller",
        Relationships = new List<DatastoreRelationship>() {
            new DatastoreRelationship() {
                Field = "Macejkovic - Shields",
                Name = "Hyatt, Ryan and Nienow",
                TableId = "a1195e8b-4c5b-4ac7-b382-06759043a08b",
                Type = DatastoreRelationshipType.Many,
            },
        },
        UpdatedAt = System.DateTime.Parse("2022-08-12T20:26:40.277Z").ToUniversalTime(),
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