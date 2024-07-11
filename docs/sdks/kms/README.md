# Kms
(*Kms*)

### Available Operations

* [CreateKmsPage](#createkmspage) - Create a page
* [CreateKmsSpace](#createkmsspace) - Create a space
* [GetKmsPage](#getkmspage) - Retrieve a page
* [GetKmsSpace](#getkmsspace) - Retrieve a space
* [ListKmsPages](#listkmspages) - List all pages
* [ListKmsSpaces](#listkmsspaces) - List all spaces
* [PatchKmsPage](#patchkmspage) - Update a page
* [PatchKmsSpace](#patchkmsspace) - Update a space
* [RemoveKmsPage](#removekmspage) - Remove a page
* [RemoveKmsSpace](#removekmsspace) - Remove a space
* [UpdateKmsPage](#updatekmspage) - Update a page
* [UpdateKmsSpace](#updatekmsspace) - Update a space

## CreateKmsPage

Create a page

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Kms.CreateKmsPageAsync(
    connectionId: "<value>",
    kmsPage: new KmsPage() {
    DownloadUrl = "<value>",
    Id = "<id>",
    SpaceId = "<value>",
    Title = "<value>",
    Type = UnifiedTo.Models.Components.KmsPageType.Html,
});

// handle response
```

### Parameters

| Parameter                                     | Type                                          | Required                                      | Description                                   |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| `ConnectionId`                                | *string*                                      | :heavy_check_mark:                            | ID of the connection                          |
| `KmsPage`                                     | [KmsPage](../../Models/Components/KmsPage.md) | :heavy_minus_sign:                            | N/A                                           |


### Response

**[CreateKmsPageResponse](../../Models/Requests/CreateKmsPageResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## CreateKmsSpace

Create a space

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Kms.CreateKmsSpaceAsync(
    connectionId: "<value>",
    kmsSpace: new KmsSpace() {
    Id = "<id>",
    Name = "<value>",
});

// handle response
```

### Parameters

| Parameter                                       | Type                                            | Required                                        | Description                                     |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| `ConnectionId`                                  | *string*                                        | :heavy_check_mark:                              | ID of the connection                            |
| `KmsSpace`                                      | [KmsSpace](../../Models/Components/KmsSpace.md) | :heavy_minus_sign:                              | N/A                                             |


### Response

**[CreateKmsSpaceResponse](../../Models/Requests/CreateKmsSpaceResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## GetKmsPage

Retrieve a page

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Kms.GetKmsPageAsync(
    connectionId: "<value>",
    id: "<value>",
    fields: new List<string>() {
    "<value>",
});

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Page                   |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetKmsPageResponse](../../Models/Requests/GetKmsPageResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## GetKmsSpace

Retrieve a space

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Kms.GetKmsSpaceAsync(
    connectionId: "<value>",
    id: "<value>",
    fields: new List<string>() {
    "<value>",
});

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Space                  |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetKmsSpaceResponse](../../Models/Requests/GetKmsSpaceResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## ListKmsPages

List all pages

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListKmsPagesRequest req = new ListKmsPagesRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Kms.ListKmsPagesAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [ListKmsPagesRequest](../../Models/Requests/ListKmsPagesRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |


### Response

**[ListKmsPagesResponse](../../Models/Requests/ListKmsPagesResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## ListKmsSpaces

List all spaces

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListKmsSpacesRequest req = new ListKmsSpacesRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Kms.ListKmsSpacesAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [ListKmsSpacesRequest](../../Models/Requests/ListKmsSpacesRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |


### Response

**[ListKmsSpacesResponse](../../Models/Requests/ListKmsSpacesResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## PatchKmsPage

Update a page

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Kms.PatchKmsPageAsync(
    connectionId: "<value>",
    id: "<value>",
    kmsPage: new KmsPage() {
    DownloadUrl = "<value>",
    Id = "<id>",
    SpaceId = "<value>",
    Title = "<value>",
    Type = UnifiedTo.Models.Components.KmsPageType.Text,
});

// handle response
```

### Parameters

| Parameter                                     | Type                                          | Required                                      | Description                                   |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| `ConnectionId`                                | *string*                                      | :heavy_check_mark:                            | ID of the connection                          |
| `Id`                                          | *string*                                      | :heavy_check_mark:                            | ID of the Page                                |
| `KmsPage`                                     | [KmsPage](../../Models/Components/KmsPage.md) | :heavy_minus_sign:                            | N/A                                           |


### Response

**[PatchKmsPageResponse](../../Models/Requests/PatchKmsPageResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## PatchKmsSpace

Update a space

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Kms.PatchKmsSpaceAsync(
    connectionId: "<value>",
    id: "<value>",
    kmsSpace: new KmsSpace() {
    Id = "<id>",
    Name = "<value>",
});

// handle response
```

### Parameters

| Parameter                                       | Type                                            | Required                                        | Description                                     |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| `ConnectionId`                                  | *string*                                        | :heavy_check_mark:                              | ID of the connection                            |
| `Id`                                            | *string*                                        | :heavy_check_mark:                              | ID of the Space                                 |
| `KmsSpace`                                      | [KmsSpace](../../Models/Components/KmsSpace.md) | :heavy_minus_sign:                              | N/A                                             |


### Response

**[PatchKmsSpaceResponse](../../Models/Requests/PatchKmsSpaceResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## RemoveKmsPage

Remove a page

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Kms.RemoveKmsPageAsync(
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Page       |


### Response

**[RemoveKmsPageResponse](../../Models/Requests/RemoveKmsPageResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## RemoveKmsSpace

Remove a space

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Kms.RemoveKmsSpaceAsync(
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Space      |


### Response

**[RemoveKmsSpaceResponse](../../Models/Requests/RemoveKmsSpaceResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## UpdateKmsPage

Update a page

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Kms.UpdateKmsPageAsync(
    connectionId: "<value>",
    id: "<value>",
    kmsPage: new KmsPage() {
    DownloadUrl = "<value>",
    Id = "<id>",
    SpaceId = "<value>",
    Title = "<value>",
    Type = UnifiedTo.Models.Components.KmsPageType.Text,
});

// handle response
```

### Parameters

| Parameter                                     | Type                                          | Required                                      | Description                                   |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| `ConnectionId`                                | *string*                                      | :heavy_check_mark:                            | ID of the connection                          |
| `Id`                                          | *string*                                      | :heavy_check_mark:                            | ID of the Page                                |
| `KmsPage`                                     | [KmsPage](../../Models/Components/KmsPage.md) | :heavy_minus_sign:                            | N/A                                           |


### Response

**[UpdateKmsPageResponse](../../Models/Requests/UpdateKmsPageResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## UpdateKmsSpace

Update a space

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Kms.UpdateKmsSpaceAsync(
    connectionId: "<value>",
    id: "<value>",
    kmsSpace: new KmsSpace() {
    Id = "<id>",
    Name = "<value>",
});

// handle response
```

### Parameters

| Parameter                                       | Type                                            | Required                                        | Description                                     |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| `ConnectionId`                                  | *string*                                        | :heavy_check_mark:                              | ID of the connection                            |
| `Id`                                            | *string*                                        | :heavy_check_mark:                              | ID of the Space                                 |
| `KmsSpace`                                      | [KmsSpace](../../Models/Components/KmsSpace.md) | :heavy_minus_sign:                              | N/A                                             |


### Response

**[UpdateKmsSpaceResponse](../../Models/Requests/UpdateKmsSpaceResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |
