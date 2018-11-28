using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct D3D11_TEX3D_SRV
    {
        public int MostDetailedMip;
        public int MipLevels;
    }
}
