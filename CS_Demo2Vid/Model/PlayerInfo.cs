using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Demo2Vid.Model
{
    public class PlayerInfo
    {
        public string KillerSteamId { get; set; }
        public string KillerName { get; set; }

        public string DisplayName => $"{KillerName} ({KillerSteamId})";
    }
}
