# Link

## Overview

### Available Operations

* [CreateCalendarLink](#createcalendarlink) - Create a link
* [CreatePaymentLink](#createpaymentlink) - Create a link
* [GetCalendarLink](#getcalendarlink) - Retrieve a link
* [GetPaymentLink](#getpaymentlink) - Retrieve a link
* [ListCalendarLinks](#listcalendarlinks) - List all links
* [ListPaymentLinks](#listpaymentlinks) - List all links
* [PatchCalendarLink](#patchcalendarlink) - Update a link
* [PatchPaymentLink](#patchpaymentlink) - Update a link
* [RemoveCalendarLink](#removecalendarlink) - Remove a link
* [RemovePaymentLink](#removepaymentlink) - Remove a link
* [UpdateCalendarLink](#updatecalendarlink) - Update a link
* [UpdatePaymentLink](#updatepaymentlink) - Update a link

## CreateCalendarLink

Create a link

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createCalendarLink" method="post" path="/calendar/{connection_id}/link" example="calendar_link" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Link.CreateCalendarLinkAsync(
    calendarLink: new CalendarLink() {
        CreatedAt = "2023-03-07T13:34:11.959Z",
        Description = "Vitium clibanus laboriosam uxor denuncio.",
        Duration = 74D,
        Id = "c5ae8a9e-103c-4be8-92b2-99db1b12c3c6",
        IsActive = true,
        Name = "Sopor sopor ancilla animus anser dignissimos vito confero utilis.",
        PriceAmount = 44D,
        PriceCurrency = "USD",
        UpdatedAt = "2024-03-13T19:26:01.923Z",
        Url = "https://annual-apricot.info/",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `CalendarLink`                                                                                                                                   | [CalendarLink](../../Models/Components/CalendarLink.md)                                                                                          | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateCalendarLinkQueryParamFields](../../Models/Requests/CreateCalendarLinkQueryParamFields.md)>                                          | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateCalendarLinkResponse](../../Models/Requests/CreateCalendarLinkResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreatePaymentLink

Create a link

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createPaymentLink" method="post" path="/payment/{connection_id}/link" example="payment_link" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Link.CreatePaymentLinkAsync(
    paymentLink: new PaymentLink() {
        Amount = 81211D,
        CreatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
        Currency = "GYD",
        Description = "Adfero ipsa terreo benevolentia utrum.",
        Id = "fa7b62c9-7717-414f-b53e-9fa1c7c45ab2",
        IsActive = true,
        IsChargeableNow = false,
        Lineitems = new List<PaymentLineitem>() {
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-08-21T00:45:53.202Z").ToUniversalTime(),
                Id = "7e15efd7-1a2e-4534-a7ad-b78c32f7c077",
                ItemDescription = "Experience the white brilliance of our Hat, perfect for aggravating environments",
                ItemName = "Licensed Marble Mouse",
                ItemSku = "TAD4EYLVRI",
                Notes = "Charisma theca video verus conduco attollo cervus decretum viridis.",
                TaxAmount = 221D,
                TotalAmount = 1841D,
                UnitAmount = 270D,
                UnitQuantity = 6D,
                UpdatedAt = System.DateTime.Parse("2023-02-12T17:31:25.507Z").ToUniversalTime(),
            },
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-09-30T05:29:29.258Z").ToUniversalTime(),
                DiscountAmount = 15D,
                Id = "79063d02-f58e-4e4f-998b-6c1f42369354",
                ItemDescription = "New Chicken model with 79 GB RAM, 846 GB storage, and lovely features",
                ItemName = "Intelligent Steel Table",
                ItemSku = "V8HQCDQYUZ",
                TaxAmount = 150D,
                TotalAmount = 2037D,
                UnitAmount = 317D,
                UnitQuantity = 6D,
                UpdatedAt = System.DateTime.Parse("2023-05-31T11:10:09.190Z").ToUniversalTime(),
            },
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-12-16T13:52:52.341Z").ToUniversalTime(),
                Id = "c9da4c92-39d4-48e3-9138-d52a6888d73e",
                ItemDescription = "Dach - Wolff's most advanced Car technology increases dense capabilities",
                ItemName = "Modern Gold Soap",
                ItemSku = "DYGKCTCLDJ",
                TaxAmount = 41D,
                TotalAmount = 281D,
                UnitAmount = 30D,
                UnitQuantity = 8D,
                UpdatedAt = System.DateTime.Parse("2023-05-22T16:35:07.583Z").ToUniversalTime(),
            },
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-08-12T19:45:39.705Z").ToUniversalTime(),
                Id = "496d51c5-3c12-41f0-a625-3a231949667f",
                ItemDescription = "The sleek and unimportant Salad comes with salmon LED lighting for smart functionality",
                ItemName = "Generic Aluminum Ball",
                ItemSku = "BSBAXWAAFF",
                Notes = "Cubo adversus victus subito asperiores vereor cibo tabgo.",
                TaxAmount = 6D,
                TotalAmount = 78D,
                UnitAmount = 24D,
                UnitQuantity = 3D,
                UpdatedAt = System.DateTime.Parse("2023-11-13T12:39:15.951Z").ToUniversalTime(),
            },
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-02-14T06:21:13.641Z").ToUniversalTime(),
                DiscountAmount = 171D,
                Id = "98aaccc4-0a07-4b11-a25d-ec8bc5ccc109",
                ItemDescription = "New Bike model with 29 GB RAM, 271 GB storage, and minty features",
                ItemName = "Incredible Aluminum Chicken",
                ItemSku = "6ERMJK20HE",
                TaxAmount = 263D,
                TotalAmount = 3708D,
                UnitAmount = 452D,
                UnitQuantity = 8D,
                UpdatedAt = System.DateTime.Parse("2023-01-31T21:39:30.894Z").ToUniversalTime(),
            },
        },
        SuccessUrl = "https://parched-kettledrum.com/",
        UpdatedAt = System.DateTime.Parse("2025-12-31T08:57:05.841Z").ToUniversalTime(),
        Url = "https://forceful-laughter.biz/",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `PaymentLink`                                                                                                                                    | [PaymentLink](../../Models/Components/PaymentLink.md)                                                                                            | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreatePaymentLinkQueryParamFields](../../Models/Requests/CreatePaymentLinkQueryParamFields.md)>                                            | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreatePaymentLinkResponse](../../Models/Requests/CreatePaymentLinkResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetCalendarLink

Retrieve a link

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCalendarLink" method="get" path="/calendar/{connection_id}/link/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Link.GetCalendarLinkAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Link                                                                                                                                   |
| `Fields`                                                                                                                                         | List<[GetCalendarLinkQueryParamFields](../../Models/Requests/GetCalendarLinkQueryParamFields.md)>                                                | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetCalendarLinkResponse](../../Models/Requests/GetCalendarLinkResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetPaymentLink

Retrieve a link

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getPaymentLink" method="get" path="/payment/{connection_id}/link/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Link.GetPaymentLinkAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Link                                                                                                                                   |
| `Fields`                                                                                                                                         | List<[GetPaymentLinkQueryParamFields](../../Models/Requests/GetPaymentLinkQueryParamFields.md)>                                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetPaymentLinkResponse](../../Models/Requests/GetPaymentLinkResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListCalendarLinks

List all links

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listCalendarLinks" method="get" path="/calendar/{connection_id}/link" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListCalendarLinksRequest req = new ListCalendarLinksRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Link.ListCalendarLinksAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListCalendarLinksRequest](../../Models/Requests/ListCalendarLinksRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[ListCalendarLinksResponse](../../Models/Requests/ListCalendarLinksResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListPaymentLinks

List all links

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listPaymentLinks" method="get" path="/payment/{connection_id}/link" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListPaymentLinksRequest req = new ListPaymentLinksRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Link.ListPaymentLinksAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListPaymentLinksRequest](../../Models/Requests/ListPaymentLinksRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[ListPaymentLinksResponse](../../Models/Requests/ListPaymentLinksResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchCalendarLink

Update a link

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchCalendarLink" method="patch" path="/calendar/{connection_id}/link/{id}" example="calendar_link" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchCalendarLinkRequest req = new PatchCalendarLinkRequest() {
    CalendarLink = new CalendarLink() {
        CreatedAt = "2023-03-07T13:34:11.959Z",
        Description = "Vitium clibanus laboriosam uxor denuncio.",
        Duration = 74D,
        Id = "fb0ea977-c27a-498b-bf0e-fa49ef6eb99e",
        IsActive = true,
        Name = "Sopor sopor ancilla animus anser dignissimos vito confero utilis.",
        PriceAmount = 44D,
        PriceCurrency = "USD",
        UpdatedAt = "2024-03-13T19:26:01.928Z",
        Url = "https://annual-apricot.info/",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Link.PatchCalendarLinkAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [PatchCalendarLinkRequest](../../Models/Requests/PatchCalendarLinkRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[PatchCalendarLinkResponse](../../Models/Requests/PatchCalendarLinkResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchPaymentLink

Update a link

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchPaymentLink" method="patch" path="/payment/{connection_id}/link/{id}" example="payment_link" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchPaymentLinkRequest req = new PatchPaymentLinkRequest() {
    PaymentLink = new PaymentLink() {
        Amount = 81211D,
        CreatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
        Currency = "GYD",
        Description = "Adfero ipsa terreo benevolentia utrum.",
        Id = "3e82e2db-232b-4d2b-95e5-0767584e5a60",
        IsActive = true,
        IsChargeableNow = false,
        Lineitems = new List<PaymentLineitem>() {
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-08-21T00:45:53.202Z").ToUniversalTime(),
                Id = "600bf101-9794-48a9-be9a-ede6bfe9c7c6",
                ItemDescription = "Experience the white brilliance of our Hat, perfect for aggravating environments",
                ItemName = "Licensed Marble Mouse",
                ItemSku = "TAD4EYLVRI",
                Notes = "Charisma theca video verus conduco attollo cervus decretum viridis.",
                TaxAmount = 221D,
                TotalAmount = 1841D,
                UnitAmount = 270D,
                UnitQuantity = 6D,
                UpdatedAt = System.DateTime.Parse("2023-02-12T17:31:25.507Z").ToUniversalTime(),
            },
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-09-30T05:29:29.258Z").ToUniversalTime(),
                DiscountAmount = 15D,
                Id = "ae6b09c0-36cd-40a8-8d0e-be75194b47fa",
                ItemDescription = "New Chicken model with 79 GB RAM, 846 GB storage, and lovely features",
                ItemName = "Intelligent Steel Table",
                ItemSku = "V8HQCDQYUZ",
                TaxAmount = 150D,
                TotalAmount = 2037D,
                UnitAmount = 317D,
                UnitQuantity = 6D,
                UpdatedAt = System.DateTime.Parse("2023-05-31T11:10:09.190Z").ToUniversalTime(),
            },
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-12-16T13:52:52.341Z").ToUniversalTime(),
                Id = "c26a1322-93df-4d23-8477-5e528d2ba430",
                ItemDescription = "Dach - Wolff's most advanced Car technology increases dense capabilities",
                ItemName = "Modern Gold Soap",
                ItemSku = "DYGKCTCLDJ",
                TaxAmount = 41D,
                TotalAmount = 281D,
                UnitAmount = 30D,
                UnitQuantity = 8D,
                UpdatedAt = System.DateTime.Parse("2023-05-22T16:35:07.583Z").ToUniversalTime(),
            },
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-08-12T19:45:39.705Z").ToUniversalTime(),
                Id = "a1773ef7-e672-4a41-9b1e-f983488c355d",
                ItemDescription = "The sleek and unimportant Salad comes with salmon LED lighting for smart functionality",
                ItemName = "Generic Aluminum Ball",
                ItemSku = "BSBAXWAAFF",
                Notes = "Cubo adversus victus subito asperiores vereor cibo tabgo.",
                TaxAmount = 6D,
                TotalAmount = 78D,
                UnitAmount = 24D,
                UnitQuantity = 3D,
                UpdatedAt = System.DateTime.Parse("2023-11-13T12:39:15.951Z").ToUniversalTime(),
            },
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-02-14T06:21:13.641Z").ToUniversalTime(),
                DiscountAmount = 171D,
                Id = "83e071cd-96c9-47ff-88cc-fec2c04ec516",
                ItemDescription = "New Bike model with 29 GB RAM, 271 GB storage, and minty features",
                ItemName = "Incredible Aluminum Chicken",
                ItemSku = "6ERMJK20HE",
                TaxAmount = 263D,
                TotalAmount = 3708D,
                UnitAmount = 452D,
                UnitQuantity = 8D,
                UpdatedAt = System.DateTime.Parse("2023-01-31T21:39:30.894Z").ToUniversalTime(),
            },
        },
        SuccessUrl = "https://parched-kettledrum.com/",
        UpdatedAt = System.DateTime.Parse("2025-12-31T08:57:05.855Z").ToUniversalTime(),
        Url = "https://forceful-laughter.biz/",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Link.PatchPaymentLinkAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [PatchPaymentLinkRequest](../../Models/Requests/PatchPaymentLinkRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[PatchPaymentLinkResponse](../../Models/Requests/PatchPaymentLinkResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveCalendarLink

Remove a link

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeCalendarLink" method="delete" path="/calendar/{connection_id}/link/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Link.RemoveCalendarLinkAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Link       |

### Response

**[RemoveCalendarLinkResponse](../../Models/Requests/RemoveCalendarLinkResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemovePaymentLink

Remove a link

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removePaymentLink" method="delete" path="/payment/{connection_id}/link/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Link.RemovePaymentLinkAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Link       |

### Response

**[RemovePaymentLinkResponse](../../Models/Requests/RemovePaymentLinkResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateCalendarLink

Update a link

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateCalendarLink" method="put" path="/calendar/{connection_id}/link/{id}" example="calendar_link" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateCalendarLinkRequest req = new UpdateCalendarLinkRequest() {
    CalendarLink = new CalendarLink() {
        CreatedAt = "2023-03-07T13:34:11.959Z",
        Description = "Vitium clibanus laboriosam uxor denuncio.",
        Duration = 74D,
        Id = "fb0ea977-c27a-498b-bf0e-fa49ef6eb99e",
        IsActive = true,
        Name = "Sopor sopor ancilla animus anser dignissimos vito confero utilis.",
        PriceAmount = 44D,
        PriceCurrency = "USD",
        UpdatedAt = "2024-03-13T19:26:01.928Z",
        Url = "https://annual-apricot.info/",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Link.UpdateCalendarLinkAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [UpdateCalendarLinkRequest](../../Models/Requests/UpdateCalendarLinkRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[UpdateCalendarLinkResponse](../../Models/Requests/UpdateCalendarLinkResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdatePaymentLink

Update a link

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updatePaymentLink" method="put" path="/payment/{connection_id}/link/{id}" example="payment_link" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdatePaymentLinkRequest req = new UpdatePaymentLinkRequest() {
    PaymentLink = new PaymentLink() {
        Amount = 81211D,
        CreatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
        Currency = "GYD",
        Description = "Adfero ipsa terreo benevolentia utrum.",
        Id = "3e82e2db-232b-4d2b-95e5-0767584e5a60",
        IsActive = true,
        IsChargeableNow = false,
        Lineitems = new List<PaymentLineitem>() {
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-08-21T00:45:53.202Z").ToUniversalTime(),
                Id = "600bf101-9794-48a9-be9a-ede6bfe9c7c6",
                ItemDescription = "Experience the white brilliance of our Hat, perfect for aggravating environments",
                ItemName = "Licensed Marble Mouse",
                ItemSku = "TAD4EYLVRI",
                Notes = "Charisma theca video verus conduco attollo cervus decretum viridis.",
                TaxAmount = 221D,
                TotalAmount = 1841D,
                UnitAmount = 270D,
                UnitQuantity = 6D,
                UpdatedAt = System.DateTime.Parse("2023-02-12T17:31:25.507Z").ToUniversalTime(),
            },
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-09-30T05:29:29.258Z").ToUniversalTime(),
                DiscountAmount = 15D,
                Id = "ae6b09c0-36cd-40a8-8d0e-be75194b47fa",
                ItemDescription = "New Chicken model with 79 GB RAM, 846 GB storage, and lovely features",
                ItemName = "Intelligent Steel Table",
                ItemSku = "V8HQCDQYUZ",
                TaxAmount = 150D,
                TotalAmount = 2037D,
                UnitAmount = 317D,
                UnitQuantity = 6D,
                UpdatedAt = System.DateTime.Parse("2023-05-31T11:10:09.190Z").ToUniversalTime(),
            },
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-12-16T13:52:52.341Z").ToUniversalTime(),
                Id = "c26a1322-93df-4d23-8477-5e528d2ba430",
                ItemDescription = "Dach - Wolff's most advanced Car technology increases dense capabilities",
                ItemName = "Modern Gold Soap",
                ItemSku = "DYGKCTCLDJ",
                TaxAmount = 41D,
                TotalAmount = 281D,
                UnitAmount = 30D,
                UnitQuantity = 8D,
                UpdatedAt = System.DateTime.Parse("2023-05-22T16:35:07.583Z").ToUniversalTime(),
            },
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-08-12T19:45:39.705Z").ToUniversalTime(),
                Id = "a1773ef7-e672-4a41-9b1e-f983488c355d",
                ItemDescription = "The sleek and unimportant Salad comes with salmon LED lighting for smart functionality",
                ItemName = "Generic Aluminum Ball",
                ItemSku = "BSBAXWAAFF",
                Notes = "Cubo adversus victus subito asperiores vereor cibo tabgo.",
                TaxAmount = 6D,
                TotalAmount = 78D,
                UnitAmount = 24D,
                UnitQuantity = 3D,
                UpdatedAt = System.DateTime.Parse("2023-11-13T12:39:15.951Z").ToUniversalTime(),
            },
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-02-14T06:21:13.641Z").ToUniversalTime(),
                DiscountAmount = 171D,
                Id = "83e071cd-96c9-47ff-88cc-fec2c04ec516",
                ItemDescription = "New Bike model with 29 GB RAM, 271 GB storage, and minty features",
                ItemName = "Incredible Aluminum Chicken",
                ItemSku = "6ERMJK20HE",
                TaxAmount = 263D,
                TotalAmount = 3708D,
                UnitAmount = 452D,
                UnitQuantity = 8D,
                UpdatedAt = System.DateTime.Parse("2023-01-31T21:39:30.894Z").ToUniversalTime(),
            },
        },
        SuccessUrl = "https://parched-kettledrum.com/",
        UpdatedAt = System.DateTime.Parse("2025-12-31T08:57:05.855Z").ToUniversalTime(),
        Url = "https://forceful-laughter.biz/",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Link.UpdatePaymentLinkAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [UpdatePaymentLinkRequest](../../Models/Requests/UpdatePaymentLinkRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[UpdatePaymentLinkResponse](../../Models/Requests/UpdatePaymentLinkResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |