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

Creates a CalendarLink. Provide the unified CalendarLink fields in the request body; they are mapped to the provider's API. Returns the created CalendarLink.

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
        Id = "14974267-334a-4084-bdf7-ec9721a39dfa",
        IsActive = true,
        Metadata = new List<CalendarMetadata>() {},
        Name = "Sopor sopor ancilla animus anser dignissimos vito confero utilis.",
        PriceAmount = 44D,
        PriceCurrency = "USD",
        UpdatedAt = "2024-03-16T16:01:10.039Z",
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

Creates a PaymentLink. Provide the unified PaymentLink fields in the request body; they are mapped to the provider's API. Returns the created PaymentLink.

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
        Id = "dfc10502-97b7-4245-b77a-8300b143ebdd",
        IsActive = true,
        IsChargeableNow = true,
        Lineitems = new List<PaymentLineitem>() {
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
                Id = "b25d99af-3a4b-4a9d-9dbf-1a0f3e50dd1a",
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
                Id = "9b2f5c4e-b380-4293-8e22-5a1240955fe3",
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
                Id = "f6761de2-4845-4b2a-8178-818c902a69b5",
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
        UpdatedAt = System.DateTime.Parse("2024-04-14T09:47:49.621Z").ToUniversalTime(),
        Url = "https://pay.example.com/dfc10502-97b7-4245-b77a-8300b143ebdd",
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

Retrieves a single CalendarLink by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Retrieves a single PaymentLink by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

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

Returns a list of CalendarLinks. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Returns a list of PaymentLinks. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

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

Updates the CalendarLink identified by `id`. Provide the unified CalendarLink fields to change in the request body.

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
        Id = "77aac66e-9d41-44a1-990b-5dcbc5fd5b3f",
        IsActive = true,
        Metadata = new List<CalendarMetadata>() {},
        Name = "Sopor sopor ancilla animus anser dignissimos vito confero utilis.",
        PriceAmount = 44D,
        PriceCurrency = "USD",
        UpdatedAt = "2024-03-16T16:01:10.042Z",
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

Updates the PaymentLink identified by `id`. Provide the unified PaymentLink fields to change in the request body.

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
        Id = "5971a8de-1cc6-4405-a17a-a782c0640c1c",
        IsActive = true,
        IsChargeableNow = true,
        Lineitems = new List<PaymentLineitem>() {
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
                Id = "abcb67e9-2918-4b32-bf7b-6fdff4c68cec",
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
                Id = "67a8bfbf-07db-4a47-af2e-b6e785ed9d88",
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
                Id = "670bfba9-a13e-4b24-b43d-3741627df673",
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
        UpdatedAt = System.DateTime.Parse("2024-04-14T09:47:49.627Z").ToUniversalTime(),
        Url = "https://pay.example.com/5971a8de-1cc6-4405-a17a-a782c0640c1c",
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

Deletes the CalendarLink identified by `id`.

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

Deletes the PaymentLink identified by `id`.

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

Updates the CalendarLink identified by `id`. Provide the unified CalendarLink fields to change in the request body.

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
        Id = "77aac66e-9d41-44a1-990b-5dcbc5fd5b3f",
        IsActive = true,
        Metadata = new List<CalendarMetadata>() {},
        Name = "Sopor sopor ancilla animus anser dignissimos vito confero utilis.",
        PriceAmount = 44D,
        PriceCurrency = "USD",
        UpdatedAt = "2024-03-16T16:01:10.042Z",
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

Updates the PaymentLink identified by `id`. Provide the unified PaymentLink fields to change in the request body.

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
        Id = "5971a8de-1cc6-4405-a17a-a782c0640c1c",
        IsActive = true,
        IsChargeableNow = true,
        Lineitems = new List<PaymentLineitem>() {
            new PaymentLineitem() {
                CreatedAt = System.DateTime.Parse("2023-06-04T16:11:45.685Z").ToUniversalTime(),
                Id = "abcb67e9-2918-4b32-bf7b-6fdff4c68cec",
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
                Id = "67a8bfbf-07db-4a47-af2e-b6e785ed9d88",
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
                Id = "670bfba9-a13e-4b24-b43d-3741627df673",
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
        UpdatedAt = System.DateTime.Parse("2024-04-14T09:47:49.627Z").ToUniversalTime(),
        Url = "https://pay.example.com/5971a8de-1cc6-4405-a17a-a782c0640c1c",
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