// generated from <Windows SDK Path>\um\spatialaudiohrtf.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct SpatialAudioHrtfActivationParams2
    {
        public IntPtr ObjectFormat;
        public AudioObjectType StaticObjectTypeMask;
        public uint MinDynamicObjectCount;
        public uint MaxDynamicObjectCount;
        public _AUDIO_STREAM_CATEGORY Category;
        public IntPtr EventHandle;
        public IntPtr NotifyObject;
        public IntPtr DistanceDecay;
        public IntPtr Directivity;
        public IntPtr Environment;
        public IntPtr Orientation;
        public SPATIAL_AUDIO_STREAM_OPTIONS Options;
    }
}
