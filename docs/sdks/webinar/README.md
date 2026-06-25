# Webinar
(*Webinar*)

## Overview

### Available Operations

* [CreateCalendarWebinar2](#createcalendarwebinar2) - Create a webinar
* [GetCalendarWebinar2](#getcalendarwebinar2) - Retrieve a webinar
* [ListCalendarWebinars2](#listcalendarwebinars2) - List all webinars
* [PatchCalendarWebinar2](#patchcalendarwebinar2) - Update a webinar
* [RemoveCalendarWebinar2](#removecalendarwebinar2) - Remove a webinar
* [UpdateCalendarWebinar2](#updatecalendarwebinar2) - Update a webinar

## CreateCalendarWebinar2

Create a webinar

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Webinar.CreateCalendarWebinar2Async(
    calendarWebinar: new CalendarWebinar() {},
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `CalendarWebinar`                                                                                                                                | [CalendarWebinar](../../Models/Components/CalendarWebinar.md)                                                                                    | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateCalendarWebinar2QueryParamFields](../../Models/Requests/CreateCalendarWebinar2QueryParamFields.md)>                                  | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateCalendarWebinar2Response](../../Models/Requests/CreateCalendarWebinar2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetCalendarWebinar2

Retrieve a webinar

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Webinar.GetCalendarWebinar2Async(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Webinar                                                                                                                                |
| `Fields`                                                                                                                                         | List<[GetCalendarWebinar2QueryParamFields](../../Models/Requests/GetCalendarWebinar2QueryParamFields.md)>                                        | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetCalendarWebinar2Response](../../Models/Requests/GetCalendarWebinar2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListCalendarWebinars2

List all webinars

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListCalendarWebinars2Request req = new ListCalendarWebinars2Request() {
    ConnectionId = "<id>",
};

var res = await sdk.Webinar.ListCalendarWebinars2Async(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [ListCalendarWebinars2Request](../../Models/Requests/ListCalendarWebinars2Request.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[ListCalendarWebinars2Response](../../Models/Requests/ListCalendarWebinars2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchCalendarWebinar2

Update a webinar

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchCalendarWebinar2Request req = new PatchCalendarWebinar2Request() {
    CalendarWebinar = new CalendarWebinar() {},
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Webinar.PatchCalendarWebinar2Async(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [PatchCalendarWebinar2Request](../../Models/Requests/PatchCalendarWebinar2Request.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[PatchCalendarWebinar2Response](../../Models/Requests/PatchCalendarWebinar2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveCalendarWebinar2

Remove a webinar

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Webinar.RemoveCalendarWebinar2Async(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Webinar    |

### Response

**[RemoveCalendarWebinar2Response](../../Models/Requests/RemoveCalendarWebinar2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateCalendarWebinar2

Update a webinar

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateCalendarWebinar2Request req = new UpdateCalendarWebinar2Request() {
    CalendarWebinar = new CalendarWebinar() {},
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Webinar.UpdateCalendarWebinar2Async(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [UpdateCalendarWebinar2Request](../../Models/Requests/UpdateCalendarWebinar2Request.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[UpdateCalendarWebinar2Response](../../Models/Requests/UpdateCalendarWebinar2Response.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |