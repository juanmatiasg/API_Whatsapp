using Microsoft.AspNetCore.Mvc;
using Whatsapp.DTOs;
using Whatsapp.Presenters;
using Whatsapp.UseCasesPorts;

namespace Whatsapp.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SendMessageController:ControllerBase
    {
        private readonly ISendMessageInputPort _sendMessageInputPort;
        private readonly ISendMessageOutputPort _sendMessageOutpuPort;

        public SendMessageController(ISendMessageInputPort sendMessageInputPort,ISendMessageOutputPort sendMessageOutpuPort)
        {
            _sendMessageInputPort = sendMessageInputPort;
            _sendMessageOutpuPort = sendMessageOutpuPort;
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage([FromQuery]SendMessageRequestDTO request)
        {
            await _sendMessageInputPort.Handle(request);

            if (((IPresenter<SendMessageResponseDTO>)_sendMessageOutpuPort).Content != null)
            {
                return Ok(((IPresenter<SendMessageResponseDTO>)_sendMessageOutpuPort).Content);
            }
            else
            {
                return BadRequest();
            }

        }


    }
}
