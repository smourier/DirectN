// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(4102,9)
using System;
using System.Runtime.InteropServices;
using PFND3DKMT_TRIMNOTIFICATIONCALLBACK = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_UNREGISTERTRIMNOTIFICATION
    {
        public IntPtr Handle;
        public IntPtr Callback;
    }
}
