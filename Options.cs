using CommandLine;

namespace Mandelsharp {
    public sealed class Options {
        [Option('s', "size", Required = false, HelpText = "Set result image width and height.")] 
        public int Size { get; set; } = 512;

        [Option('o', "output", Required = false, HelpText = "Set result image output directory.")] 
        public string Output { get; set; } = "./mandelbrot.png";

        [Option('x', "xcoord", Required = false, HelpText = "Set x coordinate to zoom in.")]
        public int X { get; set; } = -1;

        [Option('y', "ycoord", Required = false, HelpText = "Set y coordinate to zoom in.")]
        public int Y { get; set; } = -1;

        [Option('z', "zoom", Required = false, HelpText = "Set zoom value.")]
        public int Zoom { get; set; } = -1;

        [Option('c', "czoom", Required = false, HelpText = "Set cartasian zoom value.")]
        public int CartasianZoom { get; set; } = -1;
    }
}