using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Whatsapp.DTOs;
using Whatsapp.Entities.POCOs;

namespace Whatsapp.Http.Service
{
    public class WhatsappService:BaseService<SendMessageResponseDTO> , IWhatsappService
    {
        private const string TOKEN = "EAAMRfp1IoEQBOw0wV1IjuiBtoaQUarj0yMKHiq7TT8ZAbHRQNA1T2vzWRl4lEuIsKgXme0CigZCKIZAcn49Nh2DFLE7VH4ZB2LmpJ2wvFpCZAgmKdHRiQfhCostaM5sAz0rBVWt2mSK20JKWICHd48fcZAs5JZAviwp6l944yKkbsKOyIXpxZCLIg9GVYuiw74rks9qWPGuj0ZAfrXMlt";
        private const string ID_TELEFONO = "355116541012830";
        private readonly string URL = $"https://graph.facebook.com/v19.0/{ID_TELEFONO}/messages";


        public WhatsappService(HttpClient httpClient):base(httpClient) { }

        public async Task<SendMessageResponseDTO> SendMessagesAsync(WhatsappMessage message)
        {
            var payload = new
            {
                messaging_product = message.MessagingProduct,
                to = message.To,
                type = message.Type,
                template = new
                {
                    name = message.Template.Name,
                    language = new
                    {
                        code = message.Template.Language.Code
                    }
                }
            };

            var jsonMessage = JsonConvert.SerializeObject(payload);
            var requestContent = new StringContent(jsonMessage, Encoding.UTF8, "application/json");

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", TOKEN);

            // Log the payload for debugging
            Console.WriteLine("Sending payload: " + jsonMessage);

            var response = await _httpClient.PostAsync(URL, requestContent);

            var result = new SendMessageResponseDTO();

            if (response.IsSuccessStatusCode)
            {
                result.Success = true;
                result.Message = "Message sent successfully.";
                result.Data = message;
            }
            else
            {
                var responseBody = await response.Content.ReadAsStringAsync();
                result.Success = false;
                result.Message = $"Error sending message: {response.StatusCode} {responseBody}";
                result.Data = message;
            }

            return result;
        }



    }
}
