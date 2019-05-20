// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(3132,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_ALLOCATIONINFO__union_1
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DXGK_ALLOCATIONINFOFLAGS Flags { get => InteropRuntime.Get<_DXGK_ALLOCATIONINFOFLAGS>(__bits, 0, 32); set => InteropRuntime.Set<_DXGK_ALLOCATIONINFOFLAGS>(value, __bits, 0, 32); }
        public _DXGK_ALLOCATIONINFOFLAGS_WDDM2_0 FlagsWddm2 { get => InteropRuntime.Get<_DXGK_ALLOCATIONINFOFLAGS_WDDM2_0>(__bits, 0, 32); set => InteropRuntime.Set<_DXGK_ALLOCATIONINFOFLAGS_WDDM2_0>(value, __bits, 0, 32); }
    }
}
