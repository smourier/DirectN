// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_ADAPTER_VERIFIER_OPTION_DATA
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DKMT_ADAPTER_VERIFIER_VIDMM_FLAGS VidMmFlags { get => InteropRuntime.Get<_D3DKMT_ADAPTER_VERIFIER_VIDMM_FLAGS>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<_D3DKMT_ADAPTER_VERIFIER_VIDMM_FLAGS>(value, __bits, 0, 32); } }
        public _D3DKMT_ADAPTER_VERIFIER_VIDMM_TRIM_INTERVAL VidMmTrimInterval { get => InteropRuntime.Get<_D3DKMT_ADAPTER_VERIFIER_VIDMM_TRIM_INTERVAL>(__bits, 0, 192); set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<_D3DKMT_ADAPTER_VERIFIER_VIDMM_TRIM_INTERVAL>(value, __bits, 0, 192); } }
    }
}
