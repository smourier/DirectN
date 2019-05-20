// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(4584,9)
using System;
using System.Runtime.InteropServices;
using PFND3DDDI_CLOSEADAPTER = System.IntPtr;
using PFND3DDDI_CREATEDEVICE = System.IntPtr;
using PFND3DDDI_GETCAPS = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_ADAPTERFUNCS
    {
        public IntPtr pfnGetCaps;
        public IntPtr pfnCreateDevice;
        public IntPtr pfnCloseAdapter;
    }
}
