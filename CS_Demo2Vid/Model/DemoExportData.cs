using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CS_Demo2Vid.Model
{
    public class DemoExportData
    {
        [JsonPropertyName("demoFilePath")]
        public string DemoFilePath { get; set; }

        [JsonPropertyName("name")]
        public string DemoName { get; set; }

        [JsonPropertyName("kills")]
        public List<KillInfo> Kills { get; set; } = new List<KillInfo>();
    }
}
