// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmthk.h(2478,9)
using System;
using System.Runtime.InteropServices;
using LUID = DirectN._LUID;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_SHAREDPRIMARYLOCKNOTIFICATION
    {
        public LUID AdapterLuid;
        public uint VidPnSourceId;
        public _RECTL LockRect;
    }
}
