# Location
(*Location*)

### Available Operations

* [CreateCommerceLocation](#createcommercelocation) - Create a location
* [GetCommerceLocation](#getcommercelocation) - Retrieve a location
* [ListCommerceLocations](#listcommercelocations) - List all locations
* [PatchCommerceLocation](#patchcommercelocation) - Update a location
* [RemoveCommerceLocation](#removecommercelocation) - Remove a location
* [UpdateCommerceLocation](#updatecommercelocation) - Update a location

## CreateCommerceLocation

Create a location

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Location.CreateCommerceLocationAsync(
    security: new CreateCommerceLocationSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    commerceLocation: new CommerceLocation() {
    Name = "<value>",
});

// handle response
```

### Parameters

| Parameter                                                                                                           | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                          | [UnifiedTo.Models.Requests.CreateCommerceLocationSecurity](../../Models/Requests/CreateCommerceLocationSecurity.md) | :heavy_check_mark:                                                                                                  | The security requirements to use for the request.                                                                   |
| `ConnectionId`                                                                                                      | *string*                                                                                                            | :heavy_check_mark:                                                                                                  | ID of the connection                                                                                                |
| `CommerceLocation`                                                                                                  | [CommerceLocation](../../Models/Components/CommerceLocation.md)                                                     | :heavy_minus_sign:                                                                                                  | N/A                                                                                                                 |


### Response

**[CreateCommerceLocationResponse](../../Models/Requests/CreateCommerceLocationResponse.md)**


## GetCommerceLocation

Retrieve a location

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Location.GetCommerceLocationAsync(
    security: new GetCommerceLocationSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    fields: new List<string>() {
    "<value>",
});

// handle response
```

### Parameters

| Parameter                                                                                                     | Type                                                                                                          | Required                                                                                                      | Description                                                                                                   |
| ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                    | [UnifiedTo.Models.Requests.GetCommerceLocationSecurity](../../Models/Requests/GetCommerceLocationSecurity.md) | :heavy_check_mark:                                                                                            | The security requirements to use for the request.                                                             |
| `ConnectionId`                                                                                                | *string*                                                                                                      | :heavy_check_mark:                                                                                            | ID of the connection                                                                                          |
| `Id`                                                                                                          | *string*                                                                                                      | :heavy_check_mark:                                                                                            | ID of the Location                                                                                            |
| `Fields`                                                                                                      | List<*string*>                                                                                                | :heavy_minus_sign:                                                                                            | Comma-delimited fields to return                                                                              |


### Response

**[GetCommerceLocationResponse](../../Models/Requests/GetCommerceLocationResponse.md)**


## ListCommerceLocations

List all locations

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListCommerceLocationsRequest req = new ListCommerceLocationsRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Location.ListCommerceLocationsAsync(
    security: new ListCommerceLocationsSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                                         | Type                                                                                                              | Required                                                                                                          | Description                                                                                                       |
| ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                         | [ListCommerceLocationsRequest](../../Models/Requests/ListCommerceLocationsRequest.md)                             | :heavy_check_mark:                                                                                                | The request object to use for the request.                                                                        |
| `security`                                                                                                        | [UnifiedTo.Models.Requests.ListCommerceLocationsSecurity](../../Models/Requests/ListCommerceLocationsSecurity.md) | :heavy_check_mark:                                                                                                | The security requirements to use for the request.                                                                 |


### Response

**[ListCommerceLocationsResponse](../../Models/Requests/ListCommerceLocationsResponse.md)**


## PatchCommerceLocation

Update a location

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Location.PatchCommerceLocationAsync(
    security: new PatchCommerceLocationSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    commerceLocation: new CommerceLocation() {
    Name = "<value>",
});

// handle response
```

### Parameters

| Parameter                                                                                                         | Type                                                                                                              | Required                                                                                                          | Description                                                                                                       |
| ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                        | [UnifiedTo.Models.Requests.PatchCommerceLocationSecurity](../../Models/Requests/PatchCommerceLocationSecurity.md) | :heavy_check_mark:                                                                                                | The security requirements to use for the request.                                                                 |
| `ConnectionId`                                                                                                    | *string*                                                                                                          | :heavy_check_mark:                                                                                                | ID of the connection                                                                                              |
| `Id`                                                                                                              | *string*                                                                                                          | :heavy_check_mark:                                                                                                | ID of the Location                                                                                                |
| `CommerceLocation`                                                                                                | [CommerceLocation](../../Models/Components/CommerceLocation.md)                                                   | :heavy_minus_sign:                                                                                                | N/A                                                                                                               |


### Response

**[PatchCommerceLocationResponse](../../Models/Requests/PatchCommerceLocationResponse.md)**


## RemoveCommerceLocation

Remove a location

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Location.RemoveCommerceLocationAsync(
    security: new RemoveCommerceLocationSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                                           | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                          | [UnifiedTo.Models.Requests.RemoveCommerceLocationSecurity](../../Models/Requests/RemoveCommerceLocationSecurity.md) | :heavy_check_mark:                                                                                                  | The security requirements to use for the request.                                                                   |
| `ConnectionId`                                                                                                      | *string*                                                                                                            | :heavy_check_mark:                                                                                                  | ID of the connection                                                                                                |
| `Id`                                                                                                                | *string*                                                                                                            | :heavy_check_mark:                                                                                                  | ID of the Location                                                                                                  |


### Response

**[RemoveCommerceLocationResponse](../../Models/Requests/RemoveCommerceLocationResponse.md)**


## UpdateCommerceLocation

Update a location

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Location.UpdateCommerceLocationAsync(
    security: new UpdateCommerceLocationSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    commerceLocation: new CommerceLocation() {
    Name = "<value>",
});

// handle response
```

### Parameters

| Parameter                                                                                                           | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                          | [UnifiedTo.Models.Requests.UpdateCommerceLocationSecurity](../../Models/Requests/UpdateCommerceLocationSecurity.md) | :heavy_check_mark:                                                                                                  | The security requirements to use for the request.                                                                   |
| `ConnectionId`                                                                                                      | *string*                                                                                                            | :heavy_check_mark:                                                                                                  | ID of the connection                                                                                                |
| `Id`                                                                                                                | *string*                                                                                                            | :heavy_check_mark:                                                                                                  | ID of the Location                                                                                                  |
| `CommerceLocation`                                                                                                  | [CommerceLocation](../../Models/Components/CommerceLocation.md)                                                     | :heavy_minus_sign:                                                                                                  | N/A                                                                                                                 |


### Response

**[UpdateCommerceLocationResponse](../../Models/Requests/UpdateCommerceLocationResponse.md)**

