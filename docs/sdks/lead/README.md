# Lead
(*Lead*)

### Available Operations

* [CreateCrmLead](#createcrmlead) - Create a lead
* [GetCrmLead](#getcrmlead) - Retrieve a lead
* [ListCrmLeads](#listcrmleads) - List all leads
* [PatchCrmLead](#patchcrmlead) - Update a lead
* [RemoveCrmLead](#removecrmlead) - Remove a lead
* [UpdateCrmLead](#updatecrmlead) - Update a lead

## CreateCrmLead

Create a lead

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Lead.CreateCrmLeadAsync(
    security: new CreateCrmLeadSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    crmLead: new CrmLead() {});

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `security`                                                                                        | [UnifiedTo.Models.Requests.CreateCrmLeadSecurity](../../Models/Requests/CreateCrmLeadSecurity.md) | :heavy_check_mark:                                                                                | The security requirements to use for the request.                                                 |
| `ConnectionId`                                                                                    | *string*                                                                                          | :heavy_check_mark:                                                                                | ID of the connection                                                                              |
| `CrmLead`                                                                                         | [CrmLead](../../Models/Components/CrmLead.md)                                                     | :heavy_minus_sign:                                                                                | N/A                                                                                               |


### Response

**[CreateCrmLeadResponse](../../Models/Requests/CreateCrmLeadResponse.md)**


## GetCrmLead

Retrieve a lead

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Lead.GetCrmLeadAsync(
    security: new GetCrmLeadSecurity() {
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

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `security`                                                                                  | [UnifiedTo.Models.Requests.GetCrmLeadSecurity](../../Models/Requests/GetCrmLeadSecurity.md) | :heavy_check_mark:                                                                          | The security requirements to use for the request.                                           |
| `ConnectionId`                                                                              | *string*                                                                                    | :heavy_check_mark:                                                                          | ID of the connection                                                                        |
| `Id`                                                                                        | *string*                                                                                    | :heavy_check_mark:                                                                          | ID of the Lead                                                                              |
| `Fields`                                                                                    | List<*string*>                                                                              | :heavy_minus_sign:                                                                          | Comma-delimited fields to return                                                            |


### Response

**[GetCrmLeadResponse](../../Models/Requests/GetCrmLeadResponse.md)**


## ListCrmLeads

List all leads

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListCrmLeadsRequest req = new ListCrmLeadsRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Lead.ListCrmLeadsAsync(
    security: new ListCrmLeadsSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [ListCrmLeadsRequest](../../Models/Requests/ListCrmLeadsRequest.md)                             | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |
| `security`                                                                                      | [UnifiedTo.Models.Requests.ListCrmLeadsSecurity](../../Models/Requests/ListCrmLeadsSecurity.md) | :heavy_check_mark:                                                                              | The security requirements to use for the request.                                               |


### Response

**[ListCrmLeadsResponse](../../Models/Requests/ListCrmLeadsResponse.md)**


## PatchCrmLead

Update a lead

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Lead.PatchCrmLeadAsync(
    security: new PatchCrmLeadSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    crmLead: new CrmLead() {});

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `security`                                                                                      | [UnifiedTo.Models.Requests.PatchCrmLeadSecurity](../../Models/Requests/PatchCrmLeadSecurity.md) | :heavy_check_mark:                                                                              | The security requirements to use for the request.                                               |
| `ConnectionId`                                                                                  | *string*                                                                                        | :heavy_check_mark:                                                                              | ID of the connection                                                                            |
| `Id`                                                                                            | *string*                                                                                        | :heavy_check_mark:                                                                              | ID of the Lead                                                                                  |
| `CrmLead`                                                                                       | [CrmLead](../../Models/Components/CrmLead.md)                                                   | :heavy_minus_sign:                                                                              | N/A                                                                                             |


### Response

**[PatchCrmLeadResponse](../../Models/Requests/PatchCrmLeadResponse.md)**


## RemoveCrmLead

Remove a lead

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Lead.RemoveCrmLeadAsync(
    security: new RemoveCrmLeadSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `security`                                                                                        | [UnifiedTo.Models.Requests.RemoveCrmLeadSecurity](../../Models/Requests/RemoveCrmLeadSecurity.md) | :heavy_check_mark:                                                                                | The security requirements to use for the request.                                                 |
| `ConnectionId`                                                                                    | *string*                                                                                          | :heavy_check_mark:                                                                                | ID of the connection                                                                              |
| `Id`                                                                                              | *string*                                                                                          | :heavy_check_mark:                                                                                | ID of the Lead                                                                                    |


### Response

**[RemoveCrmLeadResponse](../../Models/Requests/RemoveCrmLeadResponse.md)**


## UpdateCrmLead

Update a lead

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Lead.UpdateCrmLeadAsync(
    security: new UpdateCrmLeadSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    crmLead: new CrmLead() {});

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `security`                                                                                        | [UnifiedTo.Models.Requests.UpdateCrmLeadSecurity](../../Models/Requests/UpdateCrmLeadSecurity.md) | :heavy_check_mark:                                                                                | The security requirements to use for the request.                                                 |
| `ConnectionId`                                                                                    | *string*                                                                                          | :heavy_check_mark:                                                                                | ID of the connection                                                                              |
| `Id`                                                                                              | *string*                                                                                          | :heavy_check_mark:                                                                                | ID of the Lead                                                                                    |
| `CrmLead`                                                                                         | [CrmLead](../../Models/Components/CrmLead.md)                                                     | :heavy_minus_sign:                                                                                | N/A                                                                                               |


### Response

**[UpdateCrmLeadResponse](../../Models/Requests/UpdateCrmLeadResponse.md)**

