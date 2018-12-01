// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite.h(2395,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_LINE_BREAKPOINT
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public byte[] __bits;
        public byte breakConditionBefore => InteropRuntime.GetByteBits(__bits, 0, 2);
        public byte breakConditionAfter => InteropRuntime.GetByteBits(__bits, 2, 2);
        public byte isWhitespace => InteropRuntime.GetByteBits(__bits, 4, 1);
        public byte isSoftHyphen => InteropRuntime.GetByteBits(__bits, 5, 1);
        public byte padding => InteropRuntime.GetByteBits(__bits, 6, 2);
    }
}
