using System.IO;
using System.Linq;

namespace ImageSynth
{
    public static class Files
    {
        public static string[] LoadFiles(string directory, string[] extensions)
        {
            try
            {
                var imageFiles = Directory.GetFiles(directory, "*.*", SearchOption.AllDirectories)
                    .Where(file => extensions.Contains(Path.GetExtension(file).ToLower()))
                    .ToArray();

                return imageFiles;
            }
            catch
            {
                return new string[0]; // return an empty array in case of an error
            }
        }
    }
}