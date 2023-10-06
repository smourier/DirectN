// generated from <Windows SDK Path>\shared\d3dukmdt.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_UPDATEGPUVIRTUALADDRESS_OPERATION__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 56)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DDDI_UPDATEGPUVIRTUALADDRESS_OPERATION__union_0__struct_0 Map {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DDDI_UPDATEGPUVIRTUALADDRESS_OPERATION__union_0__struct_0>(__bits, 0, 320);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[56]; InteropRuntime.Set<_D3DDDI_UPDATEGPUVIRTUALADDRESS_OPERATION__union_0__struct_0>(value, __bits, 0, 320); } }
        public _D3DDDI_UPDATEGPUVIRTUALADDRESS_OPERATION__union_0__struct_1 MapProtect {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DDDI_UPDATEGPUVIRTUALADDRESS_OPERATION__union_0__struct_1>(__bits, 0, 448);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[56]; InteropRuntime.Set<_D3DDDI_UPDATEGPUVIRTUALADDRESS_OPERATION__union_0__struct_1>(value, __bits, 0, 448); } }
        public _D3DDDI_UPDATEGPUVIRTUALADDRESS_OPERATION__union_0__struct_2 Unmap {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DDDI_UPDATEGPUVIRTUALADDRESS_OPERATION__union_0__struct_2>(__bits, 0, 192);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[56]; InteropRuntime.Set<_D3DDDI_UPDATEGPUVIRTUALADDRESS_OPERATION__union_0__struct_2>(value, __bits, 0, 192); } }
        public _D3DDDI_UPDATEGPUVIRTUALADDRESS_OPERATION__union_0__struct_3 Copy {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DDDI_UPDATEGPUVIRTUALADDRESS_OPERATION__union_0__struct_3>(__bits, 0, 192);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[56]; InteropRuntime.Set<_D3DDDI_UPDATEGPUVIRTUALADDRESS_OPERATION__union_0__struct_3>(value, __bits, 0, 192); } }
    }
}
