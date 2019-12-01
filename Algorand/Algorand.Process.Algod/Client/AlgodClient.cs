using Algorand.Tools.Api;
using Algorand.Tools.Api.Models;
using Algorand.Tools.Api.Response;
using System;
using System.Threading.Tasks;

namespace Algorand.Process.Algod.Client
{
    public class AlgodClient
    {
        private readonly IAlgorandApiClient _apiClient;
        private string ApiVersion = "v1";

        public AlgodClient(IAlgorandApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public void SetApiVersion(string apiVersion)
        {
            ApiVersion = apiVersion;
        }

        #region Health
        public async Task<ResponseBase<string>> GetHealthAsync()
        {
            try
            {
                var model = await _apiClient.GetAsync<string>("health");

                return ResponseBase<string>.Success("OK");
            }
            catch (Exception ex)
            {
                return ResponseBase<string>.Error(default, FormatError(ex));
            }
        }
        #endregion

        #region Account
        public async Task<ResponseBase<AccountInformation>> GetAccountInformationAsync(string address)
        {
            try
            {
                var model = await _apiClient.GetAsync<AccountInformation>($"{ApiVersion}/account/{address}");

                return ResponseBase<AccountInformation>.Success(model);
            }
            catch (Exception ex)
            {
                return ResponseBase<AccountInformation>.Error(null, FormatError(ex));
            }
        }
        #endregion

        private string FormatError(Exception ex)
            => $"Exception: {ex.Message} | StackTrace: {ex.StackTrace}";
    }
}