using Tubumu.Core.Extensions;

namespace Tubumu.Mediasoup
{
    /// <summary>
    /// SCTP state.
    /// </summary>
    public enum SctpState
    {
        [EnumStringValue("new")]
        New,

        [EnumStringValue("connecting")]
        Connecting,

        [EnumStringValue("connected")]
        Connected,

        [EnumStringValue("failed")]
        Failed,

        [EnumStringValue("closed")]
        Closed
    }
}
