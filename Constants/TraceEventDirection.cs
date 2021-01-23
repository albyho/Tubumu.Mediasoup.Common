using Tubumu.Core.Extensions;

namespace Tubumu.Mediasoup
{
    /// <summary>
    /// Trace event direction.
    /// </summary>
    public enum TraceEventDirection
    {
        [EnumStringValue("in")]
        In,

        [EnumStringValue("out")]
        Out
    }
}
