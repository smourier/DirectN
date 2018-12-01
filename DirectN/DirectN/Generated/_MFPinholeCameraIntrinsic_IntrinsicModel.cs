// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfapi.h(3441,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MFPinholeCameraIntrinsic_IntrinsicModel
    {
        public uint Width;
        public uint Height;
        public _MFCameraIntrinsic_PinholeCameraModel CameraModel;
        public _MFCameraIntrinsic_DistortionModel DistortionModel;
    }
}
