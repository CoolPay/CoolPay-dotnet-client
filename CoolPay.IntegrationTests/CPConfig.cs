using System;

namespace CoolPay.IntegrationTests
{
    internal static class CpConfig
    {
        public static string ApiKey
        {
            get { return Environment.GetEnvironmentVariable("COOLPAY_API_KEY"); }
        }
        public static string Username
        {
            get { return Environment.GetEnvironmentVariable("COOLPAY_USERNAME"); }
        }
         public static string Password 
        {
            get { return Environment.GetEnvironmentVariable("COOLPAY_PASSWORD"); }
        }
 
    }
}
