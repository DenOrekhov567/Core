using Core.Module.Database;

namespace Core.module
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
            foreach (object value in poolModules.Values)
            {
                if (((IModule) value).GetName() == name)
                {
                    return value;
                }
            }
            return null;
        }
    }
}
