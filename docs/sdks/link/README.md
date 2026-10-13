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
        Id = "af18eb5b-403a-4464-bef3-0202cf0f83fe",
        IsActive = true,
        Name = "Sopor sopor ancilla animus anser dignissimos vito confero utilis.",
        PriceAmount = 44D,
        PriceCurrency = "USD",
        UpdatedAt = "2024-03-13T04:32:56.298Z",
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
        Id = "c57d34e5-41ab-483c-b2ba-f11b4699476c",
        IsActive = true,
        IsChargeableNow = false,
        Lineitems = new List<PaymentLineitem>() {
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-08-21T00:45:53.202Z").ToUniversalTime(),
                Id = "c6809b95-d35e-49fb-8f12-b96c3cee50f8",
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
                Id = "def48795-ab99-4823-9f20-97182470bf21",
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
                Id = "61e39547-2769-4a0d-8144-8abbe4314f32",
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
                Id = "f457a210-cdcf-4184-a2ec-e0092730e17f",
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
                Id = "e054d9c5-7588-4bf8-9c83-779a5f3fc525",
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
        UpdatedAt = System.DateTime.Parse("2025-12-29T16:36:24.634Z").ToUniversalTime(),
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
        Id = "06188a5b-5866-4521-b2a6-7f7226ebb6c6",
        IsActive = true,
        Name = "Sopor sopor ancilla animus anser dignissimos vito confero utilis.",
        PriceAmount = 44D,
        PriceCurrency = "USD",
        UpdatedAt = "2024-03-13T04:32:56.300Z",
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
        Id = "9000049b-2d2e-48c7-a4ec-420ffe7de336",
        IsActive = true,
        IsChargeableNow = false,
        Lineitems = new List<PaymentLineitem>() {
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-08-21T00:45:53.202Z").ToUniversalTime(),
                Id = "cabe333a-c004-4546-adec-377afc079ea0",
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
                Id = "2043b319-883d-42a2-b31f-5c3d22c2f0e3",
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
                Id = "ce10203f-34d9-4e82-8c90-44b10e84641d",
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
                Id = "9626ffcc-b4a5-4340-a647-a7b54a86b95c",
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
                Id = "ddd79fbe-c12f-407a-acdc-7395bf970ec7",
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
        UpdatedAt = System.DateTime.Parse("2025-12-29T16:36:24.649Z").ToUniversalTime(),
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
        Id = "06188a5b-5866-4521-b2a6-7f7226ebb6c6",
        IsActive = true,
        Name = "Sopor sopor ancilla animus anser dignissimos vito confero utilis.",
        PriceAmount = 44D,
        PriceCurrency = "USD",
        UpdatedAt = "2024-03-13T04:32:56.300Z",
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
        Id = "9000049b-2d2e-48c7-a4ec-420ffe7de336",
        IsActive = true,
        IsChargeableNow = false,
        Lineitems = new List<PaymentLineitem>() {
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-08-21T00:45:53.202Z").ToUniversalTime(),
                Id = "cabe333a-c004-4546-adec-377afc079ea0",
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
                Id = "2043b319-883d-42a2-b31f-5c3d22c2f0e3",
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
                Id = "ce10203f-34d9-4e82-8c90-44b10e84641d",
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
                Id = "9626ffcc-b4a5-4340-a647-a7b54a86b95c",
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
                Id = "ddd79fbe-c12f-407a-acdc-7395bf970ec7",
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
        UpdatedAt = System.DateTime.Parse("2025-12-29T16:36:24.649Z").ToUniversalTime(),
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