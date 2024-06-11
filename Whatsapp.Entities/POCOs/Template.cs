using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whatsapp.Entities.POCOs
{
    public class Template
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("language")]

        public Language Language { get; set; }
    }
}
