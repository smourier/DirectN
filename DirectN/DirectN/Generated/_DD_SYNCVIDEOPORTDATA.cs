// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ddrawint.h(1780,9)
using System;
using System.Runtime.InteropServices;
using PDD_DIRECTDRAW_LOCAL = DirectN._DD_DIRECTDRAW_LOCAL;
using PDD_VIDEOPORT_LOCAL = DirectN._DD_VIDEOPORT_LOCAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_SYNCVIDEOPORTDATA
    {
        public IntPtr lpDD;
        public IntPtr lpVideoPort;
        public uint dwOriginOffset;
        public uint dwHeight;
        public uint dwVBIHeight;
        public uint dwDriverReserved1;
        public uint dwDriverReserved2;
        public uint dwDriverReserved3;
        public HRESULT ddRVal;
    }
}
