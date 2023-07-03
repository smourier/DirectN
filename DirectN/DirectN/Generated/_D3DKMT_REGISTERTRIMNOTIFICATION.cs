// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmthk.h(5195,9)
using System;
using System.Runtime.InteropServices;
using LUID = DirectN._LUID;
using PFND3DKMT_TRIMNOTIFICATIONCALLBACK = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_REGISTERTRIMNOTIFICATION
    {
        public LUID AdapterLuid;
        public uint hDevice;
        public IntPtr Callback;
        public IntPtr Context;
        public IntPtr Handle;
    }
}
