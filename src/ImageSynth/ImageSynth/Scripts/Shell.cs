using System.Diagnostics;

namespace ImageSynth
{
    public static class Shell
    {
        public static void StartProcess(string processName, string arguments, string windowTitle)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.FileName = "cmd.exe";
            processInfo.Arguments = "/c title " + windowTitle + " & " + processName + " " + arguments;
            processInfo.UseShellExecute = false;

            Process process = new Process();
            process.StartInfo = processInfo;
            process.Start();
            process.WaitForExit();
        }
    }
}