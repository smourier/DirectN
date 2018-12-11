using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct tagExtendedHeapRestrictions
    {
        public _DDSCAPSEX ddsCapsEx;
        public _DDSCAPSEX ddsCapsExAlt;
    }
}
