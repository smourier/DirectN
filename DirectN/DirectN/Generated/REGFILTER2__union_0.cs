// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(5070,36)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct REGFILTER2__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] __bits;
        public REGFILTER2__union_0__struct_0 __field_0 => InteropRuntime.GetBits<REGFILTER2__union_0__struct_0>(__bits, 0, 128);
        public REGFILTER2__union_0__struct_1 __field_1 => InteropRuntime.GetBits<REGFILTER2__union_0__struct_1>(__bits, 0, 128);
    }
}
