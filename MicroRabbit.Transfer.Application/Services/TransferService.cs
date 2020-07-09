using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using MicroRabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository TransferRepository;
        private readonly IEventBus bus;

        public TransferService(ITransferRepository TransferRepository, IEventBus bus)
        {
            this.TransferRepository = TransferRepository;
            this.bus = bus;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return this.TransferRepository.GetTransferLogs();
        }

    }
}
