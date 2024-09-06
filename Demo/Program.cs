namespace Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region configure

            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseRouting();
            app.MapGet("/", () => "Hello World!");

            #region Routing
            app.MapGet("/XX{id:int}", async context =>
           {


               await context.Response.WriteAsync($"Id = {context.Request.RouteValues["id"]}");



           });
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller}/{action}/{id?}"); 
            #endregion


            app.Run();

            #endregion

        }
    }
}
