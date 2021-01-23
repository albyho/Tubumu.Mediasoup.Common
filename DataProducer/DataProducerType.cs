using Tubumu.Core.Extensions;

namespace Tubumu.Mediasoup
{
    public enum DataProducerType
    {
        [EnumStringValue("sctp")]
        Sctp,

        [EnumStringValue("direct")]
        Direct
    }
}
