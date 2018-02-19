using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct D3D11_TEX2D_SRV1
    {
        public int MostDetailedMip;
        public int MipLevels;
        public int PlaneSlice;
    }
}
