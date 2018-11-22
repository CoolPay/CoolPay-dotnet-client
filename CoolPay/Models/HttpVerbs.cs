namespace CoolPay.Models
{
    // ReSharper disable InconsistentNaming
    [JsonConverter(typeof (StringEnumConverter))]
    public enum HttpVerb
    {
        GET,
        POST,
        DELETE,
        PUT,
        PATCH
    }
}