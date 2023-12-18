# Organization
(*Organization*)

### Available Operations

* [GetAccountingOrganization](#getaccountingorganization) - Retrieve an organization
* [ListAccountingOrganizations](#listaccountingorganizations) - List all organizations

## GetAccountingOrganization

Retrieve an organization

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Organization.GetAccountingOrganizationAsync(ConnectionId: "string", Id: "string", Fields: new List<string>() {
    "string",
});

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Organization           |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetAccountingOrganizationResponse](../../Models/Requests/GetAccountingOrganizationResponse.md)**


## ListAccountingOrganizations

List all organizations

### Example Usage

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListAccountingOrganizationsRequest req = new ListAccountingOrganizationsRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
};

var res = await sdk.Organization.ListAccountingOrganizationsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [ListAccountingOrganizationsRequest](../../Models/Requests/ListAccountingOrganizationsRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |


### Response

**[ListAccountingOrganizationsResponse](../../Models/Requests/ListAccountingOrganizationsResponse.md)**

