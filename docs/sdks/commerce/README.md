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

Creates a CommerceCollection. Provide the unified CommerceCollection fields in the request body; they are mapped to the provider's API. Returns the created CommerceCollection.

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
        Id = "ca15de12-cfc0-4461-bc9d-ec096395d653",
        IsActive = true,
        IsFeatured = false,
        IsVisible = false,
        ItemMetadata = new List<CommerceMetadata>() {},
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Defungo adopto thorax.",
                Height = 759D,
                Id = "c94e64ff-8463-4941-b48e-722f3109b02b",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "301c9d0b-f2b6-479b-80e7-6bdd6c9a6829",
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
                Id = "edc821bd-d857-42a0-b07e-11985a3a4348",
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
        UpdatedAt = System.DateTime.Parse("2025-03-15T12:28:56.456Z").ToUniversalTime(),
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

Creates a CommerceInventory. Provide the unified CommerceInventory fields in the request body; they are mapped to the provider's API. Returns the created CommerceInventory.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createCommerceInventory" method="post" path="/commerce/{connection_id}/inventory" example="commerce_inventory" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Commerce.CreateCommerceInventoryAsync(
    commerceInventory: new CommerceInventory() {
        Available = 337D,
        Id = "5b222ad4-ba39-44fe-83dc-13ae9f26b85e",
        Metadata = new List<CommerceMetadata>() {},
        UpdatedAt = System.DateTime.Parse("2025-11-21T03:27:03.491Z").ToUniversalTime(),
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

Creates a CommerceItem. Provide the unified CommerceItem fields in the request body; they are mapped to the provider's API. Returns the created CommerceItem.

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
        Description = "Decretum vulnero ustulo abeo.",
        Duration = 104D,
        GlobalCode = "978-0-85270-680-0",
        Id = "27a08bc0-d226-41e4-a946-ffddca45602b",
        IsActive = false,
        IsFeatured = false,
        IsTaxable = true,
        IsVisible = true,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Caterva eveniet acies candidus.",
                Height = 876D,
                Id = "d967cd4c-9783-4219-9236-b4826c2c33bd",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "1624b79a-3b65-465b-9df0-c5ed62d40390",
                        Slug = "doloremque",
                        Value = CommerceMetadataValue.CreateStr(
                            "allatus"
                        ),
                    },
                },
                Position = 21D,
                Type = CommerceItemMediaType.Video,
                Url = "https://picsum.photos/seed/v73y0uzyK/3001/972",
                Width = 67D,
            },
            new CommerceItemMedia() {
                Alt = "Comedo.",
                Height = 651D,
                Id = "abe2df2f-9b25-4206-9ad2-b9294f53672c",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "47694ae6-f3fb-47f6-a38b-26092c05e8ad",
                        Slug = "bis",
                        Value = CommerceMetadataValue.CreateStr(
                            "somniculosus"
                        ),
                    },
                },
                Position = 51D,
                Type = CommerceItemMediaType.Image,
                Url = "https://picsum.photos/seed/Ao4iatfO/771/3906",
                Width = 3D,
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
                Id = "66b5bea7-52e6-46fa-8ab2-bb4b54d6f3ed",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CommerceMetadataValue.CreateStr(
                    "abstergo"
                ),
            },
        },
        Name = "Handcrafted Rubber Tuna",
        Prices = new List<CommerceItemPrice>() {
            new CommerceItemPrice() {
                Currency = "USD",
                Price = 78.11D,
            },
        },
        PublicDescription = "Custodia ventus solio compono.",
        PublicName = "Handcrafted Rubber Tuna",
        RequiresShipping = true,
        Slug = "handcrafted-rubber-tuna",
        Tags = new List<string>() {
            "beatae",
            "blanditiis",
        },
        TotalStock = 682D,
        Type = "SERVICE",
        UpdatedAt = System.DateTime.Parse("2022-04-19T20:28:03.147Z").ToUniversalTime(),
        VendorName = "Mayer - Flatley",
        Weight = 37D,
        WeightUnit = WeightUnit.Oz,
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

