using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhipsImageConverter
{
    //Color3 Class Definition
    public struct Color3
    {
        public readonly int R;
        public readonly int G;
        public readonly int B;
        public readonly int A;
        public readonly int Packed;

        public Color3(int R, int G, int B)
        {
            this.R = R;
            this.G = G;
            this.B = B;
            this.A = 255;
            this.Packed = (255 << 24) | (ClampColor(R) << 16) | (ClampColor(G) << 8) | ClampColor(B);
        }

        public Color3(int R, int G, int B, int A)
        {
            this.R = R;
            this.G = G;
            this.B = B;
            this.A = A; //I only care about full transparency
            this.Packed = (255 << 24) | (ClampColor(R) << 16) | (ClampColor(G) << 8) | ClampColor(B);
        }

        private static int ClampColor(int value)
        {
            int clampedValue = value;

            if (clampedValue > 255)
            {
                clampedValue = 255;
            }
            else if (clampedValue < 0)
            {
                clampedValue = 0;
            }

            return clampedValue;
        }

        //Manhattan distance
        public int Diff(Color3 otherColor)
        {
            return Math.Abs(R - otherColor.R) + Math.Abs(G - otherColor.G) + Math.Abs(B - otherColor.B);
        }

        public Color ToColor()
        {
            return Color.FromArgb(Packed);
        }

        public static Color3 operator -(Color3 color1, Color3 color2)
        {
            //return new Color3(color1.R - color2.R, color1.G - color2.G, color1.B - color2.B);
            return color1 + -1 * color2;
        }

        public static Color3 operator +(Color3 color1, Color3 color2)
        {
            return new Color3(color1.R + color2.R, color1.G + color2.G, color1.B + color2.B, color1.A);
        }

        public static Color3 operator *(Color3 color, float multiplier)
        {
            return new Color3((int)Math.Round(color.R * multiplier), (int)Math.Round(color.G * multiplier), (int)Math.Round(color.B * multiplier), color.A);
        }

        public static Color3 operator *(float multiplier, Color3 color)
        {
            return new Color3((int)Math.Round(color.R * multiplier), (int)Math.Round(color.G * multiplier), (int)Math.Round(color.B * multiplier), color.A);
        }

        public static Color3 operator /(float dividend, Color3 color)
        {
            return new Color3((int)Math.Round(dividend / color.R), (int)Math.Round(dividend / color.G), (int)Math.Round(dividend / color.B), color.A);
        }

        public static Color3 operator /(Color3 color, float dividend)
        {
            return new Color3((int)Math.Round(color.R / dividend), (int)Math.Round(color.G / dividend), (int)Math.Round(color.B / dividend), color.A);
        }
    }
}
