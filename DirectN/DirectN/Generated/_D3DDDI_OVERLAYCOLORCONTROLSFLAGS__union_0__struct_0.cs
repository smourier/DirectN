// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(1433,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_OVERLAYCOLORCONTROLSFLAGS__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint Brightness { get => InteropRuntime.GetUInt32(__bits, 0, 1); set => InteropRuntime.SetUInt32(value, __bits, 0, 1); }
        public uint Contrast { get => InteropRuntime.GetUInt32(__bits, 1, 1); set => InteropRuntime.SetUInt32(value, __bits, 1, 1); }
        public uint Hue { get => InteropRuntime.GetUInt32(__bits, 2, 1); set => InteropRuntime.SetUInt32(value, __bits, 2, 1); }
        public uint Saturation { get => InteropRuntime.GetUInt32(__bits, 3, 1); set => InteropRuntime.SetUInt32(value, __bits, 3, 1); }
        public uint Sharpness { get => InteropRuntime.GetUInt32(__bits, 4, 1); set => InteropRuntime.SetUInt32(value, __bits, 4, 1); }
        public uint Gamma { get => InteropRuntime.GetUInt32(__bits, 5, 1); set => InteropRuntime.SetUInt32(value, __bits, 5, 1); }
        public uint ColorEnable { get => InteropRuntime.GetUInt32(__bits, 6, 1); set => InteropRuntime.SetUInt32(value, __bits, 6, 1); }
        public uint Reserved { get => InteropRuntime.GetUInt32(__bits, 7, 25); set => InteropRuntime.SetUInt32(value, __bits, 7, 25); }
    }
}
