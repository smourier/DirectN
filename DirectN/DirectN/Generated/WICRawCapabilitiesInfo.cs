using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct WICRawCapabilitiesInfo
    {
        public int cbSize;
        public int CodecMajorVersion;
        public int CodecMinorVersion;
        public WICRawCapabilities ExposureCompensationSupport;
        public WICRawCapabilities ContrastSupport;
        public WICRawCapabilities RGBWhitePointSupport;
        public WICRawCapabilities NamedWhitePointSupport;
        public int NamedWhitePointSupportMask;
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
