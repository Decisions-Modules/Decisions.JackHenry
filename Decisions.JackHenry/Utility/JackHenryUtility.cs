using System;
using System.Runtime.CompilerServices;

namespace Decisions.JackHenry
{
    internal static class JackHenryUtility
    {
        internal static string GetUrl(string baseUrl, string userId, string endpointSegments)
        {
            if (string.IsNullOrEmpty(endpointSegments))
                return $"https://{baseUrl}/a/consumer/api/v0/users/{userId}";
            else
                return $"https://{baseUrl}/a/consumer/api/v0/users/{userId}/{endpointSegments}";
        }

        internal static void AddParam(ref string url, object param, [CallerArgumentExpression("param")] string expression = null)
        {
            if (param == null)
                return;

            char symbol = url.Contains('?') ? '&' : '?';
            url = $"{url}{symbol}{expression}={param}";
        }

        internal static string GetDateString(DateTime? dateTime)
        {
            if (dateTime == null)
                return null;
            
            return dateTime.Value.ToString("yyyy-MM-ddTHH:mm:ssZ");
        }

        internal static T SendRequest<T>(string url, string tokenId)
        {
            return default(T);
            // TODO: fetch token, then simple call to httpclient
        }
    }
}
