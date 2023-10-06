// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagKS_VIDEOINFO__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1036)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public tagKS_RGBQUAD[] bmiColors {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetArray<tagKS_RGBQUAD>(__bits, 0, 8192);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1036]; InteropRuntime.SetArray<tagKS_RGBQUAD>(value, __bits, 0, 8192); } }
        public uint[] dwBitMasks {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetArray<uint>(__bits, 0, 96);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1036]; InteropRuntime.SetArray<uint>(value, __bits, 0, 96); } }
        public tag_KS_TRUECOLORINFO TrueColorInfo {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<tag_KS_TRUECOLORINFO>(__bits, 0, 8288);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1036]; InteropRuntime.Set<tag_KS_TRUECOLORINFO>(value, __bits, 0, 8288); } }
    }
}
