
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Unified.To
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;
    using Unified.To.Models.Components;
    using Unified.To.Utils;



    /// <summary>
    /// Unified.to API: One API to Rule Them All
    /// </summary>
    public interface IUnifiedTo
    {
        public IAccounting Accounting { get; }
        public IAccount Account { get; }
        public ICustomer Customer { get; }
        public IInvoice Invoice { get; }
        public IItem Item { get; }
        public IOrganization Organization { get; }
        public IPayment Payment { get; }
        public ITaxrate Taxrate { get; }
        public ITransaction Transaction { get; }
        public IAts Ats { get; }
        public IApplication Application { get; }
        public IApplicationstatus Applicationstatus { get; }
        public ICandidate Candidate { get; }
        public IDocument Document { get; }
        public IInterview Interview { get; }
        public IJob Job { get; }
        public IScorecard Scorecard { get; }
        public ICrm Crm { get; }
        public ICompany Company { get; }
        public IContact Contact { get; }
        public IDeal Deal { get; }
        public IEvent Event { get; }
        public IFile File { get; }
        public ILead Lead { get; }
        public IPipeline Pipeline { get; }
        public IEnrich Enrich { get; }
        public IPerson Person { get; }
        public IHris Hris { get; }
        public IEmployee Employee { get; }
        public IGroup Group { get; }
        public IMartech Martech { get; }
        public IList List { get; }
        public IMember Member { get; }
        public IPassthrough Passthrough { get; }
        public IStorage Storage { get; }
        public ITicketing Ticketing { get; }
        public INote Note { get; }
        public ITicket Ticket { get; }
        public IUc Uc { get; }
        public ICall Call { get; }
        public IUnified Unified { get; }
        public IApicall Apicall { get; }
        public IConnection Connection { get; }
        public IIntegration Integration { get; }
        public IAuth Auth { get; }
        public ILogin Login { get; }
        public IWebhook Webhook { get; }
    }
    
    public class SDKConfig
    {
        public static string[] ServerList = new string[]
        {
            "https://api.unified.to",
            "https://api-eu.unified.to",
        };
        /// Contains the list of servers available to the SDK
        public string serverUrl = "";
        public int serverIndex = 0;

        public string GetTemplatedServerDetails()
        {
            if (!String.IsNullOrEmpty(this.serverUrl))
            {
                return Utilities.TemplateUrl(Utilities.RemoveSuffix(this.serverUrl, "/"), new Dictionary<string, string>());
            }
            return Utilities.TemplateUrl(SDKConfig.ServerList[this.serverIndex], new Dictionary<string, string>());
        }
    }

    /// <summary>
    /// Unified.to API: One API to Rule Them All
    /// </summary>
    public class UnifiedTo: IUnifiedTo
    {
        public SDKConfig SDKConfiguration { get; private set; }

        private const string _language = "csharp";
        private const string _sdkVersion = "0.3.0";
        private const string _sdkGenVersion = "2.223.3";
        private const string _openapiDocVersion = "1.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.3.0 2.223.3 1.0 Unified.to";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;
        public IAccounting Accounting { get; private set; }
        public IAccount Account { get; private set; }
        public ICustomer Customer { get; private set; }
        public IInvoice Invoice { get; private set; }
        public IItem Item { get; private set; }
        public IOrganization Organization { get; private set; }
        public IPayment Payment { get; private set; }
        public ITaxrate Taxrate { get; private set; }
        public ITransaction Transaction { get; private set; }
        public IAts Ats { get; private set; }
        public IApplication Application { get; private set; }
        public IApplicationstatus Applicationstatus { get; private set; }
        public ICandidate Candidate { get; private set; }
        public IDocument Document { get; private set; }
        public IInterview Interview { get; private set; }
        public IJob Job { get; private set; }
        public IScorecard Scorecard { get; private set; }
        public ICrm Crm { get; private set; }
        public ICompany Company { get; private set; }
        public IContact Contact { get; private set; }
        public IDeal Deal { get; private set; }
        public IEvent Event { get; private set; }
        public IFile File { get; private set; }
        public ILead Lead { get; private set; }
        public IPipeline Pipeline { get; private set; }
        public IEnrich Enrich { get; private set; }
        public IPerson Person { get; private set; }
        public IHris Hris { get; private set; }
        public IEmployee Employee { get; private set; }
        public IGroup Group { get; private set; }
        public IMartech Martech { get; private set; }
        public IList List { get; private set; }
        public IMember Member { get; private set; }
        public IPassthrough Passthrough { get; private set; }
        public IStorage Storage { get; private set; }
        public ITicketing Ticketing { get; private set; }
        public INote Note { get; private set; }
        public ITicket Ticket { get; private set; }
        public IUc Uc { get; private set; }
        public ICall Call { get; private set; }
        public IUnified Unified { get; private set; }
        public IApicall Apicall { get; private set; }
        public IConnection Connection { get; private set; }
        public IIntegration Integration { get; private set; }
        public IAuth Auth { get; private set; }
        public ILogin Login { get; private set; }
        public IWebhook Webhook { get; private set; }

        public UnifiedTo(Security? security = null, int? serverIndex = null, string? serverUrl = null, Dictionary<string, string>? urlParams = null, ISpeakeasyHttpClient? client = null)
        {
            if (serverUrl != null) {
                if (urlParams != null) {
                    serverUrl = Utilities.TemplateUrl(serverUrl, urlParams);
                }
                _serverUrl = serverUrl;
            }

            _defaultClient = new SpeakeasyHttpClient(client);
            _securityClient = _defaultClient;
            
            if(security != null)
            {
                _securityClient = SecuritySerializer.Apply(_defaultClient, security);
            }
            
            SDKConfiguration = new SDKConfig()
            {
                serverUrl = _serverUrl
            };

            Accounting = new Accounting(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Account = new Account(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Customer = new Customer(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Invoice = new Invoice(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Item = new Item(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Organization = new Organization(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Payment = new Payment(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Taxrate = new Taxrate(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Transaction = new Transaction(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Ats = new Ats(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Application = new Application(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Applicationstatus = new Applicationstatus(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Candidate = new Candidate(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Document = new Document(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Interview = new Interview(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Job = new Job(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Scorecard = new Scorecard(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Crm = new Crm(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Company = new Company(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Contact = new Contact(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Deal = new Deal(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Event = new Event(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            File = new File(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Lead = new Lead(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Pipeline = new Pipeline(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Enrich = new Enrich(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Person = new Person(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Hris = new Hris(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Employee = new Employee(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Group = new Group(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Martech = new Martech(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            List = new List(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Member = new Member(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Passthrough = new Passthrough(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Storage = new Storage(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Ticketing = new Ticketing(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Note = new Note(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Ticket = new Ticket(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Uc = new Uc(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Call = new Call(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Unified = new Unified(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Apicall = new Apicall(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Connection = new Connection(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Integration = new Integration(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Auth = new Auth(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Login = new Login(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Webhook = new Webhook(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
        }
    }
}