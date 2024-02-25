# Issue
(*Issue*)

### Available Operations

* [ListUnifiedIssues](#listunifiedissues) - List support issues

## ListUnifiedIssues

List support issues

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

ListUnifiedIssuesRequest req = new ListUnifiedIssuesRequest() {};

var res = await sdk.Issue.ListUnifiedIssuesAsync(
    security: new ListUnifiedIssuesSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                 | [ListUnifiedIssuesRequest](../../Models/Requests/ListUnifiedIssuesRequest.md)                             | :heavy_check_mark:                                                                                        | The request object to use for the request.                                                                |
| `security`                                                                                                | [UnifiedTo.Models.Requests.ListUnifiedIssuesSecurity](../../Models/Requests/ListUnifiedIssuesSecurity.md) | :heavy_check_mark:                                                                                        | The security requirements to use for the request.                                                         |


### Response

**[ListUnifiedIssuesResponse](../../Models/Requests/ListUnifiedIssuesResponse.md)**

