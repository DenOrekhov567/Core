using Core.Module;
using Core;
using Core.Module.Teleport.Command;

namespace Core.Module.Teleport
{
    public class TeleportModule : IModule
    {
        // Реализация метода GetName, возвращающего строку с именем модуля
        public string GetName() => "Teleport";

        // Реализация метода Init, который включает модуль
        public void Init()
        {
            CorePlugin.GetInstance().GetLogger().Execute("Модуль " + GetName() + " включен");

            InitCommands();
        }

        public void InitCommands()
        {
            TeleportCommandManager.InitCommands();
        }

        // Реализация метода DeInit, который выключает модуль
        public void DeInit() { }
    }
}
