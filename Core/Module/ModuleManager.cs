using Core.Module.Database;
using Core.Module.Teleport;

namespace Core.Module
{
    public class ModuleManager
    {

        Dictionary<string, object> poolModules = new() { };

        public void InitModules()
        {
            DatabaseModule databaseModule = new DatabaseModule();
            poolModules.Add("Database", new DatabaseModule());
            databaseModule.Init();

            TeleportModule teleportModule = new TeleportModule();
            poolModules.Add("Teleport", new TeleportModule());
            teleportModule.Init();
        }

        public object? GetModule(String name) => poolModules.Values.FirstOrDefault(value => name == ((IModule)value).GetName());
    }
}
