using System;
using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using Newtonsoft.Json;

namespace Decisions.JackHenry
{
    [Writable, DataContract]
    public class AccountNumber
    {
        [WritableValue, DataMember]
        [JsonProperty("number")]
        public string Number { get; set; }
    }

    [Writable, DataContract]
    public class Accounts
    {
        [WritableValue, DataMember]
        [JsonProperty("inactivatedAccountIds")]
        public string[] InactivatedAccountIds { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("accounts")]
        public Account[] Accounts1 { get; set; }
    }

    [Writable, DataContract]
    public class Account
    {
        /// <summary>
        /// Id of the account
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Name on the account
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The masked account number for this account
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("numbers")]
        public string Numbers { get; set; }

        /// <summary>
        /// The date of when the balance was last successfully fetched
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("fetchedDate")]
        public DateTimeOffset FetchedDate { get; set; }

        /// <summary>
        /// The values of status are described in account-status
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// The status of the account. For credit unions this value will _always_ be `Unknown`.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("accountStatus")]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AccountStatus AccountStatus { get; set; }

        /// <summary>
        /// If this account is closed, this is the date when it will no longer be available
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("closedAccountAvailableUntil")]
        [JsonConverter(typeof(DateFormatConverter))]
        public DateTimeOffset ClosedAccountAvailableUntil { get; set; }

        /// <summary>
        /// The values of lastLoginFailure are described in login-failure
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("lastLoginFailure")]
        public string LastLoginFailure { get; set; }

        /// <summary>
        /// Name of the account holder (intended for display purposes only)
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("accountHolderName")]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// The values of accountType are described in account-types
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("accountType")]
        public string AccountType { get; set; }

        /// <summary>
        /// The values of accountSubType are described in account-types
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("accountSubType")]
        public string AccountSubType { get; set; }

        /// <summary>
        /// Can create payments if true
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("canCreatePayments")]
        public bool CanCreatePayments { get; set; }

        /// <summary>
        /// Can transfer from another account if true
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("canTransferFrom")]
        public bool CanTransferFrom { get; set; }

        /// <summary>
        /// Does this account have rewards associated with it. Required to be true to be able to access the rewards endpoint for this account.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("hasRewards")]
        public bool HasRewards { get; set; }

        /// <summary>
        /// Login Id
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("loginId")]
        public string LoginId { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("institution")]
        public Institution Institution { get; set; }

        /// <summary>
        /// If the account is hidden or not
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        /// <summary>
        /// True if the account is not hidden. Deprecated in favor of `hidden`
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("active")]
        public bool Active { get; set; }

        /// <summary>
        /// The preference of whether or not an account's totals should contribute to the aggregation totals
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("contributesToAggregateTotals")]
        public bool ContributesToAggregateTotals { get; set; }

        /// <summary>
        /// Alert for low funds if true
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("lowFundsAlertEnabled")]
        public bool LowFundsAlertEnabled { get; set; }

        /// <summary>
        /// Threshold of the low funds alert
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("lowFundsAlertThreshold")]
        public string LowFundsAlertThreshold { get; set; }

        /// <summary>
        /// Sort order key for the account
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("sortIndex")]
        public int SortIndex { get; set; }

        /// <summary>
        /// Favorited if true. Deprecated in favor of `sortIndex`
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("favorited")]
        public bool Favorited { get; set; }

        /// <summary>
        /// The balance the institution discloses to Banno. Typically for cash accounts, this is the amount of cash in that account; for credit accounts, this is the cash sum of the transaction amounts that have been charged to the credit account
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// The available balance the institution discloses to Banno. Typically for cash accounts, this is the amount of cash in that account minus any pending transactions that have been authorized against that account
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("availableBalance")]
        public string AvailableBalance { get; set; }

        /// <summary>
        /// The available credit the institution discloses to Banno. This is only applicable for credit accounts
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("availableCredit")]
        public string AvailableCredit { get; set; }

        /// <summary>
        /// The limit of account credit
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("creditLimit")]
        public string CreditLimit { get; set; }

        /// <summary>
        /// When the payment is due. Normalized by the client to only show the date. NOTE this data is duplicated in `formattedMetaData`, but is still required here for other purposes.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("paymentDueDate")]
        public string PaymentDueDate { get; set; }

        /// <summary>
        /// The due amount of the payment. NOTE this data is duplicated in `formattedMetaData`, but is still required here for other purposes.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("paymentDueAmount")]
        public string PaymentDueAmount { get; set; }

        /// <summary>
        /// The minimum payment due. NOTE this data is duplicated in `formattedMetaData`, but is still required here for other purposes.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("minimumPaymentDue")]
        public string MinimumPaymentDue { get; set; }

        /// <summary>
        /// Payoff balance of the account. NOTE this data is duplicated in `formattedMetaData`, but is still required here for other purposes.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("payoffBalance")]
        public string PayoffBalance { get; set; }

        /// <summary>
        /// Interest rate. Deprecated in favor of this same data in `formattedMetaData`.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("interestRate")]
        public string InterestRate { get; set; }

        /// <summary>
        /// Origin date. The date when the account was opened. Normalized by the client to only show the date. Deprecated in favor of this same data in `formattedMetaData`.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("originationDate")]
        public string OriginationDate { get; set; }

        /// <summary>
        /// Deprecated in favor of this same data in `formattedMetaData`.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("principalAmount")]
        public string PrincipalAmount { get; set; }

        /// <summary>
        /// Interest Balance of the account. Deprecated in favor of this same data in `formattedMetaData`.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("interestBalance")]
        public string InterestBalance { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("regD")]
        public RegD RegD { get; set; }

        /// <summary>
        /// The routing number for the institution that this account belongs to
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("routingNumber")]
        public string RoutingNumber { get; set; }

        /// <summary>
        /// The values that were included in the calculation of the availableBalance provided. The calculation happens as follows:
        /// <br/>- Start with current balance
        /// <br/>- Subtract float  
        /// <br/>- Subtract holds
        /// <br/>- Subtract next day memo debits 
        /// <br/>- Add accrued interest
        /// <br/>- Add overdraft limit
        /// <br/>- Add next day memo credits
        /// <br/>- Add unused protection line 
        /// <br/>- Use sweep balances (include sweep parameters) 
        /// <br/>- Use sweep balances (do not include sweep parameters) 
        /// <br/>- Add bounce protection limit
        /// <br/>- Use investment balance
        /// <br/>
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("availableBalanceCalculationIncludes")]
        public AvailableBalanceCalculationIncludes AvailableBalanceCalculationIncludes { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("formattedMetaData")]
        public FormattedMetaData FormattedMetaData { get; set; }

        /// <summary>
        /// The account's FDIC (Federal Deposit Insurance Corporation) insured status. For FIs with the `account_fdic_config` ability turned off will be `notApplicable` for all accounts
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("insuredStatus")]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AccountInsuredStatus InsuredStatus { get; set; }
    }

    [Writable, DataContract]
    public class AccountsEntitlements
    {
        [WritableValue, DataMember]
        [JsonProperty("entitlements")]
        public Entitlements[] Entitlements { get; set; }
    }

    [Writable, DataContract]
    public class Link
    {
        /// <summary>
        /// The link ID
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Account level link type
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("linkType")]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public LinkType LinkType { get; set; }

        /// <summary>
        /// Title of the link
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Longer description of the link
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Name of the SSO provider
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// FDIC (Federal Deposit Insurance Corporation) notice text to display to the user.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("fdicNotice")]
        public string FdicNotice { get; set; }
    }

    [Writable, DataContract]
    public class FormattedMetaData
    {
        [WritableValue, DataMember]
        [JsonProperty("details")]
        public FormattedMetaDataGroup[] Details { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("rewards")]
        public FormattedMetaDataGroup[] Rewards { get; set; }
    }

    [Writable, DataContract]
    public class FormattedMetaDataGroup
    {
        [WritableValue, DataMember]
        [JsonProperty("label")]
        public string Label { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("values")]
        public TextValue[] Values { get; set; }
    }

    [Writable, DataContract]
    public class FormattedMetaDataValue
    {
        /// <summary>
        /// The discriminator to determine the value type
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("type")]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public FormattedMetaDataValueType Type { get; set; }

        /// <summary>
        /// The label to display associated with the value
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("label")]
        public string Label { get; set; }

        /// <summary>
        /// Optional extra information to display - for example, in a popup dialog triggered by an info icon next to this field.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("extraDetails")]
        public string ExtraDetails { get; set; }

        /// <summary>
        /// True if this value should be hidden from displaying in the UI. A value can be marked as hidden if the institution considers it irrelevant for account holders.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        /// <summary>
        /// The label provided by the institution
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("configuredLabel")]
        public string ConfiguredLabel { get; set; }
    }

    [Writable, DataContract]
    public class TextValue : FormattedMetaDataValue
    {
        [WritableValue, DataMember]
        [JsonProperty("type")]
        public TextValueType Type { get; set; }

        /// <summary>
        /// The text value to display
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("value")]
        public string Value { get; set; }

    }

    public enum AccountStatus
    {
        [EnumMember(Value = @"Active")]
        Active = 0,

        [EnumMember(Value = @"Active nonaccruing")]
        Active_nonaccruing = 1,

        [EnumMember(Value = @"Authorization prohibited")]
        Authorization_prohibited = 2,

        [EnumMember(Value = @"Bankrupt")]
        Bankrupt = 3,

        [EnumMember(Value = @"Charge off")]
        Charge_off = 4,

        [EnumMember(Value = @"Charged off")]
        Charged_off = 5,

        [EnumMember(Value = @"Close pending")]
        Close_pending = 6,

        [EnumMember(Value = @"Closed")]
        Closed = 7,

        [EnumMember(Value = @"Do not close on zero balance")]
        Do_not_close_on_zero_balance = 8,

        [EnumMember(Value = @"Dormant")]
        Dormant = 9,

        [EnumMember(Value = @"Drill")]
        Drill = 10,

        [EnumMember(Value = @"Escheat")]
        Escheat = 11,

        [EnumMember(Value = @"Freeze with accrual")]
        Freeze_with_accrual = 12,

        [EnumMember(Value = @"Freeze with zero accrual")]
        Freeze_with_zero_accrual = 13,

        [EnumMember(Value = @"Frozen")]
        Frozen = 14,

        [EnumMember(Value = @"Frozen nonaccruing")]
        Frozen_nonaccruing = 15,

        [EnumMember(Value = @"Frozen with accrual")]
        Frozen_with_accrual = 16,

        [EnumMember(Value = @"Frozen without accrual")]
        Frozen_without_accrual = 17,

        [EnumMember(Value = @"Inactive")]
        Inactive = 18,

        [EnumMember(Value = @"Interest accrual prohibited")]
        Interest_accrual_prohibited = 19,

        [EnumMember(Value = @"Lost")]
        Lost = 20,

        [EnumMember(Value = @"Mail return")]
        Mail_return = 21,

        [EnumMember(Value = @"Mature not paid")]
        Mature_not_paid = 22,

        [EnumMember(Value = @"Matured")]
        Matured = 23,

        [EnumMember(Value = @"Matured not paid")]
        Matured_not_paid = 24,

        [EnumMember(Value = @"New")]
        New = 25,

        [EnumMember(Value = @"No auto pay")]
        No_auto_pay = 26,

        [EnumMember(Value = @"No credits")]
        No_credits = 27,

        [EnumMember(Value = @"No post")]
        No_post = 28,

        [EnumMember(Value = @"Non accrual allow transactions")]
        Non_accrual_allow_transactions = 29,

        [EnumMember(Value = @"Normal")]
        Normal = 30,

        [EnumMember(Value = @"Not available")]
        Not_available = 31,

        [EnumMember(Value = @"Occupied")]
        Occupied = 32,

        [EnumMember(Value = @"Paid off")]
        Paid_off = 33,

        [EnumMember(Value = @"Past due")]
        Past_due = 34,

        [EnumMember(Value = @"Pending closed")]
        Pending_closed = 35,

        [EnumMember(Value = @"Redeemed")]
        Redeemed = 36,

        [EnumMember(Value = @"Restricted")]
        Restricted = 37,

        [EnumMember(Value = @"Revoked")]
        Revoked = 38,

        [EnumMember(Value = @"Stolen")]
        Stolen = 39,

        [EnumMember(Value = @"Unknown")]
        Unknown = 40,

        [EnumMember(Value = @"Unoccupied")]
        Unoccupied = 41,

        [EnumMember(Value = @"Waiting for payment")]
        Waiting_for_payment = 42,

        [EnumMember(Value = @"Zero accrual")]
        Zero_accrual = 43,
    }

    [Writable, DataContract]
    public class Institution
    {
        /// <summary>
        /// ID of the institution
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Name of the institution
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    [Writable, DataContract]
    public class RegD
    {
        /// <summary>
        /// Is this account restricted by regulation D
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("restricted")]
        public bool Restricted { get; set; }

        /// <summary>
        /// Optional number of regulation D restricted withdrawals this month
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    [Writable, DataContract]
    public class AvailableBalanceCalculationIncludes
    {
        /// <summary>
        /// The current balance is the balance of the account as of the last end of day processing, which may also include memo posted items depending on the service charge code assigned to the account.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("currentBalance")]
        public string CurrentBalance { get; set; }

        /// <summary>
        /// The hold amount is a value that can be setup on an account to limit the funds from what is available.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("holdAmount")]
        public string HoldAmount { get; set; }

        /// <summary>
        /// The float amount is the amount representing when there is a check deposited on an account and the funds are not yet considered 100% available, also known as uncollected funds.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("floatAmount")]
        public string FloatAmount { get; set; }

        /// <summary>
        /// The accrued interest is the amount the deposit account has earned based upon the interest rate defined for the account that has not been paid out to the customer.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("accruedInterest")]
        public string AccruedInterest { get; set; }

        /// <summary>
        /// The available sweep amount is the amount determined from a sweep, which is a function within the demand deposit system that allows the transfer of funds between accounts after the day’s transactions and the pre-defined criteria for the transfer have been considered.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("availableSweepAmount")]
        public string AvailableSweepAmount { get; set; }

        /// <summary>
        /// The overdraft protection amount is a line of credit amount protecting a deposit account if it becomes overdrawn. Interest charges are incurred if this amount is used. Also known as unused protection line.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("overdraftProtectionAmount")]
        public string OverdraftProtectionAmount { get; set; }

        /// <summary>
        /// The overdraft limit is the amount allowed to post against for an individual debit, which would normally be an NSF (non-sufficient funds) item.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("overdraftLimit")]
        public string OverdraftLimit { get; set; }

        /// <summary>
        /// The bounce protection amount is an extension of the overdraft limit to protect against a check being denied and returned.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("bounceProtectionAmount")]
        public string BounceProtectionAmount { get; set; }
    }

    public enum AccountInsuredStatus
    {
        [EnumMember(Value = @"fdicInsured")]
        FdicInsured = 0,

        [EnumMember(Value = @"notFdicInsured")]
        NotFdicInsured = 1,

        [EnumMember(Value = @"notApplicable")]
        NotApplicable = 2,
    }

    [Writable, DataContract]
    public class Entitlements
    {
        [WritableValue, DataMember]
        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        /// <summary>
        /// Access control value for stop payments that distinguishes between read only, write only, or read/write
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("stopPaymentsAccess")]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EntitlementsStopPaymentsAccess StopPaymentsAccess { get; set; }

        /// <summary>
        /// Allowable account for use in the Zelle feature
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("zelle")]
        public bool Zelle { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("links")]
        public Link[] Links { get; set; }
    }

    public enum LinkType
    {
        [EnumMember(Value = @"CardLocationManagement")]
        CardLocationManagement = 0,

        [EnumMember(Value = @"CheckReorderingByAccount")]
        CheckReorderingByAccount = 1,

        [EnumMember(Value = @"CreditCardControls")]
        CreditCardControls = 2,

        [EnumMember(Value = @"DocumentsByAccount")]
        DocumentsByAccount = 3,

        [EnumMember(Value = @"EStatusConnect")]
        EStatusConnect = 4,

        [EnumMember(Value = @"FSCCPayment")]
        FSCCPayment = 5,

        [EnumMember(Value = @"LoanPayment")]
        LoanPayment = 6,

        [EnumMember(Value = @"MortgageServices")]
        MortgageServices = 7,

        [EnumMember(Value = @"PowerCDRenew")]
        PowerCDRenew = 8,

        [EnumMember(Value = @"PowerLoan")]
        PowerLoan = 9,

        [EnumMember(Value = @"PowerOverdraft")]
        PowerOverdraft = 10,

        [EnumMember(Value = @"PowerWithdrawCheck")]
        PowerWithdrawCheck = 11,

        [EnumMember(Value = @"Rewards")]
        Rewards = 12,
    }

    public enum FormattedMetaDataValueType
    {
        [EnumMember(Value = @"Text")]
        Text = 0,

        [EnumMember(Value = @"Date")]
        Date = 1,

        [EnumMember(Value = @"Money")]
        Money = 2,

        [EnumMember(Value = @"Percentage")]
        Percentage = 3,

        [EnumMember(Value = @"Count")]
        Count = 4,
    }

    public enum TextValueType
    {
        [EnumMember(Value = @"Text")]
        Text = 0,
    }

    public enum EntitlementsStopPaymentsAccess
    {
        [EnumMember(Value = @"Read")]
        Read = 0,

        [EnumMember(Value = @"Write")]
        Write = 1,

        [EnumMember(Value = @"Both")]
        Both = 2,

        [EnumMember(Value = @"None")]
        None = 3,
    }

    internal class DateFormatConverter : Newtonsoft.Json.Converters.IsoDateTimeConverter
    {
        public DateFormatConverter()
        {
            DateTimeFormat = "yyyy-MM-dd";
        }
    }
}
