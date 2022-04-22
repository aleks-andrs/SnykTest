using TestSnykApiCall.ApiHandler;

namespace TestSnykApiCall
{
    public class MainClass
    {
        public ApiRequests apiRequests;
        public MainClass()
        {
            apiRequests = new ApiRequests();
        }

        public async Task<string> GetOrganisations()
        {
            var result = await apiRequests.GetOrganisationsRequest();
            if(result is null)
            {
                throw new Exception();
            }

            return result;
        }

        public async Task<string> GetIntegrations(string integrationId)
        {
            var result = await apiRequests.GetIntegrationsRequest(integrationId);
            if (result is null)
            {
                throw new Exception();
            }

            return result;
        }

        public async Task<string> ListGroupMembers(string groupId)
        {
            var result = await apiRequests.ListGroupMembersRequest(groupId);
            if (result is null)
            {
                throw new Exception();
            }

            return result;
        }

        public async Task<string> AddUser(string orgId, string groupId, string userId, string role)
        {
            var result = await apiRequests.AddUserRequest(orgId, groupId, userId, role);
            if (result is null)
            {
                throw new Exception();
            }

            return result;
        }
    }
}
