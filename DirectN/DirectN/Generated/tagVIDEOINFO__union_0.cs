// generated from <Windows SDK Path>\um\amvideo.h
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagVIDEOINFO__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1036)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public tagRGBQUAD[] bmiColors {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetArray<tagRGBQUAD>(__bits, 0, 8192);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1036]; InteropRuntime.SetArray<tagRGBQUAD>(value, __bits, 0, 8192); } }
        public uint[] dwBitMasks {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetArray<uint>(__bits, 0, 96);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1036]; InteropRuntime.SetArray<uint>(value, __bits, 0, 96); } }
        public tag_TRUECOLORINFO TrueColorInfo {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<tag_TRUECOLORINFO>(__bits, 0, 8288);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1036]; InteropRuntime.Set<tag_TRUECOLORINFO>(value, __bits, 0, 8288); } }
    }
}
