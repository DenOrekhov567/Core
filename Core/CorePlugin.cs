using LiteLoader.NET;

using Core.Logger;

[assembly: LibPath("plugins\\CorePlugin\\libs")]

namespace Core
{
    [PluginMain(name: "CorePlugin")]

    public class CorePlugin : IPluginInitializer
    {
        public Dictionary<string, string> MetaData => new()
        {
            {"Something", "..."},
            {"foo", "bar"}
        };

        public Version Version => new(2, 2, 5);

        public string Introduction => "Core plugin for Liteloader.NET";

        Dictionary<string, string> IPluginInitializer.MetaData => new();

        Version IPluginInitializer.Version => new();

        private CorePlugin instance;

        private CoreLogger logger;

        public CorePlugin GetInstance()
        {
            return instance;
        }

        public void OnInitialize()
        {
            InitComponents();
        }

        private void InitComponents()
        {
            instance = this;

            logger = new CoreLogger();
            logger.Execute("Плагин Core был загружен...");
        }
    }
}