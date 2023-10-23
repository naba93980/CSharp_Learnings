using System;

namespace Composition
{
    internal class Installer
    {
        private Logger _logger;

        public Installer(Logger logger)
        {
            this._logger = logger;
        }

        public void Install()
        {
            _logger.Log("Installing");
        }

    }

    internal class Migrator
    {
        private Logger _logger;
        public Migrator(Logger logger)
        {
            this._logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("We r migrating");
        }
    }
}
