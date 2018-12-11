using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct tagNTExtendedHeapRestrictions
    {
        public _DDSCAPSEX ddsCapsEx;
        public _DDSCAPSEX ddsCapsExAlt;
    }
}
