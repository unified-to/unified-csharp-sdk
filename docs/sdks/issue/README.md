# Issue
(*Issue*)

## Overview

### Available Operations

* [ListUnifiedIssues](#listunifiedissues) - List support issues

## ListUnifiedIssues

List support issues

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
    Jwt = "<YOUR_API_KEY_HERE>",
});

ListUnifiedIssuesRequest req = ;

var res = await sdk.Issue.ListUnifiedIssuesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListUnifiedIssuesRequest](../../Models/Requests/ListUnifiedIssuesRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[ListUnifiedIssuesResponse](../../Models/Requests/ListUnifiedIssuesResponse.md)**

### Errors

| Error Type                           | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4XX, 5XX                             | \*/\*                                |