// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(1600,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_COLORTRANSFORMCAPS__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint Gamma_Rgb256x3x16 { get => InteropRuntime.GetUInt32(__bits, 0, 1); set => InteropRuntime.SetUInt32(value, __bits, 0, 1); }
        public uint Gamma_Dxgi1 { get => InteropRuntime.GetUInt32(__bits, 1, 1); set => InteropRuntime.SetUInt32(value, __bits, 1, 1); }
        public uint Transform_3x4Matrix { get => InteropRuntime.GetUInt32(__bits, 2, 1); set => InteropRuntime.SetUInt32(value, __bits, 2, 1); }
        public uint Transform_3x4Matrix_WideColor { get => InteropRuntime.GetUInt32(__bits, 3, 1); set => InteropRuntime.SetUInt32(value, __bits, 3, 1); }
        public uint Transform_3x4Matrix_HighColor { get => InteropRuntime.GetUInt32(__bits, 4, 1); set => InteropRuntime.SetUInt32(value, __bits, 4, 1); }
        public uint Transform_Matrix_V2 { get => InteropRuntime.GetUInt32(__bits, 5, 1); set => InteropRuntime.SetUInt32(value, __bits, 5, 1); }
        public uint Reserved { get => InteropRuntime.GetUInt32(__bits, 6, 26); set => InteropRuntime.SetUInt32(value, __bits, 6, 26); }
    }
}
