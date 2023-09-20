// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct _D3DKMT_QUERYREMOTEVIDPNSOURCEFROMGDIDISPLAYNAME
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)] 
        public string DeviceName;
        public uint VidPnSourceId;
    }
}
