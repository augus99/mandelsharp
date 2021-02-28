using System;

namespace Mandelsharp {
    public sealed class Mapper {
        public Axis VerticalAxis { get; private set; }
        public Axis HorizontalAxis { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Mapper(double vMin, double vMax, double hMin, double hMax, int Width, int Height) {
            this.VerticalAxis = new Axis(vMin, vMax);
            this.HorizontalAxis = new Axis(hMin, hMax);
            this.Height = Height;
            this.Width = Width;
        }

        public void Update(double vMin, double vMax, double hMin, double hMax, int Width, int Height) {
            this.VerticalAxis = new Axis(vMin, vMax);
            this.HorizontalAxis = new Axis(hMin, hMax);
            this.Height = Height;
            this.Width = Width;
        }

        public Vector2 Map(double x, double y) {
            double xMapped = HorizontalAxis.Min + (x / Width) * HorizontalAxis.Delta;
            double yMapped = VerticalAxis.Min + (y / Height) * VerticalAxis.Delta;

            return new Vector2(xMapped, yMapped);
        }

        public Vector2 MapCartasian(double x, double y) {
            Vector2 coord = new Vector2(x, y).AsCartasian(Width, Height);
            return Map(coord.X, coord.Y);
        }

        public void Zoom(double x, double y, double ratio = 1.0d) {
            if (ratio <= 0) throw new ArgumentException(nameof(ratio));

            Vector2 mappedCoord = Map(x, y);

            double halfXDelta = HorizontalAxis.Delta / (2 * ratio);
            double halfYDelta = VerticalAxis.Delta / (2 * ratio);

            Update(mappedCoord.Y - halfYDelta, mappedCoord.Y + halfYDelta,
                   mappedCoord.X - halfXDelta, mappedCoord.X + halfXDelta,
                   Width, Height);
        }

        public void ZoomCartasian(double x, double y, double ratio = 1.0d) {
            Vector2 coord = new Vector2(x, y).AsCartasian(Width, Height);
            Zoom(coord.X, coord.Y, ratio);
        }
    }
}