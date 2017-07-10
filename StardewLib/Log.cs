﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StardewModdingAPI;

namespace StardewLib
{
    public class Log
    {
        public static int sequence = 0;

        public static bool enabled = false;

        public Log(bool enabled)
        {
            Log.enabled = enabled;
        }

        public static void INFO(object o)
        {
            if (enabled)
                StardewModdingAPI.Log.Info(o);
        }

        public static void ERROR(object o)
        {
            if (enabled)
                StardewModdingAPI.Log.Error(o);
        }

        public static void DEBUG(object o)
        {
            if (enabled)
                StardewModdingAPI.Log.Debug(o);
        }

        public static void force_INFO(object o)
        {
            StardewModdingAPI.Log.Info(o);
        }

        public static void force_ERROR(object o)
        {
            StardewModdingAPI.Log.Error(o);
        }

        public static void force_DEBUG(object o)
        {
            StardewModdingAPI.Log.Debug(o);
        }
    }
}
