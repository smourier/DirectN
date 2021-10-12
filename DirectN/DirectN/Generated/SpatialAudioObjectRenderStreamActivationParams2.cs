// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\spatialaudioclient.h(171,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct SpatialAudioObjectRenderStreamActivationParams2
    {
        public IntPtr ObjectFormat;
        public AudioObjectType StaticObjectTypeMask;
        public uint MinDynamicObjectCount;
        public uint MaxDynamicObjectCount;
        public _AUDIO_STREAM_CATEGORY Category;
        public IntPtr EventHandle;
        public IntPtr NotifyObject;
        public SPATIAL_AUDIO_STREAM_OPTIONS Options;
    }
}
