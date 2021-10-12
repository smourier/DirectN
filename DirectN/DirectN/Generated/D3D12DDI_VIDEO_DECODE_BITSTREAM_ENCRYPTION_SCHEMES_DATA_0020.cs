// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(4361,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_DECODE_BITSTREAM_ENCRYPTION_SCHEMES_DATA_0020
    {
        public uint NodeIndex;
        public Guid DecodeProfile;
        public uint EncryptionSchemeCount;
        public IntPtr pEncryptionSchemes;
    }
}
