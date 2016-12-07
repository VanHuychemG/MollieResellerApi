using System.Threading.Tasks;

using MollieResellerApi.Models.Reseller.Profile;

namespace MollieResellerApi.Client.Reseller
{
    public interface IProfileClient
    {
        Task<ProfileCreateResponse> CreateProfileAsync(ProfileCreateRequest request);

        Task<ProfilesResponse> GetProfilesAsync(ProfilesRequest request);
    }
}
