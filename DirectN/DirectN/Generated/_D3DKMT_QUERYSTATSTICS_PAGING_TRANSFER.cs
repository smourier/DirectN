// generated from <Windows SDK Path>\shared\d3dkmthk.h
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
