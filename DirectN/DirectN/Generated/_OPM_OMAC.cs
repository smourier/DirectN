// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ksopmapi.h(73,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _OPM_OMAC
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public byte[] abOMAC;
    }
}
