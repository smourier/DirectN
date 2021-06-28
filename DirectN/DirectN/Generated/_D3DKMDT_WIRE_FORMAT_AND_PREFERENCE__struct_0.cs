// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmdt.h(595,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMDT_WIRE_FORMAT_AND_PREFERENCE__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DKMDT_MODE_PREFERENCE Preference { get => InteropRuntime.Get<_D3DKMDT_MODE_PREFERENCE>(__bits, 0, 2); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_D3DKMDT_MODE_PREFERENCE>(value, __bits, 0, 2); } }
        public uint Rgb { get => InteropRuntime.GetUInt32(__bits, 2, 6); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 2, 6); } }
        public uint YCbCr444 { get => InteropRuntime.GetUInt32(__bits, 8, 6); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 8, 6); } }
        public uint YCbCr422 { get => InteropRuntime.GetUInt32(__bits, 14, 6); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 14, 6); } }
        public uint YCbCr420 { get => InteropRuntime.GetUInt32(__bits, 20, 6); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 20, 6); } }
        public uint Intensity { get => InteropRuntime.GetUInt32(__bits, 26, 6); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 26, 6); } }
    }
}
