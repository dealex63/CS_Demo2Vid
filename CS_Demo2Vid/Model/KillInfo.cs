using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CS_Demo2Vid.Model
{
    public class KillInfo
    {
        [JsonPropertyName("roundNumber")]
        public int RoundNumber { get; set; }

        [JsonPropertyName("tick")]
        public int Tick { get; set; }

        [JsonPropertyName("isHeadshot")]
        public bool IsHeadshot { get; set; }

        [JsonPropertyName("killerSteamId")]
        public string KillerSteamId { get; set; }

        [JsonPropertyName("killerName")]
        public string KillerName { get; set; }
    }
}
