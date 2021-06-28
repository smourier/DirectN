// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\dxgi1_2.h(251,9)
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
