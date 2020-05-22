// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\dcomptypes.h(78,9)
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
