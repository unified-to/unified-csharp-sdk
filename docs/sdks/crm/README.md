# Crm
(*Crm*)

### Available Operations

* [CreateCrmCompany](#createcrmcompany) - Create a company
* [CreateCrmContact](#createcrmcontact) - Create a contact
* [CreateCrmDeal](#createcrmdeal) - Create a deal
* [CreateCrmEvent](#createcrmevent) - Create a event
* [CreateCrmLead](#createcrmlead) - Create a lead
* [CreateCrmPipeline](#createcrmpipeline) - Create a pipeline
* [GetCrmCompany](#getcrmcompany) - Retrieve a company
* [GetCrmContact](#getcrmcontact) - Retrieve a contact
* [GetCrmDeal](#getcrmdeal) - Retrieve a deal
* [GetCrmEvent](#getcrmevent) - Retrieve a event
* [GetCrmLead](#getcrmlead) - Retrieve a lead
* [GetCrmPipeline](#getcrmpipeline) - Retrieve a pipeline
* [ListCrmCompanies](#listcrmcompanies) - List all companies
* [ListCrmContacts](#listcrmcontacts) - List all contacts
* [ListCrmDeals](#listcrmdeals) - List all deals
* [ListCrmEvents](#listcrmevents) - List all events
* [ListCrmLeads](#listcrmleads) - List all leads
* [ListCrmPipelines](#listcrmpipelines) - List all pipelines
* [PatchCrmCompany](#patchcrmcompany) - Update a company
* [PatchCrmContact](#patchcrmcontact) - Update a contact
* [PatchCrmDeal](#patchcrmdeal) - Update a deal
* [PatchCrmEvent](#patchcrmevent) - Update a event
* [PatchCrmLead](#patchcrmlead) - Update a lead
* [PatchCrmPipeline](#patchcrmpipeline) - Update a pipeline
* [RemoveCrmCompany](#removecrmcompany) - Remove a company
* [RemoveCrmContact](#removecrmcontact) - Remove a contact
* [RemoveCrmDeal](#removecrmdeal) - Remove a deal
* [RemoveCrmEvent](#removecrmevent) - Remove a event
* [RemoveCrmLead](#removecrmlead) - Remove a lead
* [RemoveCrmPipeline](#removecrmpipeline) - Remove a pipeline
* [UpdateCrmCompany](#updatecrmcompany) - Update a company
* [UpdateCrmContact](#updatecrmcontact) - Update a contact
* [UpdateCrmDeal](#updatecrmdeal) - Update a deal
* [UpdateCrmEvent](#updatecrmevent) - Update a event
* [UpdateCrmLead](#updatecrmlead) - Update a lead
* [UpdateCrmPipeline](#updatecrmpipeline) - Update a pipeline

## CreateCrmCompany

Create a company

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Crm.CreateCrmCompanyAsync(
    security: new CreateCrmCompanySecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    crmCompany: new CrmCompany() {});

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `security`                                                                                              | [UnifiedTo.Models.Requests.CreateCrmCompanySecurity](../../Models/Requests/CreateCrmCompanySecurity.md) | :heavy_check_mark:                                                                                      | The security requirements to use for the request.                                                       |
| `ConnectionId`                                                                                          | *string*                                                                                                | :heavy_check_mark:                                                                                      | ID of the connection                                                                                    |
| `CrmCompany`                                                                                            | [CrmCompany](../../Models/Components/CrmCompany.md)                                                     | :heavy_minus_sign:                                                                                      | A company represents an organization that optionally is associated with a deal and/or contacts          |


### Response

**[CreateCrmCompanyResponse](../../Models/Requests/CreateCrmCompanyResponse.md)**


## CreateCrmContact

Create a contact

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Crm.CreateCrmContactAsync(
    security: new CreateCrmContactSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    crmContact: new CrmContact() {});

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `security`                                                                                              | [UnifiedTo.Models.Requests.CreateCrmContactSecurity](../../Models/Requests/CreateCrmContactSecurity.md) | :heavy_check_mark:                                                                                      | The security requirements to use for the request.                                                       |
| `ConnectionId`                                                                                          | *string*                                                                                                | :heavy_check_mark:                                                                                      | ID of the connection                                                                                    |
| `CrmContact`                                                                                            | [CrmContact](../../Models/Components/CrmContact.md)                                                     | :heavy_minus_sign:                                                                                      | A contact represents a person that optionally is associated with a deal and/or a company                |


### Response

**[CreateCrmContactResponse](../../Models/Requests/CreateCrmContactResponse.md)**


## CreateCrmDeal

Create a deal

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Crm.CreateCrmDealAsync(
    security: new CreateCrmDealSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    crmDeal: new CrmDeal() {});

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `security`                                                                                        | [UnifiedTo.Models.Requests.CreateCrmDealSecurity](../../Models/Requests/CreateCrmDealSecurity.md) | :heavy_check_mark:                                                                                | The security requirements to use for the request.                                                 |
| `ConnectionId`                                                                                    | *string*                                                                                          | :heavy_check_mark:                                                                                | ID of the connection                                                                              |
| `CrmDeal`                                                                                         | [CrmDeal](../../Models/Components/CrmDeal.md)                                                     | :heavy_minus_sign:                                                                                | A deal represents an opportunity with companies and/or contacts                                   |


### Response

**[CreateCrmDealResponse](../../Models/Requests/CreateCrmDealResponse.md)**


## CreateCrmEvent

Create a event

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Crm.CreateCrmEventAsync(
    security: new CreateCrmEventSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    crmEvent: new CrmEvent() {});

// handle response
```

### Parameters

| Parameter                                                                                                       | Type                                                                                                            | Required                                                                                                        | Description                                                                                                     |
| --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                      | [UnifiedTo.Models.Requests.CreateCrmEventSecurity](../../Models/Requests/CreateCrmEventSecurity.md)             | :heavy_check_mark:                                                                                              | The security requirements to use for the request.                                                               |
| `ConnectionId`                                                                                                  | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the connection                                                                                            |
| `CrmEvent`                                                                                                      | [CrmEvent](../../Models/Components/CrmEvent.md)                                                                 | :heavy_minus_sign:                                                                                              | An event represents an event, activity, or engagement and is always associated with a deal, contact, or company |


### Response

**[CreateCrmEventResponse](../../Models/Requests/CreateCrmEventResponse.md)**


## CreateCrmLead

Create a lead

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Crm.CreateCrmLeadAsync(
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


## CreateCrmPipeline

Create a pipeline

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Crm.CreateCrmPipelineAsync(
    security: new CreateCrmPipelineSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    crmPipeline: new CrmPipeline() {});

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                | [UnifiedTo.Models.Requests.CreateCrmPipelineSecurity](../../Models/Requests/CreateCrmPipelineSecurity.md) | :heavy_check_mark:                                                                                        | The security requirements to use for the request.                                                         |
| `ConnectionId`                                                                                            | *string*                                                                                                  | :heavy_check_mark:                                                                                        | ID of the connection                                                                                      |
| `CrmPipeline`                                                                                             | [CrmPipeline](../../Models/Components/CrmPipeline.md)                                                     | :heavy_minus_sign:                                                                                        | N/A                                                                                                       |


### Response

**[CreateCrmPipelineResponse](../../Models/Requests/CreateCrmPipelineResponse.md)**


## GetCrmCompany

Retrieve a company

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Crm.GetCrmCompanyAsync(
    security: new GetCrmCompanySecurity() {
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

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `security`                                                                                        | [UnifiedTo.Models.Requests.GetCrmCompanySecurity](../../Models/Requests/GetCrmCompanySecurity.md) | :heavy_check_mark:                                                                                | The security requirements to use for the request.                                                 |
| `ConnectionId`                                                                                    | *string*                                                                                          | :heavy_check_mark:                                                                                | ID of the connection                                                                              |
| `Id`                                                                                              | *string*                                                                                          | :heavy_check_mark:                                                                                | ID of the Company                                                                                 |
| `Fields`                                                                                          | List<*string*>                                                                                    | :heavy_minus_sign:                                                                                | Comma-delimited fields to return                                                                  |


### Response

**[GetCrmCompanyResponse](../../Models/Requests/GetCrmCompanyResponse.md)**


## GetCrmContact

Retrieve a contact

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Crm.GetCrmContactAsync(
    security: new GetCrmContactSecurity() {
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

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `security`                                                                                        | [UnifiedTo.Models.Requests.GetCrmContactSecurity](../../Models/Requests/GetCrmContactSecurity.md) | :heavy_check_mark:                                                                                | The security requirements to use for the request.                                                 |
| `ConnectionId`                                                                                    | *string*                                                                                          | :heavy_check_mark:                                                                                | ID of the connection                                                                              |
| `Id`                                                                                              | *string*                                                                                          | :heavy_check_mark:                                                                                | ID of the Contact                                                                                 |
| `Fields`                                                                                          | List<*string*>                                                                                    | :heavy_minus_sign:                                                                                | Comma-delimited fields to return                                                                  |


### Response

**[GetCrmContactResponse](../../Models/Requests/GetCrmContactResponse.md)**


## GetCrmDeal

Retrieve a deal

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Crm.GetCrmDealAsync(
    security: new GetCrmDealSecurity() {
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
| `security`                                                                                  | [UnifiedTo.Models.Requests.GetCrmDealSecurity](../../Models/Requests/GetCrmDealSecurity.md) | :heavy_check_mark:                                                                          | The security requirements to use for the request.                                           |
| `ConnectionId`                                                                              | *string*                                                                                    | :heavy_check_mark:                                                                          | ID of the connection                                                                        |
| `Id`                                                                                        | *string*                                                                                    | :heavy_check_mark:                                                                          | ID of the Deal                                                                              |
| `Fields`                                                                                    | List<*string*>                                                                              | :heavy_minus_sign:                                                                          | Comma-delimited fields to return                                                            |


### Response

**[GetCrmDealResponse](../../Models/Requests/GetCrmDealResponse.md)**


## GetCrmEvent

Retrieve a event

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Crm.GetCrmEventAsync(
    security: new GetCrmEventSecurity() {
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

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `security`                                                                                    | [UnifiedTo.Models.Requests.GetCrmEventSecurity](../../Models/Requests/GetCrmEventSecurity.md) | :heavy_check_mark:                                                                            | The security requirements to use for the request.                                             |
| `ConnectionId`                                                                                | *string*                                                                                      | :heavy_check_mark:                                                                            | ID of the connection                                                                          |
| `Id`                                                                                          | *string*                                                                                      | :heavy_check_mark:                                                                            | ID of the Event                                                                               |
| `Fields`                                                                                      | List<*string*>                                                                                | :heavy_minus_sign:                                                                            | Comma-delimited fields to return                                                              |


### Response

**[GetCrmEventResponse](../../Models/Requests/GetCrmEventResponse.md)**


## GetCrmLead

Retrieve a lead

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Crm.GetCrmLeadAsync(
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


## GetCrmPipeline

Retrieve a pipeline

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Crm.GetCrmPipelineAsync(
    security: new GetCrmPipelineSecurity() {
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

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `security`                                                                                          | [UnifiedTo.Models.Requests.GetCrmPipelineSecurity](../../Models/Requests/GetCrmPipelineSecurity.md) | :heavy_check_mark:                                                                                  | The security requirements to use for the request.                                                   |
| `ConnectionId`                                                                                      | *string*                                                                                            | :heavy_check_mark:                                                                                  | ID of the connection                                                                                |
| `Id`                                                                                                | *string*                                                                                            | :heavy_check_mark:                                                                                  | ID of the Pipeline                                                                                  |
| `Fields`                                                                                            | List<*string*>                                                                                      | :heavy_minus_sign:                                                                                  | Comma-delimited fields to return                                                                    |


### Response

**[GetCrmPipelineResponse](../../Models/Requests/GetCrmPipelineResponse.md)**


## ListCrmCompanies

List all companies

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListCrmCompaniesRequest req = new ListCrmCompaniesRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Crm.ListCrmCompaniesAsync(
    security: new ListCrmCompaniesSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [ListCrmCompaniesRequest](../../Models/Requests/ListCrmCompaniesRequest.md)                             | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |
| `security`                                                                                              | [UnifiedTo.Models.Requests.ListCrmCompaniesSecurity](../../Models/Requests/ListCrmCompaniesSecurity.md) | :heavy_check_mark:                                                                                      | The security requirements to use for the request.                                                       |


### Response

**[ListCrmCompaniesResponse](../../Models/Requests/ListCrmCompaniesResponse.md)**


## ListCrmContacts

List all contacts

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListCrmContactsRequest req = new ListCrmContactsRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Crm.ListCrmContactsAsync(
    security: new ListCrmContactsSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `request`                                                                                             | [ListCrmContactsRequest](../../Models/Requests/ListCrmContactsRequest.md)                             | :heavy_check_mark:                                                                                    | The request object to use for the request.                                                            |
| `security`                                                                                            | [UnifiedTo.Models.Requests.ListCrmContactsSecurity](../../Models/Requests/ListCrmContactsSecurity.md) | :heavy_check_mark:                                                                                    | The security requirements to use for the request.                                                     |


### Response

**[ListCrmContactsResponse](../../Models/Requests/ListCrmContactsResponse.md)**


## ListCrmDeals

List all deals

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListCrmDealsRequest req = new ListCrmDealsRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Crm.ListCrmDealsAsync(
    security: new ListCrmDealsSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [ListCrmDealsRequest](../../Models/Requests/ListCrmDealsRequest.md)                             | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |
| `security`                                                                                      | [UnifiedTo.Models.Requests.ListCrmDealsSecurity](../../Models/Requests/ListCrmDealsSecurity.md) | :heavy_check_mark:                                                                              | The security requirements to use for the request.                                               |


### Response

**[ListCrmDealsResponse](../../Models/Requests/ListCrmDealsResponse.md)**


## ListCrmEvents

List all events

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListCrmEventsRequest req = new ListCrmEventsRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Crm.ListCrmEventsAsync(
    security: new ListCrmEventsSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [ListCrmEventsRequest](../../Models/Requests/ListCrmEventsRequest.md)                             | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |
| `security`                                                                                        | [UnifiedTo.Models.Requests.ListCrmEventsSecurity](../../Models/Requests/ListCrmEventsSecurity.md) | :heavy_check_mark:                                                                                | The security requirements to use for the request.                                                 |


### Response

**[ListCrmEventsResponse](../../Models/Requests/ListCrmEventsResponse.md)**


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

var res = await sdk.Crm.ListCrmLeadsAsync(
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


## ListCrmPipelines

List all pipelines

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

ListCrmPipelinesRequest req = new ListCrmPipelinesRequest() {
    ConnectionId = "<value>",
};

var res = await sdk.Crm.ListCrmPipelinesAsync(
    security: new ListCrmPipelinesSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    req);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [ListCrmPipelinesRequest](../../Models/Requests/ListCrmPipelinesRequest.md)                             | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |
| `security`                                                                                              | [UnifiedTo.Models.Requests.ListCrmPipelinesSecurity](../../Models/Requests/ListCrmPipelinesSecurity.md) | :heavy_check_mark:                                                                                      | The security requirements to use for the request.                                                       |


### Response

**[ListCrmPipelinesResponse](../../Models/Requests/ListCrmPipelinesResponse.md)**


## PatchCrmCompany

Update a company

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Crm.PatchCrmCompanyAsync(
    security: new PatchCrmCompanySecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    crmCompany: new CrmCompany() {});

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `security`                                                                                            | [UnifiedTo.Models.Requests.PatchCrmCompanySecurity](../../Models/Requests/PatchCrmCompanySecurity.md) | :heavy_check_mark:                                                                                    | The security requirements to use for the request.                                                     |
| `ConnectionId`                                                                                        | *string*                                                                                              | :heavy_check_mark:                                                                                    | ID of the connection                                                                                  |
| `Id`                                                                                                  | *string*                                                                                              | :heavy_check_mark:                                                                                    | ID of the Company                                                                                     |
| `CrmCompany`                                                                                          | [CrmCompany](../../Models/Components/CrmCompany.md)                                                   | :heavy_minus_sign:                                                                                    | A company represents an organization that optionally is associated with a deal and/or contacts        |


### Response

**[PatchCrmCompanyResponse](../../Models/Requests/PatchCrmCompanyResponse.md)**


## PatchCrmContact

Update a contact

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Crm.PatchCrmContactAsync(
    security: new PatchCrmContactSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    crmContact: new CrmContact() {});

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `security`                                                                                            | [UnifiedTo.Models.Requests.PatchCrmContactSecurity](../../Models/Requests/PatchCrmContactSecurity.md) | :heavy_check_mark:                                                                                    | The security requirements to use for the request.                                                     |
| `ConnectionId`                                                                                        | *string*                                                                                              | :heavy_check_mark:                                                                                    | ID of the connection                                                                                  |
| `Id`                                                                                                  | *string*                                                                                              | :heavy_check_mark:                                                                                    | ID of the Contact                                                                                     |
| `CrmContact`                                                                                          | [CrmContact](../../Models/Components/CrmContact.md)                                                   | :heavy_minus_sign:                                                                                    | A contact represents a person that optionally is associated with a deal and/or a company              |


### Response

**[PatchCrmContactResponse](../../Models/Requests/PatchCrmContactResponse.md)**


## PatchCrmDeal

Update a deal

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Crm.PatchCrmDealAsync(
    security: new PatchCrmDealSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    crmDeal: new CrmDeal() {});

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `security`                                                                                      | [UnifiedTo.Models.Requests.PatchCrmDealSecurity](../../Models/Requests/PatchCrmDealSecurity.md) | :heavy_check_mark:                                                                              | The security requirements to use for the request.                                               |
| `ConnectionId`                                                                                  | *string*                                                                                        | :heavy_check_mark:                                                                              | ID of the connection                                                                            |
| `Id`                                                                                            | *string*                                                                                        | :heavy_check_mark:                                                                              | ID of the Deal                                                                                  |
| `CrmDeal`                                                                                       | [CrmDeal](../../Models/Components/CrmDeal.md)                                                   | :heavy_minus_sign:                                                                              | A deal represents an opportunity with companies and/or contacts                                 |


### Response

**[PatchCrmDealResponse](../../Models/Requests/PatchCrmDealResponse.md)**


## PatchCrmEvent

Update a event

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Crm.PatchCrmEventAsync(
    security: new PatchCrmEventSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    crmEvent: new CrmEvent() {});

// handle response
```

### Parameters

| Parameter                                                                                                       | Type                                                                                                            | Required                                                                                                        | Description                                                                                                     |
| --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                      | [UnifiedTo.Models.Requests.PatchCrmEventSecurity](../../Models/Requests/PatchCrmEventSecurity.md)               | :heavy_check_mark:                                                                                              | The security requirements to use for the request.                                                               |
| `ConnectionId`                                                                                                  | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the connection                                                                                            |
| `Id`                                                                                                            | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the Event                                                                                                 |
| `CrmEvent`                                                                                                      | [CrmEvent](../../Models/Components/CrmEvent.md)                                                                 | :heavy_minus_sign:                                                                                              | An event represents an event, activity, or engagement and is always associated with a deal, contact, or company |


### Response

**[PatchCrmEventResponse](../../Models/Requests/PatchCrmEventResponse.md)**


## PatchCrmLead

Update a lead

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Crm.PatchCrmLeadAsync(
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


## PatchCrmPipeline

Update a pipeline

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Crm.PatchCrmPipelineAsync(
    security: new PatchCrmPipelineSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    crmPipeline: new CrmPipeline() {});

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `security`                                                                                              | [UnifiedTo.Models.Requests.PatchCrmPipelineSecurity](../../Models/Requests/PatchCrmPipelineSecurity.md) | :heavy_check_mark:                                                                                      | The security requirements to use for the request.                                                       |
| `ConnectionId`                                                                                          | *string*                                                                                                | :heavy_check_mark:                                                                                      | ID of the connection                                                                                    |
| `Id`                                                                                                    | *string*                                                                                                | :heavy_check_mark:                                                                                      | ID of the Pipeline                                                                                      |
| `CrmPipeline`                                                                                           | [CrmPipeline](../../Models/Components/CrmPipeline.md)                                                   | :heavy_minus_sign:                                                                                      | N/A                                                                                                     |


### Response

**[PatchCrmPipelineResponse](../../Models/Requests/PatchCrmPipelineResponse.md)**


## RemoveCrmCompany

Remove a company

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Crm.RemoveCrmCompanyAsync(
    security: new RemoveCrmCompanySecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `security`                                                                                              | [UnifiedTo.Models.Requests.RemoveCrmCompanySecurity](../../Models/Requests/RemoveCrmCompanySecurity.md) | :heavy_check_mark:                                                                                      | The security requirements to use for the request.                                                       |
| `ConnectionId`                                                                                          | *string*                                                                                                | :heavy_check_mark:                                                                                      | ID of the connection                                                                                    |
| `Id`                                                                                                    | *string*                                                                                                | :heavy_check_mark:                                                                                      | ID of the Company                                                                                       |


### Response

**[RemoveCrmCompanyResponse](../../Models/Requests/RemoveCrmCompanyResponse.md)**


## RemoveCrmContact

Remove a contact

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Crm.RemoveCrmContactAsync(
    security: new RemoveCrmContactSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `security`                                                                                              | [UnifiedTo.Models.Requests.RemoveCrmContactSecurity](../../Models/Requests/RemoveCrmContactSecurity.md) | :heavy_check_mark:                                                                                      | The security requirements to use for the request.                                                       |
| `ConnectionId`                                                                                          | *string*                                                                                                | :heavy_check_mark:                                                                                      | ID of the connection                                                                                    |
| `Id`                                                                                                    | *string*                                                                                                | :heavy_check_mark:                                                                                      | ID of the Contact                                                                                       |


### Response

**[RemoveCrmContactResponse](../../Models/Requests/RemoveCrmContactResponse.md)**


## RemoveCrmDeal

Remove a deal

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Crm.RemoveCrmDealAsync(
    security: new RemoveCrmDealSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `security`                                                                                        | [UnifiedTo.Models.Requests.RemoveCrmDealSecurity](../../Models/Requests/RemoveCrmDealSecurity.md) | :heavy_check_mark:                                                                                | The security requirements to use for the request.                                                 |
| `ConnectionId`                                                                                    | *string*                                                                                          | :heavy_check_mark:                                                                                | ID of the connection                                                                              |
| `Id`                                                                                              | *string*                                                                                          | :heavy_check_mark:                                                                                | ID of the Deal                                                                                    |


### Response

**[RemoveCrmDealResponse](../../Models/Requests/RemoveCrmDealResponse.md)**


## RemoveCrmEvent

Remove a event

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Crm.RemoveCrmEventAsync(
    security: new RemoveCrmEventSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `security`                                                                                          | [UnifiedTo.Models.Requests.RemoveCrmEventSecurity](../../Models/Requests/RemoveCrmEventSecurity.md) | :heavy_check_mark:                                                                                  | The security requirements to use for the request.                                                   |
| `ConnectionId`                                                                                      | *string*                                                                                            | :heavy_check_mark:                                                                                  | ID of the connection                                                                                |
| `Id`                                                                                                | *string*                                                                                            | :heavy_check_mark:                                                                                  | ID of the Event                                                                                     |


### Response

**[RemoveCrmEventResponse](../../Models/Requests/RemoveCrmEventResponse.md)**


## RemoveCrmLead

Remove a lead

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Crm.RemoveCrmLeadAsync(
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


## RemoveCrmPipeline

Remove a pipeline

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK();

var res = await sdk.Crm.RemoveCrmPipelineAsync(
    security: new RemoveCrmPipelineSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>");

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                | [UnifiedTo.Models.Requests.RemoveCrmPipelineSecurity](../../Models/Requests/RemoveCrmPipelineSecurity.md) | :heavy_check_mark:                                                                                        | The security requirements to use for the request.                                                         |
| `ConnectionId`                                                                                            | *string*                                                                                                  | :heavy_check_mark:                                                                                        | ID of the connection                                                                                      |
| `Id`                                                                                                      | *string*                                                                                                  | :heavy_check_mark:                                                                                        | ID of the Pipeline                                                                                        |


### Response

**[RemoveCrmPipelineResponse](../../Models/Requests/RemoveCrmPipelineResponse.md)**


## UpdateCrmCompany

Update a company

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Crm.UpdateCrmCompanyAsync(
    security: new UpdateCrmCompanySecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    crmCompany: new CrmCompany() {});

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `security`                                                                                              | [UnifiedTo.Models.Requests.UpdateCrmCompanySecurity](../../Models/Requests/UpdateCrmCompanySecurity.md) | :heavy_check_mark:                                                                                      | The security requirements to use for the request.                                                       |
| `ConnectionId`                                                                                          | *string*                                                                                                | :heavy_check_mark:                                                                                      | ID of the connection                                                                                    |
| `Id`                                                                                                    | *string*                                                                                                | :heavy_check_mark:                                                                                      | ID of the Company                                                                                       |
| `CrmCompany`                                                                                            | [CrmCompany](../../Models/Components/CrmCompany.md)                                                     | :heavy_minus_sign:                                                                                      | A company represents an organization that optionally is associated with a deal and/or contacts          |


### Response

**[UpdateCrmCompanyResponse](../../Models/Requests/UpdateCrmCompanyResponse.md)**


## UpdateCrmContact

Update a contact

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Crm.UpdateCrmContactAsync(
    security: new UpdateCrmContactSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    crmContact: new CrmContact() {});

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `security`                                                                                              | [UnifiedTo.Models.Requests.UpdateCrmContactSecurity](../../Models/Requests/UpdateCrmContactSecurity.md) | :heavy_check_mark:                                                                                      | The security requirements to use for the request.                                                       |
| `ConnectionId`                                                                                          | *string*                                                                                                | :heavy_check_mark:                                                                                      | ID of the connection                                                                                    |
| `Id`                                                                                                    | *string*                                                                                                | :heavy_check_mark:                                                                                      | ID of the Contact                                                                                       |
| `CrmContact`                                                                                            | [CrmContact](../../Models/Components/CrmContact.md)                                                     | :heavy_minus_sign:                                                                                      | A contact represents a person that optionally is associated with a deal and/or a company                |


### Response

**[UpdateCrmContactResponse](../../Models/Requests/UpdateCrmContactResponse.md)**


## UpdateCrmDeal

Update a deal

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Crm.UpdateCrmDealAsync(
    security: new UpdateCrmDealSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    crmDeal: new CrmDeal() {});

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `security`                                                                                        | [UnifiedTo.Models.Requests.UpdateCrmDealSecurity](../../Models/Requests/UpdateCrmDealSecurity.md) | :heavy_check_mark:                                                                                | The security requirements to use for the request.                                                 |
| `ConnectionId`                                                                                    | *string*                                                                                          | :heavy_check_mark:                                                                                | ID of the connection                                                                              |
| `Id`                                                                                              | *string*                                                                                          | :heavy_check_mark:                                                                                | ID of the Deal                                                                                    |
| `CrmDeal`                                                                                         | [CrmDeal](../../Models/Components/CrmDeal.md)                                                     | :heavy_minus_sign:                                                                                | A deal represents an opportunity with companies and/or contacts                                   |


### Response

**[UpdateCrmDealResponse](../../Models/Requests/UpdateCrmDealResponse.md)**


## UpdateCrmEvent

Update a event

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Crm.UpdateCrmEventAsync(
    security: new UpdateCrmEventSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    crmEvent: new CrmEvent() {});

// handle response
```

### Parameters

| Parameter                                                                                                       | Type                                                                                                            | Required                                                                                                        | Description                                                                                                     |
| --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                      | [UnifiedTo.Models.Requests.UpdateCrmEventSecurity](../../Models/Requests/UpdateCrmEventSecurity.md)             | :heavy_check_mark:                                                                                              | The security requirements to use for the request.                                                               |
| `ConnectionId`                                                                                                  | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the connection                                                                                            |
| `Id`                                                                                                            | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the Event                                                                                                 |
| `CrmEvent`                                                                                                      | [CrmEvent](../../Models/Components/CrmEvent.md)                                                                 | :heavy_minus_sign:                                                                                              | An event represents an event, activity, or engagement and is always associated with a deal, contact, or company |


### Response

**[UpdateCrmEventResponse](../../Models/Requests/UpdateCrmEventResponse.md)**


## UpdateCrmLead

Update a lead

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Crm.UpdateCrmLeadAsync(
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


## UpdateCrmPipeline

Update a pipeline

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK();

var res = await sdk.Crm.UpdateCrmPipelineAsync(
    security: new UpdateCrmPipelineSecurity() {
    Jwt = "<YOUR_API_KEY_HERE>",
},
    connectionId: "<value>",
    id: "<value>",
    crmPipeline: new CrmPipeline() {});

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                | [UnifiedTo.Models.Requests.UpdateCrmPipelineSecurity](../../Models/Requests/UpdateCrmPipelineSecurity.md) | :heavy_check_mark:                                                                                        | The security requirements to use for the request.                                                         |
| `ConnectionId`                                                                                            | *string*                                                                                                  | :heavy_check_mark:                                                                                        | ID of the connection                                                                                      |
| `Id`                                                                                                      | *string*                                                                                                  | :heavy_check_mark:                                                                                        | ID of the Pipeline                                                                                        |
| `CrmPipeline`                                                                                             | [CrmPipeline](../../Models/Components/CrmPipeline.md)                                                     | :heavy_minus_sign:                                                                                        | N/A                                                                                                       |


### Response

**[UpdateCrmPipelineResponse](../../Models/Requests/UpdateCrmPipelineResponse.md)**

