﻿using Newtonsoft.Json;
using static System.Environment;

namespace Tunetoon
{
     public enum Server { Rewritten, Clash }

     public class Config
     {  
        [JsonIgnore]
        public const int LauncherVersion = 63;

        public Server GameServer = Server.Rewritten;

        public bool EncryptAccounts { get; set;} = true;

        public string RewrittenPath { get; set; } = GetFolderPath(SpecialFolder.ProgramFilesX86) + "\\Toontown Rewritten\\";

        public string ClashPath { get; set; } = GetFolderPath(SpecialFolder.LocalApplicationData) + "\\Corporate Clash\\";

        public string ClashDistrict;

        public bool SkipUpdates { get; set; }

        public bool SelectEndGames { get; set; }

        public bool GlobalEndAll { get; set; }

        public string MultiPath { get; set; }

        public bool LaunchMultitoonWhenPlay { get; set; }
     }
}
