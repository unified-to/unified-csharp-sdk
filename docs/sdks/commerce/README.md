# Commerce
(*Commerce*)

### Available Operations

* [CreateCommerceCollection](#createcommercecollection) - Create a collection
* [CreateCommerceInventory](#createcommerceinventory) - Create an inventory
* [CreateCommerceItem](#createcommerceitem) - Create an item/product
* [CreateCommerceLocation](#createcommercelocation) - Create a location
* [GetCommerceCollection](#getcommercecollection) - Retrieve a collection
* [GetCommerceInventory](#getcommerceinventory) - Retrieve an inventory
* [GetCommerceItem](#getcommerceitem) - Retrieve an item/product
* [GetCommerceLocation](#getcommercelocation) - Retrieve a location
* [ListCommerceCollections](#listcommercecollections) - List all collections
* [ListCommerceInventories](#listcommerceinventories) - List all inventories
* [ListCommerceItems](#listcommerceitems) - List all items/products
* [ListCommerceLocations](#listcommercelocations) - List all locations
* [PatchCommerceCollection](#patchcommercecollection) - Update a collection
* [PatchCommerceInventory](#patchcommerceinventory) - Update an inventory
* [PatchCommerceItem](#patchcommerceitem) - Update an item/product
* [PatchCommerceLocation](#patchcommercelocation) - Update a location
* [RemoveCommerceCollection](#removecommercecollection) - Remove a collection
* [RemoveCommerceInventory](#removecommerceinventory) - Remove an inventory
* [RemoveCommerceItem](#removecommerceitem) - Remove an item/product
* [RemoveCommerceLocation](#removecommercelocation) - Remove a location
* [UpdateCommerceCollection](#updatecommercecollection) - Update a collection
* [UpdateCommerceInventory](#updatecommerceinventory) - Update an inventory
* [UpdateCommerceItem](#updatecommerceitem) - Update an item/product
* [UpdateCommerceLocation](#updatecommercelocation) - Update a location

## CreateCommerceCollection

Create a collection

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Commerce.CreateCommerceCollectionAsync(
    connectionId: "string",
    commerceCollection: new CommerceCollection() {
    Id = "<ID>",
    ItemIds = new List<string>() {
        "string",
    },
    Media = new List<CommerceItemMedia>() {
        new CommerceItemMedia() {
            Url = "http://uneven-mattress.name",
        },
    },
    Name = "string",
    Raw = new Dictionary<string, object>() {
        { "key", "string" },
    },
    Tags = new List<string>() {
        "string",
    },
});

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ConnectionId`                                                      | *string*                                                            | :heavy_check_mark:                                                  | ID of the connection                                                |
| `CommerceCollection`                                                | [CommerceCollection](../../Models/Components/CommerceCollection.md) | :heavy_minus_sign:                                                  | A collection of items/products/services                             |


### Response

**[CreateCommerceCollectionResponse](../../Models/Requests/CreateCommerceCollectionResponse.md)**


## CreateCommerceInventory

Create an inventory

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Commerce.CreateCommerceInventoryAsync(
    connectionId: "string",
    commerceInventory: new CommerceInventory() {
    Available = 5165.08D,
    Raw = new Dictionary<string, object>() {
        { "key", "string" },
    },
});

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `ConnectionId`                                                    | *string*                                                          | :heavy_check_mark:                                                | ID of the connection                                              |
| `CommerceInventory`                                               | [CommerceInventory](../../Models/Components/CommerceInventory.md) | :heavy_minus_sign:                                                | N/A                                                               |


### Response

**[CreateCommerceInventoryResponse](../../Models/Requests/CreateCommerceInventoryResponse.md)**


## CreateCommerceItem

Create an item/product

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Commerce.CreateCommerceItemAsync(
    connectionId: "string",
    commerceItem: new CommerceItem() {
    Media = new List<CommerceItemMedia>() {
        new CommerceItemMedia() {
            Url = "http://loud-minister.name",
        },
    },
    Name = "string",
    Raw = new Dictionary<string, object>() {
        { "key", "string" },
    },
    Tags = new List<string>() {
        "string",
    },
    Variants = new List<CommerceItemVariant>() {
        new CommerceItemVariant() {
            Media = new List<CommerceItemMedia>() {
                new CommerceItemMedia() {
                    Url = "http://other-external.info",
                },
            },
            Name = "string",
            Options = new List<CommerceItemOption>() {
                new CommerceItemOption() {
                    Id = "<ID>",
                    Name = "string",
                    Values = new List<string>() {
                        "string",
                    },
                },
            },
            Prices = new List<CommerceItemPrice>() {
                new CommerceItemPrice() {
                    Price = 3330.74D,
                },
            },
            Tags = new List<string>() {
                "string",
            },
        },
    },
});

// handle response
```

### Parameters

| Parameter                                               | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `ConnectionId`                                          | *string*                                                | :heavy_check_mark:                                      | ID of the connection                                    |
| `CommerceItem`                                          | [CommerceItem](../../Models/Components/CommerceItem.md) | :heavy_minus_sign:                                      | N/A                                                     |


### Response

**[CreateCommerceItemResponse](../../Models/Requests/CreateCommerceItemResponse.md)**


## CreateCommerceLocation

Create a location

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Commerce.CreateCommerceLocationAsync(
    connectionId: "string",
    commerceLocation: new CommerceLocation() {
    Address = new PropertyCommerceLocationAddress() {},
    Name = "string",
    Raw = new Dictionary<string, object>() {
        { "key", "string" },
    },
});

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `ConnectionId`                                                  | *string*                                                        | :heavy_check_mark:                                              | ID of the connection                                            |
| `CommerceLocation`                                              | [CommerceLocation](../../Models/Components/CommerceLocation.md) | :heavy_minus_sign:                                              | N/A                                                             |


### Response

**[CreateCommerceLocationResponse](../../Models/Requests/CreateCommerceLocationResponse.md)**


## GetCommerceCollection

Retrieve a collection

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Commerce.GetCommerceCollectionAsync(
    connectionId: "string",
    id: "string",
    fields: new List<string>() {
    "string",
});

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Collection             |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetCommerceCollectionResponse](../../Models/Requests/GetCommerceCollectionResponse.md)**


## GetCommerceInventory

Retrieve an inventory

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Commerce.GetCommerceInventoryAsync(
    connectionId: "string",
    id: "string",
    fields: new List<string>() {
    "string",
});

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Inventory              |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetCommerceInventoryResponse](../../Models/Requests/GetCommerceInventoryResponse.md)**


## GetCommerceItem

Retrieve an item/product

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Commerce.GetCommerceItemAsync(
    connectionId: "string",
    id: "string",
    fields: new List<string>() {
    "string",
});

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Item                   |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetCommerceItemResponse](../../Models/Requests/GetCommerceItemResponse.md)**


## GetCommerceLocation

Retrieve a location

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Commerce.GetCommerceLocationAsync(
    connectionId: "string",
    id: "string",
    fields: new List<string>() {
    "string",
});

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Location               |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetCommerceLocationResponse](../../Models/Requests/GetCommerceLocationResponse.md)**


## ListCommerceCollections

List all collections

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListCommerceCollectionsRequest req = new ListCommerceCollectionsRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
};

var res = await sdk.Commerce.ListCommerceCollectionsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [ListCommerceCollectionsRequest](../../Models/Requests/ListCommerceCollectionsRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |


### Response

**[ListCommerceCollectionsResponse](../../Models/Requests/ListCommerceCollectionsResponse.md)**


## ListCommerceInventories

List all inventories

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListCommerceInventoriesRequest req = new ListCommerceInventoriesRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
};

var res = await sdk.Commerce.ListCommerceInventoriesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [ListCommerceInventoriesRequest](../../Models/Requests/ListCommerceInventoriesRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |


### Response

**[ListCommerceInventoriesResponse](../../Models/Requests/ListCommerceInventoriesResponse.md)**


## ListCommerceItems

List all items/products

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListCommerceItemsRequest req = new ListCommerceItemsRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
};

var res = await sdk.Commerce.ListCommerceItemsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListCommerceItemsRequest](../../Models/Requests/ListCommerceItemsRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |


### Response

**[ListCommerceItemsResponse](../../Models/Requests/ListCommerceItemsResponse.md)**


## ListCommerceLocations

List all locations

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListCommerceLocationsRequest req = new ListCommerceLocationsRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
};

var res = await sdk.Commerce.ListCommerceLocationsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [ListCommerceLocationsRequest](../../Models/Requests/ListCommerceLocationsRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |


### Response

**[ListCommerceLocationsResponse](../../Models/Requests/ListCommerceLocationsResponse.md)**


## PatchCommerceCollection

Update a collection

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Commerce.PatchCommerceCollectionAsync(
    connectionId: "string",
    id: "string",
    commerceCollection: new CommerceCollection() {
    Id = "<ID>",
    ItemIds = new List<string>() {
        "string",
    },
    Media = new List<CommerceItemMedia>() {
        new CommerceItemMedia() {
            Url = "http://personal-sorrow.com",
        },
    },
    Name = "string",
    Raw = new Dictionary<string, object>() {
        { "key", "string" },
    },
    Tags = new List<string>() {
        "string",
    },
});

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ConnectionId`                                                      | *string*                                                            | :heavy_check_mark:                                                  | ID of the connection                                                |
| `Id`                                                                | *string*                                                            | :heavy_check_mark:                                                  | ID of the Collection                                                |
| `CommerceCollection`                                                | [CommerceCollection](../../Models/Components/CommerceCollection.md) | :heavy_minus_sign:                                                  | A collection of items/products/services                             |


### Response

**[PatchCommerceCollectionResponse](../../Models/Requests/PatchCommerceCollectionResponse.md)**


## PatchCommerceInventory

Update an inventory

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Commerce.PatchCommerceInventoryAsync(
    connectionId: "string",
    id: "string",
    commerceInventory: new CommerceInventory() {
    Available = 615.23D,
    Raw = new Dictionary<string, object>() {
        { "key", "string" },
    },
});

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `ConnectionId`                                                    | *string*                                                          | :heavy_check_mark:                                                | ID of the connection                                              |
| `Id`                                                              | *string*                                                          | :heavy_check_mark:                                                | ID of the Inventory                                               |
| `CommerceInventory`                                               | [CommerceInventory](../../Models/Components/CommerceInventory.md) | :heavy_minus_sign:                                                | N/A                                                               |


### Response

**[PatchCommerceInventoryResponse](../../Models/Requests/PatchCommerceInventoryResponse.md)**


## PatchCommerceItem

Update an item/product

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Commerce.PatchCommerceItemAsync(
    connectionId: "string",
    id: "string",
    commerceItem: new CommerceItem() {
    Media = new List<CommerceItemMedia>() {
        new CommerceItemMedia() {
            Url = "http://frank-galley.biz",
        },
    },
    Name = "string",
    Raw = new Dictionary<string, object>() {
        { "key", "string" },
    },
    Tags = new List<string>() {
        "string",
    },
    Variants = new List<CommerceItemVariant>() {
        new CommerceItemVariant() {
            Media = new List<CommerceItemMedia>() {
                new CommerceItemMedia() {
                    Url = "http://irresponsible-reason.biz",
                },
            },
            Name = "string",
            Options = new List<CommerceItemOption>() {
                new CommerceItemOption() {
                    Id = "<ID>",
                    Name = "string",
                    Values = new List<string>() {
                        "string",
                    },
                },
            },
            Prices = new List<CommerceItemPrice>() {
                new CommerceItemPrice() {
                    Price = 4506.62D,
                },
            },
            Tags = new List<string>() {
                "string",
            },
        },
    },
});

// handle response
```

### Parameters

| Parameter                                               | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `ConnectionId`                                          | *string*                                                | :heavy_check_mark:                                      | ID of the connection                                    |
| `Id`                                                    | *string*                                                | :heavy_check_mark:                                      | ID of the Item                                          |
| `CommerceItem`                                          | [CommerceItem](../../Models/Components/CommerceItem.md) | :heavy_minus_sign:                                      | N/A                                                     |


### Response

**[PatchCommerceItemResponse](../../Models/Requests/PatchCommerceItemResponse.md)**


## PatchCommerceLocation

Update a location

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Commerce.PatchCommerceLocationAsync(
    connectionId: "string",
    id: "string",
    commerceLocation: new CommerceLocation() {
    Address = new PropertyCommerceLocationAddress() {},
    Name = "string",
    Raw = new Dictionary<string, object>() {
        { "key", "string" },
    },
});

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `ConnectionId`                                                  | *string*                                                        | :heavy_check_mark:                                              | ID of the connection                                            |
| `Id`                                                            | *string*                                                        | :heavy_check_mark:                                              | ID of the Location                                              |
| `CommerceLocation`                                              | [CommerceLocation](../../Models/Components/CommerceLocation.md) | :heavy_minus_sign:                                              | N/A                                                             |


### Response

**[PatchCommerceLocationResponse](../../Models/Requests/PatchCommerceLocationResponse.md)**


## RemoveCommerceCollection

Remove a collection

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Commerce.RemoveCommerceCollectionAsync(
    connectionId: "string",
    id: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Collection |


### Response

**[RemoveCommerceCollectionResponse](../../Models/Requests/RemoveCommerceCollectionResponse.md)**


## RemoveCommerceInventory

Remove an inventory

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Commerce.RemoveCommerceInventoryAsync(
    connectionId: "string",
    id: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Inventory  |


### Response

**[RemoveCommerceInventoryResponse](../../Models/Requests/RemoveCommerceInventoryResponse.md)**


## RemoveCommerceItem

Remove an item/product

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Commerce.RemoveCommerceItemAsync(
    connectionId: "string",
    id: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Item       |


### Response

**[RemoveCommerceItemResponse](../../Models/Requests/RemoveCommerceItemResponse.md)**


## RemoveCommerceLocation

Remove a location

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Commerce.RemoveCommerceLocationAsync(
    connectionId: "string",
    id: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Location   |


### Response

**[RemoveCommerceLocationResponse](../../Models/Requests/RemoveCommerceLocationResponse.md)**


## UpdateCommerceCollection

Update a collection

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Commerce.UpdateCommerceCollectionAsync(
    connectionId: "string",
    id: "string",
    commerceCollection: new CommerceCollection() {
    Id = "<ID>",
    ItemIds = new List<string>() {
        "string",
    },
    Media = new List<CommerceItemMedia>() {
        new CommerceItemMedia() {
            Url = "https://stupid-entity.org",
        },
    },
    Name = "string",
    Raw = new Dictionary<string, object>() {
        { "key", "string" },
    },
    Tags = new List<string>() {
        "string",
    },
});

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ConnectionId`                                                      | *string*                                                            | :heavy_check_mark:                                                  | ID of the connection                                                |
| `Id`                                                                | *string*                                                            | :heavy_check_mark:                                                  | ID of the Collection                                                |
| `CommerceCollection`                                                | [CommerceCollection](../../Models/Components/CommerceCollection.md) | :heavy_minus_sign:                                                  | A collection of items/products/services                             |


### Response

**[UpdateCommerceCollectionResponse](../../Models/Requests/UpdateCommerceCollectionResponse.md)**


## UpdateCommerceInventory

Update an inventory

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Commerce.UpdateCommerceInventoryAsync(
    connectionId: "string",
    id: "string",
    commerceInventory: new CommerceInventory() {
    Available = 9360.02D,
    Raw = new Dictionary<string, object>() {
        { "key", "string" },
    },
});

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `ConnectionId`                                                    | *string*                                                          | :heavy_check_mark:                                                | ID of the connection                                              |
| `Id`                                                              | *string*                                                          | :heavy_check_mark:                                                | ID of the Inventory                                               |
| `CommerceInventory`                                               | [CommerceInventory](../../Models/Components/CommerceInventory.md) | :heavy_minus_sign:                                                | N/A                                                               |


### Response

**[UpdateCommerceInventoryResponse](../../Models/Requests/UpdateCommerceInventoryResponse.md)**


## UpdateCommerceItem

Update an item/product

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Commerce.UpdateCommerceItemAsync(
    connectionId: "string",
    id: "string",
    commerceItem: new CommerceItem() {
    Media = new List<CommerceItemMedia>() {
        new CommerceItemMedia() {
            Url = "https://aggressive-major-league.org",
        },
    },
    Name = "string",
    Raw = new Dictionary<string, object>() {
        { "key", "string" },
    },
    Tags = new List<string>() {
        "string",
    },
    Variants = new List<CommerceItemVariant>() {
        new CommerceItemVariant() {
            Media = new List<CommerceItemMedia>() {
                new CommerceItemMedia() {
                    Url = "https://reasonable-cast.biz",
                },
            },
            Name = "string",
            Options = new List<CommerceItemOption>() {
                new CommerceItemOption() {
                    Id = "<ID>",
                    Name = "string",
                    Values = new List<string>() {
                        "string",
                    },
                },
            },
            Prices = new List<CommerceItemPrice>() {
                new CommerceItemPrice() {
                    Price = 8467.25D,
                },
            },
            Tags = new List<string>() {
                "string",
            },
        },
    },
});

// handle response
```

### Parameters

| Parameter                                               | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `ConnectionId`                                          | *string*                                                | :heavy_check_mark:                                      | ID of the connection                                    |
| `Id`                                                    | *string*                                                | :heavy_check_mark:                                      | ID of the Item                                          |
| `CommerceItem`                                          | [CommerceItem](../../Models/Components/CommerceItem.md) | :heavy_minus_sign:                                      | N/A                                                     |


### Response

**[UpdateCommerceItemResponse](../../Models/Requests/UpdateCommerceItemResponse.md)**


## UpdateCommerceLocation

Update a location

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Commerce.UpdateCommerceLocationAsync(
    connectionId: "string",
    id: "string",
    commerceLocation: new CommerceLocation() {
    Address = new PropertyCommerceLocationAddress() {},
    Name = "string",
    Raw = new Dictionary<string, object>() {
        { "key", "string" },
    },
});

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `ConnectionId`                                                  | *string*                                                        | :heavy_check_mark:                                              | ID of the connection                                            |
| `Id`                                                            | *string*                                                        | :heavy_check_mark:                                              | ID of the Location                                              |
| `CommerceLocation`                                              | [CommerceLocation](../../Models/Components/CommerceLocation.md) | :heavy_minus_sign:                                              | N/A                                                             |


### Response

**[UpdateCommerceLocationResponse](../../Models/Requests/UpdateCommerceLocationResponse.md)**
