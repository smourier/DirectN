using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct D3D11_TEX2DMS_ARRAY_SRV
    {
        public int FirstArraySlice;
        public int ArraySize;
    }
}
