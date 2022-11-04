using System;
using System.Security.Cryptography;

namespace DataEncryptionLab6_Kot_PC_21_MH
{
    public static class KeyGen
    {
        public static byte[] generator_Key(int lenKey, string numKey = "з нулями")
        {
            var rng = new RNGCryptoServiceProvider();
            var randomArray = new byte[lenKey];

            switch (numKey)
            {
                case "з нулями":
                    rng.GetBytes(randomArray);
                    break;
                case "без нулів":
                    rng.GetNonZeroBytes(randomArray);
                    break;
                default:
                    throw new Exception("Error");
            }

            return randomArray;
        }
    }
}