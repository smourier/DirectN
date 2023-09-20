// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;
using LUID = DirectN._LUID;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct _D3DKMT_OPENADAPTERFROMGDIDISPLAYNAME
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)] 
        public string DeviceName;
        public uint hAdapter;
        public LUID AdapterLuid;
        public uint VidPnSourceId;
    }
}
