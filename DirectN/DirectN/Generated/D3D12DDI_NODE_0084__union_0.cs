// generated from <Windows SDK Path>\um\d3d12umddi.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_NODE_0084__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D12DDI_SHADER_NODE_0084 Shader {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12DDI_SHADER_NODE_0084>(__bits, 0, 192);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<D3D12DDI_SHADER_NODE_0084>(value, __bits, 0, 192); } }
    }
}
