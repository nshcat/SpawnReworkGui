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
    public class PmcWaveSettings : GenericWaveSettings
    {   
        [JsonProperty(PropertyName = "spawn_scav_raider_location_chance")]
        public int SpawnScavRaiderLocationChance { get; set; }
    }
}
