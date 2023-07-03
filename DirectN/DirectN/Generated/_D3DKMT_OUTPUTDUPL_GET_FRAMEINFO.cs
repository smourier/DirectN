// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmthk.h(4717,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_OUTPUTDUPL_GET_FRAMEINFO
    {
        public uint hAdapter;
        public uint VidPnSourceId;
        public _D3DKMT_OUTPUTDUPL_FRAMEINFO FrameInfo;
    }
}
