using Algorand.Tools.Api;
using Algorand.Tools.Api.Models;
using Algorand.Tools.Api.Response;
using System;
using System.Collections.Generic;
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
        public async Task<ResponseBase<Account>> GetAccountInformationAsync(string address)
        {
            try
            {
                var model = await _apiClient.GetAsync<Account>($"{ApiVersion}/account/{address}");

                return ResponseBase<Account>.Success(model);
            }
            catch (Exception ex)
            {
                return ResponseBase<Account>.Error(null, FormatError(ex));
            }
        }

        public async Task<ResponseBase<Transaction>> GetTransactionInformationAsync(string address, string txId)
        {
            try
            {
                var model = await _apiClient.GetAsync<Transaction>($"{ApiVersion}/account/{address}/transaction/{txId}");

                return ResponseBase<Transaction>.Success(model);
            }
            catch (Exception ex)
            {
                return ResponseBase<Transaction>.Error(null, FormatError(ex));
            }
        }

        public async Task<ResponseBase<List<Transaction>>> GetTransactionsAsync(string address)
        {
            try
            {
                var model = await _apiClient.GetAsync<List<Transaction>>($"{ApiVersion}/account/{address}/transactions");

                return ResponseBase<List<Transaction>>.Success(model);
            }
            catch (Exception ex)
            {
                return ResponseBase<List<Transaction>>.Error(null, FormatError(ex));
            }
        }

        public async Task<ResponseBase<List<Transaction>>> GetTransactionsPendingAsync(string address)
        {
            try
            {
                var model = await _apiClient.GetAsync<List<Transaction>>($"{ApiVersion}/account/{address}/transactions/pending");

                return ResponseBase<List<Transaction>>.Success(model);
            }
            catch (Exception ex)
            {
                return ResponseBase<List<Transaction>>.Error(null, FormatError(ex));
            }
        }
        #endregion

        private string FormatError(Exception ex)
            => $"Exception: {ex.Message} | StackTrace: {ex.StackTrace}";
    }
}