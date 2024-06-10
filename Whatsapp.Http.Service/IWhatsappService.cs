using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whatsapp.DTOs;
using Whatsapp.Entities.POCOs;

namespace Whatsapp.Http.Service
{
    public interface IWhatsappService
    {
        Task<SendMessageResponseDTO> SendMessagesAsync(WhatsappMessage message);
    }
}
