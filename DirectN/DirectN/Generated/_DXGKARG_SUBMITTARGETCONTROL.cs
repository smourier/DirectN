// generated from <Windows SDK Path>\shared\d3dkmddi.h
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
