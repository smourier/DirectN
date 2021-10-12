// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfobjects.h(2995,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MFVideoInfo
    {
        public uint dwWidth;
        public uint dwHeight;
        public _MFRatio PixelAspectRatio;
        public _MFVideoChromaSubsampling SourceChromaSubsampling;
        public _MFVideoInterlaceMode InterlaceMode;
        public _MFVideoTransferFunction TransferFunction;
        public _MFVideoPrimaries ColorPrimaries;
        public _MFVideoTransferMatrix TransferMatrix;
        public _MFVideoLighting SourceLighting;
        public _MFRatio FramesPerSecond;
        public _MFNominalRange NominalRange;
        public _MFVideoArea GeometricAperture;
        public _MFVideoArea MinimumDisplayAperture;
        public _MFVideoArea PanScanAperture;
        public ulong VideoFlags;
    }
}
