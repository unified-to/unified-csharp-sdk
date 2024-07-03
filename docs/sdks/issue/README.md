# Issue
(*Issue*)

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

var res = await sdk.Issue.ListUnifiedIssuesAsync(
    limit: 7069.08D,
    offset: 7461.37D,
    updatedGte: System.DateTime.Parse("2022-01-21T01:55:24.746Z"));

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `Limit`                                                                               | *double*                                                                              | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `Offset`                                                                              | *double*                                                                              | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `UpdatedGte`                                                                          | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_minus_sign:                                                                    | Return only results whose updated date is equal or greater to this value              |


### Response

**[ListUnifiedIssuesResponse](../../Models/Requests/ListUnifiedIssuesResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |
