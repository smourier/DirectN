// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(2039,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_DRIVERCAPS__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DXGK_GAMMARAMPCAPS GammaRampCaps { get => InteropRuntime.Get<_DXGK_GAMMARAMPCAPS>(__bits, 0, 32); set => InteropRuntime.Set<_DXGK_GAMMARAMPCAPS>(value, __bits, 0, 32); }
        public _DXGK_COLORTRANSFORMCAPS ColorTransformCaps { get => InteropRuntime.Get<_DXGK_COLORTRANSFORMCAPS>(__bits, 0, 32); set => InteropRuntime.Set<_DXGK_COLORTRANSFORMCAPS>(value, __bits, 0, 32); }
    }
}
