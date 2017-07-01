using LibAtem.Common;
using LibAtem.Serialization;

namespace LibAtem.Commands.DownstreamKey
{
    [CommandName("CDsR", 4)]
    public class DownstreamKeyRateSetCommand : SerializableCommandBase
    {
        [Serializable(0), Enum8]
        public DownstreamKeyId Index { get; set; }
        [Serializable(1), UInt8Range(0, 250)]
        public uint Rate { get; set; }
    }
}