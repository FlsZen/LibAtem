using System;
using LibAtem.Common;
using LibAtem.Serialization;

namespace LibAtem.Commands.MixEffects.Transition
{
    [CommandName("CTTp", 4)]
    public class TransitionPropertiesSetCommand : SerializableCommandBase
    {
        [Flags]
        public enum MaskFlags
        {
            Style = 1 << 0,
            Selection = 1 << 1,
        }

        [Serializable(0), Enum8]
        public MaskFlags Mask { get; set; }
        [Serializable(1), Enum8]
        public MixEffectBlockId Index { get; set; }
        [Serializable(2), Enum8]
        public TStyle Style { get; set; }
        [Serializable(3), Enum8]
        public TransitionLayer Selection { get; set; }
    }
}