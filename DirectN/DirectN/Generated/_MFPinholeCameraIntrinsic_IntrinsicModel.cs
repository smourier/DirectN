// generated from <Windows SDK Path>\um\mfapi.h
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