Creates a CommerceItemvariant. Provide the unified CommerceItemvariant fields in the request body; they are mapped to the provider's API. Returns the created CommerceItemvariant.

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
        AvailableAt = System.DateTime.Parse("2022-02-06T18:14:41.644Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2022-01-20T13:49:12.968Z").ToUniversalTime(),
        Description = "Stylish Salad designed to make you stand out with little looks",
        Height = 54D,
        Id = "fd424e9e-eac4-4c01-bbbb-e2b259873405",
        IsActive = true,
        IsFeatured = false,
        IsVisible = false,
        Length = 92D,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Hic desipio thorax.",
                Height = 961D,
                Id = "3dc055f7-60f3-4d81-8d89-4c2653c99f23",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "ebaad0ce-dc74-4b28-8dc8-c226c21aadf7",
                        Slug = "ubi",
                        Value = CommerceMetadataValue.CreateStr(
                            "textus"
                        ),
                    },
                },
                Position = 72D,
                Type = CommerceItemMediaType.Image,
                Url = "https://loremflickr.com/2126/721?lock=8820088623807162",
                Width = 35D,
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
                Id = "d77713c3-e2c9-4170-ac56-0a7ea65026b1",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CommerceMetadataValue.CreateStr(
                    "absens"
                ),
            },
        },
        Name = "Chair",
        Options = new List<CommerceItemOption>() {
            new CommerceItemOption() {
                Id = "38fe8804-f4da-497d-820b-43cc2ab3bb72",
                Name = "Color",
                Position = 1D,
                Values = new List<string>() {
                    "olive",
                },
            },
            new CommerceItemOption() {
                Id = "9697bdb7-5b96-44eb-af8c-b9a37b67e5db",
                Name = "Size",
                Position = 2D,
                Values = new List<string>() {
                    "S",
                },
            },
        },
        Prices = new List<CommerceItemPrice>() {
            new CommerceItemPrice() {
                Currency = "USD",
                Price = 382.23D,
            },
        },
        PublicDescription = "Stylish Cheese designed to make you stand out with grave looks",
        PublicName = "Chair",
        RequiresShipping = false,
        SizeUnit = SizeUnit.Cm,
        Sku = "978-1-368-44270-1",
        Tags = new List<string>() {
            "deserunt",
        },
        TotalStock = 436D,
        UpdatedAt = System.DateTime.Parse("2026-03-10T11:23:40.854Z").ToUniversalTime(),
        Weight = 46D,
        WeightUnit = CommerceItemvariantWeightUnit.Oz,
        Width = 40D,
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

Creates a CommerceLocation. Provide the unified CommerceLocation fields in the request body; they are mapped to the provider's API. Returns the created CommerceLocation.

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
        Id = "b419563d-7f1a-46dc-8eae-8afcc9949d6f",
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
                Id = "881070fb-822c-4609-a556-03568bf39235",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "44205a33-c72d-4407-8b7c-d422619f3b3e",
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
        Metadata = new List<CommerceMetadata>() {},
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
        UpdatedAt = System.DateTime.Parse("2024-04-21T01:28:31.052Z").ToUniversalTime(),
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

