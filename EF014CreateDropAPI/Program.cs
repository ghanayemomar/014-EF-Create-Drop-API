using EF014.CreateDropAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace EF014
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                // Database will be created if doiesnt exist.
                await context.Database.EnsureCreatedAsync();
                await Task.Delay(30000);

                // Database will be deleted if it dies exist
                await context.Database.EnsureDeletedAsync();
            }
        }
    }
}

