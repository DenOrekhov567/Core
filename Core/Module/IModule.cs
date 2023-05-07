namespace Core.Module
{
    public interface IModule
    {
        void Init();
        void DeInit();
        string GetName();
    }
}
