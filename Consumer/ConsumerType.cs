using Tubumu.Core.Extensions;

namespace Tubumu.Mediasoup
{
    /// <summary>
    /// Consumer type.
    /// </summary>
    public enum ConsumerType
    {
        [EnumStringValue("simple")]
        Simple,

        [EnumStringValue("simulcast")]
        Simulcast,

        [EnumStringValue("svc")]
        Svc,

        [EnumStringValue("pipe")]
        Pipe
    }
}
