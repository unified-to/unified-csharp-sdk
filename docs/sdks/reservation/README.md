# Reservation

## Overview

### Available Operations

* [CreateCommerceReservation](#createcommercereservation) - Create a reservation
* [GetCommerceReservation](#getcommercereservation) - Retrieve a reservation
* [ListCommerceReservations](#listcommercereservations) - List all reservations
* [PatchCommerceReservation](#patchcommercereservation) - Update a reservation
* [RemoveCommerceReservation](#removecommercereservation) - Remove a reservation
* [UpdateCommerceReservation](#updatecommercereservation) - Update a reservation

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

var res = await sdk.Reservation.CreateCommerceReservationAsync(
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

var res = await sdk.Reservation.GetCommerceReservationAsync(
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

var res = await sdk.Reservation.ListCommerceReservationsAsync(req);

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

var res = await sdk.Reservation.PatchCommerceReservationAsync(req);

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

var res = await sdk.Reservation.RemoveCommerceReservationAsync(
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

var res = await sdk.Reservation.UpdateCommerceReservationAsync(req);

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