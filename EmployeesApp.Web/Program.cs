namespace EmployeesApp.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

           // Test by Ivan

            app.Run();
        }
    }
}
