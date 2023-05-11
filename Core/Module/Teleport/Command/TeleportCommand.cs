using LiteLoader.DynamicCommand;
using MC;
using static LiteLoader.DynamicCommand.DynamicCommand;

namespace Core.Module.Teleport.Command;

public class TeleportCommand
{
    private static readonly LiteLoader.Logger.Logger logger = new("TeleportCommand");

    public void Init()
    {
        DynamicCommandInstance Instance = DynamicCommand.CreateCommand("tpgo", "Телепортироваться к игроку", CommandPermissionLevel.Any);
        //Instance.SetAlias("");
        Instance.AddOverload(new List<string>());
        Instance.SetCallback((Cmd, Origin, Output, Results) =>
        {
            Execute(Cmd, Origin, Output, Results);
        });
        DynamicCommand.Setup(Instance);

        CorePlugin.GetInstance().GetLogger().Execute("Команда TeleportCommand включена");
    }

    public void Execute(DynamicCommand Cmd, CommandOrigin Origin, CommandOutput Output, Dictionary<string, Result> Results)
    {
        Level.BroadcastText("hihi!", TextType.RAW);
        Output.Success("successful");
    }

}