// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_CONTROLMODEBEHAVIOR
    {
        public _DXGK_MODE_BEHAVIOR_FLAGS Request;
        public _DXGK_MODE_BEHAVIOR_FLAGS Satisfied;
        public _DXGK_MODE_BEHAVIOR_FLAGS NotSatisfied;
    }
}
