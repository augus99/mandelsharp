namespace Mandelsharp {
    public sealed class Mandelbrot {
        private const int MAXITERS = 0xC8;

        public int Width { get; private set; }
        public int Height { get; private set; }

        public void Generate() {
            // Generate image
        }

        private static bool BelongsToMandelbrotSet(Complex c, out int iter) {
            Complex z = c;
            for(iter = 0; iter < MAXITERS; iter++) {
                z = z * z + c;
                if(z.Magnitude > 2) 
                    return true;
            }
            return false;
        }
    }
}