using System;
using System.Security.Cryptography;

namespace DataEncryptionLab6_Kot_PC_21_MH
{
    public class PassWordGen
    {
        private readonly string passWord;
        private readonly int myLength;
        private readonly byte[] salt0 = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };

        public PassWordGen(string usageText, string usageLen)
        {
            passWord = usageText;
            myLength = Int32.Parse(usageLen);
        }
        
        private byte[] calculations(string passWord, int len) => new Rfc2898DeriveBytes(passWord, salt0).GetBytes(len);

        public byte[] Result => calculations(passWord, myLength);
    }
}