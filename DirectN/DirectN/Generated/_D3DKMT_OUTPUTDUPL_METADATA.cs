// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmthk.h(4730,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_OUTPUTDUPL_METADATA
    {
        public uint hAdapter;
        public uint VidPnSourceId;
        public _D3DKMT_OUTPUTDUPL_METADATATYPE Type;
        public uint BufferSizeSupplied;
        public IntPtr pBuffer;
        public uint BufferSizeRequired;
    }
}
