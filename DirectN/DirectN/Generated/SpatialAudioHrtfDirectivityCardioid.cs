// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\spatialaudiohrtf.h(114,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct SpatialAudioHrtfDirectivityCardioid
    {
        public SpatialAudioHrtfDirectivity directivity;
        public float Order;
    }
}
