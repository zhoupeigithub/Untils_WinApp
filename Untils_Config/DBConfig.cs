﻿using System.Configuration;

namespace Untils_Config
{
    public class DBConfig
    {
        public static readonly string ResConnStr = ConfigurationManager.ConnectionStrings["BoZhonConnStr"].ConnectionString;
    }
}
