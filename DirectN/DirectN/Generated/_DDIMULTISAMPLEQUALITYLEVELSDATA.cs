// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(2269,13)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDIMULTISAMPLEQUALITYLEVELSDATA
    {
        public _D3DDDIFORMAT Format;
        public bool Flip;
        public _D3DDDIMULTISAMPLE_TYPE MsType;
        public uint QualityLevels;
    }
}
