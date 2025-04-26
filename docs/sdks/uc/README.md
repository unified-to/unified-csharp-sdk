# Uc
(*Uc*)

## Overview

### Available Operations

* [CreateUcComment](#createuccomment) - Create a comment
* [CreateUcContact](#createuccontact) - Create a contact
* [CreateUcRecording](#createucrecording) - Create a recording
* [GetUcComment](#getuccomment) - Retrieve a comment
* [GetUcContact](#getuccontact) - Retrieve a contact
* [GetUcRecording](#getucrecording) - Retrieve a recording
* [ListUcCalls](#listuccalls) - List all calls
* [ListUcComments](#listuccomments) - List all comments
* [ListUcContacts](#listuccontacts) - List all contacts
* [ListUcRecordings](#listucrecordings) - List all recordings
* [PatchUcComment](#patchuccomment) - Update a comment
* [PatchUcContact](#patchuccontact) - Update a contact
* [PatchUcRecording](#patchucrecording) - Update a recording
* [RemoveUcComment](#removeuccomment) - Remove a comment
* [RemoveUcContact](#removeuccontact) - Remove a contact
* [RemoveUcRecording](#removeucrecording) - Remove a recording
* [UpdateUcComment](#updateuccomment) - Update a comment
* [UpdateUcContact](#updateuccontact) - Update a contact
* [UpdateUcRecording](#updateucrecording) - Update a recording

## CreateUcComment

Create a comment

### Example Usage

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Uc.CreateUcCommentAsync(
    ucComment: new UcComment() {
        Content = "<value>",
    },
    connectionId: "<id>",
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                         | Type                                              | Required                                          | Description                                       |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| `UcComment`                                       | [UcComment](../../Models/Components/UcComment.md) | :heavy_check_mark:                                | N/A                                               |
| `ConnectionId`                                    | *string*                                          | :heavy_check_mark:                                | ID of the connection                              |
| `Fields`                                          | List<*string*>                                    | :heavy_minus_sign:                                | Comma-delimited fields to return                  |

### Response

**[CreateUcCommentResponse](../../Models/Requests/CreateUcCommentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateUcContact

Create a contact

### Example Usage

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Uc.CreateUcContactAsync(
    ucContact: new UcContact() {},
    connectionId: "<id>",
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `UcContact`                                                             | [UcContact](../../Models/Components/UcContact.md)                       | :heavy_check_mark:                                                      | A contact represents a person that optionally is associated with a call |
| `ConnectionId`                                                          | *string*                                                                | :heavy_check_mark:                                                      | ID of the connection                                                    |
| `Fields`                                                                | List<*string*>                                                          | :heavy_minus_sign:                                                      | Comma-delimited fields to return                                        |

### Response

**[CreateUcContactResponse](../../Models/Requests/CreateUcContactResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateUcRecording

Create a recording

### Example Usage

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Uc.CreateUcRecordingAsync(
    ucRecording: new UcRecording() {},
    connectionId: "<id>",
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                             | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `UcRecording`                                         | [UcRecording](../../Models/Components/UcRecording.md) | :heavy_check_mark:                                    | N/A                                                   |
| `ConnectionId`                                        | *string*                                              | :heavy_check_mark:                                    | ID of the connection                                  |
| `Fields`                                              | List<*string*>                                        | :heavy_minus_sign:                                    | Comma-delimited fields to return                      |

### Response

**[CreateUcRecordingResponse](../../Models/Requests/CreateUcRecordingResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetUcComment

Retrieve a comment

### Example Usage

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Uc.GetUcCommentAsync(
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
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Comment                |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |

### Response

**[GetUcCommentResponse](../../Models/Requests/GetUcCommentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetUcContact

Retrieve a contact

### Example Usage

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Uc.GetUcContactAsync(
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
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Contact                |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |

### Response

**[GetUcContactResponse](../../Models/Requests/GetUcContactResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetUcRecording

Retrieve a recording

### Example Usage

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Uc.GetUcRecordingAsync(
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
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Recording              |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |

### Response

**[GetUcRecordingResponse](../../Models/Requests/GetUcRecordingResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListUcCalls

List all calls

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListUcCallsRequest req = new ListUcCallsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Uc.ListUcCallsAsync(req);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [ListUcCallsRequest](../../Models/Requests/ListUcCallsRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |

### Response

**[ListUcCallsResponse](../../Models/Requests/ListUcCallsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListUcComments

List all comments

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListUcCommentsRequest req = new ListUcCommentsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Uc.ListUcCommentsAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [ListUcCommentsRequest](../../Models/Requests/ListUcCommentsRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[ListUcCommentsResponse](../../Models/Requests/ListUcCommentsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListUcContacts

List all contacts

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListUcContactsRequest req = new ListUcContactsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Uc.ListUcContactsAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [ListUcContactsRequest](../../Models/Requests/ListUcContactsRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[ListUcContactsResponse](../../Models/Requests/ListUcContactsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListUcRecordings

List all recordings

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListUcRecordingsRequest req = new ListUcRecordingsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Uc.ListUcRecordingsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListUcRecordingsRequest](../../Models/Requests/ListUcRecordingsRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[ListUcRecordingsResponse](../../Models/Requests/ListUcRecordingsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchUcComment

Update a comment

### Example Usage

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Uc.PatchUcCommentAsync(
    ucComment: new UcComment() {
        Content = "<value>",
    },
    connectionId: "<id>",
    id: "<id>",
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                         | Type                                              | Required                                          | Description                                       |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| `UcComment`                                       | [UcComment](../../Models/Components/UcComment.md) | :heavy_check_mark:                                | N/A                                               |
| `ConnectionId`                                    | *string*                                          | :heavy_check_mark:                                | ID of the connection                              |
| `Id`                                              | *string*                                          | :heavy_check_mark:                                | ID of the Comment                                 |
| `Fields`                                          | List<*string*>                                    | :heavy_minus_sign:                                | Comma-delimited fields to return                  |

### Response

**[PatchUcCommentResponse](../../Models/Requests/PatchUcCommentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchUcContact

Update a contact

### Example Usage

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Uc.PatchUcContactAsync(
    ucContact: new UcContact() {},
    connectionId: "<id>",
    id: "<id>",
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `UcContact`                                                             | [UcContact](../../Models/Components/UcContact.md)                       | :heavy_check_mark:                                                      | A contact represents a person that optionally is associated with a call |
| `ConnectionId`                                                          | *string*                                                                | :heavy_check_mark:                                                      | ID of the connection                                                    |
| `Id`                                                                    | *string*                                                                | :heavy_check_mark:                                                      | ID of the Contact                                                       |
| `Fields`                                                                | List<*string*>                                                          | :heavy_minus_sign:                                                      | Comma-delimited fields to return                                        |

### Response

**[PatchUcContactResponse](../../Models/Requests/PatchUcContactResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchUcRecording

Update a recording

### Example Usage

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Uc.PatchUcRecordingAsync(
    ucRecording: new UcRecording() {},
    connectionId: "<id>",
    id: "<id>",
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                             | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `UcRecording`                                         | [UcRecording](../../Models/Components/UcRecording.md) | :heavy_check_mark:                                    | N/A                                                   |
| `ConnectionId`                                        | *string*                                              | :heavy_check_mark:                                    | ID of the connection                                  |
| `Id`                                                  | *string*                                              | :heavy_check_mark:                                    | ID of the Recording                                   |
| `Fields`                                              | List<*string*>                                        | :heavy_minus_sign:                                    | Comma-delimited fields to return                      |

### Response

**[PatchUcRecordingResponse](../../Models/Requests/PatchUcRecordingResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveUcComment

Remove a comment

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Uc.RemoveUcCommentAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Comment    |

### Response

**[RemoveUcCommentResponse](../../Models/Requests/RemoveUcCommentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveUcContact

Remove a contact

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Uc.RemoveUcContactAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Contact    |

### Response

**[RemoveUcContactResponse](../../Models/Requests/RemoveUcContactResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveUcRecording

Remove a recording

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Uc.RemoveUcRecordingAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Recording  |

### Response

**[RemoveUcRecordingResponse](../../Models/Requests/RemoveUcRecordingResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateUcComment

Update a comment

### Example Usage

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Uc.UpdateUcCommentAsync(
    ucComment: new UcComment() {
        Content = "<value>",
    },
    connectionId: "<id>",
    id: "<id>",
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                         | Type                                              | Required                                          | Description                                       |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| `UcComment`                                       | [UcComment](../../Models/Components/UcComment.md) | :heavy_check_mark:                                | N/A                                               |
| `ConnectionId`                                    | *string*                                          | :heavy_check_mark:                                | ID of the connection                              |
| `Id`                                              | *string*                                          | :heavy_check_mark:                                | ID of the Comment                                 |
| `Fields`                                          | List<*string*>                                    | :heavy_minus_sign:                                | Comma-delimited fields to return                  |

### Response

**[UpdateUcCommentResponse](../../Models/Requests/UpdateUcCommentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateUcContact

Update a contact

### Example Usage

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Uc.UpdateUcContactAsync(
    ucContact: new UcContact() {},
    connectionId: "<id>",
    id: "<id>",
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `UcContact`                                                             | [UcContact](../../Models/Components/UcContact.md)                       | :heavy_check_mark:                                                      | A contact represents a person that optionally is associated with a call |
| `ConnectionId`                                                          | *string*                                                                | :heavy_check_mark:                                                      | ID of the connection                                                    |
| `Id`                                                                    | *string*                                                                | :heavy_check_mark:                                                      | ID of the Contact                                                       |
| `Fields`                                                                | List<*string*>                                                          | :heavy_minus_sign:                                                      | Comma-delimited fields to return                                        |

### Response

**[UpdateUcContactResponse](../../Models/Requests/UpdateUcContactResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateUcRecording

Update a recording

### Example Usage

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Uc.UpdateUcRecordingAsync(
    ucRecording: new UcRecording() {},
    connectionId: "<id>",
    id: "<id>",
    fields: new List<string>() {
        "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                             | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `UcRecording`                                         | [UcRecording](../../Models/Components/UcRecording.md) | :heavy_check_mark:                                    | N/A                                                   |
| `ConnectionId`                                        | *string*                                              | :heavy_check_mark:                                    | ID of the connection                                  |
| `Id`                                                  | *string*                                              | :heavy_check_mark:                                    | ID of the Recording                                   |
| `Fields`                                              | List<*string*>                                        | :heavy_minus_sign:                                    | Comma-delimited fields to return                      |

### Response

**[UpdateUcRecordingResponse](../../Models/Requests/UpdateUcRecordingResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |