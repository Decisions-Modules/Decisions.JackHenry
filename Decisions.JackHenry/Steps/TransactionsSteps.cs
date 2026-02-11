using System;
using DecisionsFramework.Design.Flow;
using DecisionsFramework.Design.Flow.StepImplementations;
using DecisionsFramework.Design.Properties;
using DecisionsFramework.Design.Properties.Attributes;
using static Decisions.JackHenry.JackHenryUtility;

namespace Decisions.JackHenry
{
    [AutoRegisterMethodsOnClass(true, "Integration", "Jack Henry", "Transactions")]
    public static class TransactionsSteps
    {
        public static PaginatedTransactions GetAllTransactions(
            [PropertyClassification("Financial Institution URL", 0)] string baseUrl,
            [PropertyClassification("OAuth Token", 10), TokenPicker] string tokenId,
            [PropertyClassification("User ID", 20)] string userId,
            [PropertyClassification("Account ID", 30)] string accountId,
            [PropertyClassification("Offset", 40)] int? offset = null,
            [PropertyClassification("Limit", 50)] int? limit = null,
            [PropertyClassification("Since", 60)] DateTime? sinceDate = null,
            [PropertyClassification("Until", 70)] DateTime? untilDate = null,
            [PropertyClassification("Updated Since", 80)] DateTime? updatedSinceDate = null)
        {
            string url = GetUrl(baseUrl, userId, $"accounts/{accountId}/transactions");
            string since = GetDateString(sinceDate);
            string until = GetDateString(untilDate);
            string updatedSince = GetDateString(updatedSinceDate);
            AddParam(ref url, offset);
            AddParam(ref url, limit);
            AddParam(ref url, since);
            AddParam(ref url, until);
            AddParam(ref url, updatedSince);
            return SendRequest<PaginatedTransactions>(url, tokenId);
        }

        public static Transaction GetTransaction(
            [PropertyClassification("Financial Institution URL", 0)] string baseUrl,
            [PropertyClassification("OAuth Token", 10), TokenPicker] string tokenId,
            [PropertyClassification("User ID", 20)] string userId,
            [PropertyClassification("Account ID", 30)] string accountId,
            [PropertyClassification("Transaction ID", 40)] string transactionId)
        {
            string url = GetUrl(baseUrl, userId, $"accounts/{accountId}/transactions/{transactionId}");
            return SendRequest<Transaction>(url, tokenId);
        }
   }
}
