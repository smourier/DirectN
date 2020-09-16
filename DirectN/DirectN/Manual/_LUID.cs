using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct _LUID
    {
        public long luid;
        public override string ToString() => luid.ToString();
    }
}
