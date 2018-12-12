// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva.h(1681,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA_ExtendedFormat
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint SampleFormat { get => InteropRuntime.GetUInt32(__bits, 0, 8); set => InteropRuntime.SetUInt32(value, __bits, 0, 8); }
        public uint VideoChromaSubsampling { get => InteropRuntime.GetUInt32(__bits, 8, 4); set => InteropRuntime.SetUInt32(value, __bits, 8, 4); }
        public _DXVA_NominalRange NominalRange { get => InteropRuntime.Get<_DXVA_NominalRange>(__bits, 12, 3); set => InteropRuntime.Set<_DXVA_NominalRange>(value, __bits, 12, 3); }
        public _DXVA_VideoTransferMatrix VideoTransferMatrix { get => InteropRuntime.Get<_DXVA_VideoTransferMatrix>(__bits, 15, 3); set => InteropRuntime.Set<_DXVA_VideoTransferMatrix>(value, __bits, 15, 3); }
        public _DXVA_VideoLighting VideoLighting { get => InteropRuntime.Get<_DXVA_VideoLighting>(__bits, 18, 4); set => InteropRuntime.Set<_DXVA_VideoLighting>(value, __bits, 18, 4); }
        public _DXVA_VideoPrimaries VideoPrimaries { get => InteropRuntime.Get<_DXVA_VideoPrimaries>(__bits, 22, 5); set => InteropRuntime.Set<_DXVA_VideoPrimaries>(value, __bits, 22, 5); }
        public _DXVA_VideoTransferFunction VideoTransferFunction { get => InteropRuntime.Get<_DXVA_VideoTransferFunction>(__bits, 27, 5); set => InteropRuntime.Set<_DXVA_VideoTransferFunction>(value, __bits, 27, 5); }
    }
}
