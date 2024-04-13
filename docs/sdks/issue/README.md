# Issue
(*Issue*)

### Available Operations

* [ListUnifiedIssues](#listunifiedissues) - List support issues
* [ListUnifiedSupports](#listunifiedsupports) - Get support info

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

ListUnifiedIssuesRequest req = new ListUnifiedIssuesRequest() {};

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

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## ListUnifiedSupports

Get support info

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Issue.ListUnifiedSupportsAsync();

// handle response
```


### Response

**[ListUnifiedSupportsResponse](../../Models/Requests/ListUnifiedSupportsResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |
