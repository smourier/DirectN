// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARGCB_QUERYFEATURESUPPORT
    {
        public IntPtr DeviceHandle;
        public _DXGK_FEATURE_ID FeatureId;
        public uint DriverSupportState;
        public byte Enabled;
    }
}
