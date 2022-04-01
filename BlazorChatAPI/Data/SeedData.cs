
using BlazorChatAPI.Unit_Of_Work;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorChatAPI.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BlazorChatDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BlazorChatDbContext>>()))
            {
                if (context.Account.Any())
                {
                    return;   // DB has been seeded
                }

                context.SaveChanges();
            }
        }
    }
}