Creates a CommerceReservation. Provide the unified CommerceReservation fields in the request body; they are mapped to the provider's API. Returns the created CommerceReservation.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createCommerceReservation" method="post" path="/commerce/{connection_id}/reservation" example="commerce_reservation" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Commerce.CreateCommerceReservationAsync(
    commerceReservation: new CommerceReservation() {
        CreatedAt = System.DateTime.Parse("2021-12-14T19:50:31.151Z").ToUniversalTime(),
        EndAt = System.DateTime.Parse("2022-01-01T22:00:17.868Z").ToUniversalTime(),
        GuestEmail = "julien.bartoletti@icloud.com",
        GuestName = "Julien Bartoletti",
        GuestPhone = "(728) 596-2620",
        Id = "10115731-9f33-4a2a-8754-4f90a5b17097",
        Metadata = new List<CommerceMetadata>() {},
        Notes = "Adsum textilis ipsum despecto.",
        Size = 10D,
        StartAt = System.DateTime.Parse("2021-12-18T00:40:25.125Z").ToUniversalTime(),
        Status = CommerceReservationStatus.Pending,
        UpdatedAt = System.DateTime.Parse("2023-01-04T02:09:25.157Z").ToUniversalTime(),
        Url = "https://expensive-gift.org",
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

Creates a CommerceReview. Provide the unified CommerceReview fields in the request body; they are mapped to the provider's API. Returns the created CommerceReview.

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
        AuthorAvatarUrl = "https://loremflickr.com/7/2660?lock=4279109054086693",
        AuthorEmail = "nyasia.macgyver@hotmail.com",
        AuthorLocation = "denique",
        AuthorName = "Nyasia MacGyver",
        Comments = new List<CommerceReviewComment>() {},
        Content = "Taedium thymum adipiscor amicitia cui.",
        CreatedAt = System.DateTime.Parse("2019-12-12T18:10:22.988Z").ToUniversalTime(),
        HelpfulVotes = 66D,
        Id = "ad927503-77ec-412f-b1fc-ce3f15a18f34",
        IsFeatured = false,
        IsPublic = true,
        IsVerified = false,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Desipio carpo sol laudantium colo.",
                Height = 749D,
                Id = "dce20d29-5cb6-49fa-884d-b1bf6f5ca8b2",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "590c834f-caa6-46b7-a126-85e7845c92b3",
                        Slug = "textor",
                        Value = CommerceMetadataValue.CreateStr(
                            "quos"
                        ),
                    },
                },
                Position = 29D,
                Type = CommerceItemMediaType.Video,
                Url = "https://loremflickr.com/196/2041?lock=5845524773114807",
                Width = 72D,
            },
            new CommerceItemMedia() {
                Alt = "Adopto teneo numquam.",
                Height = 957D,
                Id = "af386662-f95e-4ac1-92bc-8e2b0cfd3454",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "b4d6ddc0-5f0b-4126-94df-a4515e377662",
                        Slug = "bos",
                        Value = CommerceMetadataValue.CreateStr(
                            "casso"
                        ),
                    },
                },
                Position = 69D,
                Type = CommerceItemMediaType.Image,
                Url = "https://loremflickr.com/1178/2175?lock=5466640101053206",
                Width = 61D,
            },
        },
        Metadata = new List<CommerceMetadata>() {},
        Rating = 3D,
        Status = CommerceReviewStatus.Approved,
        Title = "Coepi adamo amicitia auxilium toties.",
        UnhelpfulVotes = 88D,
        UpdatedAt = System.DateTime.Parse("2025-08-22T02:52:56.147Z").ToUniversalTime(),
        Url = "https://diligent-bandwidth.biz",
        VerifiedPurchase = true,
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

Creates a CommerceSaleschannel. Provide the unified CommerceSaleschannel fields in the request body; they are mapped to the provider's API. Returns the created CommerceSaleschannel.

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
        Id = "d2d2997a-39d8-4b5d-bf5b-4775b960f1cc",
        IsActive = false,
        Metadata = new List<CommerceMetadata>() {},
        Slug = "amiculum-congregatio-suspendo",
        UpdatedAt = System.DateTime.Parse("2025-01-28T14:08:11.879Z").ToUniversalTime(),
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

Retrieves a single CommerceCollection by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Retrieves a single CommerceInventory by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Retrieves a single CommerceItem by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Retrieves a single CommerceItemvariant by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Retrieves a single CommerceLocation by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Retrieves a single CommerceReservation by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Retrieves a single CommerceReview by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Retrieves a single CommerceSaleschannel by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Returns a list of CommerceAvailabilities. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Returns a list of CommerceCollections. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Returns a list of CommerceInventories. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Returns a list of CommerceItems. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Returns a list of CommerceItemvariants. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Returns a list of CommerceLocations. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Returns a list of CommerceReservations. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Returns a list of CommerceReviews. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Returns a list of CommerceSaleschannels. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Updates the CommerceCollection identified by `id`. Provide the unified CommerceCollection fields to change in the request body.

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
        Id = "d8b2a3ff-41f5-4dca-bfef-b17025d08ea5",
        IsActive = true,
        IsFeatured = false,
        IsVisible = false,
        ItemMetadata = new List<CommerceMetadata>() {},
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Defungo adopto thorax.",
                Height = 759D,
                Id = "951328d3-e511-4aaa-b232-1a68c4b24773",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "34b8df44-b231-44b8-80f6-137f1fa9d775",
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
                Id = "084dff93-84ff-43b1-88b9-22bc7b617537",
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
        UpdatedAt = System.DateTime.Parse("2025-03-15T12:28:56.475Z").ToUniversalTime(),
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

