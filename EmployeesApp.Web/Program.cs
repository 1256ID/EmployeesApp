namespace EmployeesApp.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.MapControllers();
            // Test by Ivan
            // test by stanislav
            //Test by Bror

            app.Run();
        }
    }
}
