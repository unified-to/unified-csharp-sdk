
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace UnifiedTo
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;
    using UnifiedTo.Models.Components;
    using UnifiedTo.Models.Errors;
    using UnifiedTo.Utils;

    /// <summary>
    /// Unified.to API: One API to Rule Them All
    /// </summary>
    public interface IUnifiedToSDK
    {
        public IAccounting Accounting { get; }
        public IAccount Account { get; }
        public IContact Contact { get; }
        public IInvoice Invoice { get; }
        public IOrganization Organization { get; }
        public ITaxrate Taxrate { get; }
        public ITransaction Transaction { get; }
        public IAts Ats { get; }
        public IActivity Activity { get; }
        public IApplication Application { get; }
        public IApplicationstatus Applicationstatus { get; }
        public ICandidate Candidate { get; }
        public ICompany Company { get; }
        public IDocument Document { get; }
        public IInterview Interview { get; }
        public IJob Job { get; }
        public IScorecard Scorecard { get; }
        public ICommerce Commerce { get; }
        public ICollection Collection { get; }
        public IInventory Inventory { get; }
        public IItem Item { get; }
        public ILocation Location { get; }
        public ICrm Crm { get; }
        public IDeal Deal { get; }
        public IEvent Event { get; }
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
        public IPayment Payment { get; }
        public ILink Link { get; }
        public IPayout Payout { get; }
        public IRefund Refund { get; }
        public IStorage Storage { get; }
        public IFile File { get; }
        public ITicketing Ticketing { get; }
        public ICustomer Customer { get; }
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
        public IIssue Issue { get; }
        public IWebhook Webhook { get; }
    }

    public class SDKConfig
    {
        /// <summary>
        /// List of server URLs available to the SDK.
        /// </summary>
        public static readonly string[] ServerList = {
            "https://api.unified.to",
            "https://api-eu.unified.to",
        };

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
    public class UnifiedToSDK: IUnifiedToSDK
    {
        public SDKConfig SDKConfiguration { get; private set; }

        private const string _language = "csharp";
        private const string _sdkVersion = "0.14.0";
        private const string _sdkGenVersion = "2.295.1";
        private const string _openapiDocVersion = "1.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.14.0 2.295.1 1.0 UnifiedTo";
        private string _serverUrl = "";
        private int _serverIndex = 0;
        private ISpeakeasyHttpClient _defaultClient;
        private Func<Security>? _securitySource;
        public IAccounting Accounting { get; private set; }
        public IAccount Account { get; private set; }
        public IContact Contact { get; private set; }
        public IInvoice Invoice { get; private set; }
        public IOrganization Organization { get; private set; }
        public ITaxrate Taxrate { get; private set; }
        public ITransaction Transaction { get; private set; }
        public IAts Ats { get; private set; }
        public IActivity Activity { get; private set; }
        public IApplication Application { get; private set; }
        public IApplicationstatus Applicationstatus { get; private set; }
        public ICandidate Candidate { get; private set; }
        public ICompany Company { get; private set; }
        public IDocument Document { get; private set; }
        public IInterview Interview { get; private set; }
        public IJob Job { get; private set; }
        public IScorecard Scorecard { get; private set; }
        public ICommerce Commerce { get; private set; }
        public ICollection Collection { get; private set; }
        public IInventory Inventory { get; private set; }
        public IItem Item { get; private set; }
        public ILocation Location { get; private set; }
        public ICrm Crm { get; private set; }
        public IDeal Deal { get; private set; }
        public IEvent Event { get; private set; }
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
        public IPayment Payment { get; private set; }
        public ILink Link { get; private set; }
        public IPayout Payout { get; private set; }
        public IRefund Refund { get; private set; }
        public IStorage Storage { get; private set; }
        public IFile File { get; private set; }
        public ITicketing Ticketing { get; private set; }
        public ICustomer Customer { get; private set; }
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
        public IIssue Issue { get; private set; }
        public IWebhook Webhook { get; private set; }

        public UnifiedToSDK(Security? security = null, Func<Security>? securitySource = null, int? serverIndex = null, string? serverUrl = null, Dictionary<string, string>? urlParams = null, ISpeakeasyHttpClient? client = null)
        {
            if (serverIndex != null)
            {
                if (serverIndex.Value < 0 || serverIndex.Value >= SDKConfig.ServerList.Length)
                {
                    throw new Exception($"Invalid server index {serverIndex.Value}");
                }
                _serverIndex = serverIndex.Value;
            }

            if (serverUrl != null)
            {
                if (urlParams != null)
                {
                    serverUrl = Utilities.TemplateUrl(serverUrl, urlParams);
                }
                _serverUrl = serverUrl;
            }

            _defaultClient = new SpeakeasyHttpClient(client);

            if(securitySource != null)
            {
                _securitySource = securitySource;
            }
            else if(security != null)
            {
                _securitySource = () => security;
            }

            SDKConfiguration = new SDKConfig()
            {
                serverIndex = _serverIndex,
                serverUrl = _serverUrl
            };

            Accounting = new Accounting(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Account = new Account(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Contact = new Contact(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Invoice = new Invoice(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Organization = new Organization(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Taxrate = new Taxrate(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Transaction = new Transaction(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Ats = new Ats(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Activity = new Activity(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Application = new Application(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Applicationstatus = new Applicationstatus(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Candidate = new Candidate(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Company = new Company(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Document = new Document(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Interview = new Interview(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Job = new Job(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Scorecard = new Scorecard(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Commerce = new Commerce(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Collection = new Collection(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Inventory = new Inventory(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Item = new Item(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Location = new Location(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Crm = new Crm(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Deal = new Deal(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Event = new Event(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Lead = new Lead(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Pipeline = new Pipeline(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Enrich = new Enrich(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Person = new Person(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Hris = new Hris(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Employee = new Employee(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Group = new Group(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Martech = new Martech(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            List = new List(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Member = new Member(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Passthrough = new Passthrough(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Payment = new Payment(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Link = new Link(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Payout = new Payout(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Refund = new Refund(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Storage = new Storage(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            File = new File(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Ticketing = new Ticketing(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Customer = new Customer(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Note = new Note(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Ticket = new Ticket(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Uc = new Uc(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Call = new Call(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Unified = new Unified(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Apicall = new Apicall(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Connection = new Connection(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Integration = new Integration(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Auth = new Auth(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Login = new Login(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Issue = new Issue(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Webhook = new Webhook(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
        }
    }
}
