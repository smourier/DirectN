// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva.h(1681,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA_ExtendedFormat
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public uint SampleFormat => InteropRuntime.GetUInt32Bits(__bits, 0, 8);
        public uint VideoChromaSubsampling => InteropRuntime.GetUInt32Bits(__bits, 8, 4);
        public _DXVA_NominalRange NominalRange => InteropRuntime.GetBits<_DXVA_NominalRange>(__bits, 12, 3);
        public _DXVA_VideoTransferMatrix VideoTransferMatrix => InteropRuntime.GetBits<_DXVA_VideoTransferMatrix>(__bits, 15, 3);
        public _DXVA_VideoLighting VideoLighting => InteropRuntime.GetBits<_DXVA_VideoLighting>(__bits, 18, 4);
        public _DXVA_VideoPrimaries VideoPrimaries => InteropRuntime.GetBits<_DXVA_VideoPrimaries>(__bits, 22, 5);
        public _DXVA_VideoTransferFunction VideoTransferFunction => InteropRuntime.GetBits<_DXVA_VideoTransferFunction>(__bits, 27, 5);
    }
}
