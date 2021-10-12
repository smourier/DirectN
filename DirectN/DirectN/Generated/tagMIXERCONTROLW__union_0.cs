// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mmeapi.h(2081,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagMIXERCONTROLW__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public tagMIXERCONTROLW__union_0__struct_0 __field_0 { get => InteropRuntime.Get<tagMIXERCONTROLW__union_0__struct_0>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<tagMIXERCONTROLW__union_0__struct_0>(value, __bits, 0, 64); } }
        public tagMIXERCONTROLW__union_0__struct_1 __field_1 { get => InteropRuntime.Get<tagMIXERCONTROLW__union_0__struct_1>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<tagMIXERCONTROLW__union_0__struct_1>(value, __bits, 0, 64); } }
        public uint[] dwReserved { get => InteropRuntime.GetArray<uint>(__bits, 0, 192); set { if (__bits == null) __bits = new byte[24]; InteropRuntime.SetArray<uint>(value, __bits, 0, 192); } }
    }
}
