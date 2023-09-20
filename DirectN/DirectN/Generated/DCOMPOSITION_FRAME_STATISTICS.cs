// generated from <Windows SDK Path>\shared\dcomptypes.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DCOMPOSITION_FRAME_STATISTICS
    {
        public long lastFrameTime;
        public DXGI_RATIONAL currentCompositionRate;
        public long currentTime;
        public long timeFrequency;
        public long nextEstimatedFrameTime;
    }
}
