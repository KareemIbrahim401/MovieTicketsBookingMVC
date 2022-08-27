using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MovieTicketsBooking.Models;
using System.Collections.Generic;
using System.Linq;

namespace MovieTicketsBooking.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                if (!context.Cinemas.Any())
                {

                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema1",
                            Logo = "",
                            Description = "",

                        },
                    });
                    context.SaveChanges();

                }
                if (!context.Actors.Any())
                {

                }
                if (!context.Producers.Any())
                {

                }
                if (!context.Movies.Any())
                {

                }
                if (!context.Actors_Movies.Any())
                {

                }
            }
        }
    }
}
