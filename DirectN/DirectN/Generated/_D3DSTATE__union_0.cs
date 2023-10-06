// generated from <Windows SDK Path>\um\d3dtypes.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DSTATE__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DTRANSFORMSTATETYPE dtstTransformStateType {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DTRANSFORMSTATETYPE>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_D3DTRANSFORMSTATETYPE>(value, __bits, 0, 32); } }
        public _D3DLIGHTSTATETYPE dlstLightStateType {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DLIGHTSTATETYPE>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_D3DLIGHTSTATETYPE>(value, __bits, 0, 32); } }
        public _D3DRENDERSTATETYPE drstRenderStateType {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DRENDERSTATETYPE>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_D3DRENDERSTATETYPE>(value, __bits, 0, 32); } }
    }
}
