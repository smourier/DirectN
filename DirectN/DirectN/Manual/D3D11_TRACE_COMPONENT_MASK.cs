using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct D3D11_TRACE_COMPONENT_MASK
    {
        public byte mask;
    }
}
