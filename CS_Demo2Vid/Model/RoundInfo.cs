using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Demo2Vid.Model
{
    public class RoundInfo
    {
        public int RoundNumber { get; set; }
        public List<KillEvent> Kills { get; set; } = new List<KillEvent>();
    }
}
