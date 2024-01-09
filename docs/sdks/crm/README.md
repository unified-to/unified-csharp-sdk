# Crm
(*Crm*)

### Available Operations

* [CreateCrmCompany](#createcrmcompany) - Create a company
* [CreateCrmContact](#createcrmcontact) - Create a contact
* [CreateCrmDeal](#createcrmdeal) - Create a deal
* [CreateCrmEvent](#createcrmevent) - Create a event
* [CreateCrmFile](#createcrmfile) - Create a file
* [CreateCrmLead](#createcrmlead) - Create a lead
* [CreateCrmPipeline](#createcrmpipeline) - Create a pipeline
* [GetCrmCompany](#getcrmcompany) - Retrieve a company
* [GetCrmContact](#getcrmcontact) - Retrieve a contact
* [GetCrmDeal](#getcrmdeal) - Retrieve a deal
* [GetCrmEvent](#getcrmevent) - Retrieve a event
* [GetCrmFile](#getcrmfile) - Retrieve a file
* [GetCrmLead](#getcrmlead) - Retrieve a lead
* [GetCrmPipeline](#getcrmpipeline) - Retrieve a pipeline
* [ListCrmCompanies](#listcrmcompanies) - List all companies
* [ListCrmContacts](#listcrmcontacts) - List all contacts
* [ListCrmDeals](#listcrmdeals) - List all deals
* [ListCrmEvents](#listcrmevents) - List all events
* [ListCrmFiles](#listcrmfiles) - List all files
* [ListCrmLeads](#listcrmleads) - List all leads
* [ListCrmPipelines](#listcrmpipelines) - List all pipelines
* [PatchCrmCompany](#patchcrmcompany) - Update a company
* [PatchCrmContact](#patchcrmcontact) - Update a contact
* [PatchCrmDeal](#patchcrmdeal) - Update a deal
* [PatchCrmEvent](#patchcrmevent) - Update a event
* [PatchCrmFile](#patchcrmfile) - Update a file
* [PatchCrmLead](#patchcrmlead) - Update a lead
* [PatchCrmPipeline](#patchcrmpipeline) - Update a pipeline
* [RemoveCrmCompany](#removecrmcompany) - Remove a company
* [RemoveCrmContact](#removecrmcontact) - Remove a contact
* [RemoveCrmDeal](#removecrmdeal) - Remove a deal
* [RemoveCrmEvent](#removecrmevent) - Remove a event
* [RemoveCrmFile](#removecrmfile) - Remove a file
* [RemoveCrmLead](#removecrmlead) - Remove a lead
* [RemoveCrmPipeline](#removecrmpipeline) - Remove a pipeline
* [UpdateCrmCompany](#updatecrmcompany) - Update a company
* [UpdateCrmContact](#updatecrmcontact) - Update a contact
* [UpdateCrmDeal](#updatecrmdeal) - Update a deal
* [UpdateCrmEvent](#updatecrmevent) - Update a event
* [UpdateCrmFile](#updatecrmfile) - Update a file
* [UpdateCrmLead](#updatecrmlead) - Update a lead
* [UpdateCrmPipeline](#updatecrmpipeline) - Update a pipeline

## CreateCrmCompany

Create a company

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Crm.CreateCrmCompanyAsync(ConnectionId: "string", CrmCompany: new CrmCompany() {
    Address = new PropertyCrmCompanyAddress() {},
    DealIds = new List<string>() {
        "string",
    },
    Emails = new List<CrmEmail>() {
        new CrmEmail() {},
    },
    LinkUrls = new List<string>() {
        "string",
    },
    Raw = new PropertyCrmCompanyRaw() {},
    Tags = new List<string>() {
        "string",
    },
    Telephones = new List<CrmTelephone>() {
        new CrmTelephone() {
            Telephone = "string",
        },
    },
    Websites = new List<string>() {
        "string",
    },
});

// handle response
```

### Parameters

| Parameter                                                                                      | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `ConnectionId`                                                                                 | *string*                                                                                       | :heavy_check_mark:                                                                             | ID of the connection                                                                           |
| `CrmCompany`                                                                                   | [CrmCompany](../../Models/Components/CrmCompany.md)                                            | :heavy_minus_sign:                                                                             | A company represents an organization that optionally is associated with a deal and/or contacts |


### Response

**[CreateCrmCompanyResponse](../../Models/Requests/CreateCrmCompanyResponse.md)**


## CreateCrmContact

Create a contact

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Crm.CreateCrmContactAsync(ConnectionId: "string", CrmContact: new CrmContact() {
    Address = new PropertyCrmContactAddress() {},
    CompanyIds = new List<string>() {
        "string",
    },
    DealIds = new List<string>() {
        "string",
    },
    Emails = new List<CrmEmail>() {
        new CrmEmail() {},
    },
    Raw = new PropertyCrmContactRaw() {},
    Telephones = new List<CrmTelephone>() {
        new CrmTelephone() {
            Telephone = "string",
        },
    },
});

// handle response
```

### Parameters

| Parameter                                                                                | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `ConnectionId`                                                                           | *string*                                                                                 | :heavy_check_mark:                                                                       | ID of the connection                                                                     |
| `CrmContact`                                                                             | [CrmContact](../../Models/Components/CrmContact.md)                                      | :heavy_minus_sign:                                                                       | A contact represents a person that optionally is associated with a deal and/or a company |


### Response

**[CreateCrmContactResponse](../../Models/Requests/CreateCrmContactResponse.md)**


## CreateCrmDeal

Create a deal

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Crm.CreateCrmDealAsync(ConnectionId: "string", CrmDeal: new CrmDeal() {
    Raw = new PropertyCrmDealRaw() {},
    Tags = new List<string>() {
        "string",
    },
});

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `ConnectionId`                                                  | *string*                                                        | :heavy_check_mark:                                              | ID of the connection                                            |
| `CrmDeal`                                                       | [CrmDeal](../../Models/Components/CrmDeal.md)                   | :heavy_minus_sign:                                              | A deal represents an opportunity with companies and/or contacts |


### Response

**[CreateCrmDealResponse](../../Models/Requests/CreateCrmDealResponse.md)**


## CreateCrmEvent

Create a event

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Crm.CreateCrmEventAsync(ConnectionId: "string", CrmEvent: new CrmEvent() {
    Call = new PropertyCrmEventCall() {},
    CompanyIds = new List<string>() {
        "string",
    },
    ContactIds = new List<string>() {
        "string",
    },
    DealIds = new List<string>() {
        "string",
    },
    Email = new PropertyCrmEventEmail() {
        Cc = new List<string>() {
            "string",
        },
        To = new List<string>() {
            "string",
        },
    },
    LeadIds = new List<string>() {
        "string",
    },
    Meeting = new PropertyCrmEventMeeting() {},
    Note = new PropertyCrmEventNote() {},
    Raw = new PropertyCrmEventRaw() {},
    Task = new PropertyCrmEventTask() {},
});

// handle response
```

### Parameters

| Parameter                                                                                                       | Type                                                                                                            | Required                                                                                                        | Description                                                                                                     |
| --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- |
| `ConnectionId`                                                                                                  | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the connection                                                                                            |
| `CrmEvent`                                                                                                      | [CrmEvent](../../Models/Components/CrmEvent.md)                                                                 | :heavy_minus_sign:                                                                                              | An event represents an event, activity, or engagement and is always associated with a deal, contact, or company |


### Response

**[CreateCrmEventResponse](../../Models/Requests/CreateCrmEventResponse.md)**


## CreateCrmFile

Create a file

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Crm.CreateCrmFileAsync(ConnectionId: "string", CrmFile: new CrmFile() {
    Raw = new PropertyCrmFileRaw() {},
});

// handle response
```

### Parameters

| Parameter                                     | Type                                          | Required                                      | Description                                   |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| `ConnectionId`                                | *string*                                      | :heavy_check_mark:                            | ID of the connection                          |
| `CrmFile`                                     | [CrmFile](../../Models/Components/CrmFile.md) | :heavy_minus_sign:                            | N/A                                           |


### Response

**[CreateCrmFileResponse](../../Models/Requests/CreateCrmFileResponse.md)**


## CreateCrmLead

Create a lead

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Crm.CreateCrmLeadAsync(ConnectionId: "string", CrmLead: new CrmLead() {
    Address = new PropertyCrmLeadAddress() {},
    Emails = new List<CrmEmail>() {
        new CrmEmail() {},
    },
    Raw = new PropertyCrmLeadRaw() {},
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


## CreateCrmPipeline

Create a pipeline

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Crm.CreateCrmPipelineAsync(ConnectionId: "string", CrmPipeline: new CrmPipeline() {
    Raw = new PropertyCrmPipelineRaw() {},
});

// handle response
```

### Parameters

| Parameter                                             | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `ConnectionId`                                        | *string*                                              | :heavy_check_mark:                                    | ID of the connection                                  |
| `CrmPipeline`                                         | [CrmPipeline](../../Models/Components/CrmPipeline.md) | :heavy_minus_sign:                                    | N/A                                                   |


### Response

**[CreateCrmPipelineResponse](../../Models/Requests/CreateCrmPipelineResponse.md)**


## GetCrmCompany

Retrieve a company

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Crm.GetCrmCompanyAsync(ConnectionId: "string", Id: "string", Fields: new List<string>() {
    "string",
});

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Company                |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetCrmCompanyResponse](../../Models/Requests/GetCrmCompanyResponse.md)**


## GetCrmContact

Retrieve a contact

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Crm.GetCrmContactAsync(ConnectionId: "string", Id: "string", Fields: new List<string>() {
    "string",
});

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Contact                |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetCrmContactResponse](../../Models/Requests/GetCrmContactResponse.md)**


## GetCrmDeal

Retrieve a deal

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Crm.GetCrmDealAsync(ConnectionId: "string", Id: "string", Fields: new List<string>() {
    "string",
});

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Deal                   |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetCrmDealResponse](../../Models/Requests/GetCrmDealResponse.md)**


## GetCrmEvent

Retrieve a event

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Crm.GetCrmEventAsync(ConnectionId: "string", Id: "string", Fields: new List<string>() {
    "string",
});

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Event                  |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetCrmEventResponse](../../Models/Requests/GetCrmEventResponse.md)**


## GetCrmFile

Retrieve a file

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Crm.GetCrmFileAsync(ConnectionId: "string", Id: "string", Fields: new List<string>() {
    "string",
});

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the File                   |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetCrmFileResponse](../../Models/Requests/GetCrmFileResponse.md)**


## GetCrmLead

Retrieve a lead

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Crm.GetCrmLeadAsync(ConnectionId: "string", Id: "string", Fields: new List<string>() {
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


## GetCrmPipeline

Retrieve a pipeline

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Crm.GetCrmPipelineAsync(ConnectionId: "string", Id: "string", Fields: new List<string>() {
    "string",
});

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Pipeline               |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetCrmPipelineResponse](../../Models/Requests/GetCrmPipelineResponse.md)**


## ListCrmCompanies

List all companies

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListCrmCompaniesRequest req = new ListCrmCompaniesRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
};

var res = await sdk.Crm.ListCrmCompaniesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListCrmCompaniesRequest](../../Models/Requests/ListCrmCompaniesRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |


### Response

**[ListCrmCompaniesResponse](../../Models/Requests/ListCrmCompaniesResponse.md)**


## ListCrmContacts

List all contacts

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListCrmContactsRequest req = new ListCrmContactsRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
};

var res = await sdk.Crm.ListCrmContactsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [ListCrmContactsRequest](../../Models/Requests/ListCrmContactsRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[ListCrmContactsResponse](../../Models/Requests/ListCrmContactsResponse.md)**


## ListCrmDeals

List all deals

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListCrmDealsRequest req = new ListCrmDealsRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
};

var res = await sdk.Crm.ListCrmDealsAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [ListCrmDealsRequest](../../Models/Requests/ListCrmDealsRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |


### Response

**[ListCrmDealsResponse](../../Models/Requests/ListCrmDealsResponse.md)**


## ListCrmEvents

List all events

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListCrmEventsRequest req = new ListCrmEventsRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
};

var res = await sdk.Crm.ListCrmEventsAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [ListCrmEventsRequest](../../Models/Requests/ListCrmEventsRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |


### Response

**[ListCrmEventsResponse](../../Models/Requests/ListCrmEventsResponse.md)**


## ListCrmFiles

List all files

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListCrmFilesRequest req = new ListCrmFilesRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
};

var res = await sdk.Crm.ListCrmFilesAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [ListCrmFilesRequest](../../Models/Requests/ListCrmFilesRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |


### Response

**[ListCrmFilesResponse](../../Models/Requests/ListCrmFilesResponse.md)**


## ListCrmLeads

List all leads

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListCrmLeadsRequest req = new ListCrmLeadsRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
};

var res = await sdk.Crm.ListCrmLeadsAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [ListCrmLeadsRequest](../../Models/Requests/ListCrmLeadsRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |


### Response

**[ListCrmLeadsResponse](../../Models/Requests/ListCrmLeadsResponse.md)**


## ListCrmPipelines

List all pipelines

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListCrmPipelinesRequest req = new ListCrmPipelinesRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
};

var res = await sdk.Crm.ListCrmPipelinesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListCrmPipelinesRequest](../../Models/Requests/ListCrmPipelinesRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |


### Response

**[ListCrmPipelinesResponse](../../Models/Requests/ListCrmPipelinesResponse.md)**


## PatchCrmCompany

Update a company

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Crm.PatchCrmCompanyAsync(ConnectionId: "string", Id: "string", CrmCompany: new CrmCompany() {
    Address = new PropertyCrmCompanyAddress() {},
    DealIds = new List<string>() {
        "string",
    },
    Emails = new List<CrmEmail>() {
        new CrmEmail() {},
    },
    LinkUrls = new List<string>() {
        "string",
    },
    Raw = new PropertyCrmCompanyRaw() {},
    Tags = new List<string>() {
        "string",
    },
    Telephones = new List<CrmTelephone>() {
        new CrmTelephone() {
            Telephone = "string",
        },
    },
    Websites = new List<string>() {
        "string",
    },
});

// handle response
```

### Parameters

| Parameter                                                                                      | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `ConnectionId`                                                                                 | *string*                                                                                       | :heavy_check_mark:                                                                             | ID of the connection                                                                           |
| `Id`                                                                                           | *string*                                                                                       | :heavy_check_mark:                                                                             | ID of the Company                                                                              |
| `CrmCompany`                                                                                   | [CrmCompany](../../Models/Components/CrmCompany.md)                                            | :heavy_minus_sign:                                                                             | A company represents an organization that optionally is associated with a deal and/or contacts |


### Response

**[PatchCrmCompanyResponse](../../Models/Requests/PatchCrmCompanyResponse.md)**


## PatchCrmContact

Update a contact

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Crm.PatchCrmContactAsync(ConnectionId: "string", Id: "string", CrmContact: new CrmContact() {
    Address = new PropertyCrmContactAddress() {},
    CompanyIds = new List<string>() {
        "string",
    },
    DealIds = new List<string>() {
        "string",
    },
    Emails = new List<CrmEmail>() {
        new CrmEmail() {},
    },
    Raw = new PropertyCrmContactRaw() {},
    Telephones = new List<CrmTelephone>() {
        new CrmTelephone() {
            Telephone = "string",
        },
    },
});

// handle response
```

### Parameters

| Parameter                                                                                | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `ConnectionId`                                                                           | *string*                                                                                 | :heavy_check_mark:                                                                       | ID of the connection                                                                     |
| `Id`                                                                                     | *string*                                                                                 | :heavy_check_mark:                                                                       | ID of the Contact                                                                        |
| `CrmContact`                                                                             | [CrmContact](../../Models/Components/CrmContact.md)                                      | :heavy_minus_sign:                                                                       | A contact represents a person that optionally is associated with a deal and/or a company |


### Response

**[PatchCrmContactResponse](../../Models/Requests/PatchCrmContactResponse.md)**


## PatchCrmDeal

Update a deal

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Crm.PatchCrmDealAsync(ConnectionId: "string", Id: "string", CrmDeal: new CrmDeal() {
    Raw = new PropertyCrmDealRaw() {},
    Tags = new List<string>() {
        "string",
    },
});

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `ConnectionId`                                                  | *string*                                                        | :heavy_check_mark:                                              | ID of the connection                                            |
| `Id`                                                            | *string*                                                        | :heavy_check_mark:                                              | ID of the Deal                                                  |
| `CrmDeal`                                                       | [CrmDeal](../../Models/Components/CrmDeal.md)                   | :heavy_minus_sign:                                              | A deal represents an opportunity with companies and/or contacts |


### Response

**[PatchCrmDealResponse](../../Models/Requests/PatchCrmDealResponse.md)**


## PatchCrmEvent

Update a event

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Crm.PatchCrmEventAsync(ConnectionId: "string", Id: "string", CrmEvent: new CrmEvent() {
    Call = new PropertyCrmEventCall() {},
    CompanyIds = new List<string>() {
        "string",
    },
    ContactIds = new List<string>() {
        "string",
    },
    DealIds = new List<string>() {
        "string",
    },
    Email = new PropertyCrmEventEmail() {
        Cc = new List<string>() {
            "string",
        },
        To = new List<string>() {
            "string",
        },
    },
    LeadIds = new List<string>() {
        "string",
    },
    Meeting = new PropertyCrmEventMeeting() {},
    Note = new PropertyCrmEventNote() {},
    Raw = new PropertyCrmEventRaw() {},
    Task = new PropertyCrmEventTask() {},
});

// handle response
```

### Parameters

| Parameter                                                                                                       | Type                                                                                                            | Required                                                                                                        | Description                                                                                                     |
| --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- |
| `ConnectionId`                                                                                                  | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the connection                                                                                            |
| `Id`                                                                                                            | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the Event                                                                                                 |
| `CrmEvent`                                                                                                      | [CrmEvent](../../Models/Components/CrmEvent.md)                                                                 | :heavy_minus_sign:                                                                                              | An event represents an event, activity, or engagement and is always associated with a deal, contact, or company |


### Response

**[PatchCrmEventResponse](../../Models/Requests/PatchCrmEventResponse.md)**


## PatchCrmFile

Update a file

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Crm.PatchCrmFileAsync(ConnectionId: "string", Id: "string", CrmFile: new CrmFile() {
    Raw = new PropertyCrmFileRaw() {},
});

// handle response
```

### Parameters

| Parameter                                     | Type                                          | Required                                      | Description                                   |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| `ConnectionId`                                | *string*                                      | :heavy_check_mark:                            | ID of the connection                          |
| `Id`                                          | *string*                                      | :heavy_check_mark:                            | ID of the File                                |
| `CrmFile`                                     | [CrmFile](../../Models/Components/CrmFile.md) | :heavy_minus_sign:                            | N/A                                           |


### Response

**[PatchCrmFileResponse](../../Models/Requests/PatchCrmFileResponse.md)**


## PatchCrmLead

Update a lead

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Crm.PatchCrmLeadAsync(ConnectionId: "string", Id: "string", CrmLead: new CrmLead() {
    Address = new PropertyCrmLeadAddress() {},
    Emails = new List<CrmEmail>() {
        new CrmEmail() {},
    },
    Raw = new PropertyCrmLeadRaw() {},
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


## PatchCrmPipeline

Update a pipeline

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Crm.PatchCrmPipelineAsync(ConnectionId: "string", Id: "string", CrmPipeline: new CrmPipeline() {
    Raw = new PropertyCrmPipelineRaw() {},
});

// handle response
```

### Parameters

| Parameter                                             | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `ConnectionId`                                        | *string*                                              | :heavy_check_mark:                                    | ID of the connection                                  |
| `Id`                                                  | *string*                                              | :heavy_check_mark:                                    | ID of the Pipeline                                    |
| `CrmPipeline`                                         | [CrmPipeline](../../Models/Components/CrmPipeline.md) | :heavy_minus_sign:                                    | N/A                                                   |


### Response

**[PatchCrmPipelineResponse](../../Models/Requests/PatchCrmPipelineResponse.md)**


## RemoveCrmCompany

Remove a company

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Crm.RemoveCrmCompanyAsync(ConnectionId: "string", Id: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Company    |


### Response

**[RemoveCrmCompanyResponse](../../Models/Requests/RemoveCrmCompanyResponse.md)**


## RemoveCrmContact

Remove a contact

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Crm.RemoveCrmContactAsync(ConnectionId: "string", Id: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Contact    |


### Response

**[RemoveCrmContactResponse](../../Models/Requests/RemoveCrmContactResponse.md)**


## RemoveCrmDeal

Remove a deal

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Crm.RemoveCrmDealAsync(ConnectionId: "string", Id: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Deal       |


### Response

**[RemoveCrmDealResponse](../../Models/Requests/RemoveCrmDealResponse.md)**


## RemoveCrmEvent

Remove a event

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Crm.RemoveCrmEventAsync(ConnectionId: "string", Id: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Event      |


### Response

**[RemoveCrmEventResponse](../../Models/Requests/RemoveCrmEventResponse.md)**


## RemoveCrmFile

Remove a file

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Crm.RemoveCrmFileAsync(ConnectionId: "string", Id: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the File       |


### Response

**[RemoveCrmFileResponse](../../Models/Requests/RemoveCrmFileResponse.md)**


## RemoveCrmLead

Remove a lead

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Crm.RemoveCrmLeadAsync(ConnectionId: "string", Id: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Lead       |


### Response

**[RemoveCrmLeadResponse](../../Models/Requests/RemoveCrmLeadResponse.md)**


## RemoveCrmPipeline

Remove a pipeline

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Crm.RemoveCrmPipelineAsync(ConnectionId: "string", Id: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Pipeline   |


### Response

**[RemoveCrmPipelineResponse](../../Models/Requests/RemoveCrmPipelineResponse.md)**


## UpdateCrmCompany

Update a company

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Crm.UpdateCrmCompanyAsync(ConnectionId: "string", Id: "string", CrmCompany: new CrmCompany() {
    Address = new PropertyCrmCompanyAddress() {},
    DealIds = new List<string>() {
        "string",
    },
    Emails = new List<CrmEmail>() {
        new CrmEmail() {},
    },
    LinkUrls = new List<string>() {
        "string",
    },
    Raw = new PropertyCrmCompanyRaw() {},
    Tags = new List<string>() {
        "string",
    },
    Telephones = new List<CrmTelephone>() {
        new CrmTelephone() {
            Telephone = "string",
        },
    },
    Websites = new List<string>() {
        "string",
    },
});

// handle response
```

### Parameters

| Parameter                                                                                      | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `ConnectionId`                                                                                 | *string*                                                                                       | :heavy_check_mark:                                                                             | ID of the connection                                                                           |
| `Id`                                                                                           | *string*                                                                                       | :heavy_check_mark:                                                                             | ID of the Company                                                                              |
| `CrmCompany`                                                                                   | [CrmCompany](../../Models/Components/CrmCompany.md)                                            | :heavy_minus_sign:                                                                             | A company represents an organization that optionally is associated with a deal and/or contacts |


### Response

**[UpdateCrmCompanyResponse](../../Models/Requests/UpdateCrmCompanyResponse.md)**


## UpdateCrmContact

Update a contact

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Crm.UpdateCrmContactAsync(ConnectionId: "string", Id: "string", CrmContact: new CrmContact() {
    Address = new PropertyCrmContactAddress() {},
    CompanyIds = new List<string>() {
        "string",
    },
    DealIds = new List<string>() {
        "string",
    },
    Emails = new List<CrmEmail>() {
        new CrmEmail() {},
    },
    Raw = new PropertyCrmContactRaw() {},
    Telephones = new List<CrmTelephone>() {
        new CrmTelephone() {
            Telephone = "string",
        },
    },
});

// handle response
```

### Parameters

| Parameter                                                                                | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `ConnectionId`                                                                           | *string*                                                                                 | :heavy_check_mark:                                                                       | ID of the connection                                                                     |
| `Id`                                                                                     | *string*                                                                                 | :heavy_check_mark:                                                                       | ID of the Contact                                                                        |
| `CrmContact`                                                                             | [CrmContact](../../Models/Components/CrmContact.md)                                      | :heavy_minus_sign:                                                                       | A contact represents a person that optionally is associated with a deal and/or a company |


### Response

**[UpdateCrmContactResponse](../../Models/Requests/UpdateCrmContactResponse.md)**


## UpdateCrmDeal

Update a deal

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Crm.UpdateCrmDealAsync(ConnectionId: "string", Id: "string", CrmDeal: new CrmDeal() {
    Raw = new PropertyCrmDealRaw() {},
    Tags = new List<string>() {
        "string",
    },
});

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `ConnectionId`                                                  | *string*                                                        | :heavy_check_mark:                                              | ID of the connection                                            |
| `Id`                                                            | *string*                                                        | :heavy_check_mark:                                              | ID of the Deal                                                  |
| `CrmDeal`                                                       | [CrmDeal](../../Models/Components/CrmDeal.md)                   | :heavy_minus_sign:                                              | A deal represents an opportunity with companies and/or contacts |


### Response

**[UpdateCrmDealResponse](../../Models/Requests/UpdateCrmDealResponse.md)**


## UpdateCrmEvent

Update a event

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Crm.UpdateCrmEventAsync(ConnectionId: "string", Id: "string", CrmEvent: new CrmEvent() {
    Call = new PropertyCrmEventCall() {},
    CompanyIds = new List<string>() {
        "string",
    },
    ContactIds = new List<string>() {
        "string",
    },
    DealIds = new List<string>() {
        "string",
    },
    Email = new PropertyCrmEventEmail() {
        Cc = new List<string>() {
            "string",
        },
        To = new List<string>() {
            "string",
        },
    },
    LeadIds = new List<string>() {
        "string",
    },
    Meeting = new PropertyCrmEventMeeting() {},
    Note = new PropertyCrmEventNote() {},
    Raw = new PropertyCrmEventRaw() {},
    Task = new PropertyCrmEventTask() {},
});

// handle response
```

### Parameters

| Parameter                                                                                                       | Type                                                                                                            | Required                                                                                                        | Description                                                                                                     |
| --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- |
| `ConnectionId`                                                                                                  | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the connection                                                                                            |
| `Id`                                                                                                            | *string*                                                                                                        | :heavy_check_mark:                                                                                              | ID of the Event                                                                                                 |
| `CrmEvent`                                                                                                      | [CrmEvent](../../Models/Components/CrmEvent.md)                                                                 | :heavy_minus_sign:                                                                                              | An event represents an event, activity, or engagement and is always associated with a deal, contact, or company |


### Response

**[UpdateCrmEventResponse](../../Models/Requests/UpdateCrmEventResponse.md)**


## UpdateCrmFile

Update a file

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Crm.UpdateCrmFileAsync(ConnectionId: "string", Id: "string", CrmFile: new CrmFile() {
    Raw = new PropertyCrmFileRaw() {},
});

// handle response
```

### Parameters

| Parameter                                     | Type                                          | Required                                      | Description                                   |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| `ConnectionId`                                | *string*                                      | :heavy_check_mark:                            | ID of the connection                          |
| `Id`                                          | *string*                                      | :heavy_check_mark:                            | ID of the File                                |
| `CrmFile`                                     | [CrmFile](../../Models/Components/CrmFile.md) | :heavy_minus_sign:                            | N/A                                           |


### Response

**[UpdateCrmFileResponse](../../Models/Requests/UpdateCrmFileResponse.md)**


## UpdateCrmLead

Update a lead

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Crm.UpdateCrmLeadAsync(ConnectionId: "string", Id: "string", CrmLead: new CrmLead() {
    Address = new PropertyCrmLeadAddress() {},
    Emails = new List<CrmEmail>() {
        new CrmEmail() {},
    },
    Raw = new PropertyCrmLeadRaw() {},
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


## UpdateCrmPipeline

Update a pipeline

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Components;
using UnifiedTo.Models.Requests;

var sdk = new UnifiedToSDK(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Crm.UpdateCrmPipelineAsync(ConnectionId: "string", Id: "string", CrmPipeline: new CrmPipeline() {
    Raw = new PropertyCrmPipelineRaw() {},
});

// handle response
```

### Parameters

| Parameter                                             | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `ConnectionId`                                        | *string*                                              | :heavy_check_mark:                                    | ID of the connection                                  |
| `Id`                                                  | *string*                                              | :heavy_check_mark:                                    | ID of the Pipeline                                    |
| `CrmPipeline`                                         | [CrmPipeline](../../Models/Components/CrmPipeline.md) | :heavy_minus_sign:                                    | N/A                                                   |


### Response

**[UpdateCrmPipelineResponse](../../Models/Requests/UpdateCrmPipelineResponse.md)**

