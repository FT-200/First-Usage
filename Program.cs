namespace KSAtest__delete_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();


            app.MapGet("/", () => "Baha, Do some work, from now on, you're going to Die right now");

            app.Run();
        }



    }
}

namespace Something
{
    public class Class
    {

    }
}