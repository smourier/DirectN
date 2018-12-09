// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite.h(2395,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_LINE_BREAKPOINT
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public byte breakConditionBefore { get => InteropRuntime.GetByte(__bits, 0, 2); set => InteropRuntime.SetByte(value, __bits, 0, 2); }
        public byte breakConditionAfter { get => InteropRuntime.GetByte(__bits, 2, 2); set => InteropRuntime.SetByte(value, __bits, 2, 2); }
        public byte isWhitespace { get => InteropRuntime.GetByte(__bits, 4, 1); set => InteropRuntime.SetByte(value, __bits, 4, 1); }
        public byte isSoftHyphen { get => InteropRuntime.GetByte(__bits, 5, 1); set => InteropRuntime.SetByte(value, __bits, 5, 1); }
        public byte padding { get => InteropRuntime.GetByte(__bits, 6, 2); set => InteropRuntime.SetByte(value, __bits, 6, 2); }
    }
}
