// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(2784,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_PROCESS_VERIFIER_OPTION_DATA
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DKMT_PROCESS_VERIFIER_VIDMM_FLAGS VidMmFlags { get => InteropRuntime.Get<_D3DKMT_PROCESS_VERIFIER_VIDMM_FLAGS>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<_D3DKMT_PROCESS_VERIFIER_VIDMM_FLAGS>(value, __bits, 0, 32); } }
        public _D3DKMT_PROCESS_VERIFIER_VIDMM_RESTRICT_BUDGET VidMmRestrictBudget { get => InteropRuntime.Get<_D3DKMT_PROCESS_VERIFIER_VIDMM_RESTRICT_BUDGET>(__bits, 0, 128); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<_D3DKMT_PROCESS_VERIFIER_VIDMM_RESTRICT_BUDGET>(value, __bits, 0, 128); } }
    }
}