Updates the CommerceInventory identified by `id`. Provide the unified CommerceInventory fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchCommerceInventory" method="patch" path="/commerce/{connection_id}/inventory/{id}" example="commerce_inventory" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchCommerceInventoryRequest req = new PatchCommerceInventoryRequest() {
    CommerceInventory = new CommerceInventory() {
        Available = 337D,
        Id = "efd77c10-8d9b-4209-80e6-262a36c769ce",
        Metadata = new List<CommerceMetadata>() {},
        UpdatedAt = System.DateTime.Parse("2025-11-21T03:27:03.503Z").ToUniversalTime(),
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

Updates the CommerceItem identified by `id`. Provide the unified CommerceItem fields to change in the request body.

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
        Description = "Decretum vulnero ustulo abeo.",
        Duration = 104D,
        GlobalCode = "978-0-85270-680-0",
        Id = "72942384-a5e5-4427-8380-a6530866f52d",
        IsActive = false,
        IsFeatured = false,
        IsTaxable = true,
        IsVisible = true,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Caterva eveniet acies candidus.",
                Height = 876D,
                Id = "7b725666-cdd3-4d0d-b7c7-ef2c66770786",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "c2c30809-2967-4c40-975a-06c65aaf4b2d",
                        Slug = "doloremque",
                        Value = CommerceMetadataValue.CreateStr(
                            "allatus"
                        ),
                    },
                },
                Position = 21D,
                Type = CommerceItemMediaType.Video,
                Url = "https://picsum.photos/seed/v73y0uzyK/3001/972",
                Width = 67D,
            },
            new CommerceItemMedia() {
                Alt = "Comedo.",
                Height = 651D,
                Id = "546b5fac-4bfe-4d89-988b-737d882cdb0d",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "c934a36c-0ea3-4904-878a-f23b0f1776d5",
                        Slug = "bis",
                        Value = CommerceMetadataValue.CreateStr(
                            "somniculosus"
                        ),
                    },
                },
                Position = 51D,
                Type = CommerceItemMediaType.Image,
                Url = "https://picsum.photos/seed/Ao4iatfO/771/3906",
                Width = 3D,
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
                Id = "837957fb-838f-48e4-a434-e62695010966",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CommerceMetadataValue.CreateStr(
                    "abstergo"
                ),
            },
        },
        Name = "Handcrafted Rubber Tuna",
        Prices = new List<CommerceItemPrice>() {
            new CommerceItemPrice() {
                Currency = "USD",
                Price = 78.11D,
            },
        },
        PublicDescription = "Custodia ventus solio compono.",
        PublicName = "Handcrafted Rubber Tuna",
        RequiresShipping = true,
        Slug = "handcrafted-rubber-tuna",
        Tags = new List<string>() {
            "beatae",
            "blanditiis",
        },
        TotalStock = 682D,
        Type = "SERVICE",
        UpdatedAt = System.DateTime.Parse("2022-04-19T20:28:03.163Z").ToUniversalTime(),
        VendorName = "Mayer - Flatley",
        Weight = 37D,
        WeightUnit = WeightUnit.Oz,
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

