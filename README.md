### Installation

```bash
dotnet add package Unified-csharp-sdk
```
<!-- End SDK Installation [installation] -->

<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example

```csharp
using UnifiedCsharpSDK;
using UnifiedCsharpSDK.Models.Components;
using UnifiedCsharpSDK.Models.Requests;

var sdk = new UnifiedTo(
    security: new Security() {
        Jwt = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Accounting.CreateAccountingAccountAsync(ConnectionId: "string", AccountingAccount: new AccountingAccount() {
    Name = "string",
    Raw = new PropertyAccountingAccountRaw() {},
});

// handle response
```
<!-- End SDK Example Usage [usage] -->

<!-- Start Available Resources and Operations [operations] -->
## Available Resources and Operations

### [Accounting](docs/sdks/accounting/README.md)

* [CreateAccountingAccount](docs/sdks/accounting/README.md#createaccountingaccount) - Create an account
* [CreateAccountingCustomer](docs/sdks/accounting/README.md#createaccountingcustomer) - Create a customer
* [CreateAccountingInvoice](docs/sdks/accounting/README.md#createaccountinginvoice) - Create a invoice
* [CreateAccountingItem](docs/sdks/accounting/README.md#createaccountingitem) - Create an item
* [CreateAccountingPayment](docs/sdks/accounting/README.md#createaccountingpayment) - Create a payment
* [CreateAccountingTaxrate](docs/sdks/accounting/README.md#createaccountingtaxrate) - Create a taxrate
* [CreateAccountingTransaction](docs/sdks/accounting/README.md#createaccountingtransaction) - Create a transaction
* [GetAccountingAccount](docs/sdks/accounting/README.md#getaccountingaccount) - Retrieve an account
* [GetAccountingCustomer](docs/sdks/accounting/README.md#getaccountingcustomer) - Retrieve a customer
* [GetAccountingInvoice](docs/sdks/accounting/README.md#getaccountinginvoice) - Retrieve a invoice
* [GetAccountingItem](docs/sdks/accounting/README.md#getaccountingitem) - Retrieve an item
* [GetAccountingOrganization](docs/sdks/accounting/README.md#getaccountingorganization) - Retrieve an organization
* [GetAccountingPayment](docs/sdks/accounting/README.md#getaccountingpayment) - Retrieve a payment
* [GetAccountingTaxrate](docs/sdks/accounting/README.md#getaccountingtaxrate) - Retrieve a taxrate
* [GetAccountingTransaction](docs/sdks/accounting/README.md#getaccountingtransaction) - Retrieve a transaction
* [ListAccountingAccounts](docs/sdks/accounting/README.md#listaccountingaccounts) - List all accounts
* [ListAccountingCustomers](docs/sdks/accounting/README.md#listaccountingcustomers) - List all customers
* [ListAccountingInvoices](docs/sdks/accounting/README.md#listaccountinginvoices) - List all invoices
* [ListAccountingItems](docs/sdks/accounting/README.md#listaccountingitems) - List all items
* [ListAccountingOrganizations](docs/sdks/accounting/README.md#listaccountingorganizations) - List all organizations
* [ListAccountingPayments](docs/sdks/accounting/README.md#listaccountingpayments) - List all payments
* [ListAccountingTaxrates](docs/sdks/accounting/README.md#listaccountingtaxrates) - List all taxrates
* [ListAccountingTransactions](docs/sdks/accounting/README.md#listaccountingtransactions) - List all transactions
* [PatchAccountingAccount](docs/sdks/accounting/README.md#patchaccountingaccount) - Update an account
* [PatchAccountingCustomer](docs/sdks/accounting/README.md#patchaccountingcustomer) - Update a customer
* [PatchAccountingInvoice](docs/sdks/accounting/README.md#patchaccountinginvoice) - Update a invoice
* [PatchAccountingItem](docs/sdks/accounting/README.md#patchaccountingitem) - Update an item
* [PatchAccountingPayment](docs/sdks/accounting/README.md#patchaccountingpayment) - Update a payment
* [PatchAccountingTaxrate](docs/sdks/accounting/README.md#patchaccountingtaxrate) - Update a taxrate
* [PatchAccountingTransaction](docs/sdks/accounting/README.md#patchaccountingtransaction) - Update a transaction
* [RemoveAccountingAccount](docs/sdks/accounting/README.md#removeaccountingaccount) - Remove an account
* [RemoveAccountingCustomer](docs/sdks/accounting/README.md#removeaccountingcustomer) - Remove a customer
* [RemoveAccountingInvoice](docs/sdks/accounting/README.md#removeaccountinginvoice) - Remove a invoice
* [RemoveAccountingItem](docs/sdks/accounting/README.md#removeaccountingitem) - Remove an item
* [RemoveAccountingPayment](docs/sdks/accounting/README.md#removeaccountingpayment) - Remove a payment
* [RemoveAccountingTaxrate](docs/sdks/accounting/README.md#removeaccountingtaxrate) - Remove a taxrate
* [RemoveAccountingTransaction](docs/sdks/accounting/README.md#removeaccountingtransaction) - Remove a transaction
* [UpdateAccountingAccount](docs/sdks/accounting/README.md#updateaccountingaccount) - Update an account
* [UpdateAccountingCustomer](docs/sdks/accounting/README.md#updateaccountingcustomer) - Update a customer
* [UpdateAccountingInvoice](docs/sdks/accounting/README.md#updateaccountinginvoice) - Update a invoice
* [UpdateAccountingItem](docs/sdks/accounting/README.md#updateaccountingitem) - Update an item
* [UpdateAccountingPayment](docs/sdks/accounting/README.md#updateaccountingpayment) - Update a payment
* [UpdateAccountingTaxrate](docs/sdks/accounting/README.md#updateaccountingtaxrate) - Update a taxrate
* [UpdateAccountingTransaction](docs/sdks/accounting/README.md#updateaccountingtransaction) - Update a transaction

### [Account](docs/sdks/account/README.md)

* [CreateAccountingAccount](docs/sdks/account/README.md#createaccountingaccount) - Create an account
* [GetAccountingAccount](docs/sdks/account/README.md#getaccountingaccount) - Retrieve an account
* [ListAccountingAccounts](docs/sdks/account/README.md#listaccountingaccounts) - List all accounts
* [PatchAccountingAccount](docs/sdks/account/README.md#patchaccountingaccount) - Update an account
* [RemoveAccountingAccount](docs/sdks/account/README.md#removeaccountingaccount) - Remove an account
* [UpdateAccountingAccount](docs/sdks/account/README.md#updateaccountingaccount) - Update an account

### [Customer](docs/sdks/customer/README.md)

* [CreateAccountingCustomer](docs/sdks/customer/README.md#createaccountingcustomer) - Create a customer
* [CreateTicketingCustomer](docs/sdks/customer/README.md#createticketingcustomer) - Create a customer
* [GetAccountingCustomer](docs/sdks/customer/README.md#getaccountingcustomer) - Retrieve a customer
* [GetTicketingCustomer](docs/sdks/customer/README.md#getticketingcustomer) - Retrieve a customer
* [ListAccountingCustomers](docs/sdks/customer/README.md#listaccountingcustomers) - List all customers
* [ListTicketingCustomers](docs/sdks/customer/README.md#listticketingcustomers) - List all customers
* [PatchAccountingCustomer](docs/sdks/customer/README.md#patchaccountingcustomer) - Update a customer
* [PatchTicketingCustomer](docs/sdks/customer/README.md#patchticketingcustomer) - Update a customer
* [RemoveAccountingCustomer](docs/sdks/customer/README.md#removeaccountingcustomer) - Remove a customer
* [RemoveTicketingCustomer](docs/sdks/customer/README.md#removeticketingcustomer) - Remove a customer
* [UpdateAccountingCustomer](docs/sdks/customer/README.md#updateaccountingcustomer) - Update a customer
* [UpdateTicketingCustomer](docs/sdks/customer/README.md#updateticketingcustomer) - Update a customer

### [Invoice](docs/sdks/invoice/README.md)

* [CreateAccountingInvoice](docs/sdks/invoice/README.md#createaccountinginvoice) - Create a invoice
* [GetAccountingInvoice](docs/sdks/invoice/README.md#getaccountinginvoice) - Retrieve a invoice
* [ListAccountingInvoices](docs/sdks/invoice/README.md#listaccountinginvoices) - List all invoices
* [PatchAccountingInvoice](docs/sdks/invoice/README.md#patchaccountinginvoice) - Update a invoice
* [RemoveAccountingInvoice](docs/sdks/invoice/README.md#removeaccountinginvoice) - Remove a invoice
* [UpdateAccountingInvoice](docs/sdks/invoice/README.md#updateaccountinginvoice) - Update a invoice

### [Item](docs/sdks/item/README.md)

* [CreateAccountingItem](docs/sdks/item/README.md#createaccountingitem) - Create an item
* [GetAccountingItem](docs/sdks/item/README.md#getaccountingitem) - Retrieve an item
* [ListAccountingItems](docs/sdks/item/README.md#listaccountingitems) - List all items
* [PatchAccountingItem](docs/sdks/item/README.md#patchaccountingitem) - Update an item
* [RemoveAccountingItem](docs/sdks/item/README.md#removeaccountingitem) - Remove an item
* [UpdateAccountingItem](docs/sdks/item/README.md#updateaccountingitem) - Update an item

### [Organization](docs/sdks/organization/README.md)

* [GetAccountingOrganization](docs/sdks/organization/README.md#getaccountingorganization) - Retrieve an organization
* [ListAccountingOrganizations](docs/sdks/organization/README.md#listaccountingorganizations) - List all organizations

### [Payment](docs/sdks/payment/README.md)

* [CreateAccountingPayment](docs/sdks/payment/README.md#createaccountingpayment) - Create a payment
* [GetAccountingPayment](docs/sdks/payment/README.md#getaccountingpayment) - Retrieve a payment
* [ListAccountingPayments](docs/sdks/payment/README.md#listaccountingpayments) - List all payments
* [PatchAccountingPayment](docs/sdks/payment/README.md#patchaccountingpayment) - Update a payment
* [RemoveAccountingPayment](docs/sdks/payment/README.md#removeaccountingpayment) - Remove a payment
* [UpdateAccountingPayment](docs/sdks/payment/README.md#updateaccountingpayment) - Update a payment

### [Taxrate](docs/sdks/taxrate/README.md)

* [CreateAccountingTaxrate](docs/sdks/taxrate/README.md#createaccountingtaxrate) - Create a taxrate
* [GetAccountingTaxrate](docs/sdks/taxrate/README.md#getaccountingtaxrate) - Retrieve a taxrate
* [ListAccountingTaxrates](docs/sdks/taxrate/README.md#listaccountingtaxrates) - List all taxrates
* [PatchAccountingTaxrate](docs/sdks/taxrate/README.md#patchaccountingtaxrate) - Update a taxrate
* [RemoveAccountingTaxrate](docs/sdks/taxrate/README.md#removeaccountingtaxrate) - Remove a taxrate
* [UpdateAccountingTaxrate](docs/sdks/taxrate/README.md#updateaccountingtaxrate) - Update a taxrate

### [Transaction](docs/sdks/transaction/README.md)

* [CreateAccountingTransaction](docs/sdks/transaction/README.md#createaccountingtransaction) - Create a transaction
* [GetAccountingTransaction](docs/sdks/transaction/README.md#getaccountingtransaction) - Retrieve a transaction
* [ListAccountingTransactions](docs/sdks/transaction/README.md#listaccountingtransactions) - List all transactions
* [PatchAccountingTransaction](docs/sdks/transaction/README.md#patchaccountingtransaction) - Update a transaction
* [RemoveAccountingTransaction](docs/sdks/transaction/README.md#removeaccountingtransaction) - Remove a transaction
* [UpdateAccountingTransaction](docs/sdks/transaction/README.md#updateaccountingtransaction) - Update a transaction

### [Ats](docs/sdks/ats/README.md)

* [CreateAtsApplication](docs/sdks/ats/README.md#createatsapplication) - Create an application
* [CreateAtsCandidate](docs/sdks/ats/README.md#createatscandidate) - Create a candidate
* [CreateAtsDocument](docs/sdks/ats/README.md#createatsdocument) - Create a document
* [CreateAtsInterview](docs/sdks/ats/README.md#createatsinterview) - Create a interview
* [CreateAtsJob](docs/sdks/ats/README.md#createatsjob) - Create a job
* [CreateAtsScorecard](docs/sdks/ats/README.md#createatsscorecard) - Create a scorecard
* [GetAtsApplication](docs/sdks/ats/README.md#getatsapplication) - Retrieve an application
* [GetAtsCandidate](docs/sdks/ats/README.md#getatscandidate) - Retrieve a candidate
* [GetAtsDocument](docs/sdks/ats/README.md#getatsdocument) - Retrieve a document
* [GetAtsInterview](docs/sdks/ats/README.md#getatsinterview) - Retrieve a interview
* [GetAtsJob](docs/sdks/ats/README.md#getatsjob) - Retrieve a job
* [GetAtsScorecard](docs/sdks/ats/README.md#getatsscorecard) - Retrieve a scorecard
* [ListAtsApplications](docs/sdks/ats/README.md#listatsapplications) - List all applications
* [ListAtsApplicationstatuses](docs/sdks/ats/README.md#listatsapplicationstatuses) - List all application statuses
* [ListAtsCandidates](docs/sdks/ats/README.md#listatscandidates) - List all candidates
* [ListAtsDocuments](docs/sdks/ats/README.md#listatsdocuments) - List all documents
* [ListAtsInterviews](docs/sdks/ats/README.md#listatsinterviews) - List all interviews
* [ListAtsJobs](docs/sdks/ats/README.md#listatsjobs) - List all jobs
* [ListAtsScorecards](docs/sdks/ats/README.md#listatsscorecards) - List all scorecards
* [PatchAtsApplication](docs/sdks/ats/README.md#patchatsapplication) - Update an application
* [PatchAtsCandidate](docs/sdks/ats/README.md#patchatscandidate) - Update a candidate
* [PatchAtsDocument](docs/sdks/ats/README.md#patchatsdocument) - Update a document
* [PatchAtsInterview](docs/sdks/ats/README.md#patchatsinterview) - Update a interview
* [PatchAtsJob](docs/sdks/ats/README.md#patchatsjob) - Update a job
* [PatchAtsScorecard](docs/sdks/ats/README.md#patchatsscorecard) - Update a scorecard
* [RemoveAtsApplication](docs/sdks/ats/README.md#removeatsapplication) - Remove an application
* [RemoveAtsCandidate](docs/sdks/ats/README.md#removeatscandidate) - Remove a candidate
* [RemoveAtsDocument](docs/sdks/ats/README.md#removeatsdocument) - Remove a document
* [RemoveAtsInterview](docs/sdks/ats/README.md#removeatsinterview) - Remove a interview
* [RemoveAtsJob](docs/sdks/ats/README.md#removeatsjob) - Remove a job
* [RemoveAtsScorecard](docs/sdks/ats/README.md#removeatsscorecard) - Remove a scorecard
* [UpdateAtsApplication](docs/sdks/ats/README.md#updateatsapplication) - Update an application
* [UpdateAtsCandidate](docs/sdks/ats/README.md#updateatscandidate) - Update a candidate
* [UpdateAtsDocument](docs/sdks/ats/README.md#updateatsdocument) - Update a document
* [UpdateAtsInterview](docs/sdks/ats/README.md#updateatsinterview) - Update a interview
* [UpdateAtsJob](docs/sdks/ats/README.md#updateatsjob) - Update a job
* [UpdateAtsScorecard](docs/sdks/ats/README.md#updateatsscorecard) - Update a scorecard

### [Application](docs/sdks/application/README.md)

* [CreateAtsApplication](docs/sdks/application/README.md#createatsapplication) - Create an application
* [GetAtsApplication](docs/sdks/application/README.md#getatsapplication) - Retrieve an application
* [ListAtsApplications](docs/sdks/application/README.md#listatsapplications) - List all applications
* [PatchAtsApplication](docs/sdks/application/README.md#patchatsapplication) - Update an application
* [RemoveAtsApplication](docs/sdks/application/README.md#removeatsapplication) - Remove an application
* [UpdateAtsApplication](docs/sdks/application/README.md#updateatsapplication) - Update an application

### [Applicationstatus](docs/sdks/applicationstatus/README.md)

* [ListAtsApplicationstatuses](docs/sdks/applicationstatus/README.md#listatsapplicationstatuses) - List all application statuses

### [Candidate](docs/sdks/candidate/README.md)

* [CreateAtsCandidate](docs/sdks/candidate/README.md#createatscandidate) - Create a candidate
* [GetAtsCandidate](docs/sdks/candidate/README.md#getatscandidate) - Retrieve a candidate
* [ListAtsCandidates](docs/sdks/candidate/README.md#listatscandidates) - List all candidates
* [PatchAtsCandidate](docs/sdks/candidate/README.md#patchatscandidate) - Update a candidate
* [RemoveAtsCandidate](docs/sdks/candidate/README.md#removeatscandidate) - Remove a candidate
* [UpdateAtsCandidate](docs/sdks/candidate/README.md#updateatscandidate) - Update a candidate

### [Document](docs/sdks/document/README.md)

* [CreateAtsDocument](docs/sdks/document/README.md#createatsdocument) - Create a document
* [GetAtsDocument](docs/sdks/document/README.md#getatsdocument) - Retrieve a document
* [ListAtsDocuments](docs/sdks/document/README.md#listatsdocuments) - List all documents
* [PatchAtsDocument](docs/sdks/document/README.md#patchatsdocument) - Update a document
* [RemoveAtsDocument](docs/sdks/document/README.md#removeatsdocument) - Remove a document
* [UpdateAtsDocument](docs/sdks/document/README.md#updateatsdocument) - Update a document

### [Interview](docs/sdks/interview/README.md)

* [CreateAtsInterview](docs/sdks/interview/README.md#createatsinterview) - Create a interview
* [GetAtsInterview](docs/sdks/interview/README.md#getatsinterview) - Retrieve a interview
* [ListAtsInterviews](docs/sdks/interview/README.md#listatsinterviews) - List all interviews
* [PatchAtsInterview](docs/sdks/interview/README.md#patchatsinterview) - Update a interview
* [RemoveAtsInterview](docs/sdks/interview/README.md#removeatsinterview) - Remove a interview
* [UpdateAtsInterview](docs/sdks/interview/README.md#updateatsinterview) - Update a interview

### [Job](docs/sdks/job/README.md)

* [CreateAtsJob](docs/sdks/job/README.md#createatsjob) - Create a job
* [GetAtsJob](docs/sdks/job/README.md#getatsjob) - Retrieve a job
* [ListAtsJobs](docs/sdks/job/README.md#listatsjobs) - List all jobs
* [PatchAtsJob](docs/sdks/job/README.md#patchatsjob) - Update a job
* [RemoveAtsJob](docs/sdks/job/README.md#removeatsjob) - Remove a job
* [UpdateAtsJob](docs/sdks/job/README.md#updateatsjob) - Update a job

### [Scorecard](docs/sdks/scorecard/README.md)

* [CreateAtsScorecard](docs/sdks/scorecard/README.md#createatsscorecard) - Create a scorecard
* [GetAtsScorecard](docs/sdks/scorecard/README.md#getatsscorecard) - Retrieve a scorecard
* [ListAtsScorecards](docs/sdks/scorecard/README.md#listatsscorecards) - List all scorecards
* [PatchAtsScorecard](docs/sdks/scorecard/README.md#patchatsscorecard) - Update a scorecard
* [RemoveAtsScorecard](docs/sdks/scorecard/README.md#removeatsscorecard) - Remove a scorecard
* [UpdateAtsScorecard](docs/sdks/scorecard/README.md#updateatsscorecard) - Update a scorecard

### [Crm](docs/sdks/crm/README.md)

* [CreateCrmCompany](docs/sdks/crm/README.md#createcrmcompany) - Create a company
* [CreateCrmContact](docs/sdks/crm/README.md#createcrmcontact) - Create a contact
* [CreateCrmDeal](docs/sdks/crm/README.md#createcrmdeal) - Create a deal
* [CreateCrmEvent](docs/sdks/crm/README.md#createcrmevent) - Create a event
* [CreateCrmFile](docs/sdks/crm/README.md#createcrmfile) - Create a file
* [CreateCrmLead](docs/sdks/crm/README.md#createcrmlead) - Create a lead
* [CreateCrmPipeline](docs/sdks/crm/README.md#createcrmpipeline) - Create a pipeline
* [GetCrmCompany](docs/sdks/crm/README.md#getcrmcompany) - Retrieve a company
* [GetCrmContact](docs/sdks/crm/README.md#getcrmcontact) - Retrieve a contact
* [GetCrmDeal](docs/sdks/crm/README.md#getcrmdeal) - Retrieve a deal
* [GetCrmEvent](docs/sdks/crm/README.md#getcrmevent) - Retrieve a event
* [GetCrmFile](docs/sdks/crm/README.md#getcrmfile) - Retrieve a file
* [GetCrmLead](docs/sdks/crm/README.md#getcrmlead) - Retrieve a lead
* [GetCrmPipeline](docs/sdks/crm/README.md#getcrmpipeline) - Retrieve a pipeline
* [ListCrmCompanies](docs/sdks/crm/README.md#listcrmcompanies) - List all companies
* [ListCrmContacts](docs/sdks/crm/README.md#listcrmcontacts) - List all contacts
* [ListCrmDeals](docs/sdks/crm/README.md#listcrmdeals) - List all deals
* [ListCrmEvents](docs/sdks/crm/README.md#listcrmevents) - List all events
* [ListCrmFiles](docs/sdks/crm/README.md#listcrmfiles) - List all files
* [ListCrmLeads](docs/sdks/crm/README.md#listcrmleads) - List all leads
* [ListCrmPipelines](docs/sdks/crm/README.md#listcrmpipelines) - List all pipelines
* [PatchCrmCompany](docs/sdks/crm/README.md#patchcrmcompany) - Update a company
* [PatchCrmContact](docs/sdks/crm/README.md#patchcrmcontact) - Update a contact
* [PatchCrmDeal](docs/sdks/crm/README.md#patchcrmdeal) - Update a deal
* [PatchCrmEvent](docs/sdks/crm/README.md#patchcrmevent) - Update a event
* [PatchCrmFile](docs/sdks/crm/README.md#patchcrmfile) - Update a file
* [PatchCrmLead](docs/sdks/crm/README.md#patchcrmlead) - Update a lead
* [PatchCrmPipeline](docs/sdks/crm/README.md#patchcrmpipeline) - Update a pipeline
* [RemoveCrmCompany](docs/sdks/crm/README.md#removecrmcompany) - Remove a company
* [RemoveCrmContact](docs/sdks/crm/README.md#removecrmcontact) - Remove a contact
* [RemoveCrmDeal](docs/sdks/crm/README.md#removecrmdeal) - Remove a deal
* [RemoveCrmEvent](docs/sdks/crm/README.md#removecrmevent) - Remove a event
* [RemoveCrmFile](docs/sdks/crm/README.md#removecrmfile) - Remove a file
* [RemoveCrmLead](docs/sdks/crm/README.md#removecrmlead) - Remove a lead
* [RemoveCrmPipeline](docs/sdks/crm/README.md#removecrmpipeline) - Remove a pipeline
* [UpdateCrmCompany](docs/sdks/crm/README.md#updatecrmcompany) - Update a company
* [UpdateCrmContact](docs/sdks/crm/README.md#updatecrmcontact) - Update a contact
* [UpdateCrmDeal](docs/sdks/crm/README.md#updatecrmdeal) - Update a deal
* [UpdateCrmEvent](docs/sdks/crm/README.md#updatecrmevent) - Update a event
* [UpdateCrmFile](docs/sdks/crm/README.md#updatecrmfile) - Update a file
* [UpdateCrmLead](docs/sdks/crm/README.md#updatecrmlead) - Update a lead
* [UpdateCrmPipeline](docs/sdks/crm/README.md#updatecrmpipeline) - Update a pipeline

### [Company](docs/sdks/company/README.md)

* [CreateCrmCompany](docs/sdks/company/README.md#createcrmcompany) - Create a company
* [GetCrmCompany](docs/sdks/company/README.md#getcrmcompany) - Retrieve a company
* [ListCrmCompanies](docs/sdks/company/README.md#listcrmcompanies) - List all companies
* [ListEnrichCompanies](docs/sdks/company/README.md#listenrichcompanies) - Retrieve enrichment information for a company
* [PatchCrmCompany](docs/sdks/company/README.md#patchcrmcompany) - Update a company
* [RemoveCrmCompany](docs/sdks/company/README.md#removecrmcompany) - Remove a company
* [UpdateCrmCompany](docs/sdks/company/README.md#updatecrmcompany) - Update a company

### [Contact](docs/sdks/contact/README.md)

* [CreateCrmContact](docs/sdks/contact/README.md#createcrmcontact) - Create a contact
* [CreateUcContact](docs/sdks/contact/README.md#createuccontact) - Create a contact
* [GetCrmContact](docs/sdks/contact/README.md#getcrmcontact) - Retrieve a contact
* [GetUcContact](docs/sdks/contact/README.md#getuccontact) - Retrieve a contact
* [ListCrmContacts](docs/sdks/contact/README.md#listcrmcontacts) - List all contacts
* [ListUcContacts](docs/sdks/contact/README.md#listuccontacts) - List all contacts
* [PatchCrmContact](docs/sdks/contact/README.md#patchcrmcontact) - Update a contact
* [PatchUcContact](docs/sdks/contact/README.md#patchuccontact) - Update a contact
* [RemoveCrmContact](docs/sdks/contact/README.md#removecrmcontact) - Remove a contact
* [RemoveUcContact](docs/sdks/contact/README.md#removeuccontact) - Remove a contact
* [UpdateCrmContact](docs/sdks/contact/README.md#updatecrmcontact) - Update a contact
* [UpdateUcContact](docs/sdks/contact/README.md#updateuccontact) - Update a contact

### [Deal](docs/sdks/deal/README.md)

* [CreateCrmDeal](docs/sdks/deal/README.md#createcrmdeal) - Create a deal
* [GetCrmDeal](docs/sdks/deal/README.md#getcrmdeal) - Retrieve a deal
* [ListCrmDeals](docs/sdks/deal/README.md#listcrmdeals) - List all deals
* [PatchCrmDeal](docs/sdks/deal/README.md#patchcrmdeal) - Update a deal
* [RemoveCrmDeal](docs/sdks/deal/README.md#removecrmdeal) - Remove a deal
* [UpdateCrmDeal](docs/sdks/deal/README.md#updatecrmdeal) - Update a deal

### [Event](docs/sdks/event/README.md)

* [CreateCrmEvent](docs/sdks/event/README.md#createcrmevent) - Create a event
* [GetCrmEvent](docs/sdks/event/README.md#getcrmevent) - Retrieve a event
* [ListCrmEvents](docs/sdks/event/README.md#listcrmevents) - List all events
* [PatchCrmEvent](docs/sdks/event/README.md#patchcrmevent) - Update a event
* [RemoveCrmEvent](docs/sdks/event/README.md#removecrmevent) - Remove a event
* [UpdateCrmEvent](docs/sdks/event/README.md#updatecrmevent) - Update a event

### [File](docs/sdks/file/README.md)

* [CreateCrmFile](docs/sdks/file/README.md#createcrmfile) - Create a file
* [CreateStorageFile](docs/sdks/file/README.md#createstoragefile) - Create a file
* [GetCrmFile](docs/sdks/file/README.md#getcrmfile) - Retrieve a file
* [GetStorageFile](docs/sdks/file/README.md#getstoragefile) - Retrieve a file
* [ListCrmFiles](docs/sdks/file/README.md#listcrmfiles) - List all files
* [ListStorageFiles](docs/sdks/file/README.md#liststoragefiles) - List all files
* [PatchCrmFile](docs/sdks/file/README.md#patchcrmfile) - Update a file
* [PatchStorageFile](docs/sdks/file/README.md#patchstoragefile) - Update a file
* [RemoveCrmFile](docs/sdks/file/README.md#removecrmfile) - Remove a file
* [RemoveStorageFile](docs/sdks/file/README.md#removestoragefile) - Remove a file
* [UpdateCrmFile](docs/sdks/file/README.md#updatecrmfile) - Update a file
* [UpdateStorageFile](docs/sdks/file/README.md#updatestoragefile) - Update a file

### [Lead](docs/sdks/lead/README.md)

* [CreateCrmLead](docs/sdks/lead/README.md#createcrmlead) - Create a lead
* [GetCrmLead](docs/sdks/lead/README.md#getcrmlead) - Retrieve a lead
* [ListCrmLeads](docs/sdks/lead/README.md#listcrmleads) - List all leads
* [PatchCrmLead](docs/sdks/lead/README.md#patchcrmlead) - Update a lead
* [RemoveCrmLead](docs/sdks/lead/README.md#removecrmlead) - Remove a lead
* [UpdateCrmLead](docs/sdks/lead/README.md#updatecrmlead) - Update a lead

### [Pipeline](docs/sdks/pipeline/README.md)

* [CreateCrmPipeline](docs/sdks/pipeline/README.md#createcrmpipeline) - Create a pipeline
* [GetCrmPipeline](docs/sdks/pipeline/README.md#getcrmpipeline) - Retrieve a pipeline
* [ListCrmPipelines](docs/sdks/pipeline/README.md#listcrmpipelines) - List all pipelines
* [PatchCrmPipeline](docs/sdks/pipeline/README.md#patchcrmpipeline) - Update a pipeline
* [RemoveCrmPipeline](docs/sdks/pipeline/README.md#removecrmpipeline) - Remove a pipeline
* [UpdateCrmPipeline](docs/sdks/pipeline/README.md#updatecrmpipeline) - Update a pipeline

### [Enrich](docs/sdks/enrich/README.md)

* [ListEnrichCompanies](docs/sdks/enrich/README.md#listenrichcompanies) - Retrieve enrichment information for a company
* [ListEnrichPeople](docs/sdks/enrich/README.md#listenrichpeople) - Retrieve enrichment information for a person

### [Person](docs/sdks/person/README.md)

* [ListEnrichPeople](docs/sdks/person/README.md#listenrichpeople) - Retrieve enrichment information for a person

### [Hris](docs/sdks/hris/README.md)

* [CreateHrisEmployee](docs/sdks/hris/README.md#createhrisemployee) - Create an employee
* [CreateHrisGroup](docs/sdks/hris/README.md#createhrisgroup) - Create a group
* [GetHrisEmployee](docs/sdks/hris/README.md#gethrisemployee) - Retrieve an employee
* [GetHrisGroup](docs/sdks/hris/README.md#gethrisgroup) - Retrieve a group
* [ListHrisEmployees](docs/sdks/hris/README.md#listhrisemployees) - List all employees
* [ListHrisGroups](docs/sdks/hris/README.md#listhrisgroups) - List all groups
* [PatchHrisEmployee](docs/sdks/hris/README.md#patchhrisemployee) - Update an employee
* [PatchHrisGroup](docs/sdks/hris/README.md#patchhrisgroup) - Update a group
* [RemoveHrisEmployee](docs/sdks/hris/README.md#removehrisemployee) - Remove an employee
* [RemoveHrisGroup](docs/sdks/hris/README.md#removehrisgroup) - Remove a group
* [UpdateHrisEmployee](docs/sdks/hris/README.md#updatehrisemployee) - Update an employee
* [UpdateHrisGroup](docs/sdks/hris/README.md#updatehrisgroup) - Update a group

### [Employee](docs/sdks/employee/README.md)

* [CreateHrisEmployee](docs/sdks/employee/README.md#createhrisemployee) - Create an employee
* [GetHrisEmployee](docs/sdks/employee/README.md#gethrisemployee) - Retrieve an employee
* [ListHrisEmployees](docs/sdks/employee/README.md#listhrisemployees) - List all employees
* [PatchHrisEmployee](docs/sdks/employee/README.md#patchhrisemployee) - Update an employee
* [RemoveHrisEmployee](docs/sdks/employee/README.md#removehrisemployee) - Remove an employee
* [UpdateHrisEmployee](docs/sdks/employee/README.md#updatehrisemployee) - Update an employee

### [Group](docs/sdks/group/README.md)

* [CreateHrisGroup](docs/sdks/group/README.md#createhrisgroup) - Create a group
* [GetHrisGroup](docs/sdks/group/README.md#gethrisgroup) - Retrieve a group
* [ListHrisGroups](docs/sdks/group/README.md#listhrisgroups) - List all groups
* [PatchHrisGroup](docs/sdks/group/README.md#patchhrisgroup) - Update a group
* [RemoveHrisGroup](docs/sdks/group/README.md#removehrisgroup) - Remove a group
* [UpdateHrisGroup](docs/sdks/group/README.md#updatehrisgroup) - Update a group

### [Martech](docs/sdks/martech/README.md)

* [CreateMartechList](docs/sdks/martech/README.md#createmartechlist) - Create a list
* [CreateMartechMember](docs/sdks/martech/README.md#createmartechmember) - Create a member
* [GetMartechList](docs/sdks/martech/README.md#getmartechlist) - Retrieve a list
* [GetMartechMember](docs/sdks/martech/README.md#getmartechmember) - Retrieve a member
* [ListMartechLists](docs/sdks/martech/README.md#listmartechlists) - List all lists
* [ListMartechMembers](docs/sdks/martech/README.md#listmartechmembers) - List all members
* [PatchMartechList](docs/sdks/martech/README.md#patchmartechlist) - Update a list
* [PatchMartechMember](docs/sdks/martech/README.md#patchmartechmember) - Update a member
* [RemoveMartechList](docs/sdks/martech/README.md#removemartechlist) - Remove a list
* [RemoveMartechMember](docs/sdks/martech/README.md#removemartechmember) - Remove member
* [UpdateMartechList](docs/sdks/martech/README.md#updatemartechlist) - Update a list
* [UpdateMartechMember](docs/sdks/martech/README.md#updatemartechmember) - Update a member

### [List](docs/sdks/list/README.md)

* [CreateMartechList](docs/sdks/list/README.md#createmartechlist) - Create a list
* [GetMartechList](docs/sdks/list/README.md#getmartechlist) - Retrieve a list
* [ListMartechLists](docs/sdks/list/README.md#listmartechlists) - List all lists
* [PatchMartechList](docs/sdks/list/README.md#patchmartechlist) - Update a list
* [RemoveMartechList](docs/sdks/list/README.md#removemartechlist) - Remove a list
* [UpdateMartechList](docs/sdks/list/README.md#updatemartechlist) - Update a list

### [Member](docs/sdks/member/README.md)

* [CreateMartechMember](docs/sdks/member/README.md#createmartechmember) - Create a member
* [GetMartechMember](docs/sdks/member/README.md#getmartechmember) - Retrieve a member
* [ListMartechMembers](docs/sdks/member/README.md#listmartechmembers) - List all members
* [PatchMartechMember](docs/sdks/member/README.md#patchmartechmember) - Update a member
* [RemoveMartechMember](docs/sdks/member/README.md#removemartechmember) - Remove member
* [UpdateMartechMember](docs/sdks/member/README.md#updatemartechmember) - Update a member

### [Passthrough](docs/sdks/passthrough/README.md)

* [CreatePassthrough](docs/sdks/passthrough/README.md#createpassthrough) - Passthrough POST
* [ListPassthroughs](docs/sdks/passthrough/README.md#listpassthroughs) - Passthrough GET
* [PatchPassthrough](docs/sdks/passthrough/README.md#patchpassthrough) - Passthrough PUT
* [RemovePassthrough](docs/sdks/passthrough/README.md#removepassthrough) - Passthrough DELETE
* [UpdatePassthrough](docs/sdks/passthrough/README.md#updatepassthrough) - Passthrough PUT

### [Storage](docs/sdks/storage/README.md)

* [CreateStorageFile](docs/sdks/storage/README.md#createstoragefile) - Create a file
* [GetStorageFile](docs/sdks/storage/README.md#getstoragefile) - Retrieve a file
* [ListStorageFiles](docs/sdks/storage/README.md#liststoragefiles) - List all files
* [PatchStorageFile](docs/sdks/storage/README.md#patchstoragefile) - Update a file
* [RemoveStorageFile](docs/sdks/storage/README.md#removestoragefile) - Remove a file
* [UpdateStorageFile](docs/sdks/storage/README.md#updatestoragefile) - Update a file

### [Ticketing](docs/sdks/ticketing/README.md)

* [CreateTicketingCustomer](docs/sdks/ticketing/README.md#createticketingcustomer) - Create a customer
* [CreateTicketingNote](docs/sdks/ticketing/README.md#createticketingnote) - Create a note
* [CreateTicketingTicket](docs/sdks/ticketing/README.md#createticketingticket) - Create a ticket
* [GetTicketingCustomer](docs/sdks/ticketing/README.md#getticketingcustomer) - Retrieve a customer
* [GetTicketingNote](docs/sdks/ticketing/README.md#getticketingnote) - Retrieve a note
* [GetTicketingTicket](docs/sdks/ticketing/README.md#getticketingticket) - Retrieve a ticket
* [ListTicketingCustomers](docs/sdks/ticketing/README.md#listticketingcustomers) - List all customers
* [ListTicketingNotes](docs/sdks/ticketing/README.md#listticketingnotes) - List all notes
* [ListTicketingTickets](docs/sdks/ticketing/README.md#listticketingtickets) - List all tickets
* [PatchTicketingCustomer](docs/sdks/ticketing/README.md#patchticketingcustomer) - Update a customer
* [PatchTicketingNote](docs/sdks/ticketing/README.md#patchticketingnote) - Update a note
* [PatchTicketingTicket](docs/sdks/ticketing/README.md#patchticketingticket) - Update a ticket
* [RemoveTicketingCustomer](docs/sdks/ticketing/README.md#removeticketingcustomer) - Remove a customer
* [RemoveTicketingNote](docs/sdks/ticketing/README.md#removeticketingnote) - Remove a note
* [RemoveTicketingTicket](docs/sdks/ticketing/README.md#removeticketingticket) - Remove a ticket
* [UpdateTicketingCustomer](docs/sdks/ticketing/README.md#updateticketingcustomer) - Update a customer
* [UpdateTicketingNote](docs/sdks/ticketing/README.md#updateticketingnote) - Update a note
* [UpdateTicketingTicket](docs/sdks/ticketing/README.md#updateticketingticket) - Update a ticket

### [Note](docs/sdks/note/README.md)

* [CreateTicketingNote](docs/sdks/note/README.md#createticketingnote) - Create a note
* [GetTicketingNote](docs/sdks/note/README.md#getticketingnote) - Retrieve a note
* [ListTicketingNotes](docs/sdks/note/README.md#listticketingnotes) - List all notes
* [PatchTicketingNote](docs/sdks/note/README.md#patchticketingnote) - Update a note
* [RemoveTicketingNote](docs/sdks/note/README.md#removeticketingnote) - Remove a note
* [UpdateTicketingNote](docs/sdks/note/README.md#updateticketingnote) - Update a note

### [Ticket](docs/sdks/ticket/README.md)

* [CreateTicketingTicket](docs/sdks/ticket/README.md#createticketingticket) - Create a ticket
* [GetTicketingTicket](docs/sdks/ticket/README.md#getticketingticket) - Retrieve a ticket
* [ListTicketingTickets](docs/sdks/ticket/README.md#listticketingtickets) - List all tickets
* [PatchTicketingTicket](docs/sdks/ticket/README.md#patchticketingticket) - Update a ticket
* [RemoveTicketingTicket](docs/sdks/ticket/README.md#removeticketingticket) - Remove a ticket
* [UpdateTicketingTicket](docs/sdks/ticket/README.md#updateticketingticket) - Update a ticket

### [Uc](docs/sdks/uc/README.md)

* [CreateUcContact](docs/sdks/uc/README.md#createuccontact) - Create a contact
* [GetUcContact](docs/sdks/uc/README.md#getuccontact) - Retrieve a contact
* [ListUcCalls](docs/sdks/uc/README.md#listuccalls) - List all calls
* [ListUcContacts](docs/sdks/uc/README.md#listuccontacts) - List all contacts
* [PatchUcContact](docs/sdks/uc/README.md#patchuccontact) - Update a contact
* [RemoveUcContact](docs/sdks/uc/README.md#removeuccontact) - Remove a contact
* [UpdateUcContact](docs/sdks/uc/README.md#updateuccontact) - Update a contact

### [Call](docs/sdks/call/README.md)

* [ListUcCalls](docs/sdks/call/README.md#listuccalls) - List all calls

### [Unified](docs/sdks/unified/README.md)

* [CreateUnifiedConnection](docs/sdks/unified/README.md#createunifiedconnection) - Create connection
* [CreateUnifiedWebhook](docs/sdks/unified/README.md#createunifiedwebhook) - Create webhook subscription
* [GetUnifiedApicall](docs/sdks/unified/README.md#getunifiedapicall) - Retrieve specific API Call by its ID
* [GetUnifiedConnection](docs/sdks/unified/README.md#getunifiedconnection) - Retrieve connection
* [GetUnifiedIntegrationAuth](docs/sdks/unified/README.md#getunifiedintegrationauth) - Create connection indirectly
* [GetUnifiedWebhook](docs/sdks/unified/README.md#getunifiedwebhook) - Retrieve webhook by its ID
* [ListUnifiedApicalls](docs/sdks/unified/README.md#listunifiedapicalls) - Returns API Calls
* [ListUnifiedConnections](docs/sdks/unified/README.md#listunifiedconnections) - List all connections
* [ListUnifiedIntegrationWorkspaces](docs/sdks/unified/README.md#listunifiedintegrationworkspaces) - Returns all activated integrations in a workspace
* [ListUnifiedIntegrations](docs/sdks/unified/README.md#listunifiedintegrations) - Returns all integrations
* [ListUnifiedWebhooks](docs/sdks/unified/README.md#listunifiedwebhooks) - Returns all registered webhooks
* [PatchUnifiedConnection](docs/sdks/unified/README.md#patchunifiedconnection) - Update connection
* [RemoveUnifiedConnection](docs/sdks/unified/README.md#removeunifiedconnection) - Remove connection
* [RemoveUnifiedWebhook](docs/sdks/unified/README.md#removeunifiedwebhook) - Remove webhook subscription
* [UpdateUnifiedConnection](docs/sdks/unified/README.md#updateunifiedconnection) - Update connection

### [Apicall](docs/sdks/apicall/README.md)

* [GetUnifiedApicall](docs/sdks/apicall/README.md#getunifiedapicall) - Retrieve specific API Call by its ID
* [ListUnifiedApicalls](docs/sdks/apicall/README.md#listunifiedapicalls) - Returns API Calls

### [Connection](docs/sdks/connection/README.md)

* [CreateUnifiedConnection](docs/sdks/connection/README.md#createunifiedconnection) - Create connection
* [GetUnifiedConnection](docs/sdks/connection/README.md#getunifiedconnection) - Retrieve connection
* [ListUnifiedConnections](docs/sdks/connection/README.md#listunifiedconnections) - List all connections
* [PatchUnifiedConnection](docs/sdks/connection/README.md#patchunifiedconnection) - Update connection
* [RemoveUnifiedConnection](docs/sdks/connection/README.md#removeunifiedconnection) - Remove connection
* [UpdateUnifiedConnection](docs/sdks/connection/README.md#updateunifiedconnection) - Update connection

### [Integration](docs/sdks/integration/README.md)

* [GetUnifiedIntegrationAuth](docs/sdks/integration/README.md#getunifiedintegrationauth) - Create connection indirectly
* [ListUnifiedIntegrationWorkspaces](docs/sdks/integration/README.md#listunifiedintegrationworkspaces) - Returns all activated integrations in a workspace
* [ListUnifiedIntegrations](docs/sdks/integration/README.md#listunifiedintegrations) - Returns all integrations

### [Auth](docs/sdks/auth/README.md)

* [GetUnifiedIntegrationAuth](docs/sdks/auth/README.md#getunifiedintegrationauth) - Create connection indirectly
* [GetUnifiedIntegrationLogin](docs/sdks/auth/README.md#getunifiedintegrationlogin) - Sign in a user

### [Login](docs/sdks/login/README.md)

* [GetUnifiedIntegrationLogin](docs/sdks/login/README.md#getunifiedintegrationlogin) - Sign in a user

### [Webhook](docs/sdks/webhook/README.md)

* [CreateUnifiedWebhook](docs/sdks/webhook/README.md#createunifiedwebhook) - Create webhook subscription
* [GetUnifiedWebhook](docs/sdks/webhook/README.md#getunifiedwebhook) - Retrieve webhook by its ID
* [ListUnifiedWebhooks](docs/sdks/webhook/README.md#listunifiedwebhooks) - Returns all registered webhooks
* [RemoveUnifiedWebhook](docs/sdks/webhook/README.md#removeunifiedwebhook) - Remove webhook subscription
<!-- End Available Resources and Operations [operations] -->

<!-- Start Server Selection [server] -->
## Server Selection

## Server Selection

### Select Server by Index

You can override the default server globally by passing a server index to the `serverIndex: number` optional parameter when initializing the SDK client instance. The selected server will then be used as the default on the operations that use it. This table lists the indexes associated with the available servers:

| # | Server | Variables |
| - | ------ | --------- |
| 0 | `https://api.unified.to` | None |
| 1 | `https://api-eu.unified.to` | None |




### Override Server URL Per-Client

The default server can also be overridden globally by passing a URL to the `serverUrl: str` optional parameter when initializing the SDK client instance. For example:
<!-- End Server Selection [server] -->

<!-- Start SDK Installation [installation] -->
## SDK Installation

### Nuget

```bash
dotnet add package Unified-csharp-sdk
```
<!-- End SDK Installation [installation] -->

<!-- Placeholder for Future Speakeasy SDK Sections -->

# Development

## Maturity

This SDK is in beta, and there may be breaking changes between versions without a major version update. Therefore, we recommend pinning usage
to a specific package version. This way, you can install the same version each time without breaking changes unless you are intentionally
looking for the latest version.

## Contributions

While we value open-source contributions to this SDK, this library is generated programmatically.
Feel free to open a PR or a Github issue as a proof of concept and we'll do our best to include it in a future release!

### SDK Created by [Speakeasy](https://docs.speakeasyapi.dev/docs/using-speakeasy/client-sdks)
