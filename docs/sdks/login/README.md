# Login
(*Login*)

### Available Operations

* [GetUnifiedIntegrationLogin](#getunifiedintegrationlogin) - Sign in a user

## GetUnifiedIntegrationLogin

Returns an authentication URL for the specified integration.  Once a successful authentication occurs, the name and emails are returned.

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "",
    });

GetUnifiedIntegrationLoginRequest req = new GetUnifiedIntegrationLoginRequest() {
    IntegrationType = "string",
    WorkspaceId = "string",
};

var res = await sdk.Login.GetUnifiedIntegrationLoginAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [GetUnifiedIntegrationLoginRequest](../../Models/Requests/GetUnifiedIntegrationLoginRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |


### Response

**[GetUnifiedIntegrationLoginResponse](../../Models/Requests/GetUnifiedIntegrationLoginResponse.md)**

