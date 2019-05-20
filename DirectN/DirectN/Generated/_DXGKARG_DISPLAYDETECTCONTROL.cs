// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(8414,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_DISPLAYDETECTCONTROL
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint TargetId { get => InteropRuntime.GetUInt32(__bits, 0, 24); set => InteropRuntime.SetUInt32(value, __bits, 0, 24); }
        public _DXGK_DISPLAYDETECTCONTROLTYPE Type { get => InteropRuntime.Get<_DXGK_DISPLAYDETECTCONTROLTYPE>(__bits, 24, 4); set => InteropRuntime.Set<_DXGK_DISPLAYDETECTCONTROLTYPE>(value, __bits, 24, 4); }
        public uint NonDestructiveOnly { get => InteropRuntime.GetUInt32(__bits, 28, 1); set => InteropRuntime.SetUInt32(value, __bits, 28, 1); }
        public uint Reserved { get => InteropRuntime.GetUInt32(__bits, 29, 3); set => InteropRuntime.SetUInt32(value, __bits, 29, 3); }
    }
}
