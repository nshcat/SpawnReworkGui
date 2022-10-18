using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;


namespace SpawnReworkGui.Model
{
    [JsonObject(MemberSerialization.OptIn)]
    public class PmcType
    {
        [JsonProperty(PropertyName="usec")]
        public string Usec { get; set; }

        [JsonProperty(PropertyName = "bear")]
        public string Bear { get; set; } 
    }
}
