# Post

## Overview

### Available Operations

* [CreateSocialPost](#createsocialpost) - Create a post
* [GetSocialPost](#getsocialpost) - Retrieve a post
* [ListSocialPosts](#listsocialposts) - List all posts
* [PatchSocialPost](#patchsocialpost) - Update a post
* [RemoveSocialPost](#removesocialpost) - Remove a post
* [UpdateSocialPost](#updatesocialpost) - Update a post

## CreateSocialPost

Creates a SocialPost. Provide the unified SocialPost fields in the request body; they are mapped to the provider's API. Returns the created SocialPost.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createSocialPost" method="post" path="/social/{connection_id}/post" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Post.CreateSocialPostAsync(
    socialPost: new SocialPost() {},
    connectionId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `SocialPost`                                                                                                                                     | [SocialPost](../../Models/Components/SocialPost.md)                                                                                              | :heavy_check_mark:                                                                                                                               | N/A                                                                                                                                              |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Fields`                                                                                                                                         | List<[CreateSocialPostQueryParamFields](../../Models/Requests/CreateSocialPostQueryParamFields.md)>                                              | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[CreateSocialPostResponse](../../Models/Requests/CreateSocialPostResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## GetSocialPost

Retrieves a single SocialPost by its `id`. Obtain `id` values from the corresponding list endpoint. Use `fields` to return only the fields you need.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getSocialPost" method="get" path="/social/{connection_id}/post/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Post.GetSocialPostAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                        | Type                                                                                                                                             | Required                                                                                                                                         | Description                                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectionId`                                                                                                                                   | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the connection                                                                                                                             |
| `Id`                                                                                                                                             | *string*                                                                                                                                         | :heavy_check_mark:                                                                                                                               | ID of the Post                                                                                                                                   |
| `Fields`                                                                                                                                         | List<[GetSocialPostQueryParamFields](../../Models/Requests/GetSocialPostQueryParamFields.md)>                                                    | :heavy_minus_sign:                                                                                                                               | Fields to return                                                                                                                                 |
| `Raw`                                                                                                                                            | *string*                                                                                                                                         | :heavy_minus_sign:                                                                                                                               | Raw parameters to include in the 3rd-party request. Encoded as a URL component. eg. raw parameters: foo=bar&zoo=bar -> raw=foo%3Dbar%26zoo%3Dbar |

### Response

**[GetSocialPostResponse](../../Models/Requests/GetSocialPostResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## ListSocialPosts

Returns a list of SocialPosts. Narrow the results with the query parameters before paging, then page through them with `limit` and `offset` (the default and maximum page size depend on the integration). Use `fields` to return only the fields you need and reduce the response size. When the integration supports a total count, it is returned in the `X-Total-Count` response header. Use each item's `id` to retrieve, update, or delete it where those operations are supported.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listSocialPosts" method="get" path="/social/{connection_id}/post" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListSocialPostsRequest req = new ListSocialPostsRequest() {
    ConnectionId = "<id>",
};

var res = await sdk.Post.ListSocialPostsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [ListSocialPostsRequest](../../Models/Requests/ListSocialPostsRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[ListSocialPostsResponse](../../Models/Requests/ListSocialPostsResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## PatchSocialPost

Updates the SocialPost identified by `id`. Provide the unified SocialPost fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="patchSocialPost" method="patch" path="/social/{connection_id}/post/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

PatchSocialPostRequest req = new PatchSocialPostRequest() {
    SocialPost = new SocialPost() {},
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Post.PatchSocialPostAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [PatchSocialPostRequest](../../Models/Requests/PatchSocialPostRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[PatchSocialPostResponse](../../Models/Requests/PatchSocialPostResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## RemoveSocialPost

Deletes the SocialPost identified by `id`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeSocialPost" method="delete" path="/social/{connection_id}/post/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Post.RemoveSocialPostAsync(
    connectionId: "<id>",
    id: "<id>"
);

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Post       |

### Response

**[RemoveSocialPostResponse](../../Models/Requests/RemoveSocialPostResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |

## UpdateSocialPost

Updates the SocialPost identified by `id`. Provide the unified SocialPost fields to change in the request body.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateSocialPost" method="put" path="/social/{connection_id}/post/{id}" -->
```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

UpdateSocialPostRequest req = new UpdateSocialPostRequest() {
    SocialPost = new SocialPost() {},
    ConnectionId = "<id>",
    Id = "<id>",
};

var res = await sdk.Post.UpdateSocialPostAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [UpdateSocialPostRequest](../../Models/Requests/UpdateSocialPostRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[UpdateSocialPostResponse](../../Models/Requests/UpdateSocialPostResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |