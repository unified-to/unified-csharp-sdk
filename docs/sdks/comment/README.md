# Comment
(*Comment*)

## Overview

### Available Operations

* [CreateKmsComment](#createkmscomment) - Create a comment
* [CreateTaskComment](#createtaskcomment) - Create a comment
* [CreateUcComment](#createuccomment) - Create a comment
* [GetKmsComment](#getkmscomment) - Retrieve a comment
* [GetTaskComment](#gettaskcomment) - Retrieve a comment
* [GetUcComment](#getuccomment) - Retrieve a comment
* [ListKmsComments](#listkmscomments) - List all comments
* [ListTaskComments](#listtaskcomments) - List all comments
* [ListUcComments](#listuccomments) - List all comments
* [PatchKmsComment](#patchkmscomment) - Update a comment
* [PatchTaskComment](#patchtaskcomment) - Update a comment
* [PatchUcComment](#patchuccomment) - Update a comment
* [RemoveKmsComment](#removekmscomment) - Remove a comment
* [RemoveTaskComment](#removetaskcomment) - Remove a comment
* [RemoveUcComment](#removeuccomment) - Remove a comment
* [UpdateKmsComment](#updatekmscomment) - Update a comment
* [UpdateTaskComment](#updatetaskcomment) - Update a comment
* [UpdateUcComment](#updateuccomment) - Update a comment

## CreateKmsComment

Create a comment

### Example Usage

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Comment.CreateKmsCommentAsync(
    kmsComment: new KmsComment() {
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

| Parameter                                           | Type                                                | Required                                            | Description                                         |
| --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- |
| `KmsComment`                                        | [KmsComment](../../Models/Components/KmsComment.md) | :heavy_check_mark:                                  | N/A                                                 |
| `ConnectionId`                                      | *string*                                            | :heavy_check_mark:                                  | ID of the connection                                |
| `Fields`                                            | List<*string*>                                      | :heavy_minus_sign:                                  | Comma-delimited fields to return                    |

### Response

**[CreateKmsCommentResponse](../../Models/Requests/CreateKmsCommentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## CreateTaskComment

Create a comment

### Example Usage

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Comment.CreateTaskCommentAsync(
    taskComment: new TaskComment() {
        TaskId = "<id>",
        Text = "<value>",
    },
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
| `TaskComment`                                         | [TaskComment](../../Models/Components/TaskComment.md) | :heavy_check_mark:                                    | N/A                                                   |
| `ConnectionId`                                        | *string*                                              | :heavy_check_mark:                                    | ID of the connection                                  |
| `Fields`                                              | List<*string*>                                        | :heavy_minus_sign:                                    | Comma-delimited fields to return                      |

### Response

**[CreateTaskCommentResponse](../../Models/Requests/CreateTaskCommentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

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

var res = await sdk.Comment.CreateUcCommentAsync(
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

## GetKmsComment

Retrieve a comment

### Example Usage

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Comment.GetKmsCommentAsync(
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

**[GetKmsCommentResponse](../../Models/Requests/GetKmsCommentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetTaskComment

Retrieve a comment

### Example Usage

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Comment.GetTaskCommentAsync(
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

**[GetTaskCommentResponse](../../Models/Requests/GetTaskCommentResponse.md)**

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

var res = await sdk.Comment.GetUcCommentAsync(
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

## ListKmsComments

List all comments

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListKmsCommentsRequest req = new ListKmsCommentsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Comment.ListKmsCommentsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [ListKmsCommentsRequest](../../Models/Requests/ListKmsCommentsRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[ListKmsCommentsResponse](../../Models/Requests/ListKmsCommentsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListTaskComments

List all comments

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListTaskCommentsRequest req = new ListTaskCommentsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Comment.ListTaskCommentsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListTaskCommentsRequest](../../Models/Requests/ListTaskCommentsRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[ListTaskCommentsResponse](../../Models/Requests/ListTaskCommentsResponse.md)**

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

var res = await sdk.Comment.ListUcCommentsAsync(req);

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

## PatchKmsComment

Update a comment

### Example Usage

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Comment.PatchKmsCommentAsync(
    kmsComment: new KmsComment() {
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

| Parameter                                           | Type                                                | Required                                            | Description                                         |
| --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- |
| `KmsComment`                                        | [KmsComment](../../Models/Components/KmsComment.md) | :heavy_check_mark:                                  | N/A                                                 |
| `ConnectionId`                                      | *string*                                            | :heavy_check_mark:                                  | ID of the connection                                |
| `Id`                                                | *string*                                            | :heavy_check_mark:                                  | ID of the Comment                                   |
| `Fields`                                            | List<*string*>                                      | :heavy_minus_sign:                                  | Comma-delimited fields to return                    |

### Response

**[PatchKmsCommentResponse](../../Models/Requests/PatchKmsCommentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchTaskComment

Update a comment

### Example Usage

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Comment.PatchTaskCommentAsync(
    taskComment: new TaskComment() {
        TaskId = "<id>",
        Text = "<value>",
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

| Parameter                                             | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `TaskComment`                                         | [TaskComment](../../Models/Components/TaskComment.md) | :heavy_check_mark:                                    | N/A                                                   |
| `ConnectionId`                                        | *string*                                              | :heavy_check_mark:                                    | ID of the connection                                  |
| `Id`                                                  | *string*                                              | :heavy_check_mark:                                    | ID of the Comment                                     |
| `Fields`                                              | List<*string*>                                        | :heavy_minus_sign:                                    | Comma-delimited fields to return                      |

### Response

**[PatchTaskCommentResponse](../../Models/Requests/PatchTaskCommentResponse.md)**

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

var res = await sdk.Comment.PatchUcCommentAsync(
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

## RemoveKmsComment

Remove a comment

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Comment.RemoveKmsCommentAsync(
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

**[RemoveKmsCommentResponse](../../Models/Requests/RemoveKmsCommentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveTaskComment

Remove a comment

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Comment.RemoveTaskCommentAsync(
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

**[RemoveTaskCommentResponse](../../Models/Requests/RemoveTaskCommentResponse.md)**

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

var res = await sdk.Comment.RemoveUcCommentAsync(
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

## UpdateKmsComment

Update a comment

### Example Usage

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Comment.UpdateKmsCommentAsync(
    kmsComment: new KmsComment() {
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

| Parameter                                           | Type                                                | Required                                            | Description                                         |
| --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- |
| `KmsComment`                                        | [KmsComment](../../Models/Components/KmsComment.md) | :heavy_check_mark:                                  | N/A                                                 |
| `ConnectionId`                                      | *string*                                            | :heavy_check_mark:                                  | ID of the connection                                |
| `Id`                                                | *string*                                            | :heavy_check_mark:                                  | ID of the Comment                                   |
| `Fields`                                            | List<*string*>                                      | :heavy_minus_sign:                                  | Comma-delimited fields to return                    |

### Response

**[UpdateKmsCommentResponse](../../Models/Requests/UpdateKmsCommentResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateTaskComment

Update a comment

### Example Usage

```csharp
using System.Collections.Generic;
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Comment.UpdateTaskCommentAsync(
    taskComment: new TaskComment() {
        TaskId = "<id>",
        Text = "<value>",
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

| Parameter                                             | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `TaskComment`                                         | [TaskComment](../../Models/Components/TaskComment.md) | :heavy_check_mark:                                    | N/A                                                   |
| `ConnectionId`                                        | *string*                                              | :heavy_check_mark:                                    | ID of the connection                                  |
| `Id`                                                  | *string*                                              | :heavy_check_mark:                                    | ID of the Comment                                     |
| `Fields`                                              | List<*string*>                                        | :heavy_minus_sign:                                    | Comma-delimited fields to return                      |

### Response

**[UpdateTaskCommentResponse](../../Models/Requests/UpdateTaskCommentResponse.md)**

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

var res = await sdk.Comment.UpdateUcCommentAsync(
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