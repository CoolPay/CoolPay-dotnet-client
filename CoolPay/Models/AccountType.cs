using System;

namespace CoolPay.Models
{
	[Obsolete ("This is an example class, please do not use in production")]
    [JsonConverter(typeof (StringEnumConverter))]
    public enum AccountType
    {
        Any,
        Merchant,
        Reseller,
        Administrator,
        User
    }
}