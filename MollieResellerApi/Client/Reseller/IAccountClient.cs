﻿using System.Threading.Tasks;

using MollieResellerApi.Models.Reseller.Account;

namespace MollieResellerApi.Client.Reseller
{
    public interface IAccountClient
    {
        Task<AccountClaimResponse> ClaimAccountAsync(AccountClaimRequest request);

        Task<AccountCreateResponse> CreateAccountAsync(AccountCreateRequest request);

        Task<AccountEditResponse> EditAccountAsync(AccountEditRequest request);

        Task<DisconnectAccountResponse> DisconnectAccountAsync(DisconnectAccountRequest request);

        Task<AccountValidResponse> IsAccountValidAsync(AccountValidRequest request);

        Task<AvailablePaymentMethodsResponse> AvailablePaymentMethodsAsync(AvailablePaymentMethodsRequest request);

        Task<BankAccountsResponse> GetBankAccountsMethodsAsync(BankAccountsRequest request);

        Task<BankAccountEditResponse> EditBankAccountMethodsAsync(BankAccountEditRequest request);

        Task<GetLoginLinkResponse> GetLoginLinkAsync(GetLoginLinkRequest request);

        Task<SetFeesResponse> SetFeesAsync(SetFeesRequest request);
    }
}
