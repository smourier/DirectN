// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_CREATESTANDARDALLOCATION__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DKMT_STANDARDALLOCATION_EXISTINGHEAP ExistingHeapData { get => InteropRuntime.Get<_D3DKMT_STANDARDALLOCATION_EXISTINGHEAP>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.Set<_D3DKMT_STANDARDALLOCATION_EXISTINGHEAP>(value, __bits, 0, 64); } }
    }
}
