namespace LibAtem.Commands.CameraControl
{
    [CommandName("CCst"), NoCommandId]
    public class CCstCommand : ICommand
    {
        public void Serialize(ByteArrayBuilder cmd)
        {
            cmd.AddByte(0x00, 0x00); // ??
            cmd.AddByte(0x13, 0x88);
        }

        public void Deserialize(ParsedByteArray cmd)
        {
            cmd.Skip(4);
        }
    }
}