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
    public class SpawnSettings
    {
        [JsonProperty(PropertyName = "pmc_usec_chance")]
        public int PmcUsecChance { get; set; }

        [JsonProperty(PropertyName = "chanceSameSideIsHostilePercent")]
        public int ChanceSameSideIsHostilePercent { get; set; }

        [JsonProperty(PropertyName = "showTypeInNickname")]
        public bool ShowTypeInNickname { get; set; }

        [JsonProperty(PropertyName = "pmc_type")]
        public Dictionary<string, PmcType> PmcTypes { get; set; }

        [JsonProperty(PropertyName = "max_alive_bots")]
        public Dictionary<string, int> MaxAliveBots { get; set; }

        [JsonProperty(PropertyName = "bigmap")]
        public MapSettings CustomsSettings { get; set; }

        [JsonProperty(PropertyName = "shoreline")]
        public MapSettings ShorelineSettings { get; set; }

        [JsonProperty(PropertyName = "interchange")]
        public MapSettings InterchangeSettings { get; set; }

        [JsonProperty(PropertyName = "rezervbase")]
        public MapSettings ReserveSettings { get; set; }

        [JsonProperty(PropertyName = "factory4_day")]
        public MapSettings FactoryDaySettings { get; set; }

        [JsonProperty(PropertyName = "factory4_night")]
        public MapSettings FactoryNightSettings { get; set; }

        [JsonProperty(PropertyName = "laboratory")]
        public MapSettings LabsSettings { get; set; }

        [JsonProperty(PropertyName = "woods")]
        public MapSettings WoodsSettings { get; set; }

        [JsonProperty(PropertyName = "lighthouse")]
        public MapSettings LighthouseSettings { get; set; }
    }
}
