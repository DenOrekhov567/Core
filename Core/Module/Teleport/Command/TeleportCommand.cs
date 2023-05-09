using LiteLoader.DynamicCommand;
using MC;
using static LiteLoader.DynamicCommand.DynamicCommand;

namespace Core.Module.Teleport.Command;

public class TeleportCommand
{
    private static readonly LiteLoader.Logger.Logger logger = new("TeleportCommand");

    public void Init()
    {
        DynamicCommandInstance instance = DynamicCommand.CreateCommand("tpa", "Телепортироваться к игроку", CommandPermissionLevel.Any);
        instance.SetAlias("aliafortest");
        instance.AddOverload(new List<string>());
        instance.SetCallback((cmd, origin, output, results) =>
        {
            Execute(cmd, origin, output, results);
        });
        DynamicCommand.Setup(instance);

        CorePlugin.GetInstance().GetLogger().Execute("Команда TeleportCommand включена");
    }

    public void Execute(DynamicCommand cmd, CommandOrigin origin, CommandOutput output, Dictionary<string, Result> results)
    {
        Level.BroadcastText("hihi!", TextType.RAW);
        output.Success("successful");
    }

}