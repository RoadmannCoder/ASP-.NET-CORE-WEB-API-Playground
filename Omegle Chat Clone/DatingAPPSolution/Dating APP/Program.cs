
using Dating_APP.Data;
using Microsoft.EntityFrameworkCore;

namespace Dating_APP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddDbContext<DataContext>(opt =>
            {
                opt.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));

            });

                
                
            // 

            var app = builder.Build();

            // Configure the HTTP request pipeline.
       


            app.MapControllers();

            app.Run();
        }
    }
}