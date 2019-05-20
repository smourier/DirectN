// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(8297,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_SUBMITTARGETCONTROL
    {
        public uint TargetId;
        public _DXGK_TARGET_CONTROL_TYPE Type;
        public _DXGKARG_SUBMITTARGETCONTROL__union_0 __union_2;
    }
}
