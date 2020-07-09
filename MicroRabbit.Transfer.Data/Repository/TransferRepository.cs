using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private readonly TransferDbContext ctx;

        public TransferRepository(TransferDbContext ctx)
        {
            this.ctx = ctx;
        }

        public void Add(TransferLog transferLog)
        {
            this.ctx.TransferLogs.Add(transferLog);
            this.ctx.SaveChanges();
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return this.ctx.TransferLogs;
        }
    }
}
