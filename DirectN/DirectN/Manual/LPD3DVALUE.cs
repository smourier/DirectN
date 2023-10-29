using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct LPD3DVALUE
    {
        public D3DVALUE value;
    }
}
