﻿using LiteLoader.NET;

using Core.Logger;

[assembly: LibPath("plugins\\CorePlugin\\libs")]

namespace Core
{
    // Атрибут, который помечает класс как точку входа плагина, задающий имя плагина
    [PluginMain(name: "CorePlugin")] 

    public class CorePlugin : IPluginInitializer 
    {
        // Свойство класса, которое хранит метаданные плагина
        public Dictionary<string, string> MetaData => new() 
        {
            {"Something", "..."}, // метаданные плагина
            {"foo", "bar"}
        };

        // Свойство класса, которое хранит версию плагина
        public Version Version => new(2, 2, 5);

        // Свойство класса, которое хранит вступительную информацию о плагине
        public string Introduction => "Core plugin for Liteloader.NET";

        // Реализация свойства интерфейса IPluginInitializer для хранения метаданных
        Dictionary<string, string> IPluginInitializer.MetaData => new();

        // Реализация свойства интерфейса IPluginInitializer для хранения версии
        Version IPluginInitializer.Version => new();

        private CorePlugin instance;

        private CoreLogger logger;

        public CorePlugin GetInstance()
        {
            return instance;
        }

        public void OnInitialize() 
        {
            InitComponents(); // инициализация компонентов плагина
        }

        private void InitComponents()
        {
            instance = this;

            logger = new CoreLogger();
            logger.Execute("Плагин Core был загружен...");
        }

        public CoreLogger GetLogger()
        {
            return logger;
        }
    }
}