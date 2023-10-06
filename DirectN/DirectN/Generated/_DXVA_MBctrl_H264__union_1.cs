// generated from <Windows SDK Path>\um\dxva.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_MBctrl_H264__union_1
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DXVA_MBctrl_H264__union_1__struct_0 __field_0 {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXVA_MBctrl_H264__union_1__struct_0>(__bits, 0, 96);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<_DXVA_MBctrl_H264__union_1__struct_0>(value, __bits, 0, 96); } }
        public _DXVA_MBctrl_H264__union_1__struct_1 __field_1 {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXVA_MBctrl_H264__union_1__struct_1>(__bits, 0, 96);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<_DXVA_MBctrl_H264__union_1__struct_1>(value, __bits, 0, 96); } }
    }
}
