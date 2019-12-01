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

            var addre = algod.GetTransactionsPendingAsync("XXVIIAQBPZLX4IABY2TRLKXEMYQKDSTUKUY37DHTFRQ764XH4VXHV3ITNI").Result;

            Console.ReadLine();
        }
    }
}