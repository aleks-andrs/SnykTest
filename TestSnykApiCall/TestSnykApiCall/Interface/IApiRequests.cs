
namespace TestSnykApiCall.Interface
{
    public interface IApiRequests
    {
        Task<string?> GetOrganisationsRequest();
        Task<string?> GetIntegrationsRequest(string orgId);
        Task<string?> ListGroupMembersRequest(string groupId);
        Task<string?> AddUserRequest(string orgId, string groupId, string userId, string role);
    }
}
