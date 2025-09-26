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
            var openingName = String.Format("{0}_{1}.mp3", animeName, sequenceNumber).ToLower();

            return Path.Combine(path1: SecretValue.GetServerURL(),
                                path2: "openings",
                                path3: openingName);
        }

        public static string GetUrlForAnimeList()
        {
            return Path.Combine(path1: SecretValue.GetServerURL(), path2: "list.txt");
        }
    }
}
