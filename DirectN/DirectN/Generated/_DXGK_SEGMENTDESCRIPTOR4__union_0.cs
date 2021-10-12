// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(2618,5)
using System.Runtime.InteropServices;
using PHYSICAL_ADDRESS = System.Int64;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_SEGMENTDESCRIPTOR4__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public PHYSICAL_ADDRESS CpuTranslatedAddress { get => InteropRuntime.Get<PHYSICAL_ADDRESS>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<PHYSICAL_ADDRESS>(value, __bits, 0, 64); } }
        public _DXGK_CPUHOSTAPERTURE CpuHostAperture { get => InteropRuntime.Get<_DXGK_CPUHOSTAPERTURE>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<_DXGK_CPUHOSTAPERTURE>(value, __bits, 0, 96); } }
    }
}
