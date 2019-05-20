// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(611,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_RENDERKM_COMMAND
    {
        public _DXGK_RENDERKM_OPERATION OpCode;
        public uint CommandSize;
        public _DXGK_RENDERKM_COMMAND__union_0 Command;
    }
}
