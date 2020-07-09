using MicroRabbit.Transfer.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MicroRabbit.Transfer.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<TransferDbContext>
    {

        TransferDbContext IDesignTimeDbContextFactory<TransferDbContext>.CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            var builder = new DbContextOptionsBuilder<TransferDbContext>();
            var connectionString = configuration.GetConnectionString("TransferDbConnection");

            builder.UseSqlServer(connectionString);

            return new TransferDbContext(builder.Options);
        }
    }
}
