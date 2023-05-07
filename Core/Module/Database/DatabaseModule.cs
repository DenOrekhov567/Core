using Core.Module;

namespace Core.module.Database
{
    public class DatabaseModule : IModule
    {
        // Реализация метода GetName, возвращающего строку с именем модуля
        public string GetName() => "Database";

        // Реализация метода Init, который включает модуль
        public void Init() { }

        // Реализация метода DeInit, который выключает модуль
        public void DeInit() { }
    }
}
