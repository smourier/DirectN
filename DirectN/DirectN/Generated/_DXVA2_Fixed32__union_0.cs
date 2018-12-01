// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva2api.h(458,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA2_Fixed32__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public _DXVA2_Fixed32__union_0__struct_0 __field_0 => InteropRuntime.GetBits<_DXVA2_Fixed32__union_0__struct_0>(__bits, 0, 32);
        public int ll => InteropRuntime.GetInt32Bits(__bits, 0, 32);
    }
}
