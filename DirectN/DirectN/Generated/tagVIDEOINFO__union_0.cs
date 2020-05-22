// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\amvideo.h(319,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagVIDEOINFO__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public tagRGBQUAD[] bmiColors { get => InteropRuntime.GetArray<tagRGBQUAD>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.SetArray<tagRGBQUAD>(value, __bits, 0, 32); } }
        public uint[] dwBitMasks { get => InteropRuntime.GetArray<uint>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.SetArray<uint>(value, __bits, 0, 96); } }
        public tag_TRUECOLORINFO TrueColorInfo { get => InteropRuntime.Get<tag_TRUECOLORINFO>(__bits, 0, 128); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<tag_TRUECOLORINFO>(value, __bits, 0, 128); } }
    }
}
