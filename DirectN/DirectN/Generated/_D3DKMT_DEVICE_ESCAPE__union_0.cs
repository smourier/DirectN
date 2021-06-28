// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(2874,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_DEVICE_ESCAPE__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DKMT_DEVICE_ESCAPE__union_0__struct_0 VidPnFromAllocation { get => InteropRuntime.Get<_D3DKMT_DEVICE_ESCAPE__union_0__struct_0>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.Set<_D3DKMT_DEVICE_ESCAPE__union_0__struct_0>(value, __bits, 0, 64); } }
    }
}
