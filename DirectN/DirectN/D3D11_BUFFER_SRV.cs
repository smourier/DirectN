using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Explicit)]
    public struct D3D11_BUFFER_SRV
    {
        [FieldOffset(0)]
        public int FirstElement;
        [FieldOffset(4)]
        public int ElementOffset;
        [FieldOffset(0)]
        public int NumElements;
        [FieldOffset(4)]
        public int ElementWidth;
    }
}
