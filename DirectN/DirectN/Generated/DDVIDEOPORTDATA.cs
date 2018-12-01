// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxmini.h(125,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DDVIDEOPORTDATA
    {
        public uint dwVideoPortId;
        public uint dwVPFlags;
        public uint dwOriginOffset;
        public uint dwHeight;
        public uint dwVBIHeight;
        public uint dwDriverReserved1;
        public uint dwDriverReserved2;
        public uint dwDriverReserved3;
    }
}
