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
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Employee.CreateHrisEmployeeAsync(
    connectionId: "<value>",
    hrisEmployee: new HrisEmployee() {});

// handle response
```



### Parameters

| Parameter                                               | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `ConnectionId`                                          | *string*                                                | :heavy_check_mark:                                      | ID of the connection                                    |
| `HrisEmployee`                                          | [HrisEmployee](../../Models/Components/HrisEmployee.md) | :heavy_minus_sign:                                      | N/A                                                     |


### Response

**[CreateHrisEmployeeResponse](../../Models/Requests/CreateHrisEmployeeResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## GetHrisEmployee

Retrieve an employee

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Employee.GetHrisEmployeeAsync(
    connectionId: "<value>",
    id: "<value>",
    fields: new List<string>() {
    "<value>",
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
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## ListHrisEmployees

List all employees

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using System.Collections.Generic;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

ListHrisEmployeesRequest req = new ListHrisEmployeesRequest() {
    ConnectionId = "<value>",
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
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## PatchHrisEmployee

Update an employee

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Employee.PatchHrisEmployeeAsync(
    connectionId: "<value>",
    id: "<value>",
    hrisEmployee: new HrisEmployee() {});

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
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## RemoveHrisEmployee

Remove an employee

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Employee.RemoveHrisEmployeeAsync(
    connectionId: "<value>",
    id: "<value>");

// handle response
```



### Parameters

| Parameter            | Type                 | Required             | Description          |
| -------------------- | -------------------- | -------------------- | -------------------- |
| `ConnectionId`       | *string*             | :heavy_check_mark:   | ID of the connection |
| `Id`                 | *string*             | :heavy_check_mark:   | ID of the Employee   |


### Response

**[RemoveHrisEmployeeResponse](../../Models/Requests/RemoveHrisEmployeeResponse.md)**
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |

## UpdateHrisEmployee

Update an employee

### Example Usage

```csharp
using UnifiedTo;
using UnifiedTo.Models.Requests;
using UnifiedTo.Models.Components;
using System.Collections.Generic;

var sdk = new UnifiedToSDK(security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Employee.UpdateHrisEmployeeAsync(
    connectionId: "<value>",
    id: "<value>",
    hrisEmployee: new HrisEmployee() {});

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
### Errors

| Error Object                         | Status Code                          | Content Type                         |
| ------------------------------------ | ------------------------------------ | ------------------------------------ |
| UnifiedTo.Models.Errors.SDKException | 4xx-5xx                              | */*                                  |
