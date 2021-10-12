// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxva2api.h(207,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA2_ExtendedFormat__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint SampleFormat { get => InteropRuntime.GetUInt32(__bits, 0, 8); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 0, 8); } }
        public uint VideoChromaSubsampling { get => InteropRuntime.GetUInt32(__bits, 8, 4); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 8, 4); } }
        public uint NominalRange { get => InteropRuntime.GetUInt32(__bits, 12, 3); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 12, 3); } }
        public uint VideoTransferMatrix { get => InteropRuntime.GetUInt32(__bits, 15, 3); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 15, 3); } }
        public uint VideoLighting { get => InteropRuntime.GetUInt32(__bits, 18, 4); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 18, 4); } }
        public uint VideoPrimaries { get => InteropRuntime.GetUInt32(__bits, 22, 5); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 22, 5); } }
        public uint VideoTransferFunction { get => InteropRuntime.GetUInt32(__bits, 27, 5); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 27, 5); } }
    }
}
