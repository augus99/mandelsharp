using System.Drawing;

namespace Mandelsharp {
    public sealed class Mandelbrot {
        private const int MAXITERS = 0xC8;

        private Image Image { get; }
        private Mapper Mapper { get; }

        public Mandelbrot(int width, int height) {
            this.Image = new Image(width, height);
            this.Mapper = new Mapper(-1.5, 1.5, -2, 1, width, height);
        }

        public void Generate(string output) {
            // Generate image
            this.Image.SetPixels((x, y) => {
                if(BelongsToMandelbrotSet(this.Mapper.Map(x, y), out int iter))
                    return WikipediaColoring.Take(iter);
                return Color.FromArgb(0, 0, 0);
            });

            this.Image.Save(output);
        }

        private static bool BelongsToMandelbrotSet(Complex c, out int iter) {
            Complex z = c;
            for(iter = 0; iter < MAXITERS; iter++) {
                z = z * z + c;
                if(z.UnsqrtMangitude > 4) 
                    return true;
            }
            return false;
        }
    }
}