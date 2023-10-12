using System;
using System.IO;
using System.Drawing;
using static ImageSynth.BitmapTools.Read;

namespace ImageSynth.Datasets
{
    public static class Compare
    {
        public static Tuple<string, string[], float[]> CompareDrawingToDatasets(Bitmap input, string datasetFolder, int imageWidth)
        {
            string[] datasetFiles = Directory.GetFiles(datasetFolder);

            int imageArea = (int)Math.Pow(imageWidth, 2);

            int errorMinimum = int.MaxValue;
            int errorMinimumSum = 0;
            int[] errorValues = new int[datasetFiles.Length];
            string datasetGuess = "";

            byte[] inputImage = ReadBitmap(input, imageWidth);

            for (int i = 0; i < datasetFiles.Length; i++)
            {
                string[] datasetFile = File.ReadAllText(datasetFiles[i]).Split('@')[1].Split('\n');
                int error = 0;
                for (int j = 0; j < datasetFile.Length; j++)
                {
                    string[] image = datasetFile[j].Split(' ');
                    int[] imageint = new int[imageArea * 3];
                    for (int k = 0; k < imageArea * 3; k++)
                        imageint[k] = int.Parse(image[k]);

                    for (int k = 0; k < imageArea * 3; k += 3)
                        error += (int)Math.Sqrt(Math.Pow(imageint[k] - inputImage[k], 2) + Math.Pow(imageint[k + 1] - inputImage[k + 1], 2) + Math.Pow(imageint[k + 2] - inputImage[k + 2], 2));
                }

                error /= datasetFile.Length;

                if (errorMinimum > error)
                {
                    errorMinimum = error;
                    datasetGuess = datasetFiles[i];
                }

                errorMinimumSum += error;
                errorValues[i] = error;
            }

            float[] matchPercentage = new float[datasetFiles.Length];
            for (int i = 0; i < datasetFiles.Length; i++)
                matchPercentage[i] = 100 - ((errorValues[i] / (float)errorMinimumSum) * 100);

            return Tuple.Create(datasetGuess, datasetFiles, matchPercentage);
        }
    }
}