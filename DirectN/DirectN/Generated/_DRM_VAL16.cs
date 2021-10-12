// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmsdkidl.h(2086,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DRM_VAL16
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public byte[] val;
    }
}
