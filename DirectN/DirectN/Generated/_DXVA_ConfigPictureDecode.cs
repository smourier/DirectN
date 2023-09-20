// generated from <Windows SDK Path>\um\dxva.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_ConfigPictureDecode
    {
        public uint dwFunction;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)] 
        public uint[] dwReservedBits;
        public Guid guidConfigBitstreamEncryption;
        public Guid guidConfigMBcontrolEncryption;
        public Guid guidConfigResidDiffEncryption;
        public byte bConfigBitstreamRaw;
        public byte bConfigMBcontrolRasterOrder;
        public byte bConfigResidDiffHost;
        public byte bConfigSpatialResid8;
        public byte bConfigResid8Subtraction;
        public byte bConfigSpatialHost8or9Clipping;
        public byte bConfigSpatialResidInterleaved;
        public byte bConfigIntraResidUnsigned;
        public byte bConfigResidDiffAccelerator;
        public byte bConfigHostInverseScan;
        public byte bConfigSpecificIDCT;
        public byte bConfig4GroupedCoefs;
    }
}
