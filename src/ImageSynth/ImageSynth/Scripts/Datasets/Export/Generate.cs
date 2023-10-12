using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using static ImageSynth.BitmapTools.Read;
using static ImageSynth.BitmapTools.Transform;

namespace ImageSynth.Datasets.Export
{
    public static class Generate
    {
        public static void GenerateDataset(string datasetName, string[] images, int imageWidth, Label progressLabel)
        {
            int imageArea = imageWidth * imageWidth;
            if (!File.Exists(datasetName))
                File.WriteAllText(datasetName, "");
            File.AppendAllText(datasetName, imageWidth + "@");

            try
            {
                progressLabel.Invoke((MethodInvoker)delegate
                {
                    progressLabel.Text = "[0/" + images.Length + "  |  0.00%  | 00:00:00]";
                    progressLabel.Refresh();
                });
            }
            catch { }

            double totalMilliseconds = 0;

            Bitmap baseImage = new Bitmap(imageWidth, imageWidth);
            using (Graphics g = Graphics.FromImage(baseImage))
            {
                for (int i = 0; i < images.Length; i++)
                {
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();

                    g.Clear(Color.FromArgb(255, 0, 0, 0));

                    using (Bitmap loadedImage = new Bitmap(Image.FromFile(images[i])))
                        g.DrawImage(loadedImage, new Rectangle(0, 0, imageWidth, imageWidth));

                    Bitmap bitmapImage = RescaleBitmap(baseImage, imageWidth);

                    byte[] image = ReadBitmap(bitmapImage, imageWidth);

                    StringBuilder chunkBuilder = new StringBuilder();
                    for (int j = 0; j < imageArea * 3; j += 3)
                    {
                        chunkBuilder.Append(image[j]).Append(" ").Append(image[j + 1]).Append(" ").Append(image[j + 2]);

                        if (j < imageArea * 3)
                            chunkBuilder.Append(" ");
                    }

                    if (i < images.Length - 1)
                        chunkBuilder.Append("\n");

                    string chunk = chunkBuilder.ToString();

                    File.AppendAllText(datasetName, chunk);

                    stopwatch.Stop();

                    totalMilliseconds += stopwatch.Elapsed.TotalMilliseconds;
                    double averageSeconds = ((totalMilliseconds / 1000) / (i + 1)) * (images.Length - (i + 1));

                    int hours = (int)(averageSeconds / 3600);
                    int minutes = (int)((averageSeconds % 3600) / 60);
                    int seconds = (int)(averageSeconds % 60);
                    string time = $"{hours:D2}:{minutes:D2}:{seconds:D2}";

                    try
                    {
                        progressLabel.Invoke((MethodInvoker)delegate
                        {
                            progressLabel.Text = "[" + (i + 1) + "/" + images.Length + "  |  " + (((i + 1) / (float)images.Length) * 100).ToString("0.00") + "%  |  " + time + "]  :  " + Path.GetFileNameWithoutExtension(images[i]);
                            progressLabel.Refresh();
                        });
                    }
                    catch { }
                }
            }
        }
    }
}