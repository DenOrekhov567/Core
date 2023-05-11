using Core.Module;
using Core;

namespace Core.Module.Database
{
    public class DatabaseModule : IModule
    {
        public DatabaseModule()
        { 
            Init();
        }
        public string GetName() => "Database";

        public void Init() {
            CorePlugin.GetInstance().GetLogger().Execute("Модуль " + GetName() + " включен");
        }

        public void DeInit() { }
    }
}
