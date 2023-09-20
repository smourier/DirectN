// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDICB_SUBMITHISTORYSEQUENCE__union_1
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DDDICB_SUBMITHISTORYSEQUENCE__union_1__struct_0 __field_0 { get => InteropRuntime.Get<_D3DDDICB_SUBMITHISTORYSEQUENCE__union_1__struct_0>(__bits, 0, 128); set { if (__bits == null) __bits = new byte[20]; InteropRuntime.Set<_D3DDDICB_SUBMITHISTORYSEQUENCE__union_1__struct_0>(value, __bits, 0, 128); } }
        public IntPtr pBatchedMarkerData { get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size); set { if (__bits == null) __bits = new byte[20]; InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); } }
    }
}
