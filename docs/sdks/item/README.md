# Item
(*Item*)

### Available Operations

* [CreateCommerceItem](#createcommerceitem) - Create an item/product
* [GetCommerceItem](#getcommerceitem) - Retrieve an item/product
* [ListCommerceItems](#listcommerceitems) - List all items/products
* [PatchCommerceItem](#patchcommerceitem) - Update an item/product
* [RemoveCommerceItem](#removecommerceitem) - Remove an item/product
* [UpdateCommerceItem](#updatecommerceitem) - Update an item/product

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

var res = await sdk.Item.CreateCommerceItemAsync(
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

var res = await sdk.Item.GetCommerceItemAsync(
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

var res = await sdk.Item.ListCommerceItemsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListCommerceItemsRequest](../../Models/Requests/ListCommerceItemsRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |


### Response

**[ListCommerceItemsResponse](../../Models/Requests/ListCommerceItemsResponse.md)**


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

var res = await sdk.Item.PatchCommerceItemAsync(
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

var res = await sdk.Item.RemoveCommerceItemAsync(
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

var res = await sdk.Item.UpdateCommerceItemAsync(
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

