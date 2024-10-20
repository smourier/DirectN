// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_ESCAPE_GPUMMUCAPS
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public byte ReadOnlyMemorySupported {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetByte(__bits, 0, 8);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[256]; InteropRuntime.SetByte(value, __bits, 0, 8); } }
        public byte NoExecuteMemorySupported {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetByte(__bits, 8, 8);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[256]; InteropRuntime.SetByte(value, __bits, 8, 8); } }
        public byte ZeroInPteSupported {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetByte(__bits, 16, 8);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[256]; InteropRuntime.SetByte(value, __bits, 16, 8); } }
        public byte CacheCoherentMemorySupported {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetByte(__bits, 24, 8);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[256]; InteropRuntime.SetByte(value, __bits, 24, 8); } }
        public byte LargePageSupported {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetByte(__bits, 32, 8);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[256]; InteropRuntime.SetByte(value, __bits, 32, 8); } }
        public byte DualPteSupported {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetByte(__bits, 40, 8);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[256]; InteropRuntime.SetByte(value, __bits, 40, 8); } }
        public byte AllowNonAlignedLargePageAddress {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetByte(__bits, 48, 8);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[256]; InteropRuntime.SetByte(value, __bits, 48, 8); } }
        public byte PageTable64KSupported {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetByte(__bits, 56, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[256]; InteropRuntime.SetByte(value, __bits, 56, 1); } }
        public byte Reserved {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetByte(__bits, 57, 7);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[256]; InteropRuntime.SetByte(value, __bits, 57, 7); } }
        public uint VirtualAddressBitCount {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt32(__bits, 64, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[256]; InteropRuntime.SetUInt32(value, __bits, 64, 32); } }
        public uint PageTableLevelCount {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt32(__bits, 96, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[256]; InteropRuntime.SetUInt32(value, __bits, 96, 32); } }
        public _D3DKMT_PAGE_TABLE_LEVEL_DESC[] PageTableLevelDesk {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetArray<_D3DKMT_PAGE_TABLE_LEVEL_DESC>(__bits, 128, 1920);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[256]; InteropRuntime.SetArray<_D3DKMT_PAGE_TABLE_LEVEL_DESC>(value, __bits, 128, 1920); } }
    }
}
