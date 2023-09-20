// generated from <Windows SDK Path>\um\mfapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MFCameraExtrinsics
    {
        public uint TransformCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public _MFCameraExtrinsic_CalibratedTransform[] CalibratedTransforms;
    }
}
