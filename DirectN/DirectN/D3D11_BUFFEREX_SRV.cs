using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct D3D11_BUFFEREX_SRV
    {
        public int FirstElement;
        public int NumElements;
        public D3D11_BUFFEREX_SRV_FLAG Flags;
    }
}
