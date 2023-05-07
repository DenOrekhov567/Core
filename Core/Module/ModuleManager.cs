using Core.Module.Database;

namespace Core.Module
{
    public class ModuleManager
    {

        Dictionary<string, object> poolModules = new Dictionary<string, object>() { };

        public void InitModules()
        {
            poolModules.Add("Database", new DatabaseModule());
        }

        public object? GetModule(String name)
        {
            return poolModules.Values.FirstOrDefault(value => name == ((IModule)value).GetName());
        }
    }
}
