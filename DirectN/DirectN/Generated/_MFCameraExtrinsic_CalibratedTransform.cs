// generated from <Windows SDK Path>\um\mfapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MFCameraExtrinsic_CalibratedTransform
    {
        public Guid CalibrationId;
        public _MF_FLOAT3 Position;
        public _MF_QUATERNION Orientation;
    }
}
