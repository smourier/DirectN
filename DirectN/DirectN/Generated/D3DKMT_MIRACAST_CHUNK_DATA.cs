// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(4576,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DKMT_MIRACAST_CHUNK_DATA
    {
        public DXGK_MIRACAST_CHUNK_INFO ChunkInfo;
        public uint PrivateDriverDataSize;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public byte[] PrivateDriverData;
    }
}
