using LiteLoader.DynamicCommand;
using MC;

using Core;

namespace Core.Module.Teleport.Command;

public class TeleportCommand
{
    private static readonly LiteLoader.Logger.Logger logger = new("TeleportCommand");

    public void Execute()
    {
        DynamicCommandInstance instance = DynamicCommand.CreateCommand("dytest", ".NET test command", CommandPermissionLevel.Any);
        instance.SetAlias("aliafortest");
        instance.AddOverload(new List<string>());

        instance.SetCallback((cmd, origin, output, results) =>
        {
            Level.BroadcastText("hihi!", TextType.RAW);
            output.Success("successful");
        });
        DynamicCommand.Setup(instance);

        CorePlugin.GetInstance().GetLogger().Execute("Команда TeleportCommand включена");
    }
}