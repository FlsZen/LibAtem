using System;
using LibAtem.Common;
using LibAtem.Serialization;

namespace LibAtem.Commands.MixEffects.Key
{
    [CommandName("CKCk", 16)]
    public class MixEffectKeyChromaSetCommand : SerializableCommandBase
    {
        [Flags]
        public enum MaskFlags
        {
            Hue = 1 << 0,
            Gain = 1 << 1,
            YSuppress = 1 << 2,
            Lift = 1 << 3,
            Narrow = 1 << 4,
        }

        [Serializable(0), Enum8]
        public MaskFlags Mask { get; set; }
        [Serializable(1), Enum8]
        public MixEffectBlockId MixEffectIndex { get; set; }
        [Serializable(2), UInt8]
        public uint KeyerIndex { get; set; }
        [Serializable(4), UInt16D(10, 0, 3599)]
        public double Hue { get; set; }
        [Serializable(6), UInt16D(10, 0, 1000)]
        public double Gain { get; set; }
        [Serializable(8), UInt16D(10, 0, 1000)]
        public double YSuppress { get; set; }
        [Serializable(10), UInt16D(10, 0, 1000)]
        public double Lift { get; set; }
        [Serializable(12), Bool]
        public bool Narrow { get; set; }
    }
}