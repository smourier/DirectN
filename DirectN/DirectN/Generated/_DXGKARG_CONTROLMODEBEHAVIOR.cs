// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(7773,9)
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
