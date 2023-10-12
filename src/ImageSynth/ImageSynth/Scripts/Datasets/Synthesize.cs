using System;
using System.IO;
using System.Drawing;
using System.Threading.Tasks;
using static ImageSynth.BitmapTools.Read;
using static ImageSynth.BitmapTools.Transform;
using System.Threading;
using System.Windows.Forms;

namespace ImageSynth.Datasets
{
    public static class Synthesize
    {
        public static Tuple<int[,], int> InitSynthesizeImage(string dataset, int imageWidth)
        {
            int imageArea = imageWidth * imageWidth;

            string datasetFile = File.ReadAllText(dataset).Split('@')[1];
            string[] images = datasetFile.Split('\n');

            int[,] imageint = new int[images.Length, imageArea * 3];
            for (int i = 0; i < images.Length; i++)
            {
                string[] image = images[i].Split(' ');
                for (int j = 0; j < imageArea * 3; j++)
                    imageint[i, j] = int.Parse(image[j]);
            }

            return Tuple.Create(imageint, images.Length);
        }

        public static void BulkSynthesizeImage(string dataset, int imageWidth, PictureBox progressPictureBox, Label progressLabel)
        {
            var result = InitSynthesizeImage("datasets\\" + dataset + ".dataset", imageWidth);

            // get a list of all input file paths
            string[] inputFiles = Directory.GetFiles("temp\\input");

            int totalTasks = inputFiles.Length;
            int completedProcesses = 0;

            // parallelize the processing
            Parallel.ForEach(inputFiles, (file) =>
            {
                using (Bitmap originalBitmap = new Bitmap(Image.FromFile(file)))
                {
                    using (Bitmap newmap = SynthesizeImage(originalBitmap, result.Item1, imageWidth, result.Item2))
                    {
                        string outputFileName = Path.Combine("temp\\output", Path.GetFileNameWithoutExtension(file) + ".png");
                        newmap.Save(outputFileName);

                        Interlocked.Increment(ref completedProcesses);

                        try
                        {
                            progressPictureBox.Invoke((MethodInvoker)delegate
                            {
                                progressPictureBox.Image = newmap;
                                progressPictureBox.Refresh();
                            });
                        }
                        catch { }

                        try
                        {
                            progressLabel.Invoke((MethodInvoker)delegate
                            {
                                progressLabel.Text = $"[{completedProcesses}/{totalTasks}]";
                                progressLabel.Refresh();
                            });
                        }
                        catch { }
                    }
                }
            });
        }

        public static Bitmap SynthesizeImage(Bitmap inputBitmap, int[,] imageint, int imageWidth, int imageCount)
        {
            int imageArea = imageWidth * imageWidth;

            byte[] inputImage = ReadBitmap(inputBitmap, imageWidth);

            int[] finalImage = new int[imageArea * 3];

            int x_index = 0;
            int y_index = 0;
            for (int i = 0; i < imageArea * 3; i += 3)
            {
                int averagePixel;

                if (x_index == imageWidth)
                {
                    x_index = 0;
                    y_index++;
                }

                int minimum = int.MaxValue;

                Color bestPixel = Color.FromArgb(255, 0, 0, 0);

                for (int j = 0; j < imageCount; j++)
                {
                    averagePixel = (int)Math.Sqrt(0.299 * Math.Pow(imageint[j, i] - inputImage[i], 2) + 0.587 * Math.Pow(imageint[j, i + 1] - inputImage[i + 1], 2) + 0.114 * Math.Pow(imageint[j, i + 2] - inputImage[i + 2], 2));

                    if (minimum > averagePixel)
                    {
                        minimum = averagePixel;
                        bestPixel = Color.FromArgb(255, imageint[j, i], imageint[j, i + 1], imageint[j, i + 2]);
                    }
                }

                finalImage[i] = bestPixel.R;
                finalImage[i + 1] = bestPixel.G;
                finalImage[i + 2] = bestPixel.B;

                x_index++;
            }

            Bitmap synthesizedImage = new Bitmap(imageWidth, imageWidth);

            x_index = 0;
            y_index = 0;

            for (int i = 0; i < imageArea * 3; i += 3)
            {
                if (x_index == imageWidth)
                {
                    x_index = 0;
                    y_index++;
                }

                Color pixelColor = Color.FromArgb(255, finalImage[i], finalImage[i + 1], finalImage[i + 2]);
                synthesizedImage.SetPixel(x_index, y_index, pixelColor);

                x_index++;
            }

            return RescaleBitmap(synthesizedImage, imageWidth);
        }
    }
}