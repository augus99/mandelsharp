namespace Mandelsharp {
    public struct Axis {
        public double Min { get; set; }
        public double Max { get; set; }

        public double Delta { get => Max - Min; }

        public Axis(double min, double max) {
            this.Min = min;
            this.Max = max;
        }
    }
}