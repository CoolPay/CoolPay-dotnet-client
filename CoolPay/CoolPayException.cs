using System;
using System.Net;

namespace CoolPay
{
    /// <summary>
    ///     Coolpay exception
    /// </summary>
    public class CoolPayException : Exception
    {
        internal CoolPayException(string message, WebException innerException) : base(message, innerException)
        {
        }

        internal CoolPayException(string message) : base(message)
        {
        }
    }
}