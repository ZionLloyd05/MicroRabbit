using MicroRabbit.Mvc.Models.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MicroRabbit.Mvc.Services
{
    public class TransferService : ITransferService
    {
        private readonly HttpClient apiClient;

        public TransferService(HttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task Transfer(TransferDto transferDto)
        {
            var url = "https://localhost:5001/api/banking";
            var transferContent = new StringContent(JsonConvert.SerializeObject(transferDto),
                System.Text.Encoding.UTF8, "application/json");
            var response = await this.apiClient.PostAsync(url, transferContent);

            response.EnsureSuccessStatusCode();
        }
    }
}
