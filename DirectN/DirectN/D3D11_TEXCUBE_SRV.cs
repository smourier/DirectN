using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct D3D11_TEXCUBE_SRV
    {
        public int MostDetailedMip;
        public int MipLevels;
    }
}