Updates the CommerceItemvariant identified by `id`. Provide the unified CommerceItemvariant fields to change in the request body.

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
        AvailableAt = System.DateTime.Parse("2022-02-06T18:14:41.644Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2022-01-20T13:49:12.968Z").ToUniversalTime(),
        Description = "Stylish Salad designed to make you stand out with little looks",
        Height = 54D,
        Id = "c6ab1753-14e2-4592-b97b-9a45185d380f",
        IsActive = true,
        IsFeatured = false,
        IsVisible = false,
        Length = 92D,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Hic desipio thorax.",
                Height = 961D,
                Id = "d7ff097c-fae0-4c70-91cf-233535f49113",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "72681c6e-72fa-4426-8c14-483c9f0cffa0",
                        Slug = "ubi",
                        Value = CommerceMetadataValue.CreateStr(
                            "textus"
                        ),
                    },
                },
                Position = 72D,
                Type = CommerceItemMediaType.Image,
                Url = "https://loremflickr.com/2126/721?lock=8820088623807162",
                Width = 35D,
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
                Id = "7b5a161f-5df2-4a56-83d5-6ced157a1faa",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CommerceMetadataValue.CreateStr(
                    "absens"
                ),
            },
        },
        Name = "Chair",
        Options = new List<CommerceItemOption>() {
            new CommerceItemOption() {
                Id = "cf6bb4cd-1be3-428f-ae18-9f230a6f6405",
                Name = "Color",
                Position = 1D,
                Values = new List<string>() {
                    "olive",
                },
            },
            new CommerceItemOption() {
                Id = "ee820778-ce70-413b-b3d6-9a7a4e7103f3",
                Name = "Size",
                Position = 2D,
                Values = new List<string>() {
                    "S",
                },
            },
        },
        Prices = new List<CommerceItemPrice>() {
            new CommerceItemPrice() {
                Currency = "USD",
                Price = 382.23D,
            },
        },
        PublicDescription = "Stylish Cheese designed to make you stand out with grave looks",
        PublicName = "Chair",
        RequiresShipping = false,
        SizeUnit = SizeUnit.Cm,
        Sku = "978-1-368-44270-1",
        Tags = new List<string>() {
            "deserunt",
        },
        TotalStock = 436D,
        UpdatedAt = System.DateTime.Parse("2026-03-10T11:23:40.888Z").ToUniversalTime(),
        Weight = 46D,
        WeightUnit = CommerceItemvariantWeightUnit.Oz,
        Width = 40D,
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

Updates the CommerceLocation identified by `id`. Provide the unified CommerceLocation fields to change in the request body.

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
        Id = "6fbb2092-4f06-447b-b341-5d74d16391e6",
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
                Id = "8cfe5bae-d748-4c60-841d-55e6cf068f20",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "e1c649fd-059e-418f-8b02-fdc93c484597",
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
        Metadata = new List<CommerceMetadata>() {},
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
        UpdatedAt = System.DateTime.Parse("2024-04-21T01:28:31.067Z").ToUniversalTime(),
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

