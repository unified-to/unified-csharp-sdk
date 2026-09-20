# Commerce

## Overview

### Available Operations

* [CreateCommerceCollection](#createcommercecollection) - Create a collection
* [CreateCommerceInventory](#createcommerceinventory) - Create an inventory
* [CreateCommerceItem](#createcommerceitem) - Create an item
* [CreateCommerceItemvariant](#createcommerceitemvariant) - Create an itemvariant
* [CreateCommerceLocation](#createcommercelocation) - Create a location
* [CreateCommerceReservation](#createcommercereservation) - Create a reservation
* [CreateCommerceReview](#createcommercereview) - Create a review
* [CreateCommerceSaleschannel](#createcommercesaleschannel) - Create a saleschannel
* [GetCommerceCollection](#getcommercecollection) - Retrieve a collection
* [GetCommerceInventory](#getcommerceinventory) - Retrieve an inventory
* [GetCommerceItem](#getcommerceitem) - Retrieve an item
* [GetCommerceItemvariant](#getcommerceitemvariant) - Retrieve an itemvariant
* [GetCommerceLocation](#getcommercelocation) - Retrieve a location
* [GetCommerceReservation](#getcommercereservation) - Retrieve a reservation
* [GetCommerceReview](#getcommercereview) - Retrieve a review
* [GetCommerceSaleschannel](#getcommercesaleschannel) - Retrieve a saleschannel
* [ListCommerceAvailabilities](#listcommerceavailabilities) - List all availabilities
* [ListCommerceCollections](#listcommercecollections) - List all collections
* [ListCommerceInventories](#listcommerceinventories) - List all inventories
* [ListCommerceItems](#listcommerceitems) - List all items
* [ListCommerceItemvariants](#listcommerceitemvariants) - List all itemvariants
* [ListCommerceLocations](#listcommercelocations) - List all locations
* [ListCommerceReservations](#listcommercereservations) - List all reservations
* [ListCommerceReviews](#listcommercereviews) - List all reviews
* [ListCommerceSaleschannels](#listcommercesaleschannels) - List all saleschannels
* [PatchCommerceCollection](#patchcommercecollection) - Update a collection
* [PatchCommerceInventory](#patchcommerceinventory) - Update an inventory
* [PatchCommerceItem](#patchcommerceitem) - Update an item
* [PatchCommerceItemvariant](#patchcommerceitemvariant) - Update an itemvariant
* [PatchCommerceLocation](#patchcommercelocation) - Update a location
* [PatchCommerceReservation](#patchcommercereservation) - Update a reservation
* [PatchCommerceReview](#patchcommercereview) - Update a review
* [PatchCommerceSaleschannel](#patchcommercesaleschannel) - Update a saleschannel
* [RemoveCommerceCollection](#removecommercecollection) - Remove a collection
* [RemoveCommerceInventory](#removecommerceinventory) - Remove an inventory
* [RemoveCommerceItem](#removecommerceitem) - Remove an item
* [RemoveCommerceItemvariant](#removecommerceitemvariant) - Remove an itemvariant
* [RemoveCommerceLocation](#removecommercelocation) - Remove a location
* [RemoveCommerceReservation](#removecommercereservation) - Remove a reservation
* [RemoveCommerceReview](#removecommercereview) - Remove a review
* [RemoveCommerceSaleschannel](#removecommercesaleschannel) - Remove a saleschannel
* [UpdateCommerceCollection](#updatecommercecollection) - Update a collection
* [UpdateCommerceInventory](#updatecommerceinventory) - Update an inventory
* [UpdateCommerceItem](#updatecommerceitem) - Update an item
* [UpdateCommerceItemvariant](#updatecommerceitemvariant) - Update an itemvariant
* [UpdateCommerceLocation](#updatecommercelocation) - Update a location
* [UpdateCommerceReservation](#updatecommercereservation) - Update a reservation
* [UpdateCommerceReview](#updatecommercereview) - Update a review
* [UpdateCommerceSaleschannel](#updatecommercesaleschannel) - Update a saleschannel

## CreateCommerceCollection

Create a collection

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createCommerceCollection" method="post" path="/commerce/{connection_id}/collection" example="commerce_collection" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Commerce.CreateCommerceCollectionAsync(
    commerceCollection: new CommerceCollection() {
        CreatedAt = System.DateTime.Parse("2023-07-14T00:42:54.742Z").ToUniversalTime(),
        Description = "The Integrated leading edge website Cheese offers reliable performance and productive design",
        Id = "ea9b722c-e40c-4255-99b9-3e1fac378b21",
        IsActive = true,
        IsFeatured = false,
        IsVisible = false,
        ItemMetadata = new List<CommerceMetadata>() {},
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Defungo adopto thorax.",
                Height = 759D,
                Id = "42ba0cb5-208c-4c17-94c5-39ca533f7138",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "f4a4e225-1990-4d86-b866-9f1cb8b12d85",
                        Slug = "censura",
                        Value = CommerceMetadataValue.CreateStr(
                            "toties"
                        ),
                    },
                },
                Position = 80D,
                Type = CommerceItemMediaType.Video,
                Url = "https://loremflickr.com/1319/1257?lock=7280448425732025",
                Width = 40D,
            },
        },
        Metadata = new List<CommerceMetadata>() {
            new CommerceMetadata() {
                Id = "7e7fb7c1-2220-4380-aa6a-06698253ff2e",
                Slug = "aetas",
                Value = CommerceMetadataValue.CreateStr(
                    "consuasor"
                ),
            },
        },
        Name = "Small Marble Chips",
        PublicDescription = "Generic Gloves designed with Cotton for miserable performance",
        PublicName = "Small Marble Chips",
        Tags = new List<string>() {
            "ambulo",
            "adeptio",
            "contego",
        },
        Type = CommerceCollectionType.Collection,
        UpdatedAt = System.DateTime.Parse("2025-02-27T05:36:17.208Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `CommerceCollection`                                                                                                                             | [CommerceCollection](../../Models/Components/CommerceCollection.md)                                                                              | :heavy_check_mark:                                                                                                                               | A collection of items/products/services                                                                                                          |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateCommerceCollectionQueryParamFields](../../Models/Requests/CreateCommerceCollectionQueryParamFields.md)>                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateCommerceCollectionResponse](../../Models/Requests/CreateCommerceCollectionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateCommerceInventory

Create an inventory

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createCommerceInventory" method="post" path="/commerce/{connection_id}/inventory" example="commerce_inventory" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Commerce.CreateCommerceInventoryAsync(
    commerceInventory: new CommerceInventory() {
        Available = 337D,
        UpdatedAt = System.DateTime.Parse("2025-10-26T10:30:53.944Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `CommerceInventory`                                                                                                                              | [CommerceInventory](../../Models/Components/CommerceInventory.md)                                                                                | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateCommerceInventoryQueryParamFields](../../Models/Requests/CreateCommerceInventoryQueryParamFields.md)>                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateCommerceInventoryResponse](../../Models/Requests/CreateCommerceInventoryResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateCommerceItem

Create an item

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createCommerceItem" method="post" path="/commerce/{connection_id}/item" example="commerce_item" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Commerce.CreateCommerceItemAsync(
    commerceItem: new CommerceItem() {
        Collections = new List<CommerceReference>() {},
        CreatedAt = System.DateTime.Parse("2019-06-21T20:16:18.628Z").ToUniversalTime(),
        Description = "Vulnero ustulo abeo.",
        Duration = 87D,
        GlobalCode = "calamitas",
        Id = "c4ae4fb0-5939-49de-a784-28f0a2628cf4",
        IsActive = false,
        IsFeatured = true,
        IsTaxable = true,
        IsVisible = true,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Caterva eveniet acies candidus.",
                Height = 663D,
                Id = "2e062d01-1772-444a-a28f-75026cb422d6",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "ea10adde-6a80-4699-a75e-e5b9307ccde6",
                        Slug = "doloremque",
                        Value = CommerceMetadataValue.CreateStr(
                            "allatus"
                        ),
                    },
                },
                Position = 67D,
                Type = CommerceItemMediaType.Video,
                Url = "https://picsum.photos/seed/73y0uzyK/972/3753",
                Width = 88D,
            },
            new CommerceItemMedia() {
                Alt = "Comedo.",
                Height = 189D,
                Id = "3ea8c316-50ef-4fa4-897a-c3258a431b6e",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "1520ca9b-5896-4880-872a-db6a2089a516",
                        Slug = "bis",
                        Value = CommerceMetadataValue.CreateStr(
                            "somniculosus"
                        ),
                    },
                },
                Position = 3D,
                Type = CommerceItemMediaType.Image,
                Url = "https://picsum.photos/seed/Ao4iatfO/771/3906",
                Width = 66D,
            },
        },
        Metadata = new List<CommerceMetadata>() {
            new CommerceMetadata() {
                ExtraData = CommerceMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = CommerceMetadataFormat.Text,
                Id = "9ff77460-2a3b-42dd-9c06-ece8564d1b82",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CommerceMetadataValue.CreateStr(
                    "terebro"
                ),
            },
        },
        Name = "Handcrafted Rubber Tuna",
        Prices = new List<CommerceItemPrice>() {
            new CommerceItemPrice() {
                CompareAtPrice = 474D,
                Currency = "OMR",
                Price = 1438D,
            },
        },
        PublicDescription = "Custodia ventus solio compono.",
        PublicName = "Handcrafted Rubber Tuna",
        RequiresShipping = true,
        Slug = "cohors-turba-optio",
        Tags = new List<string>() {
            "blanditiis",
            "tandem",
        },
        TotalStock = 579D,
        Type = "beatae",
        UpdatedAt = System.DateTime.Parse("2022-04-07T13:13:57.339Z").ToUniversalTime(),
        VendorName = "Mayer - Flatley",
        Weight = 22D,
        WeightUnit = WeightUnit.Kg,
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `CommerceItem`                                                                                                                                   | [CommerceItem](../../Models/Components/CommerceItem.md)                                                                                          | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateCommerceItemQueryParamFields](../../Models/Requests/CreateCommerceItemQueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateCommerceItemResponse](../../Models/Requests/CreateCommerceItemResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateCommerceItemvariant

Create an itemvariant

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createCommerceItemvariant" method="post" path="/commerce/{connection_id}/itemvariant" example="commerce_itemvariant" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Commerce.CreateCommerceItemvariantAsync(
    commerceItemvariant: new CommerceItemvariant() {
        AvailableAt = System.DateTime.Parse("2022-02-02T16:10:33.503Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2022-01-20T13:49:12.968Z").ToUniversalTime(),
        Description = "Featuring Helium-enhanced technology, our Chips offers unparalleled helpful performance",
        Height = 52D,
        Id = "140fa4ca-85ec-4ace-abfe-2f11f40fb0ea",
        IsActive = false,
        IsFeatured = false,
        IsVisible = false,
        Length = 94D,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Calcar delibero cursim summisse.",
                Height = 394D,
                Id = "dda7c5e8-b9b6-4f3e-923a-2e0a0ab35c63",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "9991f6b7-4291-4727-8107-7e945f54b7c7",
                        Slug = "illo",
                        Value = CommerceMetadataValue.CreateStr(
                            "quia"
                        ),
                    },
                },
                Position = 92D,
                Type = CommerceItemMediaType.Image,
                Url = "https://picsum.photos/seed/u0YdHqlRu/2007/3208",
                Width = 54D,
            },
            new CommerceItemMedia() {
                Alt = "Civitas acies substantia tergo.",
                Height = 351D,
                Id = "7e8654fa-3b3c-4b83-94a2-beafa30ca9a8",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "7b1df0ae-7095-4f29-b368-f39b5ecdd2bf",
                        Slug = "libero",
                        Value = CommerceMetadataValue.CreateStr(
                            "capitulus"
                        ),
                    },
                },
                Position = 44D,
                Type = CommerceItemMediaType.Image,
                Url = "https://loremflickr.com/2230/1237?lock=8628070842159966",
                Width = 55D,
            },
        },
        Metadata = new List<CommerceMetadata>() {
            new CommerceMetadata() {
                ExtraData = CommerceMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = CommerceMetadataFormat.Text,
                Id = "f4805593-1fc7-4dad-93c2-98a7662b1445",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CommerceMetadataValue.CreateStr(
                    "nihil"
                ),
            },
        },
        Name = "Keyboard",
        Options = new List<CommerceItemOption>() {
            new CommerceItemOption() {
                Id = "12949a1d-5fc0-4fbd-9717-a35268977f81",
                Name = "Steel",
                Position = 97D,
                Values = new List<string>() {
                    "Granite",
                    "Plastic",
                },
            },
        },
        Prices = new List<CommerceItemPrice>() {
            new CommerceItemPrice() {
                CompareAtPrice = 3745D,
                Currency = "COP",
                Price = 4913D,
            },
            new CommerceItemPrice() {
                CompareAtPrice = 438D,
                Currency = "PHP",
                Price = 1378D,
            },
            new CommerceItemPrice() {
                CompareAtPrice = 1614D,
                Currency = "PHP",
                Price = 8702D,
            },
        },
        PublicDescription = "Stylish Soap designed to make you stand out with insistent looks",
        PublicName = "Keyboard",
        RequiresShipping = false,
        SizeUnit = SizeUnit.Cm,
        Sku = "978-0-7051-0955-0",
        Tags = new List<string>() {
            "vomito",
            "custodia",
        },
        TotalStock = 929D,
        UpdatedAt = System.DateTime.Parse("2025-05-25T20:21:18.896Z").ToUniversalTime(),
        Weight = 61D,
        WeightUnit = CommerceItemvariantWeightUnit.Oz,
        Width = 26D,
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `CommerceItemvariant`                                                                                                                            | [CommerceItemvariant](../../Models/Components/CommerceItemvariant.md)                                                                            | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateCommerceItemvariantQueryParamFields](../../Models/Requests/CreateCommerceItemvariantQueryParamFields.md)>                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateCommerceItemvariantResponse](../../Models/Requests/CreateCommerceItemvariantResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateCommerceLocation

Create a location

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createCommerceLocation" method="post" path="/commerce/{connection_id}/location" example="commerce_location" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Commerce.CreateCommerceLocationAsync(
    commerceLocation: new CommerceLocation() {
        Address = new PropertyCommerceLocationAddress() {
            Address1 = "29896 The Limes",
            City = "New Kenny",
            CountryCode = "US",
            PostalCode = "14490-0609",
            Region = "Virginia",
            RegionCode = "MS",
        },
        Categories = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2022-12-29T04:15:21.195Z").ToUniversalTime(),
        Currency = "XCD",
        Description = "Adsidue audentia.",
        Id = "92683c96-5e0b-4302-800e-b71f0593421b",
        ImageUrl = "https://picsum.photos/seed/hjFt1/1036/2220",
        IsActive = false,
        LanguageLocale = "vulgaris",
        Latitude = 0D,
        LocationType = LocationType.Restaurant,
        Longitude = 0D,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Addo.",
                Height = 283D,
                Id = "84c08b81-344c-4788-9fa1-3c57c78b929d",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "1c1359da-32a9-4def-b57d-26e36d64968c",
                        Slug = "abutor",
                        Value = CommerceMetadataValue.CreateStr(
                            "damno"
                        ),
                    },
                },
                Position = 40D,
                Type = CommerceItemMediaType.Image,
                Url = "https://picsum.photos/seed/QVh7ViTV/3964/1567",
                Width = 1D,
            },
        },
        Name = "Olson - Mraz",
        PriceLevel = "",
        Rating = 0D,
        ReviewCount = 0D,
        Telephones = new List<CommerceTelephone>() {
            new CommerceTelephone() {
                Telephone = "(872) 522-3201",
                Type = CommerceTelephoneType.Other,
            },
            new CommerceTelephone() {
                Telephone = "(236) 274-2445",
                Type = CommerceTelephoneType.Mobile,
            },
        },
        UpdatedAt = System.DateTime.Parse("2024-04-10T02:11:56.392Z").ToUniversalTime(),
        WebUrl = "https://chilly-edge.info",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `CommerceLocation`                                                                                                                               | [CommerceLocation](../../Models/Components/CommerceLocation.md)                                                                                  | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateCommerceLocationQueryParamFields](../../Models/Requests/CreateCommerceLocationQueryParamFields.md)>                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateCommerceLocationResponse](../../Models/Requests/CreateCommerceLocationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateCommerceReservation

Create a reservation

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createCommerceReservation" method="post" path="/commerce/{connection_id}/reservation" example="commerce_reservation" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Commerce.CreateCommerceReservationAsync(
    commerceReservation: new CommerceReservation() {
        CreatedAt = System.DateTime.Parse("2021-12-14T19:50:31.151Z").ToUniversalTime(),
        EndAt = System.DateTime.Parse("2022-01-01T22:00:17.868Z").ToUniversalTime(),
        GuestEmail = "Sunny.Strosin77@yahoo.com",
        GuestName = "Annette Franecki",
        GuestPhone = "(990) 317-6213",
        Id = "35589e74-521e-4752-866e-7df5b7f0ab38",
        ItemName = "Practical Ceramic Shoes",
        Notes = "Adsum textilis ipsum despecto.",
        Size = 10D,
        StaffName = "Vickie Fahey",
        StartAt = System.DateTime.Parse("2021-12-18T00:40:25.125Z").ToUniversalTime(),
        Status = CommerceReservationStatus.Pending,
        UpdatedAt = System.DateTime.Parse("2022-12-28T03:41:32.985Z").ToUniversalTime(),
        Url = "https://cluttered-pine.info/",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `CommerceReservation`                                                                                                                            | [CommerceReservation](../../Models/Components/CommerceReservation.md)                                                                            | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateCommerceReservationQueryParamFields](../../Models/Requests/CreateCommerceReservationQueryParamFields.md)>                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateCommerceReservationResponse](../../Models/Requests/CreateCommerceReservationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateCommerceReview

Create a review

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createCommerceReview" method="post" path="/commerce/{connection_id}/review" example="commerce_review" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Commerce.CreateCommerceReviewAsync(
    commerceReview: new CommerceReview() {
        AuthorAvatarUrl = "https://picsum.photos/seed/ix4Br3LA/2245/1245",
        AuthorEmail = "Cleve_Yundt@hotmail.com",
        AuthorLocation = "ipsum",
        AuthorName = "Marsha Krajcik",
        Comments = new List<CommerceReviewComment>() {},
        Content = "Taedium thymum adipiscor amicitia cui.",
        CreatedAt = System.DateTime.Parse("2019-12-12T18:10:22.988Z").ToUniversalTime(),
        HelpfulVotes = 26D,
        Id = "c612b1ce-b8f5-4807-b176-c1a09162b34b",
        IsFeatured = true,
        IsPublic = true,
        IsVerified = false,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Adulescens.",
                Height = 519D,
                Id = "e6596606-c737-467f-ab11-4dfb9efbb35c",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "17888df1-8809-4193-9818-99168b6dfbe4",
                        Slug = "aggero",
                        Value = CommerceMetadataValue.CreateStr(
                            "tero"
                        ),
                    },
                },
                Position = 72D,
                Type = CommerceItemMediaType.Video,
                Url = "https://loremflickr.com/882/1004?lock=7448492654002422",
                Width = 75D,
            },
            new CommerceItemMedia() {
                Alt = "Pauci timidus sol comburo thema.",
                Height = 297D,
                Id = "63c92585-4fe4-41f4-b7d8-574bfa1fb233",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "49c17d47-4d05-4ce3-ba34-a1320a037e60",
                        Slug = "vito",
                        Value = CommerceMetadataValue.CreateStr(
                            "cuppedia"
                        ),
                    },
                },
                Position = 61D,
                Type = CommerceItemMediaType.Image,
                Url = "https://picsum.photos/seed/3QDZ8/1208/2171",
                Width = 96D,
            },
            new CommerceItemMedia() {
                Alt = "Cuppedia vestrum patruus.",
                Height = 6D,
                Id = "ee7f1994-756b-48ac-8bf7-55d254a019a0",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "00edf3ae-f9a6-4d2d-a67a-374f23609708",
                        Slug = "arbitro",
                        Value = CommerceMetadataValue.CreateStr(
                            "villa"
                        ),
                    },
                },
                Position = 60D,
                Type = CommerceItemMediaType.Video,
                Url = "https://picsum.photos/seed/ytybC/2616/710",
                Width = 74D,
            },
        },
        Metadata = new List<CommerceMetadata>() {},
        Rating = 3D,
        Status = CommerceReviewStatus.Approved,
        Title = "Coepi adamo amicitia auxilium toties.",
        UnhelpfulVotes = 49D,
        UpdatedAt = System.DateTime.Parse("2025-07-26T15:20:28.795Z").ToUniversalTime(),
        Url = "https://excitable-underneath.com",
        VerifiedPurchase = false,
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `CommerceReview`                                                                                                                                 | [CommerceReview](../../Models/Components/CommerceReview.md)                                                                                      | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateCommerceReviewQueryParamFields](../../Models/Requests/CreateCommerceReviewQueryParamFields.md)>                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateCommerceReviewResponse](../../Models/Requests/CreateCommerceReviewResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateCommerceSaleschannel

Create a saleschannel

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createCommerceSaleschannel" method="post" path="/commerce/{connection_id}/saleschannel" example="commerce_saleschannel" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Commerce.CreateCommerceSaleschannelAsync(
    commerceSaleschannel: new CommerceSaleschannel() {
        Collections = new List<CommerceReference>() {},
        CreatedAt = System.DateTime.Parse("2021-12-12T06:19:55.421Z").ToUniversalTime(),
        Description = "Utroque denuncio solutio.",
        Id = "c2f2326c-d2d0-4e00-88e7-7ad0d44e5ccc",
        IsActive = false,
        Slug = "amiculum-congregatio-suspendo",
        UpdatedAt = System.DateTime.Parse("2025-01-08T00:50:31.637Z").ToUniversalTime(),
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `CommerceSaleschannel`                                                                                                                           | [CommerceSaleschannel](../../Models/Components/CommerceSaleschannel.md)                                                                          | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateCommerceSaleschannelQueryParamFields](../../Models/Requests/CreateCommerceSaleschannelQueryParamFields.md)>                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateCommerceSaleschannelResponse](../../Models/Requests/CreateCommerceSaleschannelResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetCommerceCollection

Retrieve a collection

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCommerceCollection" method="get" path="/commerce/{connection_id}/collection/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Commerce.GetCommerceCollectionAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Collection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[GetCommerceCollectionQueryParamFields](../../Models/Requests/GetCommerceCollectionQueryParamFields.md)>                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetCommerceCollectionResponse](../../Models/Requests/GetCommerceCollectionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetCommerceInventory

Retrieve an inventory

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCommerceInventory" method="get" path="/commerce/{connection_id}/inventory/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Commerce.GetCommerceInventoryAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Inventory                                                                                                                              |
| `Fields`                                                                                                                                         | List<[GetCommerceInventoryQueryParamFields](../../Models/Requests/GetCommerceInventoryQueryParamFields.md)>                                      | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetCommerceInventoryResponse](../../Models/Requests/GetCommerceInventoryResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetCommerceItem

Retrieve an item

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCommerceItem" method="get" path="/commerce/{connection_id}/item/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Commerce.GetCommerceItemAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Item                                                                                                                                   |
| `Fields`                                                                                                                                         | List<[GetCommerceItemQueryParamFields](../../Models/Requests/GetCommerceItemQueryParamFields.md)>                                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetCommerceItemResponse](../../Models/Requests/GetCommerceItemResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetCommerceItemvariant

Retrieve an itemvariant

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCommerceItemvariant" method="get" path="/commerce/{connection_id}/itemvariant/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Commerce.GetCommerceItemvariantAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Itemvariant                                                                                                                            |
| `Fields`                                                                                                                                         | List<[GetCommerceItemvariantQueryParamFields](../../Models/Requests/GetCommerceItemvariantQueryParamFields.md)>                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetCommerceItemvariantResponse](../../Models/Requests/GetCommerceItemvariantResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetCommerceLocation

Retrieve a location

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCommerceLocation" method="get" path="/commerce/{connection_id}/location/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Commerce.GetCommerceLocationAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Location                                                                                                                               |
| `Fields`                                                                                                                                         | List<[GetCommerceLocationQueryParamFields](../../Models/Requests/GetCommerceLocationQueryParamFields.md)>                                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetCommerceLocationResponse](../../Models/Requests/GetCommerceLocationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetCommerceReservation

Retrieve a reservation

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCommerceReservation" method="get" path="/commerce/{connection_id}/reservation/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Commerce.GetCommerceReservationAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Reservation                                                                                                                            |
| `Fields`                                                                                                                                         | List<[GetCommerceReservationQueryParamFields](../../Models/Requests/GetCommerceReservationQueryParamFields.md)>                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetCommerceReservationResponse](../../Models/Requests/GetCommerceReservationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetCommerceReview

Retrieve a review

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCommerceReview" method="get" path="/commerce/{connection_id}/review/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Commerce.GetCommerceReviewAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Review                                                                                                                                 |
| `Fields`                                                                                                                                         | List<[GetCommerceReviewQueryParamFields](../../Models/Requests/GetCommerceReviewQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetCommerceReviewResponse](../../Models/Requests/GetCommerceReviewResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetCommerceSaleschannel

Retrieve a saleschannel

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCommerceSaleschannel" method="get" path="/commerce/{connection_id}/saleschannel/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Commerce.GetCommerceSaleschannelAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Saleschannel                                                                                                                           |
| `Fields`                                                                                                                                         | List<[GetCommerceSaleschannelQueryParamFields](../../Models/Requests/GetCommerceSaleschannelQueryParamFields.md)>                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetCommerceSaleschannelResponse](../../Models/Requests/GetCommerceSaleschannelResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListCommerceAvailabilities

List all availabilities

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listCommerceAvailabilities" method="get" path="/commerce/{connection_id}/availability" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListCommerceAvailabilitiesRequest req = new ListCommerceAvailabilitiesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Commerce.ListCommerceAvailabilitiesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [ListCommerceAvailabilitiesRequest](../../Models/Requests/ListCommerceAvailabilitiesRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[ListCommerceAvailabilitiesResponse](../../Models/Requests/ListCommerceAvailabilitiesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListCommerceCollections

List all collections

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listCommerceCollections" method="get" path="/commerce/{connection_id}/collection" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListCommerceCollectionsRequest req = new ListCommerceCollectionsRequest() {
    ConnectionId = "<id>",
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

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListCommerceInventories

List all inventories

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listCommerceInventories" method="get" path="/commerce/{connection_id}/inventory" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListCommerceInventoriesRequest req = new ListCommerceInventoriesRequest() {
    ConnectionId = "<id>",
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

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListCommerceItems

List all items

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listCommerceItems" method="get" path="/commerce/{connection_id}/item" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListCommerceItemsRequest req = new ListCommerceItemsRequest() {
    ConnectionId = "<id>",
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

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListCommerceItemvariants

List all itemvariants

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listCommerceItemvariants" method="get" path="/commerce/{connection_id}/itemvariant" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListCommerceItemvariantsRequest req = new ListCommerceItemvariantsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Commerce.ListCommerceItemvariantsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [ListCommerceItemvariantsRequest](../../Models/Requests/ListCommerceItemvariantsRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[ListCommerceItemvariantsResponse](../../Models/Requests/ListCommerceItemvariantsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListCommerceLocations

List all locations

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listCommerceLocations" method="get" path="/commerce/{connection_id}/location" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListCommerceLocationsRequest req = new ListCommerceLocationsRequest() {
    ConnectionId = "<id>",
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

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListCommerceReservations

List all reservations

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listCommerceReservations" method="get" path="/commerce/{connection_id}/reservation" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListCommerceReservationsRequest req = new ListCommerceReservationsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Commerce.ListCommerceReservationsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [ListCommerceReservationsRequest](../../Models/Requests/ListCommerceReservationsRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[ListCommerceReservationsResponse](../../Models/Requests/ListCommerceReservationsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListCommerceReviews

List all reviews

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listCommerceReviews" method="get" path="/commerce/{connection_id}/review" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListCommerceReviewsRequest req = new ListCommerceReviewsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Commerce.ListCommerceReviewsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ListCommerceReviewsRequest](../../Models/Requests/ListCommerceReviewsRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[ListCommerceReviewsResponse](../../Models/Requests/ListCommerceReviewsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListCommerceSaleschannels

List all saleschannels

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listCommerceSaleschannels" method="get" path="/commerce/{connection_id}/saleschannel" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListCommerceSaleschannelsRequest req = new ListCommerceSaleschannelsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Commerce.ListCommerceSaleschannelsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [ListCommerceSaleschannelsRequest](../../Models/Requests/ListCommerceSaleschannelsRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[ListCommerceSaleschannelsResponse](../../Models/Requests/ListCommerceSaleschannelsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchCommerceCollection

Update a collection

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchCommerceCollection" method="patch" path="/commerce/{connection_id}/collection/{id}" example="commerce_collection" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchCommerceCollectionRequest req = new PatchCommerceCollectionRequest() {
    CommerceCollection = new CommerceCollection() {
        CreatedAt = System.DateTime.Parse("2023-07-14T00:42:54.742Z").ToUniversalTime(),
        Description = "The Integrated leading edge website Cheese offers reliable performance and productive design",
        Id = "9c00543a-bbe5-439f-9e79-3faea46af46f",
        IsActive = true,
        IsFeatured = false,
        IsVisible = false,
        ItemMetadata = new List<CommerceMetadata>() {},
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Defungo adopto thorax.",
                Height = 759D,
                Id = "f0be7d32-6ad4-46fb-9105-9167bc7e9aa2",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "626e7eb5-1a9c-46e9-be53-523f248efed7",
                        Slug = "censura",
                        Value = CommerceMetadataValue.CreateStr(
                            "toties"
                        ),
                    },
                },
                Position = 80D,
                Type = CommerceItemMediaType.Video,
                Url = "https://loremflickr.com/1319/1257?lock=7280448425732025",
                Width = 40D,
            },
        },
        Metadata = new List<CommerceMetadata>() {
            new CommerceMetadata() {
                Id = "88abded1-be10-42ea-a0dd-7a9813d5d126",
                Slug = "aetas",
                Value = CommerceMetadataValue.CreateStr(
                    "consuasor"
                ),
            },
        },
        Name = "Small Marble Chips",
        PublicDescription = "Generic Gloves designed with Cotton for miserable performance",
        PublicName = "Small Marble Chips",
        Tags = new List<string>() {
            "ambulo",
            "adeptio",
            "contego",
        },
        Type = CommerceCollectionType.Collection,
        UpdatedAt = System.DateTime.Parse("2025-02-27T05:36:17.220Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Commerce.PatchCommerceCollectionAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [PatchCommerceCollectionRequest](../../Models/Requests/PatchCommerceCollectionRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[PatchCommerceCollectionResponse](../../Models/Requests/PatchCommerceCollectionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchCommerceInventory

Update an inventory

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchCommerceInventory" method="patch" path="/commerce/{connection_id}/inventory/{id}" example="commerce_inventory" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchCommerceInventoryRequest req = new PatchCommerceInventoryRequest() {
    CommerceInventory = new CommerceInventory() {
        Available = 337D,
        UpdatedAt = System.DateTime.Parse("2025-10-26T10:30:53.952Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Commerce.PatchCommerceInventoryAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [PatchCommerceInventoryRequest](../../Models/Requests/PatchCommerceInventoryRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[PatchCommerceInventoryResponse](../../Models/Requests/PatchCommerceInventoryResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchCommerceItem

Update an item

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchCommerceItem" method="patch" path="/commerce/{connection_id}/item/{id}" example="commerce_item" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchCommerceItemRequest req = new PatchCommerceItemRequest() {
    CommerceItem = new CommerceItem() {
        Collections = new List<CommerceReference>() {},
        CreatedAt = System.DateTime.Parse("2019-06-21T20:16:18.628Z").ToUniversalTime(),
        Description = "Vulnero ustulo abeo.",
        Duration = 87D,
        GlobalCode = "calamitas",
        Id = "39f0112a-7ef3-42f6-9c7d-db1995c23982",
        IsActive = false,
        IsFeatured = true,
        IsTaxable = true,
        IsVisible = true,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Caterva eveniet acies candidus.",
                Height = 663D,
                Id = "7d0fc7bd-1973-4cb9-aa31-39c8e8b4c7e8",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "cfd67087-d64a-4579-8276-c3f59e321672",
                        Slug = "doloremque",
                        Value = CommerceMetadataValue.CreateStr(
                            "allatus"
                        ),
                    },
                },
                Position = 67D,
                Type = CommerceItemMediaType.Video,
                Url = "https://picsum.photos/seed/73y0uzyK/972/3753",
                Width = 88D,
            },
            new CommerceItemMedia() {
                Alt = "Comedo.",
                Height = 189D,
                Id = "be9da297-83f2-454e-b508-c392c2382653",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "54d64983-78be-4bcb-bf42-e814c9d5154f",
                        Slug = "bis",
                        Value = CommerceMetadataValue.CreateStr(
                            "somniculosus"
                        ),
                    },
                },
                Position = 3D,
                Type = CommerceItemMediaType.Image,
                Url = "https://picsum.photos/seed/Ao4iatfO/771/3906",
                Width = 66D,
            },
        },
        Metadata = new List<CommerceMetadata>() {
            new CommerceMetadata() {
                ExtraData = CommerceMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = CommerceMetadataFormat.Text,
                Id = "f1cc3521-fb88-4deb-b85d-a3d6387a8c25",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CommerceMetadataValue.CreateStr(
                    "terebro"
                ),
            },
        },
        Name = "Handcrafted Rubber Tuna",
        Prices = new List<CommerceItemPrice>() {
            new CommerceItemPrice() {
                CompareAtPrice = 474D,
                Currency = "OMR",
                Price = 1438D,
            },
        },
        PublicDescription = "Custodia ventus solio compono.",
        PublicName = "Handcrafted Rubber Tuna",
        RequiresShipping = true,
        Slug = "cohors-turba-optio",
        Tags = new List<string>() {
            "blanditiis",
            "tandem",
        },
        TotalStock = 579D,
        Type = "beatae",
        UpdatedAt = System.DateTime.Parse("2022-04-07T13:13:57.351Z").ToUniversalTime(),
        VendorName = "Mayer - Flatley",
        Weight = 22D,
        WeightUnit = WeightUnit.Kg,
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Commerce.PatchCommerceItemAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [PatchCommerceItemRequest](../../Models/Requests/PatchCommerceItemRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[PatchCommerceItemResponse](../../Models/Requests/PatchCommerceItemResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchCommerceItemvariant

Update an itemvariant

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchCommerceItemvariant" method="patch" path="/commerce/{connection_id}/itemvariant/{id}" example="commerce_itemvariant" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchCommerceItemvariantRequest req = new PatchCommerceItemvariantRequest() {
    CommerceItemvariant = new CommerceItemvariant() {
        AvailableAt = System.DateTime.Parse("2022-02-02T16:10:33.503Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2022-01-20T13:49:12.968Z").ToUniversalTime(),
        Description = "Featuring Helium-enhanced technology, our Chips offers unparalleled helpful performance",
        Height = 52D,
        Id = "6f515b17-328e-45ee-a657-e05c6bdb72e9",
        IsActive = false,
        IsFeatured = false,
        IsVisible = false,
        Length = 94D,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Calcar delibero cursim summisse.",
                Height = 394D,
                Id = "89315ea1-b677-4fd8-acf9-dce7c7489c52",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "bc20fcd4-3aac-409a-9c5e-5f6ebbc78672",
                        Slug = "illo",
                        Value = CommerceMetadataValue.CreateStr(
                            "quia"
                        ),
                    },
                },
                Position = 92D,
                Type = CommerceItemMediaType.Image,
                Url = "https://picsum.photos/seed/u0YdHqlRu/2007/3208",
                Width = 54D,
            },
            new CommerceItemMedia() {
                Alt = "Civitas acies substantia tergo.",
                Height = 351D,
                Id = "7567ebac-69c9-45f3-a90b-75ce9acc2631",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "1c4ecc59-dfb5-4173-bece-6ff43b1bb4f5",
                        Slug = "libero",
                        Value = CommerceMetadataValue.CreateStr(
                            "capitulus"
                        ),
                    },
                },
                Position = 44D,
                Type = CommerceItemMediaType.Image,
                Url = "https://loremflickr.com/2230/1237?lock=8628070842159966",
                Width = 55D,
            },
        },
        Metadata = new List<CommerceMetadata>() {
            new CommerceMetadata() {
                ExtraData = CommerceMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = CommerceMetadataFormat.Text,
                Id = "6690aed5-488f-4fd4-bdca-8d106f689412",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CommerceMetadataValue.CreateStr(
                    "nihil"
                ),
            },
        },
        Name = "Keyboard",
        Options = new List<CommerceItemOption>() {
            new CommerceItemOption() {
                Id = "b1b10799-0ced-4ec4-ae9e-67b141b79e8d",
                Name = "Steel",
                Position = 97D,
                Values = new List<string>() {
                    "Granite",
                    "Plastic",
                },
            },
        },
        Prices = new List<CommerceItemPrice>() {
            new CommerceItemPrice() {
                CompareAtPrice = 3745D,
                Currency = "COP",
                Price = 4913D,
            },
            new CommerceItemPrice() {
                CompareAtPrice = 438D,
                Currency = "PHP",
                Price = 1378D,
            },
            new CommerceItemPrice() {
                CompareAtPrice = 1614D,
                Currency = "PHP",
                Price = 8702D,
            },
        },
        PublicDescription = "Stylish Soap designed to make you stand out with insistent looks",
        PublicName = "Keyboard",
        RequiresShipping = false,
        SizeUnit = SizeUnit.Cm,
        Sku = "978-0-7051-0955-0",
        Tags = new List<string>() {
            "vomito",
            "custodia",
        },
        TotalStock = 929D,
        UpdatedAt = System.DateTime.Parse("2025-05-25T20:21:18.929Z").ToUniversalTime(),
        Weight = 61D,
        WeightUnit = CommerceItemvariantWeightUnit.Oz,
        Width = 26D,
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Commerce.PatchCommerceItemvariantAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [PatchCommerceItemvariantRequest](../../Models/Requests/PatchCommerceItemvariantRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[PatchCommerceItemvariantResponse](../../Models/Requests/PatchCommerceItemvariantResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchCommerceLocation

Update a location

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchCommerceLocation" method="patch" path="/commerce/{connection_id}/location/{id}" example="commerce_location" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchCommerceLocationRequest req = new PatchCommerceLocationRequest() {
    CommerceLocation = new CommerceLocation() {
        Address = new PropertyCommerceLocationAddress() {
            Address1 = "29896 The Limes",
            City = "New Kenny",
            CountryCode = "US",
            PostalCode = "14490-0609",
            Region = "Virginia",
            RegionCode = "MS",
        },
        Categories = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2022-12-29T04:15:21.195Z").ToUniversalTime(),
        Currency = "XCD",
        Description = "Adsidue audentia.",
        Id = "da2769e5-8e7f-4b54-8c27-59c767fd326d",
        ImageUrl = "https://picsum.photos/seed/hjFt1/1036/2220",
        IsActive = false,
        LanguageLocale = "vulgaris",
        Latitude = 0D,
        LocationType = LocationType.Restaurant,
        Longitude = 0D,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Addo.",
                Height = 283D,
                Id = "18b3164c-e194-456b-851c-de45c4470726",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "bc6f8f10-df9f-49b2-a8d8-2fed537c4ff5",
                        Slug = "abutor",
                        Value = CommerceMetadataValue.CreateStr(
                            "damno"
                        ),
                    },
                },
                Position = 40D,
                Type = CommerceItemMediaType.Image,
                Url = "https://picsum.photos/seed/QVh7ViTV/3964/1567",
                Width = 1D,
            },
        },
        Name = "Olson - Mraz",
        PriceLevel = "",
        Rating = 0D,
        ReviewCount = 0D,
        Telephones = new List<CommerceTelephone>() {
            new CommerceTelephone() {
                Telephone = "(872) 522-3201",
                Type = CommerceTelephoneType.Other,
            },
            new CommerceTelephone() {
                Telephone = "(236) 274-2445",
                Type = CommerceTelephoneType.Mobile,
            },
        },
        UpdatedAt = System.DateTime.Parse("2024-04-10T02:11:56.405Z").ToUniversalTime(),
        WebUrl = "https://chilly-edge.info",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Commerce.PatchCommerceLocationAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [PatchCommerceLocationRequest](../../Models/Requests/PatchCommerceLocationRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[PatchCommerceLocationResponse](../../Models/Requests/PatchCommerceLocationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchCommerceReservation

Update a reservation

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchCommerceReservation" method="patch" path="/commerce/{connection_id}/reservation/{id}" example="commerce_reservation" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchCommerceReservationRequest req = new PatchCommerceReservationRequest() {
    CommerceReservation = new CommerceReservation() {
        CreatedAt = System.DateTime.Parse("2021-12-14T19:50:31.151Z").ToUniversalTime(),
        EndAt = System.DateTime.Parse("2022-01-01T22:00:17.868Z").ToUniversalTime(),
        GuestEmail = "Sunny.Strosin77@yahoo.com",
        GuestName = "Annette Franecki",
        GuestPhone = "(990) 317-6213",
        Id = "afcf36a7-6459-4407-9636-ad56dad0f927",
        ItemName = "Practical Ceramic Shoes",
        Notes = "Adsum textilis ipsum despecto.",
        Size = 10D,
        StaffName = "Vickie Fahey",
        StartAt = System.DateTime.Parse("2021-12-18T00:40:25.125Z").ToUniversalTime(),
        Status = CommerceReservationStatus.Pending,
        UpdatedAt = System.DateTime.Parse("2022-12-28T03:41:32.988Z").ToUniversalTime(),
        Url = "https://cluttered-pine.info/",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Commerce.PatchCommerceReservationAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [PatchCommerceReservationRequest](../../Models/Requests/PatchCommerceReservationRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[PatchCommerceReservationResponse](../../Models/Requests/PatchCommerceReservationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchCommerceReview

Update a review

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchCommerceReview" method="patch" path="/commerce/{connection_id}/review/{id}" example="commerce_review" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchCommerceReviewRequest req = new PatchCommerceReviewRequest() {
    CommerceReview = new CommerceReview() {
        AuthorAvatarUrl = "https://picsum.photos/seed/ix4Br3LA/2245/1245",
        AuthorEmail = "Cleve_Yundt@hotmail.com",
        AuthorLocation = "ipsum",
        AuthorName = "Marsha Krajcik",
        Comments = new List<CommerceReviewComment>() {},
        Content = "Taedium thymum adipiscor amicitia cui.",
        CreatedAt = System.DateTime.Parse("2019-12-12T18:10:22.988Z").ToUniversalTime(),
        HelpfulVotes = 26D,
        Id = "cc156c3d-aa2d-44cf-9992-4fa5c4c0f372",
        IsFeatured = true,
        IsPublic = true,
        IsVerified = false,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Adulescens.",
                Height = 519D,
                Id = "77ba1c0f-fa17-4294-b08f-24ae70569ec5",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "a6ee37d2-4184-4053-923d-9492b16b237a",
                        Slug = "aggero",
                        Value = CommerceMetadataValue.CreateStr(
                            "tero"
                        ),
                    },
                },
                Position = 72D,
                Type = CommerceItemMediaType.Video,
                Url = "https://loremflickr.com/882/1004?lock=7448492654002422",
                Width = 75D,
            },
            new CommerceItemMedia() {
                Alt = "Pauci timidus sol comburo thema.",
                Height = 297D,
                Id = "c35af65d-f1e8-4817-bd17-341bf7ef807c",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "0196b59d-9e72-41ea-ae54-8f016c627134",
                        Slug = "vito",
                        Value = CommerceMetadataValue.CreateStr(
                            "cuppedia"
                        ),
                    },
                },
                Position = 61D,
                Type = CommerceItemMediaType.Image,
                Url = "https://picsum.photos/seed/3QDZ8/1208/2171",
                Width = 96D,
            },
            new CommerceItemMedia() {
                Alt = "Cuppedia vestrum patruus.",
                Height = 6D,
                Id = "26f98d09-7364-40c6-b407-5e1a61c85f5c",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "fa0fe730-5ea4-4189-8771-c0386520b053",
                        Slug = "arbitro",
                        Value = CommerceMetadataValue.CreateStr(
                            "villa"
                        ),
                    },
                },
                Position = 60D,
                Type = CommerceItemMediaType.Video,
                Url = "https://picsum.photos/seed/ytybC/2616/710",
                Width = 74D,
            },
        },
        Metadata = new List<CommerceMetadata>() {},
        Rating = 3D,
        Status = CommerceReviewStatus.Approved,
        Title = "Coepi adamo amicitia auxilium toties.",
        UnhelpfulVotes = 49D,
        UpdatedAt = System.DateTime.Parse("2025-07-26T15:20:28.837Z").ToUniversalTime(),
        Url = "https://excitable-underneath.com",
        VerifiedPurchase = false,
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Commerce.PatchCommerceReviewAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [PatchCommerceReviewRequest](../../Models/Requests/PatchCommerceReviewRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[PatchCommerceReviewResponse](../../Models/Requests/PatchCommerceReviewResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchCommerceSaleschannel

Update a saleschannel

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchCommerceSaleschannel" method="patch" path="/commerce/{connection_id}/saleschannel/{id}" example="commerce_saleschannel" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchCommerceSaleschannelRequest req = new PatchCommerceSaleschannelRequest() {
    CommerceSaleschannel = new CommerceSaleschannel() {
        Collections = new List<CommerceReference>() {},
        CreatedAt = System.DateTime.Parse("2021-12-12T06:19:55.421Z").ToUniversalTime(),
        Description = "Utroque denuncio solutio.",
        Id = "a142494f-b2d2-4b02-b1f4-e57389588a45",
        IsActive = false,
        Slug = "amiculum-congregatio-suspendo",
        UpdatedAt = System.DateTime.Parse("2025-01-08T00:50:31.643Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Commerce.PatchCommerceSaleschannelAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [PatchCommerceSaleschannelRequest](../../Models/Requests/PatchCommerceSaleschannelRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[PatchCommerceSaleschannelResponse](../../Models/Requests/PatchCommerceSaleschannelResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveCommerceCollection

Remove a collection

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeCommerceCollection" method="delete" path="/commerce/{connection_id}/collection/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Commerce.RemoveCommerceCollectionAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Collection |

### Response

**[RemoveCommerceCollectionResponse](../../Models/Requests/RemoveCommerceCollectionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveCommerceInventory

Remove an inventory

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeCommerceInventory" method="delete" path="/commerce/{connection_id}/inventory/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Commerce.RemoveCommerceInventoryAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Inventory  |

### Response

**[RemoveCommerceInventoryResponse](../../Models/Requests/RemoveCommerceInventoryResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveCommerceItem

Remove an item

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeCommerceItem" method="delete" path="/commerce/{connection_id}/item/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Commerce.RemoveCommerceItemAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Item       |

### Response

**[RemoveCommerceItemResponse](../../Models/Requests/RemoveCommerceItemResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveCommerceItemvariant

Remove an itemvariant

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeCommerceItemvariant" method="delete" path="/commerce/{connection_id}/itemvariant/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Commerce.RemoveCommerceItemvariantAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter             | Type                  | Required              | Description           |
| --------------------- | --------------------- | --------------------- | --------------------- |
| `ConnectionId`        | *string*              | :heavy_check_mark:    | ID of the connection  |
| `Id`                  | *string*              | :heavy_check_mark:    | ID of the Itemvariant |

### Response

**[RemoveCommerceItemvariantResponse](../../Models/Requests/RemoveCommerceItemvariantResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveCommerceLocation

Remove a location

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeCommerceLocation" method="delete" path="/commerce/{connection_id}/location/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Commerce.RemoveCommerceLocationAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Location   |

### Response

**[RemoveCommerceLocationResponse](../../Models/Requests/RemoveCommerceLocationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveCommerceReservation

Remove a reservation

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeCommerceReservation" method="delete" path="/commerce/{connection_id}/reservation/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Commerce.RemoveCommerceReservationAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter             | Type                  | Required              | Description           |
| --------------------- | --------------------- | --------------------- | --------------------- |
| `ConnectionId`        | *string*              | :heavy_check_mark:    | ID of the connection  |
| `Id`                  | *string*              | :heavy_check_mark:    | ID of the Reservation |

### Response

**[RemoveCommerceReservationResponse](../../Models/Requests/RemoveCommerceReservationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveCommerceReview

Remove a review

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeCommerceReview" method="delete" path="/commerce/{connection_id}/review/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Commerce.RemoveCommerceReviewAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Review     |

### Response

**[RemoveCommerceReviewResponse](../../Models/Requests/RemoveCommerceReviewResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveCommerceSaleschannel

Remove a saleschannel

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeCommerceSaleschannel" method="delete" path="/commerce/{connection_id}/saleschannel/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Commerce.RemoveCommerceSaleschannelAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter              | Type                   | Required               | Description            |
| ---------------------- | ---------------------- | ---------------------- | ---------------------- |
| `ConnectionId`         | *string*               | :heavy_check_mark:     | ID of the connection   |
| `Id`                   | *string*               | :heavy_check_mark:     | ID of the Saleschannel |

### Response

**[RemoveCommerceSaleschannelResponse](../../Models/Requests/RemoveCommerceSaleschannelResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateCommerceCollection

Update a collection

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateCommerceCollection" method="put" path="/commerce/{connection_id}/collection/{id}" example="commerce_collection" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateCommerceCollectionRequest req = new UpdateCommerceCollectionRequest() {
    CommerceCollection = new CommerceCollection() {
        CreatedAt = System.DateTime.Parse("2023-07-14T00:42:54.742Z").ToUniversalTime(),
        Description = "The Integrated leading edge website Cheese offers reliable performance and productive design",
        Id = "9c00543a-bbe5-439f-9e79-3faea46af46f",
        IsActive = true,
        IsFeatured = false,
        IsVisible = false,
        ItemMetadata = new List<CommerceMetadata>() {},
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Defungo adopto thorax.",
                Height = 759D,
                Id = "f0be7d32-6ad4-46fb-9105-9167bc7e9aa2",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "626e7eb5-1a9c-46e9-be53-523f248efed7",
                        Slug = "censura",
                        Value = CommerceMetadataValue.CreateStr(
                            "toties"
                        ),
                    },
                },
                Position = 80D,
                Type = CommerceItemMediaType.Video,
                Url = "https://loremflickr.com/1319/1257?lock=7280448425732025",
                Width = 40D,
            },
        },
        Metadata = new List<CommerceMetadata>() {
            new CommerceMetadata() {
                Id = "88abded1-be10-42ea-a0dd-7a9813d5d126",
                Slug = "aetas",
                Value = CommerceMetadataValue.CreateStr(
                    "consuasor"
                ),
            },
        },
        Name = "Small Marble Chips",
        PublicDescription = "Generic Gloves designed with Cotton for miserable performance",
        PublicName = "Small Marble Chips",
        Tags = new List<string>() {
            "ambulo",
            "adeptio",
            "contego",
        },
        Type = CommerceCollectionType.Collection,
        UpdatedAt = System.DateTime.Parse("2025-02-27T05:36:17.220Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Commerce.UpdateCommerceCollectionAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [UpdateCommerceCollectionRequest](../../Models/Requests/UpdateCommerceCollectionRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[UpdateCommerceCollectionResponse](../../Models/Requests/UpdateCommerceCollectionResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateCommerceInventory

Update an inventory

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateCommerceInventory" method="put" path="/commerce/{connection_id}/inventory/{id}" example="commerce_inventory" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateCommerceInventoryRequest req = new UpdateCommerceInventoryRequest() {
    CommerceInventory = new CommerceInventory() {
        Available = 337D,
        UpdatedAt = System.DateTime.Parse("2025-10-26T10:30:53.952Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Commerce.UpdateCommerceInventoryAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [UpdateCommerceInventoryRequest](../../Models/Requests/UpdateCommerceInventoryRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[UpdateCommerceInventoryResponse](../../Models/Requests/UpdateCommerceInventoryResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateCommerceItem

Update an item

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateCommerceItem" method="put" path="/commerce/{connection_id}/item/{id}" example="commerce_item" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateCommerceItemRequest req = new UpdateCommerceItemRequest() {
    CommerceItem = new CommerceItem() {
        Collections = new List<CommerceReference>() {},
        CreatedAt = System.DateTime.Parse("2019-06-21T20:16:18.628Z").ToUniversalTime(),
        Description = "Vulnero ustulo abeo.",
        Duration = 87D,
        GlobalCode = "calamitas",
        Id = "39f0112a-7ef3-42f6-9c7d-db1995c23982",
        IsActive = false,
        IsFeatured = true,
        IsTaxable = true,
        IsVisible = true,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Caterva eveniet acies candidus.",
                Height = 663D,
                Id = "7d0fc7bd-1973-4cb9-aa31-39c8e8b4c7e8",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "cfd67087-d64a-4579-8276-c3f59e321672",
                        Slug = "doloremque",
                        Value = CommerceMetadataValue.CreateStr(
                            "allatus"
                        ),
                    },
                },
                Position = 67D,
                Type = CommerceItemMediaType.Video,
                Url = "https://picsum.photos/seed/73y0uzyK/972/3753",
                Width = 88D,
            },
            new CommerceItemMedia() {
                Alt = "Comedo.",
                Height = 189D,
                Id = "be9da297-83f2-454e-b508-c392c2382653",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "54d64983-78be-4bcb-bf42-e814c9d5154f",
                        Slug = "bis",
                        Value = CommerceMetadataValue.CreateStr(
                            "somniculosus"
                        ),
                    },
                },
                Position = 3D,
                Type = CommerceItemMediaType.Image,
                Url = "https://picsum.photos/seed/Ao4iatfO/771/3906",
                Width = 66D,
            },
        },
        Metadata = new List<CommerceMetadata>() {
            new CommerceMetadata() {
                ExtraData = CommerceMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = CommerceMetadataFormat.Text,
                Id = "f1cc3521-fb88-4deb-b85d-a3d6387a8c25",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CommerceMetadataValue.CreateStr(
                    "terebro"
                ),
            },
        },
        Name = "Handcrafted Rubber Tuna",
        Prices = new List<CommerceItemPrice>() {
            new CommerceItemPrice() {
                CompareAtPrice = 474D,
                Currency = "OMR",
                Price = 1438D,
            },
        },
        PublicDescription = "Custodia ventus solio compono.",
        PublicName = "Handcrafted Rubber Tuna",
        RequiresShipping = true,
        Slug = "cohors-turba-optio",
        Tags = new List<string>() {
            "blanditiis",
            "tandem",
        },
        TotalStock = 579D,
        Type = "beatae",
        UpdatedAt = System.DateTime.Parse("2022-04-07T13:13:57.351Z").ToUniversalTime(),
        VendorName = "Mayer - Flatley",
        Weight = 22D,
        WeightUnit = WeightUnit.Kg,
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Commerce.UpdateCommerceItemAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [UpdateCommerceItemRequest](../../Models/Requests/UpdateCommerceItemRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[UpdateCommerceItemResponse](../../Models/Requests/UpdateCommerceItemResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateCommerceItemvariant

Update an itemvariant

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateCommerceItemvariant" method="put" path="/commerce/{connection_id}/itemvariant/{id}" example="commerce_itemvariant" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateCommerceItemvariantRequest req = new UpdateCommerceItemvariantRequest() {
    CommerceItemvariant = new CommerceItemvariant() {
        AvailableAt = System.DateTime.Parse("2022-02-02T16:10:33.503Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2022-01-20T13:49:12.968Z").ToUniversalTime(),
        Description = "Featuring Helium-enhanced technology, our Chips offers unparalleled helpful performance",
        Height = 52D,
        Id = "6f515b17-328e-45ee-a657-e05c6bdb72e9",
        IsActive = false,
        IsFeatured = false,
        IsVisible = false,
        Length = 94D,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Calcar delibero cursim summisse.",
                Height = 394D,
                Id = "89315ea1-b677-4fd8-acf9-dce7c7489c52",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "bc20fcd4-3aac-409a-9c5e-5f6ebbc78672",
                        Slug = "illo",
                        Value = CommerceMetadataValue.CreateStr(
                            "quia"
                        ),
                    },
                },
                Position = 92D,
                Type = CommerceItemMediaType.Image,
                Url = "https://picsum.photos/seed/u0YdHqlRu/2007/3208",
                Width = 54D,
            },
            new CommerceItemMedia() {
                Alt = "Civitas acies substantia tergo.",
                Height = 351D,
                Id = "7567ebac-69c9-45f3-a90b-75ce9acc2631",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "1c4ecc59-dfb5-4173-bece-6ff43b1bb4f5",
                        Slug = "libero",
                        Value = CommerceMetadataValue.CreateStr(
                            "capitulus"
                        ),
                    },
                },
                Position = 44D,
                Type = CommerceItemMediaType.Image,
                Url = "https://loremflickr.com/2230/1237?lock=8628070842159966",
                Width = 55D,
            },
        },
        Metadata = new List<CommerceMetadata>() {
            new CommerceMetadata() {
                ExtraData = CommerceMetadataExtraData.CreateMapOfAny(
                    new Dictionary<string, object>() {
                        { "display_name", "Custom Property" },
                    }
                ),
                Format = CommerceMetadataFormat.Text,
                Id = "6690aed5-488f-4fd4-bdca-8d106f689412",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CommerceMetadataValue.CreateStr(
                    "nihil"
                ),
            },
        },
        Name = "Keyboard",
        Options = new List<CommerceItemOption>() {
            new CommerceItemOption() {
                Id = "b1b10799-0ced-4ec4-ae9e-67b141b79e8d",
                Name = "Steel",
                Position = 97D,
                Values = new List<string>() {
                    "Granite",
                    "Plastic",
                },
            },
        },
        Prices = new List<CommerceItemPrice>() {
            new CommerceItemPrice() {
                CompareAtPrice = 3745D,
                Currency = "COP",
                Price = 4913D,
            },
            new CommerceItemPrice() {
                CompareAtPrice = 438D,
                Currency = "PHP",
                Price = 1378D,
            },
            new CommerceItemPrice() {
                CompareAtPrice = 1614D,
                Currency = "PHP",
                Price = 8702D,
            },
        },
        PublicDescription = "Stylish Soap designed to make you stand out with insistent looks",
        PublicName = "Keyboard",
        RequiresShipping = false,
        SizeUnit = SizeUnit.Cm,
        Sku = "978-0-7051-0955-0",
        Tags = new List<string>() {
            "vomito",
            "custodia",
        },
        TotalStock = 929D,
        UpdatedAt = System.DateTime.Parse("2025-05-25T20:21:18.929Z").ToUniversalTime(),
        Weight = 61D,
        WeightUnit = CommerceItemvariantWeightUnit.Oz,
        Width = 26D,
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Commerce.UpdateCommerceItemvariantAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [UpdateCommerceItemvariantRequest](../../Models/Requests/UpdateCommerceItemvariantRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[UpdateCommerceItemvariantResponse](../../Models/Requests/UpdateCommerceItemvariantResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateCommerceLocation

Update a location

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateCommerceLocation" method="put" path="/commerce/{connection_id}/location/{id}" example="commerce_location" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateCommerceLocationRequest req = new UpdateCommerceLocationRequest() {
    CommerceLocation = new CommerceLocation() {
        Address = new PropertyCommerceLocationAddress() {
            Address1 = "29896 The Limes",
            City = "New Kenny",
            CountryCode = "US",
            PostalCode = "14490-0609",
            Region = "Virginia",
            RegionCode = "MS",
        },
        Categories = new List<string>() {},
        CreatedAt = System.DateTime.Parse("2022-12-29T04:15:21.195Z").ToUniversalTime(),
        Currency = "XCD",
        Description = "Adsidue audentia.",
        Id = "da2769e5-8e7f-4b54-8c27-59c767fd326d",
        ImageUrl = "https://picsum.photos/seed/hjFt1/1036/2220",
        IsActive = false,
        LanguageLocale = "vulgaris",
        Latitude = 0D,
        LocationType = LocationType.Restaurant,
        Longitude = 0D,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Addo.",
                Height = 283D,
                Id = "18b3164c-e194-456b-851c-de45c4470726",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "bc6f8f10-df9f-49b2-a8d8-2fed537c4ff5",
                        Slug = "abutor",
                        Value = CommerceMetadataValue.CreateStr(
                            "damno"
                        ),
                    },
                },
                Position = 40D,
                Type = CommerceItemMediaType.Image,
                Url = "https://picsum.photos/seed/QVh7ViTV/3964/1567",
                Width = 1D,
            },
        },
        Name = "Olson - Mraz",
        PriceLevel = "",
        Rating = 0D,
        ReviewCount = 0D,
        Telephones = new List<CommerceTelephone>() {
            new CommerceTelephone() {
                Telephone = "(872) 522-3201",
                Type = CommerceTelephoneType.Other,
            },
            new CommerceTelephone() {
                Telephone = "(236) 274-2445",
                Type = CommerceTelephoneType.Mobile,
            },
        },
        UpdatedAt = System.DateTime.Parse("2024-04-10T02:11:56.405Z").ToUniversalTime(),
        WebUrl = "https://chilly-edge.info",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Commerce.UpdateCommerceLocationAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [UpdateCommerceLocationRequest](../../Models/Requests/UpdateCommerceLocationRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[UpdateCommerceLocationResponse](../../Models/Requests/UpdateCommerceLocationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateCommerceReservation

Update a reservation

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateCommerceReservation" method="put" path="/commerce/{connection_id}/reservation/{id}" example="commerce_reservation" -->
```csharp
using System;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateCommerceReservationRequest req = new UpdateCommerceReservationRequest() {
    CommerceReservation = new CommerceReservation() {
        CreatedAt = System.DateTime.Parse("2021-12-14T19:50:31.151Z").ToUniversalTime(),
        EndAt = System.DateTime.Parse("2022-01-01T22:00:17.868Z").ToUniversalTime(),
        GuestEmail = "Sunny.Strosin77@yahoo.com",
        GuestName = "Annette Franecki",
        GuestPhone = "(990) 317-6213",
        Id = "afcf36a7-6459-4407-9636-ad56dad0f927",
        ItemName = "Practical Ceramic Shoes",
        Notes = "Adsum textilis ipsum despecto.",
        Size = 10D,
        StaffName = "Vickie Fahey",
        StartAt = System.DateTime.Parse("2021-12-18T00:40:25.125Z").ToUniversalTime(),
        Status = CommerceReservationStatus.Pending,
        UpdatedAt = System.DateTime.Parse("2022-12-28T03:41:32.988Z").ToUniversalTime(),
        Url = "https://cluttered-pine.info/",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Commerce.UpdateCommerceReservationAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [UpdateCommerceReservationRequest](../../Models/Requests/UpdateCommerceReservationRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[UpdateCommerceReservationResponse](../../Models/Requests/UpdateCommerceReservationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateCommerceReview

Update a review

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateCommerceReview" method="put" path="/commerce/{connection_id}/review/{id}" example="commerce_review" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateCommerceReviewRequest req = new UpdateCommerceReviewRequest() {
    CommerceReview = new CommerceReview() {
        AuthorAvatarUrl = "https://picsum.photos/seed/ix4Br3LA/2245/1245",
        AuthorEmail = "Cleve_Yundt@hotmail.com",
        AuthorLocation = "ipsum",
        AuthorName = "Marsha Krajcik",
        Comments = new List<CommerceReviewComment>() {},
        Content = "Taedium thymum adipiscor amicitia cui.",
        CreatedAt = System.DateTime.Parse("2019-12-12T18:10:22.988Z").ToUniversalTime(),
        HelpfulVotes = 26D,
        Id = "cc156c3d-aa2d-44cf-9992-4fa5c4c0f372",
        IsFeatured = true,
        IsPublic = true,
        IsVerified = false,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Adulescens.",
                Height = 519D,
                Id = "77ba1c0f-fa17-4294-b08f-24ae70569ec5",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "a6ee37d2-4184-4053-923d-9492b16b237a",
                        Slug = "aggero",
                        Value = CommerceMetadataValue.CreateStr(
                            "tero"
                        ),
                    },
                },
                Position = 72D,
                Type = CommerceItemMediaType.Video,
                Url = "https://loremflickr.com/882/1004?lock=7448492654002422",
                Width = 75D,
            },
            new CommerceItemMedia() {
                Alt = "Pauci timidus sol comburo thema.",
                Height = 297D,
                Id = "c35af65d-f1e8-4817-bd17-341bf7ef807c",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "0196b59d-9e72-41ea-ae54-8f016c627134",
                        Slug = "vito",
                        Value = CommerceMetadataValue.CreateStr(
                            "cuppedia"
                        ),
                    },
                },
                Position = 61D,
                Type = CommerceItemMediaType.Image,
                Url = "https://picsum.photos/seed/3QDZ8/1208/2171",
                Width = 96D,
            },
            new CommerceItemMedia() {
                Alt = "Cuppedia vestrum patruus.",
                Height = 6D,
                Id = "26f98d09-7364-40c6-b407-5e1a61c85f5c",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "fa0fe730-5ea4-4189-8771-c0386520b053",
                        Slug = "arbitro",
                        Value = CommerceMetadataValue.CreateStr(
                            "villa"
                        ),
                    },
                },
                Position = 60D,
                Type = CommerceItemMediaType.Video,
                Url = "https://picsum.photos/seed/ytybC/2616/710",
                Width = 74D,
            },
        },
        Metadata = new List<CommerceMetadata>() {},
        Rating = 3D,
        Status = CommerceReviewStatus.Approved,
        Title = "Coepi adamo amicitia auxilium toties.",
        UnhelpfulVotes = 49D,
        UpdatedAt = System.DateTime.Parse("2025-07-26T15:20:28.837Z").ToUniversalTime(),
        Url = "https://excitable-underneath.com",
        VerifiedPurchase = false,
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Commerce.UpdateCommerceReviewAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [UpdateCommerceReviewRequest](../../Models/Requests/UpdateCommerceReviewRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[UpdateCommerceReviewResponse](../../Models/Requests/UpdateCommerceReviewResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateCommerceSaleschannel

Update a saleschannel

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateCommerceSaleschannel" method="put" path="/commerce/{connection_id}/saleschannel/{id}" example="commerce_saleschannel" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateCommerceSaleschannelRequest req = new UpdateCommerceSaleschannelRequest() {
    CommerceSaleschannel = new CommerceSaleschannel() {
        Collections = new List<CommerceReference>() {},
        CreatedAt = System.DateTime.Parse("2021-12-12T06:19:55.421Z").ToUniversalTime(),
        Description = "Utroque denuncio solutio.",
        Id = "a142494f-b2d2-4b02-b1f4-e57389588a45",
        IsActive = false,
        Slug = "amiculum-congregatio-suspendo",
        UpdatedAt = System.DateTime.Parse("2025-01-08T00:50:31.643Z").ToUniversalTime(),
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Commerce.UpdateCommerceSaleschannelAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [UpdateCommerceSaleschannelRequest](../../Models/Requests/UpdateCommerceSaleschannelRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[UpdateCommerceSaleschannelResponse](../../Models/Requests/UpdateCommerceSaleschannelResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |