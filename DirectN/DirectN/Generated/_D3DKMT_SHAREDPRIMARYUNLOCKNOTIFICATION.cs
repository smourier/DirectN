// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;
using LUID = DirectN._LUID;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_SHAREDPRIMARYUNLOCKNOTIFICATION
    {
        public LUID AdapterLuid;
        public uint VidPnSourceId;
    }
}
