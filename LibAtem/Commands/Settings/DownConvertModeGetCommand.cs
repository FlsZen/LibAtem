﻿using LibAtem.Common;
using LibAtem.Serialization;

namespace LibAtem.Commands.Settings
{
    [CommandName("DcOt", 4)]
    public class DownConvertModeGetCommand : SerializableCommandBase
    {
        [Serializable(0), Enum8]
        public DownConvertMode DownConvertMode { get; set; }
    }
}