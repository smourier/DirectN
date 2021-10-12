// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmdt.h(695,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DISPLAYID_DETAILED_TIMING_TYPE_I__struct_1
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public ushort HorizontalFrontPorch { get => InteropRuntime.GetUInt16(__bits, 0, 15); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 0, 15); } }
        public ushort HorizontalSyncPolarity { get => InteropRuntime.GetUInt16(__bits, 15, 1); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 15, 1); } }
    }
}
