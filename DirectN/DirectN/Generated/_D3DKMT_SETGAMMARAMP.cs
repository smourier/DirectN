// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(3093,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_SETGAMMARAMP
    {
        public uint hDevice;
        public uint VidPnSourceId;
        public _D3DDDI_GAMMARAMP_TYPE Type;
        public _D3DKMT_SETGAMMARAMP__union_0 __union_3;
        public uint Size;
    }
}
