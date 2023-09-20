// generated from <Windows SDK Path>\shared\d3dkmthk.h
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
