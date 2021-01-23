using Tubumu.Core.Extensions;

namespace Tubumu.Mediasoup
{
    /// <summary>
    /// Producer type.
    /// </summary>
    public enum ProducerType
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
