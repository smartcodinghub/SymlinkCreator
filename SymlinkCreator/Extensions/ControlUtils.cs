using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace Smartcodinghub.Util
{
    public class ControlUtils
    {
        public static Color ChangeColorBrightness(Color color, float correctionFactor)
        {
            float red = (float)color.R;
            float green = (float)color.G;
            float blue = (float)color.B;

            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }

            return Color.FromArgb(color.A, (int)red, (int)green, (int)blue);
        }

        public static Color GetNonTransparentColorFromParent(Control c)
        {
            Color ParentColor = c.Parent.BackColor;
            Control parent = c.Parent;
            while (ParentColor == Color.Transparent)
            {
                parent = parent.Parent;
                ParentColor = parent.BackColor;
            }

            return ParentColor;
        }
    }
}
