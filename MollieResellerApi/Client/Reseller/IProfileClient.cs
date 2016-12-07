using System.Threading.Tasks;

using MollieResellerApi.Models.Reseller.Profile;

namespace MollieResellerApi.Client.Reseller
{
    public interface IProfileClient
    {
        Task<CreateProfileResponse> CreateProfileAsync(CreateProfileRequest request);

        Task<GetProfilesResponse> GetProfilesAsync(GetProfilesRequest request);
    }
}
