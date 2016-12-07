using System.Threading.Tasks;

using MollieResellerApi.Models.Reseller.Account;

namespace MollieResellerApi.Client.Reseller
{
    public interface IAccountClient
    {
        Task<CreateAccountResponse> CreateAccountAsync(CreateAccountRequest request);

        Task<EditAccountResponse> EditAccountAsync(EditAccountRequest request);

        Task<DisconnectAccountResponse> DisconnectAccountAsync(DisconnectAccountRequest request);

        Task<IsAccountValidResponse> IsAccountValidAsync(IsAccountValidRequest request);

        Task<AvailablePaymentMethodsResponse> AvailablePaymentMethodsAsync(AvailablePaymentMethodsRequest request);
    }
}
