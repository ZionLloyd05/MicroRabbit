using MicroRabbit.Banking.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MicroRabbit.Banking.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<BankingDbContext>
    {

        BankingDbContext IDesignTimeDbContextFactory<BankingDbContext>.CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            var builder = new DbContextOptionsBuilder<BankingDbContext>();
            var connectionString = configuration.GetConnectionString("BankingDbConnection");

            //builder.UseSqlServer(connectionString);
            builder.UseSqlServer(connectionString);

            return new BankingDbContext(builder.Options);
        }
    }
}
