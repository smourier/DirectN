// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_SEGMENTDESCRIPTOR5__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public long CpuTranslatedAddress {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetInt64(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.SetInt64(value, __bits, 0, 64); } }
        public _DXGK_CPUHOSTAPERTURE CpuHostAperture {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGK_CPUHOSTAPERTURE>(__bits, 0, 128);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<_DXGK_CPUHOSTAPERTURE>(value, __bits, 0, 128); } }
    }
}
