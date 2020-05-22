// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wincodec.h(7111,24)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct WICRawCapabilitiesInfo
    {
        public uint cbSize;
        public uint CodecMajorVersion;
        public uint CodecMinorVersion;
        public WICRawCapabilities ExposureCompensationSupport;
        public WICRawCapabilities ContrastSupport;
        public WICRawCapabilities RGBWhitePointSupport;
        public WICRawCapabilities NamedWhitePointSupport;
        public uint NamedWhitePointSupportMask;
        public WICRawCapabilities KelvinWhitePointSupport;
        public WICRawCapabilities GammaSupport;
        public WICRawCapabilities TintSupport;
        public WICRawCapabilities SaturationSupport;
        public WICRawCapabilities SharpnessSupport;
        public WICRawCapabilities NoiseReductionSupport;
        public WICRawCapabilities DestinationColorProfileSupport;
        public WICRawCapabilities ToneCurveSupport;
        public WICRawRotationCapabilities RotationSupport;
        public WICRawCapabilities RenderModeSupport;
    }
}
