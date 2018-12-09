// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mmeapi.h(2118,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagMIXERCONTROLW__union_1
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint cSteps { get => InteropRuntime.GetUInt32(__bits, 0, 32); set => InteropRuntime.SetUInt32(value, __bits, 0, 32); }
        public uint cbCustomData { get => InteropRuntime.GetUInt32(__bits, 0, 32); set => InteropRuntime.SetUInt32(value, __bits, 0, 32); }
        public uint[] dwReserved { get => InteropRuntime.GetArray<uint>(__bits, 0, 192); set => InteropRuntime.SetArray<uint>(value, __bits, 0, 192); }
    }
}
