using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace myHealth.Models
{
    
    public class PinsStorage
    {
        [JsonProperty("0-a14")]
        public string a14 { get; set; }
        [JsonProperty("0-d7")]
        public string d7 { get; set; }
        [JsonProperty("0-d8")]
        public string d8 { get; set; }
        [JsonProperty("0-d3")]
        public string d3 { get; set; }
        [JsonProperty("0-d4")]
        public string d4 { get; set; }
        [JsonProperty("0-d5")]
        public string d5 { get; set; }
        [JsonProperty("0-d6")]
        public string d6 { get; set; }
        [JsonProperty("0-v0")]
        public string v0 { get; set; }
        [JsonProperty("0-d1")]
        public string d1 { get; set; }
        [JsonProperty("0-d2")]
        public string d2 { get; set; }
    }
}
