// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmdt.h(1813,9)
using System;
using System.Runtime.InteropServices;
using LUID = DirectN._LUID;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXGKMDT_OPM_CREATE_VIDEO_OUTPUT_FOR_TARGET_PARAMETERS
    {
        public LUID AdapterLuid;
        public uint TargetId;
        public _DXGKMDT_OPM_VIDEO_OUTPUT_SEMANTICS Vos;
    }
}
