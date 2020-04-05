// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(8038,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_SET_TIMING_PATH_INFO__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3DDDI_COLOR_SPACE_TYPE OutputColorSpace { get => InteropRuntime.Get<D3DDDI_COLOR_SPACE_TYPE>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<D3DDDI_COLOR_SPACE_TYPE>(value, __bits, 0, 32); } }
        public _D3DDDI_OUTPUT_WIRE_COLOR_SPACE_TYPE OutputWireColorSpace { get => InteropRuntime.Get<_D3DDDI_OUTPUT_WIRE_COLOR_SPACE_TYPE>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_D3DDDI_OUTPUT_WIRE_COLOR_SPACE_TYPE>(value, __bits, 0, 32); } }
    }
}
