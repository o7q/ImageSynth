using System.Drawing;
using System.Drawing.Drawing2D;

namespace ImageSynth.BitmapTools
{
    public static class Transform
    {
        public static Bitmap RescaleBitmap(Bitmap bitmap, int scale)
        {
            Bitmap rescaledBitmap = new Bitmap(scale, scale);

            using (Graphics g = Graphics.FromImage(rescaledBitmap))
            {
                g.InterpolationMode = InterpolationMode.NearestNeighbor;
                g.DrawImage(bitmap, 0, 0, scale, scale);
            }

            return rescaledBitmap;
        }
    }
}