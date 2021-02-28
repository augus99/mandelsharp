namespace Mandelsharp {
    public struct Vector2 {
        public float X { get; private set; }
        public float Y { get; private set; }

        public Vector2(float x, float y) {
            this.X = x;
            this.Y = y;
        }

        public Vector2(double x, double y) {
            this.X = (float)x;
            this.Y = (float)y;
        }

        public Vector2 AsCartasian(double width, double height)
            => new Vector2((width / 2) + X, (height / 2) - Y);

        public static implicit operator Complex(Vector2 vector)
            => new Complex(vector.X, vector.Y);
    }
}