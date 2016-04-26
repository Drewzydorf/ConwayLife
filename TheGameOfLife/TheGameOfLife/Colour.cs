using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AZielsdorf_Lab02
{
    class Colour
    {
        struct HSL
        {
            public float h;
            public float s;
            public float l;

            public HSL(float h, float s, float l)
            {
                this.h = h;
                this.s = s;
                this.l = l;
            }
        }
        public static Color InverseColour(Color colour)
        {
            HSL hueColour = RGB2HSL(colour.R, colour.B, colour.G);
            float h = hueColour.h;
            float s = hueColour.s;
            float l = hueColour.l;

            h += 180;
            h -= h > 360 ? 360 : 0;

            return HSL2RGB(h, s, l);
            
        }
        public static Color BetweenColour(Color colour1, Color colour2)
        {
            HSL hueColour1 = RGB2HSL(colour1.R, colour1.B, colour1.G);
            HSL hueColour2 = RGB2HSL(colour2.R, colour2.B, colour2.G);
            float h1 = hueColour1.h;
            float s1 = hueColour1.s;
            float l1 = hueColour1.l;
            float h2 = hueColour2.h;
            float s2 = hueColour2.s;
            float l2 = hueColour2.l;
            float h;
            float s;
            float l;

            h = (h1 + h2) / 2;
            h -= h > 360 ? 360 : 0;

            s = (s1 + s2) / 2;
            s -= s > 100 ? 100 : 0;

            l = (l1 + l2) / 2;
            l -= l > 100 ? 100 : 0;

            return HSL2RGB(h, s, l);
        }
        private static float Hue2RGB(float a, float b, float c)
        {
            if (c < 0) c += 1;
            if (c > 1) c -= 1;
            if ((6 * c) < 1) return (a + (b - a) * 6 * c);
            if ((2 * c) < 1) return (b);
            if ((3 * c) < 2) return (a + (b - a) * ((2 / 3) - c) * 6);
            return (a);
        }
        private static Color HSL2RGB(float h, float s, float l)
        {
            float r;
            float g;
            float b;

            float A;
            float B;

            if (s == 0)
            {
                r = l * 255;
                g = l * 255;
                b = l * 255;
            }
            else
            {
                if (l < 50)
                    A = l * (1 + s);
                else
                    A = (l + s) - (s * l);
                B = 2 * l - A;

                r = 255 * Hue2RGB(B, A, h + (1f / 3f));
                g = 255 * Hue2RGB(B, A, h);
                b = 255 * Hue2RGB(B, A, h - (1f / 3f));
            }

            return Color.FromArgb((int)r, (int)g, (int)b);
        }
        private static HSL RGB2HSL(float r, float g, float b)
        {
            r /= 255;
            b /= 255;
            g /= 255;
            byte cMax = (byte)Math.Max(r, Math.Max(g, b));
            byte cMin = (byte)Math.Min(r, Math.Min(g, b));
            int delta = cMax - cMin;
            float h = 0;
            float s = 0;
            float l = 0;

            if (cMax == r)
                h = 60 * (((g - b) / delta) % 6);
            else if (cMax == b)
                h = 60 * (((b - r) / delta) + 2);
            else if (cMax == g)
                h = 60 * (((r - g) / delta) + 4);

            l = (cMax + cMax) / 2;

            if (delta == 0)
                s = 0;
            else
                s = delta / (1 - Math.Abs(2 * l - 1));

            return new HSL(h, s, l);
        }
    }
}
