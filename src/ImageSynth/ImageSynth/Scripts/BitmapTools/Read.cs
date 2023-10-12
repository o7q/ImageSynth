using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ImageSynth.BitmapTools
{
    public static class Read
    {
        public static byte[] ReadBitmap(Bitmap bitmap, int imageWidth)
        {
            int imageArea = imageWidth * imageWidth;

            BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, bitmap.PixelFormat);
            int bytesPerPixel = Image.GetPixelFormatSize(bitmap.PixelFormat) / 8;
            int stride = bitmapData.Stride;

            byte[] pixelData = new byte[bitmapData.Stride * bitmap.Height];
            Marshal.Copy(bitmapData.Scan0, pixelData, 0, pixelData.Length);

            byte[] outputImage = new byte[imageArea * 3];

            int x_index = 0;
            int y_index = 0;
            for (int i = 0; i < imageArea * 3; i += 3)
            {
                if (x_index == imageWidth)
                {
                    x_index = 0;
                    y_index++;
                }

                int pixelOffset = y_index * stride + x_index * bytesPerPixel;
                outputImage[i + 2] = pixelData[pixelOffset];
                outputImage[i + 1] = pixelData[pixelOffset + 1];
                outputImage[i] = pixelData[pixelOffset + 2];

                // Use r, g, and b for further processing
                x_index++;
            }

            bitmap.UnlockBits(bitmapData);

            return outputImage;
        }
    }
}