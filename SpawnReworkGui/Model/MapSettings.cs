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
    public class MapSettings
    {
        #region Properties
        [JsonProperty(PropertyName = "map_rules")]
        public string MapRules { get; set; }

        [JsonProperty(PropertyName = "show_generated_bots")]
        public string ShowGeneratedBots { get; set; }

        [JsonProperty(PropertyName = "max_spawn_time")]
        public int MaxSpawnTime { get; set; }

        [JsonProperty(PropertyName = "max_spawn_time_limit_warning")]
        public bool MaxSpawnTimeLimitWarning { get; set; }

        [JsonProperty(PropertyName = "max_bot_per_zone")]
        public int MaxBotPerZone { get; set; }

        [JsonProperty(PropertyName = "allow_other_bot_spawn_with_boss")]
        public bool AllowOtherBotSpawnWithBoss { get; set; }

        [JsonProperty(PropertyName = "scav_map_openzones")]
        public string ScavMapOpenZones { get; set; }

        [JsonProperty(PropertyName = "has_boss")]
        public bool HasBoss { get; set; }

        [JsonProperty(PropertyName = "bosses_spawn_location_type")]
        public string BossesSpawnLocationType { get; set; }

        [JsonProperty(PropertyName = "max_boss")]
        public int MaxBoss { get; set; }

        [JsonProperty(PropertyName = "boss_spawn_trying_loop")]
        public int BossSpawnTryingLoop { get; set; }

        [JsonProperty(PropertyName = "allow_same_boss_spawn")]
        public bool AllowSameBossSpawn { get; set; }

        [JsonProperty(PropertyName = "bosses_also_use_scavs_spawn_locations")]
        public bool BossesAlsoUseScavSpawnLocations { get; set; }

        [JsonProperty(PropertyName = "bosses_also_use_raiders_spawn_locations")]
        public bool BossesAlsoUseRaidersSpawnLocations { get; set; }

        [JsonProperty(PropertyName = "cultists_spawn_count_for_max_boss")]
        public bool CultistsSpawnCountForMaxBoss { get; set; }

        [JsonProperty(PropertyName = "cultists_spawn_at_own_locations")]
        public bool CultistsSpawnAtOwnLocations { get; set; }
        #endregion

        [JsonProperty(PropertyName = "wave_settings")]
        public WaveSettings Waves { get; set; }

        [JsonProperty(PropertyName = "boss_settings")]
        public List<BossSetting> BossSettings { get; set; }
    }
}
