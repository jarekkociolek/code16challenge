using System.Diagnostics;
using System.Runtime.InteropServices;
class Program
{
    static void Main(string[] args)
    {
        bool isLinux = RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
        bool isWindows = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
        bool isMacOs = RuntimeInformation.IsOSPlatform(OSPlatform.OSX);
        var tossACoinToMaja = "https://www.siepomaga.pl/skarbonki/code16challenge/koszyk/dodaj";
        if (isWindows)
            Process.Start(new ProcessStartInfo { FileName = tossACoinToMaja, UseShellExecute = true });
        if (isLinux) Process.Start("open", tossACoinToMaja);
        if (isMacOs) Process.Start("open", tossACoinToMaja);
    }
}