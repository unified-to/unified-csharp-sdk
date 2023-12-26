# Hris
(*Hris*)

### Available Operations

* [CreateHrisEmployee](#createhrisemployee) - Create an employee
* [CreateHrisGroup](#createhrisgroup) - Create a group
* [GetHrisEmployee](#gethrisemployee) - Retrieve an employee
* [GetHrisGroup](#gethrisgroup) - Retrieve a group
* [ListHrisEmployees](#listhrisemployees) - List all employees
* [ListHrisGroups](#listhrisgroups) - List all groups
* [PatchHrisEmployee](#patchhrisemployee) - Update an employee
* [PatchHrisGroup](#patchhrisgroup) - Update a group
* [RemoveHrisEmployee](#removehrisemployee) - Remove an employee
* [RemoveHrisGroup](#removehrisgroup) - Remove a group
* [UpdateHrisEmployee](#updatehrisemployee) - Update an employee
* [UpdateHrisGroup](#updatehrisgroup) - Update a group

## CreateHrisEmployee

Create an employee

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Hris.CreateHrisEmployeeAsync(ConnectionId: "string", HrisEmployee: new HrisEmployee() {
    Address = new PropertyHrisEmployeeAddress() {},
    Emails = new List<HrisEmail>() {
        new HrisEmail() {
            Email = "Adriel_Hansen@hotmail.com",
        },
    },
    Raw = new PropertyHrisEmployeeRaw() {},
    Telephones = new List<HrisTelephone>() {
        new HrisTelephone() {
            Telephone = "string",
        },
    },
});

// handle response
```

### Parameters

| Parameter                                               | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `ConnectionId`                                          | *string*                                                | :heavy_check_mark:                                      | ID of the connection                                    |
| `HrisEmployee`                                          | [HrisEmployee](../../Models/Components/HrisEmployee.md) | :heavy_minus_sign:                                      | N/A                                                     |


### Response

**[CreateHrisEmployeeResponse](../../Models/Requests/CreateHrisEmployeeResponse.md)**


## CreateHrisGroup

Create a group

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Hris.CreateHrisGroupAsync(ConnectionId: "string", HrisGroup: new HrisGroup() {
    EmployeeIds = new List<string>() {
        "string",
    },
    ManagerIds = new List<string>() {
        "string",
    },
    Raw = new PropertyHrisGroupRaw() {},
});

// handle response
```

### Parameters

| Parameter                                         | Type                                              | Required                                          | Description                                       |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| `ConnectionId`                                    | *string*                                          | :heavy_check_mark:                                | ID of the connection                              |
| `HrisGroup`                                       | [HrisGroup](../../Models/Components/HrisGroup.md) | :heavy_minus_sign:                                | N/A                                               |


### Response

**[CreateHrisGroupResponse](../../Models/Requests/CreateHrisGroupResponse.md)**


## GetHrisEmployee

Retrieve an employee

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Hris.GetHrisEmployeeAsync(ConnectionId: "string", Id: "string", Fields: new List<string>() {
    "string",
});

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Employee               |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetHrisEmployeeResponse](../../Models/Requests/GetHrisEmployeeResponse.md)**


## GetHrisGroup

Retrieve a group

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Hris.GetHrisGroupAsync(ConnectionId: "string", Id: "string", Fields: new List<string>() {
    "string",
});

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `ConnectionId`                   | *string*                         | :heavy_check_mark:               | ID of the connection             |
| `Id`                             | *string*                         | :heavy_check_mark:               | ID of the Group                  |
| `Fields`                         | List<*string*>                   | :heavy_minus_sign:               | Comma-delimited fields to return |


### Response

**[GetHrisGroupResponse](../../Models/Requests/GetHrisGroupResponse.md)**


## ListHrisEmployees

List all employees

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListHrisEmployeesRequest req = new ListHrisEmployeesRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
};

var res = await sdk.Hris.ListHrisEmployeesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListHrisEmployeesRequest](../../Models/Requests/ListHrisEmployeesRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |


### Response

**[ListHrisEmployeesResponse](../../Models/Requests/ListHrisEmployeesResponse.md)**


## ListHrisGroups

List all groups

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListHrisGroupsRequest req = new ListHrisGroupsRequest() {
    ConnectionId = "string",
    Fields = new List<string>() {
        "string",
    },
};

var res = await sdk.Hris.ListHrisGroupsAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [ListHrisGroupsRequest](../../Models/Requests/ListHrisGroupsRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[ListHrisGroupsResponse](../../Models/Requests/ListHrisGroupsResponse.md)**


## PatchHrisEmployee

Update an employee

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Hris.PatchHrisEmployeeAsync(ConnectionId: "string", Id: "string", HrisEmployee: new HrisEmployee() {
    Address = new PropertyHrisEmployeeAddress() {},
    Emails = new List<HrisEmail>() {
        new HrisEmail() {
            Email = "Zetta.Cassin@yahoo.com",
        },
    },
    Raw = new PropertyHrisEmployeeRaw() {},
    Telephones = new List<HrisTelephone>() {
        new HrisTelephone() {
            Telephone = "string",
        },
    },
});

// handle response
```

### Parameters

| Parameter                                               | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `ConnectionId`                                          | *string*                                                | :heavy_check_mark:                                      | ID of the connection                                    |
| `Id`                                                    | *string*                                                | :heavy_check_mark:                                      | ID of the Employee                                      |
| `HrisEmployee`                                          | [HrisEmployee](../../Models/Components/HrisEmployee.md) | :heavy_minus_sign:                                      | N/A                                                     |


### Response

**[PatchHrisEmployeeResponse](../../Models/Requests/PatchHrisEmployeeResponse.md)**


## PatchHrisGroup

Update a group

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Hris.PatchHrisGroupAsync(ConnectionId: "string", Id: "string", HrisGroup: new HrisGroup() {
    EmployeeIds = new List<string>() {
        "string",
    },
    ManagerIds = new List<string>() {
        "string",
    },
    Raw = new PropertyHrisGroupRaw() {},
});

// handle response
```

### Parameters

| Parameter                                         | Type                                              | Required                                          | Description                                       |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| `ConnectionId`                                    | *string*                                          | :heavy_check_mark:                                | ID of the connection                              |
| `Id`                                              | *string*                                          | :heavy_check_mark:                                | ID of the Group                                   |
| `HrisGroup`                                       | [HrisGroup](../../Models/Components/HrisGroup.md) | :heavy_minus_sign:                                | N/A                                               |


### Response

**[PatchHrisGroupResponse](../../Models/Requests/PatchHrisGroupResponse.md)**


## RemoveHrisEmployee

Remove an employee

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Hris.RemoveHrisEmployeeAsync(ConnectionId: "string", Id: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Employee   |


### Response

**[RemoveHrisEmployeeResponse](../../Models/Requests/RemoveHrisEmployeeResponse.md)**


## RemoveHrisGroup

Remove a group

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Hris.RemoveHrisGroupAsync(ConnectionId: "string", Id: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Group      |


### Response

**[RemoveHrisGroupResponse](../../Models/Requests/RemoveHrisGroupResponse.md)**


## UpdateHrisEmployee

Update an employee

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Hris.UpdateHrisEmployeeAsync(ConnectionId: "string", Id: "string", HrisEmployee: new HrisEmployee() {
    Address = new PropertyHrisEmployeeAddress() {},
    Emails = new List<HrisEmail>() {
        new HrisEmail() {
            Email = "Abbie_Aufderhar@gmail.com",
        },
    },
    Raw = new PropertyHrisEmployeeRaw() {},
    Telephones = new List<HrisTelephone>() {
        new HrisTelephone() {
            Telephone = "string",
        },
    },
});

// handle response
```

### Parameters

| Parameter                                               | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `ConnectionId`                                          | *string*                                                | :heavy_check_mark:                                      | ID of the connection                                    |
| `Id`                                                    | *string*                                                | :heavy_check_mark:                                      | ID of the Employee                                      |
| `HrisEmployee`                                          | [HrisEmployee](../../Models/Components/HrisEmployee.md) | :heavy_minus_sign:                                      | N/A                                                     |


### Response

**[UpdateHrisEmployeeResponse](../../Models/Requests/UpdateHrisEmployeeResponse.md)**


## UpdateHrisGroup

Update a group

### Example Usage

```csharp
using Unified.To;
using Unified.To.Models.Components;
using Unified.To.Models.Requests;
using System.Collections.Generic;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Hris.UpdateHrisGroupAsync(ConnectionId: "string", Id: "string", HrisGroup: new HrisGroup() {
    EmployeeIds = new List<string>() {
        "string",
    },
    ManagerIds = new List<string>() {
        "string",
    },
    Raw = new PropertyHrisGroupRaw() {},
});

// handle response
```

### Parameters

| Parameter                                         | Type                                              | Required                                          | Description                                       |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| `ConnectionId`                                    | *string*                                          | :heavy_check_mark:                                | ID of the connection                              |
| `Id`                                              | *string*                                          | :heavy_check_mark:                                | ID of the Group                                   |
| `HrisGroup`                                       | [HrisGroup](../../Models/Components/HrisGroup.md) | :heavy_minus_sign:                                | N/A                                               |


### Response

**[UpdateHrisGroupResponse](../../Models/Requests/UpdateHrisGroupResponse.md)**

