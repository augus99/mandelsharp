using System.Drawing;

namespace Mandelsharp {
    public static class WikipediaColoring {
        private readonly static Color[] colors = new Color[] {
            Color.FromArgb( 66,  30,  15),
            Color.FromArgb( 25,   7,  26),
            Color.FromArgb(  9,   1,  47),
            Color.FromArgb(  4,   4,  73),
            Color.FromArgb(  0,   7, 100),
            Color.FromArgb( 12,  44, 138),
            Color.FromArgb( 24,  82, 177),
            Color.FromArgb( 57, 125, 209),
            Color.FromArgb(134, 181, 229),
            Color.FromArgb(211, 236, 248),
            Color.FromArgb(241, 233, 191),
            Color.FromArgb(248, 201,  95),
            Color.FromArgb(255, 170,   0),
            Color.FromArgb(204, 128,   0),
            Color.FromArgb(153,  87,   0),
            Color.FromArgb(106,  52,   3)
        };

        public static Color Take(int source)
            => colors[source % colors.Length];
    }
}