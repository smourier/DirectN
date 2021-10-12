// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\spatialaudiometadata.h(175,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct SpatialAudioObjectRenderStreamForMetadataActivationParams2
    {
        public IntPtr ObjectFormat;
        public AudioObjectType StaticObjectTypeMask;
        public uint MinDynamicObjectCount;
        public uint MaxDynamicObjectCount;
        public _AUDIO_STREAM_CATEGORY Category;
        public IntPtr EventHandle;
        public Guid MetadataFormatId;
        public uint MaxMetadataItemCount;
        public IntPtr MetadataActivationParams;
        public IntPtr NotifyObject;
        public SPATIAL_AUDIO_STREAM_OPTIONS Options;
    }
}
