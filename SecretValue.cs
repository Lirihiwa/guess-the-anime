using System.Threading.Tasks;

namespace GuessTheAnime
{
    static class SecretValue
    {
        private static string pathToEnvFile = "config.env";

        private static async Task<string?> GetVariableAsync(string name)
        {
            try
            {
                using var stream = await FileSystem.OpenAppPackageFileAsync(pathToEnvFile);
                using var reader = new StreamReader(stream);

                string? line = await reader.ReadLineAsync();

                while (line != null)
                {
                    var parts = line.Split('=', 2);

                    if (parts.Length == 2 && parts[0] == name)
                        return parts[1];
                }

                return null;
            }
            catch
            {
                return null;
            }
        }

        public static async Task<string> GetServerURL()
        {
            var url = await GetVariableAsync(name: "SERVER_URL");
            return  url ?? "";
        }
    }
}
