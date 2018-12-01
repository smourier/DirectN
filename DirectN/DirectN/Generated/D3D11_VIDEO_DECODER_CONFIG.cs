// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11.h(9691,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_VIDEO_DECODER_CONFIG
    {
        public Guid guidConfigBitstreamEncryption;
        public Guid guidConfigMBcontrolEncryption;
        public Guid guidConfigResidDiffEncryption;
        public uint ConfigBitstreamRaw;
        public uint ConfigMBcontrolRasterOrder;
        public uint ConfigResidDiffHost;
        public uint ConfigSpatialResid8;
        public uint ConfigResid8Subtraction;
        public uint ConfigSpatialHost8or9Clipping;
        public uint ConfigSpatialResidInterleaved;
        public uint ConfigIntraResidUnsigned;
        public uint ConfigResidDiffAccelerator;
        public uint ConfigHostInverseScan;
        public uint ConfigSpecificIDCT;
        public uint Config4GroupedCoefs;
        public ushort ConfigMinRenderTargetBuffCount;
        public ushort ConfigDecoderSpecific;
    }
}
