// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mmeapi.h(2107,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagMIXERCONTROLW__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
        public byte[] __bits;
        public tagMIXERCONTROLW__union_0__struct_0 __field_0 => InteropRuntime.Get<tagMIXERCONTROLW__union_0__struct_0>(__bits, 0, 64);
        public tagMIXERCONTROLW__union_0__struct_1 __field_1 => InteropRuntime.Get<tagMIXERCONTROLW__union_0__struct_1>(__bits, 0, 64);
        public uint[] dwReserved => InteropRuntime.GetArray<uint>(__bits, 0, 192);
    }
}
