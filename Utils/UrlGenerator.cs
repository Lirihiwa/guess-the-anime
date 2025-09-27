using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheAnime.Utils
{
    public static class UrlGenerator
    {
        public static string GetUrlForOpening(string animeName, int sequenceNumber)
        {
            var splitName = animeName.Split(' ');
            string animeFormatName = "";

            foreach (var item in splitName)
            {
                animeFormatName += $"{item}_";
            }

            var openingName = (animeFormatName + sequenceNumber + ".mp3").ToLower();

            return $"{SecretValue.GetServerURL().Result}/openings/{openingName}";
        }

        public static async Task<string> GetUrlForAnimeList()
        {
            var serverUrl = await SecretValue.GetServerURL();
            return Path.Combine(path1: serverUrl, path2: "list.txt");
        }
    }
}
