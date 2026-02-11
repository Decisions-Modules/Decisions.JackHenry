using System;
using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using Newtonsoft.Json;

namespace Decisions.JackHenry
{
    [Writable, DataContract]
    public class PaginatedTransactions
    {
        [WritableValue, DataMember]
        [JsonProperty("inactivatedTransactionIds")]
        public string[] InactivatedTransactionIds { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("transactions")]
        public Transaction[] Transactions { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("offset")]
        public int? Offset { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("limit")]
        public int? Limit { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("account")]
        public AccountTypeInfo Account { get; set; }
    }

    [Writable, DataContract]
    public class Transaction
    {
        [WritableValue, DataMember]
        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        /// <summary>
        /// Transaction amount.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("amount")]
        public string Amount { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("merchant")]
        public Merchant Merchant { get; set; }

        /// <summary>
        /// The transaction memo.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// The transaction memo with some extraneous details removed.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("filteredMemo")]
        public string FilteredMemo { get; set; }

        /// <summary>
        /// The name displayed for this transaction.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// The city displayed for this transaction.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("displayCity")]
        public string DisplayCity { get; set; }

        /// <summary>
        /// The state displayed for this transaction.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("displayState")]
        public string DisplayState { get; set; }

        /// <summary>
        /// Refers to one of the transaction-types. See listing on this page.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The check number associated with this transaction.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("checkNumber")]
        public string CheckNumber { get; set; }

        /// <summary>
        /// The currency that the amount is displayed in.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The account ID.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        /// <summary>
        /// The transaction ID.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The date that the transaction posted.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("datePosted")]
        public string DatePosted { get; set; }

        /// <summary>
        /// Normalized by the client to only show the date. Currently the same as `datePosted`.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("date")]
        public string Date { get; set; }

        /// <summary>
        /// States whether the transaction has hard-posted or not.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("pendingStatus")]
        public string PendingStatus { get; set; }

        /// <summary>
        /// Any Bill ID associated with this transaction.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("billId")]
        public string BillId { get; set; }

        /// <summary>
        /// Any payment ID associated with this transaction.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("paymentId")]
        public string PaymentId { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("receiptImageIds")]
        public string[] ReceiptImageIds { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("checkImageIds")]
        public string[] CheckImageIds { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("userImageIds")]
        public string[] UserImageIds { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("providerImageIds")]
        public string[] ProviderImageIds { get; set; }

        /// <summary>
        /// A boolean to tell whether or not the transaction has provider images associated with it.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("hasProviderImages")]
        public bool? HasProviderImages { get; set; }

        /// <summary>
        /// The running account balance at the point in time of this transaction.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("runningBalance")]
        public string RunningBalance { get; set; }

        /// <summary>
        /// Transaction order position by date.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("sequence")]
        public int? Sequence { get; set; }

        /// <summary>
        /// A timestamp indicating when this transaction was last updated.
        /// <br/>
        /// <br/>The reasons for an update may include (but are not limited to):
        /// <br/>
        /// <br/>- Changes of data within the financial core (e.g., running balance, check images, etc.)
        /// <br/>- Changes by the user (e.g., adding tags, notes, images, etc.)
        /// <br/>- Transaction enrichments.
        /// <br/>
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("lastUpdated")]
        public DateTimeOffset? LastUpdated { get; set; }

        /// <summary>
        /// All notes associated with the transaction.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("notes")]
        public string Notes { get; set; }

        /// <summary>
        /// The transaction category that this transaction falls into, if any. See listing on this page.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("subtype")]
        public string Subtype { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("enrichments")]
        public Enrichments Enrichments { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("loanPaymentBreakdown")]
        public LoanPaymentBreakdown[] LoanPaymentBreakdown { get; set; }

        /// <summary>
        /// Flag to know if the transaction has EDI attributes.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("EDIAvailable")]
        public bool? EDIAvailable { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("sourceData")]
        public MoovSourceData SourceData { get; set; }

