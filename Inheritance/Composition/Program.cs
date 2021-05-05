namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new Logger());
           dbMigrator.Migrate();

            var logger = new Logger();
            var installer = new Installer(logger);

            installer.Install();
        }
    }
}
