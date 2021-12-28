namespace PersonnelAdministrator.Persistence
{
    public class DbInitializer
    {
        public static void Initialize(PersonellAdministratorDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
