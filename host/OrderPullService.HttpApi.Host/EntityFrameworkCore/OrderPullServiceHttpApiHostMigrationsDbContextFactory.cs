﻿using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace OrderPullService.EntityFrameworkCore
{
    public class OrderPullServiceHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<OrderPullServiceHttpApiHostMigrationsDbContext>
    {
        public OrderPullServiceHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<OrderPullServiceHttpApiHostMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("OrderPullService"));

            return new OrderPullServiceHttpApiHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
