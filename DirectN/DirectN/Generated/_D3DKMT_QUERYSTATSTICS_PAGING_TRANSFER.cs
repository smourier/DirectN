// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmthk.h(3510,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYSTATSTICS_PAGING_TRANSFER
    {
        public ulong BytesFilled;
        public ulong BytesDiscarded;
        public ulong BytesMappedIntoAperture;
        public ulong BytesUnmappedFromAperture;
        public ulong BytesTransferredFromMdlToMemory;
        public ulong BytesTransferredFromMemoryToMdl;
        public ulong BytesTransferredFromApertureToMemory;
        public ulong BytesTransferredFromMemoryToAperture;
    }
}
