// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mmeapi.h(2093,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagMIXERCONTROLA__union_1
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
        public byte[] __bits;
        public uint cSteps => InteropRuntime.GetUInt32(__bits, 0, 32);
        public uint cbCustomData => InteropRuntime.GetUInt32(__bits, 0, 32);
        public uint[] dwReserved => InteropRuntime.GetArray<uint>(__bits, 0, 192);
    }
}
