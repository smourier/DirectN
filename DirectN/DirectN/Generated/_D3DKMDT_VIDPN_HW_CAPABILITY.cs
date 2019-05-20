// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmdt.h(721,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMDT_VIDPN_HW_CAPABILITY
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint DriverRotation { get => InteropRuntime.GetUInt32(__bits, 0, 1); set => InteropRuntime.SetUInt32(value, __bits, 0, 1); }
        public uint DriverScaling { get => InteropRuntime.GetUInt32(__bits, 1, 1); set => InteropRuntime.SetUInt32(value, __bits, 1, 1); }
        public uint DriverCloning { get => InteropRuntime.GetUInt32(__bits, 2, 1); set => InteropRuntime.SetUInt32(value, __bits, 2, 1); }
        public uint DriverColorConvert { get => InteropRuntime.GetUInt32(__bits, 3, 1); set => InteropRuntime.SetUInt32(value, __bits, 3, 1); }
        public uint DriverLinkedAdapaterOutput { get => InteropRuntime.GetUInt32(__bits, 4, 1); set => InteropRuntime.SetUInt32(value, __bits, 4, 1); }
        public uint DriverRemoteDisplay { get => InteropRuntime.GetUInt32(__bits, 5, 1); set => InteropRuntime.SetUInt32(value, __bits, 5, 1); }
        public uint Reserved { get => InteropRuntime.GetUInt32(__bits, 6, 26); set => InteropRuntime.SetUInt32(value, __bits, 6, 26); }
    }
}
