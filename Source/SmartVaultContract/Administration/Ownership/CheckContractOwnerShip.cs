namespace SmartWallet.Administration.Ownership
{
    public static class CheckContractOwnerShip
    {
        public static bool IsMethod(string method)
        {
            return method == "CheckOwnewShip";
        }

        public static string Execute(object[] args)
        {
            return "";
        }
    }
}
