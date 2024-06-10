using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whatsapp.DTOs;

namespace Whatsapp.UseCasesPorts
{
    public interface ISendMessageOutputPort
    {
        Task Handle(SendMessageResponseDTO response);
    }
}
