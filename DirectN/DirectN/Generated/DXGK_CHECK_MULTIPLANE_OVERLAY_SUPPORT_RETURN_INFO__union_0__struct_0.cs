// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(410,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGK_CHECK_MULTIPLANE_OVERLAY_SUPPORT_RETURN_INFO__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint FailingPlane { get => InteropRuntime.GetUInt32(__bits, 0, 4); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 0, 4); } }
        public uint TryAgain { get => InteropRuntime.GetUInt32(__bits, 4, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 4, 1); } }
        public uint Reserved { get => InteropRuntime.GetUInt32(__bits, 5, 27); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 5, 27); } }
    }
}
