using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whatsapp.Entities.POCOs
{
    public class WhatsappMessage
    {
        [JsonProperty("messaging_product")]
        public object MessagingProduct { get; set; } = "whatsapp";

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; } = "template";

        [JsonProperty("template")]
        public Template Template { get; set; }
        
    }
}
