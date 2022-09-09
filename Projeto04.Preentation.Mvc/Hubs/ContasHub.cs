using Microsoft.AspNetCore.SignalR;
using Projeto04.Preentation.Mvc.Models;

namespace Projeto04.Preentation.Mvc.Hubs
{
    public class ContasHub : Hub
    {
        public async Task SendMessage(ContasViewModel viewModel)
        {
            viewModel.Id = Guid.NewGuid();

            await Clients.All.SendAsync("ReceiveMessage", viewModel);        }
    }
}
