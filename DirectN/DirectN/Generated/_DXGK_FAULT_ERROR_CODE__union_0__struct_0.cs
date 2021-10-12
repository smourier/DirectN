// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmdt.h(2255,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXGK_FAULT_ERROR_CODE__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint IsDeviceSpecificCode { get => InteropRuntime.GetUInt32(__bits, 0, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 0, 1); } }
        public _DXGK_GENERAL_ERROR_CODE GeneralErrorCode { get => InteropRuntime.Get<_DXGK_GENERAL_ERROR_CODE>(__bits, 1, 31); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_DXGK_GENERAL_ERROR_CODE>(value, __bits, 1, 31); } }
    }
}
