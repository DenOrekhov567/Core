using LiteLoader.DynamicCommand;

namespace Core.Module.Teleport.Command
{
    public class TeleportCommandManager
    {
        public static void InitCommands()
        {
            TeleportCommand teleportCommand = new TeleportCommand();
            teleportCommand.Execute();
        }
    }
}