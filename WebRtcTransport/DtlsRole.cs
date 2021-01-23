using Tubumu.Core.Extensions;

namespace Tubumu.Mediasoup
{
    public enum DtlsRole
    {
        [EnumStringValue("auto")]
        Auto,

        [EnumStringValue("client")]
        Client,

        [EnumStringValue("server")]
        Server
    }
}
