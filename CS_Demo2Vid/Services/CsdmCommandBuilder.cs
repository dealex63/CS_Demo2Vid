using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CS_Demo2Vid.Services
{
    internal class CsdmCommandBuilder
    {
        public string BuildCommand(string demoPath, string outPath,string steamId, int roundNumber)
        {
            return $"csdm video \"{demoPath}\" " +
                   $"--framerate 60 " +
                   $"--close-game-after-recording " +
                   $"--encoder-software FFmpeg " +
                   $"--recording-system HLAE " +
                   $"--ffmpeg-video-container mp4 " +
                   $"--recording-output video " +
                   $"--start-seconds-before 5 " +
                   $"--end-seconds-after 5 " +
                   $"--concatenate-sequences " +
                   $"--output {outPath} " +
                   $"--mode player " +
                   $"--steamids {steamId} " +
                   $"--event kills " +
                   $"--rounds {roundNumber}";
        }

        public void RunCsdmCommand(string command)
        {
            try
            {
                var processStartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/C {command}",
                    UseShellExecute = false,
                    CreateNoWindow = false
                };

                Process.Start(processStartInfo);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Could not execute command: {ex.Message}");
            }
        }
    }
}
