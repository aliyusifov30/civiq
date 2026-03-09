using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civiq.Persistence
{
    public static class ServiceRegistration
    {

        public static void RegisterPersistence(this IServiceCollection services, IConfiguration configuration )
        {

            services.AddSingleton<IMongoClient>(sp =>
            {
                var connectionString = configuration.GetConnectionString("MongoDb");
                return new MongoClient(connectionString);
            });

            services.AddSingleton(sp =>
            {
                var client = sp.GetRequiredService<IMongoClient>();
                var databaseName = configuration["MongoDbSettings:DatabaseName"];
                return client.GetDatabase(databaseName);
            });

        }

    }
}
