using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

using MollieResellerApi.Extensions;
using MollieResellerApi.Infrastructure;
using MollieResellerApi.Models.Reseller;
using MollieResellerApi.Models.Reseller.Account;
using MollieResellerApi.Models.Reseller.Profile;

namespace MollieResellerApi.Client.Reseller
{
    public class ResellerClient : IAccountClient, IProfileClient
    {
        //  Api
        public const string ApiEndPoint = "https://www.mollie.com/api/reseller";
        public const string ApiVersion = "v1";

        //  Commands
        public const string AccountCreateCommand = "account-create";
        public const string AccountEditCommand = "account-edit";
        public const string AccountValidCommand = "account-valid";
        public const string AccountDisconnectCommand = "account-disconnect";

        public const string AvailablePaymentMethodsCommand = "available-payment-methods";

        public const string ProfileCreateCommand = "profile-create";
        public const string ProfileListCommand = "profiles";

        private readonly HttpClient _client;

        private readonly MollieConfigurationOptions _options;
        private readonly Action<string> _logger;

        private static Uri GetBaseAddress() => new Uri($"{ApiEndPoint}/{ApiVersion}/");

        private static HttpClient CreateClient => new HttpClient { BaseAddress = GetBaseAddress() };

        public ResellerClient(
            MollieConfigurationOptions options,
            Action<string> logger)
        {
            _options = options;
            _logger = logger;

            _client = CreateClient;
        }

        public async Task<CreateAccountResponse> CreateAccountAsync(CreateAccountRequest request)
        {
            return await PostAsync<CreateAccountResponse>(AccountCreateCommand, request);
        }

        public async Task<EditAccountResponse> EditAccountAsync(EditAccountRequest request)
        {
            return await PostAsync<EditAccountResponse>(AccountEditCommand, request);
        }

        public async Task<DisconnectAccountResponse> DisconnectAccountAsync(DisconnectAccountRequest request)
        {
            return await PostAsync<DisconnectAccountResponse>(AccountDisconnectCommand, request);
        }

        public async Task<IsAccountValidResponse> IsAccountValidAsync(IsAccountValidRequest request)
        {
            return await PostAsync<IsAccountValidResponse>(AccountValidCommand, request);
        }

        public async Task<AvailablePaymentMethodsResponse> AvailablePaymentMethodsAsync(AvailablePaymentMethodsRequest request)
        {
            return await PostAsync<AvailablePaymentMethodsResponse>(AvailablePaymentMethodsCommand, request);
        }

        public async Task<CreateProfileResponse> CreateProfileAsync(CreateProfileRequest request)
        {
            //  save hash, live and test key
            return await PostAsync<CreateProfileResponse>(ProfileCreateCommand, request);
        }

        public async Task<GetProfilesResponse> GetProfilesAsync(GetProfilesRequest request)
        {
            // get the auto created profile based on hash and save the live key
            return await PostAsync<GetProfilesResponse>(ProfileListCommand, request);
        }

        private async Task<T> PostAsync<T>(string command, object data)
        {
            // convert class to dictionary
            var parameters = data.ToDictionary();

            //  create sorted querystring from dictionary
            var query = parameters.ToSortedQueryString();

            //  sign request based on sorted querystring
            var signature = $"/api/reseller/v1/{command}?{query}"
                .Replace("%20", "+")
                .Hash(_options.ResellerSecret);

            //  add the signature to the dictionary
            parameters.Add("signature", signature);

            _logger($"Posting to {_client.BaseAddress}{command}");
            var response = await _client.PostAsync(command, new FormUrlEncodedContent(parameters));

            return ProcessHttpResponseMessage<T>(response);
        }

        private static T ProcessHttpResponseMessage<T>(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
                return response.Content.ReadAsStringAsync().Result.Deserialize<T>();

            switch (response.StatusCode)
            {
                case HttpStatusCode.BadRequest:
                case HttpStatusCode.Unauthorized:
                case HttpStatusCode.Forbidden:
                case HttpStatusCode.NotFound:
                case HttpStatusCode.MethodNotAllowed:
                case HttpStatusCode.UnsupportedMediaType:
                case (HttpStatusCode)422:
                    throw new ResellerApiException(response.Content.ReadAsStringAsync().Result);

                default:
                    throw new HttpRequestException(
                        $"Unknown http exception occured with status code: {(int)response.StatusCode}.");
            }
        }
    }
}
