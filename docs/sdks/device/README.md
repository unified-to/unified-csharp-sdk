# Device

## Overview

### Available Operations

* [CreateHrisDevice](#createhrisdevice) - Create a device
* [GetHrisDevice](#gethrisdevice) - Retrieve a device
* [ListHrisDevices](#listhrisdevices) - List all devices
* [PatchHrisDevice](#patchhrisdevice) - Update a device
* [RemoveHrisDevice](#removehrisdevice) - Remove a device
* [UpdateHrisDevice](#updatehrisdevice) - Update a device

## CreateHrisDevice

Creates a HrisDevice. Provide the unified HrisDevice fields in the request body; they are mapped to the provider's API. Returns the created HrisDevice.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createHrisDevice" method="post" path="/hris/{connection_id}/device" example="hris_device" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Device.CreateHrisDeviceAsync(
    hrisDevice: new HrisDevice() {
        AdminUserIds = new List<string>() {},
        AssetTag = "fJNacaaoWi",
        CreatedAt = System.DateTime.Parse("2019-04-04T17:11:40.322Z").ToUniversalTime(),
        HasAntivirus = true,
        HasFirewall = true,
        HasHdEncrypted = true,
        HasPasswordManager = true,
        HasScreenlock = false,
        Id = "406a7817-9c17-435f-9476-0a8d3e1a0250",
        IsMissing = false,
        Manufacturer = "Hackett Inc",
        Metadata = new List<HrisMetadata>() {},
        Model = "Fantastic",
        Name = "august-laptop",
        Os = "transmitter",
        OsVersion = "8.4.8",
        UpdatedAt = System.DateTime.Parse("2023-06-12T13:06:59.210Z").ToUniversalTime(),
        Version = "4.15.7",
    },
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `HrisDevice`                                                                                                                                     | [HrisDevice](../../Models/Components/HrisDevice.md)                                                                                              | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateHrisDeviceQueryParamFields](../../Models/Requests/CreateHrisDeviceQueryParamFields.md)>                                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateHrisDeviceResponse](../../Models/Requests/CreateHrisDeviceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetHrisDevice

Retrieves a single HrisDevice by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHrisDevice" method="get" path="/hris/{connection_id}/device/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Device.GetHrisDeviceAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Device                                                                                                                                 |
| `Fields`                                                                                                                                         | List<[GetHrisDeviceQueryParamFields](../../Models/Requests/GetHrisDeviceQueryParamFields.md)>                                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetHrisDeviceResponse](../../Models/Requests/GetHrisDeviceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListHrisDevices

Returns a list of HrisDevices. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listHrisDevices" method="get" path="/hris/{connection_id}/device" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListHrisDevicesRequest req = new ListHrisDevicesRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Device.ListHrisDevicesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [ListHrisDevicesRequest](../../Models/Requests/ListHrisDevicesRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[ListHrisDevicesResponse](../../Models/Requests/ListHrisDevicesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchHrisDevice

Updates the HrisDevice identified by `id`. Provide the unified HrisDevice fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchHrisDevice" method="patch" path="/hris/{connection_id}/device/{id}" example="hris_device" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchHrisDeviceRequest req = new PatchHrisDeviceRequest() {
    HrisDevice = new HrisDevice() {
        AdminUserIds = new List<string>() {},
        AssetTag = "fJNacaaoWi",
        CreatedAt = System.DateTime.Parse("2019-04-04T17:11:40.322Z").ToUniversalTime(),
        HasAntivirus = true,
        HasFirewall = true,
        HasHdEncrypted = true,
        HasPasswordManager = true,
        HasScreenlock = false,
        Id = "02c99cef-a366-4447-8229-62df562d6f5f",
        IsMissing = false,
        Manufacturer = "Hackett Inc",
        Metadata = new List<HrisMetadata>() {},
        Model = "Fantastic",
        Name = "august-laptop",
        Os = "transmitter",
        OsVersion = "8.4.8",
        UpdatedAt = System.DateTime.Parse("2023-06-12T13:06:59.221Z").ToUniversalTime(),
        Version = "4.15.7",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Device.PatchHrisDeviceAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [PatchHrisDeviceRequest](../../Models/Requests/PatchHrisDeviceRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[PatchHrisDeviceResponse](../../Models/Requests/PatchHrisDeviceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveHrisDevice

Deletes the HrisDevice identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeHrisDevice" method="delete" path="/hris/{connection_id}/device/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Device.RemoveHrisDeviceAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Device     |

### Response

**[RemoveHrisDeviceResponse](../../Models/Requests/RemoveHrisDeviceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateHrisDevice

Updates the HrisDevice identified by `id`. Provide the unified HrisDevice fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateHrisDevice" method="put" path="/hris/{connection_id}/device/{id}" example="hris_device" -->
```csharp
using System;
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateHrisDeviceRequest req = new UpdateHrisDeviceRequest() {
    HrisDevice = new HrisDevice() {
        AdminUserIds = new List<string>() {},
        AssetTag = "fJNacaaoWi",
        CreatedAt = System.DateTime.Parse("2019-04-04T17:11:40.322Z").ToUniversalTime(),
        HasAntivirus = true,
        HasFirewall = true,
        HasHdEncrypted = true,
        HasPasswordManager = true,
        HasScreenlock = false,
        Id = "02c99cef-a366-4447-8229-62df562d6f5f",
        IsMissing = false,
        Manufacturer = "Hackett Inc",
        Metadata = new List<HrisMetadata>() {},
        Model = "Fantastic",
        Name = "august-laptop",
        Os = "transmitter",
        OsVersion = "8.4.8",
        UpdatedAt = System.DateTime.Parse("2023-06-12T13:06:59.221Z").ToUniversalTime(),
        Version = "4.15.7",
    },
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Device.UpdateHrisDeviceAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [UpdateHrisDeviceRequest](../../Models/Requests/UpdateHrisDeviceRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[UpdateHrisDeviceResponse](../../Models/Requests/UpdateHrisDeviceResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |