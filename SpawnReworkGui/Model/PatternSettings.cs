using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace SpawnReworkGui.Model
{
    [JsonObject(MemberSerialization.OptIn)]
    public class PatternSettings
    {
        [JsonProperty(PropertyName = "spawns")]
        public SpawnSettings Spawns { get; set; }
    }
}
