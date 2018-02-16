using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DXGI_RGB
    {
        public float Red;
        public float Green;
        public float Blue;
    }
}
