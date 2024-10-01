# Location
(*Location*)

## Overview

### Available Operations

* [CreateCommerceLocation](#createcommercelocation) - Create a location
* [CreateHrisLocation](#createhrislocation) - Create a location
* [GetCommerceLocation](#getcommercelocation) - Retrieve a location
* [GetHrisLocation](#gethrislocation) - Retrieve a location
* [ListCommerceLocations](#listcommercelocations) - List all locations
* [ListHrisLocations](#listhrislocations) - List all locations
* [PatchCommerceLocation](#patchcommercelocation) - Update a location
* [PatchHrisLocation](#patchhrislocation) - Update a location
* [RemoveCommerceLocation](#removecommercelocation) - Remove a location
* [RemoveHrisLocation](#removehrislocation) - Remove a location
* [UpdateCommerceLocation](#updatecommercelocation) - Update a location
* [UpdateHrisLocation](#updatehrislocation) - Update a location

## CreateCommerceLocation

Create a location

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Location.CreateCommerceLocationAsync(
    connectionId: "<id>",
    commerceLocation: new CommerceLocation() {
        Name = "<value>",
    },
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `ConnectionId`                                                  | *string*                                                        | :heavy_check_mark:                                              | ID of the connection                                            |
| `CommerceLocation`                                              | [CommerceLocation](../../Models/Components/CommerceLocation.md) | :heavy_minus_sign:                                              | N/A                                                             |
| `Fields`                                                        | List<*string*>                                                  | :heavy_minus_sign:                                              | Comma-delimited fields to return                                |

### Response

**[CreateCommerceLocationResponse](../../Models/Requests/CreateCommerceLocationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateHrisLocation

Create a location

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Location.CreateHrisLocationAsync(
    connectionId: "<id>",
    hrisLocation: new HrisLocation() {},
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                               | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `ConnectionId`                                          | *string*                                                | :heavy_check_mark:                                      | ID of the connection                                    |
| `HrisLocation`                                          | [HrisLocation](../../Models/Components/HrisLocation.md) | :heavy_minus_sign:                                      | N/A                                                     |
| `Fields`                                                | List<*string*>                                          | :heavy_minus_sign:                                      | Comma-delimited fields to return                        |

### Response

**[CreateHrisLocationResponse](../../Models/Requests/CreateHrisLocationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetCommerceLocation

Retrieve a location

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Location.GetCommerceLocationAsync(
    connectionId: "<id>",
    id: "<id>",
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Location               |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |

### Response

**[GetCommerceLocationResponse](../../Models/Requests/GetCommerceLocationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetHrisLocation

Retrieve a location

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Location.GetHrisLocationAsync(
    connectionId: "<id>",
    id: "<id>",
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Location               |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |

### Response

**[GetHrisLocationResponse](../../Models/Requests/GetHrisLocationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListCommerceLocations

List all locations

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListCommerceLocationsRequest req = new ListCommerceLocationsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Location.ListCommerceLocationsAsync(req);

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

## ListHrisLocations

List all locations

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHrisLocationsRequest req = new ListHrisLocationsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Location.ListHrisLocationsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListHrisLocationsRequest](../../Models/Requests/ListHrisLocationsRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[ListHrisLocationsResponse](../../Models/Requests/ListHrisLocationsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchCommerceLocation

Update a location

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Location.PatchCommerceLocationAsync(
    connectionId: "<id>",
    id: "<id>",
    commerceLocation: new CommerceLocation() {
        Name = "<value>",
    },
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `ConnectionId`                                                  | *string*                                                        | :heavy_check_mark:                                              | ID of the connection                                            |
| `Id`                                                            | *string*                                                        | :heavy_check_mark:                                              | ID of the Location                                              |
| `CommerceLocation`                                              | [CommerceLocation](../../Models/Components/CommerceLocation.md) | :heavy_minus_sign:                                              | N/A                                                             |
| `Fields`                                                        | List<*string*>                                                  | :heavy_minus_sign:                                              | Comma-delimited fields to return                                |

### Response

**[PatchCommerceLocationResponse](../../Models/Requests/PatchCommerceLocationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchHrisLocation

Update a location

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Location.PatchHrisLocationAsync(
    connectionId: "<id>",
    id: "<id>",
    hrisLocation: new HrisLocation() {},
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                               | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `ConnectionId`                                          | *string*                                                | :heavy_check_mark:                                      | ID of the connection                                    |
| `Id`                                                    | *string*                                                | :heavy_check_mark:                                      | ID of the Location                                      |
| `HrisLocation`                                          | [HrisLocation](../../Models/Components/HrisLocation.md) | :heavy_minus_sign:                                      | N/A                                                     |
| `Fields`                                                | List<*string*>                                          | :heavy_minus_sign:                                      | Comma-delimited fields to return                        |

### Response

**[PatchHrisLocationResponse](../../Models/Requests/PatchHrisLocationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveCommerceLocation

Remove a location

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Location.RemoveCommerceLocationAsync(
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

## RemoveHrisLocation

Remove a location

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Location.RemoveHrisLocationAsync(
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

**[RemoveHrisLocationResponse](../../Models/Requests/RemoveHrisLocationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateCommerceLocation

Update a location

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Location.UpdateCommerceLocationAsync(
    connectionId: "<id>",
    id: "<id>",
    commerceLocation: new CommerceLocation() {
        Name = "<value>",
    },
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `ConnectionId`                                                  | *string*                                                        | :heavy_check_mark:                                              | ID of the connection                                            |
| `Id`                                                            | *string*                                                        | :heavy_check_mark:                                              | ID of the Location                                              |
| `CommerceLocation`                                              | [CommerceLocation](../../Models/Components/CommerceLocation.md) | :heavy_minus_sign:                                              | N/A                                                             |
| `Fields`                                                        | List<*string*>                                                  | :heavy_minus_sign:                                              | Comma-delimited fields to return                                |

### Response

**[UpdateCommerceLocationResponse](../../Models/Requests/UpdateCommerceLocationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateHrisLocation

Update a location

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Location.UpdateHrisLocationAsync(
    connectionId: "<id>",
    id: "<id>",
    hrisLocation: new HrisLocation() {},
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                               | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `ConnectionId`                                          | *string*                                                | :heavy_check_mark:                                      | ID of the connection                                    |
| `Id`                                                    | *string*                                                | :heavy_check_mark:                                      | ID of the Location                                      |
| `HrisLocation`                                          | [HrisLocation](../../Models/Components/HrisLocation.md) | :heavy_minus_sign:                                      | N/A                                                     |
| `Fields`                                                | List<*string*>                                          | :heavy_minus_sign:                                      | Comma-delimited fields to return                        |

### Response

**[UpdateHrisLocationResponse](../../Models/Requests/UpdateHrisLocationResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |