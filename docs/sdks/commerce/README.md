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
        Id = "20ee005f-5b3f-4b9f-9d87-b78ef3dd581e",
        IsActive = true,
        IsFeatured = false,
        IsVisible = false,
        ItemMetadata = new List<CommerceMetadata>() {},
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Defungo adopto thorax.",
                Height = 759D,
                Id = "cb19d902-35a8-4d9f-be3a-c7d6c523612d",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "57111a46-7009-4a57-9254-5f0887cc3c19",
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
                Id = "bb3af542-4a7e-4c44-9dd6-c67f585b1515",
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
        UpdatedAt = System.DateTime.Parse("2025-03-16T12:13:51.034Z").ToUniversalTime(),
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
        Id = "604b295d-b649-4e7b-a72c-97fc4d4adaa1",
        Metadata = new List<CommerceMetadata>() {},
        UpdatedAt = System.DateTime.Parse("2025-11-22T16:56:02.624Z").ToUniversalTime(),
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
        Id = "9cd7b1f6-640e-4066-aed5-bf503eac4778",
        IsActive = false,
        IsFeatured = false,
        IsTaxable = true,
        IsVisible = true,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Caterva eveniet acies candidus.",
                Height = 876D,
                Id = "36b70497-1b81-427b-8ac4-ff16f791be01",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "676cda5e-f328-444d-9367-1f990a1c97b7",
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
                Id = "08bbe206-b5d3-411a-9cc5-1f42c2c550ee",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "c89888b9-b723-4819-a554-24d8d1511ea1",
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
                Id = "f21d0053-fa47-4a3f-b83d-9090d51bd07b",
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
        UpdatedAt = System.DateTime.Parse("2022-04-20T14:24:18.321Z").ToUniversalTime(),
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
        Id = "479d0582-4a21-4eed-93da-9df5cd453d6e",
        IsActive = true,
        IsFeatured = false,
        IsVisible = false,
        Length = 92D,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Hic desipio thorax.",
                Height = 961D,
                Id = "dd3260a3-4e76-4409-a2a0-fb4e2fe9d76a",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "a0d870d1-0434-4690-85e2-25a4db55e6ac",
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
                Id = "be9806e2-b81f-4b39-ba02-4987ae2e7715",
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
                Id = "b8a52bb4-97a3-4aa1-b200-885ecf3d8c96",
                Name = "Color",
                Position = 1D,
                Values = new List<string>() {
                    "olive",
                },
            },
            new CommerceItemOption() {
                Id = "f367b538-2957-405a-9b22-0df3bb0a5645",
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
        UpdatedAt = System.DateTime.Parse("2026-03-12T03:52:18.068Z").ToUniversalTime(),
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
        Id = "164958b8-2467-456d-ad50-398f9688b584",
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
                Id = "e26d460b-dbb5-48d1-b68c-8f68705f2ea4",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "d82aa5bd-c643-4a3a-bf26-90763007290d",
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
        UpdatedAt = System.DateTime.Parse("2024-04-21T17:28:16.076Z").ToUniversalTime(),
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
        Id = "ade21a07-4ea1-4fb9-9330-80238143da50",
        Metadata = new List<CommerceMetadata>() {},
        Notes = "Adsum textilis ipsum despecto.",
        Size = 10D,
        StartAt = System.DateTime.Parse("2021-12-18T00:40:25.125Z").ToUniversalTime(),
        Status = CommerceReservationStatus.Pending,
        UpdatedAt = System.DateTime.Parse("2023-01-04T12:16:15.047Z").ToUniversalTime(),
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
        Id = "52f5009e-6ea7-48a8-a0f8-4264731efe7a",
        IsFeatured = false,
        IsPublic = true,
        IsVerified = false,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Desipio carpo sol laudantium colo.",
                Height = 749D,
                Id = "7d9d9e89-0c5b-435c-ab36-0ea9c425e2c7",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "214fdebb-fe70-482b-9c12-d1bdea6fcc9a",
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
                Id = "9f6e8875-0e98-4602-adb9-5c281ed4d63b",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "e6beb4de-af7b-48c0-9254-cc155c298d92",
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
        UpdatedAt = System.DateTime.Parse("2025-08-23T17:29:44.616Z").ToUniversalTime(),
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
        Id = "b73f6041-a4cd-434e-a27a-2a29082a58f1",
        IsActive = false,
        Metadata = new List<CommerceMetadata>() {},
        Slug = "amiculum-congregatio-suspendo",
        UpdatedAt = System.DateTime.Parse("2025-01-29T20:06:27.554Z").ToUniversalTime(),
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
        Id = "ed6230c6-13a2-4ea8-aaca-c3c32b82b4bc",
        IsActive = true,
        IsFeatured = false,
        IsVisible = false,
        ItemMetadata = new List<CommerceMetadata>() {},
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Defungo adopto thorax.",
                Height = 759D,
                Id = "8824b5df-07e5-4af1-a4cc-8e7222f85193",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "4b1c925b-daa4-467f-a9fe-1b7133119e0e",
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
                Id = "6e8cc3a0-ba1d-4dcc-b99e-a8db10a2c1dd",
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
        UpdatedAt = System.DateTime.Parse("2025-03-16T12:13:51.052Z").ToUniversalTime(),
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
        Id = "f106b650-e789-4043-ae63-bd893c9b9f61",
        Metadata = new List<CommerceMetadata>() {},
        UpdatedAt = System.DateTime.Parse("2025-11-22T16:56:02.635Z").ToUniversalTime(),
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
        Id = "4e90d428-afb8-4214-bb07-d525b68c6117",
        IsActive = false,
        IsFeatured = false,
        IsTaxable = true,
        IsVisible = true,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Caterva eveniet acies candidus.",
                Height = 876D,
                Id = "4710531f-607c-431c-b4c9-352c64fc51d6",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "959c10eb-8b29-4c0d-8332-9ae213880645",
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
                Id = "4760c377-99bc-4cd8-bcf7-c2dfda207bb7",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "72cfc1a4-88e1-49d0-8ada-89c07db382d2",
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
                Id = "59a81611-a3a0-44c4-a650-a5e7f0d834e9",
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
        UpdatedAt = System.DateTime.Parse("2022-04-20T14:24:18.337Z").ToUniversalTime(),
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
        Id = "6511ac2c-c336-4817-8a9c-ccbfb34c223c",
        IsActive = true,
        IsFeatured = false,
        IsVisible = false,
        Length = 92D,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Hic desipio thorax.",
                Height = 961D,
                Id = "c6b4c055-489f-4e5b-84ba-524acd34f752",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "f4fd8ab7-2974-45fa-b5cb-f556405ba45f",
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
                Id = "37a06c50-12db-474f-a62a-dbc772fe917a",
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
                Id = "032e1489-2912-43f4-afaf-763506c3d4a7",
                Name = "Color",
                Position = 1D,
                Values = new List<string>() {
                    "olive",
                },
            },
            new CommerceItemOption() {
                Id = "a368c328-36a5-4f38-a50f-03ff4c8c0304",
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
        UpdatedAt = System.DateTime.Parse("2026-03-12T03:52:18.102Z").ToUniversalTime(),
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
        Id = "5bf31e9f-42c2-41b5-b991-5281cf2cff79",
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
                Id = "b874d961-7fcc-48f3-885a-173ab141354c",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "aa387d23-e49a-43e2-84ad-6381f4ee3ba5",
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
        UpdatedAt = System.DateTime.Parse("2024-04-21T17:28:16.085Z").ToUniversalTime(),
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
        Id = "d8ae8631-91ca-489e-8749-8cdbb76d1022",
        Metadata = new List<CommerceMetadata>() {},
        Notes = "Adsum textilis ipsum despecto.",
        Size = 10D,
        StartAt = System.DateTime.Parse("2021-12-18T00:40:25.125Z").ToUniversalTime(),
        Status = CommerceReservationStatus.Pending,
        UpdatedAt = System.DateTime.Parse("2023-01-04T12:16:15.051Z").ToUniversalTime(),
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
        Id = "9cfd618e-e75c-4b42-bc03-ffda8a9ec9d3",
        IsFeatured = false,
        IsPublic = true,
        IsVerified = false,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Desipio carpo sol laudantium colo.",
                Height = 749D,
                Id = "1b5a2e71-e433-49f8-94e3-731e004f1d6b",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "5927adbd-3e99-404f-aae2-bd5731ac68ba",
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
                Id = "83cb43aa-73d5-48b4-9750-cb4dd635a72d",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "69eeaebf-6e21-4fd8-aaed-4fd5eed4b0da",
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
        UpdatedAt = System.DateTime.Parse("2025-08-23T17:29:44.655Z").ToUniversalTime(),
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
        Id = "3cc2d9c7-9531-4508-a592-456f908b0597",
        IsActive = false,
        Metadata = new List<CommerceMetadata>() {},
        Slug = "amiculum-congregatio-suspendo",
        UpdatedAt = System.DateTime.Parse("2025-01-29T20:06:27.563Z").ToUniversalTime(),
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
        Id = "ed6230c6-13a2-4ea8-aaca-c3c32b82b4bc",
        IsActive = true,
        IsFeatured = false,
        IsVisible = false,
        ItemMetadata = new List<CommerceMetadata>() {},
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Defungo adopto thorax.",
                Height = 759D,
                Id = "8824b5df-07e5-4af1-a4cc-8e7222f85193",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "4b1c925b-daa4-467f-a9fe-1b7133119e0e",
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
                Id = "6e8cc3a0-ba1d-4dcc-b99e-a8db10a2c1dd",
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
        UpdatedAt = System.DateTime.Parse("2025-03-16T12:13:51.052Z").ToUniversalTime(),
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
        Id = "f106b650-e789-4043-ae63-bd893c9b9f61",
        Metadata = new List<CommerceMetadata>() {},
        UpdatedAt = System.DateTime.Parse("2025-11-22T16:56:02.635Z").ToUniversalTime(),
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
        Id = "4e90d428-afb8-4214-bb07-d525b68c6117",
        IsActive = false,
        IsFeatured = false,
        IsTaxable = true,
        IsVisible = true,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Caterva eveniet acies candidus.",
                Height = 876D,
                Id = "4710531f-607c-431c-b4c9-352c64fc51d6",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "959c10eb-8b29-4c0d-8332-9ae213880645",
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
                Id = "4760c377-99bc-4cd8-bcf7-c2dfda207bb7",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "72cfc1a4-88e1-49d0-8ada-89c07db382d2",
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
                Id = "59a81611-a3a0-44c4-a650-a5e7f0d834e9",
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
        UpdatedAt = System.DateTime.Parse("2022-04-20T14:24:18.337Z").ToUniversalTime(),
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
        Id = "6511ac2c-c336-4817-8a9c-ccbfb34c223c",
        IsActive = true,
        IsFeatured = false,
        IsVisible = false,
        Length = 92D,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Hic desipio thorax.",
                Height = 961D,
                Id = "c6b4c055-489f-4e5b-84ba-524acd34f752",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "f4fd8ab7-2974-45fa-b5cb-f556405ba45f",
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
                Id = "37a06c50-12db-474f-a62a-dbc772fe917a",
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
                Id = "032e1489-2912-43f4-afaf-763506c3d4a7",
                Name = "Color",
                Position = 1D,
                Values = new List<string>() {
                    "olive",
                },
            },
            new CommerceItemOption() {
                Id = "a368c328-36a5-4f38-a50f-03ff4c8c0304",
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
        UpdatedAt = System.DateTime.Parse("2026-03-12T03:52:18.102Z").ToUniversalTime(),
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
        Id = "5bf31e9f-42c2-41b5-b991-5281cf2cff79",
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
                Id = "b874d961-7fcc-48f3-885a-173ab141354c",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "aa387d23-e49a-43e2-84ad-6381f4ee3ba5",
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
        UpdatedAt = System.DateTime.Parse("2024-04-21T17:28:16.085Z").ToUniversalTime(),
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
        Id = "d8ae8631-91ca-489e-8749-8cdbb76d1022",
        Metadata = new List<CommerceMetadata>() {},
        Notes = "Adsum textilis ipsum despecto.",
        Size = 10D,
        StartAt = System.DateTime.Parse("2021-12-18T00:40:25.125Z").ToUniversalTime(),
        Status = CommerceReservationStatus.Pending,
        UpdatedAt = System.DateTime.Parse("2023-01-04T12:16:15.051Z").ToUniversalTime(),
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
        Id = "9cfd618e-e75c-4b42-bc03-ffda8a9ec9d3",
        IsFeatured = false,
        IsPublic = true,
        IsVerified = false,
        Media = new List<CommerceItemMedia>() {
            new CommerceItemMedia() {
                Alt = "Desipio carpo sol laudantium colo.",
                Height = 749D,
                Id = "1b5a2e71-e433-49f8-94e3-731e004f1d6b",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "5927adbd-3e99-404f-aae2-bd5731ac68ba",
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
                Id = "83cb43aa-73d5-48b4-9750-cb4dd635a72d",
                Metadata = new List<CommerceMetadata>() {
                    new CommerceMetadata() {
                        Id = "69eeaebf-6e21-4fd8-aaed-4fd5eed4b0da",
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
        UpdatedAt = System.DateTime.Parse("2025-08-23T17:29:44.655Z").ToUniversalTime(),
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
        Id = "3cc2d9c7-9531-4508-a592-456f908b0597",
        IsActive = false,
        Metadata = new List<CommerceMetadata>() {},
        Slug = "amiculum-congregatio-suspendo",
        UpdatedAt = System.DateTime.Parse("2025-01-29T20:06:27.563Z").ToUniversalTime(),
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