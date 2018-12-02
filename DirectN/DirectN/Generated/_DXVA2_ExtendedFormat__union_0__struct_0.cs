// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva2api.h(199,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA2_ExtendedFormat__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public uint SampleFormat => InteropRuntime.GetUInt32(__bits, 0, 8);
        public uint VideoChromaSubsampling => InteropRuntime.GetUInt32(__bits, 8, 4);
        public uint NominalRange => InteropRuntime.GetUInt32(__bits, 12, 3);
        public uint VideoTransferMatrix => InteropRuntime.GetUInt32(__bits, 15, 3);
        public uint VideoLighting => InteropRuntime.GetUInt32(__bits, 18, 4);
        public uint VideoPrimaries => InteropRuntime.GetUInt32(__bits, 22, 5);
        public uint VideoTransferFunction => InteropRuntime.GetUInt32(__bits, 27, 5);
    }
}
