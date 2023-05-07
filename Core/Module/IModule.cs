namespace Core.Module 
{
    public interface IModule 
    {
        // Метод инициализации модуля
        void Init();

        // Метод деинициализации модуля
        void DeInit();

        // Метод получения имени модуля
        string GetName(); 
    }
}