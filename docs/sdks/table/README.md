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
                Id = "86af5d8a-9bc3-4622-9043-06b22c492781",
                IsIndexed = true,
                IsUnique = true,
                Name = "Ferry LLC",
                OriginalType = "conservo",
                Scale = 64D,
                Type = DatastoreFieldType.SingleSelect,
            },
            new DatastoreField() {
                Description = "Nulla cattus aequus sumo neque alter cauda subseco.",
                Id = "66b24e18-9a99-486d-9fbd-274d31b73562",
                IsNullable = true,
                IsUnique = true,
                Name = "Hand - Nader",
                OriginalType = "conservo",
                Precision = 57D,
                Type = DatastoreFieldType.SingleSelect,
            },
            new DatastoreField() {
                Description = "Utilis callide adhuc verumtamen doloremque ceno sui sint.",
                Id = "922f5261-d74c-446a-9555-1717f5d48636",
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
                Id = "ac6d054e-98d1-4aa4-b4f2-bd7361e1da12",
                Name = "Gislason, Gorczany and Hegmann",
                OriginalType = "tego",
                Precision = 94D,
                Scale = 24D,
                Type = DatastoreFieldType.Relation,
            },
            new DatastoreField() {
                Description = "Communis coma cura audio aduro acer canis expedita.",
                Id = "d501909a-8d99-4b02-b41d-10d18d3bbb77",
                IsIndexed = true,
                IsPrimaryKey = true,
                IsRequired = true,
                Name = "Graham, Steuber and Kshlerin",
                OriginalType = "defessus",
                Scale = 68D,
                Type = DatastoreFieldType.Email,
            },
        },
        Id = "3336104a-126d-4ec6-be44-09a831682287",
        Metadata = new List<DatastoreMetadata>() {},
        Name = "Rogahn, Lowe and Heller",
        Relationships = new List<DatastoreRelationship>() {
            new DatastoreRelationship() {
                Field = "Macejkovic - Shields",
                Name = "Hyatt, Ryan and Nienow",
                TableId = "3336104a-126d-4ec6-be44-09a831682287",
                Type = DatastoreRelationshipType.Many,
            },
        },
        UpdatedAt = System.DateTime.Parse("2022-08-12T18:56:36.017Z").ToUniversalTime(),
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
                Id = "40ef74d0-98f8-4c9f-abf3-0ada79ba5cf4",
                IsIndexed = true,
                IsUnique = true,
                Name = "Ferry LLC",
                OriginalType = "conservo",
                Scale = 64D,
                Type = DatastoreFieldType.SingleSelect,
            },
            new DatastoreField() {
                Description = "Nulla cattus aequus sumo neque alter cauda subseco.",
                Id = "dd088321-9be6-407f-b487-f83b8e925429",
                IsNullable = true,
                IsUnique = true,
                Name = "Hand - Nader",
                OriginalType = "conservo",
                Precision = 57D,
                Type = DatastoreFieldType.SingleSelect,
            },
            new DatastoreField() {
                Description = "Utilis callide adhuc verumtamen doloremque ceno sui sint.",
                Id = "da2104b5-dbbf-4b58-81a5-616a98bdc52a",
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
                Id = "087ccdee-c730-49fd-ad11-413aee8a7f3a",
                Name = "Gislason, Gorczany and Hegmann",
                OriginalType = "tego",
                Precision = 94D,
                Scale = 24D,
                Type = DatastoreFieldType.Relation,
            },
            new DatastoreField() {
                Description = "Communis coma cura audio aduro acer canis expedita.",
                Id = "600da4d3-4370-460a-968f-a4e5989bd5d2",
                IsIndexed = true,
                IsPrimaryKey = true,
                IsRequired = true,
                Name = "Graham, Steuber and Kshlerin",
                OriginalType = "defessus",
                Scale = 68D,
                Type = DatastoreFieldType.Email,
            },
        },
        Id = "7e391883-2378-4fd8-956a-7d3e521b47ad",
        Metadata = new List<DatastoreMetadata>() {},
        Name = "Rogahn, Lowe and Heller",
        Relationships = new List<DatastoreRelationship>() {
            new DatastoreRelationship() {
                Field = "Macejkovic - Shields",
                Name = "Hyatt, Ryan and Nienow",
                TableId = "7e391883-2378-4fd8-956a-7d3e521b47ad",
                Type = DatastoreRelationshipType.Many,
            },
        },
        UpdatedAt = System.DateTime.Parse("2022-08-12T18:56:36.019Z").ToUniversalTime(),
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
                Id = "40ef74d0-98f8-4c9f-abf3-0ada79ba5cf4",
                IsIndexed = true,
                IsUnique = true,
                Name = "Ferry LLC",
                OriginalType = "conservo",
                Scale = 64D,
                Type = DatastoreFieldType.SingleSelect,
            },
            new DatastoreField() {
                Description = "Nulla cattus aequus sumo neque alter cauda subseco.",
                Id = "dd088321-9be6-407f-b487-f83b8e925429",
                IsNullable = true,
                IsUnique = true,
                Name = "Hand - Nader",
                OriginalType = "conservo",
                Precision = 57D,
                Type = DatastoreFieldType.SingleSelect,
            },
            new DatastoreField() {
                Description = "Utilis callide adhuc verumtamen doloremque ceno sui sint.",
                Id = "da2104b5-dbbf-4b58-81a5-616a98bdc52a",
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
                Id = "087ccdee-c730-49fd-ad11-413aee8a7f3a",
                Name = "Gislason, Gorczany and Hegmann",
                OriginalType = "tego",
                Precision = 94D,
                Scale = 24D,
                Type = DatastoreFieldType.Relation,
            },
            new DatastoreField() {
                Description = "Communis coma cura audio aduro acer canis expedita.",
                Id = "600da4d3-4370-460a-968f-a4e5989bd5d2",
                IsIndexed = true,
                IsPrimaryKey = true,
                IsRequired = true,
                Name = "Graham, Steuber and Kshlerin",
                OriginalType = "defessus",
                Scale = 68D,
                Type = DatastoreFieldType.Email,
            },
        },
        Id = "7e391883-2378-4fd8-956a-7d3e521b47ad",
        Metadata = new List<DatastoreMetadata>() {},
        Name = "Rogahn, Lowe and Heller",
        Relationships = new List<DatastoreRelationship>() {
            new DatastoreRelationship() {
                Field = "Macejkovic - Shields",
                Name = "Hyatt, Ryan and Nienow",
                TableId = "7e391883-2378-4fd8-956a-7d3e521b47ad",
                Type = DatastoreRelationshipType.Many,
            },
        },
        UpdatedAt = System.DateTime.Parse("2022-08-12T18:56:36.019Z").ToUniversalTime(),
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