using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace FuleGage
{
    public class Allinfo
    {

        [JsonPropertyName("event")]
        public string Event { get; set; }
        [JsonPropertyName("timestamp")]
      
        public DateTime Timestamp { get; set; }


     

    }
}
