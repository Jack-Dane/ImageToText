using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageToText
{
    public static class BitmapExtension
    {
        public static List<List<int>> GetBrightnessByN(this Bitmap bitmap, int greyScaleLength, int xScale, int yScale)
        {
            List<List<int>> pixelColours = new List<List<int>>();
            int bitmapHeight = bitmap.Height;
            int bitmapWidth = bitmap.Width;

            int xPixel = xScale;
            int yPixel = yScale;

            for (int y = 0; y < bitmapHeight; y+=yPixel)
            {
                List<int> tempList = new List<int>();
                for (int x = 0; x < bitmapWidth; x+=xPixel)
                {
                    float average = 0;
                    int yMax = (yPixel + y) >= bitmapHeight ? ((bitmapHeight - 1) % yPixel) : yPixel;
                    int count = 0;
                    for (int y1 = 0; y1 < yMax; y1++)
                    {
                        int xMax = (xPixel + x) >= bitmapWidth ? ((bitmapWidth - 1) % xPixel) : xPixel;
                        for (int x1 = 0; x1 < xMax; x1++)
                        {
                            count++;
                            average += bitmap.GetPixel(x + x1, y + y1).GetBrightness();
                        }
                    }
                    if (count > 0)
                    {
                        tempList.Add((int)Math.Round(average / count * greyScaleLength));
                    }
                }
                pixelColours.Add(tempList);
            }
            return pixelColours;
        }
    }
}
