using System;
namespace Composition
{
    public class Installer
    {
        private readonly Logger logger;

        public Installer(Logger logger)
        {
            this.logger = logger;
        }

        public void Install()
        {
            this.logger.Log("we are installing this");
        }
    }
}
