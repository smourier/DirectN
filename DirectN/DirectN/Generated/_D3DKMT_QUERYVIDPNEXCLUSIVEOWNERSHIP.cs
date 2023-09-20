// generated from <Windows SDK Path>\shared\d3dkmthk.h
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
