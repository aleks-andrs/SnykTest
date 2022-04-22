using TestSnykApiCall.Interface;

namespace TestSnykApiCall.ApiHandler
{
    public class ApiRequests : IApiRequests
    {
        private readonly HttpClient httpClient;

        // Constructor
        /*public ApiRequests(IHttpClientWrapper _httpClient)
        {
            httpClient = _httpClient;
        }*/

        public ApiRequests()
        {
            var baseAddress = new Uri("https://snyk.io/api/v1/");
            httpClient = new HttpClient { BaseAddress = baseAddress };
            var API_KEY = "";
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("authorization", "token " + API_KEY);
        }

        // Api request to get orgs 
        public async Task<string?> GetOrganisationsRequest()
        {
            string? responseData = null;
            try
            {
                using var response = await httpClient.GetAsync("orgs");               
                responseData = await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().FullName + ": " + ex.Message);
            }
            return responseData;
        }

        // Api request to get a list of org integrations
        public async Task<string?> GetIntegrationsRequest(string orgId)
        {
            string? responseData = null;
            try
            {
                using var response = await httpClient.GetAsync("org/" + orgId + "/integrations");
                responseData = await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().FullName + ": " + ex.Message);
            }
            return responseData;
        }

        

        // Api request to list all users in the group
        public async Task<string?> ListGroupMembersRequest(string groupId)
        {
            string? responseData = null;
            try
            {
                using var response = await httpClient.GetAsync("group/" + groupId + "/members");
                if (response.IsSuccessStatusCode)
                {
                    responseData = await response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().FullName + ": " + ex.Message);
            }
            return responseData;
        }

        // Api request to add a user to Snyk org
        public async Task<string?> AddUserRequest(string orgId, string groupId, string userId, string role)
        {
            string? responseData = null;
            using var content = new StringContent("{  \"" + userId + "\": \"\",  \"" + role + "\": \"\"}", System.Text.Encoding.Default, "application/json");
            try
            {
                using var response = await httpClient.PostAsync("group/" + groupId + "/org/" + orgId + "/members", content);
                //if (response.IsSuccessStatusCode)
                //{
                responseData = await response.Content.ReadAsStringAsync();
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().FullName + ": " + ex.Message);
            }
            return responseData;
        }
    }
}
