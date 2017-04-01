using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Scratchpad.CodeGolf
{
  //http://codegolf.stackexchange.com/questions/98968/go-out-and-vote?page=2&tab=active#tab-top
  class IVoted
  {
    public void I ()
    {
      string fileName = "ivoted.bmp";

      var imageWidth = 255;
      var imageHeight = 255;

      var img = new Bitmap(imageWidth, imageHeight, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

      //24pt is 32 pixels high

      //I
      for (int i = 0; i < 9; i++)
      {
        for (int j = 0; j < 2; j++)
        {
          img.SetPixel(i, j, Color.Red);
        }
        
      }

      img.SetPixel(4, 0, Color.Red);


      img.Save(fileName);

    }
  }
}