Updates the CommerceReservation identified by `id`. Provide the unified CommerceReservation fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchCommerceReservation" method="patch" path="/commerce/{connection_id}/reservation/{id}" example="commerce_reservation" -->
```csharp
using System;
using System.Collections.Generic;
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
        GuestEmail = "julien.bartoletti@icloud.com",
        GuestName = "Julien Bartoletti",
        GuestPhone = "(728) 596-2620",
        Id = "372b582d-ffec-4aaa-b2f1-feb78713408d",
        Metadata = new List<CommerceMetadata>() {},
        Notes = "Adsum textilis ipsum despecto.",
        Size = 10D,
        StartAt = System.DateTime.Parse("2021-12-18T00:40:25.125Z").ToUniversalTime(),
        Status = CommerceReservationStatus.Pending,
        UpdatedAt = System.DateTime.Parse("2023-01-04T02:09:25.162Z").ToUniversalTime(),
        Url = "https://expensive-gift.org",
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

Updates the CommerceReview identified by `id`. Provide the unified CommerceReview fields to change in the request body.

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
        AuthorAvatarUrl = "https://loremflickr.com/7/2660?lock=4279109054086693",
        AuthorEmail = "nyasia.macgyver@hotmail.com",
        AuthorLocation = "denique",
        AuthorName = "Nyasia MacGyver",
        Comments = new List<CommerceReviewComment>() {},
        Content = "Taedium thymum adipiscor amicitia cui.",
        CreatedAt = System.DateTime.Parse("2019-12-12T18:10:22.988Z").ToUniversalTime(),
        HelpfulVotes = 66D,
        Id = "1cb1cb86-0065-4cdd-9277-ed721eed30a9",
        IsFeatured = false,
        IsPublic = true,
        IsVerified = false,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Desipio carpo sol laudantium colo.",
                Height = 749D,
                Id = "f9e24a7d-2944-4a65-9037-8dc7c693c332",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "6ec856df-44a0-4744-8fe7-f6ae92be771f",
                        Slug = "textor",
                        Value = CommerceMetadataValue.CreateStr(
                            "quos"
                        ),
                    },
                },
                Position = 29D,
                Type = CommerceItemMediaType.Video,
                Url = "https://loremflickr.com/196/2041?lock=5845524773114807",
                Width = 72D,
            },
            new CommerceItemMedia() {
                Alt = "Adopto teneo numquam.",
                Height = 957D,
                Id = "74d94876-cdae-4e86-b083-dab58cbb61ac",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "d452af00-1e42-41e5-9a58-32c47145b3ff",
                        Slug = "bos",
                        Value = CommerceMetadataValue.CreateStr(
                            "casso"
                        ),
                    },
                },
                Position = 69D,
                Type = CommerceItemMediaType.Image,
                Url = "https://loremflickr.com/1178/2175?lock=5466640101053206",
                Width = 61D,
            },
        },
        Metadata = new List<CommerceMetadata>() {},
        Rating = 3D,
        Status = CommerceReviewStatus.Approved,
        Title = "Coepi adamo amicitia auxilium toties.",
        UnhelpfulVotes = 88D,
        UpdatedAt = System.DateTime.Parse("2025-08-22T02:52:56.185Z").ToUniversalTime(),
        Url = "https://diligent-bandwidth.biz",
        VerifiedPurchase = true,
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

Updates the CommerceSaleschannel identified by `id`. Provide the unified CommerceSaleschannel fields to change in the request body.

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
        Id = "8e488829-1e13-40fc-809e-7ed91429070f",
        IsActive = false,
        Metadata = new List<CommerceMetadata>() {},
        Slug = "amiculum-congregatio-suspendo",
        UpdatedAt = System.DateTime.Parse("2025-01-28T14:08:11.890Z").ToUniversalTime(),
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

Deletes the CommerceCollection identified by `id`.

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

Deletes the CommerceInventory identified by `id`.

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

Deletes the CommerceItem identified by `id`.

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

Deletes the CommerceItemvariant identified by `id`.

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

Deletes the CommerceLocation identified by `id`.

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

Deletes the CommerceReservation identified by `id`.

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

Deletes the CommerceReview identified by `id`.

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

Deletes the CommerceSaleschannel identified by `id`.

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

Updates the CommerceCollection identified by `id`. Provide the unified CommerceCollection fields to change in the request body.

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
        Id = "d8b2a3ff-41f5-4dca-bfef-b17025d08ea5",
        IsActive = true,
        IsFeatured = false,
        IsVisible = false,
        ItemMetadata = new List<CommerceMetadata>() {},
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Defungo adopto thorax.",
                Height = 759D,
                Id = "951328d3-e511-4aaa-b232-1a68c4b24773",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "34b8df44-b231-44b8-80f6-137f1fa9d775",
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
                Id = "084dff93-84ff-43b1-88b9-22bc7b617537",
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
        UpdatedAt = System.DateTime.Parse("2025-03-15T12:28:56.475Z").ToUniversalTime(),
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

Updates the CommerceInventory identified by `id`. Provide the unified CommerceInventory fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateCommerceInventory" method="put" path="/commerce/{connection_id}/inventory/{id}" example="commerce_inventory" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateCommerceInventoryRequest req = new UpdateCommerceInventoryRequest() {
    CommerceInventory = new CommerceInventory() {
        Available = 337D,
        Id = "efd77c10-8d9b-4209-80e6-262a36c769ce",
        Metadata = new List<CommerceMetadata>() {},
        UpdatedAt = System.DateTime.Parse("2025-11-21T03:27:03.503Z").ToUniversalTime(),
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

Updates the CommerceItem identified by `id`. Provide the unified CommerceItem fields to change in the request body.

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
        Description = "Decretum vulnero ustulo abeo.",
        Duration = 104D,
        GlobalCode = "978-0-85270-680-0",
        Id = "72942384-a5e5-4427-8380-a6530866f52d",
        IsActive = false,
        IsFeatured = false,
        IsTaxable = true,
        IsVisible = true,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Caterva eveniet acies candidus.",
                Height = 876D,
                Id = "7b725666-cdd3-4d0d-b7c7-ef2c66770786",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "c2c30809-2967-4c40-975a-06c65aaf4b2d",
                        Slug = "doloremque",
                        Value = CommerceMetadataValue.CreateStr(
                            "allatus"
                        ),
                    },
                },
                Position = 21D,
                Type = CommerceItemMediaType.Video,
                Url = "https://picsum.photos/seed/v73y0uzyK/3001/972",
                Width = 67D,
            },
            new CommerceItemMedia() {
                Alt = "Comedo.",
                Height = 651D,
                Id = "546b5fac-4bfe-4d89-988b-737d882cdb0d",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "c934a36c-0ea3-4904-878a-f23b0f1776d5",
                        Slug = "bis",
                        Value = CommerceMetadataValue.CreateStr(
                            "somniculosus"
                        ),
                    },
                },
                Position = 51D,
                Type = CommerceItemMediaType.Image,
                Url = "https://picsum.photos/seed/Ao4iatfO/771/3906",
                Width = 3D,
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
                Id = "837957fb-838f-48e4-a434-e62695010966",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CommerceMetadataValue.CreateStr(
                    "abstergo"
                ),
            },
        },
        Name = "Handcrafted Rubber Tuna",
        Prices = new List<CommerceItemPrice>() {
            new CommerceItemPrice() {
                Currency = "USD",
                Price = 78.11D,
            },
        },
        PublicDescription = "Custodia ventus solio compono.",
        PublicName = "Handcrafted Rubber Tuna",
        RequiresShipping = true,
        Slug = "handcrafted-rubber-tuna",
        Tags = new List<string>() {
            "beatae",
            "blanditiis",
        },
        TotalStock = 682D,
        Type = "SERVICE",
        UpdatedAt = System.DateTime.Parse("2022-04-19T20:28:03.163Z").ToUniversalTime(),
        VendorName = "Mayer - Flatley",
        Weight = 37D,
        WeightUnit = WeightUnit.Oz,
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

Updates the CommerceItemvariant identified by `id`. Provide the unified CommerceItemvariant fields to change in the request body.

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
        AvailableAt = System.DateTime.Parse("2022-02-06T18:14:41.644Z").ToUniversalTime(),
        CreatedAt = System.DateTime.Parse("2022-01-20T13:49:12.968Z").ToUniversalTime(),
        Description = "Stylish Salad designed to make you stand out with little looks",
        Height = 54D,
        Id = "c6ab1753-14e2-4592-b97b-9a45185d380f",
        IsActive = true,
        IsFeatured = false,
        IsVisible = false,
        Length = 92D,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Hic desipio thorax.",
                Height = 961D,
                Id = "d7ff097c-fae0-4c70-91cf-233535f49113",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "72681c6e-72fa-4426-8c14-483c9f0cffa0",
                        Slug = "ubi",
                        Value = CommerceMetadataValue.CreateStr(
                            "textus"
                        ),
                    },
                },
                Position = 72D,
                Type = CommerceItemMediaType.Image,
                Url = "https://loremflickr.com/2126/721?lock=8820088623807162",
                Width = 35D,
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
                Id = "7b5a161f-5df2-4a56-83d5-6ced157a1faa",
                Namespace = "custom",
                Slug = "custom_property",
                Value = CommerceMetadataValue.CreateStr(
                    "absens"
                ),
            },
        },
        Name = "Chair",
        Options = new List<CommerceItemOption>() {
            new CommerceItemOption() {
                Id = "cf6bb4cd-1be3-428f-ae18-9f230a6f6405",
                Name = "Color",
                Position = 1D,
                Values = new List<string>() {
                    "olive",
                },
            },
            new CommerceItemOption() {
                Id = "ee820778-ce70-413b-b3d6-9a7a4e7103f3",
                Name = "Size",
                Position = 2D,
                Values = new List<string>() {
                    "S",
                },
            },
        },
        Prices = new List<CommerceItemPrice>() {
            new CommerceItemPrice() {
                Currency = "USD",
                Price = 382.23D,
            },
        },
        PublicDescription = "Stylish Cheese designed to make you stand out with grave looks",
        PublicName = "Chair",
        RequiresShipping = false,
        SizeUnit = SizeUnit.Cm,
        Sku = "978-1-368-44270-1",
        Tags = new List<string>() {
            "deserunt",
        },
        TotalStock = 436D,
        UpdatedAt = System.DateTime.Parse("2026-03-10T11:23:40.888Z").ToUniversalTime(),
        Weight = 46D,
        WeightUnit = CommerceItemvariantWeightUnit.Oz,
        Width = 40D,
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

Updates the CommerceLocation identified by `id`. Provide the unified CommerceLocation fields to change in the request body.

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
        Id = "6fbb2092-4f06-447b-b341-5d74d16391e6",
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
                Id = "8cfe5bae-d748-4c60-841d-55e6cf068f20",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "e1c649fd-059e-418f-8b02-fdc93c484597",
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
        Metadata = new List<CommerceMetadata>() {},
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
        UpdatedAt = System.DateTime.Parse("2024-04-21T01:28:31.067Z").ToUniversalTime(),
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

Updates the CommerceReservation identified by `id`. Provide the unified CommerceReservation fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateCommerceReservation" method="put" path="/commerce/{connection_id}/reservation/{id}" example="commerce_reservation" -->
```csharp
using System;
using System.Collections.Generic;
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
        GuestEmail = "julien.bartoletti@icloud.com",
        GuestName = "Julien Bartoletti",
        GuestPhone = "(728) 596-2620",
        Id = "372b582d-ffec-4aaa-b2f1-feb78713408d",
        Metadata = new List<CommerceMetadata>() {},
        Notes = "Adsum textilis ipsum despecto.",
        Size = 10D,
        StartAt = System.DateTime.Parse("2021-12-18T00:40:25.125Z").ToUniversalTime(),
        Status = CommerceReservationStatus.Pending,
        UpdatedAt = System.DateTime.Parse("2023-01-04T02:09:25.162Z").ToUniversalTime(),
        Url = "https://expensive-gift.org",
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

