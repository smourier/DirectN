// generated from <Windows SDK Path>\shared\d3dkmthk.h
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
