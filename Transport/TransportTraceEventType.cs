using Tubumu.Core.Extensions;

namespace Tubumu.Mediasoup
{
    /// <summary>
    /// Transport trace event type.
    /// </summary>
    public enum TransportTraceEventType
    {
        [EnumStringValue("probation")]
        Probation,

        [EnumStringValue("bwe")]
        BWE
    }
}
