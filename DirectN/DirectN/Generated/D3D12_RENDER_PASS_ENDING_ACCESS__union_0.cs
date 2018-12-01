// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12.h(14178,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_RENDER_PASS_ENDING_ACCESS__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 44)]
        public byte[] __bits;
        public D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS Resolve => InteropRuntime.GetBits<D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS>(__bits, 0, 352);
    }
}
