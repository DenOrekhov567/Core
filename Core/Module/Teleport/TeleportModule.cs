using Core.Module;
using Core;
using Core.Module.Teleport.Command;

namespace Core.Module.Teleport
{
    public class TeleportModule : IModule
    {
        public TeleportModule()
        {
            Init();
        }
        public string GetName() => "Teleport";

        public void Init()
        {
            CorePlugin.GetInstance().GetLogger().Execute("Модуль " + GetName() + " включен");

            InitCommands();
        }

        public void InitCommands()
        {
            TeleportCommand Teleport = new TeleportCommand();
            Teleport.Init();
        }

        // Реализация метода DeInit, который выключает модуль
        public void DeInit() { }
    }
}
