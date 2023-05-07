using Core.Module;
using Core;

namespace Core.Module.Database
{
    public class DatabaseModule : IModule
    {
        // Реализация метода GetName, возвращающего строку с именем модуля
        public string GetName() => "Database";

        // Реализация метода Init, который включает модуль
        public void Init() {
            CorePlugin.GetInstance().GetLogger().Execute("Модуль " + GetName() + " включен");
        }

        // Реализация метода DeInit, который выключает модуль
        public void DeInit() { }
    }
}
