namespace SteamConvert;

public class SteamIDUtil
{
    public static string ConvertSteamID64ToSteamID3(string steamID64)
    {
        if (long.TryParse(steamID64, out long steamID))
        {
            const long steamID3Mask = 0xFFFFFFFFL;
            long steamID3 = steamID & steamID3Mask;
            return steamID3.ToString();
        }
        else
        {
            return "Invalid SteamID64";
        }
    }

    public static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Usage: SteamConvert <SteamID>");
            return;
        }

        string steamID64 = args[0];
        string steamID3 = ConvertSteamID64ToSteamID3(steamID64);

        if (steamID3 != null)
        {
            Console.WriteLine("SteamID3: [U:1:" + steamID3 + "]");
        }
        else
        {
            Console.WriteLine("Invalid SteamID");
        }
    }
}