        /// <summary>
        /// Last 4 digits of the debit/credit card number, only populated for the Symitar core. String can be null.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("cardNumber", Required = Newtonsoft.Json.Required.Default)]
        public string CardNumber { get; set; }
    }

    [Writable, DataContract]
    public class AccountTypeInfo
    {
        /// <summary>
        /// The values of accountType are described in account-types
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("accountType")]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AccountType? AccountType { get; set; }

        /// <summary>
        /// The values of accountSubType are described in account-types
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("accountSubType")]
        public string AccountSubType { get; set; }
    }

    [Writable, DataContract]
    public class LoanPaymentBreakdown
    {
        /// <summary>
        /// Payment description.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Payment amount.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("amount")]
        public string Amount { get; set; }
    }

    /// <summary>
    /// Source-provided data, presented exactly as provided from the ultimate source of the transaction.
    /// <br/>The data provided here comes directly from the Moov API.
    /// <br/>
    /// <br/>[Moov API docs](https://docs.moov.io/api/sources/wallets/get-transaction/)
    /// <br/>
    /// </summary>
    [Writable, DataContract]
    public class MoovSourceData
    {
        /// <summary>
        /// The data provider. If present, the value will be `Moov`.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("provider")]
        public string Provider { get; set; }

        /// <summary>
        /// The Moov Wallet id.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("walletId")]
        public string WalletId { get; set; }

        /// <summary>
        /// The id of the Moov sweep this transaction is in.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("sweepId")]
        public string SweepId { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("transactionType")]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MoovSourceDataTransactionType? TransactionType { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("sourceType")]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MoovSourceDataSourceType? SourceType { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("status")]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MoovSourceDataStatus? Status { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("createdOn")]
        public string CreatedOn { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("completedOn")]
        public string CompletedOn { get; set; }

        /// <summary>
        /// The total Moov transaction amount.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("grossAmount")]
        public string GrossAmount { get; set; }

        /// <summary>
        /// Total Moov fees paid for the transaction.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("feeAmount")]
        public string FeeAmount { get; set; }

        /// <summary>
        /// The ids of the individual Moov fee charges that sum up to the fee amount.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("feeIds")]
        public string[] FeeIds { get; set; }

        /// <summary>
        /// The gross amount less fees paid for a Moov transaction. This amount is the amount that affects the Moov Wallet's balance.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("netAmount")]
        public string NetAmount { get; set; }

        /// <summary>
        /// A 3-letter ISO 4217 currency code.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    [Writable, DataContract]
    public class CategoryIcon
    {
        /// <summary>
        /// URL to the category icons in Png.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("image/png")]
        public string Image_png { get; set; }

        /// <summary>
        /// URL to the category icons in Svg.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("image/svg+xml")]
        public string Image_svgplusxml { get; set; }
    }

    [Writable, DataContract]
    public class Merchant
    {
        /// <summary>
        /// The merchant name.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The merchant ID - deprecated.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The merchant's parent ID - deprecated.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("parentMerchantId")]
        public string ParentMerchantId { get; set; }

        /// <summary>
        /// The merchant's web URL.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// The merchant's telephone number.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The merchant economic sector.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("category")]
        public string Category { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("location")]
        public Location Location { get; set; }
    }

    [Writable, DataContract]
    public class Enrichments
    {
        /// <summary>
        /// Transaction description.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("cleanMemo")]
        public string CleanMemo { get; set; }

        /// <summary>
        /// Expense category for the transaction. (Not closed, more possible values could be added in the future)
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("expenseCategory")]
        public string ExpenseCategory { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("categoryIcon")]
        public CategoryIcon CategoryIcon { get; set; }

        /// <summary>
        /// Free-form expense category for the transaction.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("customExpenseCategory")]
        public string CustomExpenseCategory { get; set; }

        /// <summary>
        /// Unique identifier for the merchant.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("merchantId")]
        public string MerchantId { get; set; }

        /// <summary>
        /// URL to the merchant's logo image.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// User-defined custom name for the merchant.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("customMerchantName", Required = Newtonsoft.Json.Required.Default)]
        public string CustomMerchantName { get; set; }
    }

    public enum AccountType
    {
        [EnumMember(Value = @"Deposit")]
        Deposit = 0,

        [EnumMember(Value = @"Line of Credit")]
        Line_of_Credit = 1,

        [EnumMember(Value = @"Debt")]
        Debt = 2,

        [EnumMember(Value = @"Investment")]
        Investment = 3,

        [EnumMember(Value = @"Bill Pay")]
        Bill_Pay = 4,

        [EnumMember(Value = @"Other")]
        Other = 5,

        [EnumMember(Value = @"Unknown")]
        Unknown = 6,
    }

    public enum MoovSourceDataTransactionType
    {
        [EnumMember(Value = @"account-funding")]
        AccountFunding = 0,

        [EnumMember(Value = @"ach-reversal")]
        AchReversal = 1,

        [EnumMember(Value = @"adjustment")]
        Adjustment = 2,

        [EnumMember(Value = @"auto-sweep")]
        AutoSweep = 3,

        [EnumMember(Value = @"card-payment")]
        CardPayment = 4,

        [EnumMember(Value = @"card-decline")]
        CardDecline = 5,

        [EnumMember(Value = @"card-reversal")]
        CardReversal = 6,

        [EnumMember(Value = @"cash-out")]
        CashOut = 7,

        [EnumMember(Value = @"dispute")]
        Dispute = 8,

        [EnumMember(Value = @"dispute-reversal")]
        DisputeReversal = 9,

        [EnumMember(Value = @"facilitator-fee")]
        FacilitatorFee = 10,

        [EnumMember(Value = @"issuing-refund")]
        IssuingRefund = 11,

        [EnumMember(Value = @"issuing-transaction")]
        IssuingTransaction = 12,

        [EnumMember(Value = @"issuing-transaction-adjustment")]
        IssuingTransactionAdjustment = 13,

        [EnumMember(Value = @"issuing-auth-hold")]
        IssuingAuthHold = 14,

        [EnumMember(Value = @"issuing-auth-release")]
        IssuingAuthRelease = 15,

        [EnumMember(Value = @"issuing-decline")]
        IssuingDecline = 16,

        [EnumMember(Value = @"moov-fee")]
        MoovFee = 17,

        [EnumMember(Value = @"payment")]
        Payment = 18,

        [EnumMember(Value = @"payout")]
        Payout = 19,

        [EnumMember(Value = @"refund")]
        Refund = 20,

        [EnumMember(Value = @"refund-failure")]
        RefundFailure = 21,

        [EnumMember(Value = @"rtp-failure")]
        RtpFailure = 22,

        [EnumMember(Value = @"top-up")]
        TopUp = 23,

        [EnumMember(Value = @"wallet-transfer")]
        WalletTransfer = 24,
    }

    public enum MoovSourceDataSourceType
    {
        [EnumMember(Value = @"adjustment")]
        Adjustment = 0,

        [EnumMember(Value = @"dispute")]
        Dispute = 1,

        [EnumMember(Value = @"fee")]
        Fee = 2,

        [EnumMember(Value = @"issuing-authorization")]
        IssuingAuthorization = 3,

        [EnumMember(Value = @"issuing-card-transaction")]
        IssuingCardTransaction = 4,

        [EnumMember(Value = @"transfer")]
        Transfer = 5,

        [EnumMember(Value = @"sweep")]
        Sweep = 6,
    }

    public enum MoovSourceDataStatus
    {
        [EnumMember(Value = @"canceled")]
        Canceled = 0,

        [EnumMember(Value = @"completed")]
        Completed = 1,

        [EnumMember(Value = @"failed")]
        Failed = 2,

        [EnumMember(Value = @"pending")]
        Pending = 3,
    }

    [Writable, DataContract]
    public class Location
    {
        /// <summary>
        /// The merchant's street address.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("streetAddress")]
        public string StreetAddress { get; set; }

        /// <summary>
        /// The merchant's cross-street.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("crossStreet")]
        public string CrossStreet { get; set; }

        /// <summary>
        /// The merchant's city.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// The merchant's state.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// The merchant's postal code.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("zip")]
        public string Zip { get; set; }

        /// <summary>
        /// The merchant locations latitude.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("lat")]
        public string Lat { get; set; }

        /// <summary>
        /// The merchant locations longitude.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("long")]
        public string Long { get; set; }
    }
}
