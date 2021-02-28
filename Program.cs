using System;
using CommandLine;

namespace Mandelsharp {
    public class Program {
        public static void Main(string[] args) {
            Parser.Default.ParseArguments<Options>(args).WithParsed<Options>(o => {
                if(o.Size < 32) Exit("Size must be at least 32px.");
                else {
                    // Proccess args
                    Mandelbrot mdb = new Mandelbrot(o.Size, o.Size);

                    if(o.Zoom > 1) mdb.Zoom(o.X, o.Y, o.Zoom);
                    else if(o.CartasianZoom > 1) mdb.ZoomCartesian(o.X, o.Y, o.CartasianZoom);

                    mdb.Generate(o.Output);
                }
            });
        }

        public static void Exit(string errorMessage) {
            ConsoleColor prev = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nError: ");
            Console.ForegroundColor = prev;
            Console.WriteLine(errorMessage);
            Environment.Exit(-1);
        }
    }
}
