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
    public class WaveSettings
    {
        [JsonProperty(PropertyName = "scav_waves")]
        public GenericWaveSettings ScavWaves { get; set; }

        [JsonProperty(PropertyName = "sniper_waves")]
        public GenericWaveSettings SniperWaves { get; set; }

        [JsonProperty(PropertyName = "raider_waves")]
        public RaiderWaveSettings RaiderWaves { get; set; }

        [JsonProperty(PropertyName = "pmc_waves")]
        public PmcWaveSettings PMCWaves { get; set; }
    }
}
