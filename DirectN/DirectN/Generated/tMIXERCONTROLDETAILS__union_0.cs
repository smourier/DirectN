// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mmeapi.h(2335,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tMIXERCONTROLDETAILS__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] __bits;
        public IntPtr hwndOwner => InteropRuntime.Get<IntPtr>(__bits, 0, 64);
        public uint cMultipleItems => InteropRuntime.GetUInt32(__bits, 0, 32);
    }
}
