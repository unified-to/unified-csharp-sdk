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
using System.Collections.Generic;
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
        Id = "56f56475-63e4-471b-9756-432fd4fd9a62",
        IsActive = true,
        Metadata = new List<CalendarMetadata>() {},
        Name = "Sopor sopor ancilla animus anser dignissimos vito confero utilis.",
        PriceAmount = 44D,
        PriceCurrency = "USD",
        UpdatedAt = "2024-03-15T13:06:35.491Z",
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
        Amount = 17001.68D,
        CreatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
        Currency = "CAD",
        Description = "Savor the tender essence in our Ball, designed for dim culinary adventures",
        Id = "95ca1701-9a97-40d8-b2b8-14bb3ceded0a",
        IsActive = true,
        IsChargeableNow = true,
        Lineitems = new List<PaymentLineitem>() {
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
                Id = "56c5d53f-d803-462c-884b-ed9d672f8437",
                ItemDescription = "Discover the worst new Computer with an exciting mix of Steel ingredients",
                ItemName = "Soft Marble Cheese",
                TaxAmount = 0D,
                TotalAmount = 9342D,
                UnitAmount = 519D,
                UnitQuantity = 18D,
                UpdatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
            },
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
                DiscountAmount = 424.32D,
                Id = "19656cb9-33ad-4b91-98ac-a9f22095c884",
                ItemDescription = "Innovative Shoes featuring utilized technology and Cotton construction",
                ItemName = "Sleek Aluminum Shoes",
                Notes = "Cervus decretum viridis doloremque.",
                TaxAmount = 0D,
                TotalAmount = 6647.68D,
                UnitAmount = 884D,
                UnitQuantity = 8D,
                UpdatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
            },
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
                Id = "76f2e426-29cd-4630-8a27-c79166d3c03a",
                ItemDescription = "Featuring Osmium-enhanced technology, our Soap offers unparalleled major performance",
                ItemName = "Elegant Concrete Gloves",
                Notes = "Desipio usque vacuus currus cetera testimonium.",
                TaxAmount = 0D,
                TotalAmount = 1012D,
                UnitAmount = 506D,
                UnitQuantity = 2D,
                UpdatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
            },
        },
        Metadata = new List<PaymentMetadata>() {},
        SuccessUrl = "https://tinted-jet.info",
        UpdatedAt = System.DateTime.Parse("2024-04-13T09:35:36.719Z").ToUniversalTime(),
        Url = "https://pay.example.com/95ca1701-9a97-40d8-b2b8-14bb3ceded0a",
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
using System.Collections.Generic;
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
        Id = "e1fb4ca3-e293-473a-aa91-e1bd43a664d3",
        IsActive = true,
        Metadata = new List<CalendarMetadata>() {},
        Name = "Sopor sopor ancilla animus anser dignissimos vito confero utilis.",
        PriceAmount = 44D,
        PriceCurrency = "USD",
        UpdatedAt = "2024-03-15T13:06:35.495Z",
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
        Amount = 17001.68D,
        CreatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
        Currency = "CAD",
        Description = "Savor the tender essence in our Ball, designed for dim culinary adventures",
        Id = "0b342998-9562-4730-bb95-c37b0a89983e",
        IsActive = true,
        IsChargeableNow = true,
        Lineitems = new List<PaymentLineitem>() {
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
                Id = "d68633de-488d-4422-b388-0ed2546d244a",
                ItemDescription = "Discover the worst new Computer with an exciting mix of Steel ingredients",
                ItemName = "Soft Marble Cheese",
                TaxAmount = 0D,
                TotalAmount = 9342D,
                UnitAmount = 519D,
                UnitQuantity = 18D,
                UpdatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
            },
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
                DiscountAmount = 424.32D,
                Id = "4de4c706-32d9-4863-8f3d-1d981da2ff12",
                ItemDescription = "Innovative Shoes featuring utilized technology and Cotton construction",
                ItemName = "Sleek Aluminum Shoes",
                Notes = "Cervus decretum viridis doloremque.",
                TaxAmount = 0D,
                TotalAmount = 6647.68D,
                UnitAmount = 884D,
                UnitQuantity = 8D,
                UpdatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
            },
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
                Id = "5d559395-af99-45fd-8ab5-3f542517872b",
                ItemDescription = "Featuring Osmium-enhanced technology, our Soap offers unparalleled major performance",
                ItemName = "Elegant Concrete Gloves",
                Notes = "Desipio usque vacuus currus cetera testimonium.",
                TaxAmount = 0D,
                TotalAmount = 1012D,
                UnitAmount = 506D,
                UnitQuantity = 2D,
                UpdatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
            },
        },
        Metadata = new List<PaymentMetadata>() {},
        SuccessUrl = "https://tinted-jet.info",
        UpdatedAt = System.DateTime.Parse("2024-04-13T09:35:36.724Z").ToUniversalTime(),
        Url = "https://pay.example.com/0b342998-9562-4730-bb95-c37b0a89983e",
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
using System.Collections.Generic;
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
        Id = "e1fb4ca3-e293-473a-aa91-e1bd43a664d3",
        IsActive = true,
        Metadata = new List<CalendarMetadata>() {},
        Name = "Sopor sopor ancilla animus anser dignissimos vito confero utilis.",
        PriceAmount = 44D,
        PriceCurrency = "USD",
        UpdatedAt = "2024-03-15T13:06:35.495Z",
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
        Amount = 17001.68D,
        CreatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
        Currency = "CAD",
        Description = "Savor the tender essence in our Ball, designed for dim culinary adventures",
        Id = "0b342998-9562-4730-bb95-c37b0a89983e",
        IsActive = true,
        IsChargeableNow = true,
        Lineitems = new List<PaymentLineitem>() {
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
                Id = "d68633de-488d-4422-b388-0ed2546d244a",
                ItemDescription = "Discover the worst new Computer with an exciting mix of Steel ingredients",
                ItemName = "Soft Marble Cheese",
                TaxAmount = 0D,
                TotalAmount = 9342D,
                UnitAmount = 519D,
                UnitQuantity = 18D,
                UpdatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
            },
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
                DiscountAmount = 424.32D,
                Id = "4de4c706-32d9-4863-8f3d-1d981da2ff12",
                ItemDescription = "Innovative Shoes featuring utilized technology and Cotton construction",
                ItemName = "Sleek Aluminum Shoes",
                Notes = "Cervus decretum viridis doloremque.",
                TaxAmount = 0D,
                TotalAmount = 6647.68D,
                UnitAmount = 884D,
                UnitQuantity = 8D,
                UpdatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
            },
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
                Id = "5d559395-af99-45fd-8ab5-3f542517872b",
                ItemDescription = "Featuring Osmium-enhanced technology, our Soap offers unparalleled major performance",
                ItemName = "Elegant Concrete Gloves",
                Notes = "Desipio usque vacuus currus cetera testimonium.",
                TaxAmount = 0D,
                TotalAmount = 1012D,
                UnitAmount = 506D,
                UnitQuantity = 2D,
                UpdatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
            },
        },
        Metadata = new List<PaymentMetadata>() {},
        SuccessUrl = "https://tinted-jet.info",
        UpdatedAt = System.DateTime.Parse("2024-04-13T09:35:36.724Z").ToUniversalTime(),
        Url = "https://pay.example.com/0b342998-9562-4730-bb95-c37b0a89983e",
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