namespace Core.Logger
{
    public class CoreLogger
    {
        private readonly LiteLoader.Logger.Logger logger = new("CoreLogger");

        public void Execute(string message)
        {
            logger.Info.WriteLine(message);
        }
    }
}