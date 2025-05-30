//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace UnifiedTo
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using UnifiedTo.Hooks;
    using UnifiedTo.Models.Components;
    using UnifiedTo.Models.Errors;
    using UnifiedTo.Utils;
    using UnifiedTo.Utils.Retries;

    /// <summary>
    /// Unified.to API: One API to Rule Them All
    /// </summary>
    public interface IUnifiedToSDK
    {
        public IAccounting Accounting { get; }
        public IAccount Account { get; }
        public IContact Contact { get; }
        public IInvoice Invoice { get; }
        public IJournal Journal { get; }
        public IOrder Order { get; }
        public IOrganization Organization { get; }
        public IReport Report { get; }
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
        public ICalendar Calendar { get; }
        public IBusy Busy { get; }
        public IEvent Event { get; }
        public ILink Link { get; }
        public IRecording Recording { get; }
        public ICommerce Commerce { get; }
        public ICollection Collection { get; }
        public IInventory Inventory { get; }
        public IItem Item { get; }
        public ILocation Location { get; }
        public IReview Review { get; }
        public ICrm Crm { get; }
        public IDeal Deal { get; }
        public ILead Lead { get; }
        public IPipeline Pipeline { get; }
        public IEnrich Enrich { get; }
        public IPerson Person { get; }
        public IGenai Genai { get; }
        public IModel Model { get; }
        public IPrompt Prompt { get; }
        public IHris Hris { get; }
        public IDevice Device { get; }
        public IEmployee Employee { get; }
        public IGroup Group { get; }
        public IPayslip Payslip { get; }
        public ITimeoff Timeoff { get; }
        public ITimeshift Timeshift { get; }
        public IKms Kms { get; }
        public IComment Comment { get; }
        public IPage Page { get; }
        public ISpace Space { get; }
        public ILms Lms { get; }
        public IClass Class { get; }
        public ICourse Course { get; }
        public IInstructor Instructor { get; }
        public IStudent Student { get; }
        public IMartech Martech { get; }
        public IList List { get; }
        public IMember Member { get; }
        public IMessaging Messaging { get; }
        public IChannel Channel { get; }
        public IMessage Message { get; }
        public IMetadata Metadata { get; }
        public IPassthrough Passthrough { get; }
        public IPayment Payment { get; }
        public IPayout Payout { get; }
        public IRefund Refund { get; }
        public ISubscription Subscription { get; }
        public IRepo Repo { get; }
        public IBranch Branch { get; }
        public ICommit Commit { get; }
        public IPullrequest Pullrequest { get; }
        public IRepository Repository { get; }
        public IScim Scim { get; }
        public IUser User { get; }
        public IStorage Storage { get; }
        public IFile File { get; }
        public ITask Task { get; }
        public IProject Project { get; }
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
            "https://api-au.unified.to",
        };

        public string ServerUrl = "";
        public int ServerIndex = 0;
        public SDKHooks Hooks = new SDKHooks();
        public RetryConfig? RetryConfig = null;

        public string GetTemplatedServerUrl()
        {
            if (!String.IsNullOrEmpty(this.ServerUrl))
            {
                return Utilities.TemplateUrl(Utilities.RemoveSuffix(this.ServerUrl, "/"), new Dictionary<string, string>());
            }
            return Utilities.TemplateUrl(SDKConfig.ServerList[this.ServerIndex], new Dictionary<string, string>());
        }

        public ISpeakeasyHttpClient InitHooks(ISpeakeasyHttpClient client)
        {
            string preHooksUrl = GetTemplatedServerUrl();
            var (postHooksUrl, postHooksClient) = this.Hooks.SDKInit(preHooksUrl, client);
            if (preHooksUrl != postHooksUrl)
            {
                this.ServerUrl = postHooksUrl;
            }
            return postHooksClient;
        }
    }

    /// <summary>
    /// Unified.to API: One API to Rule Them All
    /// </summary>
    public class UnifiedToSDK: IUnifiedToSDK
    {
        public SDKConfig SDKConfiguration { get; private set; }

        private const string _language = "csharp";
        private const string _sdkVersion = "0.23.7";
        private const string _sdkGenVersion = "2.610.0";
        private const string _openapiDocVersion = "1.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.23.7 2.610.0 1.0 UnifiedTo";
        private string _serverUrl = "";
        private int _serverIndex = 0;
        private ISpeakeasyHttpClient _client;
        private Func<UnifiedTo.Models.Components.Security>? _securitySource;
        public IAccounting Accounting { get; private set; }
        public IAccount Account { get; private set; }
        public IContact Contact { get; private set; }
        public IInvoice Invoice { get; private set; }
        public IJournal Journal { get; private set; }
        public IOrder Order { get; private set; }
        public IOrganization Organization { get; private set; }
        public IReport Report { get; private set; }
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
        public ICalendar Calendar { get; private set; }
        public IBusy Busy { get; private set; }
        public IEvent Event { get; private set; }
        public ILink Link { get; private set; }
        public IRecording Recording { get; private set; }
        public ICommerce Commerce { get; private set; }
        public ICollection Collection { get; private set; }
        public IInventory Inventory { get; private set; }
        public IItem Item { get; private set; }
        public ILocation Location { get; private set; }
        public IReview Review { get; private set; }
        public ICrm Crm { get; private set; }
        public IDeal Deal { get; private set; }
        public ILead Lead { get; private set; }
        public IPipeline Pipeline { get; private set; }
        public IEnrich Enrich { get; private set; }
        public IPerson Person { get; private set; }
        public IGenai Genai { get; private set; }
        public IModel Model { get; private set; }
        public IPrompt Prompt { get; private set; }
        public IHris Hris { get; private set; }
        public IDevice Device { get; private set; }
        public IEmployee Employee { get; private set; }
        public IGroup Group { get; private set; }
        public IPayslip Payslip { get; private set; }
        public ITimeoff Timeoff { get; private set; }
        public ITimeshift Timeshift { get; private set; }
        public IKms Kms { get; private set; }
        public IComment Comment { get; private set; }
        public IPage Page { get; private set; }
        public ISpace Space { get; private set; }
        public ILms Lms { get; private set; }
        public IClass Class { get; private set; }
        public ICourse Course { get; private set; }
        public IInstructor Instructor { get; private set; }
        public IStudent Student { get; private set; }
        public IMartech Martech { get; private set; }
        public IList List { get; private set; }
        public IMember Member { get; private set; }
        public IMessaging Messaging { get; private set; }
        public IChannel Channel { get; private set; }
        public IMessage Message { get; private set; }
        public IMetadata Metadata { get; private set; }
        public IPassthrough Passthrough { get; private set; }
        public IPayment Payment { get; private set; }
        public IPayout Payout { get; private set; }
        public IRefund Refund { get; private set; }
        public ISubscription Subscription { get; private set; }
        public IRepo Repo { get; private set; }
        public IBranch Branch { get; private set; }
        public ICommit Commit { get; private set; }
        public IPullrequest Pullrequest { get; private set; }
        public IRepository Repository { get; private set; }
        public IScim Scim { get; private set; }
        public IUser User { get; private set; }
        public IStorage Storage { get; private set; }
        public IFile File { get; private set; }
        public ITask Task { get; private set; }
        public IProject Project { get; private set; }
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

        public UnifiedToSDK(UnifiedTo.Models.Components.Security? security = null, Func<UnifiedTo.Models.Components.Security>? securitySource = null, int? serverIndex = null, string? serverUrl = null, Dictionary<string, string>? urlParams = null, ISpeakeasyHttpClient? client = null, RetryConfig? retryConfig = null)
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

            _client = client ?? new SpeakeasyHttpClient();

            if(securitySource != null)
            {
                _securitySource = securitySource;
            }
            else if(security != null)
            {
                _securitySource = () => security;
            }
            else
            {
                throw new Exception("security and securitySource cannot both be null");
            }

            SDKConfiguration = new SDKConfig()
            {
                ServerIndex = _serverIndex,
                ServerUrl = _serverUrl,
                RetryConfig = retryConfig
            };

            _client = SDKConfiguration.InitHooks(_client);


            Accounting = new Accounting(_client, _securitySource, _serverUrl, SDKConfiguration);


            Account = new Account(_client, _securitySource, _serverUrl, SDKConfiguration);


            Contact = new Contact(_client, _securitySource, _serverUrl, SDKConfiguration);


            Invoice = new Invoice(_client, _securitySource, _serverUrl, SDKConfiguration);


            Journal = new Journal(_client, _securitySource, _serverUrl, SDKConfiguration);


            Order = new Order(_client, _securitySource, _serverUrl, SDKConfiguration);


            Organization = new Organization(_client, _securitySource, _serverUrl, SDKConfiguration);


            Report = new Report(_client, _securitySource, _serverUrl, SDKConfiguration);


            Taxrate = new Taxrate(_client, _securitySource, _serverUrl, SDKConfiguration);


            Transaction = new Transaction(_client, _securitySource, _serverUrl, SDKConfiguration);


            Ats = new Ats(_client, _securitySource, _serverUrl, SDKConfiguration);


            Activity = new Activity(_client, _securitySource, _serverUrl, SDKConfiguration);


            Application = new Application(_client, _securitySource, _serverUrl, SDKConfiguration);


            Applicationstatus = new Applicationstatus(_client, _securitySource, _serverUrl, SDKConfiguration);


            Candidate = new Candidate(_client, _securitySource, _serverUrl, SDKConfiguration);


            Company = new Company(_client, _securitySource, _serverUrl, SDKConfiguration);


            Document = new Document(_client, _securitySource, _serverUrl, SDKConfiguration);


            Interview = new Interview(_client, _securitySource, _serverUrl, SDKConfiguration);


            Job = new Job(_client, _securitySource, _serverUrl, SDKConfiguration);


            Scorecard = new Scorecard(_client, _securitySource, _serverUrl, SDKConfiguration);


            Calendar = new Calendar(_client, _securitySource, _serverUrl, SDKConfiguration);


            Busy = new Busy(_client, _securitySource, _serverUrl, SDKConfiguration);


            Event = new Event(_client, _securitySource, _serverUrl, SDKConfiguration);


            Link = new Link(_client, _securitySource, _serverUrl, SDKConfiguration);


            Recording = new Recording(_client, _securitySource, _serverUrl, SDKConfiguration);


            Commerce = new Commerce(_client, _securitySource, _serverUrl, SDKConfiguration);


            Collection = new Collection(_client, _securitySource, _serverUrl, SDKConfiguration);


            Inventory = new Inventory(_client, _securitySource, _serverUrl, SDKConfiguration);


            Item = new Item(_client, _securitySource, _serverUrl, SDKConfiguration);


            Location = new Location(_client, _securitySource, _serverUrl, SDKConfiguration);


            Review = new Review(_client, _securitySource, _serverUrl, SDKConfiguration);


            Crm = new Crm(_client, _securitySource, _serverUrl, SDKConfiguration);


            Deal = new Deal(_client, _securitySource, _serverUrl, SDKConfiguration);


            Lead = new Lead(_client, _securitySource, _serverUrl, SDKConfiguration);


            Pipeline = new Pipeline(_client, _securitySource, _serverUrl, SDKConfiguration);


            Enrich = new Enrich(_client, _securitySource, _serverUrl, SDKConfiguration);


            Person = new Person(_client, _securitySource, _serverUrl, SDKConfiguration);


            Genai = new Genai(_client, _securitySource, _serverUrl, SDKConfiguration);


            Model = new Model(_client, _securitySource, _serverUrl, SDKConfiguration);


            Prompt = new Prompt(_client, _securitySource, _serverUrl, SDKConfiguration);


            Hris = new Hris(_client, _securitySource, _serverUrl, SDKConfiguration);


            Device = new Device(_client, _securitySource, _serverUrl, SDKConfiguration);


            Employee = new Employee(_client, _securitySource, _serverUrl, SDKConfiguration);


            Group = new Group(_client, _securitySource, _serverUrl, SDKConfiguration);


            Payslip = new Payslip(_client, _securitySource, _serverUrl, SDKConfiguration);


            Timeoff = new Timeoff(_client, _securitySource, _serverUrl, SDKConfiguration);


            Timeshift = new Timeshift(_client, _securitySource, _serverUrl, SDKConfiguration);


            Kms = new Kms(_client, _securitySource, _serverUrl, SDKConfiguration);


            Comment = new Comment(_client, _securitySource, _serverUrl, SDKConfiguration);


            Page = new Page(_client, _securitySource, _serverUrl, SDKConfiguration);


            Space = new Space(_client, _securitySource, _serverUrl, SDKConfiguration);


            Lms = new Lms(_client, _securitySource, _serverUrl, SDKConfiguration);


            Class = new Class(_client, _securitySource, _serverUrl, SDKConfiguration);


            Course = new Course(_client, _securitySource, _serverUrl, SDKConfiguration);


            Instructor = new Instructor(_client, _securitySource, _serverUrl, SDKConfiguration);


            Student = new Student(_client, _securitySource, _serverUrl, SDKConfiguration);


            Martech = new Martech(_client, _securitySource, _serverUrl, SDKConfiguration);


            List = new List(_client, _securitySource, _serverUrl, SDKConfiguration);


            Member = new Member(_client, _securitySource, _serverUrl, SDKConfiguration);


            Messaging = new Messaging(_client, _securitySource, _serverUrl, SDKConfiguration);


            Channel = new Channel(_client, _securitySource, _serverUrl, SDKConfiguration);


            Message = new Message(_client, _securitySource, _serverUrl, SDKConfiguration);


            Metadata = new Metadata(_client, _securitySource, _serverUrl, SDKConfiguration);


            Passthrough = new Passthrough(_client, _securitySource, _serverUrl, SDKConfiguration);


            Payment = new Payment(_client, _securitySource, _serverUrl, SDKConfiguration);


            Payout = new Payout(_client, _securitySource, _serverUrl, SDKConfiguration);


            Refund = new Refund(_client, _securitySource, _serverUrl, SDKConfiguration);


            Subscription = new Subscription(_client, _securitySource, _serverUrl, SDKConfiguration);


            Repo = new Repo(_client, _securitySource, _serverUrl, SDKConfiguration);


            Branch = new Branch(_client, _securitySource, _serverUrl, SDKConfiguration);


            Commit = new Commit(_client, _securitySource, _serverUrl, SDKConfiguration);


            Pullrequest = new Pullrequest(_client, _securitySource, _serverUrl, SDKConfiguration);


            Repository = new Repository(_client, _securitySource, _serverUrl, SDKConfiguration);


            Scim = new Scim(_client, _securitySource, _serverUrl, SDKConfiguration);


            User = new User(_client, _securitySource, _serverUrl, SDKConfiguration);


            Storage = new Storage(_client, _securitySource, _serverUrl, SDKConfiguration);


            File = new File(_client, _securitySource, _serverUrl, SDKConfiguration);


            Task = new Task(_client, _securitySource, _serverUrl, SDKConfiguration);


            Project = new Project(_client, _securitySource, _serverUrl, SDKConfiguration);


            Ticketing = new Ticketing(_client, _securitySource, _serverUrl, SDKConfiguration);


            Customer = new Customer(_client, _securitySource, _serverUrl, SDKConfiguration);


            Note = new Note(_client, _securitySource, _serverUrl, SDKConfiguration);


            Ticket = new Ticket(_client, _securitySource, _serverUrl, SDKConfiguration);


            Uc = new Uc(_client, _securitySource, _serverUrl, SDKConfiguration);


            Call = new Call(_client, _securitySource, _serverUrl, SDKConfiguration);


            Unified = new Unified(_client, _securitySource, _serverUrl, SDKConfiguration);


            Apicall = new Apicall(_client, _securitySource, _serverUrl, SDKConfiguration);


            Connection = new Connection(_client, _securitySource, _serverUrl, SDKConfiguration);


            Integration = new Integration(_client, _securitySource, _serverUrl, SDKConfiguration);


            Auth = new Auth(_client, _securitySource, _serverUrl, SDKConfiguration);


            Login = new Login(_client, _securitySource, _serverUrl, SDKConfiguration);


            Issue = new Issue(_client, _securitySource, _serverUrl, SDKConfiguration);


            Webhook = new Webhook(_client, _securitySource, _serverUrl, SDKConfiguration);
        }
    }
}