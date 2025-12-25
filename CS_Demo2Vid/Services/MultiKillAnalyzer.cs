using CS_Demo2Vid.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Demo2Vid.Services
{
    public class MultiKillAnalyzer
    {
        private const int MultiKillTickWindow = 384;

        public Dictionary<string, (string KillerName, List<(int RoundNumber, int KillCount)>)>
            GetDetailedMultikillInfo(DemoExportData demoData)
        {
            var multikillInfo =
                new Dictionary<string, (string KillerName, List<(int RoundNumber, int KillCount)>)>();

            var killsByRound = demoData.Kills.GroupBy(k => k.RoundNumber);

            foreach (var roundGroup in killsByRound)
            {
                var killsByPlayer = roundGroup
                    .Where(k => !string.IsNullOrEmpty(k.KillerSteamId) && k.KillerSteamId != 0.ToString())
                    .GroupBy(k => k.KillerSteamId);

                foreach (var playerGroup in killsByPlayer)
                {
                    var kills = playerGroup.OrderBy(k => k.Tick).ToList();
                    int count = kills.Count;
                    string killerName = kills[0].KillerName ?? "Unknown";

                    if (count < 2)
                        continue;

                    if (count > 2)
                    {
                        AddMultikill(multikillInfo, playerGroup.Key, killerName, roundGroup.Key, count);
                        continue;
                    }

                    if (count == 2)
                    {
                        var first = kills[0];
                        var second = kills[1];

                        bool isWithinTicks = Math.Abs(second.Tick - first.Tick) <= MultiKillTickWindow;
                        bool areBothHeadshot = first.IsHeadshot && second.IsHeadshot;

                        if (isWithinTicks || areBothHeadshot)
                        {
                            AddMultikill(multikillInfo, playerGroup.Key, killerName, roundGroup.Key, count);
                        }
                    }
                }
            }

            return multikillInfo;
        }

        private void AddMultikill(
            Dictionary<string, (string KillerName, List<(int, int)>)> data,
            string steamId, string name, int round, int kills)
        {
            if (!data.ContainsKey(steamId))
            {
                data[steamId] = (name, new List<(int, int)>());
            }

            data[steamId].Item2.Add((round, kills));
        }
    }

}

