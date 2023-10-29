using System;
using System.Runtime.InteropServices;
using CLIPFORMAT = System.Int16;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PROPBAG2
    {
        public PROPBAG2_TYPE dwType;
        public VARTYPE vt;
        public CLIPFORMAT cfType;
        public int dwHint;
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pstrName;
        public Guid clsid;
    }
}
