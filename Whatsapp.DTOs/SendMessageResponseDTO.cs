using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whatsapp.Entities.POCOs;

namespace Whatsapp.DTOs
{
    public class SendMessageResponseDTO : IResponse<WhatsappMessage>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public WhatsappMessage Data { get; set; }
    }
}
