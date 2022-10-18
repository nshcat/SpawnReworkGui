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
    public class BossSupport
    {
        [JsonProperty(PropertyName = "BossEscortType")]
        public string BossEscortType { get; set; }

        [JsonProperty(PropertyName = "BossEscortDifficult")]
        public List<string> BossEscortDifficult { get; set; }

        [JsonProperty(PropertyName = "BossEscortAmount_min")]
        public int BossEscortAmountMin { get; set; }

        [JsonProperty(PropertyName = "BossEscortAmount_max")]
        public int BossEscortAmountMax { get; set; }
    }
}
