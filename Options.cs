using CommandLine;

namespace Mandelsharp {
    public sealed class Options {
        [Option('s', "size", Required = false, HelpText = "Set result image width and height.")] 
        public int Size { get; set; }

        [Option('o', "output", Required = false, HelpText = "Set result image output directory.")] 
        public string Output { get; set; }

        [Option('x', "xcoord", Required = false, HelpText = "Set x coordinate to zoom in.")]
        public int X { get; set; }

        [Option('y', "ycoord", Required = false, HelpText = "Set y coordinate to zoom in.")]
        public int Y { get; set; }

        [Option('z', "zoom", Required = false, HelpText = "Set zoom value.")]
        public int Zoom { get; set; }
    }
}