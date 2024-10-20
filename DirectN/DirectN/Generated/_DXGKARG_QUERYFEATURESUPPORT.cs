// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_QUERYFEATURESUPPORT
    {
        public _DXGK_FEATURE_ID FeatureId;
        public ushort MinSupportedVersion;
        public ushort MaxSupportedVersion;
        public byte AllowExperimental;
        public byte SupportedByDriver;
        public byte SupportedOnCurrentConfig;
    }
}
