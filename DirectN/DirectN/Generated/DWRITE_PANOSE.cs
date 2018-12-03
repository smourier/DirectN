// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_1.h(752,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_PANOSE
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public byte[] __bits;
        public byte[] values => InteropRuntime.GetArray<byte>(__bits, 0, 80);
        public byte familyKind => InteropRuntime.GetByte(__bits, 0, 8);
        public DWRITE_PANOSE__struct_0 text => InteropRuntime.Get<DWRITE_PANOSE__struct_0>(__bits, 0, 80);
        public DWRITE_PANOSE__struct_1 script => InteropRuntime.Get<DWRITE_PANOSE__struct_1>(__bits, 0, 80);
        public DWRITE_PANOSE__struct_2 decorative => InteropRuntime.Get<DWRITE_PANOSE__struct_2>(__bits, 0, 80);
        public DWRITE_PANOSE__struct_3 symbol => InteropRuntime.Get<DWRITE_PANOSE__struct_3>(__bits, 0, 80);
    }
}
