using System.IO;
using System.Text;
using System.Drawing;
using static ImageSynth.BitmapTools.Read;

namespace ImageSynth.Datasets.Export
{
    public static class Append
    {
        public static void AppendDataset(Bitmap input, string dataset, int imageWidth)
        {
            int imageArea = imageWidth * imageWidth;

            if (!File.Exists(dataset))
                File.WriteAllText(dataset, "");

            string content = File.Exists(dataset) ? File.ReadAllText(dataset) : "";

            byte[] image = ReadBitmap(input, imageWidth);

            StringBuilder chunkBuilder = new StringBuilder();

            for (int i = 0; i < imageArea * 3; i += 3)
                chunkBuilder.Append(image[i]).Append(" ").Append(image[i + 1]).Append(" ").Append(image[i + 2]).Append(" ");

            if (string.IsNullOrEmpty(content))
                content = imageWidth + "@";
            else
                content += "\n";

            File.WriteAllText(dataset, content + chunkBuilder.ToString(0, chunkBuilder.Length - 1));
        }
    }
}