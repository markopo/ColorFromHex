using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace ScrollableLayout
{
    public class ColorFromHex
    {

        public static Color getColor(double opacity, string hexcolor)
        {
            byte a = (byte)(Convert.ToInt32(255 * opacity));
            byte r = (byte)(Convert.ToUInt32(hexcolor.Substring(1, 2), 16));
            byte g = (byte)(Convert.ToUInt32(hexcolor.Substring(3, 2), 16));
            byte b = (byte)(Convert.ToUInt32(hexcolor.Substring(5, 2), 16));
            return Color.FromArgb(a, r, g, b);
        }


        public static Color Blue()
        {
            return getColor(1.0, "#1BA1E2"); 
        }

        public static Color Red()
        {
            return getColor(1.0, "#D4000D"); 
        }

        public static Color Green()
        {
            return getColor(1.0, "#099451"); 
        }

        public static Color Yellow()
        {
            return getColor(1.0, "#F2E52E"); 
        }

    }
}
