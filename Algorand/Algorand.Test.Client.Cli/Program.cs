using Algorand.Process.Algod.Client;
using Algorand.Tools.Api;
using System;

namespace Algorand.Test.Client.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var algoapi = new AlgorandApiClient("https://testnet-algorand.api.purestake.io/ps1/");
            algoapi.SetApiKey("X-API-Key", "");

            var algod = new AlgodClient(algoapi);

            var addre = algod.GetAccountInformationAsync("AEC4WDHXCDF4B5LBNXXRTB3IJTVJSWUZ4VJ4THPU2QGRJGTA3MIDFN3CQA").Result;

            Console.ReadLine();
        }
    }
}