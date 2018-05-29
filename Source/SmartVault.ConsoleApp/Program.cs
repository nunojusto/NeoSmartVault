using System;
using System.Text;
using NeoModules.JsonRpc.Client;
using NeoModules.RPC;
using NeoModules.Core;

namespace SmartWallet.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const string contractHash = "0x417d6706e5899fbc6ea533b17c91752a040d902a";

            var rpcClient = new RpcClient(new Uri("http://localhost:30333"));
            var neoApiService = new NeoApiService(rpcClient);

            var script = NeoModules.NEP6.Utils.GenerateScript(UInt160.Parse(contractHash).ToArray(), "CheckDeployContract", new object[] { });

            var resultTask = neoApiService.Contracts.InvokeScript.SendRequestAsync(script.ToHexString());
            resultTask.ContinueWith(x =>
            {
                var content = x.Result.Stack[0].Value.ToString();
                Console.WriteLine($"bytes: {content.HexToBytes()}");
                Console.WriteLine($"value: {Encoding.UTF8.GetString(content.HexToBytes())}");
            });

            Console.ReadLine();
        }
    }
}
