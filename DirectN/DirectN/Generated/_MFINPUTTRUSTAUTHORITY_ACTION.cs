// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(13005,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MFINPUTTRUSTAUTHORITY_ACTION
    {
        public _MFPOLICYMANAGER_ACTION Action;
        public IntPtr pbTicket;
        public uint cbTicket;
    }
}
