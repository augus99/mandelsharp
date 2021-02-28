using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Mandelsharp {
    public class Image: IDisposable {
        
        public int Width { get; }
        public int Height { get; }

        private readonly Bitmap bitmap;
        private readonly GCHandle pxHandle;
        private readonly int[] pixels;
        private bool disposed;

        public Image(int width, int height) {
            this.Width = width;
            this.Height = height;
            this.pixels = new int[width * height];
            this.pxHandle = GCHandle.Alloc(pixels, GCHandleType.Pinned);
            this.bitmap = new Bitmap(width, height, width * 4, PixelFormat.Format32bppArgb, pxHandle.AddrOfPinnedObject());
        }

        public void SetPixel(int x, int y, Color color) {
            this.pixels[y * Width + x] = color.ToArgb();
        }

        public void SetPixels(Func<int, int, Color> func) {
            for(int x = 0; x < Width; x++)
                for(int y = 0; y < Height; y++)
                    this.pixels[x + Width * y] = func(x, y).ToArgb();
        }

        public void Save(string path) {
            bitmap.Save(path, ImageFormat.Png);
        }

        void IDisposable.Dispose() {
            if(disposed) return;
            disposed = true;
            bitmap.Dispose();
            pxHandle.Free();
        }
    }
}