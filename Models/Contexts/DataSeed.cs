using WebIntroEmpty.Models.Entities;

namespace WebIntroEmpty.Models.Contexts
{
    public static class DataSeed
    {

        internal static IApplicationBuilder Seed(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<DataContext>();

                var list = new[]
                {
                new Country { Id=1,Name = "Azerbaijan", Code = "AZE" },
                new Country { Id=2,Name = "Russia", Code = "RU" },
                new Country { Id = 3, Name = "Turkey", Code = "TR" },
                new Country { Id = 4, Name = "Georgia", Code = "GRE" }



            };


                db.Countries.AddRange(list);

                db.SaveChanges();
            }
            return app;
        }
    }
}
