// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(4081,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_GETDEVICESTATE
    {
        public uint hDevice;
        public _D3DKMT_DEVICESTATE_TYPE StateType;
        public _D3DKMT_GETDEVICESTATE__union_0 __union_2;
    }
}
