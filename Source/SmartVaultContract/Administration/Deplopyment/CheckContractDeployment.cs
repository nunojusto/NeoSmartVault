using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Services.Neo;

namespace SmartWallet.Administration.Deplopyment
{
    public static class CheckContractDeployment
    {
        public static bool IsMethod(string method)
        {
            return method == "CheckDeployContract";
        }

        public static string Execute(object[] args)
        {
            var isContractActive = Storage.Get(Storage.CurrentContext, "Active").AsString();

            if (isContractActive == "1")
            {
                return "ACTIVE";
            }

            return "INACTIVE";
        }
    }
}
