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
    public class RaiderWaveSettings : GenericWaveSettings
    {
        [JsonProperty(PropertyName = "raider_default_role")]
        public string RaiderDefaultRole { get; set; }

        [JsonProperty(PropertyName = "raider_high_role")]
        public bool RaiderHighRole { get; set; }

        [JsonProperty(PropertyName = "raider_high_role_chance")]
        public int RaiderHighRoleChance { get; set; }

        [JsonProperty(PropertyName = "raider_high_role_list")]
        public string RaiderHighRoleList { get; set; }
    }
}
