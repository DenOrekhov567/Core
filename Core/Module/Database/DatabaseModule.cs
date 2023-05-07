using Core.Module;

namespace Core.module.Database
{
    public class DatabaseModule: IModule
    {
        public string GetName() => "Database";

        public void Init() { }  

        public void DeInit() { }
    }
}
