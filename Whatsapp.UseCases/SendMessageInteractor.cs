using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whatsapp.DTOs;
using Whatsapp.Entities.POCOs;
using Whatsapp.Http.Service;
using Whatsapp.UseCasesPorts;

namespace Whatsapp.UseCases
{
    public class SendMessageInteractor: ISendMessageInputPort
    {
        private readonly IWhatsappService _whatsappService;
        private readonly ISendMessageOutputPort _outputPort;
        public SendMessageInteractor(IWhatsappService whatsappService, ISendMessageOutputPort outputPort)
        {
            _whatsappService = whatsappService;
            _outputPort = outputPort;
        }



        public async Task Handle(SendMessageRequestDTO request)
        {
            var message = new WhatsappMessage
            {
                To = request.TelephoneNumber,
                Template = new Template
                {
                    Name = "hello_world",
                    Language = new Language
                    {
                        Code = "en_US"
                    }
                }
            };

            var responseDTO = await _whatsappService.SendMessagesAsync(message);

            var response = new SendMessageResponseDTO
            {
                Success = responseDTO.Success,
                Message = responseDTO.Message,
                Data = responseDTO.Data
            };

            await _outputPort.Handle(response);
        }
    }
}
