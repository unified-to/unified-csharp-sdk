# Organization
(*Organization*)

### Available Operations

* [GetAccountingOrganization](#getaccountingorganization) - Retrieve an organization
* [ListAccountingOrganizations](#listaccountingorganizations) - List all organizations

## GetAccountingOrganization

Retrieve an organization

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Organization.GetAccountingOrganizationAsync(
    security: new GetAccountingOrganizationSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    fields: new List<string>() {
    "<value>",
});

// handle response
```

### Parameters

| Parameter                                                                                                                 | Type                                                                                                                      | Required                                                                                                                  | Description                                                                                                               |
| ------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                | [UnifiedTo.Models.Requests.GetAccountingOrganizationSecurity](../../Models/Requests/GetAccountingOrganizationSecurity.md) | :heavy_check_mark:                                                                                                        | The security requirements to use for the request.                                                                         |
| `ConnectionId`                                                                                                            | *string*                                                                                                                  | :heavy_check_mark:                                                                                                        | ID of the connection                                                                                                      |
| `Id`                                                                                                                      | *string*                                                                                                                  | :heavy_check_mark:                                                                                                        | ID of the Organization                                                                                                    |
| `Fields`                                                                                                                  | List<*string*>                                                                                                            | :heavy_minus_sign:                                                                                                        | Comma-delimited fields to return                                                                                          |


### Response

**[GetAccountingOrganizationResponse](../../Models/Requests/GetAccountingOrganizationResponse.md)**


## ListAccountingOrganizations

List all organizations

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListAccountingOrganizationsRequest req = new ListAccountingOrganizationsRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Organization.ListAccountingOrganizationsAsync(
    security: new ListAccountingOrganizationsSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                                                     | Type                                                                                                                          | Required                                                                                                                      | Description                                                                                                                   |
| ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                                     | [ListAccountingOrganizationsRequest](../../Models/Requests/ListAccountingOrganizationsRequest.md)                             | :heavy_check_mark:                                                                                                            | The request object to use for the request.                                                                                    |
| `security`                                                                                                                    | [UnifiedTo.Models.Requests.ListAccountingOrganizationsSecurity](../../Models/Requests/ListAccountingOrganizationsSecurity.md) | :heavy_check_mark:                                                                                                            | The security requirements to use for the request.                                                                             |


### Response

**[ListAccountingOrganizationsResponse](../../Models/Requests/ListAccountingOrganizationsResponse.md)**

