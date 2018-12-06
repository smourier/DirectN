using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct tagSIZE
    {
        public uint width;
        public uint height;

        public tagSIZE(uint width, uint height)
        {
            this.width = width;
            this.height = height;
        }

        public tagSIZE(int width, int height)
        {
            this.width = (uint)width;
            this.height = (uint)height;
        }

        public override string ToString() => "W=" + width + ",H=" + height;
        public D2D_SIZE_U ToD2D_SIZE_U() => new D2D_SIZE_U { width = width, height = height };
    }
}
