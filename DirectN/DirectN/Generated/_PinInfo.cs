// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(1229,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct _PinInfo
    {
        public IntPtr pFilter;
        public _PinDirection dir;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)] 
        public string achName;
    }
}
