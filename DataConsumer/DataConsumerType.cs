using Tubumu.Core.Extensions;

namespace Tubumu.Mediasoup
{
    public enum DataConsumerType
    {
        [EnumStringValue("sctp")]
        Sctp,

        [EnumStringValue("direct")]
        Direct
    }
}
