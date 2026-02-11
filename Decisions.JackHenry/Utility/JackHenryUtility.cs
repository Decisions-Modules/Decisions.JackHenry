using System;
using System.Runtime.CompilerServices;
using Decisions.OAuth;
using DecisionsFramework.Data.ORMapper;
using DecisionsFramework.ServiceLayer;
using DecisionsFramework.Utilities.Data;
using Newtonsoft.Json;

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
            if (string.IsNullOrEmpty(tokenId))
                throw new Exception($"No OAuth token specified");

            ORM<OAuthToken> orm = new ORM<OAuthToken>();
            OAuthToken token = orm.Fetch(tokenId);
            if (token == null)
                throw new Exception($"No OAuth token found with ID {tokenId}");

            HttpClient httpClient = HttpClients.GetHttpClient(HttpClientAuthType.Normal);
            HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get, url);
            req.Headers.Add("Authorization", $"Bearer {token.TokenData}");
            HttpResponseMessage res = httpClient.Send(req);
            res.EnsureSuccessStatusCode();

            using (Stream responseStream = res.Content.ReadAsStream())
            {
                using (StreamReader streamReader = new StreamReader(responseStream))
                {
                    string responseString = streamReader.ReadToEnd();
                    object result = JsonConvert.DeserializeObject(responseString, typeof(T));
                    return (T)result;
                }
            }
        }
    }
}
