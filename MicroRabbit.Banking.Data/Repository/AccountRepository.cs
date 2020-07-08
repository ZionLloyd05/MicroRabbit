using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankingDbContext ctx;

        public AccountRepository(BankingDbContext ctx)
        {
            this.ctx = ctx;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return this.ctx.Accounts;
        }
    }
}
