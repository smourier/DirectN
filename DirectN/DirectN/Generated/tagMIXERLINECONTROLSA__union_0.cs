// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mmeapi.h(2249,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagMIXERLINECONTROLSA__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public uint dwControlID => InteropRuntime.GetUInt32(__bits, 0, 32);
        public uint dwControlType => InteropRuntime.GetUInt32(__bits, 0, 32);
    }
}
