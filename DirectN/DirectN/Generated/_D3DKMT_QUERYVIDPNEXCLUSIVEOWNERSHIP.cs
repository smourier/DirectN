// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmthk.h(5235,9)
using System;
using System.Runtime.InteropServices;
using LUID = DirectN._LUID;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYVIDPNEXCLUSIVEOWNERSHIP
    {
        public IntPtr hProcess;
        public IntPtr hWindow;
        public uint VidPnSourceId;
        public LUID AdapterLuid;
        public _D3DKMT_VIDPNSOURCEOWNER_TYPE OwnerType;
    }
}
