using System.IO;
using System.Drawing;
using static ImageSynth.BitmapTools.Transform;

namespace ImageSynth.Datasets
{
    public static class Vision
    {
        public static Bitmap CalculateDatasetVision(string dataset, int imageWidth)
        {
            int imageArea = imageWidth * imageWidth;

            string datasetFile = File.ReadAllText(dataset).Split('@')[1];
            string[] images = datasetFile.Split('\n');

            int[] averageImage = new int[imageArea * 3];

            for (int i = 0; i < images.Length; i++)
            {
                string[] image = images[i].Split(' ');

                for (int j = 0; j < imageArea * 3; j += 3)
                {
                    averageImage[j] += int.Parse(image[j]);
                    averageImage[j + 1] += int.Parse(image[j + 1]);
                    averageImage[j + 2] += int.Parse(image[j + 2]);
                }
            }

            for (int i = 0; i < imageArea * 3; i++)
                averageImage[i] /= images.Length;

            Bitmap averageBitmap = new Bitmap(imageWidth, imageWidth);

            int x_index = 0;
            int y_index = 0;
            for (int i = 0; i < imageArea * 3; i += 3)
            {
                if (x_index == imageWidth)
                {
                    x_index = 0;
                    y_index++;
                }

                Color pixelColor = Color.FromArgb(255, averageImage[i], averageImage[i + 1], averageImage[i + 2]);
                averageBitmap.SetPixel(x_index, y_index, pixelColor);

                x_index++;
            }

            return RescaleBitmap(averageBitmap, imageWidth);
        }
    }
}