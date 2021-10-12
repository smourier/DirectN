// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(9226,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARGCB_ISFEATUREENABLED
    {
        public IntPtr DeviceHandle;
        public _DXGK_FEATURE_ID FeatureId;
        public byte Enabled;
    }
}
