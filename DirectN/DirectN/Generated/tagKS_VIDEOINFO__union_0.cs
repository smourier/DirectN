// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(4051,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagKS_VIDEOINFO__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public tagKS_RGBQUAD[] bmiColors { get => InteropRuntime.GetArray<tagKS_RGBQUAD>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.SetArray<tagKS_RGBQUAD>(value, __bits, 0, 32); } }
        public uint[] dwBitMasks { get => InteropRuntime.GetArray<uint>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.SetArray<uint>(value, __bits, 0, 96); } }
        public tag_KS_TRUECOLORINFO TrueColorInfo { get => InteropRuntime.Get<tag_KS_TRUECOLORINFO>(__bits, 0, 128); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<tag_KS_TRUECOLORINFO>(value, __bits, 0, 128); } }
    }
}
