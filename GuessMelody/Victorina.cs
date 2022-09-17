﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMelody
{
    public static class Victorina
    {
        public static List<string> MusicList = new List<string>();
        public static int GameDuration = 60;
        public static int MusicDuration = 10;
        public static bool RandomStart = false;
        public static string LastFolder = "";
        public static bool AllDirectories = false;

        public static string RegKeyName = "Software\\MyCompanyName\\GuessMelody";

        public static void ReadMusic()
        {
            string[] musicFiles = Directory.GetFiles(
                LastFolder, 
                "*.mp3", 
                AllDirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);

            MusicList.Clear();
            MusicList.AddRange(musicFiles);
        }

        public static void WriteParam()
        {
            RegistryKey registryKey = null;
            try
            {
                registryKey = Registry.CurrentUser.CreateSubKey(RegKeyName);
                if (registryKey == null) return;
                registryKey.SetValue("LastFolder", LastFolder);
                registryKey.SetValue("Random", RandomStart);
                registryKey.SetValue("GameDuration", GameDuration);
                registryKey.SetValue("MusicDuration", MusicDuration);
                registryKey.SetValue("AllDirectories", AllDirectories);
            }
            finally
            {
                if (registryKey != null) registryKey.Close();
            }
        }

        public static void ReadParam()
        {
            RegistryKey registryKey = null;
            try
            {
                registryKey = Registry.CurrentUser.CreateSubKey(RegKeyName);
                if (registryKey != null)
                {
                    LastFolder = (string)registryKey.GetValue("LastFolder");
                    RandomStart = Convert.ToBoolean(registryKey.GetValue("Random", false));
                    GameDuration = (int)registryKey.GetValue("GameDuration");
                    MusicDuration = (int)registryKey.GetValue("MusicDuration");
                    AllDirectories = Convert.ToBoolean(registryKey.GetValue("AllDirectories", false));
                }
            }
            finally
            {
                if (registryKey != null) registryKey.Close();
            }
        }
    }
}
