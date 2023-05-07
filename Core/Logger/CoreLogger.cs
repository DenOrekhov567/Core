using LiteLoader.Logger;

namespace Core.Logger
{
    public class CoreLogger
    {
        private readonly Logger logger = new("CoreLogger");

        public void Execute(string message)
        {
            logger.Info.WriteLine(message);
        }
    }
}