Updates the CommerceReview identified by `id`. Provide the unified CommerceReview fields to change in the request body.

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
        AuthorAvatarUrl = "https://loremflickr.com/7/2660?lock=4279109054086693",
        AuthorEmail = "nyasia.macgyver@hotmail.com",
        AuthorLocation = "denique",
        AuthorName = "Nyasia MacGyver",
        Comments = new List<CommerceReviewComment>() {},
        Content = "Taedium thymum adipiscor amicitia cui.",
        CreatedAt = System.DateTime.Parse("2019-12-12T18:10:22.988Z").ToUniversalTime(),
        HelpfulVotes = 66D,
        Id = "1cb1cb86-0065-4cdd-9277-ed721eed30a9",
        IsFeatured = false,
        IsPublic = true,
        IsVerified = false,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Desipio carpo sol laudantium colo.",
                Height = 749D,
                Id = "f9e24a7d-2944-4a65-9037-8dc7c693c332",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "6ec856df-44a0-4744-8fe7-f6ae92be771f",
                        Slug = "textor",
                        Value = CommerceMetadataValue.CreateStr(
                            "quos"
                        ),
                    },
                },
                Position = 29D,
                Type = CommerceItemMediaType.Video,
                Url = "https://loremflickr.com/196/2041?lock=5845524773114807",
                Width = 72D,
            },
            new CommerceItemMedia() {
                Alt = "Adopto teneo numquam.",
                Height = 957D,
                Id = "74d94876-cdae-4e86-b083-dab58cbb61ac",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "d452af00-1e42-41e5-9a58-32c47145b3ff",
                        Slug = "bos",
                        Value = CommerceMetadataValue.CreateStr(
                            "casso"
                        ),
                    },
                },
                Position = 69D,
                Type = CommerceItemMediaType.Image,
                Url = "https://loremflickr.com/1178/2175?lock=5466640101053206",
                Width = 61D,
            },
        },
        Metadata = new List<CommerceMetadata>() {},
        Rating = 3D,
        Status = CommerceReviewStatus.Approved,
        Title = "Coepi adamo amicitia auxilium toties.",
        UnhelpfulVotes = 88D,
        UpdatedAt = System.DateTime.Parse("2025-08-22T02:52:56.185Z").ToUniversalTime(),
        Url = "https://diligent-bandwidth.biz",
        VerifiedPurchase = true,
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

Updates the CommerceSaleschannel identified by `id`. Provide the unified CommerceSaleschannel fields to change in the request body.

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
        Id = "8e488829-1e13-40fc-809e-7ed91429070f",
        IsActive = false,
        Metadata = new List<CommerceMetadata>() {},
        Slug = "amiculum-congregatio-suspendo",
        UpdatedAt = System.DateTime.Parse("2025-01-28T14:08:11.890Z").ToUniversalTime(),
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