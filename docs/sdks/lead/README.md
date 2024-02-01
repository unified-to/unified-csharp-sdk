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
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Lead.CreateCrmLeadAsync(
    connectionId: "string",
    crmLead: new CrmLead() {
    Address = new PropertyCrmLeadAddress() {},
    Emails = new List<CrmEmail>() {
        new CrmEmail() {},
    },
    Raw = new Dictionary<string, object>() {
        { "key", "string" },
    },
    Telephones = new List<CrmTelephone>() {
        new CrmTelephone() {
            Telephone = "string",
        },
    },
});

// handle response
```

### Parameters

| Parameter                                     | Type                                          | Required                                      | Description                                   |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| `ConnectionId`                                | *string*                                      | :heavy_check_mark:                            | ID of the connection                          |
| `CrmLead`                                     | [CrmLead](../../Models/Components/CrmLead.md) | :heavy_minus_sign:                            | N/A                                           |


### Response

**[CreateCrmLeadResponse](../../Models/Requests/CreateCrmLeadResponse.md)**


## GetCrmLead

Retrieve a lead

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Lead.GetCrmLeadAsync(
    connectionId: "string",
    id: "string",
    fields: new List<string>() {
    "string",
});

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Lead                   |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetCrmLeadResponse](../../Models/Requests/GetCrmLeadResponse.md)**


## ListCrmLeads

List all leads

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListCrmLeadsRequest req = new ListCrmLeadsRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
};

var res = await sdk.Lead.ListCrmLeadsAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [ListCrmLeadsRequest](../../Models/Requests/ListCrmLeadsRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |


### Response

**[ListCrmLeadsResponse](../../Models/Requests/ListCrmLeadsResponse.md)**


## PatchCrmLead

Update a lead

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Lead.PatchCrmLeadAsync(
    connectionId: "string",
    id: "string",
    crmLead: new CrmLead() {
    Address = new PropertyCrmLeadAddress() {},
    Emails = new List<CrmEmail>() {
        new CrmEmail() {},
    },
    Raw = new Dictionary<string, object>() {
        { "key", "string" },
    },
    Telephones = new List<CrmTelephone>() {
        new CrmTelephone() {
            Telephone = "string",
        },
    },
});

// handle response
```

### Parameters

| Parameter                                     | Type                                          | Required                                      | Description                                   |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| `ConnectionId`                                | *string*                                      | :heavy_check_mark:                            | ID of the connection                          |
| `Id`                                          | *string*                                      | :heavy_check_mark:                            | ID of the Lead                                |
| `CrmLead`                                     | [CrmLead](../../Models/Components/CrmLead.md) | :heavy_minus_sign:                            | N/A                                           |


### Response

**[PatchCrmLeadResponse](../../Models/Requests/PatchCrmLeadResponse.md)**


## RemoveCrmLead

Remove a lead

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Lead.RemoveCrmLeadAsync(
    connectionId: "string",
    id: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Lead       |


### Response

**[RemoveCrmLeadResponse](../../Models/Requests/RemoveCrmLeadResponse.md)**


## UpdateCrmLead

Update a lead

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Lead.UpdateCrmLeadAsync(
    connectionId: "string",
    id: "string",
    crmLead: new CrmLead() {
    Address = new PropertyCrmLeadAddress() {},
    Emails = new List<CrmEmail>() {
        new CrmEmail() {},
    },
    Raw = new Dictionary<string, object>() {
        { "key", "string" },
    },
    Telephones = new List<CrmTelephone>() {
        new CrmTelephone() {
            Telephone = "string",
        },
    },
});

// handle response
```

### Parameters

| Parameter                                     | Type                                          | Required                                      | Description                                   |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| `ConnectionId`                                | *string*                                      | :heavy_check_mark:                            | ID of the connection                          |
| `Id`                                          | *string*                                      | :heavy_check_mark:                            | ID of the Lead                                |
| `CrmLead`                                     | [CrmLead](../../Models/Components/CrmLead.md) | :heavy_minus_sign:                            | N/A                                           |


### Response

**[UpdateCrmLeadResponse](../../Models/Requests/UpdateCrmLeadResponse.md)**

