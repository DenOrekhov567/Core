using Core.Module.Database;
using Core.Module.Teleport;

namespace Core.Module
{
    public class ModuleManager
    {
        readonly Dictionary<string, object> PoolModules = new() { };

        public ModuleManager()
        {
            Init();
        }
        public void Init()
        {
            PoolModules.Add("Database", new DatabaseModule());
            PoolModules.Add("Teleport", new TeleportModule());
        }

        public object? GetModule(String name) => PoolModules.Values.FirstOrDefault(value => name == ((IModule)value).GetName());
    }
}
