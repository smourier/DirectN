// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12.h(14140,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_RENDER_PASS_BEGINNING_ACCESS__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] __bits;
        public D3D12_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS Clear => InteropRuntime.GetBits<D3D12_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS>(__bits, 0, 256);
    }
}
