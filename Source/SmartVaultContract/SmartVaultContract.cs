using Neo.SmartContract.Framework;

namespace SmartWallet
{
    public class SmartVaultContract : SmartContract
    {
        public static string Main(string method, params object[] args)
        {
            if (Administration.Deplopyment.CheckContractDeployment.IsMethod(method))
            {
                return Administration.Deplopyment.CheckContractDeployment.Execute(args);
            }

            return "ERROR 001: Unknown method " + method;
        }
    }
}
