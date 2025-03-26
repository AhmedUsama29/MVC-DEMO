namespace MVC_DEMO
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });

            app.MapGet("/ ", async context =>
             {
                 await context.Response.WriteAsync("Hello nada !");
             });

            //app.MapGet("/", async context =>
            //{
            //    await context.Response.WriteAsync("Hello Test !");
            //});

            //app.MapGet("/test", async context =>
            //{
            //    await context.Response.WriteAsync("Hello Test !");
            //});

            //app.MapGet(pattern: "/{name}", async context =>
            //{
            //    await context.Response.WriteAsync("Hello Test !");
            //});

            //app.MapGet(pattern: "/{fixed}/{name}", requestDelegate: async context =>
            //{
            //    var name = context.GetRouteValue("name");
            //    var name2 = context.Request.RouteValues["name"];
            //    await context.Response.WriteAsync($"Hello fixed {name} v1!");
            //});

            //app.MapGet("/test", async context =>
            //{
            //    await context.Response.WriteAsync("Hello Test v2!");
            //});

            //app.MapGet("/Movie/GetMovie", async context =>
            //{
            //    await context.Response.WriteAsync("Hello Get Movie!");
            //});

            //app.MapControllerRoute(
            //name: "movie",
            //pattern: "{controller}/{action}/{id?}"
            //);
            //app.MapControllerRoute(
            //    name: "default",
            //    pattern: "{controller}/{action}/{id:regex(^\\d{{2}}$)?}/{mynameAlpha$)}",
            //    defaults: new { controller = "Home", action = "Index" },
            //    constraints: new { id = @"\d{2}" }
            //);

            
            app.Run();


        }
    }
}
