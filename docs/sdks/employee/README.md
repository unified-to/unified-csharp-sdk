# Employee
(*Employee*)

### Available Operations

* [CreateHrisEmployee](#createhrisemployee) - Create an employee
* [GetHrisEmployee](#gethrisemployee) - Retrieve an employee
* [ListHrisEmployees](#listhrisemployees) - List all employees
* [PatchHrisEmployee](#patchhrisemployee) - Update an employee
* [RemoveHrisEmployee](#removehrisemployee) - Remove an employee
* [UpdateHrisEmployee](#updatehrisemployee) - Update an employee

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

var res = await sdk.Employee.CreateHrisEmployeeAsync(ConnectionId: "string", HrisEmployee: new HrisEmployee() {
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

var res = await sdk.Employee.GetHrisEmployeeAsync(ConnectionId: "string", Id: "string", Fields: new List<string>() {
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

var res = await sdk.Employee.ListHrisEmployeesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListHrisEmployeesRequest](../../Models/Requests/ListHrisEmployeesRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |


### Response

**[ListHrisEmployeesResponse](../../Models/Requests/ListHrisEmployeesResponse.md)**


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

var res = await sdk.Employee.PatchHrisEmployeeAsync(ConnectionId: "string", Id: "string", HrisEmployee: new HrisEmployee() {
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

var res = await sdk.Employee.RemoveHrisEmployeeAsync(ConnectionId: "string", Id: "string");

// handle response
```

### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Employee   |


### Response

**[RemoveHrisEmployeeResponse](../../Models/Requests/RemoveHrisEmployeeResponse.md)**


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

var res = await sdk.Employee.UpdateHrisEmployeeAsync(ConnectionId: "string", Id: "string", HrisEmployee: new HrisEmployee() {
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

