using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whatsapp.DTOs;
using Whatsapp.UseCasesPorts;

namespace Whatsapp.Presenters
{
    public class WhatsappPresenter :ISendMessageOutputPort, IPresenter<SendMessageResponseDTO>
    {
        public SendMessageResponseDTO Content { get; private set; }

        public Task Handle(SendMessageResponseDTO response)
        {
            Content = response;
            return Task.CompletedTask;
        }
    }
}
