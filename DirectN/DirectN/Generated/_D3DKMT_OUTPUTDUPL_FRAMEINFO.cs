// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_OUTPUTDUPL_FRAMEINFO
    {
        public long LastPresentTime;
        public long LastMouseUpdateTime;
        public uint AccumulatedFrames;
        public bool RectsCoalesced;
        public bool ProtectedContentMaskedOut;
        public _D3DKMT_OUTPUTDUPL_POINTER_POSITION PointerPosition;
        public uint TotalMetadataBufferSize;
        public uint PointerShapeBufferSize;
    }
}
