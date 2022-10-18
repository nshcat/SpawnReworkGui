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
    public class GenericWaveSettings
    {
        [JsonProperty(PropertyName="wave_total")]
        public int WaveTotal { get; set; }

        [JsonProperty(PropertyName = "slot_min")]
        public int SlotMin { get; set; }

        [JsonProperty(PropertyName = "slot_max")]
        public int SlotMax { get; set; }

        [JsonProperty(PropertyName = "insta_spawn_waves", DefaultValueHandling =DefaultValueHandling.Populate)]
        public int InstaSpawnWaves { get; set; }

        [JsonProperty(PropertyName = "spawn_time_delay_after_insta_wave")]
        public int SpawnTimeDelayAfterInstaWave { get; set; }

        [JsonProperty(PropertyName = "spawn_time_delay_for_each_min")]
        public int SpawnTimeDelayForEachMin { get; set; }

        [JsonProperty(PropertyName = "spawn_time_delay_for_each_max")]
        public int SpawnTimeDelayForEachMax { get; set; }

        [JsonProperty(PropertyName = "spawn_time_delay_accumulate_for_each_zone")]
        public bool SpawnTimeDelayAccumulateForEachZone { get; set; }

        [JsonProperty(PropertyName = "spawn_location_type")]
        public string SpawnLocationType { get; set; }

        [JsonProperty(PropertyName = "difficulty")]
        public Dictionary<string, int> Difficulty { get; set; }

        [JsonProperty(PropertyName = "spawn_locations")]
        public Dictionary<string, int> SpawnLocations { get; set; }
    }
}
