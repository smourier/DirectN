using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_FACTORY_OPTIONS
    {
        public D2D1_DEBUG_LEVEL debugLevel;
    }
}
