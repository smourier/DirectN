// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(2139,9)
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
