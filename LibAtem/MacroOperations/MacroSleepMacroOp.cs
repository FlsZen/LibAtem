using LibAtem.Commands;
using LibAtem.Common;
using LibAtem.Serialization;

namespace LibAtem.MacroOperations
{
    [MacroOperation(MacroOperationType.MacroSleep, 8)]
    public class MacroSleepMacroOp : MacroOpBase
    {
        [Serialize(4), UInt8]
        [MacroField("Frames")]
        public uint Frames { get; set; }

        public override ICommand ToCommand()
        {
            return null;
        }
    }
}