using Algorand.Process.Algod.Client;
using Algorand.Tools.Api;
using System;

namespace Algorand.Test.Client.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var algoapi = new AlgorandApiClient("https://testnet-algorand.api.purestake.io/ps1");
            algoapi.SetApiKey("X-API-Key", "");

            var algod = new AlgodClient(algoapi);

            var addre = algod.GetTransactionsPendingAsync("LHHQJ6UMXRGEPXBVFKT7SY26BQOIK64VVPCLVRL3RNQLX5ZMBYG6ZHZMBE").Result;

            Console.ReadLine();
        }
    }
}