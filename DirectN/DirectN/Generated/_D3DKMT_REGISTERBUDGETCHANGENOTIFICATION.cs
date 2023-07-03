// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmthk.h(5222,9)
using System;
using System.Runtime.InteropServices;
using PFND3DKMT_BUDGETCHANGENOTIFICATIONCALLBACK = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_REGISTERBUDGETCHANGENOTIFICATION
    {
        public uint hDevice;
        public IntPtr Callback;
        public IntPtr Context;
        public IntPtr Handle;
    }
}
