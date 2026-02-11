using System;
using DecisionsFramework.Design.Flow;
using DecisionsFramework.Design.Flow.StepImplementations;
using DecisionsFramework.Design.Properties;
using DecisionsFramework.Design.Properties.Attributes;
using static Decisions.JackHenry.JackHenryUtility;

namespace Decisions.JackHenry
{
    [AutoRegisterMethodsOnClass(true, "Integration", "Jack Henry", "Accounts")]
    public static class AccountsSteps
    {
        public static Accounts GetAllAccounts(
            [PropertyClassification("Financial Institution URL", 0)] string baseUrl,
            [PropertyClassification("OAuth Token", 10), TokenPicker] string tokenId,
            [PropertyClassification("User ID", 20)] string userId,
            [PropertyClassification("Active Users Only", 30)] bool? active = null)
        {
            string url = GetUrl(baseUrl, userId, "accounts");
            AddParam(ref url, active);
            return SendRequest<Accounts>(url, tokenId);
        }

        public static AccountNumber GetAccountNumber(
            [PropertyClassification("Financial Institution URL", 0)] string baseUrl,
            [PropertyClassification("OAuth Token", 10), TokenPicker] string tokenId,
            [PropertyClassification("User ID", 20)] string userId,
            [PropertyClassification("Account ID", 30)] string accountId)
        {
            string url = GetUrl(baseUrl, userId, $"accounts/{accountId}/number");
            return SendRequest<AccountNumber>(url, tokenId);
        }

        public static Entitlements GetEntitlements(
            [PropertyClassification("Financial Institution URL", 0)] string baseUrl,
            [PropertyClassification("OAuth Token", 10), TokenPicker] string tokenId,
            [PropertyClassification("User ID", 20)] string userId)
        {
            string url = GetUrl(baseUrl, userId, $"accounts/entitlements");
            return SendRequest<Entitlements>(url, tokenId);
        }

        public static Account GetAccount(
            [PropertyClassification("Financial Institution URL", 0)] string baseUrl,
            [PropertyClassification("OAuth Token", 10), TokenPicker] string tokenId,
            [PropertyClassification("User ID", 20)] string userId,
            [PropertyClassification("Account ID", 30)] string accountId)
        {
            string url = GetUrl(baseUrl, userId, $"accounts/{accountId}");
            return SendRequest<Account>(url, tokenId);
        }
    }
}
