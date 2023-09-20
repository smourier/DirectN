// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MFExtendedCameraIntrinsic_IntrinsicModel
    {
        public uint Width;
        public uint Height;
        public uint SplitFrameId;
        public _MFCameraIntrinsic_CameraModel CameraModel;
    }
}
