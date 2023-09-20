// generated from <Windows SDK Path>\shared\dxgi1_2.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_OUTDUPL_FRAME_INFO
    {
        public long LastPresentTime;
        public long LastMouseUpdateTime;
        public uint AccumulatedFrames;
        public bool RectsCoalesced;
        public bool ProtectedContentMaskedOut;
        public DXGI_OUTDUPL_POINTER_POSITION PointerPosition;
        public uint TotalMetadataBufferSize;
        public uint PointerShapeBufferSize;
    }
}
