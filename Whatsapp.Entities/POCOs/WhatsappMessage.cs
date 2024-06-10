using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whatsapp.Entities.POCOs
{
    public class WhatsappMessage
    {
        public string MessagingProduct { get; set; } = "whatsapp";
        public string To { get; set; }
        public string Type { get; set; } = "template";
        public Template Template { get; set; }

    }
}
