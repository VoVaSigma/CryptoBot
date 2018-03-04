using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CryptoBot.Models
{
    public static class AppSettings
    {
        public static string Url { get; set; } = "https://telegrambotapp.azurewebsites.net:443/{0}";

        public static string Name { get; set; } = "toliantest_bot";

        public static string Key { get; set; } = "500648582:AAHDiU1YA688AKBd_XDEHVIblH-eF1k9CsU";
    }
}