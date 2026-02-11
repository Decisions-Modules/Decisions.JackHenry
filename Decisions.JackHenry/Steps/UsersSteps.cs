using System;
using DecisionsFramework.Design.Flow;
using DecisionsFramework.Design.Flow.StepImplementations;
using DecisionsFramework.Design.Properties;
using DecisionsFramework.Design.Properties.Attributes;
using static Decisions.JackHenry.JackHenryUtility;

namespace Decisions.JackHenry
{
    [AutoRegisterMethodsOnClass(true, "Integration", "Jack Henry", "Users")]
    public static class UsersSteps
    {
        public static UserInfo GetUserInformation(
            [PropertyClassification("Financial Institution URL", 0)] string baseUrl,
            [PropertyClassification("OAuth Token", 10), TokenPicker] string tokenId,
            [PropertyClassification("User ID", 20)] string userId)
        {
            string url = GetUrl(baseUrl, userId, null);
            return SendRequest<UserInfo>(url, tokenId);
        }
    }
}
