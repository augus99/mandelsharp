using System;

namespace Mandelsharp {
    public struct Complex {
        public double A { get; private set; }
        public double B { get; private set; }
        public double Magnitude => Math.Sqrt((A * A) + (B * B));
        public double UnsqrtMangitude => A * A + B * B;

        public Complex(double a, double b) {
            this.A = a;
            this.B = b;
        }

        public static Complex operator *(Complex left, Complex right) {
            if(right.B == 0) return left * right.A;
            if(left.B == 0) return right * left.A;

            double a = left.A * right.A - left.B * right.B;
            double b = left.A * left.B + right.A * right.B;
            
            return new Complex(a, b);
        }

        public static Complex operator *(Complex left, double right) {
            return new Complex(left.A * right, left.B * right);
        }

        public static Complex operator +(Complex left, Complex right) {
            return new Complex(left.A + right.A, left.B + right.B);
        }

        public static Complex operator -(Complex left, Complex right) {
            return new Complex(left.A - right.A, left.B - right.B);
        }
    }
}