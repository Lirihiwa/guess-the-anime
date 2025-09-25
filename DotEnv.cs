using System.Threading.Tasks;

namespace GuessTheAnime
{
    static class DotEnv
    {
        private static string pathToEnvFile = "config.env";

        private static async Task<string?> GetVariableAsync(string name)
        {
            try
            {
                using var stream = await FileSystem.OpenAppPackageFileAsync(pathToEnvFile);
                using var reader = new StreamReader(stream);

                string? line;

                while ((line = await reader.ReadLineAsync()) != null)
                {
                    var parts = line.Split(separator: '=',
                                           options: StringSplitOptions.RemoveEmptyEntries);

                    if (parts.Length == 2 && parts[0] == "SERVER_URL") return parts[1];
                }

                return null;
            }
            catch
            {
                return null;
            }
        }

        public static string GetFileServerURL()
        {
            return GetVariableAsync(name: "SERVER_URL").Result ?? "";
        }
    }
}
