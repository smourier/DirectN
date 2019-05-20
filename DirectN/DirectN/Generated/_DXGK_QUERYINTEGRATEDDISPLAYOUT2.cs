// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(2638,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_QUERYINTEGRATEDDISPLAYOUT2
    {
        public _DXGK_INTEGRATEDDISPLAYFLAGS Flags;
        public _D3DKMDT_VIDEO_SIGNAL_INFO NativeTiming;
        public _DXGK_MONITORLINKINFO_CAPABILITIES LinkCapabilities;
        public _DXGK_COLORIMETRY Colorimetry;
        public _DXGK_DISPLAY_TECHNOLOGY DisplayTechnology;
        public _DXGK_DISPLAY_USAGE IntendedUsage;
        public byte Instance;
        public _DXGK_DISPLAY_DESCRIPTOR_TYPE DescriptorType;
        public _D3DKMDT_WIRE_FORMAT_AND_PREFERENCE DitheringSupport;
    }
}
