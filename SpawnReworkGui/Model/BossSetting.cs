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
    public class BossSetting
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "chance")]
        public int Chance { get; set; }

        [JsonProperty(PropertyName = "difficulty")]
        public string Difficulty { get; set; }

        [JsonProperty(PropertyName = "wave_total")]
        public int WaveTotal { get; set; }

        [JsonProperty(PropertyName = "wave_spawn_time_for_each_min")]
        public int WaveSpawnTimeForEachMin { get; set; }

        [JsonProperty(PropertyName = "wave_spawn_time_for_each_max")]
        public int WaveSpawnTimeForEachMax { get; set; }

        [JsonProperty(PropertyName = "wave_spawn_all_same_location")]
        public bool WaveSpawnAllSameLocation { get; set; }

        [JsonProperty(PropertyName = "spawn_locations")]
        public Dictionary<string, int> SpawnLocations { get; set; }

        [JsonProperty(PropertyName = "trigger_id")]
        public string TriggerId { get; set; }

        [JsonProperty(PropertyName = "trigger_name")]
        public string TriggerName { get; set; }

        [JsonProperty(PropertyName = "random_time_spawn")]
        public bool RandomTimeSpawn { get; set; }

        [JsonProperty(PropertyName = "supports")]
        public List<BossSupport> Supports { get; set; }
    }
}
